Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class loginform




    Private Sub showpasschcbx_CheckedChanged(sender As Object, e As EventArgs) Handles showpasschcbx.CheckedChanged

        If showpasschcbx.Checked = True Then
            passwordtxtbx.PasswordChar = ""
        Else
            passwordtxtbx.PasswordChar = "*"

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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

            query = "SELECT * FROM USER_ACCOUNT WHERE username=@username AND password=@password"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@username", usernametxtbx.Text.Trim())
            cmd.Parameters.AddWithValue("@password", passwordtxtbx.Text)

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Login successfully", MsgBoxStyle.Information)

            Else
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlconn.Close()
        End Try

    End Sub

    Private Sub createaccntlinklb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles createaccntlinklb.LinkClicked
        CreateAccount.Show()
        Me.Hide()
    End Sub



    Private Sub systemtitlelb_Click(sender As Object, e As EventArgs) Handles systemtitlelb.Click

    End Sub
End Class
