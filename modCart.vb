Module modCart
    Public CartTable As DataTable
    Public Event CartUpdated()

    Public Sub InitCart()
        CartTable = New DataTable()
        CartTable.Columns.Add("ProductID", GetType(String))
        CartTable.Columns.Add("ProductName", GetType(String))
        CartTable.Columns.Add("Size", GetType(String))
        CartTable.Columns.Add("Price", GetType(Decimal))
    End Sub

    Public Sub AddItem(pid As String, pname As String, psize As String, pprice As Decimal)
        If CartTable Is Nothing Then InitCart()

        Dim hasSeparator As Boolean = False
        For Each r As DataRow In CartTable.Rows
            If r("ProductName").ToString() = "ADD ONS" Then
                hasSeparator = True
                Exit For
            End If
        Next

        If CartTable.Rows.Count = 1 AndAlso Not hasSeparator Then
            Dim sep As DataRow = CartTable.NewRow()
            sep("ProductID") = "SEP"
            sep("ProductName") = "ADD ONS"
            sep("Size") = ""
            sep("Price") = 0
            CartTable.Rows.Add(sep)
        End If

        Dim newRow As DataRow = CartTable.NewRow()
        newRow("ProductID") = pid
        newRow("ProductName") = pname
        newRow("Size") = psize
        newRow("Price") = pprice
        CartTable.Rows.Add(newRow)

        RaiseEvent CartUpdated()
    End Sub

    Public Sub RemoveItem(index As Integer)
        If CartTable Is Nothing Then Return
        If index < 0 OrElse index >= CartTable.Rows.Count Then Return
        If CartTable.Rows(index)("ProductID").ToString() = "SEP" Then Return

        CartTable.Rows.RemoveAt(index)

        If CartTable.Rows.Count = 2 Then
            For i As Integer = CartTable.Rows.Count - 1 To 0 Step -1
                If CartTable.Rows(i)("ProductID").ToString() = "SEP" Then
                    CartTable.Rows.RemoveAt(i)
                End If
            Next
        End If

        If CartTable.Rows.Count = 0 Then CartTable.Clear()
        RaiseEvent CartUpdated()
    End Sub

    Public Sub ClearCart()
        If CartTable IsNot Nothing Then
            CartTable.Clear()
            RaiseEvent CartUpdated()
        End If
    End Sub

    Public Sub AddToCart(pid As String, pname As String, psize As String, qty As Integer, price As Decimal)
        AddItem(pid, pname, psize, price)
    End Sub
End Module