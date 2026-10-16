Imports System.Data.SqlClient

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

End Module
