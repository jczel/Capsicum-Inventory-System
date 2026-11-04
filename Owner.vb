Public Class Owner

    Private Sub Owner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim OwnerDashboard As New OwnerDashboard()

        Display.Controls.Clear()
        OwnerDashboard.Dock = DockStyle.Fill
        Display.Controls.Add(OwnerDashboard)

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) 
        Form1login.Show()
        Me.Hide()
    End Sub

    Private Sub Owner_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub printreportbtn_Click(sender As Object, e As EventArgs) 

        Dim OwnerPrintReport As New OwnerPrintReport()
        Display.Controls.Clear()
        OwnerPrintReport.Dock = DockStyle.Fill
        Display.Controls.Add(OwnerPrintReport)
    End Sub
End Class