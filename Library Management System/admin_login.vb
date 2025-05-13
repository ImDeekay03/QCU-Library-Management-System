Imports Oracle.ManagedDataAccess.Client
Imports System.Data
Imports System.Drawing
Imports Guna.UI2.WinForms

Public Class admin_login
    Private Const ConnString As String =
        "User Id=system;Password=march2005;" &
        "Data Source=(DESCRIPTION=" &
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))" &
            "(CONNECT_DATA=(SID=xe)))"

    Public Sub New()
        ' ─── TURN OFF DPI SCALING ───────────────────────────────
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None

        ' ─── Initialize Form ───────────────────────────────────
        InitializeComponent()

        ' ─── Window settings ───────────────────────────────────
        Me.ControlBox = True
        Me.MinimizeBox = True
        Me.MaximizeBox = True
        Me.BackColor = Color.White
        Me.WindowState = FormWindowState.Maximized
        Me.MinimumSize = New Size(900, 800)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uname = txtUsername.Text.Trim()
        Dim pwd = txtPassword.Text

        If String.IsNullOrEmpty(uname) OrElse String.IsNullOrEmpty(pwd) Then
            MessageBox.Show("Please enter both username and password.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New OracleConnection(ConnString)
            Try
                conn.Open()
                Using cmd As New OracleCommand(
                        "SELECT ADMIN_ID, FIRST_NAME, LAST_NAME " &
                        "FROM admin " &
                        "WHERE USERNAME = :u AND PASSWORD = :p", conn)
                    cmd.Parameters.Add("u", OracleDbType.Varchar2).Value = uname
                    cmd.Parameters.Add("p", OracleDbType.Varchar2).Value = pwd

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Successful login
                            Dim firstName = reader.GetString(1)
                            Dim lastName = reader.GetString(2)

                            ' Show dashboard
                            Dim dash = New admin_dashboard()
                            dash.Text = $"Welcome, {firstName} {lastName}"
                            dash.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
