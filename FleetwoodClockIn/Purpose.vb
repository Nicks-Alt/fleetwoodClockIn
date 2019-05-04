Public Class Purpose
    Friend cancelPressed As Boolean = False
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel?", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then
            cancelPressed = True
            Close()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub radMoyer_CheckedChanged(sender As Object, e As EventArgs) Handles radAcademic.CheckedChanged, radCollegeCareer.CheckedChanged, radOther.CheckedChanged, radSocialEmotional.CheckedChanged
        btnOK.Enabled = True
    End Sub
    Private Function AssignPurpose() As String
        If radAcademic.Checked Then
            Return "Academic"
        ElseIf radCollegeCareer.Checked Then
            Return "College/Career"
        ElseIf radSocialEmotional.Checked Then
            Return "Social/Emotional"
        Else
            Return "Other"
        End If
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmMain.currentStudents(frmMain.currentStudents.Length - 1).Purpose = AssignPurpose()
        Close()
    End Sub
End Class