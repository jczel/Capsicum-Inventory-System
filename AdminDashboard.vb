Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        userCounts(totalusersnumlb)
        productCounts(totalprodnumlb)
        showUser(namelb, adminlb)
        totalStock(totalstocknumlb)
        Timer1.Start()
        namelb.Text = LoggedFirstName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelb.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        timelb.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub todaysnumofTransnumlb_Click(sender As Object, e As EventArgs) Handles todaysnumofTransnumlb.Click

    End Sub
End Class
