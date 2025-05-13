<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserPopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPopUp))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pn_login1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button11 = New Guna.UI2.WinForms.Guna2Button()
        Me.UserPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ProgramTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NameTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SecondFourDigitsTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FirstTwoDigitsTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProgLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StudIDLabel = New System.Windows.Forms.Label()
        Me.pn_login2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.pn_login1.SuspendLayout()
        CType(Me.UserPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_login2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pn_login1
        '
        Me.pn_login1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pn_login1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pn_login1.BorderRadius = 40
        Me.pn_login1.Controls.Add(Me.Guna2Button11)
        Me.pn_login1.Controls.Add(Me.UserPic)
        Me.pn_login1.Controls.Add(Me.ProgramTxtBox)
        Me.pn_login1.Controls.Add(Me.NameTxtBox)
        Me.pn_login1.Controls.Add(Me.SecondFourDigitsTxtBox)
        Me.pn_login1.Controls.Add(Me.Label8)
        Me.pn_login1.Controls.Add(Me.FirstTwoDigitsTxtBox)
        Me.pn_login1.Controls.Add(Me.ProgLabel)
        Me.pn_login1.Controls.Add(Me.NameLabel)
        Me.pn_login1.Controls.Add(Me.StudIDLabel)
        Me.pn_login1.Controls.Add(Me.pn_login2)
        Me.pn_login1.FillColor = System.Drawing.Color.White
        Me.pn_login1.Location = New System.Drawing.Point(300, 145)
        Me.pn_login1.Margin = New System.Windows.Forms.Padding(4)
        Me.pn_login1.Name = "pn_login1"
        Me.pn_login1.Size = New System.Drawing.Size(1223, 639)
        Me.pn_login1.TabIndex = 0
        '
        'Guna2Button11
        '
        Me.Guna2Button11.Animated = True
        Me.Guna2Button11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button11.BorderRadius = 10
        Me.Guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button11.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Guna2Button11.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button11.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Guna2Button11.Location = New System.Drawing.Point(513, 604)
        Me.Guna2Button11.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button11.Name = "Guna2Button11"
        Me.Guna2Button11.Size = New System.Drawing.Size(77, 31)
        Me.Guna2Button11.TabIndex = 66
        Me.Guna2Button11.Text = "Admin"
        '
        'UserPic
        '
        Me.UserPic.BackColor = System.Drawing.Color.White
        Me.UserPic.Image = CType(resources.GetObject("UserPic.Image"), System.Drawing.Image)
        Me.UserPic.ImageRotate = 0!
        Me.UserPic.Location = New System.Drawing.Point(205, 75)
        Me.UserPic.Margin = New System.Windows.Forms.Padding(4)
        Me.UserPic.Name = "UserPic"
        Me.UserPic.Size = New System.Drawing.Size(176, 122)
        Me.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPic.TabIndex = 8
        Me.UserPic.TabStop = False
        '
        'ProgramTxtBox
        '
        Me.ProgramTxtBox.BorderColor = System.Drawing.Color.Black
        Me.ProgramTxtBox.BorderRadius = 12
        Me.ProgramTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProgramTxtBox.DefaultText = ""
        Me.ProgramTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProgramTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProgramTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProgramTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProgramTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProgramTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramTxtBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ProgramTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProgramTxtBox.Location = New System.Drawing.Point(205, 370)
        Me.ProgramTxtBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgramTxtBox.Name = "ProgramTxtBox"
        Me.ProgramTxtBox.PlaceholderText = "Program"
        Me.ProgramTxtBox.SelectedText = ""
        Me.ProgramTxtBox.Size = New System.Drawing.Size(300, 42)
        Me.ProgramTxtBox.TabIndex = 5
        '
        'NameTxtBox
        '
        Me.NameTxtBox.BorderColor = System.Drawing.Color.Black
        Me.NameTxtBox.BorderRadius = 12
        Me.NameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameTxtBox.DefaultText = ""
        Me.NameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxtBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.NameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxtBox.Location = New System.Drawing.Point(205, 306)
        Me.NameTxtBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTxtBox.Name = "NameTxtBox"
        Me.NameTxtBox.PlaceholderText = "Name"
        Me.NameTxtBox.SelectedText = ""
        Me.NameTxtBox.Size = New System.Drawing.Size(300, 42)
        Me.NameTxtBox.TabIndex = 7
        '
        'SecondFourDigitsTxtBox
        '
        Me.SecondFourDigitsTxtBox.BorderColor = System.Drawing.Color.Black
        Me.SecondFourDigitsTxtBox.BorderRadius = 12
        Me.SecondFourDigitsTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SecondFourDigitsTxtBox.DefaultText = ""
        Me.SecondFourDigitsTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SecondFourDigitsTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SecondFourDigitsTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SecondFourDigitsTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SecondFourDigitsTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SecondFourDigitsTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondFourDigitsTxtBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.SecondFourDigitsTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SecondFourDigitsTxtBox.Location = New System.Drawing.Point(301, 247)
        Me.SecondFourDigitsTxtBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SecondFourDigitsTxtBox.Name = "SecondFourDigitsTxtBox"
        Me.SecondFourDigitsTxtBox.PlaceholderText = "0000"
        Me.SecondFourDigitsTxtBox.SelectedText = ""
        Me.SecondFourDigitsTxtBox.Size = New System.Drawing.Size(72, 37)
        Me.SecondFourDigitsTxtBox.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(271, 247)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 29)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "-"
        '
        'FirstTwoDigitsTxtBox
        '
        Me.FirstTwoDigitsTxtBox.BorderColor = System.Drawing.Color.Black
        Me.FirstTwoDigitsTxtBox.BorderRadius = 12
        Me.FirstTwoDigitsTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstTwoDigitsTxtBox.DefaultText = ""
        Me.FirstTwoDigitsTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstTwoDigitsTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstTwoDigitsTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstTwoDigitsTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstTwoDigitsTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstTwoDigitsTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstTwoDigitsTxtBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.FirstTwoDigitsTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstTwoDigitsTxtBox.Location = New System.Drawing.Point(205, 247)
        Me.FirstTwoDigitsTxtBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.FirstTwoDigitsTxtBox.Name = "FirstTwoDigitsTxtBox"
        Me.FirstTwoDigitsTxtBox.PlaceholderText = "00"
        Me.FirstTwoDigitsTxtBox.SelectedText = ""
        Me.FirstTwoDigitsTxtBox.Size = New System.Drawing.Size(51, 37)
        Me.FirstTwoDigitsTxtBox.TabIndex = 4
        '
        'ProgLabel
        '
        Me.ProgLabel.AutoSize = True
        Me.ProgLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgLabel.Location = New System.Drawing.Point(92, 382)
        Me.ProgLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProgLabel.Name = "ProgLabel"
        Me.ProgLabel.Size = New System.Drawing.Size(97, 24)
        Me.ProgLabel.TabIndex = 3
        Me.ProgLabel.Text = "Program : "
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(112, 318)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(76, 24)
        Me.NameLabel.TabIndex = 2
        Me.NameLabel.Text = "Name : "
        '
        'StudIDLabel
        '
        Me.StudIDLabel.AutoSize = True
        Me.StudIDLabel.BackColor = System.Drawing.Color.White
        Me.StudIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudIDLabel.Location = New System.Drawing.Point(80, 255)
        Me.StudIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StudIDLabel.Name = "StudIDLabel"
        Me.StudIDLabel.Size = New System.Drawing.Size(111, 24)
        Me.StudIDLabel.TabIndex = 1
        Me.StudIDLabel.Text = "Student ID : "
        '
        'pn_login2
        '
        Me.pn_login2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pn_login2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pn_login2.BorderColor = System.Drawing.Color.Transparent
        Me.pn_login2.BorderRadius = 40
        Me.pn_login2.Controls.Add(Me.PictureBox1)
        Me.pn_login2.Controls.Add(Me.LinkLabel1)
        Me.pn_login2.Controls.Add(Me.Label4)
        Me.pn_login2.Controls.Add(Me.Label3)
        Me.pn_login2.Controls.Add(Me.Label2)
        Me.pn_login2.Controls.Add(Me.Label1)
        Me.pn_login2.CustomizableEdges.BottomLeft = False
        Me.pn_login2.CustomizableEdges.TopLeft = False
        Me.pn_login2.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.pn_login2.Location = New System.Drawing.Point(599, 0)
        Me.pn_login2.Margin = New System.Windows.Forms.Padding(4)
        Me.pn_login2.Name = "pn_login2"
        Me.pn_login2.Size = New System.Drawing.Size(624, 639)
        Me.pn_login2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(220, 75)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(325, 556)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(152, 20)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "library@qcu.edu.ph" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(133, 556)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Need help? Email us at " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(189, 382)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Knowledge is free at the library." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Just bring your ID!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(105, 315)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Welcome to Quezon City University Library!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(152, 228)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QCU Library"
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'UserPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1821, 945)
        Me.Controls.Add(Me.pn_login1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Credential PopUp"
        Me.pn_login1.ResumeLayout(False)
        Me.pn_login1.PerformLayout()
        CType(Me.UserPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_login2.ResumeLayout(False)
        Me.pn_login2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pn_login1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pn_login2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents StudIDLabel As Label
    Friend WithEvents FirstTwoDigitsTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NameTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SecondFourDigitsTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ProgramTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button11 As Guna.UI2.WinForms.Guna2Button
End Class
