Imports System.Data.SqlClient

Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        userCounts(totalusersnumlb)
        productCounts(totalprodnumlb)
        showUser(namelb, adminlb)
        totalStock(totalstocknumlb)
        Timer1.Start()
        namelb.Text = LoggedFirstName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelb.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        timelb.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub todaysnumofTransnumlb_Click(sender As Object, e As EventArgs) Handles todaysnumofTransnumlb.Click

    End Sub

    Private Sub totalprodlb_Click(sender As Object, e As EventArgs) Handles totalprodlb.Click

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
