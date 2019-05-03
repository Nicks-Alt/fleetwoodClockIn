Public Class ClockedInStudents
    Private Sub lstStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudents.SelectedIndexChanged
        Try
            If lstStudents.SelectedIndex <> -1 Then
                For i = 0 To frmMain.currentStudents.Length - 1
                    frmMain.currentStudents(lstStudents.SelectedIndex) = frmMain.currentStudents(lstStudents.SelectedIndex + 1)
                Next
            End If
        Catch ex As Exception
            frmMain.con.Open()
            Dim command As New OleDb.OleDbCommand("INSERT INTO Data (StudentName, Counselor, Purpose, InDate, TimeIn, TimeOut, Duration) VALUES ('" & frmMain.currentStudents(lstStudents.SelectedIndex).Name & "', '" & frmMain.currentStudents(lstStudents.SelectedIndex).Counselor & "', '" & frmMain.currentStudents(lstStudents.SelectedIndex).Purpose & "', '" & frmMain.currentStudents(lstStudents.SelectedIndex).InDate & "', '" & frmMain.currentStudents(lstStudents.SelectedIndex).StartTime & "', '" & Now.ToLongTimeString & "', '" & frmMain.CalculateTime(frmMain.currentStudents(lstStudents.SelectedIndex)) & "')", frmMain.con)
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