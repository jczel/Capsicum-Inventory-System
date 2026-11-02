Public Class Menucntrl

    Dim product As New Menu
    Private Sub Menucntrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim menu As New Menu
        Guna2Panel11.Controls.Clear()
        product.Dock = DockStyle.Fill
        Guna2Panel11.Controls.Add(product)
    End Sub



    Private Sub AddOnsbttn_Click(sender As Object, e As EventArgs)
        Guna2Panel11.Controls.Clear()
        product.Dock = DockStyle.Fill
        Guna2Panel11.Controls.Add(product)
    End Sub


End Class
