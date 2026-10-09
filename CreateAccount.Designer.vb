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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginlinklb = New System.Windows.Forms.LinkLabel()
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
        Me.registerpanel.Controls.Add(Me.birthdatetimepicker)
        Me.registerpanel.Controls.Add(Me.Label4)
        Me.registerpanel.Controls.Add(Me.Label3)
        Me.registerpanel.Controls.Add(Me.Label2)
        Me.registerpanel.Controls.Add(Me.loginlinklb)
        Me.registerpanel.Controls.Add(Me.registerbttn)
        Me.registerpanel.Controls.Add(Me.gendercmbbx)
        Me.registerpanel.Controls.Add(Me.confirmpasswtxtbx)
        Me.registerpanel.Controls.Add(Me.passwtxtbx)
        Me.registerpanel.Controls.Add(Me.usernametxtbx)
        Me.registerpanel.Controls.Add(Me.lastnametxtbx)
        Me.registerpanel.Controls.Add(Me.fnametxtbx)
        Me.registerpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.registerpanel.Location = New System.Drawing.Point(0, 0)
        Me.registerpanel.Name = "registerpanel"
        Me.registerpanel.Size = New System.Drawing.Size(1050, 702)
        Me.registerpanel.TabIndex = 12
        '
        'birthdatetimepicker
        '
        Me.birthdatetimepicker.AutoRoundedCorners = True
        Me.birthdatetimepicker.BackColor = System.Drawing.Color.Transparent
        Me.birthdatetimepicker.Checked = True
        Me.birthdatetimepicker.FillColor = System.Drawing.Color.White
        Me.birthdatetimepicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.birthdatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthdatetimepicker.Location = New System.Drawing.Point(214, 397)
        Me.birthdatetimepicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.birthdatetimepicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.birthdatetimepicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.birthdatetimepicker.Name = "birthdatetimepicker"
        Me.birthdatetimepicker.Size = New System.Drawing.Size(268, 55)
        Me.birthdatetimepicker.TabIndex = 21
        Me.birthdatetimepicker.Value = New Date(2026, 9, 30, 18, 59, 56, 905)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(464, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 36)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Register"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(223, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Birthdate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(595, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Gender"
        '
        'loginlinklb
        '
        Me.loginlinklb.ActiveLinkColor = System.Drawing.Color.LightGray
        Me.loginlinklb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.loginlinklb.AutoSize = True
        Me.loginlinklb.BackColor = System.Drawing.Color.Transparent
        Me.loginlinklb.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginlinklb.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginlinklb.Location = New System.Drawing.Point(465, 569)
        Me.loginlinklb.Name = "loginlinklb"
        Me.loginlinklb.Size = New System.Drawing.Size(96, 33)
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
        Me.registerbttn.Location = New System.Drawing.Point(374, 494)
        Me.registerbttn.Name = "registerbttn"
        Me.registerbttn.Size = New System.Drawing.Size(268, 55)
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
        Me.gendercmbbx.Items.AddRange(New Object() {"Male", "Female"})
        Me.gendercmbbx.Location = New System.Drawing.Point(585, 304)
        Me.gendercmbbx.Name = "gendercmbbx"
        Me.gendercmbbx.Size = New System.Drawing.Size(260, 31)
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
        Me.confirmpasswtxtbx.Location = New System.Drawing.Point(585, 226)
        Me.confirmpasswtxtbx.Margin = New System.Windows.Forms.Padding(6)
        Me.confirmpasswtxtbx.Name = "confirmpasswtxtbx"
        Me.confirmpasswtxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.confirmpasswtxtbx.PlaceholderText = "Confirm Password"
        Me.confirmpasswtxtbx.SelectedText = ""
        Me.confirmpasswtxtbx.Size = New System.Drawing.Size(260, 49)
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
        Me.passwtxtbx.Location = New System.Drawing.Point(585, 149)
        Me.passwtxtbx.Margin = New System.Windows.Forms.Padding(6)
        Me.passwtxtbx.Name = "passwtxtbx"
        Me.passwtxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.passwtxtbx.PlaceholderText = "Password"
        Me.passwtxtbx.SelectedText = ""
        Me.passwtxtbx.Size = New System.Drawing.Size(260, 49)
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
        Me.usernametxtbx.Location = New System.Drawing.Point(214, 302)
        Me.usernametxtbx.Margin = New System.Windows.Forms.Padding(6)
        Me.usernametxtbx.Name = "usernametxtbx"
        Me.usernametxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.usernametxtbx.PlaceholderText = "User Name"
        Me.usernametxtbx.SelectedText = ""
        Me.usernametxtbx.Size = New System.Drawing.Size(260, 49)
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
        Me.lastnametxtbx.Location = New System.Drawing.Point(214, 226)
        Me.lastnametxtbx.Margin = New System.Windows.Forms.Padding(6)
        Me.lastnametxtbx.Name = "lastnametxtbx"
        Me.lastnametxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.lastnametxtbx.PlaceholderText = "Last Name"
        Me.lastnametxtbx.SelectedText = ""
        Me.lastnametxtbx.Size = New System.Drawing.Size(260, 49)
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
        Me.fnametxtbx.Location = New System.Drawing.Point(214, 149)
        Me.fnametxtbx.Margin = New System.Windows.Forms.Padding(6)
        Me.fnametxtbx.Name = "fnametxtbx"
        Me.fnametxtbx.PlaceholderForeColor = System.Drawing.Color.Sienna
        Me.fnametxtbx.PlaceholderText = "First Name"
        Me.fnametxtbx.SelectedText = ""
        Me.fnametxtbx.Size = New System.Drawing.Size(260, 49)
        Me.fnametxtbx.TabIndex = 2
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1050, 702)
        Me.Controls.Add(Me.registerpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents loginlinklb As LinkLabel

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents birthdatetimepicker As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
