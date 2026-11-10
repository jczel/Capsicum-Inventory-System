Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms
Imports System.Drawing.Imaging

Public Class ManageAcc


    Private Sub EnsureOpen()
        connect()
        If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

    End Sub

    Sub AutoNumber()
        Try
            EnsureOpen()
            query = "SELECT ISNULL(MAX(CAST(SUBSTRING(UserID, 4, 10) AS INT)), 0) + 1 FROM UserAccount"
            cmd = New SqlCommand(query, sqlconn)
            Dim nextNum As Integer = CInt(cmd.ExecuteScalar())
            userid.Text = "UID" & nextNum.ToString("D8")
        Catch ex As Exception
            userid.Text = "UID00000001"
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Sub usertable()
        Try
            EnsureOpen()
            Guna2DataGridView1.Rows.Clear()
            query = "SELECT UserID, firstname, lastname, username, birthdate, password, role, gender, image FROM UserAccount"
            cmd = New SqlCommand(query, sqlconn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Guna2DataGridView1.Rows.Add(dr("UserID"), dr("firstname"), dr("lastname"), dr("username"), dr("birthdate"), dr("password"), dr("role"), dr("gender"), dr("image"), "EDIT", "DELETE")
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Load error: " & ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Sub addUser()
        Try
            EnsureOpen()
            Dim ms As New MemoryStream()
            If Guna2PictureBox1.Image IsNot Nothing Then
                Guna2PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
            End If

            query = "INSERT INTO UserAccount (UserID, firstname, lastname, username, birthdate, password, role, gender, image) VALUES (@UserID, @firstname, @lastname, @username, @birthdate, @password, @role, @gender, @image)"
            cmd = New SqlCommand(query, sqlconn)
            With cmd.Parameters
                .AddWithValue("@UserID", userid.Text)
                .AddWithValue("@firstname", firstname.Text)
                .AddWithValue("@lastname", lastname.Text)
                .AddWithValue("@username", username.Text)
                .AddWithValue("@birthdate", birthdate.Value.Date)
                .AddWithValue("@password", password.Text)
                .AddWithValue("@role", rolecmbbox.Text)
                .AddWithValue("@gender", gendercmbox.Text)
                If Guna2PictureBox1.Image IsNot Nothing Then
                    .AddWithValue("@image", ms.ToArray())
                Else
                    .AddWithValue("@image", DBNull.Value)
                End If
            End With
            cmd.ExecuteNonQuery()
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Sub updateUser()
        Try
            EnsureOpen()
            Dim ms As New MemoryStream()
            If Guna2PictureBox1.Image IsNot Nothing Then
                Guna2PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
            End If

            query = "UPDATE UserAccount SET firstname=@firstname, lastname=@lastname, username=@username, birthdate=@birthdate, password=@password, role=@role, gender=@gender, image=@image WHERE UserID=@UserID"
            cmd = New SqlCommand(query, sqlconn)
            With cmd.Parameters
                .AddWithValue("@UserID", userid.Text)
                .AddWithValue("@firstname", firstname.Text)
                .AddWithValue("@lastname", lastname.Text)
                .AddWithValue("@username", username.Text)
                .AddWithValue("@birthdate", birthdate.Value.Date)
                .AddWithValue("@password", password.Text)
                .AddWithValue("@role", rolecmbbox.Text)
                .AddWithValue("@gender", gendercmbox.Text)
                If Guna2PictureBox1.Image IsNot Nothing Then
                    .AddWithValue("@image", ms.ToArray())
                Else
                    .AddWithValue("@image", DBNull.Value)
                End If
            End With
            cmd.ExecuteNonQuery()
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Sub deleteUser(ByVal id As String)
        Try
            EnsureOpen()
            query = "DELETE FROM UserAccount WHERE UserID=@UserID"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@UserID", id)
            cmd.ExecuteNonQuery()
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Sub viewimage()
        Try
            EnsureOpen()
            query = "SELECT image FROM UserAccount WHERE UserID=@id"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@id", userid.Text)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                If IsDBNull(dr("image")) Then
                    Guna2PictureBox1.Image = Nothing
                Else
                    Dim img() As Byte = DirectCast(dr("image"), Byte())
                    Dim ms As New MemoryStream(img)
                    Guna2PictureBox1.Image = Image.FromStream(ms)
                End If
            End If
            dr.Close()
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
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
            If MsgBox("Are you sure you want to delete this data?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                deleteUser(Guna2DataGridView1.Item(0, i).Value.ToString())
                usertable()
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
        If Guna2PictureBox1.Image Is Nothing Then MsgBox("Image Cannot be blank", MsgBoxStyle.Critical) : Return
        If password.Text <> confirmpass.Text Then MsgBox("Password and confirm password does not match", MsgBoxStyle.Critical) : Return
        If username.Text.Length < 6 OrElse password.Text.Length < 6 Then MsgBox("Username and Password must be atleast 6 characters", MsgBoxStyle.Critical) : Return
        If Not Regex.IsMatch(username.Text, "[A-Z]") Then MsgBox("Username must have atleast 1 uppercase letter", MsgBoxStyle.Critical) : Return
        If Not Regex.IsMatch(password.Text, "[0-9]") Then MsgBox("Password must have atleast 1 number ", MsgBoxStyle.Critical) : Return

        Try
            EnsureOpen()
            query = "SELECT COUNT(*) FROM UserAccount WHERE username=@username"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@username", username.Text.Trim())
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            sqlconn.Close()

            If count > 0 Then
                MsgBox("Username already exists! Use another username.", MsgBoxStyle.Critical)
                username.Clear()
                Return
            End If

            addUser()
            MsgBox("Data added")
            usertable()
            Clear()
            AutoNumber()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        If firstname.Text = "" Then MsgBox("First Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If password.Text <> confirmpass.Text Then MsgBox("Password and confirm password does not match", MsgBoxStyle.Critical) : Return
        updateUser()
        MsgBox("Data updated")
        usertable()
        Clear()
        AutoNumber()
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
        rolecmbbox.SelectedIndex = -1
        Guna2PictureBox1.Image = Nothing
    End Sub

    Private Sub Guna2DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Guna2DataGridView1.DataError
        e.ThrowException = False
        e.Cancel = False
    End Sub

    Private Sub ManageAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        usertable()
        roless()
        gender()
        SizeFilterCmbx.SelectedIndex = 0
        AutoNumber()
    End Sub

    Sub SearchUser(keyword As String)

        Dim connStr As String = "Server=(localdb)\MSSQLLocalDB; Database=DB_CAPSICUM; Trusted_Connection=True; MultipleActiveResultSets=True;"
        Try
            Guna2DataGridView1.Rows.Clear()
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Dim q As String
                If keyword.Trim() = "" Then
                    q = "SELECT UserID, firstname, lastname, username, birthdate, password, role, gender, image FROM UserAccount"
                Else
                    q = "SELECT UserID, firstname, lastname, username, birthdate, password, role, gender, image FROM UserAccount WHERE UserID LIKE @k OR firstname LIKE @k OR lastname LIKE @k OR username LIKE @k"
                End If
                Using cmd2 As New SqlCommand(q, conn)
                    If keyword.Trim() <> "" Then cmd2.Parameters.AddWithValue("@k", "%" & keyword.Trim() & "%")
                    Using dr2 As SqlDataReader = cmd2.ExecuteReader()
                        While dr2.Read()
                            Guna2DataGridView1.Rows.Add(dr2("UserID"), dr2("firstname"), dr2("lastname"), dr2("username"), dr2("birthdate"), dr2("password"), dr2("role"), dr2("gender"), dr2("image"), "EDIT", "DELETE")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("SearchUser: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        SearchUser(Guna2TextBox2.Text)
    End Sub

    Private Sub SizeFilterCmbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SizeFilterCmbx.SelectedIndexChanged
        Try
            EnsureOpen()
            Guna2DataGridView1.Rows.Clear()
            If SizeFilterCmbx.Text = "All" Then
                query = "SELECT UserID, firstname, lastname, username, birthdate, password, role, gender, image FROM UserAccount"
                cmd = New SqlCommand(query, sqlconn)
            Else
                query = "SELECT UserID, firstname, lastname, username, birthdate, password, role, gender, image FROM UserAccount WHERE role=@role"
                cmd = New SqlCommand(query, sqlconn)
                cmd.Parameters.AddWithValue("@role", SizeFilterCmbx.Text)
            End If
            dr = cmd.ExecuteReader()
            While dr.Read()
                Guna2DataGridView1.Rows.Add(dr("UserID"), dr("firstname"), dr("lastname"), dr("username"), dr("birthdate"), dr("password"), dr("role"), dr("gender"), dr("image"), "EDIT", "DELETE")
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Dim tempImg As Image = Image.FromFile(OpenFileDialog1.FileName)
                Guna2PictureBox1.Image = New Bitmap(tempImg)
                tempImg.Dispose()
            Catch ex As Exception
                MsgBox("Use JPG or PNG only", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class