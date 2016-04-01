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

    Private Sub cmdnew_Click(sender As Object, e As EventArgs) Handles cmdnewmonth.Click
        ExcelAcountManagerOpen()
        If MsgBox("ARE YOU SURE TO RESET ACCOUNT?" + vbNewLine + "Only reset in the start of the month.", vbYesNo + vbCritical, "Confirm Clear Records?") = vbYes Then
            If blnExcelOpen = True Then
                Dim lopidx As Integer = 0
                Dim startindex As Integer = 613
                Dim endingindex As Integer = 0
                Dim thisDay As DateTime = System.DateTime.Today
                Dim currentmonth As Integer = 0
                currentmonth = thisDay.Month
                endingindex = startindex + System.DateTime.DaysInMonth(2016, currentmonth)
                worksheet.Range("C613:C643").Value = ""
                worksheet.Range("D613:D643").Value = ""
                worksheet.Cells(startindex, 3).Value = (currentmonth) & "/1/" & thisDay.Year
                worksheet.Range("C613").AutoFill(worksheet.Range("C613:C" & endingindex - 1), Excel.XlAutoFillType.xlFillDays)
                worksheet.Range("D613").AutoFill(worksheet.Range("D613:D" & endingindex - 1), Excel.XlAutoFillType.xlFillDefault)
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
                    .Range("B" & TrnStrtIdx & ":H579").ClearContents()
                End With
                workbook.Save()
                MsgBox("Record Cleared!", vbInformation, "CLEAR RECORD")
            End If
        End If
        ExcelAcountManagerClose()
    End Sub

    Private Sub cmdnewyear_Click(sender As Object, e As EventArgs) Handles cmdnewyear.Click
        ExcelAcountManagerOpen()
        If MsgBox("ARE YOU SURE TO RESET ACCOUNT?" + vbNewLine + "This Option to be used begining of every Year only.", vbYesNo + vbCritical, "Confirm Clear Records?") = vbYes Then
            If blnExcelOpen = True Then
                Dim lopidx As Integer = 0
                Dim startindex As Integer = 613
                Dim endingindex As Integer = 0
                Dim thisDay As DateTime = System.DateTime.Today
                Dim currentmonth As Integer = 0
                currentmonth = thisDay.Month
                endingindex = startindex + System.DateTime.DaysInMonth(2016, currentmonth)
                worksheet.Range("C613:C643").Value = ""
                worksheet.Range("D613:D643").Value = ""
                worksheet.Cells(startindex, 3).Value = (currentmonth) & "/1/" & thisDay.Year
                worksheet.Range("C613").AutoFill(worksheet.Range("C613:C" & endingindex - 1), Excel.XlAutoFillType.xlFillDays)
                worksheet.Range("D613").AutoFill(worksheet.Range("D613:D" & endingindex - 1), Excel.XlAutoFillType.xlFillDefault)
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
                    .Range("B" & TrnStrtIdx & ":H579").ClearContents()
                    .Range("L77:W176").ClearContents()
                End With
                workbook.Save()
                MsgBox("Record Cleared!", vbInformation, "CLEAR RECORD")
            End If
        End If
        ExcelAcountManagerClose()
    End Sub
End Class