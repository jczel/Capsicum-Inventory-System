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

    Private Sub allprdbttn_Click(sender As Object, e As EventArgs) Handles allprdbttn.Click
        Dim menuUC As Menu = TryCast(Me.ParentForm.Controls.Find("Menu1", True).FirstOrDefault(), Menu)
        If menuUC IsNot Nothing Then menuUC.loadGrouped("All")
    End Sub

    Private Sub hotCofbttn_Click(sender As Object, e As EventArgs) Handles hotCofbttn.Click
        Dim menuUC As Menu = TryCast(Me.ParentForm.Controls.Find("Menu1", True).FirstOrDefault(), Menu)
        If menuUC IsNot Nothing Then menuUC.loadGrouped("Hot Coffee")
    End Sub

    Private Sub coldCofbttn_Click(sender As Object, e As EventArgs) Handles coldCofbttn.Click
        Dim menuUC As Menu = TryCast(Me.ParentForm.Controls.Find("Menu1", True).FirstOrDefault(), Menu)
        If menuUC IsNot Nothing Then menuUC.loadGrouped("Cold Coffee")
    End Sub

    Private Sub teabttn_Click(sender As Object, e As EventArgs) Handles teabttn.Click
        Dim menuUC As Menu = TryCast(Me.ParentForm.Controls.Find("Menu1", True).FirstOrDefault(), Menu)
        If menuUC IsNot Nothing Then menuUC.loadGrouped("Tea")
    End Sub

    Private Sub Dssrtbttn_Click(sender As Object, e As EventArgs) Handles Dssrtbttn.Click
        Dim menuUC As Menu = TryCast(Me.ParentForm.Controls.Find("Menu1", True).FirstOrDefault(), Menu)
        If menuUC IsNot Nothing Then menuUC.loadGrouped("Desert")
    End Sub

    Private Sub AddOnsbttn_Click_1(sender As Object, e As EventArgs) Handles AddOnsbttn.Click

    End Sub
End Class
