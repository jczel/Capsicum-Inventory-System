Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports System.IO

Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        loadAllProduct()
    End Sub

    Private Sub loadAllProduct()
        FlowLayoutPanel1.Controls.Clear()

        Try
            query = "Select * from Product"
            cmd = New SqlCommand(query, sqlconn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim container As New Guna2Panel With {
                    .Height = 168,
                    .Width = 275,
                    .BorderColor = Color.FromArgb(128, 64, 0),
                    .BorderRadius = 20,
                    .BorderThickness = 2,
                    .Margin = New Padding(10)
                }

                Dim productName As New Label With {
                    .Location = New Point(133, 43),
                    .ForeColor = Color.FromArgb(128, 64, 0),
                    .Font = New Font("Microsoft YaHei UI", 9, FontStyle.Bold),
                    .Text = dr("productname").ToString()
                }

                Dim productPrice As New Label With {
                    .Location = New Point(133, 81),
                    .ForeColor = Color.FromArgb(64, 64, 64),
                    .Font = New Font("Microsoft YaHei UI", 12, FontStyle.Bold),
                    .Text = "₱" & dr("price").ToString()
                }

                Dim productImg As New Guna2PictureBox With {
                    .Location = New Point(13, 12),
                    .BorderRadius = 10,
                    .Height = 91,
                    .Width = 102,
                    .SizeMode = PictureBoxSizeMode.StretchImage
                }



                Try
                    If Not IsDBNull(dr("prodimage")) Then

                        Dim imgBytes As Byte() = DirectCast(dr("prodimage"), Byte())
                        Using ms As New MemoryStream(imgBytes)
                            productImg.Image = Image.FromStream(ms)
                        End Using
                    End If
                Catch ex1 As Exception

                    Try
                        Dim imgPath As String = dr("prodimage").ToString()
                        If File.Exists(imgPath) Then
                            productImg.Image = Image.FromFile(imgPath)
                        Else

                            Dim localPath As String = Application.StartupPath & "\Images\" & imgPath
                            If File.Exists(localPath) Then
                                productImg.Image = Image.FromFile(localPath)
                            End If
                        End If
                    Catch
                    End Try
                End Try


                Dim smallSizebtn As New Guna2Button With {.Height = 33, .Width = 44, .BorderColor = Color.FromArgb(128, 64, 0), .BorderThickness = 2, .BorderRadius = 15, .Text = "S", .Location = New Point(13, 123), .ForeColor = Color.FromArgb(128, 64, 0), .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold), .FillColor = Color.Transparent}
                Dim mediumSizebtn As New Guna2Button With {.Height = 33, .Width = 52, .BorderColor = Color.FromArgb(128, 64, 0), .BorderThickness = 2, .BorderRadius = 15, .Text = "M", .Location = New Point(63, 123), .ForeColor = Color.FromArgb(128, 64, 0), .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold), .FillColor = Color.Transparent}
                Dim largeSizebtn As New Guna2Button With {.Height = 33, .Width = 44, .BorderColor = Color.FromArgb(128, 64, 0), .BorderThickness = 2, .BorderRadius = 15, .Text = "L", .Location = New Point(121, 123), .ForeColor = Color.FromArgb(128, 64, 0), .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold), .FillColor = Color.Transparent}
                Dim addBtn As New Guna2Button With {.Height = 33, .Width = 85, .FillColor = Color.FromArgb(128, 64, 0), .BorderRadius = 10, .Text = "Add", .Location = New Point(171, 123), .ForeColor = Color.White, .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)}

                FlowLayoutPanel1.Controls.Add(container)
                container.Controls.Add(productName)
                container.Controls.Add(productPrice)
                container.Controls.Add(smallSizebtn)
                container.Controls.Add(mediumSizebtn)
                container.Controls.Add(largeSizebtn)
                container.Controls.Add(addBtn)
                container.Controls.Add(productImg)

            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub
End Class