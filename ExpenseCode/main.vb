Imports System.Windows.Forms



Public Class main

    Dim msg As String = "Personal Account Manager " + vbNewLine + "Version: 30.03.16.329"

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub TransactionEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionEntryToolStripMenuItem.Click

        Dim NewMDIChild As New frmtransactions()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to exit Account Manager?", vbCritical + vbYesNo, "Exit") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub SetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupToolStripMenuItem.Click
        Dim NewMDIChild As New frmbankupdate()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub


    Private Sub CashDistributionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashDistributionToolStripMenuItem.Click
        Dim NewMDIChild As New frmreport
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me

        'Display the new form.
        NewMDIChild.Show()
    End Sub



    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = msg
        My.Computer.Audio.Stop()
    End Sub

    Private Sub BankingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankingToolStripMenuItem.Click

        Dim NewMDIChild As New frmbankbal
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub SetupToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetupToolStripMenuItem1.Click
        Dim NewMDIChild As New frmaccsetup
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpenseToolStripMenuItem.Click
        Dim NewMDIChild As New frmdisprecord
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox(msg, vbInformation, "About")
    End Sub
    Private Sub QueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueryToolStripMenuItem.Click
        Dim NewMDIChild As New frmqueryexpense
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you sure you want to exit Account Manager?", vbCritical + vbYesNo, "Exit") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub
End Class
