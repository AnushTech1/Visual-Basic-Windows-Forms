
Imports System.Data.OleDb

Public Class Form1
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\anush\OneDrive\Documents\studentDB.accdb")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            Dim query As String = "INSERT INTO Users (Name, Email, Gender, Contact) VALUES (?, ?, ?, ?)"
            cmd = New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", TextBox1.Text)
            cmd.Parameters.AddWithValue("?", TextBox2.Text)
            cmd.Parameters.AddWithValue("?", TextBox3.Text)
            cmd.Parameters.AddWithValue("?", TextBox4.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Inserted Successfully")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            con.Open()
            Dim query As String = "UPDATE Users SET Email=?, Gender=?, Contact=? WHERE Name=?"
            cmd = New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", TextBox2.Text)
            cmd.Parameters.AddWithValue("?", TextBox3.Text)
            cmd.Parameters.AddWithValue("?", TextBox4.Text)
            cmd.Parameters.AddWithValue("?", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Updated Successfully")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim query As String = "DELETE FROM Users WHERE Name=?"
            cmd = New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Deleted Successfully")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            con.Open()
            Dim query As String = "SELECT * FROM Users WHERE Name=?"
            cmd = New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", TextBox1.Text)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                TextBox2.Text = reader("Email").ToString()
                TextBox3.Text = reader("Gender").ToString()
                TextBox4.Text = reader("Contact").ToString()
            Else
                MessageBox.Show("No Record Found")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            con.Open()
            da = New OleDbDataAdapter("SELECT * FROM Users", con)
            dt = New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
