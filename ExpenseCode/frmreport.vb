Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class frmreport
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet = Nothing
    Dim workbook As Excel.Workbook = Nothing
    Dim myRecordopen As Boolean = False
    Dim cmdaddclicked As Boolean = False
    Private Sub frmcashdist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctr As Control
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Enabled = False
            End If
        Next ctr

        cmdload.Enabled = True
        cmdupdate.Enabled = False
        cmdexit.Enabled = True
        cmdsave.Enabled = False
        cboAccount.Enabled = False
        cmdAdd.Enabled = False
        cmdupdate1.Enabled = False
        cboAccount.Items.Add("GIRISH")
        cboAccount.Items.Add("KARTHIK")
        cboAccount.Items.Add("SHUBHA")
        cboAccount.Items.Add("OTHER")
        cboAccount.Items.Add("RESERVED COINS")
        cboAccount.Items.Add("RESERVED NOTES")
        cboAccount.Items.Add("COINS IN USE")
        cboAccount.Items.Add("CALCULATOR")
        cboAccount.Sorted = True

    End Sub

    Private Sub ExcelAcountManagerOpen()
        Try
            APP = CType(GetObject(, "Excel.Application"), Excel.Application)
        Catch ex As Exception
            APP = New Excel.Application
        End Try
        With APP
            .DisplayAlerts = False
            .Visible = False
        End With
        workbook = APP.Workbooks.Open(acountmanager)
        worksheet = workbook.Worksheets("Expenditure")
        myRecordopen = True
    End Sub

    Private Sub ExcelAcountManagerClose()
        If myRecordopen = True Then
            workbook.Close()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            Marshal.FinalReleaseComObject(worksheet)
            Marshal.FinalReleaseComObject(workbook)
            APP.Quit()
            Marshal.FinalReleaseComObject(APP)
        End If
    End Sub



    Private Sub sumofcalculation(ByVal txtcontrol1 As TextBox, ByVal txtcontrol2 As TextBox)
        Dim sum As Double = 0.0
        If txtcontrol1.Text <> vbNullString And DataValidation(txtcontrol1) <> False Then
            If Val(txtcontrol1.Text) > Val(txtAccount.Text) And cmdaddclicked = False Then
                MsgBox("Available Amount: " + vbTab + txtAccount.Text + Environment.NewLine + "Amount Spent: " + vbTab + _
                    CType(Val(txtcontrol1.Text), Double).ToString("f2") + Environment.NewLine + "Amount Requested is More than Available", _
                       vbCritical, "ERROR")
                txtcontrol1.Text = ""
                txtcontrol1.Focus()
                Exit Sub
            End If
            If Val(txtsum.Text) > 0 Then
                cmdupdate1.Enabled = True
            End If
        Else
            txtcontrol1.Focus()
            Exit Sub
        End If
        sum = Val(txtvar1.Text) + Val(txtvar2.Text) + Val(txtvar3.Text) + Val(txtvar4.Text) + Val(txtvar5.Text) + _
               Val(txtvar6.Text) + Val(txtvar7.Text) + Val(txtvar8.Text) + Val(txtvar9.Text) + Val(txtvar10.Text) + _
               Val(txtvar11.Text) + Val(txtvar12.Text) + Val(txtvar13.Text) + Val(txtvar14.Text) + Val(txtvar15.Text) + _
               Val(txtvar16.Text)
        If cboAccount.Text <> "CALCULATOR" And cmdaddclicked = False Then
            sum = Val(txtAccount.Text) - sum
        ElseIf cboAccount.Text <> "CALCULATOR" And cmdaddclicked = True Then
            sum = Val(txtAccount.Text) + sum
        End If
        If (sum < 0) Then
            MsgBox("Please Check Your Balance and then try again", vbCritical, "Insufficient Balance")
            txtcontrol2.Enabled = False
            txtcontrol1.Enabled = False
            txtcontrol1.Text = ""
            cmdupdate1.Enabled = True
            Exit Sub
        End If
        txtsum.Text = sum
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdload.Click
        Dim rowindex As Integer = 0
        ExcelAcountManagerOpen()
        If myRecordopen = True Then
            With worksheet
                If APP.WorksheetFunction.CountA(.Cells) <> 0 Then
                    rowindex = .Range("B1:B580").Find(What:="Reserved Coins", LookAt:=Excel.XlLookAt.xlPart, LookIn:=Excel.XlFindLookIn.xlValues, SearchOrder:=Excel.XlSearchOrder.xlByRows, SearchDirection:=Excel.XlSearchDirection.xlPrevious, MatchCase:=False).Row
                End If
            End With
            txtreservedcoin.Text = Decimal.Round(worksheet.Cells(rowindex, 3).Value, 2).ToString("f2")
            txtreservednotes.Text = Decimal.Round(worksheet.Cells(rowindex + 1, 3).Value, 2).ToString("f2")
            txtusagecoin.Text = Decimal.Round(worksheet.Cells(rowindex + 2, 3).Value, 2).ToString("f2")
            txtgirish.Text = Decimal.Round(worksheet.Cells(rowindex + 3, 3).Value, 2).ToString("f2")
            txtshubha.Text = Decimal.Round(worksheet.Cells(rowindex + 4, 3).Value, 2).ToString("f2")
            txtkarthik.Text = Decimal.Round(worksheet.Cells(rowindex + 5, 3).Value, 2).ToString("f2")
            txtother.Text = Decimal.Round(worksheet.Cells(rowindex + 6, 3).Value, 2).ToString("f2")
            txtcshinhand.Text = Decimal.Round(worksheet.Cells(rowindex + 7, 3).Value, 2).ToString("f2")
            txtcshsystem.Text = Decimal.Round(worksheet.Cells(rowindex + 8, 3).Value, 2).ToString("f2")
            txtcshtally.Text = Decimal.Round(worksheet.Cells(rowindex + 9, 3).Value, 2).ToString("f2")
            txtcshonly.Text = Decimal.Round(worksheet.Cells(rowindex + 10, 3).Value, 2).ToString("f2")
            txttotcoin.Text = Decimal.Round(worksheet.Cells(rowindex + 11, 3).Value, 2).ToString("f2")
            txttotcash.Text = Decimal.Round(worksheet.Cells(rowindex + 12, 3).Value, 2).ToString("f2")
            cmdupdate.Enabled = True
            cmdload.Enabled = False
            cboAccount.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        ExcelAcountManagerClose()
        Me.Close()
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Dim rowindex As Integer = 0
        If myRecordopen = True Then
            With worksheet
                If APP.WorksheetFunction.CountA(.Cells) <> 0 Then
                    rowindex = .Range("B1:B580").Find(What:="Reserved Coins", LookAt:=Excel.XlLookAt.xlPart, LookIn:=Excel.XlFindLookIn.xlValues, SearchOrder:=Excel.XlSearchOrder.xlByRows, SearchDirection:=Excel.XlSearchDirection.xlPrevious, MatchCase:=False).Row
                End If
            End With
            txtreservedcoin.Text = Decimal.Round(worksheet.Cells(rowindex, 3).Value, 2).ToString("f2")
            txtreservednotes.Text = Decimal.Round(worksheet.Cells(rowindex + 1, 3).Value, 2).ToString("f2")
            txtusagecoin.Text = Decimal.Round(worksheet.Cells(rowindex + 2, 3).Value, 2).ToString("f2")
            txtgirish.Text = Decimal.Round(worksheet.Cells(rowindex + 3, 3).Value, 2).ToString("f2")
            txtshubha.Text = Decimal.Round(worksheet.Cells(rowindex + 4, 3).Value, 2).ToString("f2")
            txtkarthik.Text = Decimal.Round(worksheet.Cells(rowindex + 5, 3).Value, 2).ToString("f2")
            txtother.Text = Decimal.Round(worksheet.Cells(rowindex + 6, 3).Value, 2).ToString("f2")
            txtcshinhand.Text = Decimal.Round(worksheet.Cells(rowindex + 7, 3).Value, 2).ToString("f2")
            txtcshsystem.Text = Decimal.Round(worksheet.Cells(rowindex + 8, 3).Value, 2).ToString("f2")
            txtcshtally.Text = Decimal.Round(worksheet.Cells(rowindex + 9, 3).Value, 2).ToString("f2")
            txtcshonly.Text = Decimal.Round(worksheet.Cells(rowindex + 10, 3).Value, 2).ToString("f2")
            txttotcoin.Text = Decimal.Round(worksheet.Cells(rowindex + 11, 3).Value, 2).ToString("f2")
            txttotcash.Text = Decimal.Round(worksheet.Cells(rowindex + 12, 3).Value, 2).ToString("f2")
            cmdupdate.Enabled = False
            cmdload.Enabled = False
            cmdsave.Enabled = True
            cboAccount.Enabled = True
        End If
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        Dim rowindex As Integer = 0
        If MsgBox("Are Your Sure You Want to Save the Changes?", vbYesNo, "Update") = vbYes Then
            If myRecordopen = True Then
                With worksheet
                    If APP.WorksheetFunction.CountA(.Cells) <> 0 Then
                        rowindex = .Range("B1:B580").Find(What:="Reserved Coins", LookAt:=Excel.XlLookAt.xlPart, LookIn:=Excel.XlFindLookIn.xlValues, SearchOrder:=Excel.XlSearchOrder.xlByRows, SearchDirection:=Excel.XlSearchDirection.xlPrevious, MatchCase:=False).Row
                    End If
                End With
                worksheet.Cells(rowindex, 3).Value = txtreservedcoin.Text
                worksheet.Cells(rowindex + 1, 3).Value = txtreservednotes.Text
                worksheet.Cells(rowindex + 2, 3).Value = txtusagecoin.Text
                worksheet.Cells(rowindex + 3, 3).Value = txtgirish.Text
                worksheet.Cells(rowindex + 4, 3).Value = txtshubha.Text
                worksheet.Cells(rowindex + 5, 3).Value = txtkarthik.Text
                worksheet.Cells(rowindex + 6, 3).Value = txtother.Text
                workbook.Save()
                cmdupdate.Enabled = True
                cboAccount.Enabled = False
                cboAccount.Text = ""
                Dim ctr As Control
                For Each ctr In Me.Controls
                    If TypeOf ctr Is TextBox Then
                        ctr.Enabled = False
                        ctr.Text = ""
                    End If
                Next ctr
            Else
                MsgBox("Record is closed")
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cboAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccount.SelectedIndexChanged
        Dim ctr As Control
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                If ctr.Name.StartsWith("txtvar") Then
                    ctr.Text = ""
                    ctr.Enabled = False
                End If
            End If
        Next ctr
        cmdaddclicked = False
        If cboAccount.Text = "GIRISH" Then
            txtAccount.Text = txtgirish.Text
        ElseIf cboAccount.Text = "SHUBHA" Then
            txtAccount.Text = txtshubha.Text
        ElseIf cboAccount.Text = "KARTHIK" Then
            txtAccount.Text = txtkarthik.Text
        ElseIf cboAccount.Text = "OTHER" Then
            txtAccount.Text = txtother.Text
        ElseIf cboAccount.Text = "CALCULATOR" Then
            txtAccount.Text = ""
            txtvar1.Enabled = True
            txtvar1.Focus()
            cmdaddclicked = True

        ElseIf cboAccount.Text = "RESERVED COINS" Then
            txtAccount.Text = txtreservedcoin.Text
        ElseIf cboAccount.Text = "RESERVED NOTES" Then
            txtAccount.Text = txtreservednotes.Text
        ElseIf cboAccount.Text = "COINS IN USE" Then
            txtAccount.Text = txtusagecoin.Text
        End If
        If cboAccount.Text <> "CALCULATOR" Then
            If Val(txtAccount.Text) > 0 Then
                txtvar1.Enabled = True
                cmdupdate1.Enabled = True
            Else
                txtvar1.Enabled = False
                cmdupdate1.Enabled = False
            End If
        End If
        txtsum.Text = Val(txtAccount.Text)
        cboAccount.Enabled = False
        cmdupdate1.Enabled = False
        cmdAdd.Enabled = True
    End Sub

    Private Function DataValidation(ByVal txtctl As TextBox) As Boolean
        Dim bReturnValue As Boolean = True
        If IsNumeric(txtctl.Text) = False Then
            txtctl.BackColor = Color.Red
            MsgBox("Please enter a number for value1", vbCritical, "Amount")

            txtctl.BackColor = Color.White
            bReturnValue = False
            txtctl.Text = ""
            DataValidation = bReturnValue
            Exit Function
        End If
        DataValidation = True
    End Function

    Private Sub updatedvalue()

        Dim rowindex As Integer = 0
        If myRecordopen = True Then
            With worksheet
                If APP.WorksheetFunction.CountA(.Cells) <> 0 Then
                    rowindex = .Range("B1:B580").Find(What:="Reserved Coins", LookAt:=Excel.XlLookAt.xlPart, LookIn:=Excel.XlFindLookIn.xlValues, SearchOrder:=Excel.XlSearchOrder.xlByRows, SearchDirection:=Excel.XlSearchDirection.xlPrevious, MatchCase:=False).Row
                End If
            End With

            txtreservedcoin.Text = Decimal.Round(worksheet.Cells(rowindex, 3).Value, 2).ToString("f2")
            txtreservednotes.Text = Decimal.Round(worksheet.Cells(rowindex + 1, 3).Value, 2).ToString("f2")
            txtusagecoin.Text = Decimal.Round(worksheet.Cells(rowindex + 2, 3).Value, 2).ToString("f2")
            txtgirish.Text = Decimal.Round(worksheet.Cells(rowindex + 3, 3).Value, 2).ToString("f2")
            txtshubha.Text = Decimal.Round(worksheet.Cells(rowindex + 4, 3).Value, 2).ToString("f2")
            txtkarthik.Text = Decimal.Round(worksheet.Cells(rowindex + 5, 3).Value, 2).ToString("f2")
            txtother.Text = Decimal.Round(worksheet.Cells(rowindex + 6, 3).Value, 2).ToString("f2")
            txtcshinhand.Text = Decimal.Round(worksheet.Cells(rowindex + 7, 3).Value, 2).ToString("f2")
            txtcshsystem.Text = Decimal.Round(worksheet.Cells(rowindex + 8, 3).Value, 2).ToString("f2")
            txtcshtally.Text = Decimal.Round(worksheet.Cells(rowindex + 9, 3).Value, 2).ToString("f2")
            txtcshonly.Text = Decimal.Round(worksheet.Cells(rowindex + 10, 3).Value, 2).ToString("f2")
            txttotcoin.Text = Decimal.Round(worksheet.Cells(rowindex + 11, 3).Value, 2).ToString("f2")
            txttotcash.Text = Decimal.Round(worksheet.Cells(rowindex + 12, 3).Value, 2).ToString("f2")

        End If
    End Sub





    Private Sub txtvar1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar1, txtvar2)
            cmdAdd.Enabled = False
        End If
    End Sub

    Private Sub txtvar2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar2.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar2, txtvar3)
        End If
    End Sub

    Private Sub txtvar3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar3.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar3, txtvar4)
        End If
    End Sub


    Private Sub txtvar4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar4.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar4, txtvar5)
        End If
    End Sub

    Private Sub txtvar5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar5.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar5, txtvar6)
        End If
    End Sub


    Private Sub txtvar6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar6.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar6, txtvar7)
        End If
    End Sub

    Private Sub txtvar7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar7.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar7, txtvar8)
        End If
    End Sub

    Private Sub txtvar8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar8.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar8, txtvar9)
        End If
    End Sub

    Private Sub txtvar9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar9.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar9, txtvar10)
        End If
    End Sub

    Private Sub txtvar10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar10.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar10, txtvar11)
        End If
    End Sub

    Private Sub txtvar11_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar11.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar11, txtvar12)
        End If
    End Sub

    Private Sub txtvar12_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar12.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar12, txtvar13)
        End If
    End Sub

    Private Sub txtvar13_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar13.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar13, txtvar14)
        End If
    End Sub

    Private Sub txtvar14_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar14.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar14, txtvar15)
        End If
    End Sub

    Private Sub txtvar15_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar15.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar15, txtvar16)
        End If
    End Sub

    Private Sub txtvar16_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvar16.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sumofcalculation(txtvar16, txtvar16)
        End If
    End Sub

    Private Sub cmdupdate1_Click(sender As Object, e As EventArgs) Handles cmdupdate1.Click
        If cboAccount.Text = "CALCULATOR" Then
            EnableNextTextBox(txtvar1, txtvar2)
            EnableNextTextBox(txtvar2, txtvar3)
            EnableNextTextBox(txtvar3, txtvar4)
            EnableNextTextBox(txtvar4, txtvar5)
            EnableNextTextBox(txtvar5, txtvar6)
            EnableNextTextBox(txtvar6, txtvar7)
            EnableNextTextBox(txtvar7, txtvar8)
            EnableNextTextBox(txtvar8, txtvar9)
            EnableNextTextBox(txtvar9, txtvar10)
            EnableNextTextBox(txtvar10, txtvar11)
            EnableNextTextBox(txtvar11, txtvar12)
            EnableNextTextBox(txtvar12, txtvar13)
            EnableNextTextBox(txtvar13, txtvar14)
            EnableNextTextBox(txtvar14, txtvar15)
            EnableNextTextBox(txtvar15, txtvar16)
            If txtvar16.Enabled = True Then
                cmdupdate1.Enabled = True
            Else
                cmdupdate1.Enabled = False
            End If
        Else
            If MsgBox("Are You Sure You Want to Upate?", vbYesNo + vbCritical, "Distribution Update") = vbYes Then

                If cboAccount.Text = "GIRISH" Then
                    If MsgBox("Girish Balance: " & Val(txtgirish.Text) & " New Balance: " & Val(txtsum.Text), vbCritical + vbYesNo, "Confirm Update") = vbYes Then
                        txtgirish.Text = CType(Val(txtsum.Text), Double).ToString("f2")
                        cmdupdate1.Enabled = False
                    Else
                        Exit Sub
                    End If
                ElseIf cboAccount.Text = "KARTHIK" Then
                    If MsgBox("Karthik Balance: " & Val(txtkarthik.Text) & " New Balance: " & Val(txtsum.Text), vbCritical + vbYesNo, "Confirm Update") = vbYes Then
                        txtkarthik.Text = CType(Val(txtsum.Text), Double).ToString("f2")
                        cmdupdate1.Enabled = False
                    Else
                        Exit Sub
                    End If
                ElseIf cboAccount.Text = "SHUBHA" Then
                    If MsgBox("Shubha Balance: " & Val(txtshubha.Text) & " New Balance: " & Val(txtsum.Text), vbCritical + vbYesNo, "Confirm Update") = vbYes Then
                        txtshubha.Text = CType(Val(txtsum.Text), Double).ToString("f2")
                        cmdupdate1.Enabled = False
                    Else
                        Exit Sub
                    End If
                ElseIf cboAccount.Text = "OTHER" Then
                    If MsgBox("Other Balance: " & Val(txtother.Text) & " New Balance: " & Val(txtsum.Text), vbCritical + vbYesNo, "Confirm Update") = vbYes Then
                        txtother.Text = CType(Val(txtsum.Text), Double).ToString("f2")
                        cmdupdate1.Enabled = False
                    Else
                        Exit Sub
                    End If

                ElseIf cboAccount.Text = "RESERVED COINS" Then
                    If MsgBox("Reserved Coins Balance: " & Val(txtreservedcoin.Text) & " New Balance: " & Val(txtsum.Text), vbCritical + vbYesNo, "Confirm Update") = vbYes Then
                        txtreservedcoin.Text = CType(Val(txtsum.Text), Double).ToString("f2")
                        cmdupdate1.Enabled = False
                    Else
                        Exit Sub
                    End If

                ElseIf cboAccount.Text = "RESERVED NOTES" Then
                    If MsgBox("Reserved Notes Balance: " & Val(txtreservednotes.Text) & " New Balance: " & Val(txtsum.Text), vbYesNo, "Confirm Update") = vbYes Then
                        txtreservednotes.Text = CType(Val(txtsum.Text), Double).ToString("f2")
                        cmdupdate1.Enabled = False
                    Else
                        Exit Sub
                    End If


                ElseIf cboAccount.Text = "COINS IN USE" Then
                    If MsgBox("Daily Use Coins Balance: " & Val(txtusagecoin.Text) & " New Balance: " & Val(txtsum.Text), vbCritical + vbYesNo, "Confirm Update") = vbYes Then
                        txtusagecoin.Text = CType(Val(txtsum.Text), Double).ToString("f2")
                        cmdupdate1.Enabled = False
                    Else
                        Exit Sub
                    End If

                End If
            Else
                EnableNextTextBox(txtvar1, txtvar2)
                EnableNextTextBox(txtvar2, txtvar3)
                EnableNextTextBox(txtvar3, txtvar4)
                EnableNextTextBox(txtvar4, txtvar5)
                EnableNextTextBox(txtvar5, txtvar6)
                EnableNextTextBox(txtvar6, txtvar7)
                EnableNextTextBox(txtvar7, txtvar8)
                EnableNextTextBox(txtvar8, txtvar9)
                EnableNextTextBox(txtvar9, txtvar10)
                EnableNextTextBox(txtvar10, txtvar11)
                EnableNextTextBox(txtvar11, txtvar12)
                EnableNextTextBox(txtvar12, txtvar13)
                EnableNextTextBox(txtvar13, txtvar14)
                EnableNextTextBox(txtvar14, txtvar15)
                EnableNextTextBox(txtvar15, txtvar16)
                If txtvar16.Enabled = True Then
                    cmdupdate1.Enabled = True
                Else
                    cmdupdate1.Enabled = False
                End If
            End If
        End If
        cboAccount.Enabled = True
    End Sub


    Private Sub EnableNextTextBox(ByVal txtcurbox As TextBox, ByVal txtnextbox As TextBox)
        If txtnextbox.Text = vbNullString And txtcurbox.Text <> vbNullString Then
            txtnextbox.Enabled = True
            txtnextbox.Focus()
        End If
    End Sub


    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        cmdaddclicked = True
        cmdAdd.Enabled = False
        txtvar1.Enabled = True
        txtvar1.Focus()
    End Sub


    Private Sub cmdreport_Click(sender As Object, e As EventArgs) Handles cmdreport.Click
        Dim iRow As Long = 0
        Dim inext As Long = 582
        Dim inext2 As Long = 595
        Dim rptdir As String = My.Application.Info.DirectoryPath & "\..\statements"
        Dim rptencFilename As String
        Dim rptclearFilename As String = My.Application.Info.DirectoryPath & "\tmpreport"
        Dim rptmetaFilename As String = My.Application.Info.DirectoryPath & "\tmpmetareport.pdf"
        Dim metadatatxt As String = My.Application.Info.DirectoryPath & "\metadata.txt"
        Dim thisDate As Date = Today
        Dim dirnamedate As String = thisDate
        Dim curyear As Integer = Year(thisDate)
        Dim curmonth As Integer = Month(thisDate)
        Dim strProgramName As String = My.Application.Info.DirectoryPath & "\pdftk.exe"
        Dim pdftk As New Process()
        Dim Pwduser As String = "aitpb3106f"
        Dim Pwdowner As String = "india21"

        If (curmonth >= 1 And curmonth <= 3) Then
            dirnamedate = Trim(Str(curyear - 1)) & "_" & Trim(Str(curyear))
        ElseIf (curmonth >= 4 And curmonth <= 12) Then
            dirnamedate = Trim(Str(curyear)) & "_" & Trim(Str(curyear + 1))
        End If
        rptdir = rptdir & "\" & dirnamedate
        If My.Computer.FileSystem.DirectoryExists(rptdir) = False Then
            My.Computer.FileSystem.CreateDirectory(rptdir)
        End If
        If My.Computer.FileSystem.DirectoryExists(rptdir) = False Then
            My.Computer.FileSystem.CreateDirectory(rptdir)
        End If

        rptdir = rptdir & "\" & Format(thisDate, "MM") & UCase(Format(thisDate, "MMM")) & curyear
        If My.Computer.FileSystem.DirectoryExists(rptdir) = False Then
            My.Computer.FileSystem.CreateDirectory(rptdir)
        End If
        ExcelAcountManagerOpen()
        If myRecordopen = True Then
            main.ToolStripStatusLabel.Text = "Printing the Statement"
            With worksheet
                iRow = .Range("B" & .Rows.Count).End(Excel.XlDirection.xlUp).Row
                worksheet.Cells(inext, 1).value = "PERSONAL LOAN TAKEN / PERSONAL LOAN RECOVERED"
                inext = inext + 1
                worksheet.Cells(inext2, 1).value = "PERSONAL LOAN TAKEN / PERSONAL LOAN RECOVERED"
                inext2 = inext2 + 1
                For lopidx = 315 To iRow
                    If worksheet.Cells(lopidx, 6).value = "BANK025" Then
                        worksheet.Cells(inext, 2).value = worksheet.Cells(lopidx, 2).value
                        worksheet.Cells(inext, 3).value = worksheet.Cells(lopidx, 3).value
                        worksheet.Cells(inext, 4).value = worksheet.Cells(lopidx, 4).value
                        inext = inext + 1
                    ElseIf worksheet.Cells(lopidx, 7).value = "BANK025" Then

                        worksheet.Cells(inext2, 2).value = worksheet.Cells(lopidx, 2).value
                        worksheet.Cells(inext2, 3).value = worksheet.Cells(lopidx, 3).value
                        worksheet.Cells(inext2, 4).value = worksheet.Cells(lopidx, 4).value
                        inext2 = inext2 + 1
                    End If
                Next
            End With

            With worksheet
                .PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait
                .PageSetup.PaperSize = Excel.XlPaperSize.xlPaperA4
                .PageSetup.PrintArea = "$A$181:$D$" & iRow & ",$A$581:$D$646"
                .PageSetup.FitToPagesTall = False
                .PageSetup.FitToPagesWide = False
                .PageSetup.Zoom = 81
                .ExportAsFixedFormat(Type:=Excel.XlFixedFormatType.xlTypePDF, Quality:=Excel.XlFixedFormatQuality.xlQualityStandard, Filename:=rptclearFilename, IncludeDocProperties:=True, IgnorePrintAreas:=False, OpenAfterPublish:=False)
            End With
            rptencFilename = rptdir & "\" & Format(worksheet.Cells(183, 2).value, "yyyy_MM_dd") & ".pdf"
        Else
            rptencFilename = rptdir ' resolve compiler warning , better code needs to be written
        End If

        rptclearFilename = rptclearFilename & ".pdf"
        Dim org1 As String = rptclearFilename
        Dim org2 As String = rptmetaFilename
        '----------------------------------------------------------------------------
        metadatatxt = """" & metadatatxt & """"
        rptmetaFilename = """" & rptmetaFilename & """"
        pdftk.StartInfo.FileName = """" & strProgramName & """"
        pdftk.StartInfo.Arguments = rptclearFilename & " update_info " & metadatatxt & " Output " & rptmetaFilename
        pdftk.StartInfo.UseShellExecute = False
        pdftk.StartInfo.RedirectStandardOutput = False
        pdftk.StartInfo.CreateNoWindow = True
        pdftk.Start()
        pdftk.WaitForExit()
        '----------------------------------------------------------------------------
        'Password Protect the Report file.
        '----------------------------------------------------------------------------
        main.ToolStripStatusLabel.Text = "Protected Statement Generation"
        rptencFilename = """" & rptencFilename & """"
        Pwduser = """" & Pwduser & """"
        Pwdowner = """" & Pwdowner & """"
        '----------------------------------------------------------------------------
        pdftk.StartInfo.FileName = """" & strProgramName & """"
        pdftk.StartInfo.Arguments = rptmetaFilename & " Output " & rptencFilename & " Owner_pw " & Pwdowner & " User_pw " & Pwduser & " Allow Printing"
        pdftk.StartInfo.UseShellExecute = False
        pdftk.StartInfo.RedirectStandardOutput = False
        pdftk.StartInfo.CreateNoWindow = True
        pdftk.Start()
        pdftk.WaitForExit()

        If pdftk.ExitCode = 0 Then
            If My.Computer.FileSystem.FileExists(org1) Then
                My.Computer.FileSystem.DeleteFile(org1)
            End If
            If My.Computer.FileSystem.FileExists(org2) Then
                My.Computer.FileSystem.DeleteFile(org2)
            End If
        End If
        main.ToolStripStatusLabel.Text = "Protected Statement Generated." & pdftk.ExitCode
    End Sub
End Class