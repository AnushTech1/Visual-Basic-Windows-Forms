Imports System

' 1. Enum: Fixed values ke liye
Enum Role
    Admin
    Developer
    Guest
End Enum

' 2. Struct: Value Type (Asli data stack par rehta hai)
Structure Point
    Public X As Integer
    Public Y As Integer
End Structure


Module Module1
    Sub Main()
        ' --- VALUE TYPE EXAMPLE (Struct) ---
        Dim p1 As New Point()
        p1.X = 10
        Dim p2 As Point = p1 ' Pura data copy ho raha hai (Naya box bana)
        p2.X = 50

        Console.WriteLine("--- Struct (Value Type) ---")
        Console.WriteLine("p1.X: " & p1.X) ' Output: 10 (Badla nahi)
        Console.WriteLine("p2.X: " & p2.X) ' Output: 50

        ' --- REFERENCE TYPE EXAMPLE (Class) ---
        Dim s1 As New Student()
        s1.Name = "Amit"
        Dim s2 As Student = s1 ' Sirf ADDRESS copy ho raha hai (Box ek hi hai)
        s2.Name = "Rahul"

        Console.WriteLine(vbCrLf & "--- Class (Reference Type) ---")
        Console.WriteLine("s1.Name: " & s1.Name) ' Output: Rahul (Badal gaya!)
        Console.WriteLine("s2.Name: " & s2.Name) ' Output: Rahul

        ' --- ENUM EXAMPLE ---
        Dim myRole As Role = Role.Developer
        Console.WriteLine(vbCrLf & "--- Enum ---")
        Console.WriteLine("Mera Role hai: " & myRole.ToString() & " (Internal Value: " & CInt(myRole) & ")")

        Console.ReadLine()
    End Sub
End Module