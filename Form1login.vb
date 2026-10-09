Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Web.Security

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

            query = "SELECT role FROM Users WHERE username=@username AND password=@password"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@username", usernametxtbx.Text.Trim())
            cmd.Parameters.AddWithValue("@password", passwordtxtbx.Text)


            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                Dim role As String = dr("role").ToString().Trim()
                dr.Close()
                sqlconn.Close()

                MessageBox.Show("Login success! ")

                If role = "Owner" Then
                    Dim f As New Owner()
                    f.Show()
                    Me.Hide()
                ElseIf role = "Admin" Then
                    Dim f As New Admin()
                    f.Show()
                    Me.Hide()
                ElseIf role = "Staff" Then
                    Dim f As New Staff()
                    f.Show()
                    Me.Hide()
                End If

            Else

                dr.Close()
                sqlconn.Close()
                MsgBox("Invalid username or password! User not found in table Users.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MessageBox.Show("Login Error: " & ex.Message)
        Finally
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Private Sub createaccntlinklb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub passwordtxtbx_TextChanged(sender As Object, e As EventArgs) Handles passwordtxtbx.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
