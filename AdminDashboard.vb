Imports System.Data.SqlClient
Imports Guna.Charts.WinForms

Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Timer1.Start()
        namelb.Text = LoggedFirstName
        userCounts(totalusersnumlb)
        productCounts(totalprodnumlb)
        totalStock(Label1)
        showUser(namelb, adminlb)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelb.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        timelb.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub totalusersnumlb_Click(sender As Object, e As EventArgs) Handles totalusersnumlb.Click

    End Sub

    Private Sub totalprodnumlb_Click(sender As Object, e As EventArgs) Handles totalprodnumlb.Click

    End Sub



    Private Sub todaysnumofTransnumlb_Click(sender As Object, e As EventArgs) Handles todaysnumofTransnumlb.Click
        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            ' === TODAY'S TRANSACTIONS FIX ===
            Dim sqlToday As String = "SELECT COUNT(DISTINCT TransactionNo) FROM Transactions WHERE CONVERT(DATE, transDate) = CONVERT(DATE, GETDATE())"
            Using cmd As New SqlCommand(sqlToday, sqlconn)
                Dim count As Object = cmd.ExecuteScalar()
                If count IsNot Nothing AndAlso Not IsDBNull(count) Then
                    todaysnumofTransnumlb.Text = count.ToString()
                    ' or kung lbl mo ay TodayTransactions label
                Else
                    todaysnumofTransnumlb.Text = ""
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Today Trans Error: " & ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub



    Private Sub showUser(lblName As Label, lblRole As Label)
        lblName.Text = LoggedFirstName
        lblRole.Text = "Role"
    End Sub

    Private Sub productAreachrt_Load(sender As Object, e As EventArgs) Handles productAreachrt.Load
        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            Dim sql As String = "SELECT DATENAME(WEEKDAY, transDate) as DayName, COUNT(DISTINCT TransactionNo) as TransCount FROM Transactions WHERE transDate >= DATEADD(DAY, -7, GETDATE()) GROUP BY DATENAME(WEEKDAY, transDate)"
            Dim dt As New DataTable()
            Using cmd As New SqlCommand(sql, sqlconn)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using

            productAreachrt.Datasets.Clear()

            ' Ito lang yung gumagana sa Guna version mo
            Dim lineDs As New GunaLineDataset()
            lineDs.Label = "Weekly Transactions"

            ' Ito lang gumagana sa version mo
            lineDs.BorderColor = Color.FromArgb(255, 165, 0) ' orange
            lineDs.BorderWidth = 3 ' mas makapal para mas kita
            lineDs.PointRadius = 5


            Dim daysOrder As String() = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}

            For Each d In daysOrder
                Dim row = dt.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of String)("DayName") = d)
                Dim val As Integer = If(row IsNot Nothing, CInt(row("TransCount")), 0)
                ' Kahit 0 i-add mo para di maputol line
                lineDs.DataPoints.Add(d, val)
            Next

            productAreachrt.Datasets.Add(lineDs)
            productAreachrt.Update()

        Catch ex As Exception
            MessageBox.Show("Chart Error: " & ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Private Sub weeklysaleschrt_Load(sender As Object, e As EventArgs) Handles weeklysaleschrt.Load
        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            Dim sql As String = "SELECT DATENAME(WEEKDAY, transDate) as DayName, COUNT(DISTINCT TransactionNo) as TransCount FROM Transactions WHERE transDate >= DATEADD(DAY, -7, GETDATE()) GROUP BY DATENAME(WEEKDAY, transDate)"

            Dim dt As New DataTable()
            Using cmd As New SqlCommand(sql, sqlconn)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using

            weeklysaleschrt.Datasets.Clear()
            Dim pieDs As New GunaPieDataset()
            pieDs.Label = "Weekly"

            Dim daysOrder As String() = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
            For Each d In daysOrder
                Dim row = dt.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of String)("DayName") = d)
                Dim val As Integer = If(row IsNot Nothing, CInt(row("TransCount")), 0)
                If val > 0 Then
                    pieDs.DataPoints.Add(d, val)
                End If
            Next

            weeklysaleschrt.Datasets.Add(pieDs)
            weeklysaleschrt.Update()
        Catch
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
