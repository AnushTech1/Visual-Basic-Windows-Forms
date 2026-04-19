Public Class StringFunctions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = txtInput.Text
        Dim length As Integer = input.Length
        Dim upperText As String = input.ToUpper()
        Dim replacedText As String = input.Replace("hello", "hi")
        Dim reversedText As String = StrReverse(input)
        Dim result As String = " Length : " & length & vbCrLf &
            "Uppercase :" & upperText & vbCrLf &
            "Replaced : " & replacedText & vbCrLf &
            "Reversed : " & reversedText
        lblResult.Text = result
    End Sub
End Class
