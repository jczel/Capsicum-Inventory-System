Imports System.Data.SqlClient

Public Class Staff

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Dim menu As New Menucntrl
        Guna2Panel5.Controls.Clear()
        menu.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(menu)
        showUser(namelb, rolelb)
    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
        Form1login.Show()
        Me.Hide()
    End Sub

    Private Sub Staff_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Menubtn_Click(sender As Object, e As EventArgs) Handles Menubtn.Click
        Dim menu As New Menucntrl
        Guna2Panel5.Controls.Clear()
        menu.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(menu)
    End Sub

    Private Sub productinfobtn_Click(sender As Object, e As EventArgs) Handles productinfobtn.Click
        loadform(New MenuMngment)
    End Sub

    Private Sub loadform(childform As Form)
        Guna2Panel5.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(childform)
        childform.Show()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Form1login.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Panel5_Paint_1(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles rolelb.Click

    End Sub
End Class