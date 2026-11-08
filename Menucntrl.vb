Public Class Menucntrl

    Dim product As New Menu

    Private Sub Menucntrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Panel11.Controls.Clear()
        product.Dock = DockStyle.Fill
        Guna2Panel11.Controls.Add(product)
    End Sub

    Private Sub allprdbttn_Click(sender As Object, e As EventArgs) Handles allprdbttn.Click
        product.loadGrouped("All")
    End Sub

    Private Sub hotCofbttn_Click(sender As Object, e As EventArgs) Handles hotCofbttn.Click
        product.loadGrouped("Hot Coffee")
    End Sub

    Private Sub coldCofbttn_Click(sender As Object, e As EventArgs) Handles coldCofbttn.Click
        product.loadGrouped("Cold Coffee")
    End Sub

    Private Sub teabttn_Click(sender As Object, e As EventArgs) Handles teabttn.Click
        product.loadGrouped("Tea")
    End Sub

    Private Sub Dssrtbttn_Click(sender As Object, e As EventArgs) Handles Dssrtbttn.Click
        product.loadGrouped("Desserts")
    End Sub

    Private Sub AddOnsbttn_Click_1(sender As Object, e As EventArgs) Handles AddOnsbttn.Click
        product.loadGrouped("Add-ons")
    End Sub

    Private Sub Guna2Panel11_Paint(sender As Object, e As PaintEventArgs)

    End Sub


End Class