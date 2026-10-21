Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Usermanagement

    Private Sub Usermanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        readdata()
        roless()
        gender()
        AutoNumber()
    End Sub

    Sub CreateNewAutoNumber()
        Try
            Dim cmd As New SqlCommand
            With cmd
                .Connection = sqlconn
                .CommandText = "SP_AutoNumber"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@pfx", "UID") '' Palitan nyo nalang si pfx
            End With
            cmd.ExecuteScalar()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub AutoNumber()
        Dim number As String
        query = "SELECT Max(NewNumber) FROM AutoNumber where pfx = @pfx"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@Pfx", "UID") '' Palitan nyo nalang si pfx
            If IsDBNull(cmd.ExecuteScalar) Then
                CreateNewAutoNumber()
                Dim number1 As String
                query = "SELECT Max(NewNumber) FROM AutoNumber where pfx = @pfx"
                cmd = New SqlClient.SqlCommand(query, sqlconn)
                With cmd
                    .Parameters.AddWithValue("@pfx", "UID") '' Palitan nyo nalang si pfx
                    number1 = Convert.ToString(cmd.ExecuteScalar)
                    userid.Text = number1 ''palitan textboxname
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                number = Convert.ToString(cmd.ExecuteScalar)
                userid.Text = number '' palitan textboxname
            End If
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Sub readdata()
        Guna2DataGridView1.Rows.Clear()
        query = "select * from UserAccount"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            Guna2DataGridView1.Rows.Add(dr("UserID"), dr("firstname"), dr("lastname"), dr("username"), dr("birthdate"), dr("password"), dr("role"), dr("gender"), dr("image"), "EDIT", "DELETE")
        End While

        cmd.Dispose()
        dr.Close()

        For i = 0 To Guna2DataGridView1.Rows.Count - 1

            Guna2DataGridView1.Rows(i).Height = 100
        Next


    End Sub

    Sub savedata()
        Dim ms As New MemoryStream
        Guna2PictureBox1.Image.Save(ms, Guna2PictureBox1.Image.RawFormat)
        query = "Insert into UserAccount (UserID, firstname, lastname, username, birthdate, password, role, gender, image) values (@UserID, @firstname, @lastname, @username, @birthdate, @password, @role, @gender, @image);"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd.Parameters
            .AddWithValue("@UserID", userid.Text)
            .AddWithValue("@firstname", firstname.Text)
            .AddWithValue("@lastname", lastname.Text)
            .AddWithValue("@username", username.Text)
            .AddWithValue("@password", password.Text)
            .AddWithValue("@role", rolecmbbox.Text)
            .AddWithValue("@gender", gendercmbox.Text)
            .AddWithValue("@image", ms.ToArray())

        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Sub updatedata()
        Dim ms As New MemoryStream
        Guna2PictureBox1.Image.Save(ms, Guna2PictureBox1.Image.RawFormat)

        query = "Update UserAccount set firstname = @firstname, username = @username, birthdate = @birthdate, 
                password = @password, role = @role, gender = @gender, image = @image where UserID = '" & userid.Text & "'"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd.Parameters
            .AddWithValue("@UserID", userid.Text)
            .AddWithValue("@firstname", firstname.Text)
            .AddWithValue("@lastname", lastname.Text)
            .AddWithValue("@username", username.Text)
            .AddWithValue("@password", password.Text)
            .AddWithValue("@role", rolecmbbox.Text)
            .AddWithValue("@gender", gendercmbox.Text)
            .AddWithValue("@image", ms.ToArray())

        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Sub delete(ByVal id As String)
        query = "Delete From UserAccount where UserID = @UserID"
        cmd = New SqlCommand(query, sqlconn)
        With cmd.Parameters
            .AddWithValue("@UserID", id.ToString)
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Sub viewimage()
        Dim img() As Byte
        query = "Select * from UserAccount where ID = '" & userid.Text & "'"
        cmd = New SqlCommand(query, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            If IsDBNull(dr("image")) Then
                Guna2PictureBox1.Image = Nothing
            Else
                img = dr("image")
                Dim ms As New MemoryStream(img)
                Guna2PictureBox1.Image = Image.FromStream(ms)
            End If
        End While
        dr.Close()
        cmd.Dispose()

    End Sub
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim i As Integer = Guna2DataGridView1.CurrentRow.Index
        If e.ColumnIndex = 8 Then
            userid.Text = Guna2DataGridView1.Item(0, i).Value
            firstname.Text = Guna2DataGridView1.Item(1, i).Value
            lastname.Text = Guna2DataGridView1.Item(2, i).Value
            username.Text = Guna2DataGridView1.Item(3, i).Value
            birthdate.Text = Guna2DataGridView1.Item(4, i).Value
            password.Text = Guna2DataGridView1.Item(5, i).Value
            confirmpass.Text = Guna2DataGridView1.Item(5, i).Value
            rolecmbbox.Text = Guna2DataGridView1.Item(6, i).Value
            gendercmbox.Text = Guna2DataGridView1.Item(7, i).Value
            viewimage()
        ElseIf e.ColumnIndex = 10 Then
            Dim confirm = MsgBox("Are you sure you want to delete this data?", MsgBoxStyle.YesNo)
            If confirm = MsgBoxResult.Yes Then
                delete(Guna2DataGridView1.Item(0, i).Value)
                readdata()
            End If
        End If

    End Sub

    Private Sub Guna2TextBox7_TextChanged(sender As Object, e As EventArgs) Handles userid.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If firstname.Text = "" Then MsgBox("First Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If lastname.Text = "" Then MsgBox("Last Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If username.Text = "" Then MsgBox("Username Cannot be blank", MsgBoxStyle.Critical) : Return
        If password.Text = "" Then MsgBox("Password Cannot be blank", MsgBoxStyle.Critical) : Return
        If gendercmbox.Text = "" Then MsgBox("Select Gender", MsgBoxStyle.Critical) : Return
        If Guna2PictureBox1.Text Is Nothing Then MsgBox("Image Cannot be blank", MsgBoxStyle.Critical) : Return


        If password.Text <> confirmpass.Text Then
            MsgBox("Password and confirm password does not match", MsgBoxStyle.Critical)
            password.Clear()
            confirmpass.Clear()
            Return
        End If


        If username.Text.Length < 6 OrElse password.Text.Length < 6 Then
            MsgBox("Username and Password must be atleast 6 characters", MsgBoxStyle.Critical)
            Return
        End If

        If Not Regex.IsMatch(username.Text, "[A-Z]") Then
            MsgBox("Username must have atleast 1 uppercase letter", MsgBoxStyle.Critical)
            Return
        End If

        If Not Regex.IsMatch(password.Text, "[0-9]") Then
            MsgBox("Password must have atleast 1 number ", MsgBoxStyle.Critical)
            Return
        End If

        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            query = "SELECT COUNT(*) FROM UserAccount WHERE username=@username"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@username", username.Text.Trim())
            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("Username already exists! Use another username.", MsgBoxStyle.Critical)
                username.Clear()
                sqlconn.Close()
                Return
            End If
            MsgBox("Data added")
            savedata()
                readdata()
                Clear()
                CreateNewAutoNumber()
                AutoNumber()
                sqlconn.Close()
        Catch ex As Exception
            MsgBox("Error checking duplicate: " & ex.Message)
            Return
        End Try


    End Sub

    Sub roless()
        rolecmbbox.Items.Clear()
        rolecmbbox.Items.Add("Admin")
        rolecmbbox.Items.Add("Owner")
        rolecmbbox.Items.Add("Staff")
    End Sub

    Sub gender()
        gendercmbox.Items.Clear()
        gendercmbox.Items.Add("Female")
        gendercmbox.Items.Add("Male")
    End Sub

    Sub Clear()
        firstname.Clear()
        lastname.Clear()
        username.Clear()
        password.Clear()
        confirmpass.Clear()
        gendercmbox.SelectedIndex = -1
        Guna2PictureBox1.Image = Nothing
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.FileName = "IMAGES FILES ONLY (*.jpg,*.png,*.gif|*.jpg; *.png; *.gif"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Guna2PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If firstname.Text = "" Then MsgBox("First Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If lastname.Text = "" Then MsgBox("Last Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If username.Text = "" Then MsgBox("Username Cannot be blank", MsgBoxStyle.Critical) : Return
        If password.Text = "" Then MsgBox("Password Cannot be blank", MsgBoxStyle.Critical) : Return
        If gendercmbox.Text = "" Then MsgBox("Select Gender", MsgBoxStyle.Critical) : Return


        If password.Text <> confirmpass.Text Then
            MsgBox("Password and confirm password does not match", MsgBoxStyle.Critical)
            password.Clear()
            confirmpass.Clear()
            Return
        End If


        If username.Text.Length < 6 OrElse password.Text.Length < 6 Then
            MsgBox("Username and Password must be atleast 6 characters", MsgBoxStyle.Critical)
            Return
        End If

        If Not Regex.IsMatch(username.Text, "[A-Z]") Then
            MsgBox("Username must have atleast 1 uppercase letter", MsgBoxStyle.Critical)
            Return
        End If

        If Not Regex.IsMatch(password.Text, "[0-9]") Then
            MsgBox("Password must have atleast 1 number ", MsgBoxStyle.Critical)
            Return
        End If

        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            query = "SELECT COUNT(*) FROM UserAccount WHERE username=@username"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@username", username.Text.Trim())
            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("Username already exists! Use another username.", MsgBoxStyle.Critical)
                username.Clear()
                sqlconn.Close()
                Return
            End If
            MsgBox("Data added")
            updatedata()
            readdata()
            Clear()
            AutoNumber()
            sqlconn.Close()
        Catch ex As Exception
            MsgBox("Error checking duplicate: " & ex.Message)
            Return
        End Try


    End Sub
    Private Sub Guna2DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Guna2DataGridView1.DataError
        e.ThrowException = False
        e.Cancel = False
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub firstname_TextChanged(sender As Object, e As EventArgs) Handles firstname.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



End Class