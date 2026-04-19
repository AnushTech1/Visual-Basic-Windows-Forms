Public Class DateTimeFunctions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Current Date And Time
        Dim currentDateTime As DateTime = DateTime.Now
        MessageBox.Show("current date and time is :" & currentDateTime.ToString())

        'Add 5 Days to Current Date
        Dim futureDate As DateTime = currentDateTime.AddDays(5)
        MessageBox.Show("Date after 5 days: " & futureDate.ToString("dd-MM-yyyy"))

        'Difference between two days
        Dim startDate As DateTime = DateTime.Parse("2025-08-01")
        Dim endDate As DateTime = DateTime.Now
        Dim diff As TimeSpan = endDate - startDate
        MessageBox.Show("Days difference between is :" & diff.TotalDays.ToString())

        'Display year,month,day,hour
        Dim now As DateTime = DateTime.Now
        Dim details As String = "year: " & now.Year & vbCrLf &
                                "months: " & now.Month & vbCrLf &
                                "day: " & now.Day & vbCrLf &
                                "hours: " & now.Hour
        MessageBox.Show(details)
    End Sub
End Class