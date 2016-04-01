<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtransactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.txtitemdesc = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboitemcode = New System.Windows.Forms.ComboBox()
        Me.cbopaymode = New System.Windows.Forms.ComboBox()
        Me.cbodestbank = New System.Windows.Forms.ComboBox()
        Me.cboincome = New System.Windows.Forms.ComboBox()
        Me.txtitemcode = New System.Windows.Forms.TextBox()
        Me.txtsrcbank = New System.Windows.Forms.TextBox()
        Me.txtdestbank = New System.Windows.Forms.TextBox()
        Me.txtincome = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cborecordtype = New System.Windows.Forms.ComboBox()
        Me.txtslno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdexit
        '
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdexit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Red
        Me.cmdexit.Location = New System.Drawing.Point(556, 381)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(85, 26)
        Me.cmdexit.TabIndex = 13
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'txtitemdesc
        '
        Me.txtitemdesc.BackColor = System.Drawing.Color.White
        Me.txtitemdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtitemdesc.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemdesc.Location = New System.Drawing.Point(255, 301)
        Me.txtitemdesc.Name = "txtitemdesc"
        Me.txtitemdesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtitemdesc.Size = New System.Drawing.Size(455, 27)
        Me.txtitemdesc.TabIndex = 9
        '
        'txtdate
        '
        Me.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdate.Enabled = False
        Me.txtdate.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdate.Location = New System.Drawing.Point(775, 12)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(104, 27)
        Me.txtdate.TabIndex = 7
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.Color.White
        Me.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamount.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(255, 336)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(104, 27)
        Me.txtamount.TabIndex = 10
        '
        'cmdupdate
        '
        Me.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdupdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.ForeColor = System.Drawing.Color.Red
        Me.cmdupdate.Location = New System.Drawing.Point(455, 381)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(85, 26)
        Me.cmdupdate.TabIndex = 11
        Me.cmdupdate.Text = "&SAVE"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdadd
        '
        Me.cmdadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdadd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.Color.Red
        Me.cmdadd.Location = New System.Drawing.Point(253, 381)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(85, 26)
        Me.cmdadd.TabIndex = 1
        Me.cmdadd.Text = "&ADD"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'cmdreset
        '
        Me.cmdreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdreset.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreset.ForeColor = System.Drawing.Color.Red
        Me.cmdreset.Location = New System.Drawing.Point(354, 381)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(85, 26)
        Me.cmdreset.TabIndex = 12
        Me.cmdreset.Text = "&RESET"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(108, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Record ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(108, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Record Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(108, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Transaction Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(108, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Transaction Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(108, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Transaction Item Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(108, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Payee Bank"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(108, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Benificiary Account"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(108, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Mode of Income"
        '
        'cboitemcode
        '
        Me.cboitemcode.BackColor = System.Drawing.Color.White
        Me.cboitemcode.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboitemcode.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboitemcode.ForeColor = System.Drawing.Color.Maroon
        Me.cboitemcode.FormattingEnabled = True
        Me.cboitemcode.Location = New System.Drawing.Point(255, 161)
        Me.cboitemcode.Name = "cboitemcode"
        Me.cboitemcode.Size = New System.Drawing.Size(455, 27)
        Me.cboitemcode.TabIndex = 5
        '
        'cbopaymode
        '
        Me.cbopaymode.BackColor = System.Drawing.Color.White
        Me.cbopaymode.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbopaymode.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopaymode.ForeColor = System.Drawing.Color.Maroon
        Me.cbopaymode.FormattingEnabled = True
        Me.cbopaymode.Location = New System.Drawing.Point(255, 196)
        Me.cbopaymode.Name = "cbopaymode"
        Me.cbopaymode.Size = New System.Drawing.Size(455, 27)
        Me.cbopaymode.TabIndex = 6
        '
        'cbodestbank
        '
        Me.cbodestbank.BackColor = System.Drawing.Color.White
        Me.cbodestbank.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbodestbank.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodestbank.ForeColor = System.Drawing.Color.Maroon
        Me.cbodestbank.FormattingEnabled = True
        Me.cbodestbank.Location = New System.Drawing.Point(255, 231)
        Me.cbodestbank.Name = "cbodestbank"
        Me.cbodestbank.Size = New System.Drawing.Size(455, 27)
        Me.cbodestbank.TabIndex = 7
        '
        'cboincome
        '
        Me.cboincome.BackColor = System.Drawing.Color.White
        Me.cboincome.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboincome.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboincome.ForeColor = System.Drawing.Color.Maroon
        Me.cboincome.FormattingEnabled = True
        Me.cboincome.Location = New System.Drawing.Point(255, 266)
        Me.cboincome.Name = "cboincome"
        Me.cboincome.Size = New System.Drawing.Size(455, 27)
        Me.cboincome.TabIndex = 8
        '
        'txtitemcode
        '
        Me.txtitemcode.BackColor = System.Drawing.Color.White
        Me.txtitemcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtitemcode.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemcode.Location = New System.Drawing.Point(775, 48)
        Me.txtitemcode.Name = "txtitemcode"
        Me.txtitemcode.Size = New System.Drawing.Size(104, 27)
        Me.txtitemcode.TabIndex = 25
        '
        'txtsrcbank
        '
        Me.txtsrcbank.BackColor = System.Drawing.Color.White
        Me.txtsrcbank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsrcbank.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrcbank.Location = New System.Drawing.Point(775, 81)
        Me.txtsrcbank.Name = "txtsrcbank"
        Me.txtsrcbank.Size = New System.Drawing.Size(104, 27)
        Me.txtsrcbank.TabIndex = 26
        '
        'txtdestbank
        '
        Me.txtdestbank.BackColor = System.Drawing.Color.White
        Me.txtdestbank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdestbank.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdestbank.Location = New System.Drawing.Point(775, 114)
        Me.txtdestbank.Name = "txtdestbank"
        Me.txtdestbank.Size = New System.Drawing.Size(104, 27)
        Me.txtdestbank.TabIndex = 27
        '
        'txtincome
        '
        Me.txtincome.BackColor = System.Drawing.Color.White
        Me.txtincome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtincome.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtincome.Location = New System.Drawing.Point(775, 147)
        Me.txtincome.Name = "txtincome"
        Me.txtincome.Size = New System.Drawing.Size(104, 27)
        Me.txtincome.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(255, 91)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 27)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(108, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "New Record"
        '
        'cborecordtype
        '
        Me.cborecordtype.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cborecordtype.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborecordtype.FormattingEnabled = True
        Me.cborecordtype.Location = New System.Drawing.Point(255, 126)
        Me.cborecordtype.Name = "cborecordtype"
        Me.cborecordtype.Size = New System.Drawing.Size(193, 27)
        Me.cborecordtype.TabIndex = 4
        '
        'txtslno
        '
        Me.txtslno.BackColor = System.Drawing.Color.White
        Me.txtslno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtslno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtslno.Location = New System.Drawing.Point(256, 56)
        Me.txtslno.Name = "txtslno"
        Me.txtslno.Size = New System.Drawing.Size(105, 27)
        Me.txtslno.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label10.Location = New System.Drawing.Point(271, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 29)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "TRANSACTIONS"
        '
        'frmtransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(885, 415)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtslno)
        Me.Controls.Add(Me.cborecordtype)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtincome)
        Me.Controls.Add(Me.txtdestbank)
        Me.Controls.Add(Me.txtsrcbank)
        Me.Controls.Add(Me.txtitemcode)
        Me.Controls.Add(Me.cboincome)
        Me.Controls.Add(Me.cbodestbank)
        Me.Controls.Add(Me.cbopaymode)
        Me.Controls.Add(Me.cboitemcode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txtitemdesc)
        Me.Controls.Add(Me.cmdexit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmtransactions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSACTIONS"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents txtitemdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboitemcode As System.Windows.Forms.ComboBox
    Friend WithEvents cbopaymode As System.Windows.Forms.ComboBox
    Friend WithEvents cbodestbank As System.Windows.Forms.ComboBox
    Friend WithEvents cboincome As System.Windows.Forms.ComboBox
    Friend WithEvents txtitemcode As System.Windows.Forms.TextBox
    Friend WithEvents txtdestbank As System.Windows.Forms.TextBox
    Friend WithEvents txtincome As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cborecordtype As System.Windows.Forms.ComboBox
    Friend WithEvents txtsrcbank As System.Windows.Forms.TextBox
    Friend WithEvents txtslno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
