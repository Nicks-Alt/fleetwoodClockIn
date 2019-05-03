Public Class Counselors
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim cancel As Boolean
        Do
            If MsgBox("Are you sure you want to cancel?", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then
                cancel = True
            Else
                cancel = False
            End If
        Loop Until cancel = True
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
    Private Sub Counselors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOK.Enabled = False
    End Sub
End Class