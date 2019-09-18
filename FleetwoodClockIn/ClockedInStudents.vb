Public Class ClockedInStudents
    Friend currentStudent As Student
    Private Sub lstStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudents.SelectedIndexChanged
        Dim currentIndex As Integer
        Try
            If lstStudents.SelectedIndex <> -1 Then
                currentStudent = frmMain.currentStudents(lstStudents.SelectedIndex)
                currentIndex = lstStudents.SelectedIndex
                For i = 0 To frmMain.currentStudents.Length - 1
                    frmMain.currentStudents(currentIndex) = frmMain.currentStudents(currentIndex + 1)
                Next
            End If
        Catch ex As Exception
            frmMain.con.Open()
            Destination.ShowDialog()
            Dim command As New OleDb.OleDbCommand("INSERT INTO Data (StudentName, Counselor, Purpose, InDate, TimeIn, TimeOut, Duration) VALUES ('" & frmMain.currentStudents(currentIndex).Name & "', '" & frmMain.currentStudents(currentIndex).Counselor & "', '" & frmMain.currentStudents(currentIndex).Purpose & "', '" & frmMain.currentStudents(currentIndex).InDate & "', '" & frmMain.currentStudents(currentIndex).StartTime & "', '" & Now.ToLongTimeString & "', '" & frmMain.CalculateTime(frmMain.currentStudents(currentIndex)) & "')", frmMain.con)
            command.ExecuteNonQuery()
            frmMain.con.Close()
            ReDim Preserve frmMain.currentStudents(frmMain.currentStudents.Length - 2)
            Close()
        End Try
    End Sub

    Private Sub ClockedInStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmMain.currentStudents.Length = 0 Then
            Close()
        End If
    End Sub
End Class