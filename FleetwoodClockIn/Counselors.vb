Public Class Counselors
    Friend cancelPressed As Boolean = False
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to cancel?", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then
            cancelPressed = True
            Close()
        Else
            Exit Sub
        End If
    End Sub
    Private Function AssignCounselor() As String
        Return lstItems.SelectedItem
    End Function
    Private Sub Counselors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstItems.Items.Clear()
        Dim objReader As New IO.StreamReader("Counselors.txt")
        Dim temp() As String = objReader.ReadLine.ToString.Split(",")
        For Each element In temp
            lstItems.Items.Add(element)
        Next
        objReader.Close()
    End Sub
    Private Sub lstItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItems.SelectedIndexChanged
        frmMain.currentStudents(frmMain.currentStudents.Length - 1).Counselor = AssignCounselor()
        Close()
    End Sub
End Class