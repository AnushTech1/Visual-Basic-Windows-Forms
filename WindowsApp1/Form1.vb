Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim age As Integer = InputBox("enter your age", "age Input")
        MsgBox(age + 2)
    End Sub
End Class
