Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class CreateAccount

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        gender()
        usertype()
    End Sub

    Sub savedata()
        Try
            If sqlconn.State = ConnectionState.Closed Then
                sqlconn.Open()
            End If

            query = "INSERT INTO USER_ACCOUNT (firstname, lastname, username, birthdate, password, usertype, gender) VALUES (@firstname, @lastname, @username, @birthdate, @password, @usertype, @gender)"
            cmd = New SqlCommand(query, sqlconn)
            With cmd.Parameters
                .AddWithValue("@firstname", fnametxtbx.Text.Trim())
                .AddWithValue("@lastname", lastnametxtbx.Text.Trim())
                .AddWithValue("@username", usernametxtbx.Text.Trim())
                .AddWithValue("@birthdate", birthdatetimepicker.Value.Date)
                .AddWithValue("@password", passwtxtbx.Text)
                .AddWithValue("@usertype", usetypecmbbx.Text)
                .AddWithValue("@gender", gendercmbbx.Text)
            End With
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try
    End Sub

    Private Sub registerbttn_Click(sender As Object, e As EventArgs) Handles registerbttn.Click


        If fnametxtbx.Text = "" Then MsgBox("First Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If lastnametxtbx.Text = "" Then MsgBox("Last Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If usernametxtbx.Text = "" Then MsgBox("Username Cannot be blank", MsgBoxStyle.Critical) : Return
        If passwtxtbx.Text = "" Then MsgBox("Password Cannot be blank", MsgBoxStyle.Critical) : Return
        If usetypecmbbx.Text = "" Then MsgBox("Select User Type", MsgBoxStyle.Critical) : Return
        If gendercmbbx.Text = "" Then MsgBox("Select Gender", MsgBoxStyle.Critical) : Return


        If passwtxtbx.Text <> confirmpasswtxtbx.Text Then
            MsgBox("Password and confirm password does not match", MsgBoxStyle.Critical)
            passwtxtbx.Clear()
            confirmpasswtxtbx.Clear()
            Return
        End If


        If usernametxtbx.Text.Length < 6 OrElse passwtxtbx.Text.Length < 6 Then
            MsgBox("Username and Password must be atleast 6 characters", MsgBoxStyle.Critical)
            Return
        End If

        If Not Regex.IsMatch(usernametxtbx.Text, "[A-Z]") Then
            MsgBox("Username must have atleast 1 uppercase letter", MsgBoxStyle.Critical)
            Return
        End If

        If Not Regex.IsMatch(passwtxtbx.Text, "[0-9]") Then
            MsgBox("Password must have atleast 1 number ", MsgBoxStyle.Critical)
            Return
        End If

        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            query = "SELECT COUNT(*) FROM USER_ACCOUNT WHERE username=@username"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@username", usernametxtbx.Text.Trim())
            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("Username already exists! Use another username.", MsgBoxStyle.Critical)
                usernametxtbx.Clear()
                sqlconn.Close()
                Return
            End If
            sqlconn.Close()
        Catch ex As Exception
            MsgBox("Error checking duplicate: " & ex.Message)
            Return
        End Try


        savedata()

    End Sub

    Sub usertype()
        usetypecmbbx.Items.Clear()
        usetypecmbbx.Items.Add("Admin")
        usetypecmbbx.Items.Add("Staff")
        usetypecmbbx.Items.Add("Owner")
    End Sub

    Sub gender()
        gendercmbbx.Items.Clear()
        gendercmbbx.Items.Add("Female")
        gendercmbbx.Items.Add("Male")
    End Sub

    Sub Clear()
        fnametxtbx.Clear()
        lastnametxtbx.Clear()
        usernametxtbx.Clear()
        passwtxtbx.Clear()
        confirmpasswtxtbx.Clear()
        usetypecmbbx.SelectedIndex = -1
        gendercmbbx.SelectedIndex = -1
    End Sub

    Private Sub registerpanel_Paint(sender As Object, e As PaintEventArgs) Handles registerpanel.Paint

    End Sub
End Class