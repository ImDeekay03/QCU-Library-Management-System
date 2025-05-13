Imports Oracle.ManagedDataAccess.Client
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Guna.UI2.WinForms

Public Class admin_books
    Private Const ConnString As String =
        "User Id=system;Password=march2005;" &
        "Data Source=(DESCRIPTION=" &
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))" &
            "(CONNECT_DATA=(SID=xe)))"

    Private booksTable As DataTable

    ' ───────────────────────────────────────────────────────────
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
    ' Initialize Sidebar Controls
    Private Sub InitializeSidebar()
        For Each ctrl As Control In panelSidebar.Controls
            If TypeOf ctrl Is Guna2Button Then
                AddHandler DirectCast(ctrl, Guna2Button).Click, AddressOf SidebarButton_Click
            End If
        Next
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.ControlBox = True
        Me.MinimizeBox = True
        Me.MaximizeBox = True
    End Sub

    ' ───────────────────────────────────────────────────────────
    ' Database Operations
    Private Function GetBooks() As DataTable
        Dim dt As New DataTable()
        Using conn As New OracleConnection(ConnString)
            Try
                conn.Open()
                Dim cmd As New OracleCommand(
                    "SELECT book_id, book_title, type, language, availability " &
                    "FROM adminbooks " &
                    "WHERE is_archived = 0", conn) ' Only show non-archived books

                Dim adapter As New OracleDataAdapter(cmd)
                adapter.Fill(dt)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        Return dt
    End Function

    Private Sub admin_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeSidebar()
        booksTable = GetBooks()

        ' ===== FORM SETTINGS =====
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.WindowState = FormWindowState.Maximized
        Me.MinimumSize = New Size(900, 800)

        ' ===== DATAGRIDVIEW SETUP =====
        With dgvBooks
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AutoGenerateColumns = False
            .Columns.Clear()
            .BorderStyle = BorderStyle.FixedSingle
            .BackgroundColor = Color.White
            .GridColor = Color.FromArgb(224, 224, 224)
            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .RowTemplate.Height = 40
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersHeight = 40
            .EnableHeadersVisualStyles = False
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 230)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With

        ' ===== COLUMN DEFINITIONS =====
        Dim colBookID As New DataGridViewTextBoxColumn With {
            .Name = "colBookID",
            .HeaderText = "BOOK ID",
            .DataPropertyName = "BOOK_ID",
            .Width = 150,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        }

        Dim colTitle As New DataGridViewTextBoxColumn With {
            .Name = "colTitle",
            .HeaderText = "BOOK TITLE",
            .DataPropertyName = "BOOK_TITLE",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        }

        Dim colType As New DataGridViewTextBoxColumn With {
            .Name = "colType",
            .HeaderText = "TYPE",
            .DataPropertyName = "TYPE",
            .Width = 120
        }

        Dim colLanguage As New DataGridViewTextBoxColumn With {
            .Name = "colLanguage",
            .HeaderText = "LANGUAGE",
            .DataPropertyName = "LANGUAGE",
            .Width = 120
        }

        Dim colAvailability As New DataGridViewTextBoxColumn With {
            .Name = "colAvailability",
            .HeaderText = "STATUS",
            .DataPropertyName = "AVAILABILITY",
            .Width = 120,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        }

        ' Archive Action Column
        Dim colAction As New DataGridViewImageColumn With {
        .Name = "colAction",
        .HeaderText = "ACTION",
        .Image = ResizeImage(My.Resources.archive, 22, 22),
        .ImageLayout = DataGridViewImageCellLayout.Zoom,
        .Width = 110,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
        .DefaultCellStyle = New DataGridViewCellStyle With {
            .Padding = New Padding(5),
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        }
    }

        dgvBooks.Columns.AddRange({colBookID, colTitle, colType, colLanguage, colAvailability, colAction})

        ' ===== BORDER STYLING =====
        AddHandler dgvBooks.Paint, Sub(senderPainter, ePainter)
                                       ControlPaint.DrawBorder(ePainter.Graphics,
                                           dgvBooks.ClientRectangle,
                                           Color.Silver, 1, ButtonBorderStyle.Solid,
                                           Color.Silver, 1, ButtonBorderStyle.Solid,
                                           Color.Silver, 1, ButtonBorderStyle.Solid,
                                           Color.Silver, 1, ButtonBorderStyle.Solid)
                                   End Sub

        ' ===== SEARCH FUNCTIONALITY =====
        AddHandler txtSearch.TextChanged, AddressOf txtSearch_TextChanged

        dgvBooks.DataSource = booksTable

    End Sub

    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If dgvBooks.Columns(e.ColumnIndex).Name = "colAction" AndAlso e.RowIndex >= 0 Then
            Dim bookId = dgvBooks.Rows(e.RowIndex).Cells("colBookID").Value.ToString()

            If MessageBox.Show($"Archive book {bookId}?", "Confirm Archive", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ArchiveBook(bookId)
                booksTable = GetBooks()
                dgvBooks.DataSource = booksTable
            End If
        End If
    End Sub

    Private Sub ArchiveBook(bookId As String)
        Using conn As New OracleConnection(ConnString)
            Try
                conn.Open()
                Dim cmd As New OracleCommand(
                    "UPDATE adminbooks SET is_archived = 1 WHERE book_id = :bookId", conn)
                cmd.Parameters.Add("bookId", OracleDbType.Varchar2).Value = bookId
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error archiving book: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function ResizeImage(original As Image, width As Integer, height As Integer) As Bitmap
        Dim destImage As New Bitmap(width, height)
        Using graphics As Graphics = Graphics.FromImage(destImage)
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphics.DrawImage(original, New Rectangle(0, 0, width, height))
        End Using
        Return destImage
    End Function

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            dgvBooks.DataSource = booksTable
        Else
            Dim dv As New DataView(booksTable)
            dv.RowFilter = $"BOOK_ID LIKE '%{searchText}%' OR BOOK_TITLE LIKE '%{searchText}%' OR TYPE LIKE '%{searchText}%'"
            dgvBooks.DataSource = dv
        End If

    End Sub
End Class