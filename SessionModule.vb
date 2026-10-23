Imports System.Data.SqlClient

Module SessionModule
    Public LoggedUsername As String
    Public LoggedRole As String
    Public LoggedFirstName As String
    Public LoggedLastName As String

    Public Sub showUser(name As Label, role As Label)

        query = "SELECT * FROM UserAccount WHERE username = @username"

        Using cmd As New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@username", Form1login.usernametxtbx.Text)

            Using dr = cmd.ExecuteReader()

                While dr.Read
                    name.Text = dr("first_name") & " " & dr("last_name")
                    role.Text = dr("role")
                End While
            End Using

        End Using
    End Sub

End Module
