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
    Public Sub DisableTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            DisableTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = False
            End If
        Next ctrl
    End Sub
    Public Sub ClearTextnum(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextnum(ctrl)
            If TypeOf ctrl Is TextBox Then
                If ctrl.Name.StartsWith("txtnum") Then
                    ctrl.Text = ""
                    ctrl.Enabled = False
                End If
            End If
        Next ctrl
    End Sub


    Public Sub EmptyTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            EmptyTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                'If CType(ctrl, TextBox).Name.StartsWith("txtnum") Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub


    Public Sub EnableGroup2TextBox(ByVal enable As Boolean)
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is TextBox Then
                If (enable = True) Then
                    CType(ctrl, TextBox).Enabled = True
                Else
                    CType(ctrl, TextBox).Enabled = False
                End If
            End If
        Next ctrl
    End Sub

    Private Sub frmcashdist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableSound()
        DisableTextBox(Me)
        cmdload.Enabled = True
        cmdupdate.Enabled = False
        cmdcancel.Enabled = False
        cmdexit.Enabled = True
        cmdsave.Enabled = False
        cboAccount.Enabled = False
        cmdcredit.Enabled = False
        cmddebit.Enabled = False
        cmdreport.Enabled = False
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
            cmdload.Enabled = False
            cboAccount.Enabled = True
            cmdreport.Enabled = True
            enableediting()
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
            cmdreport.Enabled = True
            enableediting()
        End If
    End Sub

    Private Sub enableediting()
        txtreservedcoin.Enabled = True
        txtreservednotes.Enabled = True
        txtusagecoin.Enabled = True
        txtgirish.Enabled = True
        txtshubha.Enabled = True
        txtkarthik.Enabled = True
        txtother.Enabled = True
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        Dim rowindex As Integer = 0
        If MsgBox("Are Your Sure to Save?", vbYesNo, "Save Record") = vbYes Then
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
                cboAccount.Enabled = False
                cboAccount.Text = ""
                ClearTextnum(Me)
                cmdsave.Enabled = False
                cmdcancel.Enabled = False
                cmdupdate.Enabled = True
            Else
                MsgBox("Record is closed")
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cboAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccount.SelectedIndexChanged
        ClearTextnum(Me)
        EnableGroup2TextBox(False)
        If cboAccount.Text = "GIRISH" Then
            txtAccount.Text = txtgirish.Text
        ElseIf cboAccount.Text = "SHUBHA" Then
            txtAccount.Text = txtshubha.Text
        ElseIf cboAccount.Text = "KARTHIK" Then
            txtAccount.Text = txtkarthik.Text
        ElseIf cboAccount.Text = "OTHER" Then
            txtAccount.Text = txtother.Text
        ElseIf cboAccount.Text = "CALCULATOR" Then
            cmddebit.Enabled = False
            cmdcredit.Enabled = False
        ElseIf cboAccount.Text = "RESERVED COINS" Then
            txtAccount.Text = txtreservedcoin.Text
        ElseIf cboAccount.Text = "RESERVED NOTES" Then
            txtAccount.Text = txtreservednotes.Text
        ElseIf cboAccount.Text = "COINS IN USE" Then
            txtAccount.Text = txtusagecoin.Text
        End If
        txtnum1.Enabled = True
        txtnum1.Focus()
        cboAccount.Enabled = False
        cmdreport.Enabled = False
    End Sub
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

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdcredit.Click
        Dim newsum As Double = 0.0
        cmddebit.Enabled = False
        cmdcredit.Enabled = False
        newsum = CType(Val(txtnumsum.Text) + Val(txtAccount.Text), Double).ToString("f2")
        updatedistribution(newsum)
        cmdsave.Enabled = True
    End Sub

    Private Sub updatedistribution(newsum As Double)
        If cboAccount.Text = "GIRISH" Then
            cashdistributionfieldupdate(txtgirish, newsum)
        ElseIf cboAccount.Text = "KARTHIK" Then
            cashdistributionfieldupdate(txtkarthik, newsum)
        ElseIf cboAccount.Text = "SHUBHA" Then
            cashdistributionfieldupdate(txtshubha, newsum)
        ElseIf cboAccount.Text = "OTHER" Then
            cashdistributionfieldupdate(txtother, newsum)
        ElseIf cboAccount.Text = "RESERVED COINS" Then
            cashdistributionfieldupdate(txtreservedcoin, newsum)
        ElseIf cboAccount.Text = "RESERVED NOTES" Then
            cashdistributionfieldupdate(txtreservednotes, newsum)
        ElseIf cboAccount.Text = "COINS IN USE" Then
            cashdistributionfieldupdate(txtusagecoin, newsum)
        End If
    End Sub

    Private Sub cashdistributionfieldupdate(ByVal txtctl As TextBox, newsum As Double)
        If MsgBox(" Previous Balance:  " & Val(txtctl.Text) & vbCrLf & " Present   Balance:  " & newsum, vbCritical + vbYesNo, "Confirm Account Balance") = vbYes Then
            txtctl.Text = CType(newsum, Double).ToString("f2")
        End If
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
            MsgBox("Protected Account Statement Generated", vbInformation)
        End If
        main.ToolStripStatusLabel.Text = "Protected Statement Generated with ExitCode: " & pdftk.ExitCode
        cmdreport.Enabled = False
    End Sub
    Private Sub txtnum1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtnum2.Enabled = True
            txtnum2.Focus()
            txtnum1.Text = CType(Val(txtnum1.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum1.Text), Double).ToString("f2")
            txtnum1.Enabled = False
        End If
    End Sub


    Private Sub txtnum2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum2.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtnum3.Enabled = True
            txtnum3.Focus()
            txtnum2.Text = CType(Val(txtnum2.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum2.Text), Double).ToString("f2")
            txtnum2.Enabled = False
        End If
    End Sub

    Private Sub txtnum3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum3.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtnum4.Enabled = True
            txtnum4.Focus()
            txtnum3.Text = CType(Val(txtnum3.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum3.Text), Double).ToString("f2")
            txtnum3.Enabled = False
        End If
    End Sub

    Private Sub txtnum4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum4.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtnum5.Enabled = True
            txtnum5.Focus()
            txtnum4.Text = CType(Val(txtnum4.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum4.Text), Double).ToString("f2")
            txtnum4.Enabled = False
        End If
    End Sub

    Private Sub txtnum5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum5.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtnum6.Enabled = True
            txtnum6.Focus()
            txtnum5.Text = CType(Val(txtnum5.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum5.Text), Double).ToString("f2")
            txtnum5.Enabled = False
        End If
    End Sub

    Private Sub txtnum6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum6.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtnum7.Enabled = True
            txtnum7.Focus()
            txtnum6.Text = CType(Val(txtnum6.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum6.Text), Double).ToString("f2")
            txtnum6.Enabled = False
        End If
    End Sub

    Private Sub txtnum7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum7.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtnum8.Enabled = True
            txtnum8.Focus()
            txtnum7.Text = CType(Val(txtnum7.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum7.Text), Double).ToString("f2")
            txtnum7.Enabled = False
        End If
    End Sub

    Private Sub txtnum8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum8.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtnum9.Enabled = True
            txtnum9.Focus()
            txtnum8.Text = CType(Val(txtnum8.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum8.Text), Double).ToString("f2")
            txtnum8.Enabled = False
        End If
    End Sub

    Private Sub txtnum9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum9.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtnum10.Enabled = True
            txtnum10.Focus()
            txtnum9.Text = CType(Val(txtnum9.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum9.Text), Double).ToString("f2")
            txtnum9.Enabled = False
        End If
    End Sub

    Private Sub txtnum10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnum10.KeyDown
        If (e.KeyCode = Keys.Enter) Then

            txtnum10.Text = CType(Val(txtnum10.Text), Double).ToString("f2")
            txtnumsum.Text = CType(Val(txtnumsum.Text) + Val(txtnum10.Text), Double).ToString("f2")
            txtnum10.Enabled = False
            MsgBox("Calculated: " & txtnumsum.Text, vbInformation, cboAccount.Text)
            If cboAccount.Text <> "CALCULATOR" Then
                cmdcredit.Enabled = True
                cmddebit.Enabled = True
                cmdcancel.Enabled = True
            Else
                cboAccount.Enabled = True
                cboAccount.Text = ""
            End If
        End If
    End Sub

    Private Sub cmdupdate1_Click(sender As Object, e As EventArgs) Handles cmddebit.Click
        Dim newsum As Double = 0.0
        cmddebit.Enabled = False
        cmdcredit.Enabled = False
        If Val(txtAccount.Text) < Val(txtnumsum.Text) Then
            MsgBox("Something went wrong", vbCritical, "Inavalid Account Data")
            EmptyTextBox(Me)
            txtnum1.Enabled = True
            txtnum1.Focus()
            cboAccount.Enabled = True
            cboAccount.Text = ""
            cmdsave.Enabled = False
            Exit Sub
        End If
        newsum = CType(Val(txtAccount.Text) - Val(txtnumsum.Text), Double).ToString("f2")
        updatedistribution(newsum)
        cmdsave.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmdcancel.Click
        cmdcredit.Enabled = False
        cmddebit.Enabled = False
        cmdcancel.Enabled = False
        cmdsave.Enabled = False
        cboAccount.Enabled = True
    End Sub
    End Class