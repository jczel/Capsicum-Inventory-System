Public Class StaffDashboard

    Private Sub StaffDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        namelb.Text = LoggedFirstName

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelb.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        timelb.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub
End Class
