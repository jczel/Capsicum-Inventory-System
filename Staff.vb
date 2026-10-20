Public Class Staff
    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim menu As New Menu
        Guna2Panel5.Controls.Clear()
        menu.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(menu)

    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Form1login.Show()
        Me.Hide()
    End Sub

    Private Sub Staff_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click


    End Sub
End Class