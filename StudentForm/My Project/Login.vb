Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" Or TextBox2.Text = "1234567890" Then
            Me.Hide()
            Dim Dashboard As New Form2()
            Dashboard.show()
        Else
            Dim result As MsgBoxResult = MsgBox("Invaild Login detials", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical, "System Message")
            If result = MsgBoxResult.Cancel Then
                Application.Exit()

            Else
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
    End Sub
End Class