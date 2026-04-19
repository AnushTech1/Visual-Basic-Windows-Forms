Public Class DateTimePicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedDate As DateTime = DateTimePicker1.Value
        MessageBox.Show("you selected :" & selectedDate.ToString("dd-MM-yyyy"), "selected date ")
    End Sub
End Class