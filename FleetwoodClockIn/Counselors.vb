Public Class Counselors
    Friend cancelPressed As Boolean = False
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then
            cancelPressed = True
            Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmMain.currentStudents(frmMain.currentStudents.Length - 1).Counselor = AssignCounselor()
        Close()

    End Sub
    Private Function AssignCounselor() As String
        If radMoyer.Checked Then
            Return "Ms. Moyer"
        ElseIf radEngelhardt.Checked Then
            Return "Mr. Engelhardt"
        ElseIf radSaunders.Checked Then
            Return "Mrs. Saunders"
        ElseIf radHawkins.Checked Then
            Return "Mrs. Hawkins"
        Else
            Return "Other"
        End If
    End Function

    Private Sub radMoyer_CheckedChanged(sender As Object, e As EventArgs) Handles radMoyer.CheckedChanged, radEngelhardt.CheckedChanged, radHawkins.CheckedChanged, radOther.CheckedChanged, radSaunders.CheckedChanged
        btnOK.Enabled = True
    End Sub
End Class