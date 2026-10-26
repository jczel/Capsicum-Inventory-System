<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usermanagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.birthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.confirmpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.rolecmbbox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.gendercmbox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.userid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(29, 44)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(183, 110)
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'lastname
        '
        Me.lastname.AutoRoundedCorners = True
        Me.lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastname.DefaultText = ""
        Me.lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastname.Location = New System.Drawing.Point(29, 226)
        Me.lastname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lastname.Name = "lastname"
        Me.lastname.PlaceholderText = "Lastname"
        Me.lastname.SelectedText = ""
        Me.lastname.Size = New System.Drawing.Size(183, 24)
        Me.lastname.TabIndex = 3
        '
        'username
        '
        Me.username.AutoRoundedCorners = True
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.DefaultText = ""
        Me.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.Location = New System.Drawing.Point(29, 260)
        Me.username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.username.Name = "username"
        Me.username.PlaceholderText = "Username"
        Me.username.SelectedText = ""
        Me.username.Size = New System.Drawing.Size(183, 24)
        Me.username.TabIndex = 4
        '
        'birthdate
        '
        Me.birthdate.AutoRoundedCorners = True
        Me.birthdate.Checked = True
        Me.birthdate.FillColor = System.Drawing.Color.White
        Me.birthdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.birthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthdate.Location = New System.Drawing.Point(29, 307)
        Me.birthdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.birthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.birthdate.Name = "birthdate"
        Me.birthdate.Size = New System.Drawing.Size(183, 27)
        Me.birthdate.TabIndex = 5
        Me.birthdate.Value = New Date(2026, 10, 16, 17, 53, 38, 520)
        '
        'password
        '
        Me.password.AutoRoundedCorners = True
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.DefaultText = ""
        Me.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.Location = New System.Drawing.Point(29, 342)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.password.Name = "password"
        Me.password.PlaceholderText = "Password"
        Me.password.SelectedText = ""
        Me.password.Size = New System.Drawing.Size(183, 23)
        Me.password.TabIndex = 6
        '
        'confirmpass
        '
        Me.confirmpass.AutoRoundedCorners = True
        Me.confirmpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmpass.DefaultText = ""
        Me.confirmpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.confirmpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpass.Location = New System.Drawing.Point(29, 375)
        Me.confirmpass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.confirmpass.Name = "confirmpass"
        Me.confirmpass.PlaceholderText = "Confirm Password"
        Me.confirmpass.SelectedText = ""
        Me.confirmpass.Size = New System.Drawing.Size(183, 23)
        Me.confirmpass.TabIndex = 7
        '
        'rolecmbbox
        '
        Me.rolecmbbox.AutoRoundedCorners = True
        Me.rolecmbbox.BackColor = System.Drawing.Color.Transparent
        Me.rolecmbbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.rolecmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rolecmbbox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rolecmbbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rolecmbbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rolecmbbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.rolecmbbox.ItemHeight = 30
        Me.rolecmbbox.Items.AddRange(New Object() {"Admin", "Owner", "Staff"})
        Me.rolecmbbox.Location = New System.Drawing.Point(29, 422)
        Me.rolecmbbox.Name = "rolecmbbox"
        Me.rolecmbbox.Size = New System.Drawing.Size(183, 36)
        Me.rolecmbbox.TabIndex = 8
        '
        'gendercmbox
        '
        Me.gendercmbox.AutoRoundedCorners = True
        Me.gendercmbox.BackColor = System.Drawing.Color.Transparent
        Me.gendercmbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gendercmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gendercmbox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gendercmbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gendercmbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.gendercmbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gendercmbox.ItemHeight = 30
        Me.gendercmbox.Items.AddRange(New Object() {"Female", "Male"})
        Me.gendercmbox.Location = New System.Drawing.Point(29, 476)
        Me.gendercmbox.Name = "gendercmbox"
        Me.gendercmbox.Size = New System.Drawing.Size(183, 36)
        Me.gendercmbox.TabIndex = 9
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(29, 518)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(183, 39)
        Me.Guna2Button1.TabIndex = 10
        Me.Guna2Button1.Text = "Add"
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 40
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(245, 91)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 62
        Me.Guna2DataGridView1.RowTemplate.Height = 50
        Me.Guna2DataGridView1.RowTemplate.ReadOnly = True
        Me.Guna2DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(805, 466)
        Me.Guna2DataGridView1.TabIndex = 11
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SaddleBrown
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "UserID"
        Me.Column1.Name = "Column1"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Firstname"
        Me.Column11.MinimumWidth = 8
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Lastname"
        Me.Column12.MinimumWidth = 8
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Username"
        Me.Column13.MinimumWidth = 8
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Birthdate"
        Me.Column14.MinimumWidth = 8
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.HeaderText = "Password"
        Me.Column15.MinimumWidth = 8
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.HeaderText = "Role"
        Me.Column16.MinimumWidth = 8
        Me.Column16.Name = "Column16"
        '
        'Column17
        '
        Me.Column17.HeaderText = "Gender"
        Me.Column17.MinimumWidth = 8
        Me.Column17.Name = "Column17"
        '
        'Column18
        '
        Me.Column18.HeaderText = "Image"
        Me.Column18.MinimumWidth = 8
        Me.Column18.Name = "Column18"
        Me.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column19
        '
        Me.Column19.HeaderText = "Edit"
        Me.Column19.MinimumWidth = 8
        Me.Column19.Name = "Column19"
        Me.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column20
        '
        Me.Column20.HeaderText = "Delete"
        Me.Column20.MinimumWidth = 8
        Me.Column20.Name = "Column20"
        '
        'Column2
        '
        Me.Column2.HeaderText = "View"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Role"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Birthdate"
        '
        'firstname
        '
        Me.firstname.AutoRoundedCorners = True
        Me.firstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstname.DefaultText = ""
        Me.firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.firstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstname.Location = New System.Drawing.Point(29, 192)
        Me.firstname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.firstname.Name = "firstname"
        Me.firstname.PlaceholderText = "Firstname"
        Me.firstname.SelectedText = ""
        Me.firstname.Size = New System.Drawing.Size(183, 24)
        Me.firstname.TabIndex = 17
        '
        'userid
        '
        Me.userid.AutoRoundedCorners = True
        Me.userid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.userid.DefaultText = ""
        Me.userid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.userid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.userid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userid.Location = New System.Drawing.Point(29, 162)
        Me.userid.Margin = New System.Windows.Forms.Padding(4)
        Me.userid.Name = "userid"
        Me.userid.PlaceholderText = "User ID"
        Me.userid.SelectedText = ""
        Me.userid.Size = New System.Drawing.Size(183, 21)
        Me.userid.TabIndex = 18
        '
        'Guna2Button2
        '
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.Location = New System.Drawing.Point(29, 563)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(183, 39)
        Me.Guna2Button2.TabIndex = 19
        Me.Guna2Button2.Text = "Update"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox2.AutoRoundedCorners = True
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2TextBox2.BorderThickness = 2
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(922, 33)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PlaceholderText = "Search ID, name, username.."
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(332, 36)
        Me.Guna2TextBox2.TabIndex = 20
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(1260, 33)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(94, 36)
        Me.Guna2Button3.TabIndex = 21
        Me.Guna2Button3.Text = "Search"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me.Guna2DataGridView1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(271, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Manage Accounts"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(14, 35)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(82, 74)
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(102, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(20, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 22)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Gender"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(102, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 28)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(22, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 19)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Role"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(22, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 22)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Birthdate"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 20
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Guna2Panel2.CustomizableEdges.TopLeft = False
        Me.Guna2Panel2.CustomizableEdges.TopRight = False
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Peru
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 278)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(269, 188)
        Me.Guna2Panel2.TabIndex = 7
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Peru
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderThickness = 4
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(1085, 90)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(269, 466)
        Me.Guna2Panel1.TabIndex = 23
        '
        'Usermanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 612)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.gendercmbox)
        Me.Controls.Add(Me.rolecmbbox)
        Me.Controls.Add(Me.confirmpass)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.birthdate)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Name = "Usermanagement"
        Me.Text = "Usermanagement"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents birthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents confirmpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents rolecmbbox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents gendercmbox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents firstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents userid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label4 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewImageColumn
    Friend WithEvents Column19 As DataGridViewButtonColumn
    Friend WithEvents Column20 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
