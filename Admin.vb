Imports System.Data.SqlClient

Public Class Admin
    Dim admindash As New AdminDashboard

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            query = "SELECT image FROM UserAccount WHERE UserID = @id"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@id", LoggedUserID)
            Dim result As Object = cmd.ExecuteScalar()
            sqlconn.Close()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Dim imgBytes As Byte() = DirectCast(result, Byte())
                Dim ms As New IO.MemoryStream(imgBytes)
                Guna2PictureBox1.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dsplaypnl.Controls.Clear()
        admindash.Dock = DockStyle.Fill
        Dsplaypnl.Controls.Add(admindash)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles MangAccbtn.Click
        OpenAdminChildForm(New ManageAcc)
    End Sub


    Private Sub OpenAdminChildForm(childForm As Form)

        Dsplaypnl.Controls.Clear()

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        Dsplaypnl.Controls.Add(childForm)

        childForm.Show()

    End Sub

    Private Sub Dashboardbtn_Click(sender As Object, e As EventArgs) Handles Dashboardbtn.Click
        Dsplaypnl.Controls.Clear()
        admindash.Dock = DockStyle.Fill
        Dsplaypnl.Controls.Add(admindash)
    End Sub

    Private Sub MngInvtrybtn_Click(sender As Object, e As EventArgs) Handles MngInvtrybtn.Click

        OpenAdminChildForm(New MenuMngment)



    End Sub

    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        Form1login.Show()
        Me.Hide()
    End Sub
End Class