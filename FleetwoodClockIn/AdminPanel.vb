Public Class AdminPanel
    Private Sub btnDatabase_Click(sender As Object, e As EventArgs) Handles btnDatabase.Click
        Process.Start("StudentDatabase.mdb")
    End Sub
    Private Sub btnEditCounselors_Click(sender As Object, e As EventArgs) Handles btnEditCounselors.Click
        CounselorsPanel.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class