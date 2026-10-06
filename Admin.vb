Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adminDashboard As New AdminDashboard()
        Guna2Panel5.Controls.Clear()
        adminDashboard.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(adminDashboard)

    End Sub


End Class
