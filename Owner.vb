Imports System.Data.SqlClient
Imports System.IO

Public Class Owner

    Private Sub Owner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            query = "SELECT image FROM UserAccount WHERE UserID = @id"
            cmd = New SqlCommand(query, sqlconn)
            cmd.Parameters.AddWithValue("@id", LoggedUserID)
            Dim result As Object = cmd.ExecuteScalar()
            sqlconn.Close()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Dim imgBytes As Byte() = DirectCast(result, Byte())
                Dim ms As New IO.MemoryStream(imgBytes)
                Guna2PictureBox1.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim OwnerDashboard As New OwnerDashboard()
        Displaypnl.Controls.Clear()
        OwnerDashboard.Dock = DockStyle.Fill
        Displaypnl.Controls.Add(OwnerDashboard)

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
        Form1login.Show()
        Me.Hide()
    End Sub

    Private Sub Owner_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub


    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then


            LoggedUserID = Nothing
            LoggedUsername = Nothing
            LoggedRole = Nothing
            LoggedFirstName = Nothing
            LoggedLastName = Nothing
            LoggedImage = Nothing


            For Each f As Form In Application.OpenForms
                If TypeOf f Is Form1login Then
                    Dim login As Form1login = DirectCast(f, Form1login)
                    login.usernametxtbx.Clear()
                    login.passwordtxtbx.Clear()
                    login.showpasschcbx.Checked = False
                    login.passwordtxtbx.PasswordChar = "*"c
                    login.Show()
                    Me.Close()
                    Return
                End If
            Next


            Dim newLogin As New Form1login()
            newLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub transachistrybtn_Click(sender As Object, e As EventArgs) Handles transachistrybtn.Click
        Dim transactionhistoryy As New TransactionHistoryCntrl
        Displaypnl.Controls.Clear()
        transactionhistoryy.Dock = DockStyle.Fill
        Displaypnl.Controls.Add(transactionhistoryy)
    End Sub

    Private Sub Dashbrdbtn_Click(sender As Object, e As EventArgs) Handles Dashbrdbtn.Click
        Dim Ownerdashboard As New OwnerDashboard()
        Displaypnl.Controls.Clear()
        Ownerdashboard.Dock = DockStyle.Fill
        Displaypnl.Controls.Add(Ownerdashboard)
    End Sub

    Private Sub generatereportbtn_Click(sender As Object, e As EventArgs) Handles generatereportbtn.Click
        loadform(New GenerateReport)
    End Sub

    Private Sub loadform(childform As Form)
        Displaypnl.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        Displaypnl.Controls.Add(childform)
        childform.Show()
    End Sub
End Class