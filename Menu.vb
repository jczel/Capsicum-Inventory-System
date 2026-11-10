Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports System.IO

Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.WrapContents = True
        connect()
        loadGrouped("All")

    End Sub

    Public Sub loadGrouped(Optional filter As String = "All")
        FlowLayoutPanel1.Controls.Clear()
        Try
            If sqlconn.State = ConnectionState.Closed Then
                sqlconn.Open()
            End If

            Dim dtAll As New DataTable()
            Dim sql As String


            If filter = "All" Then
                sql = "SELECT productname, size, price, prodimage, category FROM Product ORDER BY productname"
                cmd = New SqlCommand(sql, sqlconn)
            Else
                sql = "SELECT productname, size, price, prodimage, category FROM Product WHERE category = @category ORDER BY productname"
                cmd = New SqlCommand(sql, sqlconn)
                cmd.Parameters.AddWithValue("@category", filter)
            End If

            cmd.CommandTimeout = 120
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dtAll)


            Dim grouped = dtAll.AsEnumerable().GroupBy(Function(r) r.Field(Of String)("productname"))

            For Each g In grouped
                Dim pName As String = g.Key
                Dim priceS As String = ""
                Dim priceM As String = ""
                Dim priceL As String = ""
                Dim singlePrice As String = ""
                Dim prodImage As Object = Nothing

                For Each r2 In g
                    Dim sz As String = ""
                    If Not IsDBNull(r2("size")) Then
                        sz = r2("size").ToString().Trim().ToUpper()
                    End If

                    If sz = "" Then
                        singlePrice = r2("price").ToString()
                    ElseIf sz = "S" OrElse sz.Contains("SMALL") Then
                        priceS = r2("price").ToString()
                    ElseIf sz = "M" OrElse sz.Contains("MED") Then
                        priceM = r2("price").ToString()
                    ElseIf sz = "L" OrElse sz.Contains("LARGE") Then
                        priceL = r2("price").ToString()
                    End If

                    prodImage = r2("prodimage")
                Next

                Dim container As New Guna2Panel With {
                    .Height = 168,
                    .Width = 275,
                    .BorderRadius = 20,
                    .BorderThickness = 2,
                    .BorderColor = Color.FromArgb(128, 64, 0),
                    .Margin = New Padding(10)
                }

                Dim productName As New Label With {
                    .Text = pName,
                    .Location = New Point(133, 20),
                    .AutoSize = True,
                    .Font = New Font("Microsoft YaHei UI", 9, FontStyle.Bold)
                }

                Dim productPrice As New Label With {
                    .Location = New Point(133, 50),
                    .AutoSize = True,
                    .Font = New Font("Microsoft YaHei UI", 12, FontStyle.Bold)
                }

                If singlePrice <> "" Then
                    productPrice.Text = "₱" & singlePrice
                ElseIf priceM <> "" Then
                    productPrice.Text = "₱" & priceM
                ElseIf priceS <> "" Then
                    productPrice.Text = "₱" & priceS
                Else
                    productPrice.Text = "₱" & priceL
                End If

                Dim productImg As New Guna2PictureBox With {
                    .Location = New Point(13, 12),
                    .Size = New Size(102, 91),
                    .BorderRadius = 10,
                    .SizeMode = PictureBoxSizeMode.StretchImage
                }

                Try
                    If prodImage IsNot Nothing AndAlso Not IsDBNull(prodImage) Then
                        Dim imgBytes As Byte() = DirectCast(prodImage, Byte())
                        Using ms As New MemoryStream(imgBytes)
                            productImg.Image = Image.FromStream(ms)
                        End Using
                    End If
                Catch
                End Try

                Dim btnS As New Guna2Button With {.Text = "S", .Location = New Point(13, 123), .Size = New Size(44, 33), .BorderRadius = 15, .BorderThickness = 2, .BorderColor = Color.FromArgb(128, 64, 0), .FillColor = Color.FromArgb(128, 64, 0)}
                Dim btnM As New Guna2Button With {.Text = "M", .Location = New Point(63, 123), .Size = New Size(52, 33), .BorderRadius = 15, .BorderThickness = 2, .BorderColor = Color.FromArgb(128, 64, 0), .FillColor = Color.FromArgb(128, 64, 0)}
                Dim btnL As New Guna2Button With {.Text = "L", .Location = New Point(121, 123), .Size = New Size(44, 33), .BorderRadius = 15, .BorderThickness = 2, .BorderColor = Color.FromArgb(128, 64, 0), .FillColor = Color.FromArgb(128, 64, 0)}
                Dim addBtn As New Guna2Button With {.Text = "Add", .Location = New Point(171, 123), .Size = New Size(85, 33), .BorderRadius = 10, .FillColor = Color.FromArgb(128, 64, 0)}

                If singlePrice <> "" Then
                    btnS.Visible = False
                    btnM.Visible = False
                    btnL.Visible = False
                    addBtn.Location = New Point(13, 123)
                    addBtn.Size = New Size(243, 33)
                Else
                    If priceS = "" Then btnS.Visible = False
                    If priceM = "" Then btnM.Visible = False
                    If priceL = "" Then btnL.Visible = False

                    If priceS = "" AndAlso priceL = "" AndAlso priceM <> "" Then
                        btnM.Location = New Point(13, 123)
                        btnM.FillColor = Color.FromArgb(128, 64, 0)
                        btnM.ForeColor = Color.White
                    End If
                End If

                Dim ps As String = priceS
                Dim pm As String = priceM
                Dim pl As String = priceL

                AddHandler btnS.Click, Sub(s, ev) productPrice.Text = "₱" & ps
                AddHandler btnM.Click, Sub(s, ev) productPrice.Text = "₱" & pm
                AddHandler btnL.Click, Sub(s, ev) productPrice.Text = "₱" & pl

                container.Controls.Add(productName)
                container.Controls.Add(productPrice)
                container.Controls.Add(productImg)
                container.Controls.Add(btnS)
                container.Controls.Add(btnM)
                container.Controls.Add(btnL)
                container.Controls.Add(addBtn)

                FlowLayoutPanel1.Controls.Add(container)
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class