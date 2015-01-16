Public Class Buttons

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each s As Setting In Settings
            dgvButtons.Rows.Add(s.Name, s.Filename)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using frmAddButton As New AddButton
            If frmAddButton.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgvButtons.Rows.Add(frmAddButton.ButtonName, frmAddButton.Filename)
            End If
        End Using
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim newSettings As New List(Of Setting)
        For Each row As DataGridViewRow In dgvButtons.Rows
            newSettings.Add(New Setting With {.Name = CStr(row.Cells("BoardName").Value), .Filename = CStr(row.Cells("Filename").Value)})
        Next
        Settings = newSettings
        Me.Close()
    End Sub
End Class