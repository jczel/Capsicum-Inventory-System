Public Class Owner

    Private Sub Owner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim OwnerDashboard As New OwnerDashboard()

        Guna2Panel5.Controls.Clear()
        OwnerDashboard.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(OwnerDashboard)

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Form1login.Show()
        Me.Hide()
    End Sub

    Private Sub Owner_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class