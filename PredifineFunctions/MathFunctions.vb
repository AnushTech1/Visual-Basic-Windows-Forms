Public Class MathFunctions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double = Val(TextBox1.Text)
        Dim num2 As Double = Val(TextBox2.Text)
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Math.Abs(num1):" & Math.Abs(num1))
        ListBox1.Items.Add("Math.Sqrt(num1):" & Math.Sqrt(num1))
        ListBox1.Items.Add("Math.Round(num1):" & Math.Round(num1))
        ListBox1.Items.Add("Math.Floor(num1):" & Math.Floor(num1))
        ListBox1.Items.Add("Math.Ceiling(num1):" & Math.Ceiling(num1))
        ListBox1.Items.Add("Math.Max(num1,num2):" & Math.Max(num1, num2))
        ListBox1.Items.Add("Math.Min(num1,num2):" & Math.Min(num1, num2))
    End Sub
End Class