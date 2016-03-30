Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Public Class frmbankbal

    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet = Nothing
    Dim workbook As Excel.Workbook = Nothing
    Dim filename As String
    Dim blnExcelOpen As Boolean = False



    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        ExcelAcountManagerClose()
        Me.Close()
    End Sub


    Private Sub frmbankdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sum As Double = 0.0
        cbobnktype.Items.Add("GIRISH SB")
        cbobnktype.Items.Add("GIRISH CR")
        cbobnktype.Items.Add("SHUBHA SB")
        cbobnktype.Items.Add("KARTHIK SB")
        cbobnktype.Items.Add("MPHASIS PF")
        cbobnktype.Items.Add("CASH")
        ExcelAcountManagerOpen()
        init_header(gridbankdata, "Bank", 10)
        show_grid(worksheet.Cells(3, 2).value, worksheet.Cells(3, 4).value, 0)
        show_grid(worksheet.Cells(4, 2).value, worksheet.Cells(4, 4).value, 1)
        show_grid(worksheet.Cells(6, 2).value, worksheet.Cells(6, 4).value, 2)
        show_grid(worksheet.Cells(9, 2).value, worksheet.Cells(9, 4).value, 3)
        show_grid(worksheet.Cells(10, 2).value, worksheet.Cells(10, 4).value, 4)
        show_grid(worksheet.Cells(11, 2).value, worksheet.Cells(11, 4).value, 5)
        show_grid(worksheet.Cells(18, 2).value, worksheet.Cells(18, 4).value, 6)
        show_grid(worksheet.Cells(19, 2).value, worksheet.Cells(19, 4).value, 7)
        show_grid(worksheet.Cells(23, 2).value, worksheet.Cells(23, 4).value, 8)
        show_grid(worksheet.Cells(24, 2).value, worksheet.Cells(24, 4).value, 9)
        For Each row As DataGridViewRow In gridbankdata.Rows
            sum = sum + row.Cells(1).Value
        Next
        txtsum.Text = sum
        txtsum.TextAlign = HorizontalAlignment.Center
    End Sub


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

    Private Sub init_header(ByVal ctl As Control, ByVal desc As String, ByVal nrRow As Integer)
        Dim column As DataGridViewColumn
        With gridbankdata.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Black
            .ForeColor = Color.White
            .Font = New Font(gridbankdata.Font, FontStyle.Bold)
        End With
        With gridbankdata
            .AllowUserToAddRows = True
            .RowHeadersVisible = False
            .ColumnCount = 2
            .RowCount = nrRow
            .ReadOnly = True
            .Columns(0).HeaderText = " BANK NAME "
            .Columns(1).HeaderText = " AMOUNT "
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        column = gridbankdata.Columns(0)
        column.Width = 520
        column = gridbankdata.Columns(1)
        column.Width = 150
        gridbankdata.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        gridbankdata.RowHeadersVisible = False
    End Sub
    Private Sub show_grid(ByVal val1 As String, ByVal val2 As Double, ByVal index As Integer)
        With gridbankdata
            .RowHeadersVisible = False
            .Item(0, index).Value = val1
            .Item(1, index).Value = CType(val2, Double).ToString("f2") & "   "
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub cbobnktype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobnktype.SelectedIndexChanged
        Dim sum As Double = 0.0
        Dim loc As Integer = 0
        If cbobnktype.Text = "GIRISH SB" Then
            init_header(gridbankdata, "Bank", 6)
            show_grid(worksheet.Cells(3, 2).value, worksheet.Cells(3, 4).value, 0)
            show_grid(worksheet.Cells(4, 2).value, worksheet.Cells(4, 4).value, 1)
            show_grid(worksheet.Cells(6, 2).value, worksheet.Cells(6, 4).value, 2)
            show_grid(worksheet.Cells(9, 2).value, worksheet.Cells(9, 4).value, 3)
            show_grid(worksheet.Cells(10, 2).value, worksheet.Cells(10, 4).value, 4)
            show_grid(worksheet.Cells(11, 2).value, worksheet.Cells(11, 4).value, 5)
        ElseIf cbobnktype.Text = "GIRISH CR" Then
            init_header(gridbankdata, "Bank", 4)
            show_grid(worksheet.Cells(14, 2).value, worksheet.Cells(14, 4).value, 0)
            show_grid(worksheet.Cells(15, 2).value, worksheet.Cells(15, 4).value, 1)
            show_grid(worksheet.Cells(16, 2).value, worksheet.Cells(16, 4).value, 2)
            show_grid(worksheet.Cells(17, 2).value, worksheet.Cells(17, 4).value, 3)
        ElseIf cbobnktype.Text = "SHUBHA SB" Then
            init_header(gridbankdata, "Bank", 3)
            show_grid(worksheet.Cells(18, 2).value, worksheet.Cells(18, 4).value, 0)
            show_grid(worksheet.Cells(19, 2).value, worksheet.Cells(19, 4).value, 1)
            show_grid(worksheet.Cells(23, 2).value, worksheet.Cells(23, 4).value, 2)
        ElseIf cbobnktype.Text = "KARTHIK SB" Then
            init_header(gridbankdata, "Bank", 2)
            show_grid(worksheet.Cells(24, 2).value, worksheet.Cells(24, 4).value, 0)
            show_grid(worksheet.Cells(25, 2).value, worksheet.Cells(25, 4).value, 1)
        ElseIf cbobnktype.Text = "CASH" Then
            init_header(gridbankdata, "Bank", 1)
            show_grid(worksheet.Cells(27, 2).value, worksheet.Cells(27, 4).value, 0)
        ElseIf cbobnktype.Text = "MPHASIS PF" Then
            init_header(gridbankdata, "Bank", 1)
            loc = 32
            show_grid(worksheet.Cells(loc, 2).value, worksheet.Cells(loc, 4).value, 0)
        End If
        For Each row As DataGridViewRow In gridbankdata.Rows
            sum = sum + row.Cells(1).Value
        Next
        txtsum.Text = sum
        txtsum.TextAlign = HorizontalAlignment.Center
    End Sub
End Class