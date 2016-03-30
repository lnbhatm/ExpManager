Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class frmbankupdate

    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet = Nothing
    Dim workbook As Excel.Workbook = Nothing
    Dim filename As String
    Public currentIndex As Integer
    Dim blnExcelOpen As Boolean = False
    Dim enableclear As Boolean = False


    Private Sub cmdload_Click(sender As Object, e As EventArgs) Handles cmdload.Click
        Dim string1 As String
        Dim i As Integer
        currentIndex = 315
        Try
            APP = CType(GetObject(, "Excel.Application"), Excel.Application)
        Catch ex As Exception
            APP = New Excel.Application
        End Try
        blnExcelOpen = True
        With APP
            .DisplayAlerts = False
        End With
        workbook = APP.Workbooks.Open(acountmanager)
        worksheet = workbook.Worksheets("Expenditure")
        For i = 3 To 52
            string1 = worksheet.Cells(i, 2).Value
            If string1 <> "" Then
                cbobankcode.Items.Add(worksheet.Cells(i, 2).Value)
            End If
        Next i
        cmdedit.Enabled = True
        cmdexit.Enabled = True
        cmdload.Enabled = False
        cbobankcode.Enabled = True
        txtbalance.TextAlign = HorizontalAlignment.Right
        txtCredits.TextAlign = HorizontalAlignment.Right
        txtcurcrdt.TextAlign = HorizontalAlignment.Right
        txtcursav.TextAlign = HorizontalAlignment.Right
        txtSavings.TextAlign = HorizontalAlignment.Right
        main.ToolStripStatusLabel.Text = "Load Sucess"
    End Sub

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click

        If cmdsave.Enabled = True Then
            MsgBox("Record Update Failed!", vbCritical, "Update")
        End If
        If blnExcelOpen = True Then
            workbook.Close()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            Marshal.FinalReleaseComObject(worksheet)
            Marshal.FinalReleaseComObject(workbook)
            APP.Quit()
            Marshal.FinalReleaseComObject(APP)
            blnExcelOpen = False
            cbobankcode.Items.Clear()
        End If
        Me.Close()
    End Sub

    Private Sub cbobankcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobankcode.SelectedIndexChanged
        Dim selectedindex As Integer
        Dim x As Integer
        If blnExcelOpen = True Then
            selectedindex = cbobankcode.SelectedIndex
            If selectedindex <= 9 Then
                txtbankcode.Text = "BANK" & "00" & selectedindex
            ElseIf selectedindex > 9 And selectedindex <= 99 Then
                txtbankcode.Text = "BANK" & "0" & selectedindex
            Else
                txtbankcode.Text = "BANK" & selectedindex
            End If

            With worksheet
                If APP.WorksheetFunction.CountA(.Cells) <> 0 Then
                    x = .Range("C1:C580").Find(What:=txtbankcode.Text, LookAt:=Excel.XlLookAt.xlPart, LookIn:=Excel.XlFindLookIn.xlValues, SearchOrder:=Excel.XlSearchOrder.xlByRows, SearchDirection:=Excel.XlSearchDirection.xlPrevious, MatchCase:=False).Row
                End If
            End With
            txtbalance.Text = CType(Val(worksheet.Cells(x, 4).Value), Double).ToString("f2")
            txtSavings.Text = CType(Val(worksheet.Cells(x, 5).Value), Double).ToString("f2")
            txtCredits.Text = CType(Val(worksheet.Cells(x, 6).Value), Double).ToString("f2")
            txtcursav.Text = CType(Val(worksheet.Cells(x, 7).Value), Double).ToString("f2")
            txtcurcrdt.Text = CType(Val(worksheet.Cells(x, 8).Value), Double).ToString("f2")


        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each mycontrol As Control In Me.GroupBox1.Controls
            If TypeOf mycontrol Is TextBox Then
                mycontrol.Enabled = False
            End If
        Next
        cbobankcode.Enabled = False
        cmdedit.Enabled = False
        cmdsave.Enabled = False
        cmdexit.Enabled = True
    End Sub

    Private Sub cmdedit_Click(sender As Object, e As EventArgs) Handles cmdedit.Click
        cmdload.Enabled = False
        cmdsave.Enabled = True
        cmdedit.Enabled = False
        txtCredits.Enabled = True
        txtSavings.Enabled = True
        cbobankcode.Enabled = True
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        Dim x As Integer
        If blnExcelOpen = True Then
            With worksheet
                If APP.WorksheetFunction.CountA(.Cells) <> 0 Then
                    x = .Range("C1:C580").Find(What:=txtbankcode.Text, LookAt:=Excel.XlLookAt.xlPart, LookIn:=Excel.XlFindLookIn.xlValues, SearchOrder:=Excel.XlSearchOrder.xlByRows, SearchDirection:=Excel.XlSearchDirection.xlPrevious, MatchCase:=False).Row
                End If
            End With
            worksheet.Cells(x, 5).Value = txtSavings.Text
            worksheet.Cells(x, 6).Value = txtCredits.Text
            For Each ctr In Me.Controls
                If TypeOf ctr Is TextBox Then
                    If ctr.Text = vbNullString Then
                        MsgBox("Empty String Not Allowed!")
                        ctr.Focus()
                        Exit Sub
                    End If
                End If
            Next ctr
            workbook.Save()
            workbook.Close()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            Marshal.FinalReleaseComObject(worksheet)
            Marshal.FinalReleaseComObject(workbook)
            APP.Quit()
            Marshal.FinalReleaseComObject(APP)
            blnExcelOpen = False
            cbobankcode.Items.Clear()
            MsgBox("Record Updated!", vbInformation, "UPDATE")
        End If
        cmdsave.Enabled = False
        cmdexit.Enabled = True
        cmdload.Enabled = True
        cbobankcode.Text = ""
        cbobankcode.Enabled = False
        For Each mycontrol As Control In Me.GroupBox1.Controls
            If TypeOf mycontrol Is TextBox Then
                mycontrol.Text = ""
                mycontrol.Enabled = False
            End If
        Next
        main.ToolStripStatusLabel.Text = "Save Completed"
    End Sub
End Class