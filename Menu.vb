Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports System.IO

Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.WrapContents = True
        connect()
        loadGrouped("All")
    End Sub

    Public Sub loadGrouped(Optional filter As String = "All")
        FlowLayoutPanel1.Controls.Clear()
        Try
            If sqlconn.State = ConnectionState.Closed Then sqlconn.Open()
            Dim dtAll As New DataTable()
            Dim sql As String
            If filter = "All" Then
                sql = "SELECT ProductID, productname, size, price, prodimage, category, quantity FROM Product ORDER BY productname"
                cmd = New SqlCommand(sql, sqlconn)
            Else
                sql = "SELECT ProductID, productname, size, price, prodimage, category, quantity FROM Product WHERE category = @category ORDER BY productname"
                cmd = New SqlCommand(sql, sqlconn)
                cmd.Parameters.AddWithValue("@category", filter)
            End If
            cmd.CommandTimeout = 120
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dtAll)

            Dim grouped = dtAll.AsEnumerable().GroupBy(Function(r) r.Field(Of String)("productname"))
            For Each g In grouped
                Dim pName As String = g.Key
                Dim idS As String = ""
                Dim idM As String = ""
                Dim idL As String = ""
                Dim idSingle As String = ""
                Dim priceS As String = ""
                Dim priceM As String = ""
                Dim priceL As String = ""
                Dim singlePrice As String = ""
                Dim qtyS As Integer = 0
                Dim qtyM As Integer = 0
                Dim qtyL As Integer = 0
                Dim qtySingle As Integer = 0
                Dim prodImage As Object = Nothing

                For Each r2 In g
                    Dim sz As String = ""
                    If Not IsDBNull(r2("size")) Then sz = r2("size").ToString().Trim().ToUpper()
                    Dim rID As String = r2("ProductID").ToString()
                    Dim curQty As Integer = 0
                    If Not IsDBNull(r2("quantity")) Then curQty = CInt(r2("quantity"))
                    If sz = "" Then
                        singlePrice = r2("price").ToString()
                        idSingle = rID
                        qtySingle = curQty
                    ElseIf sz = "S" OrElse sz.Contains("SMALL") Then
                        priceS = r2("price").ToString()
                        idS = rID
                        qtyS = curQty
                    ElseIf sz = "M" OrElse sz.Contains("MED") Then
                        priceM = r2("price").ToString()
                        idM = rID
                        qtyM = curQty
                    ElseIf sz = "L" OrElse sz.Contains("LARGE") Then
                        priceL = r2("price").ToString()
                        idL = rID
                        qtyL = curQty
                    End If
                    prodImage = r2("prodimage")
                Next

                Dim selectedSize As String = ""
                Dim selectedPrice As Decimal = 0
                Dim selectedID As String = ""
                Dim selectedQty As Integer = 0

                Dim sizeCount As Integer = 0
                If priceS <> "" Then sizeCount += 1
                If priceM <> "" Then sizeCount += 1
                If priceL <> "" Then sizeCount += 1

                If singlePrice <> "" Then
                    selectedSize = ""
                    selectedPrice = CDec(singlePrice)
                    selectedID = idSingle
                    selectedQty = qtySingle
                ElseIf sizeCount = 1 Then
                    If priceS <> "" Then
                        selectedSize = "S" : selectedPrice = CDec(priceS) : selectedID = idS : selectedQty = qtyS
                    ElseIf priceM <> "" Then
                        selectedSize = "M" : selectedPrice = CDec(priceM) : selectedID = idM : selectedQty = qtyM
                    ElseIf priceL <> "" Then
                        selectedSize = "L" : selectedPrice = CDec(priceL) : selectedID = idL : selectedQty = qtyL
                    End If
                Else
                    selectedSize = ""
                    selectedID = ""
                    selectedPrice = 0
                    selectedQty = 0
                End If

                Dim container As New Guna2Panel With {.Height = 168, .Width = 275, .BorderRadius = 20, .BorderThickness = 2, .BorderColor = Color.FromArgb(128, 64, 0), .Margin = New Padding(10)}
                Dim productName As New Label With {.Text = pName, .Location = New Point(133, 20), .AutoSize = True, .Font = New Font("Microsoft YaHei UI", 9, FontStyle.Bold)}
                Dim productPrice As New Label With {.Location = New Point(133, 50), .AutoSize = True, .Font = New Font("Microsoft YaHei UI", 12, FontStyle.Bold)}

                If singlePrice <> "" Then
                    productPrice.Text = "₱" & singlePrice
                ElseIf priceM <> "" Then
                    productPrice.Text = "₱" & priceM
                ElseIf priceS <> "" Then
                    productPrice.Text = "₱" & priceS
                ElseIf priceL <> "" Then
                    productPrice.Text = "₱" & priceL
                End If

                Dim productImg As New Guna2PictureBox With {.Location = New Point(13, 12), .Size = New Size(102, 91), .BorderRadius = 10, .SizeMode = PictureBoxSizeMode.StretchImage}
                Try
                    If prodImage IsNot Nothing AndAlso Not IsDBNull(prodImage) Then
                        Dim imgBytes As Byte() = DirectCast(prodImage, Byte())
                        Using ms As New MemoryStream(imgBytes)
                            productImg.Image = Image.FromStream(ms)
                        End Using
                    End If
                Catch
                End Try

                Dim btnS As New Guna2Button With {.Text = "S", .Location = New Point(13, 123), .Size = New Size(44, 33), .BorderRadius = 15, .BorderThickness = 2, .BorderColor = Color.FromArgb(128, 64, 0), .FillColor = Color.FromArgb(128, 64, 0), .ForeColor = Color.White}
                Dim btnM As New Guna2Button With {.Text = "M", .Location = New Point(63, 123), .Size = New Size(52, 33), .BorderRadius = 15, .BorderThickness = 2, .BorderColor = Color.FromArgb(128, 64, 0), .FillColor = Color.FromArgb(128, 64, 0), .ForeColor = Color.White}
                Dim btnL As New Guna2Button With {.Text = "L", .Location = New Point(121, 123), .Size = New Size(44, 33), .BorderRadius = 15, .BorderThickness = 2, .BorderColor = Color.FromArgb(128, 64, 0), .FillColor = Color.FromArgb(128, 64, 0), .ForeColor = Color.White}
                Dim addBtn As New Guna2Button With {.Text = "Add", .Location = New Point(171, 123), .Size = New Size(85, 33), .BorderRadius = 10, .FillColor = Color.FromArgb(128, 64, 0)}

                If singlePrice <> "" Then
                    btnS.Visible = False
                    btnM.Visible = False
                    btnL.Visible = False
                    addBtn.Location = New Point(13, 123)
                    addBtn.Size = New Size(243, 33)
                    addBtn.Enabled = True
                    addBtn.FillColor = Color.FromArgb(128, 64, 0)
                Else
                    If priceS = "" Then btnS.Visible = False
                    If priceM = "" Then btnM.Visible = False
                    If priceL = "" Then btnL.Visible = False

                    If sizeCount > 1 Then
                        addBtn.Enabled = False
                        addBtn.FillColor = Color.Gray
                    Else
                        addBtn.Enabled = True
                        addBtn.FillColor = Color.FromArgb(128, 64, 0)
                    End If
                End If

                Dim ResetSizeButtons = Sub()
                                           For Each b In {btnS, btnM, btnL}
                                               b.FillColor = Color.FromArgb(128, 64, 0)
                                               b.ForeColor = Color.White
                                           Next
                                       End Sub

                Dim HighlightButton = Sub(btn As Guna2Button)
                                          ResetSizeButtons()
                                          btn.FillColor = Color.White
                                          btn.ForeColor = Color.FromArgb(128, 64, 0)
                                      End Sub

                AddHandler btnS.Click, Sub(s, ev)
                                           productPrice.Text = "₱" & priceS
                                           selectedSize = "S"
                                           selectedPrice = CDec(priceS)
                                           selectedID = idS
                                           selectedQty = qtyS
                                           HighlightButton(btnS)
                                           addBtn.Enabled = True
                                           addBtn.FillColor = Color.FromArgb(128, 64, 0)
                                       End Sub
                AddHandler btnM.Click, Sub(s, ev)
                                           productPrice.Text = "₱" & priceM
                                           selectedSize = "M"
                                           selectedPrice = CDec(priceM)
                                           selectedID = idM
                                           selectedQty = qtyM
                                           HighlightButton(btnM)
                                           addBtn.Enabled = True
                                           addBtn.FillColor = Color.FromArgb(128, 64, 0)
                                       End Sub
                AddHandler btnL.Click, Sub(s, ev)
                                           productPrice.Text = "₱" & priceL
                                           selectedSize = "L"
                                           selectedPrice = CDec(priceL)
                                           selectedID = idL
                                           selectedQty = qtyL
                                           HighlightButton(btnL)
                                           addBtn.Enabled = True
                                           addBtn.FillColor = Color.FromArgb(128, 64, 0)
                                       End Sub

                AddHandler addBtn.Click, Sub(s, ev)
                                             If selectedID = "" OrElse selectedPrice <= 0 Then
                                                 MessageBox.Show("Pili ka muna ng size (S / M / L) para sa " & pName & "!", "Select Size", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                 Return
                                             End If

                                             Dim halfStockLimit As Integer = 25
                                             If selectedQty <= 0 Then
                                                 MessageBox.Show(pName & " (" & selectedSize & ") is OUT OF STOCK!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                                 Return
                                             End If
                                             If selectedQty <= halfStockLimit Then
                                                 MessageBox.Show("Cannot add " & pName & vbCrLf & vbCrLf & "Stock is too low: " & selectedQty & " left." & vbCrLf & "Half of stock reached (" & halfStockLimit & "). Please restock first.", "Low Stock - Blocked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                                 Return
                                             End If

                                             Dim inCart As Integer = 0
                                             If modCart.CartTable IsNot Nothing Then
                                                 For Each r As DataRow In modCart.CartTable.Rows
                                                     If r("ProductID").ToString() = selectedID Then inCart += 1
                                                 Next
                                             End If
                                             If inCart + 1 > selectedQty Then
                                                 MessageBox.Show("Cannot add more " & pName & ". You already have " & inCart & " in cart, stock is only " & selectedQty, "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                                 Return
                                             End If

                                             modCart.AddItem(selectedID, pName, selectedSize, selectedPrice)

                                             ' ===== RESET AFTER ADD =====
                                             ResetSizeButtons()

                                             If sizeCount > 1 Then
                                                 selectedSize = ""
                                                 selectedID = ""
                                                 selectedPrice = 0
                                                 selectedQty = 0
                                                 addBtn.Enabled = False
                                                 addBtn.FillColor = Color.Gray
                                                 If priceM <> "" Then
                                                     productPrice.Text = "₱" & priceM
                                                 ElseIf priceS <> "" Then
                                                     productPrice.Text = "₱" & priceS
                                                 End If
                                             End If
                                         End Sub

                container.Controls.Add(productName)
                container.Controls.Add(productPrice)
                container.Controls.Add(productImg)
                container.Controls.Add(btnS)
                container.Controls.Add(btnM)
                container.Controls.Add(btnL)
                container.Controls.Add(addBtn)
                FlowLayoutPanel1.Controls.Add(container)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        End Try
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint
    End Sub
End Class