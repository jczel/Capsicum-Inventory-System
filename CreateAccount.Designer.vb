<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccount))
        Me.registerpanel = New System.Windows.Forms.Panel()
        Me.birthdatetimepicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.loginlinklb = New System.Windows.Forms.LinkLabel()
        Me.registerbttn = New Guna.UI2.WinForms.Guna2Button()
        Me.genderlb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.gendercmbbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.birthdatelb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.usertypelb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.usetypecmbbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.confirmpasswtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.usernametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lastnametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fnametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Registerlb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.registerpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'registerpanel
        '
        Me.registerpanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.registerpanel.BackgroundImage = CType(resources.GetObject("registerpanel.BackgroundImage"), System.Drawing.Image)
        Me.registerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registerpanel.Controls.Add(Me.birthdatetimepicker)
        Me.registerpanel.Controls.Add(Me.loginlinklb)
        Me.registerpanel.Controls.Add(Me.registerbttn)
        Me.registerpanel.Controls.Add(Me.genderlb)
        Me.registerpanel.Controls.Add(Me.gendercmbbx)
        Me.registerpanel.Controls.Add(Me.birthdatelb)
        Me.registerpanel.Controls.Add(Me.usertypelb)
        Me.registerpanel.Controls.Add(Me.usetypecmbbx)
        Me.registerpanel.Controls.Add(Me.confirmpasswtxtbx)
        Me.registerpanel.Controls.Add(Me.passwtxtbx)
        Me.registerpanel.Controls.Add(Me.usernametxtbx)
        Me.registerpanel.Controls.Add(Me.lastnametxtbx)
        Me.registerpanel.Controls.Add(Me.fnametxtbx)
        Me.registerpanel.Controls.Add(Me.Registerlb)
        Me.registerpanel.Location = New System.Drawing.Point(0, 0)
        Me.registerpanel.Margin = New System.Windows.Forms.Padding(2)
        Me.registerpanel.Name = "registerpanel"
        Me.registerpanel.Size = New System.Drawing.Size(700, 458)
        Me.registerpanel.TabIndex = 12
        '
        'birthdatetimepicker
        '
        Me.birthdatetimepicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.birthdatetimepicker.AutoRoundedCorners = True
        Me.birthdatetimepicker.BackColor = System.Drawing.Color.Transparent
        Me.birthdatetimepicker.Checked = True
        Me.birthdatetimepicker.FillColor = System.Drawing.Color.White
        Me.birthdatetimepicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.birthdatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.birthdatetimepicker.Location = New System.Drawing.Point(143, 271)
        Me.birthdatetimepicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.birthdatetimepicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.birthdatetimepicker.Name = "birthdatetimepicker"
        Me.birthdatetimepicker.Size = New System.Drawing.Size(223, 36)
        Me.birthdatetimepicker.TabIndex = 18
        Me.birthdatetimepicker.Value = New Date(2026, 9, 29, 16, 45, 21, 942)
        '
        'loginlinklb
        '
        Me.loginlinklb.ActiveLinkColor = System.Drawing.Color.LightGray
        Me.loginlinklb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.loginlinklb.AutoSize = True
        Me.loginlinklb.BackColor = System.Drawing.Color.Transparent
        Me.loginlinklb.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginlinklb.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginlinklb.Location = New System.Drawing.Point(308, 371)
        Me.loginlinklb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.loginlinklb.Name = "loginlinklb"
        Me.loginlinklb.Size = New System.Drawing.Size(68, 22)
        Me.loginlinklb.TabIndex = 16
        Me.loginlinklb.TabStop = True
        Me.loginlinklb.Text = "Log In"
        '
        'registerbttn
        '
        Me.registerbttn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.registerbttn.AutoRoundedCorners = True
        Me.registerbttn.BackColor = System.Drawing.Color.Transparent
        Me.registerbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.registerbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.registerbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.registerbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.registerbttn.FillColor = System.Drawing.Color.SaddleBrown
        Me.registerbttn.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.registerbttn.ForeColor = System.Drawing.Color.White
        Me.registerbttn.Location = New System.Drawing.Point(249, 321)
        Me.registerbttn.Margin = New System.Windows.Forms.Padding(2)
        Me.registerbttn.Name = "registerbttn"
        Me.registerbttn.Size = New System.Drawing.Size(179, 36)
        Me.registerbttn.TabIndex = 14
        Me.registerbttn.Text = "Register"
        '
        'genderlb
        '
        Me.genderlb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.genderlb.BackColor = System.Drawing.Color.Transparent
        Me.genderlb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.genderlb.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.genderlb.Location = New System.Drawing.Point(401, 250)
        Me.genderlb.Margin = New System.Windows.Forms.Padding(2)
        Me.genderlb.Name = "genderlb"
        Me.genderlb.Size = New System.Drawing.Size(42, 17)
        Me.genderlb.TabIndex = 12
        Me.genderlb.Text = "Gender"
        '
        'gendercmbbx
        '
        Me.gendercmbbx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gendercmbbx.AutoRoundedCorners = True
        Me.gendercmbbx.BackColor = System.Drawing.Color.Transparent
        Me.gendercmbbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gendercmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gendercmbbx.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gendercmbbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gendercmbbx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.gendercmbbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gendercmbbx.ItemHeight = 30
        Me.gendercmbbx.Items.AddRange(New Object() {"Male", "Female"})
        Me.gendercmbbx.Location = New System.Drawing.Point(390, 271)
        Me.gendercmbbx.Margin = New System.Windows.Forms.Padding(2)
        Me.gendercmbbx.Name = "gendercmbbx"
        Me.gendercmbbx.Size = New System.Drawing.Size(116, 36)
        Me.gendercmbbx.TabIndex = 11
        '
        'birthdatelb
        '
        Me.birthdatelb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.birthdatelb.BackColor = System.Drawing.Color.Transparent
        Me.birthdatelb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.birthdatelb.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdatelb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.birthdatelb.Location = New System.Drawing.Point(161, 249)
        Me.birthdatelb.Margin = New System.Windows.Forms.Padding(2)
        Me.birthdatelb.Name = "birthdatelb"
        Me.birthdatelb.Size = New System.Drawing.Size(53, 17)
        Me.birthdatelb.TabIndex = 10
        Me.birthdatelb.Text = "Birthdate"
        '
        'usertypelb
        '
        Me.usertypelb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.usertypelb.BackColor = System.Drawing.Color.Transparent
        Me.usertypelb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.usertypelb.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertypelb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.usertypelb.Location = New System.Drawing.Point(401, 187)
        Me.usertypelb.Margin = New System.Windows.Forms.Padding(2)
        Me.usertypelb.Name = "usertypelb"
        Me.usertypelb.Size = New System.Drawing.Size(56, 17)
        Me.usertypelb.TabIndex = 8
        Me.usertypelb.Text = "User Type"
        '
        'usetypecmbbx
        '
        Me.usetypecmbbx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.usetypecmbbx.AutoRoundedCorners = True
        Me.usetypecmbbx.BackColor = System.Drawing.Color.Transparent
        Me.usetypecmbbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.usetypecmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.usetypecmbbx.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usetypecmbbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usetypecmbbx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.usetypecmbbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.usetypecmbbx.ItemHeight = 30
        Me.usetypecmbbx.Items.AddRange(New Object() {"Admin", "Owner", "staff"})
        Me.usetypecmbbx.Location = New System.Drawing.Point(390, 208)
        Me.usetypecmbbx.Margin = New System.Windows.Forms.Padding(2)
        Me.usetypecmbbx.Name = "usetypecmbbx"
        Me.usetypecmbbx.Size = New System.Drawing.Size(116, 36)
        Me.usetypecmbbx.TabIndex = 7
        '
        'confirmpasswtxtbx
        '
        Me.confirmpasswtxtbx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.confirmpasswtxtbx.AutoRoundedCorners = True
        Me.confirmpasswtxtbx.BackColor = System.Drawing.Color.Transparent
        Me.confirmpasswtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmpasswtxtbx.DefaultText = ""
        Me.confirmpasswtxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmpasswtxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmpasswtxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpasswtxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpasswtxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpasswtxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.confirmpasswtxtbx.ForeColor = System.Drawing.Color.Black
        Me.confirmpasswtxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpasswtxtbx.Location = New System.Drawing.Point(390, 147)
        Me.confirmpasswtxtbx.Name = "confirmpasswtxtbx"
        Me.confirmpasswtxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.confirmpasswtxtbx.PlaceholderText = "Confirm Password"
        Me.confirmpasswtxtbx.SelectedText = ""
        Me.confirmpasswtxtbx.Size = New System.Drawing.Size(173, 32)
        Me.confirmpasswtxtbx.TabIndex = 6
        '
        'passwtxtbx
        '
        Me.passwtxtbx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.passwtxtbx.AutoRoundedCorners = True
        Me.passwtxtbx.BackColor = System.Drawing.Color.Transparent
        Me.passwtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwtxtbx.DefaultText = ""
        Me.passwtxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwtxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwtxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwtxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwtxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwtxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.passwtxtbx.ForeColor = System.Drawing.Color.Black
        Me.passwtxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwtxtbx.Location = New System.Drawing.Point(390, 97)
        Me.passwtxtbx.Name = "passwtxtbx"
        Me.passwtxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.passwtxtbx.PlaceholderText = "Password"
        Me.passwtxtbx.SelectedText = ""
        Me.passwtxtbx.Size = New System.Drawing.Size(173, 32)
        Me.passwtxtbx.TabIndex = 5
        '
        'usernametxtbx
        '
        Me.usernametxtbx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.usernametxtbx.AutoRoundedCorners = True
        Me.usernametxtbx.BackColor = System.Drawing.Color.Transparent
        Me.usernametxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernametxtbx.DefaultText = ""
        Me.usernametxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernametxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernametxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernametxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.usernametxtbx.ForeColor = System.Drawing.Color.Black
        Me.usernametxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernametxtbx.Location = New System.Drawing.Point(143, 212)
        Me.usernametxtbx.Name = "usernametxtbx"
        Me.usernametxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.usernametxtbx.PlaceholderText = "User Name"
        Me.usernametxtbx.SelectedText = ""
        Me.usernametxtbx.Size = New System.Drawing.Size(173, 32)
        Me.usernametxtbx.TabIndex = 4
        '
        'lastnametxtbx
        '
        Me.lastnametxtbx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lastnametxtbx.AutoRoundedCorners = True
        Me.lastnametxtbx.BackColor = System.Drawing.Color.Transparent
        Me.lastnametxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastnametxtbx.DefaultText = ""
        Me.lastnametxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lastnametxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lastnametxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastnametxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastnametxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastnametxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lastnametxtbx.ForeColor = System.Drawing.Color.Black
        Me.lastnametxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastnametxtbx.Location = New System.Drawing.Point(143, 147)
        Me.lastnametxtbx.Name = "lastnametxtbx"
        Me.lastnametxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.lastnametxtbx.PlaceholderText = "Last Name"
        Me.lastnametxtbx.SelectedText = ""
        Me.lastnametxtbx.Size = New System.Drawing.Size(173, 32)
        Me.lastnametxtbx.TabIndex = 3
        '
        'fnametxtbx
        '
        Me.fnametxtbx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fnametxtbx.AutoRoundedCorners = True
        Me.fnametxtbx.BackColor = System.Drawing.Color.Transparent
        Me.fnametxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fnametxtbx.DefaultText = ""
        Me.fnametxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fnametxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fnametxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fnametxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fnametxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fnametxtbx.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.fnametxtbx.ForeColor = System.Drawing.Color.Black
        Me.fnametxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fnametxtbx.Location = New System.Drawing.Point(143, 97)
        Me.fnametxtbx.Name = "fnametxtbx"
        Me.fnametxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.fnametxtbx.PlaceholderText = "First Name"
        Me.fnametxtbx.SelectedText = ""
        Me.fnametxtbx.Size = New System.Drawing.Size(173, 32)
        Me.fnametxtbx.TabIndex = 2
        '
        'Registerlb
        '
        Me.Registerlb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Registerlb.BackColor = System.Drawing.Color.Transparent
        Me.Registerlb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Registerlb.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registerlb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Registerlb.Location = New System.Drawing.Point(271, 57)
        Me.Registerlb.Margin = New System.Windows.Forms.Padding(2)
        Me.Registerlb.Name = "Registerlb"
        Me.Registerlb.Size = New System.Drawing.Size(157, 26)
        Me.Registerlb.TabIndex = 1
        Me.Registerlb.Text = "Register Account"
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(700, 458)
        Me.Controls.Add(Me.registerpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CreateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateAccount"
        Me.registerpanel.ResumeLayout(False)
        Me.registerpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents registerpanel As Panel
    Friend WithEvents fnametxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Registerlb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lastnametxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernametxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents confirmpasswtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents passwtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usetypecmbbx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents usertypelb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents birthdatelb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents genderlb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents gendercmbbx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents registerbttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loginlinklb As LinkLabel
    Friend WithEvents birthdatetimepicker As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
