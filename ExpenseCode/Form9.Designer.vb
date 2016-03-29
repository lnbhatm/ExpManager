<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquery
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.datadisplay = New System.Windows.Forms.DataGridView()
        Me.cboexp = New System.Windows.Forms.ComboBox()
        Me.cbobank = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.txtsum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtavail = New System.Windows.Forms.TextBox()
        CType(Me.datadisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datadisplay
        '
        Me.datadisplay.AllowUserToResizeColumns = False
        Me.datadisplay.AllowUserToResizeRows = False
        Me.datadisplay.BackgroundColor = System.Drawing.Color.White
        Me.datadisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datadisplay.DefaultCellStyle = DataGridViewCellStyle1
        Me.datadisplay.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datadisplay.Location = New System.Drawing.Point(18, 42)
        Me.datadisplay.Name = "datadisplay"
        Me.datadisplay.ReadOnly = True
        Me.datadisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.datadisplay.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datadisplay.Size = New System.Drawing.Size(742, 249)
        Me.datadisplay.TabIndex = 1
        '
        'cboexp
        '
        Me.cboexp.FormattingEnabled = True
        Me.cboexp.Location = New System.Drawing.Point(353, 15)
        Me.cboexp.Name = "cboexp"
        Me.cboexp.Size = New System.Drawing.Size(407, 21)
        Me.cboexp.TabIndex = 2
        '
        'cbobank
        '
        Me.cbobank.FormattingEnabled = True
        Me.cbobank.Location = New System.Drawing.Point(92, 15)
        Me.cbobank.Name = "cbobank"
        Me.cbobank.Size = New System.Drawing.Size(168, 21)
        Me.cbobank.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Query Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(285, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "EXPENSE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "QUERY RECORD"
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbobank)
        Me.GroupBox1.Controls.Add(Me.cboexp)
        Me.GroupBox1.Controls.Add(Me.datadisplay)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(774, 300)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'cmdexit
        '
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdexit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(814, 375)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(54, 23)
        Me.cmdexit.TabIndex = 10
        Me.cmdexit.Text = "Exit"
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'txtsum
        '
        Me.txtsum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsum.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsum.Location = New System.Drawing.Point(297, 341)
        Me.txtsum.Name = "txtsum"
        Me.txtsum.Size = New System.Drawing.Size(87, 22)
        Me.txtsum.TabIndex = 11
        Me.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(182, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total Amount Spent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(410, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 14)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Available Amount"
        '
        'txtavail
        '
        Me.txtavail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtavail.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtavail.Location = New System.Drawing.Point(517, 343)
        Me.txtavail.Name = "txtavail"
        Me.txtavail.Size = New System.Drawing.Size(87, 22)
        Me.txtavail.TabIndex = 14
        '
        'frmquery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 410)
        Me.Controls.Add(Me.txtavail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsum)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmquery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.datadisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datadisplay As System.Windows.Forms.DataGridView
    Friend WithEvents cboexp As System.Windows.Forms.ComboBox
    Friend WithEvents cbobank As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents txtsum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtavail As System.Windows.Forms.TextBox
End Class
