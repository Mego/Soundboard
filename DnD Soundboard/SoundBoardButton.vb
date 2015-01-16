Public Class SoundBoardButton

    Private _strSoundfile As String

    Public Sub New(ByVal pName As String, ByVal pFilename As String)
        InitializeComponent()

        Button1.Text = pName
        SoundFile = pFilename
    End Sub

    Public Property SoundFile As String
        Get
            Return _strSoundfile
        End Get
        Set(value As String)
            If IO.File.Exists(value) Then
                _strSoundfile = value
                Button1.Enabled = True
            End If
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(SoundFile)
    End Sub

End Class
