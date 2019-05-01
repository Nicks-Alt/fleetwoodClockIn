Public Class frmMain
    Friend currentStudents() As Student
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btnClockIn_Click(sender As Object, e As EventArgs) Handles btnClockIn.Click
        If currentStudents Is Nothing Then
            ReDim Preserve currentStudents(0)
        Else
            ReDim Preserve currentStudents(currentStudents.Length)
        End If
        Dim goodData As Boolean
        Do
            Dim temp As String = InputBox("Enter your name:", "Enter Name", " ")
            If IsNumeric(temp) = False Then
                goodData = True ' No names have numbers
                currentStudents(currentStudents.Length - 1).Name = temp.ToUpper
            End If
        Loop Until goodData
        Counselors.ShowDialog()
        Purpose.ShowDialog()
        tmrBackground.Start()
        currentStudents(currentStudents.GetUpperBound(0)).StartTime = Now.ToLongTimeString
        currentStudents(currentStudents.GetUpperBound(0)).InDate = Now.ToLongDateString
        ClockedInStudents.Show()
    End Sub

    Private Sub btnClockOut_Click(sender As Object, e As EventArgs) Handles btnClockOut.Click
        ClockedInStudents.ShowDialog()
    End Sub
    Private Sub tmrBackground_Tick(sender As Object, e As EventArgs) Handles tmrBackground.Tick
        ClockedInStudents.lstStudents.Items.Clear()
        For Each Student In currentStudents
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
End Class
