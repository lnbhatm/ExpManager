<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbankupdate
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
        Me.cbobankcode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbankcode = New System.Windows.Forms.TextBox()
        Me.txtSavings = New System.Windows.Forms.TextBox()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.cmdload = New System.Windows.Forms.Button()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.cmdedit = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcursav = New System.Windows.Forms.TextBox()
        Me.txtcurcrdt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbobankcode
        '
        Me.cbobankcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbobankcode.BackColor = System.Drawing.Color.White
        Me.cbobankcode.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbobankcode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbobankcode.FormattingEnabled = True
        Me.cbobankcode.Location = New System.Drawing.Point(245, 24)
        Me.cbobankcode.Name = "cbobankcode"
        Me.cbobankcode.Size = New System.Drawing.Size(278, 27)
        Me.cbobankcode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(85, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Banking Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(85, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Previous Saving"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(85, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Previous Credit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(85, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Account Balance"
        '
        'txtbankcode
        '
        Me.txtbankcode.BackColor = System.Drawing.Color.White
        Me.txtbankcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbankcode.Location = New System.Drawing.Point(775, 217)
        Me.txtbankcode.Name = "txtbankcode"
        Me.txtbankcode.Size = New System.Drawing.Size(94, 20)
        Me.txtbankcode.TabIndex = 5
        Me.txtbankcode.Visible = False
        '
        'txtSavings
        '
        Me.txtSavings.BackColor = System.Drawing.Color.White
        Me.txtSavings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSavings.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSavings.Location = New System.Drawing.Point(245, 66)
        Me.txtSavings.Name = "txtSavings"
        Me.txtSavings.Size = New System.Drawing.Size(118, 27)
        Me.txtSavings.TabIndex = 6
        '
        'txtCredits
        '
        Me.txtCredits.BackColor = System.Drawing.Color.White
        Me.txtCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredits.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredits.Location = New System.Drawing.Point(245, 114)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(118, 27)
        Me.txtCredits.TabIndex = 7
        '
        'txtbalance
        '
        Me.txtbalance.BackColor = System.Drawing.Color.White
        Me.txtbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbalance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.Location = New System.Drawing.Point(245, 258)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(121, 31)
        Me.txtbalance.TabIndex = 8
        '
        'cmdload
        '
        Me.cmdload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdload.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdload.ForeColor = System.Drawing.Color.Olive
        Me.cmdload.Location = New System.Drawing.Point(517, 377)
        Me.cmdload.Name = "cmdload"
        Me.cmdload.Size = New System.Drawing.Size(50, 22)
        Me.cmdload.TabIndex = 9
        Me.cmdload.Text = "LOAD"
        Me.cmdload.UseVisualStyleBackColor = True
        '
        'cmdexit
        '
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Olive
        Me.cmdexit.Location = New System.Drawing.Point(682, 377)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(50, 22)
        Me.cmdexit.TabIndex = 10
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'cmdedit
        '
        Me.cmdedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdedit.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdedit.ForeColor = System.Drawing.Color.Olive
        Me.cmdedit.Location = New System.Drawing.Point(572, 377)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(50, 22)
        Me.cmdedit.TabIndex = 11
        Me.cmdedit.Text = "EDIT"
        Me.cmdedit.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdsave.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.Olive
        Me.cmdsave.Location = New System.Drawing.Point(627, 377)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(50, 22)
        Me.cmdsave.TabIndex = 12
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(322, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(312, 33)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SAVINGS/CREDITS UPDATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(85, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Credit to Bank"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(85, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Debit from Bank"
        '
        'txtcursav
        '
        Me.txtcursav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcursav.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcursav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcursav.Location = New System.Drawing.Point(245, 162)
        Me.txtcursav.Name = "txtcursav"
        Me.txtcursav.Size = New System.Drawing.Size(118, 27)
        Me.txtcursav.TabIndex = 17
        '
        'txtcurcrdt
        '
        Me.txtcurcrdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcurcrdt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurcrdt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcurcrdt.Location = New System.Drawing.Point(245, 210)
        Me.txtcurcrdt.Name = "txtcurcrdt"
        Me.txtcurcrdt.Size = New System.Drawing.Size(118, 27)
        Me.txtcurcrdt.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcurcrdt)
        Me.GroupBox1.Controls.Add(Me.txtcursav)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtbalance)
        Me.GroupBox1.Controls.Add(Me.txtCredits)
        Me.GroupBox1.Controls.Add(Me.txtSavings)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbobankcode)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(203, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 310)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(885, 415)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdedit)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.cmdload)
        Me.Controls.Add(Me.txtbankcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPDATE SAVINGS AND CREDIT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbobankcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbankcode As System.Windows.Forms.TextBox
    Friend WithEvents txtSavings As System.Windows.Forms.TextBox
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents cmdload As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdedit As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcursav As System.Windows.Forms.TextBox
    Friend WithEvents txtcurcrdt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
