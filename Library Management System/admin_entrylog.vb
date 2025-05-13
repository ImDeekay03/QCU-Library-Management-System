Imports Oracle.ManagedDataAccess.Client
Imports System.Data

Public Class admin_entrylog
    Dim windowSwitcher As New windowTools()

    ' Method to load entry log data into the DataGridView
    Private Sub LoadEntryLogData()
        Dim connection As OracleConnection = DatabaseConnection.GetConnection()

        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            Dim query As String = "SELECT * FROM EntryLog" ' Replace 'EntryLog' with your actual table name
            Dim command As New OracleCommand(query, connection)
            Dim adapter As New OracleDataAdapter(command)
            Dim dataTable As New DataTable()

            Try
                ' Fill the DataTable with data from the database
                adapter.Fill(dataTable)

                ' Bind the DataTable to the DataGridView
                dgvEntryLog.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error loading entry log data: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Failed to connect to the database.")
        End If
    End Sub

    ' Method to load history log data into the DataGridView
    Private Sub LoadHistoryLogData()
        Dim connection As OracleConnection = DatabaseConnection.GetConnection()

        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            Dim query As String = "SELECT * FROM HistoryLog" ' Replace 'HistoryLog' with your actual table name
            Dim command As New OracleCommand(query, connection)
            Dim adapter As New OracleDataAdapter(command)
            Dim dataTable As New DataTable()

            Try
                ' Fill the DataTable with data from the database
                adapter.Fill(dataTable)

                ' Bind the DataTable to the DataGridView
                dgvEntryLog.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error loading history log data: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Failed to connect to the database.")
        End If
    End Sub

    Private Sub dashbrd_btn_Click(sender As Object, e As EventArgs) Handles dashbrd_btn.Click
        ' Navigate to the admin dashboard
        windowSwitcher.windowSwitch(Me, New admin_dashboard())
    End Sub

    Private Sub borrowedreturned_btn_Click(sender As Object, e As EventArgs) Handles borrowedreturned_btn.Click
        ' Navigate to the borrowed/returned entry log (current page)
        windowSwitcher.windowSwitch(Me, New admin_entrylog())
    End Sub

    Private Sub Libbooks_btn_Click(sender As Object, e As EventArgs) Handles Libbooks_btn.Click
        ' Navigate to the library books management
        windowSwitcher.windowSwitch(Me, New admin_books())
    End Sub

    Private Sub meetingrm_btn_Click(sender As Object, e As EventArgs) Handles meetingrm_btn.Click
        ' Navigate to the meeting room management
        windowSwitcher.windowSwitch(Me, New admin_rooms())
    End Sub

    Private Sub rooms_btn_Click(sender As Object, e As EventArgs) Handles rooms_btn.Click
        ' Navigate to the general rooms management
        windowSwitcher.windowSwitch(Me, New admin_rooms())
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        ' Navigate to the login screen
        windowSwitcher.windowSwitch(Me, New admin_login())
    End Sub

    Private Sub admin_entrylog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start the timer to update time and date
        timeDateTimer.Start()

        ' Load the entry log data into the DataGridView
        LoadEntryLogData()
    End Sub

    ' Event handler for the Timer Tick event
    Private Sub timeDateTimer_Tick(sender As Object, e As EventArgs) Handles timeDateTimer.Tick
        ' Update the current time in Label32
        Label32.Text = DateTime.Now.ToString("hh:mm:ss tt") ' Format: 12-hour clock with AM/PM

        ' Update the current date in Label33
        Label33.Text = DateTime.Now.ToString("MMMM dd, yyyy") ' Format: Full month name, day, and year
    End Sub

    ' Event handler for btn_history click (Show History Log)
    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        ' Load the history log data into the DataGridView
        LoadHistoryLogData()
    End Sub

    Private Sub btn_realtime_Click(sender As Object, e As EventArgs) Handles btn_realtime.Click

    End Sub
End Class


