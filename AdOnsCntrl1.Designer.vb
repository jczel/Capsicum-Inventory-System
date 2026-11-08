<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdOnsCntrl1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdOnsCntrl1))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.slectsizelb = New System.Windows.Forms.Label()
        Me.Selectsizecmbbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Srchtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Searchbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(994, 626)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.21725!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.40575!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.21725!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(994, 626)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.Controls.Add(Me.slectsizelb)
        Me.Guna2Panel2.Controls.Add(Me.Selectsizecmbbx)
        Me.Guna2Panel2.Controls.Add(Me.Srchtxtbx)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Searchbtn)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.BorderRadius = 10
        Me.Guna2Panel2.ShadowDecoration.Depth = 20
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.Size = New System.Drawing.Size(988, 83)
        Me.Guna2Panel2.TabIndex = 1
        '
        'slectsizelb
        '
        Me.slectsizelb.AutoSize = True
        Me.slectsizelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slectsizelb.Location = New System.Drawing.Point(299, 38)
        Me.slectsizelb.Name = "slectsizelb"
        Me.slectsizelb.Size = New System.Drawing.Size(79, 15)
        Me.slectsizelb.TabIndex = 70
        Me.slectsizelb.Text = "Select Size"
        '
        'Selectsizecmbbx
        '
        Me.Selectsizecmbbx.BackColor = System.Drawing.Color.Transparent
        Me.Selectsizecmbbx.BorderColor = System.Drawing.Color.SaddleBrown
        Me.Selectsizecmbbx.BorderRadius = 5
        Me.Selectsizecmbbx.BorderThickness = 2
        Me.Selectsizecmbbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Selectsizecmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Selectsizecmbbx.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Selectsizecmbbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Selectsizecmbbx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Selectsizecmbbx.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Selectsizecmbbx.ItemHeight = 35
        Me.Selectsizecmbbx.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.Selectsizecmbbx.Location = New System.Drawing.Point(280, 25)
        Me.Selectsizecmbbx.Name = "Selectsizecmbbx"
        Me.Selectsizecmbbx.Size = New System.Drawing.Size(160, 41)
        Me.Selectsizecmbbx.TabIndex = 69
        '
        'Srchtxtbx
        '
        Me.Srchtxtbx.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Srchtxtbx.AutoRoundedCorners = True
        Me.Srchtxtbx.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Srchtxtbx.BorderThickness = 2
        Me.Srchtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Srchtxtbx.DefaultText = ""
        Me.Srchtxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Srchtxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Srchtxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Srchtxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Srchtxtbx.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Srchtxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Srchtxtbx.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.Srchtxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Srchtxtbx.Location = New System.Drawing.Point(559, 28)
        Me.Srchtxtbx.Margin = New System.Windows.Forms.Padding(8)
        Me.Srchtxtbx.Name = "Srchtxtbx"
        Me.Srchtxtbx.PlaceholderText = "Search Product ID, name..."
        Me.Srchtxtbx.SelectedText = ""
        Me.Srchtxtbx.Size = New System.Drawing.Size(317, 38)
        Me.Srchtxtbx.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(165, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Add more product"
        '
        'Searchbtn
        '
        Me.Searchbtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Searchbtn.AutoRoundedCorners = True
        Me.Searchbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Searchbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Searchbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Searchbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Searchbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Searchbtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchbtn.ForeColor = System.Drawing.Color.White
        Me.Searchbtn.Location = New System.Drawing.Point(888, 30)
        Me.Searchbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(82, 38)
        Me.Searchbtn.TabIndex = 23
        Me.Searchbtn.Text = "Search"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(164, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Add-Ons"
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
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(167, 83)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 13
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'AdOnsCntrl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "AdOnsCntrl1"
        Me.Size = New System.Drawing.Size(994, 626)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Srchtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Searchbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Selectsizecmbbx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents slectsizelb As Label
End Class
