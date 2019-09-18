Imports System.Runtime.CompilerServices
Public Class CounselorsPanel
    Private counselors As New List(Of String)
    Private Sub CounselorsPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstItems.Items.Clear()
        Dim objGetCounselors As New IO.StreamReader("Counselors.txt")
        Dim raw As String = objGetCounselors.ReadLine()
        If raw IsNot Nothing Then
            Dim tempcounselors() As String = raw.Split(",")
            For Each counselor In tempcounselors
                lstItems.Items.Add(counselor)
                counselors.Add(counselor)
            Next
        Else
            btnRemove.Enabled = False
        End If
        objGetCounselors.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim temp As String
        Do
            temp = InputBox("Enter name of new counselor.", "New Counselor")
            If temp <> "" Then
                counselors.Add(temp)
                lstItems.Items.Add(temp)
            Else
                If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Cancel?") = MsgBoxResult.Yes Then
                    Exit Sub
                End If
            End If
        Loop Until temp <> ""
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstItems.SelectedIndex = -1 Then
            MsgBox("Select an item from the listbox, then press the remove button", MsgBoxStyle.Exclamation, "Error.")
        Else
            counselors.RemoveAt(lstItems.SelectedIndex)
            lstItems.Items.RemoveAt(lstItems.SelectedIndex)
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim objWriter As New IO.StreamWriter("counselors.txt", False)
        Dim temp As String
        Dim i
        For Each element In counselors
            If i = counselors.Count - 1 Then
                temp += element
            Else
                temp += element & ","
            End If
            i += 1
        Next
        objWriter.WriteLine(temp)
        lstItems.Items.Clear()
        counselors.Clear()
        objWriter.Close()
        Close()
    End Sub

    Private Sub lstItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItems.SelectedIndexChanged
        btnRemove.Enabled = True
    End Sub
    Private Sub EditCounselorName(sender As Object, e As EventArgs) Handles lstItems.DoubleClick
        If lstItems.SelectedIndex <> -1 Then
            Dim name As String
            Dim goodData As Boolean
            Do
                name = InputBox("Enter name:", "Enter name", " ")
                If name.Trim(" ") <> "" Then
                    lstItems.Replace(lstItems.SelectedIndex, name)
                    goodData = True
                Else
                    If MsgBox("Are you sure that you wish to cancel?", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
                        Exit Sub
                    Else
                        goodData = False
                    End If
                End If
            Loop Until goodData
        End If
    End Sub
End Class

Module Replace
    <Extension()>
    Public Sub Replace(aListBox As ListBox, indexToReplace As Integer, valueToReplace As Object)
        Dim listBoxCollection As New List(Of Object)
        Dim i As Integer
        For Each item In aListBox.Items
            If i <> indexToReplace Then
                listBoxCollection.Add(item)
            Else
                listBoxCollection.Add(valueToReplace)
            End If
            i += 1
        Next
        aListBox.Items.Clear()
        For Each item In listBoxCollection
            aListBox.Items.Add(item)
        Next
    End Sub
End Module