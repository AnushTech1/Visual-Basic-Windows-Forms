Public Class Form1
    Dim lbl As New Label()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl.AutoSize = True
        lbl.Location = New Point(30%, 50%)
        lbl.Visible = False
        Me.Controls.Add(lbl)
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            lbl.Text = "This is green color"
            lbl.ForeColor = Color.White
            lbl.BackColor = Color.Green
            lbl.Visible = True
        Else
            lbl.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            lbl.BackColor = Color.Red
            lbl.ForeColor = Color.White
            lbl.Text = "This is red color"
            lbl.Visible = True
        Else
            lbl.Visible = False
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            lbl.BackColor = Color.Blue
            lbl.ForeColor = Color.White
            lbl.Text = "This is blue color"
            lbl.Visible = True
        Else
            lbl.Visible = False
        End If
    End Sub

End Class
