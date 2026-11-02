Public Class Admin
    Dim admindash As New AdminDashboard

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dsplaypnl.Controls.Clear()
        admindash.Dock = DockStyle.Fill
        Dsplaypnl.Controls.Add(admindash)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles MangAccbtn.Click
        OpenAdminChildForm(New ManageAcc)
    End Sub


    Private Sub OpenAdminChildForm(childForm As Form)

        Dsplaypnl.Controls.Clear()

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        Dsplaypnl.Controls.Add(childForm)

        childForm.Show()

    End Sub

    Private Sub Dashboardbtn_Click(sender As Object, e As EventArgs) Handles Dashboardbtn.Click
        Dsplaypnl.Controls.Clear()
        admindash.Dock = DockStyle.Fill
        Dsplaypnl.Controls.Add(admindash)
    End Sub

    Private Sub MngInvtrybtn_Click(sender As Object, e As EventArgs) Handles MngInvtrybtn.Click

        OpenAdminChildForm(New MenuMngment)



    End Sub

    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        Form1login.Show()
        Me.Hide()
    End Sub
End Class