<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_books
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_books))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.user_icon = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnRooms = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBooks = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEntlog = New Guna.UI2.WinForms.Guna2Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Guna2Button10 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.panelSidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.colBookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLanguage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAvailability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2.SuspendLayout()
        Me.panelSidebar.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'user_icon
        '
        Me.user_icon.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.user_icon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.user_icon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.user_icon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.user_icon.FillColor = System.Drawing.Color.Transparent
        Me.user_icon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.user_icon.ForeColor = System.Drawing.Color.White
        Me.user_icon.Image = CType(resources.GetObject("user_icon.Image"), System.Drawing.Image)
        Me.user_icon.ImageSize = New System.Drawing.Size(40, 40)
        Me.user_icon.Location = New System.Drawing.Point(20, 11)
        Me.user_icon.Margin = New System.Windows.Forms.Padding(4)
        Me.user_icon.Name = "user_icon"
        Me.user_icon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.user_icon.Size = New System.Drawing.Size(47, 44)
        Me.user_icon.TabIndex = 0
        '
        'btnRooms
        '
        Me.btnRooms.Animated = True
        Me.btnRooms.AnimatedGIF = True
        Me.btnRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRooms.FillColor = System.Drawing.Color.Transparent
        Me.btnRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.ForeColor = System.Drawing.Color.Black
        Me.btnRooms.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnRooms.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnRooms.Image = CType(resources.GetObject("btnRooms.Image"), System.Drawing.Image)
        Me.btnRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRooms.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnRooms.Location = New System.Drawing.Point(4, 513)
        Me.btnRooms.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(188, 74)
        Me.btnRooms.TabIndex = 14
        Me.btnRooms.Text = "Rooms"
        Me.btnRooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRooms.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.AnimatedGIF = True
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnLogout.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnLogout.Location = New System.Drawing.Point(4, 809)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(188, 74)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnBooks
        '
        Me.btnBooks.Animated = True
        Me.btnBooks.AnimatedGIF = True
        Me.btnBooks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBooks.FillColor = System.Drawing.Color.Transparent
        Me.btnBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.Black
        Me.btnBooks.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnBooks.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.btnBooks.Image = CType(resources.GetObject("btnBooks.Image"), System.Drawing.Image)
        Me.btnBooks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBooks.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnBooks.Location = New System.Drawing.Point(4, 432)
        Me.btnBooks.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(188, 74)
        Me.btnBooks.TabIndex = 12
        Me.btnBooks.Text = "Books"
        Me.btnBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBooks.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnUsers
        '
        Me.btnUsers.Animated = True
        Me.btnUsers.AnimatedGIF = True
        Me.btnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUsers.FillColor = System.Drawing.Color.Transparent
        Me.btnUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.Black
        Me.btnUsers.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnUsers.HoverState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnUsers.Location = New System.Drawing.Point(4, 351)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(188, 74)
        Me.btnUsers.TabIndex = 10
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnDashboard
        '
        Me.btnDashboard.Animated = True
        Me.btnDashboard.AnimatedGIF = True
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.Black
        Me.btnDashboard.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnDashboard.HoverState.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnDashboard.Location = New System.Drawing.Point(4, 188)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(188, 74)
        Me.btnDashboard.TabIndex = 9
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnEntlog
        '
        Me.btnEntlog.Animated = True
        Me.btnEntlog.AnimatedGIF = True
        Me.btnEntlog.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnEntlog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEntlog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEntlog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEntlog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEntlog.FillColor = System.Drawing.Color.Transparent
        Me.btnEntlog.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnEntlog.ForeColor = System.Drawing.Color.Black
        Me.btnEntlog.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnEntlog.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.btnEntlog.Image = CType(resources.GetObject("btnEntlog.Image"), System.Drawing.Image)
        Me.btnEntlog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEntlog.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnEntlog.Location = New System.Drawing.Point(4, 270)
        Me.btnEntlog.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEntlog.Name = "btnEntlog"
        Me.btnEntlog.Size = New System.Drawing.Size(188, 74)
        Me.btnEntlog.TabIndex = 11
        Me.btnEntlog.Text = "Entry Log"
        Me.btnEntlog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEntlog.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1444, 33)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 18)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "May 12, 2025"
        '
        'Guna2Button10
        '
        Me.Guna2Button10.BorderRadius = 10
        Me.Guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button10.FillColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Guna2Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Guna2Button10.ForeColor = System.Drawing.Color.White
        Me.Guna2Button10.Image = CType(resources.GetObject("Guna2Button10.Image"), System.Drawing.Image)
        Me.Guna2Button10.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button10.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button10.Location = New System.Drawing.Point(1250, 102)
        Me.Guna2Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button10.Name = "Guna2Button10"
        Me.Guna2Button10.Size = New System.Drawing.Size(186, 50)
        Me.Guna2Button10.TabIndex = 62
        Me.Guna2Button10.Text = "Add Books"
        Me.Guna2Button10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button10.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.Label22)
        Me.Guna2Panel2.Controls.Add(Me.Label9)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel9)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2Panel2.Controls.Add(Me.user_icon)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(196, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1625, 64)
        Me.Guna2Panel2.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1448, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 24)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "12:00 AM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Admin Name"
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel9.Location = New System.Drawing.Point(1560, 9)
        Me.Guna2Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(3, 49)
        Me.Guna2Panel9.TabIndex = 19
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.Animated = True
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.Image = CType(resources.GetObject("Guna2CircleButton1.Image"), System.Drawing.Image)
        Me.Guna2CircleButton1.ImageSize = New System.Drawing.Size(35, 35)
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(1571, 9)
        Me.Guna2CircleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(53, 48)
        Me.Guna2CircleButton1.TabIndex = 1
        '
        'panelSidebar
        '
        Me.panelSidebar.BackColor = System.Drawing.Color.White
        Me.panelSidebar.Controls.Add(Me.btnRooms)
        Me.panelSidebar.Controls.Add(Me.btnLogout)
        Me.panelSidebar.Controls.Add(Me.btnBooks)
        Me.panelSidebar.Controls.Add(Me.btnEntlog)
        Me.panelSidebar.Controls.Add(Me.btnUsers)
        Me.panelSidebar.Controls.Add(Me.btnDashboard)
        Me.panelSidebar.Controls.Add(Me.Label1)
        Me.panelSidebar.Controls.Add(Me.Guna2PictureBox1)
        Me.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSidebar.Location = New System.Drawing.Point(0, 0)
        Me.panelSidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSidebar.Name = "panelSidebar"
        Me.panelSidebar.Size = New System.Drawing.Size(196, 945)
        Me.panelSidebar.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "QCU Library"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(13, 8)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(160, 121)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 9
        Me.Guna2PictureBox1.TabStop = False
        '
        'dgvBooks
        '
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvBooks.ColumnHeadersHeight = 50
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBookID, Me.colBookName, Me.colType, Me.colLanguage, Me.colAvailability, Me.colImage})
        Me.dgvBooks.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvBooks.Location = New System.Drawing.Point(272, 188)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.RowHeadersWidth = 100
        Me.dgvBooks.RowTemplate.Height = 24
        Me.dgvBooks.Size = New System.Drawing.Size(1469, 671)
        Me.dgvBooks.TabIndex = 65
        '
        'colBookID
        '
        Me.colBookID.DataPropertyName = "BOOK_ID"
        Me.colBookID.HeaderText = "Book ID"
        Me.colBookID.MinimumWidth = 6
        Me.colBookID.Name = "colBookID"
        '
        'colBookName
        '
        Me.colBookName.DataPropertyName = "BOOK_NAME"
        Me.colBookName.HeaderText = "Book Name"
        Me.colBookName.MinimumWidth = 6
        Me.colBookName.Name = "colBookName"
        '
        'colType
        '
        Me.colType.DataPropertyName = "TYPE"
        Me.colType.HeaderText = "Type"
        Me.colType.MinimumWidth = 6
        Me.colType.Name = "colType"
        '
        'colLanguage
        '
        Me.colLanguage.HeaderText = "Language"
        Me.colLanguage.MinimumWidth = 6
        Me.colLanguage.Name = "colLanguage"
        '
        'colAvailability
        '
        Me.colAvailability.HeaderText = "Availability"
        Me.colAvailability.MinimumWidth = 6
        Me.colAvailability.Name = "colAvailability"
        '
        'colImage
        '
        Me.colImage.HeaderText = "Action"
        Me.colImage.MinimumWidth = 6
        Me.colImage.Name = "colImage"
        Me.colImage.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(265, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 39)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Book Management"
        '
        'txtSearch
        '
        Me.txtSearch.BorderRadius = 10
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.IconLeft = CType(resources.GetObject("txtSearch.IconLeft"), System.Drawing.Image)
        Me.txtSearch.Location = New System.Drawing.Point(1456, 102)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(285, 50)
        Me.txtSearch.TabIndex = 67
        '
        'admin_books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1821, 945)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.Guna2Button10)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.panelSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "admin_books"
        Me.Text = "admin_books"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.panelSidebar.ResumeLayout(False)
        Me.panelSidebar.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button10 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents user_icon As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents panelSidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnRooms As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBooks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEntlog As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents colBookID As DataGridViewTextBoxColumn
    Friend WithEvents colBookName As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colLanguage As DataGridViewTextBoxColumn
    Friend WithEvents colAvailability As DataGridViewTextBoxColumn
    Friend WithEvents colImage As DataGridViewImageColumn
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
