Imports System.Data.SqlClient
Imports System.Deployment.Internal

Module connection
    Public sqlconn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public query As String

    Sub connect()
        Try
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
            sqlconn.ConnectionString = "Server = .\SQLEXPRESS; Database = DB_CAPSICUM; Trusted_Connection = True; MultipleActiveResultSets = True;"
            sqlconn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub userCounts(label As Label)
        query = "SELECT COUNT(*) FROM UserAccount"

        Using cmd As New SqlCommand(query, sqlconn)
            Dim countUser As Integer = Convert.ToInt32(cmd.ExecuteScalar)

            label.Text = countUser.ToString()
        End Using
    End Sub

    Public Sub productCounts(label As Label)
        query = "SELECT COUNT(*) FROM Product"
        Using cmd As New SqlCommand(query, sqlconn)
            Dim countProduct As Integer = Convert.ToInt32(cmd.ExecuteScalar)

            label.Text = countProduct.ToString()
        End Using
    End Sub

    Public Sub totalStock(label As Label)
        query = "SELECT ISNULL(SUM(Quantity), 0) FROM Product"

        Using cmd As New SqlCommand(query, sqlconn)
            Dim countStocks As Integer = Convert.ToInt32(cmd.ExecuteScalar)

            label.Text = countStocks.ToString()
        End Using
    End Sub
End Module
