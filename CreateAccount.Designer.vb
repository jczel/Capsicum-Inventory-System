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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rolecombbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.birthdatetimepicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Role = New System.Windows.Forms.Label()
        Me.registerbttn = New Guna.UI2.WinForms.Guna2Button()
        Me.gendercmbbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.confirmpasswtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.usernametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lastnametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fnametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.registerpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'registerpanel
        '
        Me.registerpanel.BackColor = System.Drawing.Color.Transparent
        Me.registerpanel.BackgroundImage = CType(resources.GetObject("registerpanel.BackgroundImage"), System.Drawing.Image)
        Me.registerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registerpanel.Controls.Add(Me.Label1)
        Me.registerpanel.Controls.Add(Me.rolecombbx)
        Me.registerpanel.Controls.Add(Me.birthdatetimepicker)
        Me.registerpanel.Controls.Add(Me.Label4)
        Me.registerpanel.Controls.Add(Me.Label3)
        Me.registerpanel.Controls.Add(Me.Role)
        Me.registerpanel.Controls.Add(Me.registerbttn)
        Me.registerpanel.Controls.Add(Me.gendercmbbx)
        Me.registerpanel.Controls.Add(Me.confirmpasswtxtbx)
        Me.registerpanel.Controls.Add(Me.passwtxtbx)
        Me.registerpanel.Controls.Add(Me.usernametxtbx)
        Me.registerpanel.Controls.Add(Me.lastnametxtbx)
        Me.registerpanel.Controls.Add(Me.fnametxtbx)
        Me.registerpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.registerpanel.Location = New System.Drawing.Point(0, 0)
        Me.registerpanel.Margin = New System.Windows.Forms.Padding(2)
        Me.registerpanel.Name = "registerpanel"
        Me.registerpanel.Size = New System.Drawing.Size(700, 456)
        Me.registerpanel.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(407, 248)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Gender"
        '
        'rolecombbx
        '
        Me.rolecombbx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rolecombbx.AutoRoundedCorners = True
        Me.rolecombbx.BackColor = System.Drawing.Color.Transparent
        Me.rolecombbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.rolecombbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rolecombbx.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rolecombbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rolecombbx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rolecombbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.rolecombbx.ItemHeight = 25
        Me.rolecombbx.Items.AddRange(New Object() {"Admin", "Owner", "Staff"})
        Me.rolecombbx.Location = New System.Drawing.Point(390, 208)
        Me.rolecombbx.Margin = New System.Windows.Forms.Padding(2)
        Me.rolecombbx.Name = "rolecombbx"
        Me.rolecombbx.Size = New System.Drawing.Size(175, 31)
        Me.rolecombbx.TabIndex = 22
        '
        'birthdatetimepicker
        '
        Me.birthdatetimepicker.AutoRoundedCorners = True
        Me.birthdatetimepicker.BackColor = System.Drawing.Color.Transparent
        Me.birthdatetimepicker.Checked = True
        Me.birthdatetimepicker.FillColor = System.Drawing.Color.White
        Me.birthdatetimepicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.birthdatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthdatetimepicker.Location = New System.Drawing.Point(143, 258)
        Me.birthdatetimepicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.birthdatetimepicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.birthdatetimepicker.Name = "birthdatetimepicker"
        Me.birthdatetimepicker.Size = New System.Drawing.Size(179, 36)
        Me.birthdatetimepicker.TabIndex = 21
        Me.birthdatetimepicker.Value = New Date(2026, 9, 30, 18, 59, 56, 905)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(309, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Register"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(154, 242)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Birthdate"
        '
        'Role
        '
        Me.Role.AutoSize = True
        Me.Role.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Role.Location = New System.Drawing.Point(407, 193)
        Me.Role.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(36, 15)
        Me.Role.TabIndex = 18
        Me.Role.Text = "Roles"
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
        Me.gendercmbbx.ItemHeight = 25
        Me.gendercmbbx.Items.AddRange(New Object() {"Female", "Male"})
        Me.gendercmbbx.Location = New System.Drawing.Point(390, 263)
        Me.gendercmbbx.Margin = New System.Windows.Forms.Padding(2)
        Me.gendercmbbx.Name = "gendercmbbx"
        Me.gendercmbbx.Size = New System.Drawing.Size(175, 31)
        Me.gendercmbbx.TabIndex = 11
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
        Me.confirmpasswtxtbx.Margin = New System.Windows.Forms.Padding(4)
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
        Me.passwtxtbx.Margin = New System.Windows.Forms.Padding(4)
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
        Me.usernametxtbx.Location = New System.Drawing.Point(143, 196)
        Me.usernametxtbx.Margin = New System.Windows.Forms.Padding(4)
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
        Me.lastnametxtbx.Margin = New System.Windows.Forms.Padding(4)
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
        Me.fnametxtbx.Margin = New System.Windows.Forms.Padding(4)
        Me.fnametxtbx.Name = "fnametxtbx"
        Me.fnametxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.fnametxtbx.PlaceholderText = "First Name"
        Me.fnametxtbx.SelectedText = ""
        Me.fnametxtbx.Size = New System.Drawing.Size(173, 32)
        Me.fnametxtbx.TabIndex = 2
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(700, 456)
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
    Friend WithEvents lastnametxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernametxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents confirmpasswtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents passwtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gendercmbbx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents registerbttn As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents Label3 As Label
    Friend WithEvents Role As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents birthdatetimepicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents rolecombbx As Guna.UI2.WinForms.Guna2ComboBox
End Class
