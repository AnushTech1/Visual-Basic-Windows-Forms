Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim age As Integer = Convert.ToInt32(TextBox2.Text())
        If age >= 18 Then
            TextBox3.Text = "Eligible"
        Else
            TextBox3.Text = "eneligible"
        End If
    End Sub
End Class
