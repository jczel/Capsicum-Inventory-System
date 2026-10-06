Public Class Staff
    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim StaffDashboard As New StaffDashboard()
        Guna2Panel5.Controls.Clear()
        StaffDashboard.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(StaffDashboard)

    End Sub


End Class