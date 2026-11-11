Imports System.Data.SqlClient

Public Class GenerateReport
    Private Sub generatereportbtn_Click(sender As Object, e As EventArgs) Handles generatereportbtn.Click
        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            Dim startDate As Date = startdateGdatepickr.Value.Date
            Dim endDate As Date = enddateGdatepickr.Value.Date.AddDays(1).AddSeconds(-1)

            Dim sql As String = "
            SELECT 
                CAST(transDate AS DATE) AS [Date],
                TransactionNo AS [Transaction No.],
                COUNT(*) AS [Total Item],
                MAX(discountType) AS [Discount],
                MAX(total) AS [total]
            FROM Transactions
            WHERE transDate BETWEEN @start AND @end
            GROUP BY CAST(transDate AS DATE), TransactionNo
            ORDER BY [Date] DESC"

            Using cmd As New SqlCommand(sql, sqlconn)
                cmd.Parameters.AddWithValue("@start", startDate)
                cmd.Parameters.AddWithValue("@end", endDate)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                GeneratereportDtgrid.DataSource = dt

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
        Dim y As Integer = 20

        ' Fixed X positions ng columns
        Dim xDate As Integer = 20
        Dim xTrans As Integer = 110
        Dim xItems As Integer = 290
        Dim xDisc As Integer = 350
        Dim xTotal As Integer = 520

        ' Title
        e.Graphics.DrawString("Sales Report: " & startdateGdatepickr.Value.ToShortDateString() & " to " & enddateGdatepickr.Value.ToShortDateString(), fontTitle, Brushes.Black, xDate, y)
        y += 30

        ' Header
        e.Graphics.DrawString("Date", fontHeader, Brushes.Black, xDate, y)
        e.Graphics.DrawString("Transaction No.", fontHeader, Brushes.Black, xTrans, y)
        e.Graphics.DrawString("Items", fontHeader, Brushes.Black, xItems, y)
        e.Graphics.DrawString("Discount", fontHeader, Brushes.Black, xDisc, y)
        e.Graphics.DrawString("Total", fontHeader, Brushes.Black, xTotal, y)
        y += 15
        e.Graphics.DrawLine(Pens.Black, xDate, y, 650, y)
        y += 10

        ' Body
        Dim totalSales As Decimal = 0
        For Each row As DataGridViewRow In GeneratereportDtgrid.Rows
            If row.IsNewRow Then Continue For

            e.Graphics.DrawString(Convert.ToDateTime(row.Cells(0).Value).ToShortDateString(), fontBody, Brushes.Black, xDate, y)
            e.Graphics.DrawString(row.Cells(1).Value.ToString(), fontBody, Brushes.Black, xTrans, y)
            e.Graphics.DrawString(row.Cells(2).Value.ToString(), fontBody, Brushes.Black, xItems, y)
            e.Graphics.DrawString(row.Cells(3).Value.ToString(), fontBody, Brushes.Black, xDisc, y)
            e.Graphics.DrawString("₱" & row.Cells(4).Value.ToString(), fontBody, Brushes.Black, xTotal, y)

            y += 20
            totalSales += Convert.ToDecimal(row.Cells(4).Value)
        Next

        y += 10
        e.Graphics.DrawLine(Pens.Black, xDate, y, 650, y)
        y += 10
        e.Graphics.DrawString("TOTAL SALES: ₱" & totalSales.ToString("N2"), fontTitle, Brushes.Black, xDate, y)
        y += 30
        e.Graphics.DrawString("Prepared by: ____________________", fontBody, Brushes.Black, xDate, y)
    End Sub
End Class