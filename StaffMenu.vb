Public Class StaffMenu
    Private Sub allitmbtn_Click(sender As Object, e As EventArgs) Handles allitmbtn.Click

    End Sub

    Private Sub allitmbtn_MouseHover(sender As Object, e As EventArgs) Handles allitmbtn.MouseHover
        allitmbtn.ShadowDecoration.Enabled = False
    End Sub

    Private Sub allitmbtn_MouseLeave(sender As Object, e As EventArgs) Handles allitmbtn.MouseLeave
        allitmbtn.ShadowDecoration.Enabled = True
    End Sub
End Class
