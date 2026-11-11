Imports System.Data.SqlClient

Public Class Admin
    Dim admindash As New AdminDashboard

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            query = "SELECT image FROM UserAccount WHERE UserID = @UserID"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@UserID", LoggedUserID)
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


    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub logoutbttn_Click_1(sender As Object, e As EventArgs) Handles logoutbttn.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            LoggedUserID = Nothing
            LoggedUsername = Nothing
            LoggedRole = Nothing
            LoggedFirstName = Nothing
            LoggedLastName = Nothing
            LoggedImage = Nothing


            For Each f As Form In Application.OpenForms
                If TypeOf f Is Form1login Then
                    Dim login As Form1login = DirectCast(f, Form1login)
                    login.usernametxtbx.Clear()
                    login.passwordtxtbx.Clear()
                    login.showpasschcbx.Checked = False
                    login.passwordtxtbx.PasswordChar = "*"c
                    login.Show()
                    Me.Close()
                    Return
                End If
            Next


            Dim newLogin As New Form1login()
            newLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Menubttn_Click(sender As Object, e As EventArgs) Handles Menubttn.Click
        Dim menuu As New Menucntrl
        Dsplaypnl.Controls.Clear()
        menuu.Dock = DockStyle.Fill
        Dsplaypnl.Controls.Add(menuu)

    End Sub
End Class