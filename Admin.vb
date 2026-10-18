Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adminDashboard As New AdminDashboard()
        Guna2Panel5.Controls.Clear()
        adminDashboard.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(adminDashboard)

    End Sub

    Private Sub manageUserAccbttn_Click(sender As Object, e As EventArgs) Handles manageUserAccbttn.Click
        Dim userRec As New UserRecords()
        Guna2Panel5.Controls.Clear()
        userRec.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(userRec)
    End Sub

    Private Sub logoutbttn_Click(sender As Object, e As EventArgs)
        Form1login.Show()
        Me.Hide()
    End Sub



    Private Sub Admin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
