Public Class Form1
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    ' End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim striNumber As String = "123"
        Dim intNumber As Integer
        Dim dblResult As Double
        intNumber = CInt(striNumber)
        dblResult = CDbl(intNumber)
        MessageBox.Show("integer value :" & intNumber.ToString())
        MessageBox.Show("double value :" & dblResult.ToString())
    End Sub
End Class
