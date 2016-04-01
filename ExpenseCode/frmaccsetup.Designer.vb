<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaccsetup
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
        Me.cmdnewmonth = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdnewyear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdexit.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Olive
        Me.cmdexit.Location = New System.Drawing.Point(40, 106)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(201, 25)
        Me.cmdexit.TabIndex = 0
        Me.cmdexit.Text = "E&XIT"
        Me.cmdexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdnewmonth
        '
        Me.cmdnewmonth.BackColor = System.Drawing.Color.White
        Me.cmdnewmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdnewmonth.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnewmonth.ForeColor = System.Drawing.Color.Olive
        Me.cmdnewmonth.Location = New System.Drawing.Point(40, 42)
        Me.cmdnewmonth.Name = "cmdnewmonth"
        Me.cmdnewmonth.Size = New System.Drawing.Size(201, 25)
        Me.cmdnewmonth.TabIndex = 1
        Me.cmdnewmonth.Text = "RESET MONTH"
        Me.cmdnewmonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdnewmonth.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(316, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MONTHLY SETUP"
        '
        'cmdnewyear
        '
        Me.cmdnewyear.BackColor = System.Drawing.Color.White
        Me.cmdnewyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdnewyear.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnewyear.ForeColor = System.Drawing.Color.Olive
        Me.cmdnewyear.Location = New System.Drawing.Point(39, 72)
        Me.cmdnewyear.Name = "cmdnewyear"
        Me.cmdnewyear.Size = New System.Drawing.Size(201, 25)
        Me.cmdnewyear.TabIndex = 3
        Me.cmdnewyear.Text = "RESET YEAR"
        Me.cmdnewyear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdnewyear.UseVisualStyleBackColor = False
        '
        'frmaccsetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(925, 485)
        Me.Controls.Add(Me.cmdnewyear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdnewmonth)
        Me.Controls.Add(Me.cmdexit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmaccsetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdnewmonth As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdnewyear As System.Windows.Forms.Button
End Class
