Imports System.Data.SqlClient

Public Class Menucntrl
    Dim product As New Menu
    Dim discountRate As Decimal = 0
    Dim subTotal As Decimal = 0
    Dim finalTotal As Decimal = 0

    Private Sub Menucntrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Panel11.Controls.Clear()
        product.Dock = DockStyle.Fill
        Guna2Panel11.Controls.Add(product)

        modCart.InitCart()

        cmbDiscountType.Items.Clear()
        cmbDiscountType.Items.Add("None")
        cmbDiscountType.Items.Add("Senior Citizen - 20%")
        cmbDiscountType.Items.Add("PWD - 20%")
        cmbDiscountType.SelectedIndex = 0
        txtDiscountID.Enabled = False

        ProductCartDtgrd.DataSource = modCart.CartTable
        ProductCartDtgrd.AllowUserToAddRows = False

        If ProductCartDtgrd.Columns("ProductID") IsNot Nothing Then
            ProductCartDtgrd.Columns("ProductID").Visible = True
        End If

        If ProductCartDtgrd.Columns("Remove") Is Nothing Then
            Dim b As New DataGridViewButtonColumn()
            b.Name = "Remove"
            b.Text = "Remove"
            b.UseColumnTextForButtonValue = True
            ProductCartDtgrd.Columns.Add(b)
        End If

        AddHandler modCart.CartUpdated, AddressOf RefreshCart
        ComputeTotal()
    End Sub

    Private Sub RefreshCart()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf RefreshCart))
            Return
        End If
        ProductCartDtgrd.Refresh()
        ComputeTotal()
    End Sub

    ' DFD: PRICE PROCESS - D DISCOUNT, D TOTAL PRICE
    Sub ComputeTotal()
        subTotal = 0
        For Each r As DataRow In modCart.CartTable.Rows
            If r("ProductID").ToString() <> "SEP" Then
                subTotal += CDec(r("Price"))
            End If
        Next

        If cmbDiscountType.Text.Contains("Senior") Or cmbDiscountType.Text.Contains("PWD") Then
            discountRate = 0.2D
        Else
            discountRate = 0
        End If

        Dim discountAmt As Decimal = subTotal * discountRate
        finalTotal = subTotal - discountAmt

        subnumlb.Text = subTotal.ToString("0.00")
        discntnumlb.Text = discountRate.ToString("0%") & " (-₱" & discountAmt.ToString("0.00") & ")"
        If discountRate = 0 Then discntnumlb.Text = "0% (-₱0.00)"
        totalnumlb.Text = finalTotal.ToString("0.00")
    End Sub

    Private Sub cmbDiscountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDiscountType.SelectedIndexChanged
        If cmbDiscountType.SelectedIndex = 0 Then
            txtDiscountID.Clear()
            txtDiscountID.Enabled = False
        Else
            txtDiscountID.Enabled = True
            txtDiscountID.Focus()
        End If
        ComputeTotal()
    End Sub

    Private Sub allprdbttn_Click(sender As Object, e As EventArgs) Handles allprdbttn.Click
        product.loadGrouped("All")
    End Sub
    Private Sub hotCofbttn_Click(sender As Object, e As EventArgs) Handles hotCofbttn.Click
        product.loadGrouped("Hot Coffee")
    End Sub
    Private Sub coldCofbttn_Click(sender As Object, e As EventArgs) Handles coldCofbttn.Click
        product.loadGrouped("Cold Coffee")
    End Sub
    Private Sub teabttn_Click(sender As Object, e As EventArgs) Handles teabttn.Click
        product.loadGrouped("Tea")
    End Sub
    Private Sub Dssrtbttn_Click(sender As Object, e As EventArgs) Handles Dssrtbttn.Click
        product.loadGrouped("Desserts")
    End Sub

    Private Sub ProductCartDtgrd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductCartDtgrd.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim pid = ProductCartDtgrd.Rows(e.RowIndex).Cells("ProductID").Value
        If pid IsNot Nothing AndAlso pid.ToString() = "SEP" Then Return
        If ProductCartDtgrd.Columns(e.ColumnIndex).Name = "Remove" Then
            modCart.RemoveItem(e.RowIndex)
        End If
    End Sub

    Private Sub ProductCartDtgrd_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ProductCartDtgrd.CellFormatting
        If e.RowIndex < 0 Then Return
        Dim grid = CType(sender, DataGridView)
        If e.RowIndex >= grid.Rows.Count Then Return
        Dim row = grid.Rows(e.RowIndex)
        Dim pidVal = row.Cells("ProductID").Value

        If pidVal IsNot Nothing AndAlso pidVal.ToString() = "SEP" Then
            row.DefaultCellStyle.BackColor = Color.FromArgb(128, 64, 0)
            row.DefaultCellStyle.ForeColor = Color.White
            row.DefaultCellStyle.Font = New Font("Microsoft YaHei UI", 9, FontStyle.Bold)
            If grid.Columns(e.ColumnIndex).Name = "ProductID" OrElse
               grid.Columns(e.ColumnIndex).Name = "Price" OrElse
               grid.Columns(e.ColumnIndex).Name = "Size" OrElse
               grid.Columns(e.ColumnIndex).Name = "Remove" Then
                e.Value = ""
            End If
        Else
            row.DefaultCellStyle.BackColor = Color.White
            row.DefaultCellStyle.ForeColor = Color.Black
            row.DefaultCellStyle.Font = New Font("Microsoft YaHei UI", 8, FontStyle.Regular)
        End If
    End Sub

    Private Sub ProductCartDtgrd_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles ProductCartDtgrd.CellPainting
        If e.RowIndex < 0 Then Return
        Dim grid = CType(sender, DataGridView)
        Dim pid = grid.Rows(e.RowIndex).Cells("ProductID").Value
        If pid IsNot Nothing AndAlso pid.ToString() = "SEP" Then
            If grid.Columns(e.ColumnIndex).Name = "Remove" Then
                e.PaintBackground(e.CellBounds, True)
                Using brush As New SolidBrush(Color.FromArgb(128, 64, 0))
                    e.Graphics.FillRectangle(brush, e.CellBounds)
                End Using
                e.Handled = True
            End If
        End If
    End Sub

    ' ===== DFD: D CONFIRM + PAYMENT + D TRANSACTION TABLE + PRINT RECEIPT =====
    Private Sub Confrmbttn_Click(sender As Object, e As EventArgs) Handles Confrmbttn.Click
        ' 1. Validate Cart (ADDS-ON Process)
        If modCart.CartTable Is Nothing OrElse modCart.CartTable.Rows.Count = 0 Then
            MsgBox("Cart is empty! Please add products.", MsgBoxStyle.Exclamation, "Empty Cart")
            Return
        End If

        Dim realCount As Integer = 0
        For Each r As DataRow In modCart.CartTable.Rows
            If r("ProductID").ToString() <> "SEP" Then realCount += 1
        Next
        If realCount = 0 Then
            MsgBox("Cart is empty!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' 2. Validate Discount (D DISCOUNT)
        If cmbDiscountType.SelectedIndex > 0 AndAlso txtDiscountID.Text.Trim() = "" Then
            MsgBox("Please enter ID No. for " & cmbDiscountType.Text, MsgBoxStyle.Exclamation, "Discount Required")
            txtDiscountID.Focus()
            Return
        End If

        ' 3. Confirm Payment (D CONFIRM)
        Dim ask = MsgBox("Confirm Payment?" & vbCrLf & "Total: ₱" & finalTotal.ToString("0.00"), MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Payment Confirmation")
        If ask = MsgBoxResult.No Then Return

        Try
            connect()
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()

            ' Generate one TransactionNo for whole order (main + add-ons)
            Dim transNo As String = "TRN" & DateTime.Now.ToString("yyyyMMddHHmmss")

            For Each r As DataRow In modCart.CartTable.Rows
                If r("ProductID").ToString() = "SEP" Then Continue For ' skip ADD ONS header

                ' DFD: D TRANSACTION TABLE - Save to DB
                Dim sql As String = "INSERT INTO Transactions (TransactionNo, ProductID, productname, size, price, quantity, subTotal, discountType, discountID, discountRate, total, transDate) VALUES (@trn, @pid, @pname, @size, @price, @qty, @sub, @dtype, @did, @drate, @total, @date)"
                Using cmd As New SqlCommand(sql, sqlconn)
                    cmd.Parameters.AddWithValue("@trn", transNo)
                    cmd.Parameters.AddWithValue("@pid", r("ProductID"))
                    cmd.Parameters.AddWithValue("@pname", r("ProductName"))
                    cmd.Parameters.AddWithValue("@size", r("Size"))
                    cmd.Parameters.AddWithValue("@price", CDec(r("Price")))
                    cmd.Parameters.AddWithValue("@qty", 1)
                    cmd.Parameters.AddWithValue("@sub", subTotal)
                    cmd.Parameters.AddWithValue("@dtype", cmbDiscountType.Text)
                    cmd.Parameters.AddWithValue("@did", txtDiscountID.Text)
                    cmd.Parameters.AddWithValue("@drate", discountRate)
                    cmd.Parameters.AddWithValue("@total", finalTotal)
                    cmd.Parameters.AddWithValue("@date", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using
            Next

            ' DFD: PRINT RECEIPT
            Dim receipt As String = "===== COFFEE SHOP RECEIPT =====" & vbCrLf
            receipt &= "Trans No: " & transNo & vbCrLf
            receipt &= "Date: " & DateTime.Now.ToString() & vbCrLf & vbCrLf
            For Each r As DataRow In modCart.CartTable.Rows
                If r("ProductID").ToString() = "SEP" Then
                    receipt &= vbCrLf & "--- ADD ONS ---" & vbCrLf
                Else
                    receipt &= r("ProductName").ToString() & " (" & r("Size").ToString() & ") - ₱" & CDec(r("Price")).ToString("0.00") & vbCrLf
                End If
            Next
            receipt &= vbCrLf & "Sub Total: ₱" & subTotal.ToString("0.00") & vbCrLf
            receipt &= "Discount: " & discntnumlb.Text & vbCrLf
            receipt &= "TOTAL: ₱" & finalTotal.ToString("0.00") & vbCrLf & vbCrLf
            receipt &= "Thank you!"

            MsgBox(receipt, MsgBoxStyle.Information, "Receipt - Payment Successful")

            ' 4. Clear after payment
            ClearAll()

        Catch ex As Exception
            MsgBox("Transaction Failed: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Private Sub Clearbttn_Click(sender As Object, e As EventArgs) Handles Clearbttn.Click
        If modCart.CartTable.Rows.Count = 0 Then Return

        Dim ask = MsgBox("Clear all items in cart?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Clear Cart")
        If ask = MsgBoxResult.Yes Then
            ClearAll()
        End If
    End Sub

    Private Sub ClearAll()
        ' DFD: CLEAR - reset all D (Cart, Discount, Total)
        modCart.ClearCart()
        cmbDiscountType.SelectedIndex = 0
        txtDiscountID.Clear()
        txtDiscountID.Enabled = False
        subTotal = 0
        finalTotal = 0
        discountRate = 0
        subnumlb.Text = "0.00"
        discntnumlb.Text = "0% (-₱0.00)"
        totalnumlb.Text = "0.00"
    End Sub

    Private Sub Guna2Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel11.Paint
    End Sub
    Private Sub Discountlb_Paint(sender As Object, e As PaintEventArgs) Handles Discountlb.Paint
    End Sub
End Class