Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class MenuMngment
    Const maxQuantity As Integer = 50
    Private Sub productTable()

        PrdctTble.Rows.Clear()

        query = "SELECT * FROM Product"

        Using cmd As New SqlCommand(query, sqlconn)
            Using dr = cmd.ExecuteReader()
                While dr.Read
                    PrdctTble.Rows.Add(dr("ProductID"),
                                       dr("ProductName"),
                                       dr("Category"),
                                       dr("Size"),
                                       dr("Price"),
                                       dr("quantity"),
                                       dr("Image"),
                                            "Edit",
                                            "Delete")
                End While
            End Using
        End Using
    End Sub




    Private Sub MenuMngment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        productTable()
    End Sub

    Private Sub prdctnmtxbx_TextChanged(sender As Object, e As EventArgs) Handles prdctnmtxbx.TextChanged
        If Regex.IsMatch(prdctnmtxbx.Text, "[0-9]") Then
            MsgBox("invalid input")
            prdctnmtxbx.Text = ""
        End If
    End Sub

    Private Sub pricetxbx_TextChanged(sender As Object, e As EventArgs) Handles pricetxbx.TextChanged
        If Regex.IsMatch(pricetxbx.Text, "[a-z]") Then
            MsgBox("invalid input")
            pricetxbx.Text = ""
        End If
    End Sub

    Private Sub quantitytxbx_TextChanged(sender As Object, e As EventArgs) Handles quantitytxbx.TextChanged
        If Not quantitytxbx.Text = "" Then
            If Convert.ToInt32(quantitytxbx.Text) > maxQuantity Then
                MsgBox("invalid input")
                quantitytxbx.Clear()
            End If
        End If

    End Sub


    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        Dim result As String = MsgBox(InputBox("Enter size"))

        If MsgBoxResult.Ok Then
            SizeFilterCmbx.Items.Add(result)
        End If
    End Sub

    Private Sub SizeFilterCmbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SizeFilterCmbx.SelectedIndexChanged
        Dim size As String = SizeFilterCmbx.SelectedItem

        Select Case size
            Case "Small"
                sizeFilter("Small")
            Case "Medium"
                sizeFilter("Medium")
            Case "Large"
                sizeFilter("Large")
            Case Else
                connect()
                productTable()
        End Select

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        countNotif += 1
        Admin.NotifCount.Text = countNotif.ToString()
    End Sub
End Class