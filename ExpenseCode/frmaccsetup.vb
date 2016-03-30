Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices


Public Class frmaccsetup
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet = Nothing
    Dim workbook As Excel.Workbook = Nothing
    Dim filename As String
    Public currentIndex As Integer
    Dim blnExcelOpen As Boolean = False
    Dim enableclear As Boolean = False



    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub frmsetupdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1180, 605)
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

    Private Sub cmdnew_Click(sender As Object, e As EventArgs) Handles cmdnew.Click
        ExcelAcountManagerOpen()
        If MsgBox("ALL RECORD WILL BE REMOVED, ARE YOU SURE?" + vbNewLine + "This Option to be used begining of every Month only.", vbYesNo + vbCritical, "Confirm Clear Records?") = vbYes Then
            If blnExcelOpen = True Then
                Dim lopidx As Integer = 0
                Dim startindex As Integer = 612
                Dim endingindex As Integer = 0
                Dim thisDay As DateTime = System.DateTime.Today
                Dim currentmonth As Integer = 0
                currentmonth = thisDay.Month
                endingindex = startindex + System.DateTime.DaysInMonth(2016, currentmonth)
                worksheet.Range("C612:C642").Value = ""
                worksheet.Range("D612:D642").Value = ""
                worksheet.Cells(startindex, 3).Value = (currentmonth) & "/1/" & thisDay.Year
                worksheet.Range("C612").AutoFill(worksheet.Range("C612:C" & endingindex - 1), Excel.XlAutoFillType.xlFillDays)
                worksheet.Range("D612").AutoFill(worksheet.Range("D612:D" & endingindex - 1), Excel.XlAutoFillType.xlFillDefault)
                With worksheet
                    .Range("D57:D70").Value = "0.00"
                    For lopidx = 3 To 52
                        If .Cells(lopidx, 4).Value >= 0 Then
                            .Cells(lopidx, 9).Value = .Cells(lopidx, 4).Value
                            .Cells(lopidx, 10).Value = 0.0
                        Else
                            .Cells(lopidx, 9).Value = 0.0
                            .Cells(lopidx, 10).Value = Math.Abs(.Cells(lopidx, 4).Value)
                        End If
                    Next lopidx
                    .Range("E3:F52").Value = "0.00"
                    .Range("I3:J52").Copy()
                    .Range("E3").PasteSpecial(Excel.XlPasteType.xlPasteValues, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone)
                    .Range("B314:H579").ClearContents()
                End With
                workbook.Save()
                MsgBox("Record Cleared!", vbInformation, "CLEAR RECORD")
            End If
        End If
        ExcelAcountManagerClose()
    End Sub
End Class