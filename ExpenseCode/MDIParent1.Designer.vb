<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashDistributionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BankingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.ShowToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1184, 26)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem1, Me.SetupToolStripMenuItem, Me.TransactionEntryToolStripMenuItem, Me.CashDistributionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MainToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.MainToolStripMenuItem.Text = "DATA"
        '
        'SetupToolStripMenuItem1
        '
        Me.SetupToolStripMenuItem1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetupToolStripMenuItem1.ForeColor = System.Drawing.Color.Indigo
        Me.SetupToolStripMenuItem1.Name = "SetupToolStripMenuItem1"
        Me.SetupToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.SetupToolStripMenuItem1.Text = "Reset"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetupToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SetupToolStripMenuItem.Text = "Bank"
        '
        'TransactionEntryToolStripMenuItem
        '
        Me.TransactionEntryToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionEntryToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo
        Me.TransactionEntryToolStripMenuItem.Name = "TransactionEntryToolStripMenuItem"
        Me.TransactionEntryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TransactionEntryToolStripMenuItem.Text = "Expenses"
        '
        'CashDistributionToolStripMenuItem
        '
        Me.CashDistributionToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashDistributionToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo
        Me.CashDistributionToolStripMenuItem.Name = "CashDistributionToolStripMenuItem"
        Me.CashDistributionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CashDistributionToolStripMenuItem.Text = "Report"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ShowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BankingToolStripMenuItem, Me.ExpenseToolStripMenuItem, Me.QueryToolStripMenuItem})
        Me.ShowToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ShowToolStripMenuItem.Text = "ENQUIRY"
        '
        'BankingToolStripMenuItem
        '
        Me.BankingToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo
        Me.BankingToolStripMenuItem.Name = "BankingToolStripMenuItem"
        Me.BankingToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BankingToolStripMenuItem.Text = "Bank Balance"
        '
        'ExpenseToolStripMenuItem
        '
        Me.ExpenseToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo
        Me.ExpenseToolStripMenuItem.Name = "ExpenseToolStripMenuItem"
        Me.ExpenseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExpenseToolStripMenuItem.Text = "Transactions"
        '
        'QueryToolStripMenuItem
        '
        Me.QueryToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo
        Me.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem"
        Me.QueryToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.QueryToolStripMenuItem.Text = "Query"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.QuitApplicationToolStripMenuItem})
        Me.HELPToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HELPToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AboutToolStripMenuItem.Text = "About App"
        '
        'QuitApplicationToolStripMenuItem
        '
        Me.QuitApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.QuitApplicationToolStripMenuItem.Name = "QuitApplicationToolStripMenuItem"
        Me.QuitApplicationToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.QuitApplicationToolStripMenuItem.Text = "Quit App"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1184, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.ActiveLinkColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(41, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        Me.ToolStripStatusLabel.VisitedLinkColor = System.Drawing.Color.White
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal Account Manager"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashDistributionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BankingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpenseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
