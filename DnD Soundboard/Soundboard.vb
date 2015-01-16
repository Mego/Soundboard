Public Class Soundboard

    Public Property Reload As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadSettings()
        LoadButtons()
        Reload = False
    End Sub

    Private Sub Soundboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub

    Private Sub LoadButtons()
        For Each s As Setting In Settings
            tlpSounds.Controls.Add(New SoundBoardButton(s.Name, s.Filename) With {.Dock = DockStyle.Fill})
        Next
    End Sub

    Private Sub ButtonsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButtonsToolStripMenuItem.Click
        Using frmButtons As New Buttons
            frmButtons.ShowDialog()
        End Using
        Reload = True
        Me.Close()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        My.Computer.Audio.Stop()
    End Sub
End Class
