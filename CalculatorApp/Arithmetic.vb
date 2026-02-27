Imports System.Linq.Expressions

Public Class Arithmetic
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = TextBox1.Text
        Dim b As Integer = TextBox2.Text
        '  Dim result As Integer
        Dim op As Integer = ListBox1.SelectedIndex
        Select Case op
            Case 0
                MsgBox(a + b)
            Case 1
                MsgBox(a - b)
            Case 2
                MsgBox(a * b)
            Case 3
                MsgBox(a / b)
            Case 4
                MsgBox(a Mod b)
        End Select
        '  MsgBox("The sum result is " & result)
    End Sub
End Class
