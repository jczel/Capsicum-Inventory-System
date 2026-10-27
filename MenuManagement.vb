Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class MenuManagement

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
        readdata()
        sizes()
        categ()
        AutoNumber()
    End Sub

    Sub AutoNumber()

        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            query = "SELECT Max(NewNumber) FROM AutoNumber where pfx = @pfx"
            cmd = New SqlClient.SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@pfx", "PID")
            Dim result As Object = cmd.ExecuteScalar()
            cmd.Dispose()

            If IsDBNull(result) OrElse result Is Nothing Then
                CreateNewAutoNumber()
                query = "SELECT Max(NewNumber) FROM AutoNumber where pfx = @pfx"
                cmd = New SqlClient.SqlCommand(query, sqlconn)
                cmd.Parameters.AddWithValue("@pfx", "PID")
                prodid.Text = Convert.ToString(cmd.ExecuteScalar())
                cmd.Dispose()
            Else
                prodid.Text = Convert.ToString(result)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CreateNewAutoNumber()

        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            Dim cmd2 As New SqlCommand("SP_AutoNumber", sqlconn)
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.Parameters.AddWithValue("@pfx", "PID")
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub readdata()
        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            Guna2DataGridView1.Rows.Clear()
            query = "SELECT ProductID, productname, category, size, price, quantity, prodimage FROM Product"
            cmd = New SqlClient.SqlCommand(query, sqlconn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Guna2DataGridView1.Rows.Add(dr("ProductID"), dr("productname"), dr("category"), dr("size"), dr("price"), dr("quantity"), dr("prodimage"), "Edit", "Delete")
            End While
            dr.Close()
            cmd.Dispose()
            sqlconn.Close()
        Catch ex As Exception
            MsgBox("readdata error: " & ex.Message)
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Sub savedata()
        If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
        Dim imgData As Object = DBNull.Value
        If Guna2PictureBox1.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream
                Using bmp As New Bitmap(Guna2PictureBox1.Image)
                    bmp.Save(ms, Imaging.ImageFormat.Png)
                End Using
                imgData = ms.ToArray()
            End Using
        End If

        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            query = "Insert into Product (ProductID, productname, category, size, price, quantity, prodimage) values (@ProductID, @productname, @category, @size, @price, @quantity, @prodimage)"
            cmd = New SqlClient.SqlCommand(query, sqlconn)
            With cmd.Parameters
                .AddWithValue("@ProductID", prodid.Text)
                .AddWithValue("@productname", prodname.Text)
                .AddWithValue("@category", catcmbx.Text)
                .AddWithValue("@size", sizecmbx.Text)
                .AddWithValue("@price", price.Text)
                .AddWithValue("@quantity", quantity.Text)
                .Add("@prodimage", SqlDbType.VarBinary, -1).Value = imgData
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            sqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Sub updatedata()

        Dim imgData As Object = DBNull.Value
        If Guna2PictureBox1.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream
                Using bmp As New Bitmap(Guna2PictureBox1.Image)
                    bmp.Save(ms, Imaging.ImageFormat.Png)
                End Using
                imgData = ms.ToArray()
            End Using
        End If

        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            query = "Update Product set productname=@productname, category=@category, size=@size, price=@price, quantity=@quantity, prodimage=@prodimage Where ProductID=@ProductID"
            cmd = New SqlClient.SqlCommand(query, sqlconn)
            With cmd.Parameters
                .AddWithValue("@ProductID", prodid.Text)
                .AddWithValue("@productname", prodname.Text)
                .AddWithValue("@category", catcmbx.Text)
                .AddWithValue("@size", sizecmbx.Text)
                .AddWithValue("@price", price.Text)
                .AddWithValue("@quantity", quantity.Text)
                .Add("@prodimage", SqlDbType.VarBinary, -1).Value = imgData
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            sqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Sub delete(ByVal id As String)
        If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
        query = "Delete From Product where ProductID = @ProductID"
        cmd = New SqlCommand(query, sqlconn)
        cmd.Parameters.AddWithValue("@ProductID", id)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Sub viewimage()
        If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
        Try
            Dim img() As Byte
            query = "Select prodimage from Product where ProductID = @ProductID"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@ProductID", prodid.Text)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                If IsDBNull(dr("prodimage")) Then
                    Guna2PictureBox1.Image = Nothing
                Else
                    img = CType(dr("prodimage"), Byte())
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
        If e.ColumnIndex = 7 Then
            prodid.Text = Guna2DataGridView1.Item(0, i).Value.ToString()
            prodname.Text = Guna2DataGridView1.Item(1, i).Value.ToString()
            catcmbx.Text = Guna2DataGridView1.Item(2, i).Value.ToString()
            sizecmbx.Text = Guna2DataGridView1.Item(3, i).Value.ToString()
            price.Text = Guna2DataGridView1.Item(4, i).Value.ToString()
            quantity.Text = Guna2DataGridView1.Item(5, i).Value.ToString()
            viewimage()
        ElseIf e.ColumnIndex = 8 Then
            Dim confirm = MsgBox("Are you sure you want to delete this data?", MsgBoxStyle.YesNo)
            If confirm = MsgBoxResult.Yes Then
                delete(Guna2DataGridView1.Item(0, i).Value.ToString())
                readdata()
                AutoNumber()
            End If
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If prodname.Text = "" Then MsgBox("Product Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If catcmbx.Text = "" Then MsgBox("Choose Category", MsgBoxStyle.Critical) : Return
        If sizecmbx.Text = "" Then MsgBox("Choose Size", MsgBoxStyle.Critical) : Return
        If price.Text = "" Then MsgBox("Price Cannot be blank", MsgBoxStyle.Critical) : Return
        If quantity.Text = "" Then MsgBox("Quantity Cannot be blank", MsgBoxStyle.Critical) : Return
        If Guna2PictureBox1.Image Is Nothing Then MsgBox("Image Cannot be blank", MsgBoxStyle.Critical) : Return


        If Not Regex.IsMatch(quantity.Text.Trim(), "^[0-9]+$") Then
            MsgBox("Quantity must be number only", MsgBoxStyle.Critical)
            quantity.Focus()
            Return
        End If

        If Not Regex.IsMatch(price.Text.Trim(), "^[0-9]+(\.[0-9]{1,2})?$") Then
            MsgBox("Price must be numbers only (ex: 100 or 100.50)", MsgBoxStyle.Critical)
            price.Focus()
            Return
        End If

        If CInt(quantity.Text) <= 0 Then
            MsgBox("Quantity must be greater than 0", MsgBoxStyle.Critical)
            Return
        End If

        If CDbl(price.Text) <= 0 Then
            MsgBox("Price must be greater than 0", MsgBoxStyle.Critical)
            Return
        End If
        MsgBox("Data added")
        savedata()
        readdata()
        Clear()
        CreateNewAutoNumber()
        AutoNumber()
        sqlconn.Close()

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


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If prodname.Text = "" Then MsgBox("Product Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If catcmbx.Text = "" Then MsgBox("Choose Category", MsgBoxStyle.Critical) : Return
        If sizecmbx.Text = "" Then MsgBox("Choose Size", MsgBoxStyle.Critical) : Return
        If price.Text = "" Then MsgBox("Price Cannot be blank", MsgBoxStyle.Critical) : Return
        If quantity.Text = "" Then MsgBox("Quantity Cannot be blank", MsgBoxStyle.Critical) : Return
        If Guna2PictureBox1.Image Is Nothing Then MsgBox("Image Cannot be blank", MsgBoxStyle.Critical) : Return

        If Not Regex.IsMatch(quantity.Text.Trim(), "^[0-9]+$") Then
            MsgBox("Quantity must be number only", MsgBoxStyle.Critical)
            quantity.Focus()
            Return
        End If

        If Not Regex.IsMatch(price.Text.Trim(), "^[0-9]+(\.[0-9]{1,2})?$") Then
            MsgBox("Price must be numbers only (ex: 100 or 100.50)", MsgBoxStyle.Critical)
            price.Focus()
            Return
        End If

        If CInt(quantity.Text) <= 0 Then
            MsgBox("Quantity must be greater than 0", MsgBoxStyle.Critical)
            Return
        End If

        If CDbl(price.Text) <= 0 Then
            MsgBox("Price must be greater than 0", MsgBoxStyle.Critical)
            Return
        End If
        MsgBox("Data added")
        savedata()
        readdata()
        Clear()
        AutoNumber()
        sqlconn.Close()

    End Sub

    Sub categ()
        catcmbx.Items.Clear()
        catcmbx.Items.Add("Hot Coffee")
        catcmbx.Items.Add("Cold Coffee")
        catcmbx.Items.Add("Tea")
        catcmbx.Items.Add("Desserts")
    End Sub
    Sub sizes()
        sizecmbx.Items.Clear()
        sizecmbx.Items.Add("Small")
        sizecmbx.Items.Add("Medium")
        sizecmbx.Items.Add("Large")
    End Sub
    Sub Clear()
        prodname.Clear()
        price.Clear()
        quantity.Clear()
        sizecmbx.SelectedIndex = -1
        catcmbx.SelectedIndex = -1
        Guna2PictureBox1.Image = Nothing
    End Sub

    Private Sub Guna2DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Guna2DataGridView1.DataError
        e.ThrowException = False
        e.Cancel = False
    End Sub

End Class