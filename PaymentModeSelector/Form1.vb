Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String
        If RadioButton1.Checked Then
            result = "you selected : Credit card"
        ElseIf RadioButton2.Checked Then
            result = "you selected : Debit card"
        ElseIf RadioButton3.Checked Then
            result = "you selected : Net banking"
        Else
            result = "Please select a payment option!"
        End If
        MessageBox.Show(result, "Payment Mode")

    End Sub
End Class
