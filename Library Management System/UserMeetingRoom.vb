Imports Oracle.ManagedDataAccess.Client
Public Class UserMeetingRoom
    Private connectionString As String = "User Id=system;Password=123456789;Data Source=localhost:1521/orcl"

    Private Sub UserMeetingRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        testing_mode(True)
        LoadData()
    End Sub

    Dim windowSwitcher As New windowTools()
    Private Sub dashbrd_btn_Click(sender As Object, e As EventArgs) Handles dashbrd_btn.Click
        windowSwitcher.windowSwitch(Me, New UserHomePage())
    End Sub
    Private Sub meetingrm_btn_Click(sender As Object, e As EventArgs) Handles meetingrm_btn.Click
        windowSwitcher.windowSwitch(Me, New UserBorrowedbooks())
    End Sub

    Private Sub borrow_books_btn_Click(sender As Object, e As EventArgs) Handles borrow_books_btn.Click
        windowSwitcher.windowSwitch(Me, New UserBorrowBooks())
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        windowSwitcher.windowSwitch(Me, New UserPopUp())
    End Sub

    Private Sub rooms_btn_Click(sender As Object, e As EventArgs) Handles rooms_btn.Click
        windowSwitcher.windowSwitch(Me, New UserMeetingRoom())
    End Sub

    Private Sub book_meeting_btn_Click(sender As Object, e As EventArgs) Handles book_meeting_btn.Click
        Using conn As New OracleConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO booked_meeting_rooms(meeting_room_no, description, 
                    schedule, meeting_end, duration) VALUES (:meeting_room_id, :description, 
                    TO_DATE(:schedule, 'MM/DD/YYYY HH12:MI AM'), :meeting_end,
                    :duration)"

                Using cmd As New OracleCommand(sql, conn)
                    cmd.Parameters.Add(New OracleParameter("meeting_room_no",
                                                           Integer.Parse(room_number_field.Text)))
                    cmd.Parameters.Add(New OracleParameter("description", desc_field.Text))
                    cmd.Parameters.Add(New OracleParameter("schedule", (meeting_date_picker.Value.ToShortDateString) & " " &
                                                           (hour_updown.Value.ToString & ":" &
                                                           min_updown.Value.ToString & " " &
                                                           time_modes_cb.SelectedText)))
                    cmd.Parameters.Add(New OracleParameter("meeting_end", format_meeting_end(hour_updown.Value,
                        min_updown.Value, duration_field.Text)))
                    cmd.Parameters.Add(New OracleParameter("duration", Integer.Parse(duration_field.Text)))

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data inserted successfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try

            LoadData()
        End Using
    End Sub

    Private Sub LoadData()
        ' SQL query to fetch data
        Dim mr_query As String = "SELECT * FROM meeting_rooms"
        Dim bmr_query As String = "SELECT * FROM booked_meeting_rooms"

        ' Create a connection and data adapter
        Using conn As New OracleConnection(connectionString)
            Try
                conn.Open()

                Using mr_adapter As New OracleDataAdapter(mr_query, conn),
                    bmr_adapter As New OracleDataAdapter(bmr_query, conn),
                    mr_table As New DataTable(),
                    bmr_table As New DataTable()

                    mr_adapter.Fill(mr_table)
                    bmr_adapter.Fill(bmr_table)

                    upcoming_meeting_dtg.DataSource = mr_table
                    booked_meetings_dtg.DataSource = bmr_table
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    'Private Function booking_validation(conn As OracleConnection, room_number As Integer, schedule As String, meeting_start As String, meeting_end As String)
    '    Dim sql = "SELECT room_number, schedule, meeting_end FROM booked_meeting_rooms 
    '        LEFT JOIN meeting_rooms ON booked_meeting_rooms.meeting_room_no = 
    '        meeting_rooms.room_number;"

    '    Using cmd As New OracleCommand(sql, conn)
    '        Using reader = cmd.ExecuteReader
    '            If (reader.Read()) Then
    '                Dim reserved_room_no = reader.GetInt32(0)
    '                Dim reserved_schedule = reader.GetDateTime(1).ToShortDateString()
    '                Dim reserved_time = reader.GetDateTime(1).ToShortTimeString()
    '                Dim reserved_meeting_end = reader.GetString(2)

    '                If (reserved_schedule = schedule) Then
    '                    If (meeting_start < reserved_time And meeting_end < reserved_time) Then
    '                        Return True
    '                    ElseIf (meeting_start > meeting_end) Then
    '                        Return True
    '                    End If

    '                    Return False
    '                End If
    '            End If
    '        End Using
    '    End Using
    'End Function

    'Private Sub booking_creation(room_number As Integer, description As String,
    '                             schedule As String, meeting_end As String, duration As Integer)

    '    Using conn As New OracleConnection(connectionString)
    '        Try
    '            booking_validation(conn, description, schedule, meeting_end)
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try
    '    End Using
    'End Sub

    Private Sub insert_booking()

    End Sub

    Private Function format_meeting_end(ts_hr As Decimal, ts_min As Decimal, duration As String)
        Dim te_hr = ts_hr
        Dim te_min = ts_min + Integer.Parse(duration)

        If (te_min >= 60) Then
            Dim min_rem = te_min Mod 60
            te_hr += (te_min - min_rem) / 60
            te_min = min_rem
        End If

        Dim te_hr_str = te_hr.ToString
        Dim te_min_str = te_min.ToString

        te_min_str = If(te_min_str.Length = 1, te_min_str.Insert(0, 0), te_min_str)

        Return te_hr_str & ":" & te_min_str & " " & time_modes_cb.SelectedItem
    End Function

    Private Sub testing_mode(set_testing As Boolean)
        If (set_testing = True) Then
            desc_field.Text = "Rope Inventory System"
            room_number_field.Text = "101"
            hour_updown.Value = 5
            min_updown.Value = 5
            time_modes_cb.SelectedIndex = 1
        End If
    End Sub
End Class