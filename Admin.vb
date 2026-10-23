Public Class Admin
    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim admindash As New AdminDashboard
        Guna2Panel5.Controls.Clear()
        admindash.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(admindash)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class