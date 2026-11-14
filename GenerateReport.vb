Imports System.Data.SqlClient

Public Class GenerateReport

    Private Sub generatereportbtn_Click(sender As Object, e As EventArgs) Handles generatereportbtn.Click
        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            Dim startDate As Date = startdateGdatepickr.Value.Date
            Dim endDate As Date = enddateGdatepickr.Value.Date.AddDays(1).AddSeconds(-1)


            Dim sql As String = " SELECT CAST(transDate AS DATE) AS [Date], " &
                                " TransactionNo AS [Transaction No.], " &
                                " SUM(quantity) AS [Total Item], " &
                                " MAX(discountType) AS [Discount], " &
                                " MAX(total) AS [total] " &
                                " FROM Transactions " &
                                " WHERE transDate BETWEEN @start AND @end " &
                                " GROUP BY CAST(transDate AS DATE), TransactionNo " &
                                " ORDER BY [Date] DESC"

            Using cmd As New SqlCommand(sql, sqlconn)
                cmd.Parameters.AddWithValue("@start", startDate)
                cmd.Parameters.AddWithValue("@end", endDate)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                GeneratereportDtgrid.DataSource = dt
                StyleGrid()

                If dt.Rows.Count = 0 Then
                    MsgBox("No transactions between " & startDate.ToShortDateString() & " and " & endDate.ToShortDateString())
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Private Sub StyleGrid()
        With GeneratereportDtgrid
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .GridColor = Color.FromArgb(230, 230, 230)
            .EnableHeadersVisualStyles = False

            .ColumnHeadersHeight = 38
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 64, 0)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft YaHei UI", 9, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .DefaultCellStyle.Font = New Font("Microsoft YaHei UI", 8.5, FontStyle.Regular)
            .RowTemplate.Height = 32
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 248, 235)

            If .Columns.Contains("Date") Then
                .Columns("Date").FillWeight = 18
                .Columns("Date").DefaultCellStyle.Format = "MM/dd/yyyy"
            End If
            If .Columns.Contains("Transaction No.") Then
                .Columns("Transaction No.").FillWeight = 32
            End If
            If .Columns.Contains("Total Item") Then
                .Columns("Total Item").FillWeight = 14
                .Columns("Total Item").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Total Item").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
            If .Columns.Contains("Discount") Then
                .Columns("Discount").FillWeight = 20
            End If
            If .Columns.Contains("total") Then
                .Columns("total").FillWeight = 16
                .Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("total").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("total").DefaultCellStyle.Format = "N2"
            End If
        End With
    End Sub

    Private Sub printreportbtn_Click(sender As Object, e As EventArgs) Handles printreportbtn.Click
        If GeneratereportDtgrid.Rows.Count = 0 Then
            MsgBox("Generate report first!")
            Return
        End If
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontTitle As New Font("Arial", 12, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 9, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 9)
        Dim fontSmall As New Font("Arial", 8, FontStyle.Italic)
        Dim y As Integer = 20

        Dim xDate As Integer = 20
        Dim xTrans As Integer = 130
        Dim xItems As Integer = 400
        Dim xDisc As Integer = 460
        Dim xTotal As Integer = 580

        Dim ownerName As String = LoggedFirstName & " " & LoggedLastName

        e.Graphics.DrawString("Sales Report: " & startdateGdatepickr.Value.ToShortDateString() & " to " & enddateGdatepickr.Value.ToShortDateString(), fontTitle, Brushes.Black, xDate, y)
        y += 30
        e.Graphics.DrawString("Date", fontHeader, Brushes.Black, xDate, y)
        e.Graphics.DrawString("Transaction No.", fontHeader, Brushes.Black, xTrans, y)
        e.Graphics.DrawString("Items", fontHeader, Brushes.Black, xItems, y)
        e.Graphics.DrawString("Discount", fontHeader, Brushes.Black, xDisc, y)
        e.Graphics.DrawString("Total", fontHeader, Brushes.Black, xTotal, y)
        y += 15
        e.Graphics.DrawLine(Pens.Black, xDate, y, 650, y)
        y += 10

        Dim totalSales As Decimal = 0
        For Each row As DataGridViewRow In GeneratereportDtgrid.Rows
            If row.IsNewRow Then Continue For
            e.Graphics.DrawString(Convert.ToDateTime(row.Cells(0).Value).ToShortDateString(), fontBody, Brushes.Black, xDate, y)
            e.Graphics.DrawString(row.Cells(1).Value.ToString(), fontBody, Brushes.Black, xTrans, y)
            e.Graphics.DrawString(row.Cells(2).Value.ToString(), fontBody, Brushes.Black, xItems, y)
            e.Graphics.DrawString(row.Cells(3).Value.ToString(), fontBody, Brushes.Black, xDisc, y)
            e.Graphics.DrawString("₱" & Convert.ToDecimal(row.Cells(4).Value).ToString("N2"), fontBody, Brushes.Black, xTotal, y)
            y += 20
            totalSales += Convert.ToDecimal(row.Cells(4).Value)
        Next
        y += 10
        e.Graphics.DrawLine(Pens.Black, xDate, y, 650, y)
        y += 15
        e.Graphics.DrawString("TOTAL SALES: ₱" & totalSales.ToString("N2"), fontTitle, Brushes.Black, xDate, y)


        y += 40
        e.Graphics.DrawString("Prepared by: " & ownerName, fontBody, Brushes.Black, xDate, y)
        y += 20
        e.Graphics.DrawString("Date Printed: " & DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt"), fontSmall, Brushes.Black, xDate, y)
        y += 20
        e.Graphics.DrawString("Signature: ____________________", fontBody, Brushes.Black, xDate, y)
    End Sub

End Class