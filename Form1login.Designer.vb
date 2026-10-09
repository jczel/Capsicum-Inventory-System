<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.passwordtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.usernametxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.systemtitlelb = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.showpasschcbx = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.loginbttn = New Guna.UI2.WinForms.Guna2Button()
        Me.pleaseloginlb = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.passwordtxtbx)
        Me.Panel1.Controls.Add(Me.usernametxtbx)
        Me.Panel1.Controls.Add(Me.systemtitlelb)
        Me.Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel1.Controls.Add(Me.showpasschcbx)
        Me.Panel1.Controls.Add(Me.loginbttn)
        Me.Panel1.Controls.Add(Me.pleaseloginlb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 337)
        Me.Panel1.TabIndex = 0
        '
        'passwordtxtbx
        '
        Me.passwordtxtbx.AutoRoundedCorners = True
        Me.passwordtxtbx.BackColor = System.Drawing.Color.Transparent
        Me.passwordtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordtxtbx.DefaultText = ""
        Me.passwordtxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordtxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordtxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtxtbx.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtxtbx.IconRight = CType(resources.GetObject("passwordtxtbx.IconRight"), System.Drawing.Image)
        Me.passwordtxtbx.IconRightSize = New System.Drawing.Size(30, 30)
        Me.passwordtxtbx.Location = New System.Drawing.Point(406, 170)
        Me.passwordtxtbx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwordtxtbx.Name = "passwordtxtbx"
        Me.passwordtxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtxtbx.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.passwordtxtbx.PlaceholderText = "Password"
        Me.passwordtxtbx.SelectedText = ""
        Me.passwordtxtbx.Size = New System.Drawing.Size(235, 30)
        Me.passwordtxtbx.TabIndex = 15
        '
        'usernametxtbx
        '
        Me.usernametxtbx.AutoRoundedCorners = True
        Me.usernametxtbx.BackColor = System.Drawing.Color.Transparent
        Me.usernametxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernametxtbx.DefaultText = ""
        Me.usernametxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernametxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernametxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernametxtbx.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernametxtbx.IconRight = CType(resources.GetObject("usernametxtbx.IconRight"), System.Drawing.Image)
        Me.usernametxtbx.IconRightSize = New System.Drawing.Size(30, 30)
        Me.usernametxtbx.Location = New System.Drawing.Point(406, 125)
        Me.usernametxtbx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.usernametxtbx.Name = "usernametxtbx"
        Me.usernametxtbx.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.usernametxtbx.PlaceholderText = "Username"
        Me.usernametxtbx.SelectedText = ""
        Me.usernametxtbx.Size = New System.Drawing.Size(235, 30)
        Me.usernametxtbx.TabIndex = 14
        '
        'systemtitlelb
        '
        Me.systemtitlelb.AutoSize = True
        Me.systemtitlelb.BackColor = System.Drawing.Color.Transparent
        Me.systemtitlelb.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.systemtitlelb.Location = New System.Drawing.Point(413, 73)
        Me.systemtitlelb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.systemtitlelb.Name = "systemtitlelb"
        Me.systemtitlelb.Size = New System.Drawing.Size(242, 16)
        Me.systemtitlelb.TabIndex = 13
        Me.systemtitlelb.Text = "Inventory System For Small Coffee Shop"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.BackgroundImage = CType(resources.GetObject("Guna2CirclePictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(473, 8)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(106, 86)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 12
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'showpasschcbx
        '
        Me.showpasschcbx.AutoSize = True
        Me.showpasschcbx.BackColor = System.Drawing.Color.Transparent
        Me.showpasschcbx.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.showpasschcbx.CheckedState.BorderRadius = 0
        Me.showpasschcbx.CheckedState.BorderThickness = 0
        Me.showpasschcbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.showpasschcbx.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.showpasschcbx.Location = New System.Drawing.Point(406, 215)
        Me.showpasschcbx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.showpasschcbx.Name = "showpasschcbx"
        Me.showpasschcbx.Size = New System.Drawing.Size(116, 18)
        Me.showpasschcbx.TabIndex = 11
        Me.showpasschcbx.Text = "Show password"
        Me.showpasschcbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.showpasschcbx.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.showpasschcbx.UncheckedState.BorderRadius = 0
        Me.showpasschcbx.UncheckedState.BorderThickness = 0
        Me.showpasschcbx.UncheckedState.FillColor = System.Drawing.Color.Sienna
        Me.showpasschcbx.UseVisualStyleBackColor = False
        '
        'loginbttn
        '
        Me.loginbttn.AutoRoundedCorners = True
        Me.loginbttn.BackColor = System.Drawing.Color.Transparent
        Me.loginbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.loginbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.loginbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loginbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.loginbttn.FillColor = System.Drawing.Color.White
        Me.loginbttn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbttn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginbttn.Location = New System.Drawing.Point(473, 247)
        Me.loginbttn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.loginbttn.Name = "loginbttn"
        Me.loginbttn.Size = New System.Drawing.Size(106, 29)
        Me.loginbttn.TabIndex = 8
        Me.loginbttn.Text = "Log In"
        '
        'pleaseloginlb
        '
        Me.pleaseloginlb.AutoSize = True
        Me.pleaseloginlb.BackColor = System.Drawing.Color.Transparent
        Me.pleaseloginlb.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pleaseloginlb.ForeColor = System.Drawing.Color.White
        Me.pleaseloginlb.Location = New System.Drawing.Point(431, 96)
        Me.pleaseloginlb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pleaseloginlb.Name = "pleaseloginlb"
        Me.pleaseloginlb.Size = New System.Drawing.Size(181, 17)
        Me.pleaseloginlb.TabIndex = 1
        Me.pleaseloginlb.Text = "Please Login your account"
        '
        'Form1login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(699, 337)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(719, 387)
        Me.Name = "Form1login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pleaseloginlb As Label
    Friend WithEvents loginbttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showpasschcbx As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents systemtitlelb As Label
    Friend WithEvents passwordtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernametxtbx As Guna.UI2.WinForms.Guna2TextBox
End Class
