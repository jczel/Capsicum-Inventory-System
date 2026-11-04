Imports Guna.UI2.WinForms

Public Class AddOnsflw1

    Private Sub addOnsflw1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.WrapContents = True


        Dim container As New Guna2Panel With {
             .Height = 312,
             .Width = 179,
             .BorderRadius = 5,
             .BorderThickness = 2,
             .BorderColor = Color.FromArgb(128, 64, 0),
             .Margin = New Padding(10)
            }
        Dim productName As New Label With {
            .Text = "Product Name",
            .Location = New Point(189, 35),
            .AutoSize = True,
            .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)
        }

        Dim productPrice As New Label With {
            .Location = New Point(213, 74),
            .AutoSize = True,
            .Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)
        }
        Dim adddbutton As New Guna2Button With {
            .Text = "Add",
            .Location = New Point(180, 124),
            .Size = New Size(110, 38),
            .FillColor = Color.FromArgb(128, 64, 0),
            .ForeColor = Color.White,
            .Font = New Font("Microsoft YaHei UI", 9, FontStyle.Bold)
        }
        Dim productImg As New Guna2PictureBox With {
            .Location = New Point(21, 18),
            .Size = New Size(145, 144),
            .SizeMode = PictureBoxSizeMode.StretchImage
        }
        FlowLayoutPanel1.Controls.Add(container)
        container.Controls.Add(productName)
        container.Controls.Add(productPrice)
        container.Controls.Add(adddbutton)
        container.Controls.Add(productImg)


    End Sub
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint





    End Sub
End Class
