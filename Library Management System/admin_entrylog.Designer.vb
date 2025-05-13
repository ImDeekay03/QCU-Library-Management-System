<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_entrylog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_entrylog))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.user_icon = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_realtime = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_history = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.rooms_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.logout_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.meetingrm_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.borrowedreturned_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Libbooks_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashbrd_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvEntryLog = New System.Windows.Forms.DataGridView()
        Me.timeDateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.dgvEntryLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(1083, 27)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(81, 15)
        Me.Label33.TabIndex = 25
        Me.Label33.Text = "May 12, 2025"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(1086, 7)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(78, 18)
        Me.Label32.TabIndex = 24
        Me.Label32.Text = "12:00 AM"
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
        Me.user_icon.Location = New System.Drawing.Point(15, 9)
        Me.user_icon.Name = "user_icon"
        Me.user_icon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.user_icon.Size = New System.Drawing.Size(35, 36)
        Me.user_icon.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "User Name"
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel9.Location = New System.Drawing.Point(1170, 7)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(2, 40)
        Me.Guna2Panel9.TabIndex = 19
        '
        'btn_realtime
        '
        Me.btn_realtime.Animated = True
        Me.btn_realtime.BorderRadius = 10
        Me.btn_realtime.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btn_realtime.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_realtime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_realtime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_realtime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_realtime.FillColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_realtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btn_realtime.ForeColor = System.Drawing.Color.White
        Me.btn_realtime.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btn_realtime.Location = New System.Drawing.Point(366, 86)
        Me.btn_realtime.Name = "btn_realtime"
        Me.btn_realtime.Size = New System.Drawing.Size(150, 41)
        Me.btn_realtime.TabIndex = 54
        Me.btn_realtime.Text = "Real-Time Log"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.Label33)
        Me.Guna2Panel2.Controls.Add(Me.Label32)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel9)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2Panel2.Controls.Add(Me.user_icon)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(147, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1219, 52)
        Me.Guna2Panel2.TabIndex = 52
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
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(1178, 7)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(40, 39)
        Me.Guna2CircleButton1.TabIndex = 1
        '
        'btn_history
        '
        Me.btn_history.Animated = True
        Me.btn_history.BorderRadius = 10
        Me.btn_history.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btn_history.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_history.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_history.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_history.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_history.FillColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btn_history.ForeColor = System.Drawing.Color.White
        Me.btn_history.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btn_history.Location = New System.Drawing.Point(210, 86)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(150, 41)
        Me.btn_history.TabIndex = 53
        Me.btn_history.Text = "History Log"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.rooms_btn)
        Me.Guna2Panel1.Controls.Add(Me.logout_btn)
        Me.Guna2Panel1.Controls.Add(Me.meetingrm_btn)
        Me.Guna2Panel1.Controls.Add(Me.borrowedreturned_btn)
        Me.Guna2Panel1.Controls.Add(Me.Libbooks_btn)
        Me.Guna2Panel1.Controls.Add(Me.dashbrd_btn)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(147, 768)
        Me.Guna2Panel1.TabIndex = 59
        '
        'rooms_btn
        '
        Me.rooms_btn.Animated = True
        Me.rooms_btn.AnimatedGIF = True
        Me.rooms_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.rooms_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.rooms_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.rooms_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.rooms_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.rooms_btn.FillColor = System.Drawing.Color.Transparent
        Me.rooms_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rooms_btn.ForeColor = System.Drawing.Color.Black
        Me.rooms_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.rooms_btn.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.rooms_btn.Image = CType(resources.GetObject("rooms_btn.Image"), System.Drawing.Image)
        Me.rooms_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rooms_btn.ImageSize = New System.Drawing.Size(24, 24)
        Me.rooms_btn.Location = New System.Drawing.Point(3, 417)
        Me.rooms_btn.Name = "rooms_btn"
        Me.rooms_btn.Size = New System.Drawing.Size(141, 60)
        Me.rooms_btn.TabIndex = 14
        Me.rooms_btn.Text = "Rooms"
        Me.rooms_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rooms_btn.TextOffset = New System.Drawing.Point(5, 0)
        '
        'logout_btn
        '
        Me.logout_btn.Animated = True
        Me.logout_btn.AnimatedGIF = True
        Me.logout_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.logout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logout_btn.FillColor = System.Drawing.Color.Transparent
        Me.logout_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_btn.ForeColor = System.Drawing.Color.Black
        Me.logout_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.logout_btn.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.logout_btn.Image = CType(resources.GetObject("logout_btn.Image"), System.Drawing.Image)
        Me.logout_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.logout_btn.ImageSize = New System.Drawing.Size(24, 24)
        Me.logout_btn.Location = New System.Drawing.Point(3, 657)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(141, 60)
        Me.logout_btn.TabIndex = 13
        Me.logout_btn.Text = "Log Out"
        Me.logout_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.logout_btn.TextOffset = New System.Drawing.Point(5, 0)
        '
        'meetingrm_btn
        '
        Me.meetingrm_btn.Animated = True
        Me.meetingrm_btn.AnimatedGIF = True
        Me.meetingrm_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.meetingrm_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.meetingrm_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.meetingrm_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.meetingrm_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.meetingrm_btn.FillColor = System.Drawing.Color.Transparent
        Me.meetingrm_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meetingrm_btn.ForeColor = System.Drawing.Color.Black
        Me.meetingrm_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.meetingrm_btn.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.meetingrm_btn.Image = CType(resources.GetObject("meetingrm_btn.Image"), System.Drawing.Image)
        Me.meetingrm_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.meetingrm_btn.ImageSize = New System.Drawing.Size(24, 24)
        Me.meetingrm_btn.Location = New System.Drawing.Point(3, 351)
        Me.meetingrm_btn.Name = "meetingrm_btn"
        Me.meetingrm_btn.Size = New System.Drawing.Size(141, 60)
        Me.meetingrm_btn.TabIndex = 12
        Me.meetingrm_btn.Text = "Books"
        Me.meetingrm_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.meetingrm_btn.TextOffset = New System.Drawing.Point(5, 0)
        '
        'borrowedreturned_btn
        '
        Me.borrowedreturned_btn.Animated = True
        Me.borrowedreturned_btn.AnimatedGIF = True
        Me.borrowedreturned_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.borrowedreturned_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.borrowedreturned_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.borrowedreturned_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.borrowedreturned_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.borrowedreturned_btn.FillColor = System.Drawing.Color.Transparent
        Me.borrowedreturned_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.borrowedreturned_btn.ForeColor = System.Drawing.Color.Black
        Me.borrowedreturned_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.borrowedreturned_btn.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.borrowedreturned_btn.Image = CType(resources.GetObject("borrowedreturned_btn.Image"), System.Drawing.Image)
        Me.borrowedreturned_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.borrowedreturned_btn.ImageSize = New System.Drawing.Size(24, 24)
        Me.borrowedreturned_btn.Location = New System.Drawing.Point(3, 219)
        Me.borrowedreturned_btn.Name = "borrowedreturned_btn"
        Me.borrowedreturned_btn.Size = New System.Drawing.Size(141, 60)
        Me.borrowedreturned_btn.TabIndex = 11
        Me.borrowedreturned_btn.Text = "Entry Log"
        Me.borrowedreturned_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.borrowedreturned_btn.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Libbooks_btn
        '
        Me.Libbooks_btn.Animated = True
        Me.Libbooks_btn.AnimatedGIF = True
        Me.Libbooks_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Libbooks_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Libbooks_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Libbooks_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Libbooks_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Libbooks_btn.FillColor = System.Drawing.Color.Transparent
        Me.Libbooks_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Libbooks_btn.ForeColor = System.Drawing.Color.Black
        Me.Libbooks_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Libbooks_btn.HoverState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.Libbooks_btn.Image = CType(resources.GetObject("Libbooks_btn.Image"), System.Drawing.Image)
        Me.Libbooks_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Libbooks_btn.ImageSize = New System.Drawing.Size(24, 24)
        Me.Libbooks_btn.Location = New System.Drawing.Point(3, 285)
        Me.Libbooks_btn.Name = "Libbooks_btn"
        Me.Libbooks_btn.Size = New System.Drawing.Size(141, 60)
        Me.Libbooks_btn.TabIndex = 10
        Me.Libbooks_btn.Text = "Users"
        Me.Libbooks_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Libbooks_btn.TextOffset = New System.Drawing.Point(5, 0)
        '
        'dashbrd_btn
        '
        Me.dashbrd_btn.Animated = True
        Me.dashbrd_btn.AnimatedGIF = True
        Me.dashbrd_btn.BackColor = System.Drawing.Color.Transparent
        Me.dashbrd_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.dashbrd_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.dashbrd_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.dashbrd_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dashbrd_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dashbrd_btn.FillColor = System.Drawing.Color.Transparent
        Me.dashbrd_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dashbrd_btn.ForeColor = System.Drawing.Color.Black
        Me.dashbrd_btn.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.dashbrd_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.dashbrd_btn.HoverState.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.dashbrd_btn.Image = CType(resources.GetObject("dashbrd_btn.Image"), System.Drawing.Image)
        Me.dashbrd_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dashbrd_btn.ImageSize = New System.Drawing.Size(24, 24)
        Me.dashbrd_btn.Location = New System.Drawing.Point(3, 153)
        Me.dashbrd_btn.Name = "dashbrd_btn"
        Me.dashbrd_btn.Size = New System.Drawing.Size(141, 60)
        Me.dashbrd_btn.TabIndex = 9
        Me.dashbrd_btn.Text = "Dashboard"
        Me.dashbrd_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dashbrd_btn.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "QCU Library"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(120, 98)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 9
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.dgvEntryLog)
        Me.Guna2Panel3.Location = New System.Drawing.Point(212, 153)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1099, 544)
        Me.Guna2Panel3.TabIndex = 60
        '
        'dgvEntryLog
        '
        Me.dgvEntryLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntryLog.Location = New System.Drawing.Point(-2, 0)
        Me.dgvEntryLog.Name = "dgvEntryLog"
        Me.dgvEntryLog.Size = New System.Drawing.Size(1092, 546)
        Me.dgvEntryLog.TabIndex = 61
        '
        'timeDateTimer
        '
        Me.timeDateTimer.Interval = 1000
        '
        'admin_entrylog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btn_realtime)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.btn_history)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin_entrylog"
        Me.Text = "admin_entrylog"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.dgvEntryLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btn_realtime As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents user_icon As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_history As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents rooms_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logout_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents meetingrm_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents borrowedreturned_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Libbooks_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashbrd_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents timeDateTimer As Timer
    Friend WithEvents dgvEntryLog As DataGridView
End Class
