Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices


Public Class frmdisprecord

    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet = Nothing
    Dim workbook As Excel.Workbook = Nothing
    Dim filename As String
    Public currentIndex As Integer
    Dim blnExcelOpen As Boolean = False
    Dim enableclear As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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

    Private Sub frmrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lopidx As Integer = 315
        Dim iRow As Long = 0
        Dim grdidx As Integer = 0
        ExcelAcountManagerOpen()
        With worksheet
            iRow = .Range("B" & .Rows.Count).End(Excel.XlDirection.xlUp).Row
            If iRow = 314 Then
                MsgBox("No Transaction yet!", vbInformation, "Record")
            Else
                DataGridView1.ColumnCount = 4
                DataGridView1.RowCount = (iRow - 315) + 1
                DataGridView1.Columns(0).Name = "Sl No"
                DataGridView1.Columns(1).Name = "Transaction Description"
                DataGridView1.Columns(2).Name = "Transaction Date"
                DataGridView1.Columns(3).Name = "Amount"
                Dim columnHeaderStyle As New DataGridViewCellStyle()
                columnHeaderStyle.BackColor = Color.Beige
                columnHeaderStyle.Font = New Font("Callibri", 10, FontStyle.Bold)
                DataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle
                DataGridView1.RowHeadersVisible = False
                For lopidx = 315 To iRow
                    If (worksheet.Cells(lopidx, 2).value <> vbNullString) Then
                        DataGridView1.Item(0, grdidx).Value = " " & worksheet.Cells(lopidx, 1).value & " "
                        DataGridView1.Item(1, grdidx).Value = " " & worksheet.Cells(lopidx, 2).value & " "
                        DataGridView1.Item(2, grdidx).Value = Format(worksheet.Cells(lopidx, 3).value, " dd MMM yyyy  dddd ")
                        DataGridView1.Item(3, grdidx).Value = " " & CType(Val(worksheet.Cells(lopidx, 4).value), Double).ToString("f2") & " "
                        grdidx = grdidx + 1
                    End If
                Next lopidx
            End If
        End With
        ExcelAcountManagerClose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class