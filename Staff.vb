Public Class Staff
    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim staffMenu As New StaffMenu()
        Guna2Panel5.Controls.Clear()
        staffMenu.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(staffMenu)

    End Sub


End Class