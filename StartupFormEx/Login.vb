Public Class Form1
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If username.Text = "Admin" And password.Text = "123" Then
            Me.Hide()
            Dim main As New Form2()
            main.ShowDialog()
            Me.Close()
        Else
            MsgBox("invalid login")
        End If
    End Sub
End Class
