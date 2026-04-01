Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim child As New ChildForm()
        child.MdiParent = Me
        child.Show()
    End Sub
End Class