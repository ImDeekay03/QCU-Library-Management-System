Imports Oracle.ManagedDataAccess.Client

Public Class AddBorrowingForm
    ' Event handler for the Save button click
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get the input values
        Dim bookId As String = txtBookID.Text
        Dim borrowerName As String = txtBorrowerName.Text
        Dim borrowDate As Date = dtpBorrowDate.Value
        Dim returnDate As Date = dtpReturnDate.Value

        ' Validate inputs
        If String.IsNullOrEmpty(bookId) OrElse String.IsNullOrEmpty(borrowerName) Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Save the borrowing details to the database
        Dim connection As OracleConnection = DatabaseConnection.GetConnection()

        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            Dim query As String = "INSERT INTO Borrowings (BookID, BorrowerName, BorrowDate, ReturnDate) VALUES (:BookID, :BorrowerName, :BorrowDate, :ReturnDate)"
            Dim command As New OracleCommand(query, connection)

            ' Add parameters to prevent SQL injection
            command.Parameters.Add(":BookID", bookId)
            command.Parameters.Add(":BorrowerName", borrowerName)
            command.Parameters.Add(":BorrowDate", borrowDate)
            command.Parameters.Add(":ReturnDate", returnDate)

            Try
                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Borrowing details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close() ' Close the form after saving
                Else
                    MessageBox.Show("Failed to add borrowing details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error saving borrowing details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Failed to connect to the database.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class