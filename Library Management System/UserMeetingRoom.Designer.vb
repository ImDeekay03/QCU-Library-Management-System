<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserMeetingRoom
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserMeetingRoom))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlBookMeeting = New Guna.UI2.WinForms.Guna2Panel()
        Me.time_modes_cb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.min_updown = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.hour_updown = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.room_number_field = New Guna.UI2.WinForms.Guna2TextBox()
        Me.duration_field = New Guna.UI2.WinForms.Guna2TextBox()
        Me.book_meeting_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.desc_field = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlAvailability = New Guna.UI2.WinForms.Guna2Panel()
        Me.booked_meetings_dtg = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.meeting_date_picker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.user_icon = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.borrow_books_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.rooms_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.logout_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.meetingrm_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashbrd_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.upcoming_meeting_dtg = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlBookMeeting.SuspendLayout()
        CType(Me.min_updown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hour_updown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAvailability.SuspendLayout()
        CType(Me.booked_meetings_dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upcoming_meeting_dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlBookMeeting
        '
        Me.pnlBookMeeting.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBookMeeting.BorderRadius = 15
        Me.pnlBookMeeting.Controls.Add(Me.meeting_date_picker)
        Me.pnlBookMeeting.Controls.Add(Me.time_modes_cb)
        Me.pnlBookMeeting.Controls.Add(Me.min_updown)
        Me.pnlBookMeeting.Controls.Add(Me.hour_updown)
        Me.pnlBookMeeting.Controls.Add(Me.room_number_field)
        Me.pnlBookMeeting.Controls.Add(Me.duration_field)
        Me.pnlBookMeeting.Controls.Add(Me.book_meeting_btn)
        Me.pnlBookMeeting.Controls.Add(Me.Label10)
        Me.pnlBookMeeting.Controls.Add(Me.desc_field)
        Me.pnlBookMeeting.Controls.Add(Me.Label9)
        Me.pnlBookMeeting.FillColor = System.Drawing.Color.White
        Me.pnlBookMeeting.Location = New System.Drawing.Point(180, 109)
        Me.pnlBookMeeting.Name = "pnlBookMeeting"
        Me.pnlBookMeeting.Size = New System.Drawing.Size(556, 169)
        Me.pnlBookMeeting.TabIndex = 16
        '
        'time_modes_cb
        '
        Me.time_modes_cb.BackColor = System.Drawing.Color.Transparent
        Me.time_modes_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.time_modes_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.time_modes_cb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.time_modes_cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.time_modes_cb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.time_modes_cb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.time_modes_cb.ItemHeight = 30
        Me.time_modes_cb.Items.AddRange(New Object() {"AM", "PM"})
        Me.time_modes_cb.Location = New System.Drawing.Point(346, 89)
        Me.time_modes_cb.Name = "time_modes_cb"
        Me.time_modes_cb.Size = New System.Drawing.Size(80, 36)
        Me.time_modes_cb.TabIndex = 38
        '
        'min_updown
        '
        Me.min_updown.BackColor = System.Drawing.Color.Transparent
        Me.min_updown.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.min_updown.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.min_updown.Location = New System.Drawing.Point(290, 95)
        Me.min_updown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.min_updown.Name = "min_updown"
        Me.min_updown.Size = New System.Drawing.Size(50, 28)
        Me.min_updown.TabIndex = 37
        '
        'hour_updown
        '
        Me.hour_updown.BackColor = System.Drawing.Color.Transparent
        Me.hour_updown.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.hour_updown.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hour_updown.Location = New System.Drawing.Point(227, 95)
        Me.hour_updown.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.hour_updown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hour_updown.Name = "hour_updown"
        Me.hour_updown.Size = New System.Drawing.Size(52, 28)
        Me.hour_updown.TabIndex = 36
        Me.hour_updown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'room_number_field
        '
        Me.room_number_field.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.room_number_field.DefaultText = ""
        Me.room_number_field.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.room_number_field.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.room_number_field.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.room_number_field.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.room_number_field.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.room_number_field.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.room_number_field.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.room_number_field.IconRight = CType(resources.GetObject("room_number_field.IconRight"), System.Drawing.Image)
        Me.room_number_field.IconRightSize = New System.Drawing.Size(10, 10)
        Me.room_number_field.Location = New System.Drawing.Point(432, 55)
        Me.room_number_field.Name = "room_number_field"
        Me.room_number_field.PlaceholderText = "Room Number"
        Me.room_number_field.SelectedText = ""
        Me.room_number_field.Size = New System.Drawing.Size(116, 28)
        Me.room_number_field.TabIndex = 35
        '
        'duration_field
        '
        Me.duration_field.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.duration_field.DefaultText = ""
        Me.duration_field.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.duration_field.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.duration_field.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.duration_field.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.duration_field.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.duration_field.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.duration_field.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.duration_field.IconRight = CType(resources.GetObject("duration_field.IconRight"), System.Drawing.Image)
        Me.duration_field.IconRightSize = New System.Drawing.Size(10, 10)
        Me.duration_field.Location = New System.Drawing.Point(432, 95)
        Me.duration_field.Name = "duration_field"
        Me.duration_field.PlaceholderText = "30 Minutes"
        Me.duration_field.SelectedText = ""
        Me.duration_field.Size = New System.Drawing.Size(116, 28)
        Me.duration_field.TabIndex = 34
        '
        'book_meeting_btn
        '
        Me.book_meeting_btn.BorderRadius = 5
        Me.book_meeting_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.book_meeting_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.book_meeting_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.book_meeting_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.book_meeting_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.book_meeting_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_meeting_btn.ForeColor = System.Drawing.Color.White
        Me.book_meeting_btn.Location = New System.Drawing.Point(455, 132)
        Me.book_meeting_btn.Name = "book_meeting_btn"
        Me.book_meeting_btn.Size = New System.Drawing.Size(75, 26)
        Me.book_meeting_btn.TabIndex = 33
        Me.book_meeting_btn.Text = "Book"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(47, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 26)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "This will book an event in Meeting Room for 30 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " minutes, today at 9:00am."
        '
        'desc_field
        '
        Me.desc_field.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.desc_field.DefaultText = ""
        Me.desc_field.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.desc_field.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.desc_field.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.desc_field.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.desc_field.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.desc_field.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.desc_field.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.desc_field.Location = New System.Drawing.Point(48, 55)
        Me.desc_field.Name = "desc_field"
        Me.desc_field.PlaceholderText = "What should we call this meeting?"
        Me.desc_field.SelectedText = ""
        Me.desc_field.Size = New System.Drawing.Size(378, 28)
        Me.desc_field.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 24)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Book a Meeting"
        '
        'pnlAvailability
        '
        Me.pnlAvailability.BackColor = System.Drawing.SystemColors.Control
        Me.pnlAvailability.BorderRadius = 15
        Me.pnlAvailability.Controls.Add(Me.booked_meetings_dtg)
        Me.pnlAvailability.Controls.Add(Me.Label18)
        Me.pnlAvailability.Controls.Add(Me.Guna2Panel7)
        Me.pnlAvailability.FillColor = System.Drawing.Color.White
        Me.pnlAvailability.Location = New System.Drawing.Point(780, 317)
        Me.pnlAvailability.Name = "pnlAvailability"
        Me.pnlAvailability.Size = New System.Drawing.Size(548, 403)
        Me.pnlAvailability.TabIndex = 18
        '
        'booked_meetings_dtg
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.booked_meetings_dtg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.booked_meetings_dtg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.booked_meetings_dtg.ColumnHeadersHeight = 20
        Me.booked_meetings_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.booked_meetings_dtg.DefaultCellStyle = DataGridViewCellStyle12
        Me.booked_meetings_dtg.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.booked_meetings_dtg.Location = New System.Drawing.Point(44, 56)
        Me.booked_meetings_dtg.Name = "booked_meetings_dtg"
        Me.booked_meetings_dtg.RowHeadersVisible = False
        Me.booked_meetings_dtg.Size = New System.Drawing.Size(482, 322)
        Me.booked_meetings_dtg.TabIndex = 56
        Me.booked_meetings_dtg.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.booked_meetings_dtg.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.booked_meetings_dtg.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.booked_meetings_dtg.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.booked_meetings_dtg.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.booked_meetings_dtg.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.booked_meetings_dtg.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.booked_meetings_dtg.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.booked_meetings_dtg.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.booked_meetings_dtg.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.booked_meetings_dtg.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.booked_meetings_dtg.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.booked_meetings_dtg.ThemeStyle.HeaderStyle.Height = 20
        Me.booked_meetings_dtg.ThemeStyle.ReadOnly = False
        Me.booked_meetings_dtg.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.booked_meetings_dtg.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.booked_meetings_dtg.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.booked_meetings_dtg.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.booked_meetings_dtg.ThemeStyle.RowsStyle.Height = 22
        Me.booked_meetings_dtg.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.booked_meetings_dtg.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(40, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(234, 24)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Meeting Rooms Availability"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel7.BorderRadius = 15
        Me.Guna2Panel7.CustomizableEdges.BottomRight = False
        Me.Guna2Panel7.CustomizableEdges.TopRight = False
        Me.Guna2Panel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Guna2Panel7.Location = New System.Drawing.Point(3, 0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(14, 403)
        Me.Guna2Panel7.TabIndex = 2
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.CustomizableEdges.BottomRight = False
        Me.Guna2Panel1.CustomizableEdges.TopRight = False
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(180, 110)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(17, 169)
        Me.Guna2Panel1.TabIndex = 0
        '
        'meeting_date_picker
        '
        Me.meeting_date_picker.Checked = True
        Me.meeting_date_picker.FillColor = System.Drawing.Color.White
        Me.meeting_date_picker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.meeting_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.meeting_date_picker.Location = New System.Drawing.Point(48, 95)
        Me.meeting_date_picker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.meeting_date_picker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.meeting_date_picker.Name = "meeting_date_picker"
        Me.meeting_date_picker.Size = New System.Drawing.Size(173, 28)
        Me.meeting_date_picker.TabIndex = 2
        Me.meeting_date_picker.Value = New Date(2025, 4, 27, 22, 35, 22, 0)
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel6.BorderRadius = 15
        Me.Guna2Panel6.CustomizableEdges.BottomRight = False
        Me.Guna2Panel6.CustomizableEdges.TopRight = False
        Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Guna2Panel6.Location = New System.Drawing.Point(180, 317)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(17, 403)
        Me.Guna2Panel6.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.Label28)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label25)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel9)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2Panel2.Controls.Add(Me.user_icon)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(147, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1219, 52)
        Me.Guna2Panel2.TabIndex = 63
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(1078, 27)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(81, 15)
        Me.Label28.TabIndex = 56
        Me.Label28.Text = "May 12, 2025"
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
        Me.Label3.Location = New System.Drawing.Point(1081, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "12:00 AM"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(60, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 18)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "User Name"
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel9.Location = New System.Drawing.Point(1165, 7)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(2, 40)
        Me.Guna2Panel9.TabIndex = 19
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.Animated = True
        Me.Guna2CircleButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
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
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(1177, 7)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(40, 39)
        Me.Guna2CircleButton1.TabIndex = 1
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
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.White
        Me.Guna2Panel4.Controls.Add(Me.borrow_books_btn)
        Me.Guna2Panel4.Controls.Add(Me.rooms_btn)
        Me.Guna2Panel4.Controls.Add(Me.logout_btn)
        Me.Guna2Panel4.Controls.Add(Me.meetingrm_btn)
        Me.Guna2Panel4.Controls.Add(Me.dashbrd_btn)
        Me.Guna2Panel4.Controls.Add(Me.Label5)
        Me.Guna2Panel4.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(147, 768)
        Me.Guna2Panel4.TabIndex = 64
        '
        'borrow_books_btn
        '
        Me.borrow_books_btn.Animated = True
        Me.borrow_books_btn.AnimatedGIF = True
        Me.borrow_books_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.borrow_books_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.borrow_books_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.borrow_books_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.borrow_books_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.borrow_books_btn.FillColor = System.Drawing.Color.Transparent
        Me.borrow_books_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrow_books_btn.ForeColor = System.Drawing.Color.Black
        Me.borrow_books_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.borrow_books_btn.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.borrow_books_btn.Image = CType(resources.GetObject("borrow_books_btn.Image"), System.Drawing.Image)
        Me.borrow_books_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.borrow_books_btn.ImageSize = New System.Drawing.Size(24, 24)
        Me.borrow_books_btn.Location = New System.Drawing.Point(3, 285)
        Me.borrow_books_btn.Name = "borrow_books_btn"
        Me.borrow_books_btn.Size = New System.Drawing.Size(141, 60)
        Me.borrow_books_btn.TabIndex = 15
        Me.borrow_books_btn.Text = "Borrow Books"
        Me.borrow_books_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.borrow_books_btn.TextOffset = New System.Drawing.Point(5, 0)
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
        Me.rooms_btn.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.rooms_btn.Image = CType(resources.GetObject("rooms_btn.Image"), System.Drawing.Image)
        Me.rooms_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rooms_btn.ImageSize = New System.Drawing.Size(24, 24)
        Me.rooms_btn.Location = New System.Drawing.Point(3, 351)
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
        Me.logout_btn.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
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
        Me.meetingrm_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.meetingrm_btn.ForeColor = System.Drawing.Color.Black
        Me.meetingrm_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.meetingrm_btn.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.meetingrm_btn.Image = CType(resources.GetObject("meetingrm_btn.Image"), System.Drawing.Image)
        Me.meetingrm_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.meetingrm_btn.ImageSize = New System.Drawing.Size(24, 24)
        Me.meetingrm_btn.Location = New System.Drawing.Point(3, 219)
        Me.meetingrm_btn.Name = "meetingrm_btn"
        Me.meetingrm_btn.Size = New System.Drawing.Size(141, 60)
        Me.meetingrm_btn.TabIndex = 12
        Me.meetingrm_btn.Text = "Books"
        Me.meetingrm_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.meetingrm_btn.TextOffset = New System.Drawing.Point(5, 0)
        '
        'dashbrd_btn
        '
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
        Me.dashbrd_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.dashbrd_btn.HoverState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "QCU Library"
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
        'upcoming_meeting_dtg
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.upcoming_meeting_dtg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.upcoming_meeting_dtg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.upcoming_meeting_dtg.ColumnHeadersHeight = 20
        Me.upcoming_meeting_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.upcoming_meeting_dtg.DefaultCellStyle = DataGridViewCellStyle9
        Me.upcoming_meeting_dtg.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upcoming_meeting_dtg.Location = New System.Drawing.Point(193, 317)
        Me.upcoming_meeting_dtg.Name = "upcoming_meeting_dtg"
        Me.upcoming_meeting_dtg.RowHeadersVisible = False
        Me.upcoming_meeting_dtg.Size = New System.Drawing.Size(543, 403)
        Me.upcoming_meeting_dtg.TabIndex = 65
        Me.upcoming_meeting_dtg.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.upcoming_meeting_dtg.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.upcoming_meeting_dtg.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.upcoming_meeting_dtg.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.upcoming_meeting_dtg.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.upcoming_meeting_dtg.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.upcoming_meeting_dtg.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upcoming_meeting_dtg.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upcoming_meeting_dtg.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.upcoming_meeting_dtg.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.upcoming_meeting_dtg.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.upcoming_meeting_dtg.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.upcoming_meeting_dtg.ThemeStyle.HeaderStyle.Height = 20
        Me.upcoming_meeting_dtg.ThemeStyle.ReadOnly = False
        Me.upcoming_meeting_dtg.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.upcoming_meeting_dtg.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.upcoming_meeting_dtg.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.upcoming_meeting_dtg.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.upcoming_meeting_dtg.ThemeStyle.RowsStyle.Height = 22
        Me.upcoming_meeting_dtg.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upcoming_meeting_dtg.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(199, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 24)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Meeting Rooms"
        '
        'UserMeetingRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.upcoming_meeting_dtg)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.pnlAvailability)
        Me.Controls.Add(Me.pnlBookMeeting)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserMeetingRoom"
        Me.Text = "UserMeetingRoom"
        Me.pnlBookMeeting.ResumeLayout(False)
        Me.pnlBookMeeting.PerformLayout()
        CType(Me.min_updown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hour_updown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAvailability.ResumeLayout(False)
        Me.pnlAvailability.PerformLayout()
        CType(Me.booked_meetings_dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upcoming_meeting_dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlBookMeeting As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlAvailability As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents meeting_date_picker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents desc_field As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents book_meeting_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents room_number_field As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents duration_field As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents user_icon As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents borrow_books_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents rooms_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logout_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents meetingrm_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashbrd_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents upcoming_meeting_dtg As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents booked_meetings_dtg As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents time_modes_cb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents min_updown As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents hour_updown As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label12 As Label
End Class
