Public Class frmMain
    Friend currentStudents() As Student
    Friend con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StudentDatabase.mdb")
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Size = New Size(My.Computer.Screen.Bounds.X, My.Computer.Screen.Bounds.Y)

    End Sub
    Private Sub btnClockIn_Click(sender As Object, e As EventArgs) Handles btnClockIn.Click
        If currentStudents Is Nothing Then
            ReDim Preserve currentStudents(0)
        Else
            ReDim Preserve currentStudents(currentStudents.Length)
        End If
        Dim goodData, cancel As Boolean

        Do
            Dim temp As String = InputBox("Enter your name:", "Enter Name", " ")
            If temp <> "" Then
                If IsNumeric(temp) = False Then
                    goodData = True ' No names have numbers
                    currentStudents(currentStudents.Length - 1).Name = temp.ToUpper
                End If
            Else
                Select Case MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Are you sure?")
                    Case MsgBoxResult.Yes
                        Exit Sub
                    Case MsgBoxResult.No
                        cancel = False
                End Select
            End If
        Loop Until goodData Or cancel
        Counselors.ShowDialog()
        Purpose.ShowDialog()
        tmrBackground.Start()
        currentStudents(currentStudents.GetUpperBound(0)).StartTime = Now.ToLongTimeString
        currentStudents(currentStudents.GetUpperBound(0)).InDate = Now.ToLongDateString
    End Sub

    Private Sub btnClockOut_Click(sender As Object, e As EventArgs) Handles btnClockOut.Click
        If currentStudents.Length <> 0 Then
            ClockedInStudents.ShowDialog()
        Else
            MsgBox("There are no students signed in.", MsgBoxStyle.Information, "No students.")
        End If
    End Sub
    Private Sub tmrBackground_Tick(sender As Object, e As EventArgs) Handles tmrBackground.Tick
        ClockedInStudents.lstStudents.Items.Clear()
        For Each Student In currentStudents
            If Student.InDate = Nothing Then
                Exit For
            End If
            ClockedInStudents.lstStudents.Items.Add(Student.Name & " | " & CalculateTime(Student))
        Next
    End Sub
    Public Function CalculateTime(student As Student) As String
        Dim hours As Integer = DateDiff(DateInterval.Hour, Date.Parse(student.StartTime), Date.Parse(Now.ToLongTimeString))
        Dim minutes As Integer = DateDiff(DateInterval.Minute, Date.Parse(student.StartTime), Date.Parse(Now.ToLongTimeString))
        Dim seconds As Integer = DateDiff(DateInterval.Second, Date.Parse(student.StartTime), Date.Parse(Now.ToLongTimeString))
        If seconds > 59 Then
            seconds = seconds Mod 60
        End If
        If minutes > 59 Then
            minutes = minutes Mod 60
        End If
        Dim fixedH = CStr(hours)
        Dim fixedM = CStr(minutes)
        Dim fixedS = CStr(seconds)
        If fixedM.Length = 1 Then
            fixedM = "0" + minutes.ToString
        End If
        If fixedS.Length = 1 Then
            fixedS = "0" + seconds.ToString
        End If
        If fixedH.Length = 1 Then
            fixedH = "0" + hours.ToString
        End If
        Return fixedH & ":" & fixedM & ":" & fixedS
    End Function

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblTime.Text = Now.ToLongTimeString
    End Sub
End Class
