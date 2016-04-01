Imports System.IO
Imports System.Globalization
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices


Public Class frmtransactions
    Dim APP As New Excel.Application
    Dim worksheetexp As Excel.Worksheet = Nothing
    Dim wrksheetrnt As Excel.Worksheet = Nothing
    Dim wrksheetrd As Excel.Worksheet = Nothing
    Dim wrksheetmotors As Excel.Worksheet = Nothing
    Dim workbook As Excel.Workbook = Nothing
    Dim filename
    Public currentIndex As Integer
    Dim blnExcelOpen As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctr As Control
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Or TypeOf ctr Is DateTimePicker Then
                ctr.Enabled = False
            End If
        Next ctr
        cmdreset.Enabled = False
        cmdupdate.Enabled = False
        txtitemcode.Visible = False
        txtdestbank.Visible = False
        txtincome.Visible = False
        txtsrcbank.Visible = False
        txtdate.Visible = False
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        cborecordtype.Items.Clear()
        cborecordtype.Items.Add("Income")
        cborecordtype.Items.Add("Expense")
        cborecordtype.Items.Add("RD/PPF")
        cborecordtype.Items.Add("NEFT")
        cborecordtype.Items.Add("ATM")
        cborecordtype.Items.Add("Credit")
        cborecordtype.Items.Add("Refund")
        cborecordtype.Items.Add("KarthikSB")
        openexcelsheet()
        Dim ctr As Control
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Or TypeOf ctr Is DateTimePicker Then
                ctr.Enabled = False
                ctr.Text = ""
            End If
        Next ctr
        disablepaymodeitems()
        With worksheetexp
            currentIndex = .Range("B" & .Rows.Count).End(Excel.XlDirection.xlUp).Row + 1
        End With
        txtslno.Text = currentIndex
        cmdadd.Enabled = False
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Dim thisDay As DateTime = System.DateTime.Today
        Dim tDay As DateTime
        Dim thismonth As Integer = thisDay.Month
        Dim startcopycell As String = "L77"
        Dim lopidx As Integer = 3
        Dim index As Integer = 0
        If blnExcelOpen = True Then
            If cborecordtype.Enabled = True And cborecordtype.Text = vbNullString Then
                MsgBox("Please Select the New Record Type", vbCritical, "Mode of Income")
                cborecordtype.Focus()
                Exit Sub
            End If

            If txtdate.Text = vbNullString Then
                MsgBox("Please enter the Transaction Date", vbCritical, "Data Entry Error")
                DateTimePicker1.Focus()
                Exit Sub
            End If

            If cboitemcode.Enabled = True Then
                If txtitemcode.Text = vbNullString Or cboitemcode.Text = vbNullString Then
                    MsgBox("Please enter the Transaction Item", vbCritical, "Data Entry Error")
                    cboitemcode.Focus()
                    Exit Sub
                End If
            End If

            If cbopaymode.Enabled = True Then
                If txtsrcbank.Text = vbNullString Or cbopaymode.Text = vbNullString Then
                    MsgBox("Please select the Payee Bank", vbCritical, "Data Entry Error")
                    cbopaymode.Focus()
                    Exit Sub
                End If
            End If

            If cbodestbank.Enabled = True Then
                If txtdestbank.Text = vbNullString Or cbodestbank.Text = vbNullString Then
                    MsgBox("Please select the Benificiary Bank", vbCritical + vbInformation, "Data Entry Error")
                    cbodestbank.Focus()
                    Exit Sub
                End If
            End If

            If cboincome.Enabled = True Then
                If txtincome.Text = vbNullString Or cboincome.Text = vbNullString Then
                    MsgBox("Please select the Mode of Income", vbCritical, "Data Entry Error")
                    cboincome.Focus()
                    Exit Sub
                End If
            End If

            If txtitemdesc.Text = vbNullString Then
                MsgBox("Please enter the Transaction Description", vbCritical, "Data Entry Error")
                txtitemdesc.Focus()
                Exit Sub
            End If
            If txtamount.Text = vbNullString Then
                MsgBox("Please enter the Transaction Amount", vbCritical, "Data Entry Error")
                txtamount.Focus()
                Exit Sub
            End If
            worksheetexp.Cells(currentIndex, 3).Value = txtdate.Text
            worksheetexp.Cells(currentIndex, 2).Value = txtitemdesc.Text
            worksheetexp.Cells(currentIndex, 4).Value = txtamount.Text
            worksheetexp.Cells(currentIndex, 5).Value = txtitemcode.Text
            worksheetexp.Cells(currentIndex, 6).Value = txtsrcbank.Text
            worksheetexp.Cells(currentIndex, 7).Value = txtdestbank.Text
            worksheetexp.Cells(currentIndex, 8).Value = txtincome.Text

            If (txtitemcode.Text = "CODE008") Then
                With wrksheetrnt
                    index = .Range("L" & .Rows.Count).End(Excel.XlDirection.xlUp).Row + 1
                End With
                wrksheetrnt.Cells(index, 12).Value = txtdate.Text
                wrksheetrnt.Cells(index, 13).Value = txtamount.Text
                tDay = txtdate.Text
                If (tDay.Month - 1 = 0) Then
                    wrksheetrnt.Cells(index, 14).Value = MonthName(12, False)
                    wrksheetrnt.Cells(index, 15).Value = tDay.Year - 1
                Else
                    wrksheetrnt.Cells(index, 14).Value = MonthName(tDay.Month - 1, False)
                    wrksheetrnt.Cells(index, 15).Value = tDay.Year
                End If



            ElseIf (txtitemcode.Text = "CODE000") Or (txtitemcode.Text = "CODE001") Or _
                   (txtitemcode.Text = "CODE002") Or (txtitemcode.Text = "CODE003") Or _
                   (txtitemcode.Text = "CODE004") Or (txtitemcode.Text = "CODE005") Or _
                   (txtitemcode.Text = "CODE006") Or (txtitemcode.Text = "CODE007") Then
                With wrksheetrd
                    index = .Range("A" & .Rows.Count).End(Excel.XlDirection.xlUp).Row + 1
                End With
                wrksheetrd.Cells(index, 1).Value = wrksheetrd.Cells(index - 1, 1).Value + 1
                wrksheetrd.Cells(index, 2).Value = txtdate.Text
                wrksheetrd.Cells(index, 3).Value = txtamount.Text
                tDay = txtdate.Text
                wrksheetrd.Cells(index, 4).Value = MonthName(tDay.Month, False)
                wrksheetrd.Cells(index, 5).Value = tDay.Year
                wrksheetrd.Cells(index, 6).Value = txtitemcode.Text

            ElseIf (txtitemcode.Text = "CODE019") Or (txtitemcode.Text = "CODE020") Or _
                   (txtitemcode.Text = "CODE021") Or (txtitemcode.Text = "CODE022") Or _
                   (txtitemcode.Text = "CODE023") Or (txtitemcode.Text = "CODE024") Or _
                   (txtitemcode.Text = "CODE025") Or (txtitemcode.Text = "CODE026") Or _
                   (txtitemcode.Text = "CODE027") Or (txtitemcode.Text = "CODE028") Or _
                   (txtitemcode.Text = "CODE029") Or (txtitemcode.Text = "CODE030") Or _
                   (txtitemcode.Text = "CODE031") Or (txtitemcode.Text = "CODE032") Or _
                   (txtitemcode.Text = "CODE033") Or (txtitemcode.Text = "CODE034") Or _
                   (txtitemcode.Text = "CODE035") Or (txtitemcode.Text = "CODE036") Then
                Dim msg, title, value As String
                With wrksheetmotors
                    index = .Range("A" & .Rows.Count).End(Excel.XlDirection.xlUp).Row + 1
                    .Range("A2:G2").Copy()
                    .Range("A" & index).PasteSpecial(Excel.XlPasteType.xlPasteFormats, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone)
                End With
                wrksheetmotors.Cells(index, 1).Value = (index - 1)
                wrksheetmotors.Cells(index, 2).Value = txtdate.Text
                wrksheetmotors.Cells(index, 3).Value = txtamount.Text
                tDay = txtdate.Text
                wrksheetmotors.Cells(index, 4).Value = MonthName(tDay.Month, False)
                wrksheetmotors.Cells(index, 5).Value = tDay.Year
                wrksheetmotors.Cells(index, 6).Value = txtitemcode.Text
                msg = "Enter the Vehicle Milage in KM"
                title = "KILO METER READING"
                value = 0
                value = InputBox(msg, title, value)
                wrksheetmotors.Cells(index, 7).Value = value
            End If
            '-------------------------------------------------------------------------------------
            With wrksheetrd
                .Range("B2:F5000").Sort(Key1:=.Range("B2"), Order1:=Excel.XlSortOrder.xlAscending, Header:=Excel.XlYesNoGuess.xlYes, _
                OrderCustom:=1, MatchCase:=False, Orientation:=Excel.XlSortOrientation.xlSortColumns, _
                DataOption1:=Excel.XlSortDataOption.xlSortNormal)
            End With

            With wrksheetrd
                .Range("B2:F5000").Sort(Key1:=.Range("F2"), Order1:=Excel.XlSortOrder.xlAscending, Header:=Excel.XlYesNoGuess.xlYes, _
                OrderCustom:=1, MatchCase:=False, Orientation:=Excel.XlSortOrientation.xlSortColumns, _
                DataOption1:=Excel.XlSortDataOption.xlSortNormal)
            End With

            With worksheetexp
                .Range(trans_entry_range).Sort(Key1:=.Range("C" & TrnStrtIdx), Order1:=Excel.XlSortOrder.xlAscending, Header:=Excel.XlYesNoGuess.xlYes, _
                OrderCustom:=1, MatchCase:=False, Orientation:=Excel.XlSortOrientation.xlSortColumns, _
                DataOption1:=Excel.XlSortDataOption.xlSortNormal)
                .Range("K77:K176").Copy()
                Select Case thismonth
                    Case 1
                        startcopycell = "U77"
                    Case 2
                        startcopycell = "V77"
                    Case 3
                        startcopycell = "W77"
                    Case 4
                        startcopycell = "L77"
                    Case 5
                        startcopycell = "M77"
                    Case 6
                        startcopycell = "N77"
                    Case 7
                        startcopycell = "O77"
                    Case 8
                        startcopycell = "P77"
                    Case 9
                        startcopycell = "Q77"
                    Case 10
                        startcopycell = "R77"
                    Case 11
                        startcopycell = "S77"
                    Case 12
                        startcopycell = "T77"
                End Select
                .Range(startcopycell).PasteSpecial(Excel.XlPasteType.xlPasteValues, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone)
                For lopidx = 3 To 52
                    If .Cells(lopidx, 4).Value >= 0 Then
                        .Cells(lopidx, 9).Value = .Cells(lopidx, 4).Value
                        .Cells(lopidx, 10).Value = 0.0
                    Else
                        .Cells(lopidx, 9).Value = 0.0
                        .Cells(lopidx, 10).Value = Math.Abs(.Cells(lopidx, 4).Value)
                    End If
                Next lopidx
            End With

            workbook.Save()

            If worksheetexp.Cells(197, 3).Value > 0 Then
                worksheetexp.Cells(595, 4).Value = worksheetexp.Cells(197, 3).Value - worksheetexp.Cells(197, 4).Value
            Else
                worksheetexp.Cells(595, 4).Value = worksheetexp.Cells(197, 3).Value + worksheetexp.Cells(197, 4).Value
            End If


            If worksheetexp.Cells(199, 3).Value > 0 Then
                worksheetexp.Cells(596, 4).Value = worksheetexp.Cells(199, 3).Value - worksheetexp.Cells(199, 4).Value
            Else
                worksheetexp.Cells(596, 4).Value = worksheetexp.Cells(199, 3).Value + worksheetexp.Cells(199, 4).Value
            End If


            If worksheetexp.Cells(200, 3).Value > 0 Then
                worksheetexp.Cells(597, 4).Value = worksheetexp.Cells(200, 3).Value - worksheetexp.Cells(200, 4).Value
            Else
                worksheetexp.Cells(597, 4).Value = worksheetexp.Cells(200, 3).Value + worksheetexp.Cells(200, 4).Value
            End If


            cmdupdate.Enabled = False
            cmdadd.Enabled = True
            cmdreset.Enabled = False
        End If
    End Sub

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        closeexcelsheet()
        Me.Close()
    End Sub

    Private Sub cboitemcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboitemcode.SelectedIndexChanged
        Dim selectedindex As Integer
        selectedindex = cboitemcode.SelectedIndex
        If selectedindex <= 9 Then
            txtitemcode.Text = "CODE" & "00" & selectedindex
        ElseIf selectedindex > 9 And selectedindex <= 99 Then
            txtitemcode.Text = "CODE" & "0" & selectedindex
        Else
            txtitemcode.Text = "CODE" & selectedindex
        End If
        txtitemdesc.Text = cboitemcode.Text
    End Sub

    Private Sub cbopaymode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopaymode.SelectedIndexChanged
        Dim selectedindex As Integer
        selectedindex = cbopaymode.SelectedIndex
        If selectedindex <= 9 Then
            txtsrcbank.Text = "BANK" & "00" & selectedindex
        ElseIf selectedindex > 9 And selectedindex <= 99 Then
            txtsrcbank.Text = "BANK" & "0" & selectedindex
        Else
            txtsrcbank.Text = "BANK" & selectedindex
        End If
    End Sub

    Private Sub cbodestbank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodestbank.SelectedIndexChanged
        Dim selectedindex As Integer
        selectedindex = cbodestbank.SelectedIndex
        If selectedindex <= 9 Then
            txtdestbank.Text = "BANK" & "00" & selectedindex
        ElseIf selectedindex > 9 And selectedindex <= 99 Then
            txtdestbank.Text = "BANK" & "0" & selectedindex
        Else
            txtdestbank.Text = "BANK" & selectedindex
        End If
    End Sub

    Private Sub cboincome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboincome.SelectedIndexChanged
        Dim selectedindex As Integer
        selectedindex = cboincome.SelectedIndex
        If selectedindex <= 9 Then
            txtincome.Text = "INCOME" & "00" & selectedindex
        ElseIf selectedindex > 9 And selectedindex <= 99 Then
            txtincome.Text = "INCOME" & "0" & selectedindex
        Else
            txtincome.Text = "INCOME" & selectedindex
        End If
        txtitemdesc.Enabled = True
        txtitemdesc.Text = cboincome.Text
    End Sub



    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Dim ctr As Control
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Or TypeOf ctr Is DateTimePicker Then
                ctr.Enabled = False
                ctr.Text = ""
            End If
        Next ctr
        cmdreset.Enabled = False
        cmdupdate.Enabled = False
        cmdadd.Enabled = True
    End Sub

    Private Sub DateTimePicker1_GotFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.GotFocus
        txtdate.Text = DateTimePicker1.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtdate.Text = DateTimePicker1.Value.ToString("MM/dd/yyyy")
        cborecordtype.Enabled = True
    End Sub

    Private Sub cborecordtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cborecordtype.SelectedIndexChanged
        comboboxtransitemcode()
        comboboxbankingcode()
        comboboxincomemodecode()
        comboboxtransitemcode()
        disablepaymodeitems()
        If cborecordtype.Text = "Income" Then
            EnableIncome()
        ElseIf cborecordtype.Text = "Expense" Then
            EnableExpense()
        ElseIf cborecordtype.Text = "Refund" Then
            EnableRefund()
        ElseIf cborecordtype.Text = "KarthikSB" Then
            EnableConvertgift()
        ElseIf cborecordtype.Text = "NEFT" Then
            Enablefundtransfer()
        ElseIf cborecordtype.Text = "Credit" Then
            Enablefundtransfer()
        ElseIf cborecordtype.Text = "ATM" Then
            Enablefundtransfer()
        ElseIf cborecordtype.Text = "RD/PPF" Then
            termdepositpayment()
        End If
        txtitemdesc.Enabled = True
    End Sub

    Private Sub disablepaymodeitems()
        txtdestbank.Enabled = False
        txtincome.Enabled = False
        txtitemcode.Enabled = False
        txtsrcbank.Enabled = False
        txtitemdesc.Enabled = False
        cbodestbank.Enabled = False
        cboincome.Enabled = False
        cbopaymode.Enabled = False
        cboitemcode.Enabled = False
    End Sub
    Private Sub EnableIncome()
        disablepaymodeitems()
        cbodestbank.Enabled = True
        cboincome.Enabled = True
    End Sub

    Private Sub EnableExpense()
        disablepaymodeitems()
        cboitemcode.Enabled = True
        cbopaymode.Enabled = True
    End Sub


    Private Sub EnableRefund()
        disablepaymodeitems()
        cboitemcode.Enabled = True
        cboincome.Enabled = True
        cbodestbank.Enabled = True
    End Sub


    Private Sub Enablefundtransfer()
        disablepaymodeitems()
        cbopaymode.Enabled = True
        cbodestbank.Enabled = True
    End Sub

    Private Sub termdepositpayment()
        disablepaymodeitems()
        cboitemcode.Enabled = True
        cbopaymode.Enabled = True
        cbodestbank.Enabled = True
    End Sub



    Private Sub EnableConvertgift()
        disablepaymodeitems()
        cbodestbank.Enabled = True
        cboincome.Enabled = True
        cbopaymode.Enabled = True
    End Sub


    Private Sub openexcelsheet()
        If Not My.Computer.FileSystem.FileExists(acountmanager) Then
            MsgBox(acountmanager & " does not exist")
            Exit Sub
        End If
        Try
            APP = CType(GetObject(, "Excel.Application"), Excel.Application)
        Catch ex As Exception
            APP = New Excel.Application
        End Try
        blnExcelOpen = True
        With APP
            .DisplayAlerts = False
            .Visible = False
        End With
        workbook = APP.Workbooks.Open(acountmanager)
        worksheetexp = workbook.Worksheets("Expenditure")
        wrksheetrnt = workbook.Worksheets("HouseRent")
        wrksheetrd = workbook.Worksheets("Investments")
        wrksheetmotors = workbook.Worksheets("Vehicle")
        blnExcelOpen = True
    End Sub

    Private Sub closeexcelsheet()
        If blnExcelOpen = True Then
            workbook.Close()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            Marshal.FinalReleaseComObject(worksheetexp)
            Marshal.FinalReleaseComObject(wrksheetrnt)
            Marshal.FinalReleaseComObject(wrksheetrd)
            Marshal.FinalReleaseComObject(wrksheetmotors)
            Marshal.FinalReleaseComObject(workbook)
            APP.Quit()
            Marshal.FinalReleaseComObject(APP)
            blnExcelOpen = False
        End If
    End Sub

    Private Sub readdate(ByVal i As Integer)
        Dim temps As String
        txtslno.Text = worksheetexp.Cells(i, 1).Value
        txtitemdesc.Text = worksheetexp.Cells(i, 2).Value
        txtdate.Text = worksheetexp.Cells(i, 3).Value
        txtamount.Text = worksheetexp.Cells(i, 4).Value
        txtitemcode.Text = worksheetexp.Cells(i, 5).Value
        txtsrcbank.Text = worksheetexp.Cells(i, 6).Value
        txtdestbank.Text = worksheetexp.Cells(i, 7).Value
        txtincome.Text = worksheetexp.Cells(i, 8).Value

        For i = 77 To 176
            temps = worksheetexp.Cells(i, 2).Value
            If temps <> "" Then
                cboitemcode.Items.Add(worksheetexp.Cells(i, 2).Value)
            End If
        Next i
        For i = 57 To 70
            temps = worksheetexp.Cells(i, 2).Value
            If temps <> "" Then
                cboincome.Items.Add(worksheetexp.Cells(i, 2).Value)
            End If
        Next i
        For i = 3 To 52
            temps = worksheetexp.Cells(i, 2).Value
            If temps <> "" Then
                cbodestbank.Items.Add(worksheetexp.Cells(i, 2).Value)
                cbopaymode.Items.Add(worksheetexp.Cells(i, 2).Value)
            End If
        Next i
    End Sub

    
    Private Sub comboboxtransitemcode()
        Dim index As Integer = 0
        If blnExcelOpen = True Then
            cboitemcode.Items.Clear()
            For index = 77 To 176
                If worksheetexp.Cells(index, 2).Value <> vbNullString Then
                    cboitemcode.Items.Add(worksheetexp.Cells(index, 2).Value)
                End If
            Next index
        End If
    End Sub

    Private Sub comboboxincomemodecode()
        Dim index As Integer = 0
        If blnExcelOpen = True Then
            cboincome.Items.Clear()
            For index = 57 To 70
                If worksheetexp.Cells(index, 2).Value <> vbNullString Then
                    cboincome.Items.Add(worksheetexp.Cells(index, 2).Value)
                End If
            Next index
        End If
    End Sub

    Private Sub comboboxbankingcode()
        Dim index As Integer = 0
        If blnExcelOpen = True Then
            cbodestbank.Items.Clear()
            cbopaymode.Items.Clear()
            For index = 3 To 52
                If worksheetexp.Cells(index, 2).Value <> vbNullString Then
                    cbodestbank.Items.Add(worksheetexp.Cells(index, 2).Value)
                    cbopaymode.Items.Add(worksheetexp.Cells(index, 2).Value)
                End If
            Next index
        End If
    End Sub

    Private Sub txtamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtamount.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim myTI As TextInfo = New CultureInfo("en-US", False).TextInfo
            Dim titlecase As String
            cmdreset.Enabled = True
            cmdupdate.Enabled = True

            If txtitemdesc.Text = vbNullString Then
                MsgBox("Please enter the Transaction Description", vbCritical, "Data Entry Error")
                txtitemdesc.Focus()
                Exit Sub
            Else
                If (Len(txtitemdesc.Text) <= 70) Then
                    titlecase = myTI.ToLower(txtitemdesc.Text)
                    txtitemdesc.Text = myTI.ToTitleCase(titlecase)
                Else
                    MsgBox("Description can not exceed 70 charecters", vbCritical, "Description")
                    txtitemdesc.Focus()
                    Exit Sub
                End If
            End If
            cmdupdate.Focus()
        End If
    End Sub

    Private Sub txtitemdesc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtitemdesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamount.Enabled = True
            txtamount.Focus()
        End If
    End Sub
End Class

