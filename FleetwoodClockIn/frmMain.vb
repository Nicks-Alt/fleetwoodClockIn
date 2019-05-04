Public Class frmMain
    Friend password As String = "Database"
    Friend currentStudents() As Student
    Friend con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StudentDatabase.mdb")
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim middleX As Integer = My.Computer.Screen.Bounds.Width / 2
        btnClockIn.Location = New Point(middleX - middleX / 2, My.Computer.Screen.Bounds.Height / 2)
        btnClockIn.Left = btnClockIn.Left - (btnClockIn.Width / 2)
        btnClockOut.Location = New Point(middleX + middleX / 2, My.Computer.Screen.Bounds.Height / 2)
        btnClockOut.Left = btnClockOut.Left - (btnClockOut.Width / 2)
        lblTime.Location = New Point(My.Computer.Screen.Bounds.Width / 2, My.Computer.Screen.Bounds.Height / 6)
        lblTime.Left = lblTime.Left - (lblTime.Width / 2)
        lblTitle.Location = New Point(My.Computer.Screen.Bounds.Width / 2, My.Computer.Screen.Bounds.Y)
        lblTitle.Left = lblTitle.Left - (lblTitle.Width / 2)
        lblLogin.Location = New Point(My.Computer.Screen.Bounds.Width - 50, My.Computer.Screen.Bounds.Height - 50)
    End Sub
    Private Sub btnClockIn_Click(sender As Object, e As EventArgs) Handles btnClockIn.Click
        If currentStudents Is Nothing Then
            ReDim Preserve currentStudents(0)
        Else
            If currentStudents(currentStudents.Length - 1).Name = Nothing Then
                ReDim Preserve currentStudents(currentStudents.Length - 2)
            End If
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
                        ReDim Preserve currentStudents(currentStudents.Length - 2)
                        Exit Sub
                    Case MsgBoxResult.No
                        cancel = False
                End Select
            End If
        Loop Until goodData Or cancel
        Counselors.ShowDialog()
        If Counselors.cancelPressed Then
            Exit Sub
        Else
            Purpose.ShowDialog()
            If Purpose.cancelPressed Then
                Exit Sub
            Else
                tmrBackground.Start()
                currentStudents(currentStudents.GetUpperBound(0)).StartTime = Now.ToLongTimeString
                currentStudents(currentStudents.GetUpperBound(0)).InDate = Now.ToLongDateString
            End If
        End If
    End Sub

    Private Sub btnClockOut_Click(sender As Object, e As EventArgs) Handles btnClockOut.Click
        If currentStudents Is Nothing OrElse currentStudents.Length = 0 Then
            MsgBox("No students clocked in.", MsgBoxStyle.Exclamation, "No students.")
            Exit Sub
        Else
            ClockedInStudents.ShowDialog()
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

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            frmEnterPass.ShowDialog()
        End If
    End Sub
End Class
