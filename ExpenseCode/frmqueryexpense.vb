Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class frmqueryexpense

    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet = Nothing
    Dim workbook As Excel.Workbook = Nothing
    Dim filename As String
    Dim blnExcelOpen As Boolean = False
    Private clickedCell As DataGridViewCell

    Private Sub ExcelAcountManagerOpen()
        If blnExcelOpen = False Then
            Try
                APP = CType(GetObject(, "Excel.Application"), Excel.Application)
            Catch ex As Exception
                APP = New Excel.Application
            End Try
            With APP
                .DisplayAlerts = False
                .Visible = False
                .Application.EnableEvents = False
            End With
            workbook = APP.Workbooks.Open(acountmanager)
            worksheet = workbook.Worksheets("Expenditure")
            blnExcelOpen = True
        End If
    End Sub

    Private Sub ExcelAcountManagerClose()
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
        End If
    End Sub

    Private Sub frmquery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim lopidx As Integer = TrnStrtIdx
        Dim iRow As Long = 0
        Dim grdidx As Integer = 0
        ExcelAcountManagerOpen()
        With cbobank.Items
            .Add("ItemCode")
            .Add("PayeeBank")
            .Add("Benificiary")
            .Add("Date")
        End With

    End Sub

    Private Sub cbobank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobank.SelectedIndexChanged
        Dim i As Integer
        Dim tempstr As String

        If cbobank.SelectedItem = "ItemCode" Then
            cboexp.Items.Clear()
            For i = 77 To 176
                tempstr = worksheet.Cells(i, 2).Value
                If tempstr <> "" Then
                    cboexp.Items.Add(worksheet.Cells(i, 2).Value)
                End If
            Next i
        ElseIf cbobank.SelectedItem = "PayeeBank" Or cbobank.SelectedItem = "Benificiary" Then
            cboexp.Items.Clear()
            For i = 3 To 52
                tempstr = worksheet.Cells(i, 2).Value
                If tempstr <> "" Then
                    cboexp.Items.Add(worksheet.Cells(i, 2).Value)
                End If
            Next i
        ElseIf cbobank.SelectedItem = "Date" Then
            cboexp.Items.Clear()
            For i = 613 To 643
                tempstr = worksheet.Cells(i, 3).Value
                If tempstr <> "" Then
                    cboexp.Items.Add(Format(worksheet.Cells(i, 3).Value, " dd MMM yyyy"))
                End If
            Next i
        End If
    End Sub

    Private Sub displaydatagrid(ByVal val1 As String, ByVal val2 As String, ByVal val3 As String, ByVal val4 As String, ByVal index As Integer)
        With datadisplay
            .RowHeadersVisible = False
            .Item(0, index).Value = val1
            .Item(1, index).Value = val2
            .Item(2, index).Value = val3
            .Item(3, index).Value = val4
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub displaydatagridheader(ByVal desc As String)
        Dim column As DataGridViewColumn
        With datadisplay.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Black
            .ForeColor = Color.White
            .Font = New Font(datadisplay.Font, FontStyle.Bold)
        End With
        With datadisplay
            .AllowUserToAddRows = True
            .RowHeadersVisible = False
            .ColumnCount = 4
            .ReadOnly = True
            .Columns(0).HeaderText = " SL NO "
            .Columns(1).HeaderText = desc
            .Columns(2).HeaderText = " DATE "
            .Columns(3).HeaderText = " AMOUNT "
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        column = datadisplay.Columns(0)
        column.Width = 80
        column = datadisplay.Columns(1)
        column.Width = 450
        column = datadisplay.Columns(2)
        column.Width = 190
        column = datadisplay.Columns(3)
        column.Width = 100
        datadisplay.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        datadisplay.RowHeadersVisible = False
    End Sub


    Private Sub derivedisplaydatafromcomboselection(ByVal code As String, ByVal coloumnindex As Integer)
        Dim iRow As Long = 0
        Dim grdidx As Integer = 0
        Dim sum As Double = 0
        Dim val1 As String
        Dim val2 As String
        Dim val3 As String
        Dim val4 As String
        datadisplay.Columns.Clear()
        datadisplay.Rows.Clear()
        datadisplay.Refresh()
        With worksheet
            iRow = .Range("B" & .Rows.Count).End(Excel.XlDirection.xlUp).Row
            If iRow = (TrnStrtIdx) Then
                MsgBox("No Transaction yet!", vbInformation, "Record")
            Else
                displaydatagridheader("DESCRIPTION")
                datadisplay.RowCount = iRow - TrnStrtIdx
                For lopidx = TrnStrtIdx To iRow
                    If (worksheet.Cells(lopidx, 2).value <> vbNullString) And code = worksheet.Cells(lopidx, coloumnindex).value Then
                        val1 = worksheet.Cells(lopidx, 1).value
                        val2 = worksheet.Cells(lopidx, 2).value
                        val3 = Format(worksheet.Cells(lopidx, 3).value, " dd MMM yyyy  dddd ")
                        val4 = CType(Val(worksheet.Cells(lopidx, 4).value), Double).ToString("f2")
                        displaydatagrid(val1, val2, val3, val4, grdidx)
                        grdidx = grdidx + 1
                        sum = sum + worksheet.Cells(lopidx, 4).value
                    End If
                Next lopidx
            End If
        End With
        txtsum.Text = CType(sum, Double).ToString("f2")
    End Sub

    Private Sub cboexp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboexp.SelectedIndexChanged
        Dim selectedindex As Integer
        Dim expcode As String
        Dim coloumnindex As Integer
        Dim bankcode As String
        Dim startindex As Integer = 77
        Dim coloumnname As String = "G"
        If cbobank.SelectedItem = "ItemCode" Then
            selectedindex = cboexp.SelectedIndex
            If selectedindex <= 9 Then
                expcode = "CODE" & "00" & selectedindex
            ElseIf selectedindex > 9 And selectedindex <= 99 Then
                expcode = "CODE" & "0" & selectedindex
            Else
                expcode = "CODE" & selectedindex
            End If
            coloumnindex = 5
            derivedisplaydatafromcomboselection(expcode, coloumnindex)
            txtavail.Text = worksheet.Cells(startindex + selectedindex, 6).value - worksheet.Cells(startindex + selectedindex, 11).value
        ElseIf cbobank.SelectedItem = "PayeeBank" Then
            selectedindex = cboexp.SelectedIndex
            If selectedindex <= 9 Then
                bankcode = "BANK" & "00" & selectedindex
            ElseIf selectedindex > 9 And selectedindex <= 99 Then
                bankcode = "BANK" & "0" & selectedindex
            Else
                bankcode = "BANK" & selectedindex
            End If
            coloumnindex = 6
            derivedisplaydatafromcomboselection(bankcode, coloumnindex)
        ElseIf cbobank.SelectedItem = "Benificiary" Then
            selectedindex = cboexp.SelectedIndex
            If selectedindex <= 9 Then
                bankcode = "BANK" & "00" & selectedindex
            ElseIf selectedindex > 9 And selectedindex <= 99 Then
                bankcode = "BANK" & "0" & selectedindex
            Else
                bankcode = "BANK" & selectedindex
            End If
            coloumnindex = 7
            derivedisplaydatafromcomboselection(bankcode, coloumnindex)
        ElseIf cbobank.SelectedItem = "Date" Then
            coloumnindex = 3
            derivedisplaydatafromcomboselection(cboexp.SelectedItem, coloumnindex)
        End If

    End Sub

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        ExcelAcountManagerClose()
        Me.Close()
    End Sub
End Class