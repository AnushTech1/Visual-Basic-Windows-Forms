
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Basic_calculator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim num1 As Integer = Convert.ToInt32(TextBox1.Text)
            Dim num2 As Integer = Val(TextBox2.Text)
            Dim result As Integer = num1 / num2
            Label4.Text = result
        Catch ex As DivideByZeroException
            MessageBox.Show("error can divided by zero", "exception")
        Catch ex As FormatException
            MessageBox.Show("Error: place enter valid number", "Exceptio")
        Catch ex As Exception
            MessageBox.Show("General error:" & ex.Message, "Exception")
        Finally
            Label5.clear()
            Label5.Text &= vbCrLf & "Process complete"
        End Try
    End Sub
End Class