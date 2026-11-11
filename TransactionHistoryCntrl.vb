Imports System.Data.SqlClient

Public Class TransactionHistoryCntrl
    Private Sub TransactionHistoryCntrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtStart.Value = Date.Today
        dtEnd.Value = Date.Today
        LoadData(Date.Today, Date.Today.AddDays(1))
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sDate As DateTime = dtStart.Value.Date
        Dim eDate As DateTime = dtEnd.Value.Date.AddDays(1).AddSeconds(-1)

        If sDate > eDate Then
            MsgBox("Start Date cannot be greater than End Date")
            Return
        End If
        LoadData(sDate, eDate)
    End Sub

    Private Sub LoadData(sDate As DateTime, eDate As DateTime)
        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            Dim sql As String = "
            SELECT 
                MIN(transDate) as [Date],
                TransactionNo as [Transaction No.],
                MAX(StaffName) as [Staff],
                COUNT(*) as [Total Item],
                MAX(discountType) as [Discount],
                MAX(total) as [Total]
            FROM Transactions
            WHERE transDate BETWEEN @s AND @e
            GROUP BY TransactionNo
            ORDER BY MIN(transDate) DESC"

            Using cmd As New SqlCommand(sql, sqlconn)
                cmd.Parameters.AddWithValue("@s", sDate)
                cmd.Parameters.AddWithValue("@e", eDate)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                DataGridView1.Columns.Clear()
                DataGridView1.DataSource = dt

                DesignGrid()

            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Private Sub DesignGrid()
        With DataGridView1
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.FromArgb(253, 245, 235)
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.FromArgb(230, 210, 190)
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 38
            .ColumnHeadersHeight = 45
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(121, 48, 24)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .ColumnHeadersDefaultCellStyle.Padding = New Padding(15, 0, 0, 0)


            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.FromArgb(71, 69, 94)
            .DefaultCellStyle.Font = New Font("Segoe UI", 9.5, FontStyle.Regular)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .DefaultCellStyle.Padding = New Padding(15, 0, 0, 0)


            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 245, 235)
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(71, 69, 94)
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 225, 206)
            .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(71, 69, 94)
        End With
    End Sub
End Class