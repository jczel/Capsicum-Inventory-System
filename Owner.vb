Public Class Owner

    Private Sub Owner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim OwnerDashboard As New OwnerDashboard()

        Guna2Panel5.Controls.Clear()
        OwnerDashboard.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(OwnerDashboard)

    End Sub

End Class