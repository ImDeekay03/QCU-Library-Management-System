Imports Oracle.ManagedDataAccess.Client
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Guna.UI2.WinForms

Public Class admin_entrylog

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
    ' Hook every Guna2Button in panelSidebar to the same click handler
    Private Sub InitializeSidebar()
        For Each ctrl As Control In panelSidebar.Controls
            If TypeOf ctrl Is Guna2Button Then
                AddHandler DirectCast(ctrl, Guna2Button).Click, AddressOf SidebarButton_Click
            End If
        Next
    End Sub

    ' ───────────────────────────────────────────────────────────
    ' Shared handler for all sidebar buttons
    Private Sub SidebarButton_Click(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Guna2Button)

        Select Case btn.Name
            Case "btnDashboard"
                Dim dash = New admin_dashboard()
                dash.Show()
                Me.Hide()

            Case "btnEntlog"
                ' Already here—optionally refresh your entry‐log grid
                Return

            Case "btnUsers"
                Dim users = New admin_users()
                users.Show()
                Me.Hide()

            Case "btnBooks"
                Dim books = New admin_books()
                books.Show()
                Me.Hide()

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
    ' Form Load: apply window settings & load your entry‐log data
    Private Sub admin_entrylog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ─── FORM SETTINGS ─────────────────────────────────────
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.WindowState = FormWindowState.Maximized
        Me.MinimumSize = New Size(900, 800)

        ' ─── ENTRY-LOG CONTENT ─────────────────────────────────
        ' TODO: configure your dgvEntryLog (if you have one) 
        '       and bind it to a DataTable fetched from your table:

        ' Dim logTable = GetEntryLog()
        ' dgvEntryLog.DataSource = logTable
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    ' ───────────────────────────────────────────────────────────
    ' Example stub for loading entry-log data
    ' Private Function GetEntryLog() As DataTable
    '     Dim dt As New DataTable()
    '     Using conn As New OracleConnection(ConnString)
    '         conn.Open()
    '         ' … SELECT * FROM admin_entrylog WHERE … …
    '     End Using
    '     Return dt
    ' End Function

End Class