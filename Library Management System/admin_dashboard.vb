Imports Oracle.ManagedDataAccess.Client
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Guna.UI2.WinForms

Public Class admin_dashboard

    Public Sub New()
        InitializeComponent()
        ' ─── Window controls ────────────────────────────────────
        Me.ControlBox = True
        Me.MinimizeBox = True
        Me.MaximizeBox = True

        ' ─── Wire up sidebar ────────────────────────────────────
        InitializeSidebar()
    End Sub

    ' ───────────────────────────────────────────────────────────
    ' Hook every Guna2Button in your panelSidebar to our handler
    Private Sub InitializeSidebar()
        For Each ctrl As Control In panelSidebar.Controls
            If TypeOf ctrl Is Guna2Button Then
                AddHandler DirectCast(ctrl, Guna2Button).Click, AddressOf SidebarButton_Click
            End If
        Next
    End Sub

    ' ───────────────────────────────────────────────────────────
    ' Shared handler for all sidebar buttons



    ' ───────────────────────────────────────────────────────────
    ' Form Load: apply window settings & (later) load dashboard data
    Private Sub admin_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ─── FORM SETTINGS ─────────────────────────────────────
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.WindowState = FormWindowState.Maximized
        Me.MinimumSize = New Size(900, 800)

        ' ─── DASHBOARD CONTENT ─────────────────────────────────
        ' TODO: Populate your summary widgets, charts, etc.
    End Sub

    ' Sidebar Navigation Handler
    Private Sub SidebarButton_Click(sender As Object, e As EventArgs) Handles _
    btnDashboard.Click, btnEntlog.Click, btnUsers.Click, btnBooks.Click, btnRooms.Click, btnLogout.Click

        Dim btn = DirectCast(sender, Guna2Button)

        Select Case btn.Name
            Case "btnDashboard"
                Dim dash = New admin_dashboard()
                dash.Show()
                Me.Hide()

            Case "btnEntlog"
                Dim log = New admin_entrylog()
                log.Show()
                Me.Hide()

            Case "btnUsers"
                Dim users = New admin_users()
                users.Show()
                Me.Hide()

            Case "btnBooks"
                ' Refresh data when staying on same form
                booksTable = GetBooks()
                dgvBooks.DataSource = booksTable

            Case "btnRooms"
                Dim rooms = New admin_rooms()
                rooms.Show()
                Me.Hide()

            Case "btnLogout"
                Me.Close()
                admin_login.Show()
        End Select
    End Sub



    ' ───────────────────────────────────────────────────────────
    ' Add any dashboard-specific methods/properties below,
    ' e.g. Private Sub LoadStats(), Private Sub RefreshCharts(), etc.

End Class
