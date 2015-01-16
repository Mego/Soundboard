Public Module modSoundboard

    Public Sub Main()
        Dim frmSoundboard As Soundboard = Nothing
        Do
            If frmSoundboard IsNot Nothing Then
                frmSoundboard.Dispose()
                frmSoundboard = Nothing
            End If
            frmSoundboard = New Soundboard
            Application.Run(frmSoundboard)
        Loop While frmSoundboard.Reload
    End Sub

End Module
