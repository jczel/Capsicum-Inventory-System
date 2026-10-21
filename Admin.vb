Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adminDashboard As New AdminDashboard()
        Guna2Panel5.Controls.Clear()
        adminDashboard.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(adminDashboard)

    End Sub



    Private Sub Admin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub logoutbttn_Click_1(sender As Object, e As EventArgs)
        Form1login.Show()
        Me.Hide()
    End Sub



    Private Sub Admin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
