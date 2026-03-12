Module ArrayEx
    Sub main()
        Dim marks(4) As Integer
        marks(0) = 27
        marks(1) = 24
        marks(2) = 30

        marks(3) = 255
        Console.WriteLine("Student marks")
        For i As Integer = 0 To 4
            Console.WriteLine("subject" & (i + 1) & marks(i))
        Next
    End Sub

End Module
