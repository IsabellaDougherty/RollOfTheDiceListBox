Imports System.Xml

Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim count(10, 1) As Integer
        Dim title As String = "|                   Roll Of The Dice                   |"
        Dim formatting As String
        Dim proxy As String
        Dim diceNumbers As String
        Dim numbers As String
        Dim counting As Integer = 1
        Dim rolls As String
        Dim rollOne As Integer
        Dim rollTwo As Integer
        Dim sum As Integer
        Dim random As New Random()

        For i = 0 To 999
            rollOne = random.Next(1, 7)
            rollTwo = random.Next(1, 7)
            sum = rollOne + rollTwo
            Select Case sum
                Case 2
                    count(0, 1) += 1
                Case 3
                    count(1, 1) += 1
                Case 4
                    count(2, 1) += 1
                Case 5
                    count(3, 1) += 1
                Case 6
                    count(4, 1) += 1
                Case 7
                    count(5, 1) += 1
                Case 8
                    count(6, 1) += 1
                Case 9
                    count(7, 1) += 1
                Case 10
                    count(8, 1) += 1
                Case 11
                    count(9, 1) += 1
                Case 12
                    count(10, 1) += 1
            End Select
        Next

        For i As Integer = 2 To 12
            numbers += "|"
            numbers += i.ToString().PadRight(4).PadLeft(4)

        Next
        numbers += "|"

        For i = 0 To 10
            proxy += "|"
            proxy += CStr(count(i, 1)).ToString().PadRight(4).PadLeft(4)
        Next
        proxy += "|"



        formatting += StrDup(56, "-")
        diceNumbers += " |"

        ListBox.Items.Add(formatting)
        ListBox.Items.Add(title)
        ListBox.Items.Add(formatting)
        ListBox.Items.Add(numbers)
        ListBox.Items.Add(formatting)
        ListBox.Items.Add(proxy)
        ListBox.Items.Add(formatting)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ListBox.Items.Clear()
    End Sub
End Class
