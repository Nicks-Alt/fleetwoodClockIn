Public Class frmEnterPass
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtPassword.Text = frmMain.password Then
            Hide()
            AdminPanel.ShowDialog()
        Else
            MsgBox("Incorrect password! Please try again.", MsgBoxStyle.Exclamation, "Wrong password.")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    Private Sub EnterKey_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Me, New EventArgs)
        End If
    End Sub
    Private Sub frmEnterPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Clear()
        txtPassword.Focus()
    End Sub

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblChangePass.Click
        Do
            Dim objReader As New IO.StreamReader("Security.txt")
            If objReader.ReadLine.Contains(InputBox("Enter old password:")) Then
                objReader.Close()
                Dim objWriter As New IO.StreamWriter("Security.txt", False)
                Dim newpass As String = InputBox("Enter new password:")
                If newpass = InputBox("Enter new password again") Then
                    objWriter.WriteLine(newpass)
                    objWriter.Close()
                    frmMain.password = newpass
                    Exit Do
                Else
                    MsgBox("Passwords to not match, please try again.", MsgBoxStyle.Exclamation, "Try again.")
                End If
            Else
                MsgBox("Incorrect password.", MsgBoxStyle.Exclamation, "Wrong password")
                objReader.Close()
            End If
        Loop
    End Sub
End Class