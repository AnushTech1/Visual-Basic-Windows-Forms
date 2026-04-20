Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Grade_Finder
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim H As Double, i As Double, M As Double, S As Double, SS As Double, total As Double, avg As Double
        Try
            H = CDbl(TextBox1.Text)
            i = CDbl(TextBox2.Text)
            M = CDbl(TextBox3.Text)
            S = CDbl(TextBox4.Text)
            SS = CDbl(TextBox5.Text)
            'Check data

            total = H + i + M + S + SS
            avg = total / 5
            If avg >= 75 Then
                Label8.Text = "A"
            ElseIf avg >= 60 Then
                Label8.Text = "B"
            ElseIf avg >= 50 Then
                Label8.Text = "C"
            ElseIf avg >= 40 Then
                Label8.Text = "D"
            Else
                Label8.Text = "Fail"
            End If
        Catch ex As FormatException
            MessageBox.Show("Please Enter a Valid Number!")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
