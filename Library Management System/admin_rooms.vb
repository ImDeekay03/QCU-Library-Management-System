Imports Oracle.ManagedDataAccess.Client
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Guna.UI2.WinForms

Public Class admin_rooms

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
                Dim log = New admin_entrylog()
                log.Show()
                Me.Hide()

            Case "btnUsers"
                Dim users = New admin_users()
                users.Show()
                Me.Hide()

            Case "btnBooks"
                Dim books = New admin_books()
                books.Show()
                Me.Hide()

            Case "btnRooms"
                ' Already here—optionally refresh rooms list
                Return

            Case "btnLogout"
                Me.Close()
                admin_login.Show()
        End Select
    End Sub

    ' ───────────────────────────────────────────────────────────
    ' Form Load: apply window settings & (later) load your rooms data
    Private Sub admin_rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ─── FORM SETTINGS ─────────────────────────────────────
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.WindowState = FormWindowState.Maximized
        Me.MinimumSize = New Size(900, 800)

        ' ─── DATAGRIDVIEW SETUP ────────────────────────────────
        ' (If you have a dgvRooms grid, you can configure it here.
        '  Just mirror the setup from admin_books and then bind:
        '
        '  Dim roomsTable = GetRooms()
        '  dgvRooms.DataSource = roomsTable
        '
        '  You’ll need to implement GetRooms() similar to GetBooks().)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

    End Sub

    ' ───────────────────────────────────────────────────────────
    ' (Optional) Example stub for your data-fetching function:
    ' Private Function GetRooms() As DataTable
    '     Dim dt As New DataTable()
    '     Using conn As New OracleConnection(ConnString)
    '         conn.Open()
    '         ' … fill dt with your SELECT … FROM adminrooms …
    '     End Using
    '     Return dt
    ' End Function

End Class
