Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form1login




    Private Sub showpasschcbx_CheckedChanged(sender As Object, e As EventArgs) Handles showpasschcbx.CheckedChanged

        If showpasschcbx.Checked = True Then
            passwordtxtbx.PasswordChar = ""
        Else
            passwordtxtbx.PasswordChar = "*"

        End If
    End Sub


    Private Sub loginbttn_Click_1(sender As Object, e As EventArgs) Handles loginbttn.Click
        If usernametxtbx.Text = "" AndAlso passwordtxtbx.Text = "" Then
            MsgBox("Username and Password cannot be blank", MsgBoxStyle.Critical)
            Return
        ElseIf usernametxtbx.Text = "" Then
            MsgBox("Username cannot be blank", MsgBoxStyle.Critical)
            Return
        ElseIf passwordtxtbx.Text = "" Then
            MsgBox("Password cannot be blank", MsgBoxStyle.Critical)
            Return
        End If

        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            query = "SELECT UserID, username, role, firstname, lastname, image FROM UserAccount WHERE username=@username AND password=@password"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@username", usernametxtbx.Text.Trim())
            cmd.Parameters.AddWithValue("@password", passwordtxtbx.Text)

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then

                LoggedUserID = dr("UserID").ToString()
                LoggedUsername = dr("username").ToString()
                LoggedRole = dr("role").ToString().Trim()
                LoggedFirstName = dr("firstname").ToString()
                LoggedLastName = dr("lastname").ToString()

                If Not IsDBNull(dr("image")) Then
                    LoggedImage = DirectCast(dr("image"), Byte())
                Else
                    LoggedImage = Nothing
                End If

                dr.Close()
                sqlconn.Close()

                MessageBox.Show("Login success! Welcome " & LoggedFirstName)


                If LoggedRole = "Owner" Then
                    Dim f As New Owner()
                    f.Show()
                    Me.Hide()
                ElseIf LoggedRole = "Admin" Then
                    Dim f As New Admin()
                    f.Show()
                    Me.Hide()
                ElseIf LoggedRole = "Staff" Then
                    Dim f As New Staff()
                    f.Show()
                    Me.Hide()
                End If

            Else
                dr.Close()
                sqlconn.Close()
                MsgBox("Invalid username or password!", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MessageBox.Show("Login Error: " & ex.Message)
        Finally
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub




    Private Sub Form1login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If LoggedUserID Is Nothing Then
            Application.Exit()
        End If
    End Sub


    Private Sub Form1login_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            usernametxtbx.Clear()
            passwordtxtbx.Clear()
            showpasschcbx.Checked = False
            passwordtxtbx.PasswordChar = "*"c
            usernametxtbx.Focus()
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
