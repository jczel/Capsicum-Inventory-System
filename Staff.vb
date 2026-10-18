Public Class Staff
    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim menu As New Menu
        Guna2Panel5.Controls.Clear()
        menu.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(menu)

    End Sub

    Private Sub Guna2Panel5_Paint_1(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub
End Class