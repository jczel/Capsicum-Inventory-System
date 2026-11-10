Public Class Owner

    Private Sub Owner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim OwnerDashboard As New OwnerDashboard()

        Displaypnl.Controls.Clear()
        OwnerDashboard.Dock = DockStyle.Fill
        Displaypnl.Controls.Add(OwnerDashboard)

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
        Form1login.Show()
        Me.Hide()
    End Sub

    Private Sub Owner_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub


    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        Form1login.Show()
        Me.Hide()
    End Sub

    Private Sub transachistrybtn_Click(sender As Object, e As EventArgs) Handles transachistrybtn.Click
        Dim transactionhistoryy As New TransactionHistoryCntrl
        Displaypnl.Controls.Clear()
        transactionhistoryy.Dock = DockStyle.Fill
        Displaypnl.Controls.Add(transactionhistoryy)
    End Sub

    Private Sub Dashbrdbtn_Click(sender As Object, e As EventArgs) Handles Dashbrdbtn.Click
        Dim Ownerdashboard As New OwnerDashboard()
        Displaypnl.Controls.Clear()
        Ownerdashboard.Dock = DockStyle.Fill
        Displaypnl.Controls.Add(Ownerdashboard)
    End Sub

    Private Sub generatereportbtn_Click(sender As Object, e As EventArgs) Handles generatereportbtn.Click
        loadform(New GenerateReport)
    End Sub

    Private Sub loadform(childform As Form)
        Displaypnl.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        Displaypnl.Controls.Add(childform)
        childform.Show()
    End Sub
End Class