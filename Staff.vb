Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Staff

    Sub viewimage()
        Try
            Dim img() As Byte
            query = "Select image from UserAccount where username = @username"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@username", LoggedUsername)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                If IsDBNull(dr("image")) Then
                    Guna2PictureBox1.Image = Nothing
                Else
                    img = CType(dr("image"), Byte())
                    Using ms As New MemoryStream(img)
                        Guna2PictureBox1.Image = Image.FromStream(ms)
                    End Using
                End If
            End If
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        connect()
        Dim menu As New Menucntrl
        Guna2Panel5.Controls.Clear()
        menu.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(menu)
        showUser(namelb, rolelb)
        viewimage()

    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
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

    Private Sub transactionhisbtn_Click(sender As Object, e As EventArgs) Handles transactionhisbtn.Click
        Dim transactionhistory As New TransactionHistoryCntrl
        Guna2Panel5.Controls.Clear()
        transactionhistory.Dock = DockStyle.Fill
        Guna2Panel5.Controls.Add(transactionhistory)
    End Sub
End Class