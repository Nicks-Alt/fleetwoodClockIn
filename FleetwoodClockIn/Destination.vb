Public Class Destination
    Private currentStudent As Student
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        PrintDocument1.Print()
        Activate()
        Close()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim headerFont As New Font(FontFamily.GenericSerif, 16, FontStyle.Underline, GraphicsUnit.Pixel)
        Dim detailFont As New Font(FontFamily.GenericSerif, 12, FontStyle.Italic, GraphicsUnit.Pixel)
        Dim teacherFont As New Font(FontFamily.GenericSerif, 12, FontStyle.Underline, GraphicsUnit.Pixel)
        Dim wut As New Font(FontFamily.GenericSerif, 6, FontStyle.Regular, GraphicsUnit.Pixel)
        e.Graphics.DrawImage(BackgroundImage, New Rectangle(0, 0, 70, 70))
        e.Graphics.DrawString("GUIDANCE PASS", headerFont, Brushes.Black, 70, 0)
        e.Graphics.DrawString(currentStudent.Name, detailFont, Brushes.Black, 80, 25)
        e.Graphics.DrawString(currentStudent.Counselor, detailFont, Brushes.Black, 80, 40)
        e.Graphics.DrawString(Now.ToLongDateString, detailFont, Brushes.Black, 0, 68)
        e.Graphics.DrawString(Now.ToLongTimeString, detailFont, Brushes.Black, 0, 80)
        e.Graphics.DrawString(txtDestination.Text, teacherFont, Brushes.Black, 83, 80)
        e.Graphics.DrawString("π", wut, Brushes.Black, 185, 90)
    End Sub
    Private Sub Destination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentStudent = ClockedInStudents.currentStudent
        Dim dymoPrinterFound As Boolean
        For Each printer In Printing.PrinterSettings.InstalledPrinters
            If printer.ToString.Contains("DYMO") Then
                dymoPrinterFound = True
                Exit Sub
            End If
        Next
    End Sub
    Private Sub EnterKey(sender As Object, e As KeyEventArgs) Handles txtDestination.KeyDown
        If e.KeyCode = Keys.Enter Then
            PrintDocument1.Print()
            Activate()
            Close()
        End If
    End Sub
End Class