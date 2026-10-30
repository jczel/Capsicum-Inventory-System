Public Class Menucntrl
    Private Sub Menucntrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim product As New Menu
        Guna2Panel11.Controls.Clear()
        product.Dock = DockStyle.Fill
        Guna2Panel11.Controls.Add(product)
    End Sub
End Class
