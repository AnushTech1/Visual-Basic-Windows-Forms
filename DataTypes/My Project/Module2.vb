Module Module2
    Sub main()
        Dim age As Integer
        Dim agestr As String
        agestr = InputBox("enter your age ", "age input")
        age = Convert.ToInt32(agestr)
        Console.WriteLine(age)
    End Sub
End Module
