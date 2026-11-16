Imports System.Data.SqlClient
Imports Guna.Charts.WinForms

Public Class OwnerDashboard

    Private Sub OwnerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        namelb.Text = LoggedFirstName


        LoadOwnerDashboard()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelb.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        timelb.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub


    Private Sub LoadOwnerDashboard()
        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()


            Using cmd As New SqlCommand("SELECT ISNULL(SUM(t.Quantity * p.Price), 0) FROM Transactions t INNER JOIN Product p ON t.ProductID = p.ProductID WHERE CONVERT(DATE, t.transDate) = CONVERT(DATE, GETDATE())", sqlconn)
                Dim salesToday As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                todaysalesnumlb.Text = "₱" & salesToday.ToString("N2")
            End Using


            Using cmd As New SqlCommand("SELECT COUNT(DISTINCT TransactionNo) FROM Transactions", sqlconn)
                totaltransnumlb.Text = cmd.ExecuteScalar().ToString()
            End Using

            Using cmd As New SqlCommand("SELECT TOP 1 p.ProductName FROM Transactions t INNER JOIN Product p ON t.ProductID = p.ProductID GROUP BY p.ProductName ORDER BY SUM(t.Quantity) DESC", sqlconn)
                Dim result = cmd.ExecuteScalar()
                If result Is Nothing Then
                    bestsellingnumlb.Text = "No Data"
                Else
                    bestsellingnumlb.Text = result.ToString()
                End If
            End Using


            Using cmd As New SqlCommand("SELECT ISNULL(SUM(t.Quantity * p.Price), 0) FROM Transactions t INNER JOIN Product p ON t.ProductID = p.ProductID", sqlconn)
                Dim income As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                todaysrvenuenumlb.Text = "₱" & income.ToString("N2")
            End Using


            Dim sqlWeekly As String = "
            SELECT DATENAME(WEEKDAY, transDate) as DayName, 
                   ISNULL(SUM(t.Quantity * p.Price), 0) as Sales
            FROM Transactions t
            INNER JOIN Product p ON t.ProductID = p.ProductID
            WHERE transDate >= DATEADD(DAY, -7, GETDATE())
            GROUP BY DATENAME(WEEKDAY, transDate)
        "
            Dim dtWeekly As New DataTable()
            Using cmd As New SqlCommand(sqlWeekly, sqlconn)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dtWeekly)
            End Using

            weeklysalesareachrt.Datasets.Clear()
            Dim barDs As New GunaBarDataset()
            barDs.Label = "Weekly Sales Chart"


            Dim daysOrder As String() = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
            Dim daysShort As String() = {"Mon", "Tues", "Wed", "Thurs", "Fri", "Sat"}

            For i = 0 To daysOrder.Length - 1
                Dim row = dtWeekly.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of String)("DayName") = daysOrder(i))
                Dim sales As Decimal = If(row IsNot Nothing, CDec(row("Sales")), 0)
                barDs.DataPoints.Add(daysShort(i), sales)
            Next

            weeklysalesareachrt.Datasets.Add(barDs)
            weeklysalesareachrt.Update()


            revenueareachrt.Datasets.Clear()
            Dim lineDs As New GunaLineDataset()
            lineDs.Label = "Revenue Chart"

            For i = 0 To daysOrder.Length - 1
                Dim row = dtWeekly.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of String)("DayName") = daysOrder(i))
                Dim sales As Decimal = If(row IsNot Nothing, CDec(row("Sales")), 0)
                lineDs.DataPoints.Add(daysShort(i), sales)
            Next

            revenueareachrt.Datasets.Add(lineDs)
            revenueareachrt.Update()

        Catch ex As Exception
            MessageBox.Show("Owner Dashboard Error: " & ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub


    Private Sub todaysalesnumlb_Click(sender As Object, e As EventArgs) Handles todaysalesnumlb.Click
    End Sub

    Private Sub totaltransnumlb_Click(sender As Object, e As EventArgs) Handles totaltransnumlb.Click
    End Sub

    Private Sub bestsellingnumlb_Click(sender As Object, e As EventArgs) Handles bestsellingnumlb.Click
    End Sub

    Private Sub todaysrvenuenumlb_Click(sender As Object, e As EventArgs) Handles todaysrvenuenumlb.Click
    End Sub

    Private Sub weeklysalesareachrt_Load(sender As Object, e As EventArgs) Handles weeklysalesareachrt.Load
    End Sub

    Private Sub revenueareachrt_Load(sender As Object, e As EventArgs) Handles revenueareachrt.Load
    End Sub
End Class