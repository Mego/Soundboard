Imports System.IO

Public Class AddButton

    Public Property ButtonName As String
    Public Property Filename As String

    Private Sub btnFilename_Click(sender As Object, e As EventArgs) Handles btnFilename.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim uriFile As Uri = New Uri(OpenFileDialog1.FileName)
            Dim uriCur As Uri = New Uri(My.Computer.FileSystem.CurrentDirectory & Path.DirectorySeparatorChar)
            Dim strRelPath As String = Uri.UnescapeDataString(uriCur.MakeRelativeUri(uriFile).ToString())
            If uriFile.Scheme.ToUpperInvariant = "FILE" Then
                strRelPath = strRelPath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
            End If
            Filename = strRelPath
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ButtonName = txtName.Text
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class