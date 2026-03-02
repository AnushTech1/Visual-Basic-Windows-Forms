Public Class Student
    Private name As String = "Anush"

    Private Sub show()
        Console.WriteLine("hello" & name)
    End Sub
    Public Sub detials()
        show()
    End Sub
End Class
Module Module1
    Sub main()
        Dim S As New Student()
        'S.show()
        S.detials()
    End Sub

End Module
