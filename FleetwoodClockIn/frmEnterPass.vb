Public Class frmEnterPass
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtPassword.Text = frmMain.password Then
            Process.Start("StudentDatabase.mdb")
            Close()
        Else
            MsgBox("Incorrect password! Please try again.", MsgBoxStyle.Exclamation, "Wrong password.")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    Private Sub EnterKeyBullshit(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Me, New EventArgs)
        End If
    End Sub
    Private Sub frmEnterPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Clear()
        txtPassword.Focus()
    End Sub
End Class