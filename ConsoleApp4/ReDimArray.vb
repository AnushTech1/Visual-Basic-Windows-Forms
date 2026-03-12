Module ReDimArray
    Sub main()
        Dim scores() As Integer
        Dim i As Integer
        ReDim scores(2)
        scores(0) = 10
        scores(1) = 20
        scores(2) = 40
        Console.WriteLine("Intial scroes:")
        For i = 0 To UBound(scores)
            Console.WriteLine(scores(i))
        Next
        'resize the array and preserve data

    End Sub
End Module
