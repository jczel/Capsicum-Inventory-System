Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms

Public Class MenuMngment

    Const maxQuantity As Integer = 50

    Private Sub MenuMngment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
        readdata()
        sizes()
        categ()
        AutoNumber()
        SizeFilterCmbx.SelectedIndex = 0
    End Sub





    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        If prdctnmtxbx.Text = "" Then MsgBox("Product Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If Categorycmbbx.Text = "" Then MsgBox("Choose Category", MsgBoxStyle.Critical) : Return
        If pricetxbx.Text = "" Then MsgBox("Price Cannot be blank", MsgBoxStyle.Critical) : Return
        If quantitytxbx.Text = "" Then MsgBox("Quantity Cannot be blank", MsgBoxStyle.Critical) : Return
        If Prdctpicbx.Image Is Nothing Then MsgBox("Image Cannot be blank", MsgBoxStyle.Critical) : Return
        If Not Regex.IsMatch(quantitytxbx.Text.Trim(), "^[0-9]+$") Then
            MsgBox("Quantity must be number only", MsgBoxStyle.Critical)
            Return
        End If
        If Not Regex.IsMatch(pricetxbx.Text.Trim(), "^[0-9]+(\.[0-9]{1,2})?$") Then
            MsgBox("Price must be numbers only (ex: 100 or 100.50)", MsgBoxStyle.Critical)
            Return
        End If
        If CInt(quantitytxbx.Text) <= 0 Then MsgBox("Quantity must be greater than 0", MsgBoxStyle.Critical) : Return
        If CDbl(pricetxbx.Text) <= 0 Then MsgBox("Price must be greater than 0", MsgBoxStyle.Critical) : Return
        If CInt(quantitytxbx.Text) > 50 Then MsgBox("Quantity cannot exceed 50", MsgBoxStyle.Critical) : Return

        savedata()
        MsgBox("Data added")
        readdata()
        Clear()
        CreateNewAutoNumber()
        AutoNumber()

    End Sub


    Private Sub PrdctTbledtgrd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PrdctTbledtgrd.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim i As Integer = e.RowIndex
        If e.ColumnIndex = 7 Then
            PrdcId.Text = PrdctTbledtgrd.Item(0, i).Value.ToString()
            prdctnmtxbx.Text = PrdctTbledtgrd.Item(1, i).Value.ToString()
            Categorycmbbx.Text = PrdctTbledtgrd.Item(2, i).Value.ToString()
            sizecmbbx.Text = PrdctTbledtgrd.Item(3, i).Value.ToString()
            pricetxbx.Text = PrdctTbledtgrd.Item(4, i).Value.ToString()
            quantitytxbx.Text = PrdctTbledtgrd.Item(5, i).Value.ToString()
            viewimage()
        ElseIf e.ColumnIndex = 8 Then
            Dim confirm = MsgBox("Are you sure you want to delete this data?", MsgBoxStyle.YesNo)
            If confirm = MsgBoxResult.Yes Then
                delete(PrdctTbledtgrd.Item(0, i).Value.ToString())
                readdata()
                AutoNumber()
            End If
        End If


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
                PrdcId.Text = Convert.ToString(cmd.ExecuteScalar())
                cmd.Dispose()
            Else
                PrdcId.Text = Convert.ToString(result)
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
            PrdctTbledtgrd.DataSource = Nothing
            PrdctTbledtgrd.Rows.Clear()
            query = "SELECT ProductID, productname, category, size, price, quantity, prodimage FROM Product"
            cmd = New SqlClient.SqlCommand(query, sqlconn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                PrdctTbledtgrd.Rows.Add(dr("ProductID"), dr("productname"), dr("category"), dr("size"), dr("price"), dr("quantity"), dr("prodimage"), "EDIT", "DELETE")
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
        If Prdctpicbx.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream
                Using bmp As New Bitmap(Prdctpicbx.Image)
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
                .AddWithValue("@ProductID", PrdcId.Text)
                .AddWithValue("@productname", prdctnmtxbx.Text)
                .AddWithValue("@category", Categorycmbbx.Text)
                .AddWithValue("@size", sizecmbbx.Text)
                .AddWithValue("@price", pricetxbx.Text)
                .AddWithValue("@quantity", quantitytxbx.Text)
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
        If Prdctpicbx.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream
                Using bmp As New Bitmap(Prdctpicbx.Image)
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
                .AddWithValue("@ProductID", PrdcId.Text)
                .AddWithValue("@productname", prdctnmtxbx.Text)
                .AddWithValue("@category", Categorycmbbx.Text)
                .AddWithValue("@size", sizecmbbx.Text)
                .AddWithValue("@price", pricetxbx.Text)
                .AddWithValue("@quantity", quantitytxbx.Text)
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
            cmd.Parameters.AddWithValue("@ProductID", PrdcId.Text)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                If IsDBNull(dr("prodimage")) Then
                    Prdctpicbx.Image = Nothing
                Else
                    img = CType(dr("prodimage"), Byte())
                    Using ms As New MemoryStream(img)
                        Prdctpicbx.Image = Image.FromStream(ms)
                    End Using
                End If
            End If
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
        End Try
    End Sub


    Sub SearchProduct(keyword As String)
        Dim connStr As String = "Server = DESKTOP-51BM6RG\SQLEXPRESS; Database = DB_CAPSICUM; Trusted_Connection = True; MultipleActiveResultSets = True;"


        Try
            PrdctTbledtgrd.Rows.Clear()

            Using sqlconn As New SqlClient.SqlConnection(connStr)
                sqlconn.Open()

                Dim q As String
                If keyword.Trim() = "" Then
                    q = "SELECT ProductID, productname, category, size, price, quantity, prodimage FROM Product"
                    Using cmd As New SqlClient.SqlCommand(q, sqlconn)
                        Using dr As SqlClient.SqlDataReader = cmd.ExecuteReader()
                            While dr.Read()
                                PrdctTbledtgrd.Rows.Add(dr("ProductID"), dr("productname"), dr("category"), dr("size"), dr("price"), dr("quantity"), dr("prodimage"), "Edit", "Delete")
                            End While
                        End Using
                    End Using
                Else
                    q = "SELECT ProductID, productname, category, size, price, quantity, prodimage FROM Product 
                     WHERE ProductID LIKE @k OR productname LIKE @k OR category LIKE @k"
                    Using cmd As New SqlClient.SqlCommand(q, sqlconn)
                        cmd.Parameters.AddWithValue("@k", "%" & keyword.Trim() & "%")
                        Using dr As SqlClient.SqlDataReader = cmd.ExecuteReader()
                            While dr.Read()
                                PrdctTbledtgrd.Rows.Add(dr("ProductID"), dr("productname"), dr("category"), dr("size"), dr("price"), dr("quantity"), dr("prodimage"), "Edit", "Delete")
                            End While
                        End Using
                    End Using
                End If
            End Using

        Catch ex As Exception
            MsgBox("SearchProduct: " & ex.Message)
        End Try
    End Sub


    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        If prdctnmtxbx.Text = "" Then MsgBox("Product Name Cannot be blank", MsgBoxStyle.Critical) : Return
        If Categorycmbbx.Text = "" Then MsgBox("Choose Category", MsgBoxStyle.Critical) : Return

        If pricetxbx.Text = "" Then MsgBox("Price Cannot be blank", MsgBoxStyle.Critical) : Return
        If quantitytxbx.Text = "" Then MsgBox("Quantity Cannot be blank", MsgBoxStyle.Critical) : Return
        If Prdctpicbx.Image Is Nothing Then MsgBox("Image Cannot be blank", MsgBoxStyle.Critical) : Return

        If Not Regex.IsMatch(quantitytxbx.Text.Trim(), "^[0-9]+$") Then
            MsgBox("Quantity must be number only", MsgBoxStyle.Critical)
            quantitytxbx.Focus()
            Return
        End If

        If Not Regex.IsMatch(pricetxbx.Text.Trim(), "^[0-9]+(\.[0-9]{1,2})?$") Then
            MsgBox("Price must be numbers only (ex: 100 or 100.50)", MsgBoxStyle.Critical)
            pricetxbx.Focus()
            Return
        End If

        If CInt(quantitytxbx.Text) <= 0 Then
            MsgBox("Quantity must be greater than 0", MsgBoxStyle.Critical)
            Return
        End If

        If CDbl(pricetxbx.Text) <= 0 Then
            MsgBox("Price must be greater than 0", MsgBoxStyle.Critical)
            Return
        End If
        MsgBox("Data Updated")
        updatedata()
        readdata()
        Clear()
        AutoNumber()

    End Sub

    Private Sub Prdctpicbx_Click(sender As Object, e As EventArgs) Handles Prdctpicbx.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Dim tempImg As Image = Image.FromFile(OpenFileDialog1.FileName)
                Prdctpicbx.Image = New Bitmap(tempImg)
                tempImg.Dispose()
            Catch ex As Exception
                MsgBox("Use JPG or PNG only", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Sub categ()
        Categorycmbbx.Items.Clear()
        Categorycmbbx.Items.Add("Hot Coffee")
        Categorycmbbx.Items.Add("Cold Coffee")
        Categorycmbbx.Items.Add("Tea")
        Categorycmbbx.Items.Add("Desserts")
    End Sub
    Sub sizes()
        sizecmbbx.Items.Clear()
        sizecmbbx.Items.Add("Small")
        sizecmbbx.Items.Add("Medium")
        sizecmbbx.Items.Add("Large")
    End Sub

    Sub Clear()
        prdctnmtxbx.Clear()
        pricetxbx.Clear()
        quantitytxbx.Clear()
        sizecmbbx.SelectedIndex = -1
        Categorycmbbx.SelectedIndex = -1
        Prdctpicbx.Image = Nothing
    End Sub


    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        SearchProduct(Srchtxtbx.Text)

    End Sub

    Private Sub SizeFilterCmbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SizeFilterCmbx.SelectedIndexChanged
        connect()
        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            PrdctTbledtgrd.DataSource = Nothing
            PrdctTbledtgrd.Rows.Clear()

            Dim query As String
            If SizeFilterCmbx.Text = "All" Then
                query = "SELECT ProductID, productname, category, size, price, quantity, prodimage FROM Product"
                cmd = New SqlClient.SqlCommand(query, sqlconn)
            Else
                query = "SELECT ProductID, productname, category, size, price, quantity, prodimage FROM Product WHERE size = @size"
                cmd = New SqlClient.SqlCommand(query, sqlconn)
                cmd.Parameters.AddWithValue("@size", SizeFilterCmbx.Text)
            End If

            dr = cmd.ExecuteReader()
            While dr.Read()
                PrdctTbledtgrd.Rows.Add(dr("ProductID"), dr("productname"), dr("category"), dr("size"), dr("price"), dr("quantity"), dr("prodimage"), "EDIT", "DELETE")
            End While
            dr.Close()
            sqlconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then
                sqlconn.Open()
            End If

            Dim sqlSelect As String = "SELECT ProductName, Size, quantity FROM Product WHERE quantity <= 25"
            Using cmdSelect As New SqlCommand(sqlSelect, sqlconn)
                Dim da As New SqlDataAdapter(cmdSelect)
                Dim dt As New DataTable
                da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MsgBox("No low stock. All good!")
                    Return
                End If

                Dim list As String = "Restocked:" & vbCrLf & vbCrLf
                For Each row As DataRow In dt.Rows
                    list &= "- " & row("ProductName").ToString() & " (" & row("Size").ToString() & ") : " & row("quantity").ToString() & " -> 50" & vbCrLf
                Next

                Dim sqlUpdate As String = "UPDATE Product SET quantity = 50 WHERE quantity <= 25"
                Using cmdUpdate As New SqlCommand(sqlUpdate, sqlconn)
                    Dim count As Integer = cmdUpdate.ExecuteNonQuery()
                    MsgBox(list & vbCrLf & count & " products restocked!", MsgBoxStyle.Information, "Restock Done")
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try
    End Sub
End Class

