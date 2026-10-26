Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Usermanagement

    Private Sub Usermanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
        readdata()
        roless()
        gender()
        AutoNumber()
    End Sub

    Sub AutoNumber()
        Try
            query = "SELECT Max(NewNumber) FROM AutoNumber where pfx = @pfx"
            cmd = New SqlClient.SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@pfx", "UID")
            Dim result As Object = cmd.ExecuteScalar()
            cmd.Dispose()

            If IsDBNull(result) OrElse result Is Nothing Then
                CreateNewAutoNumber()
                query = "SELECT Max(NewNumber) FROM AutoNumber where pfx = @pfx"
                cmd = New SqlClient.SqlCommand(query, sqlconn)
                cmd.Parameters.AddWithValue("@pfx", "UID")
                userid.Text = Convert.ToString(cmd.ExecuteScalar())
                cmd.Dispose()
            Else
                userid.Text = Convert.ToString(result)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CreateNewAutoNumber()
        Try
            Dim cmd2 As New SqlCommand("SP_AutoNumber", sqlconn)
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.Parameters.AddWithValue("@pfx", "UID")
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub readdata()
        Try
            Guna2DataGridView1.Rows.Clear()
            query = "select * from UserAccount"
            cmd = New SqlClient.SqlCommand(query, sqlconn)
            dr = cmd.ExecuteReader()
            While dr.Read

                Guna2DataGridView1.Rows.Add(dr("UserID").ToString(), dr("firstname"), dr("lastname"), dr("username"), dr("birthdate"), dr("password"), dr("role"), dr("gender"), dr("image"), "EDIT", "DELETE")
            End While
            dr.Close()
            cmd.Dispose()

            For i = 0 To Guna2DataGridView1.Rows.Count - 1
                Guna2DataGridView1.Rows(i).Height = 100
            Next
        Catch ex As Exception
            MsgBox("readdata error: " & ex.Message)
        End Try
    End Sub

    Sub savedata()
        Dim imgData As Object = DBNull.Value
        If Guna2PictureBox1.Image IsNot Nothing Then
            Using ms As New MemoryStream
                Guna2PictureBox1.Image.Save(ms, Guna2PictureBox1.Image.RawFormat)
                imgData = ms.ToArray()
            End Using
        End If

        query = "Insert into UserAccount (UserID, firstname, lastname, username, birthdate, password, role, gender, image) values (@UserID, @firstname, @lastname, @username, @birthdate, @password, @role, @gender, @image)"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd.Parameters
            .AddWithValue("@UserID", userid.Text)
            .AddWithValue("@firstname", firstname.Text)
            .AddWithValue("@lastname", lastname.Text)
            .AddWithValue("@username", username.Text)
            .AddWithValue("@birthdate", birthdate.Value.Date)
            .AddWithValue("@password", password.Text)
            .AddWithValue("@role", rolecmbbox.Text)
            .AddWithValue("@gender", gendercmbox.Text)
            .AddWithValue("@image", imgData) ' WALANG ()
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Sub updatedata()
        Dim imgData As Object = DBNull.Value
        If Guna2PictureBox1.Image IsNot Nothing Then
            Using ms As New MemoryStream
                Guna2PictureBox1.Image.Save(ms, Guna2PictureBox1.Image.RawFormat)
                imgData = ms.ToArray()
            End Using
        End If

        query = "Update UserAccount set firstname=@firstname, lastname=@lastname, username=@username, birthdate=@birthdate, password=@password, role=@role, gender=@gender, image=@image where UserID=@UserID"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd.Parameters
            .AddWithValue("@UserID", userid.Text)
            .AddWithValue("@firstname", firstname.Text)
            .AddWithValue("@lastname", lastname.Text)
            .AddWithValue("@username", username.Text)
            .AddWithValue("@birthdate", birthdate.Value.Date)
            .AddWithValue("@password", password.Text)
            .AddWithValue("@role", rolecmbbox.Text)
            .AddWithValue("@gender", gendercmbox.Text)
            .AddWithValue("@image", imgData)
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Sub delete(ByVal id As String)
        query = "Delete From UserAccount where UserID = @UserID"
        cmd = New SqlCommand(query, sqlconn)
        cmd.Parameters.AddWithValue("@UserID", id)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Sub viewimage()
        Try
            Dim img() As Byte
            query = "Select image from UserAccount where UserID = @UserID"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@UserID", userid.Text)
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

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim i As Integer = e.RowIndex
        If e.ColumnIndex = 9 Then
            userid.Text = Guna2DataGridView1.Item(0, i).Value.ToString()
            firstname.Text = Guna2DataGridView1.Item(1, i).Value.ToString()
            lastname.Text = Guna2DataGridView1.Item(2, i).Value.ToString()
            username.Text = Guna2DataGridView1.Item(3, i).Value.ToString()
            birthdate.Text = Guna2DataGridView1.Item(4, i).Value.ToString()
            password.Text = Guna2DataGridView1.Item(5, i).Value.ToString()
            confirmpass.Text = Guna2DataGridView1.Item(5, i).Value.ToString()
            rolecmbbox.Text = Guna2DataGridView1.Item(6, i).Value.ToString()
            gendercmbox.Text = Guna2DataGridView1.Item(7, i).Value.ToString()
            viewimage()
        ElseIf e.ColumnIndex = 10 Then
            Dim confirm = MsgBox("Are you sure you want to delete this data?", MsgBoxStyle.YesNo)
            If confirm = MsgBoxResult.Yes Then
                delete(Guna2DataGridView1.Item(0, i).Value.ToString())
                readdata()
                AutoNumber()
            End If
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If firstname.Text = "" Then MsgBox("First Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If lastname.Text = "" Then MsgBox("Last Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If username.Text = "" Then MsgBox("Username Cannot be blank", MsgBoxStyle.Critical) : Return
        If password.Text = "" Then MsgBox("Password Cannot be blank", MsgBoxStyle.Critical) : Return
        If gendercmbox.Text = "" Then MsgBox("Select Gender", MsgBoxStyle.Critical) : Return
        If Guna2PictureBox1.Text Is Nothing Then MsgBox("Image Cannot be blank", MsgBoxStyle.Critical) : Return


        If Not Regex.IsMatch(firstname.Text.Trim(), "^[a-zA-Z ]+$") Then
            MsgBox("First Name must contain letters only", MsgBoxStyle.Critical)
            Return
        End If

        If Not Regex.IsMatch(lastname.Text.Trim(), "^[a-zA-Z ]+$") Then
            MsgBox("Last Name must contain letters only", MsgBoxStyle.Critical)
            Return
        End If

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
        OpenFileDialog1.FileName = "IMAGES FILES ONLY (.jpg,.png,*.gif|*.jpg; *.png; *.gif"
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

        If Not Regex.IsMatch(firstname.Text.Trim(), "^[a-zA-Z ]+$") Then
            MsgBox("First Name must contain letters only", MsgBoxStyle.Critical)
            Return
        End If

        If Not Regex.IsMatch(lastname.Text.Trim(), "^[a-zA-Z ]+$") Then
            MsgBox("Last Name must contain letters only", MsgBoxStyle.Critical)
            Return
        End If



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

End Class