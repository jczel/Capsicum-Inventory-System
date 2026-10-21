Public Class OwnerDashboard

    Private Sub OwnerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        namelb.Text = LoggedFirstName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelb.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        timelb.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub namelb_Click(sender As Object, e As EventArgs) Handles namelb.Click

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub todaysalesnumlb_Click(sender As Object, e As EventArgs) Handles todaysalesnumlb.Click

    End Sub
End Class
