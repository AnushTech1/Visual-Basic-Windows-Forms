Public Class BitwiseOp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer = TextBox1.Text
        Dim num2 As Integer = TextBox2.Text
        ListBox1.Items.Add(num1 And num2)
        ListBox1.Items.Add(num1 Or num2)
        ListBox1.Items.Add(num1 Xor num2)
    End Sub
End Class