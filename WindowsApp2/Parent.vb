Public Class Parent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim child As New Childern()
        child.MdiParent = Me
        child.Show()
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
