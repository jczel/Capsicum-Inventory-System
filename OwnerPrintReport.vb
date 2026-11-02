Public Class OwnerPrintReport
    Private Sub subnumlb_Click(sender As Object, e As EventArgs) Handles subnumlb.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelb.Text = DateTime.Now.ToString("MMM/dd/yyyy")
    End Sub

    Private Sub OwnerPrintReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
