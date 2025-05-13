Imports Oracle.ManagedDataAccess.Client
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Guna.UI2.WinForms

Public Class admin_users
    Private Const ConnString As String =
        "User Id=system;Password=march2005;" &
        "Data Source=(DESCRIPTION=" &
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))" &
            "(CONNECT_DATA=(SID=xe)))"

    Private studentsTable As DataTable


    ' ───────────────────────────────────────────────────────────
    ' Handle any sidebar-button click and route to the right form
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
                ' Already here—refresh if you like:
                studentsTable = GetStudents()
                dgvUsers.DataSource = studentsTable

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
    ' Scan your sidebar panel and hook every Guna2Button to our click handler
    Private Sub InitializeSidebar()
        For Each ctrl As Control In panelSidebar.Controls
            If TypeOf ctrl Is Guna.UI2.WinForms.Guna2Button Then
                AddHandler DirectCast(ctrl, Guna.UI2.WinForms.Guna2Button).Click, AddressOf SidebarButton_Click
            End If
        Next
    End Sub


    ' I-restore ang minimize/maximize buttons
    Public Sub New()
        InitializeComponent()

        Me.ControlBox = True
        Me.MinimizeBox = True
        Me.MaximizeBox = True

    End Sub

    Function GetStudents() As DataTable
        Dim dt As New DataTable()
        Using conn As New OracleConnection(ConnString)
            Try
                conn.Open()
                Dim cmd As New OracleCommand(
                    "SELECT STUDENT_ID, " &
                    "TRIM(FIRST_NAME || ' ' || COALESCE(MIDDLE_NAME || ' ', '') || LAST_NAME) AS FULL_NAME, " &
                    "EMAIL " &
                    "FROM STUDENTS " &
                    "WHERE IS_ARCHIVED = 0", conn)

                Dim adapter As New OracleDataAdapter(cmd)
                adapter.Fill(dt)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        Return dt
    End Function

    Private Sub admin_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        studentsTable = GetStudents() ' I-store ang DataTable
        dgvUsers.DataSource = studentsTable ' Bind directly to DataTable

        ' ===== FORM SETTINGS =====
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.WindowState = FormWindowState.Maximized
        Me.MinimumSize = New Size(900, 800)



        ' ===== DATAGRIDVIEW STYLING =====
        With dgvUsers
            ' Basic Configuration
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AutoGenerateColumns = False
            .Columns.Clear()
            .BorderStyle = BorderStyle.FixedSingle
            .BackgroundColor = Color.White
            .GridColor = Color.FromArgb(224, 224, 224)

            ' Font Settings
            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .RowTemplate.Height = 40

            ' Header Styling
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersHeight = 40
            .EnableHeadersVisualStyles = False

            ' Cell Styling
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

            ' Selection Styling
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 230)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With


        ' ===== COLUMN SETUP WITH STYLING =====
        Dim colUserID As New DataGridViewTextBoxColumn With {
            .Name = "colUserID",
            .HeaderText = "USER ID",
            .DataPropertyName = "STUDENT_ID",
            .Width = 120,
            .DefaultCellStyle = New DataGridViewCellStyle With {
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        }

        Dim colName As New DataGridViewTextBoxColumn With {
            .Name = "colName",
            .HeaderText = "FULL NAME",
            .DataPropertyName = "FULL_NAME",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        }

        Dim colEmail As New DataGridViewTextBoxColumn With {
            .Name = "colEmail",
            .HeaderText = "EMAIL ADDRESS",
            .DataPropertyName = "EMAIL",
            .Width = 300
        }

        ' Action Column with Advanced Styling
        Dim imgCol As New DataGridViewImageColumn With {
            .Name = "colArchive",
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



        dgvUsers.Columns.AddRange({colUserID, colName, colEmail, imgCol})

        ' ===== LOAD DATA =====
        dgvUsers.DataSource = GetStudents()

        ' ===== BORDER STYLING =====
        AddHandler dgvUsers.Paint, Sub(senderPainter, ePainter)
                                       ControlPaint.DrawBorder(ePainter.Graphics,
                                           dgvUsers.ClientRectangle,
                                           Color.Silver, 1, ButtonBorderStyle.Solid,
                                           Color.Silver, 1, ButtonBorderStyle.Solid,
                                           Color.Silver, 1, ButtonBorderStyle.Solid,
                                           Color.Silver, 1, ButtonBorderStyle.Solid)
                                   End Sub

        ' ===== RESIZE HANDLING =====
        AddHandler Me.Resize, AddressOf Form_Resize
    End Sub

    ' ===== SEARCH FUNCTIONALITY =====
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            dgvUsers.DataSource = studentsTable
        Else
            Dim filteredView As New DataView(studentsTable)
            filteredView.RowFilter = $"STUDENT_ID LIKE '%{searchText}%' " &
                                   $"OR FULL_NAME LIKE '%{searchText}%' " &
                                   $"OR EMAIL LIKE '%{searchText}%'"
            dgvUsers.DataSource = filteredView
        End If
    End Sub

    Private Sub Form_Resize(sender As Object, e As EventArgs)
        ' Dynamic column adjustments
        dgvUsers.Columns("colUserID").Width = CInt(dgvUsers.Width * 0.15)
        dgvUsers.Columns("colEmail").Width = CInt(dgvUsers.Width * 0.25)
    End Sub

    Private Function ResizeImage(original As Image, width As Integer, height As Integer) As Bitmap
        Dim destImage As New Bitmap(width, height)
        Using graphics As Graphics = Graphics.FromImage(destImage)
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphics.DrawImage(original, New Rectangle(0, 0, width, height))
        End Using
        Return destImage
    End Function

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.ColumnIndex = dgvUsers.Columns("colArchive").Index AndAlso e.RowIndex >= 0 Then
            Dim studentId As String = dgvUsers.Rows(e.RowIndex).Cells("colUserID").Value.ToString()
            If MessageBox.Show($"Archive user {studentId}?", "Confirm Archive", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using conn As New OracleConnection(ConnString)
                    Try
                        conn.Open()
                        Dim cmd As New OracleCommand(
                            "UPDATE STUDENTS SET IS_ARCHIVED = 1 WHERE STUDENT_ID = :studentId", conn)
                        cmd.Parameters.Add("studentId", OracleDbType.Varchar2).Value = studentId
                        cmd.ExecuteNonQuery()
                        dgvUsers.DataSource = GetStudents()
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End Using
            End If
        End If
    End Sub
End Class