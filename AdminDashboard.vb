Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelb.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        timelb.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub


End Class
