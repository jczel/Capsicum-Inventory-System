<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionHistoryCntrl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionHistoryCntrl))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.transactionhistorylb = New System.Windows.Forms.Label()
        Me.printreportbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GeneratereportDtgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startdatetransactlb = New System.Windows.Forms.Label()
        Me.enddatetransactlb = New System.Windows.Forms.Label()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.GeneratereportDtgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.23664!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.7633588!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1048, 578)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.BorderThickness = 2
        Me.Guna2Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1034, 572)
        Me.Guna2Panel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2Panel1, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2Panel7, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2Panel6, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.03743!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.96257!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 384.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1034, 572)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Guna2Panel7.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Guna2Panel7.BorderRadius = 5
        Me.Guna2Panel7.BorderThickness = 2
        Me.Guna2Panel7.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Guna2Panel7.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2Panel7.Controls.Add(Me.enddatetransactlb)
        Me.Guna2Panel7.Controls.Add(Me.startdatetransactlb)
        Me.Guna2Panel7.Controls.Add(Me.printreportbtn)
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel7.Location = New System.Drawing.Point(3, 76)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(1028, 108)
        Me.Guna2Panel7.TabIndex = 2
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Guna2Panel6.BorderRadius = 5
        Me.Guna2Panel6.BorderThickness = 2
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel9)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(1028, 67)
        Me.Guna2Panel6.TabIndex = 1
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Guna2Panel9.BorderRadius = 5
        Me.Guna2Panel9.BorderThickness = 2
        Me.Guna2Panel9.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel9.Controls.Add(Me.transactionhistorylb)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(1028, 67)
        Me.Guna2Panel9.TabIndex = 1
        '
        'transactionhistorylb
        '
        Me.transactionhistorylb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.transactionhistorylb.AutoSize = True
        Me.transactionhistorylb.BackColor = System.Drawing.Color.Transparent
        Me.transactionhistorylb.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionhistorylb.ForeColor = System.Drawing.Color.SaddleBrown
        Me.transactionhistorylb.Location = New System.Drawing.Point(412, 15)
        Me.transactionhistorylb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.transactionhistorylb.Name = "transactionhistorylb"
        Me.transactionhistorylb.Size = New System.Drawing.Size(317, 37)
        Me.transactionhistorylb.TabIndex = 1
        Me.transactionhistorylb.Text = "Transaction History"
        '
        'printreportbtn
        '
        Me.printreportbtn.BackColor = System.Drawing.Color.Transparent
        Me.printreportbtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.printreportbtn.BorderRadius = 10
        Me.printreportbtn.BorderThickness = 2
        Me.printreportbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.printreportbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.printreportbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.printreportbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.printreportbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.printreportbtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.printreportbtn.ForeColor = System.Drawing.Color.White
        Me.printreportbtn.Location = New System.Drawing.Point(799, 29)
        Me.printreportbtn.Name = "printreportbtn"
        Me.printreportbtn.Size = New System.Drawing.Size(215, 51)
        Me.printreportbtn.TabIndex = 66
        Me.printreportbtn.Text = "Search"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.GeneratereportDtgrid)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 190)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1028, 379)
        Me.Guna2Panel1.TabIndex = 3
        '
        'GeneratereportDtgrid
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GeneratereportDtgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GeneratereportDtgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GeneratereportDtgrid.ColumnHeadersHeight = 34
        Me.GeneratereportDtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GeneratereportDtgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GeneratereportDtgrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.GeneratereportDtgrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeneratereportDtgrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GeneratereportDtgrid.Location = New System.Drawing.Point(0, 0)
        Me.GeneratereportDtgrid.Name = "GeneratereportDtgrid"
        Me.GeneratereportDtgrid.RowHeadersVisible = False
        Me.GeneratereportDtgrid.Size = New System.Drawing.Size(1028, 379)
        Me.GeneratereportDtgrid.TabIndex = 1
        Me.GeneratereportDtgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GeneratereportDtgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SaddleBrown
        Me.GeneratereportDtgrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratereportDtgrid.ThemeStyle.HeaderStyle.Height = 34
        Me.GeneratereportDtgrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Column6
        '
        Me.Column6.HeaderText = "Date"
        Me.Column6.Name = "Column6"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Transaction ID"
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Staff "
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Total Item"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Discount"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        '
        'startdatetransactlb
        '
        Me.startdatetransactlb.AutoSize = True
        Me.startdatetransactlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startdatetransactlb.ForeColor = System.Drawing.Color.SaddleBrown
        Me.startdatetransactlb.Location = New System.Drawing.Point(24, 42)
        Me.startdatetransactlb.Name = "startdatetransactlb"
        Me.startdatetransactlb.Size = New System.Drawing.Size(111, 24)
        Me.startdatetransactlb.TabIndex = 67
        Me.startdatetransactlb.Text = "Start Date :"
        '
        'enddatetransactlb
        '
        Me.enddatetransactlb.AutoSize = True
        Me.enddatetransactlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enddatetransactlb.ForeColor = System.Drawing.Color.SaddleBrown
        Me.enddatetransactlb.Location = New System.Drawing.Point(403, 42)
        Me.enddatetransactlb.Name = "enddatetransactlb"
        Me.enddatetransactlb.Size = New System.Drawing.Size(108, 24)
        Me.enddatetransactlb.TabIndex = 68
        Me.enddatetransactlb.Text = "End Date :"
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Guna2DateTimePicker1.BorderRadius = 5
        Me.Guna2DateTimePicker1.BorderThickness = 2
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(517, 30)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(202, 50)
        Me.Guna2DateTimePicker1.TabIndex = 70
        Me.Guna2DateTimePicker1.Value = New Date(2026, 11, 9, 11, 53, 16, 246)
        '
        'Guna2DateTimePicker2
        '
        Me.Guna2DateTimePicker2.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Guna2DateTimePicker2.BorderRadius = 5
        Me.Guna2DateTimePicker2.BorderThickness = 2
        Me.Guna2DateTimePicker2.Checked = True
        Me.Guna2DateTimePicker2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker2.Location = New System.Drawing.Point(182, 30)
        Me.Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Me.Guna2DateTimePicker2.Size = New System.Drawing.Size(202, 50)
        Me.Guna2DateTimePicker2.TabIndex = 71
        Me.Guna2DateTimePicker2.Value = New Date(2026, 11, 9, 11, 53, 16, 246)
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.BackgroundImage = CType(resources.GetObject("Guna2CirclePictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(167, 67)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 14
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'TransactionHistoryCntrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "TransactionHistoryCntrl"
        Me.Size = New System.Drawing.Size(1048, 578)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel7.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel9.ResumeLayout(False)
        Me.Guna2Panel9.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.GeneratereportDtgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents transactionhistorylb As Label
    Friend WithEvents printreportbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GeneratereportDtgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents startdatetransactlb As Label
    Friend WithEvents enddatetransactlb As Label
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
