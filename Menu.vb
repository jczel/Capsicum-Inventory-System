Imports Guna.UI2.WinForms
Imports System.Windows.Forms
Public Class Menu


    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
        loadAllProduct()
    End Sub

    Private Sub loadAllProduct()

        Dim container As New Guna2Panel With {
            .Height = 168,
            .Width = 275,
            .BorderColor = Color.FromArgb(128, 64, 0),
            .BorderRadius = 20,
            .BorderThickness = 2
            }

        Dim productName As New Label With {
            .Location = New Point(133, 43),
            .ForeColor = Color.FromArgb(128, 64, 0),
            .Font = New Font("Microsoft YaHei UI", 9, FontStyle.Bold),
            .Text = "Product name"
            }

        Dim productPrice As New Label With {
            .Location = New Point(133, 81),
            .ForeColor = Color.FromArgb(64, 64, 64),
            .Font = New Font("Microsoft YaHei UI", 12, FontStyle.Bold),
            .Text = "150"
            }

        Dim smallSizebtn As New Guna2Button With {
            .Height = 33,
            .Width = 44,
            .BorderColor = Color.FromArgb(128, 64, 0),
            .BorderThickness = 2,
            .BorderRadius = 15,
            .Text = "S",
            .Location = New Point(13, 123),
            .ForeColor = Color.FromArgb(128, 64, 0),
            .TextAlign = HorizontalAlignment.Center,
            .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold),
            .FillColor = Color.Transparent
            }

        Dim mediumSizebtn As New Guna2Button With {
           .Height = 33,
           .Width = 52,
           .BorderColor = Color.FromArgb(128, 64, 0),
           .BorderThickness = 2,
           .BorderRadius = 15,
           .Text = "M",
           .Location = New Point(63, 123),
           .ForeColor = Color.FromArgb(128, 64, 0),
           .TextAlign = HorizontalAlignment.Center,
           .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold),
           .FillColor = Color.Transparent
           }

        Dim largeSizebtn As New Guna2Button With {
            .Height = 33,
            .Width = 44,
            .BorderColor = Color.FromArgb(128, 64, 0),
            .BorderThickness = 2,
            .BorderRadius = 15,
            .Text = "L",
            .Location = New Point(121, 123),
            .ForeColor = Color.FromArgb(128, 64, 0),
            .TextAlign = HorizontalAlignment.Center,
            .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold),
            .FillColor = Color.Transparent
            }

        Dim addBtn As New Guna2Button With {
            .Height = 33,
            .Width = 85,
            .FillColor = Color.FromArgb(128, 64, 0),
            .BorderRadius = 10,
            .Text = "Add",
            .Location = New Point(171, 123),
            .ForeColor = Color.White,
            .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)
            }

        Dim productImg As New Guna2PictureBox With {
            .Location = New Point(13, 12),
            .BorderRadius = 10,
            .Height = 91,
            .Width = 102,
            .SizeMode = PictureBoxSizeMode.StretchImage
            }
        FlowLayoutPanel1.Controls.Add(container)
        container.Controls.Add(productName)
        container.Controls.Add(productPrice)
        container.Controls.Add(smallSizebtn)
        container.Controls.Add(mediumSizebtn)
        container.Controls.Add(largeSizebtn)
        container.Controls.Add(addBtn)
        container.Controls.Add(productImg)
    End Sub

End Class
