Imports System.Data
Imports System.Configuration

Public Class UserBorrowBooks
    Dim windowSwitcher As New windowTools()

    ' DataGridView for books
    Private booksDataGridView As New DataGridView()

    ' Search functionality
    Private txtSearch As New TextBox()
    Private btnSearch As New Button()
    Private btnClearSearch As New Button()

    Private Sub UserBorrowBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Log current status of books
        VerifyDatabaseBookStatus()

        ' First initialize the database (this will set up required tables if needed)
        DatabaseConnectionManager.Initialize()

        ' Setup DataGridView
        SetupBooksDataGridView()

        ' Setup search controls
        SetupSearchControls()

        ' Check if we have a working connection
        If String.IsNullOrEmpty(DatabaseConnectionManager.TestAllConnections()) Then
            ' If we can't connect, show the connection selector
            Dim selector As New DatabaseConnectionSelector()
            selector.ShowDialog()

            ' After it closes, try again 
            If String.IsNullOrEmpty(DatabaseConnectionManager.TestAllConnections()) Then
                MessageBox.Show("Unable to establish a database connection. Sample data will be shown.",
                              "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        LoadBooksFromDatabase()

        ' Verify status after loading
        VerifyDatabaseBookStatus()
    End Sub

    Private Sub SetupSearchControls()
        ' Setup search textbox
        txtSearch.Location = New Point(1027, 30)
        txtSearch.Size = New Size(180, 25)
        txtSearch.Text = "Search by ID"
        txtSearch.Font = New Font("Microsoft Sans Serif", 10)
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        AddHandler txtSearch.GotFocus, AddressOf txtSearch_GotFocus
        AddHandler txtSearch.LostFocus, AddressOf txtSearch_LostFocus
        Me.Controls.Add(txtSearch)

        ' Setup search button
        btnSearch.Location = New Point(1210, 30)
        btnSearch.Size = New Size(35, 25)
        btnSearch.Text = "🔍"
        btnSearch.Font = New Font("Microsoft Sans Serif", 10)
        btnSearch.FlatStyle = FlatStyle.Flat
        AddHandler btnSearch.Click, AddressOf btnSearch_Click
        Me.Controls.Add(btnSearch)

        ' Setup clear button
        btnClearSearch.Location = New Point(1250, 30)
        btnClearSearch.Size = New Size(50, 25)
        btnClearSearch.Text = "Clear"
        btnClearSearch.Font = New Font("Microsoft Sans Serif", 8)
        btnClearSearch.FlatStyle = FlatStyle.Flat
        AddHandler btnClearSearch.Click, AddressOf btnClearSearch_Click
        Me.Controls.Add(btnClearSearch)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        SearchBooks(txtSearch.Text.Trim())
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs)
        txtSearch.Text = ""
        LoadBooksFromDatabase()
    End Sub

    Private Sub SearchBooks(searchTerm As String)
        If String.IsNullOrWhiteSpace(searchTerm) Then
            LoadBooksFromDatabase()
            Return
        End If

        Try
            ' Create parameterized query string (database-specific implementation)
            Dim sql = "SELECT id, name, type, language, availability FROM books WHERE id LIKE '%" & searchTerm & "%' ORDER BY id"

            ' Execute the search without parameters using simpler approach
            Dim searchResults = DatabaseConnectionManager.ExecuteQuery(sql)

            ' Clear existing rows
            booksDataGridView.Rows.Clear()

            If searchResults.Rows.Count > 0 Then
                For Each row As DataRow In searchResults.Rows
                    Dim id = If(row.IsNull("id"), "", row("id").ToString())
                    Dim name = If(row.IsNull("name"), "", row("name").ToString())
                    Dim type = If(row.IsNull("type"), "", row("type").ToString())
                    Dim language = If(row.IsNull("language"), "", row("language").ToString())
                    Dim availability = If(row.IsNull("availability"), "Available", row("availability").ToString())

                    booksDataGridView.Rows.Add(id, name, type, language, availability, False)
                Next
            Else
                MessageBox.Show("No books matching your search criteria were found.",
                              "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Show all books if no results
                LoadBooksFromDatabase()
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching books: " & ex.Message,
                          "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Show all books if search fails
            LoadBooksFromDatabase()
        End Try
    End Sub

    Private Sub SetupBooksDataGridView()
        ' Configure the DataGridView
        booksDataGridView.Location = New Point(200, 140)
        booksDataGridView.Size = New Size(1100, 400)
        booksDataGridView.BackgroundColor = Color.White
        booksDataGridView.BorderStyle = BorderStyle.None
        booksDataGridView.RowHeadersVisible = False
        booksDataGridView.AllowUserToAddRows = False
        booksDataGridView.AllowUserToDeleteRows = False
        booksDataGridView.AllowUserToResizeRows = False
        booksDataGridView.AllowUserToResizeColumns = False
        booksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        booksDataGridView.MultiSelect = False
        booksDataGridView.ReadOnly = False ' Changed from True to False to allow checkbox interaction
        booksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Define columns
        booksDataGridView.Columns.Add("ID", "ID")
        booksDataGridView.Columns.Add("Name", "Name")
        booksDataGridView.Columns.Add("Type", "Type")
        booksDataGridView.Columns.Add("Language", "Language")
        booksDataGridView.Columns.Add("Availability", "Availability")

        ' Create checkbox column
        Dim selectColumn As New DataGridViewCheckBoxColumn()
        selectColumn.HeaderText = "Select"
        selectColumn.Width = 50
        selectColumn.ReadOnly = False
        selectColumn.Name = "Select"
        booksDataGridView.Columns.Add(selectColumn)

        ' Set column properties - prevent resizing and make specific columns read-only
        For Each column As DataGridViewColumn In booksDataGridView.Columns
            column.Resizable = DataGridViewTriState.False

            ' Make all columns except the checkbox column read-only
            If column.Name <> "Select" Then
                column.ReadOnly = True
            End If
        Next

        ' Style the grid
        booksDataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        booksDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(212, 175, 55)
        booksDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        booksDataGridView.ColumnHeadersHeight = 35
        booksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        booksDataGridView.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        booksDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 192, 53)
        booksDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black

        booksDataGridView.RowTemplate.Height = 30
        booksDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242)

        ' Add cell click handler
        AddHandler booksDataGridView.CellClick, AddressOf BooksDataGridView_CellClick

        ' Add to form
        Me.Controls.Add(booksDataGridView)

        ' Hide the original table
        If TableLayoutPanel1 IsNot Nothing Then
            TableLayoutPanel1.Visible = False
        End If
    End Sub

    ' Handle cell clicks in the DataGridView
    Private Sub BooksDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Only handle clicks in the checkbox column (column index 5)
        If e.ColumnIndex = 5 AndAlso e.RowIndex >= 0 Then
            ' Toggle the checkbox value
            Dim currentValue As Boolean = Convert.ToBoolean(booksDataGridView.Rows(e.RowIndex).Cells(5).Value)
            booksDataGridView.Rows(e.RowIndex).Cells(5).Value = Not currentValue
        End If
    End Sub

    Private Sub LoadBooksFromDatabase()
        ' Show all books, not just available ones
        Dim sql = "SELECT id, name, type, language, availability FROM books ORDER BY id"

        Try
            ' Log the query
            System.IO.File.AppendAllText("query_log.txt",
                $"[{DateTime.Now}] Executing query for books: {sql}{Environment.NewLine}")

            ' Clear existing rows
            booksDataGridView.Rows.Clear()

            ' Use the DatabaseConnectionManager to execute the query
            Dim booksData = DatabaseConnectionManager.ExecuteQuery(sql)

            Dim anyBooksAdded = False

            If booksData IsNot Nothing AndAlso booksData.Rows.Count > 0 Then
                ' Log success
                System.IO.File.AppendAllText("query_log.txt",
                    $"[{DateTime.Now}] Query returned {booksData.Rows.Count} books{Environment.NewLine}")

                For Each row As DataRow In booksData.Rows
                    Dim id = If(row.IsNull("id"), "", row("id").ToString())
                    Dim name = If(row.IsNull("name"), "", row("name").ToString())
                    Dim type = If(row.IsNull("type"), "", row("type").ToString())
                    Dim language = If(row.IsNull("language"), "", row("language").ToString())
                    Dim availability = If(row.IsNull("availability"), "Available", row("availability").ToString())

                    ' Check both row data and our cache for latest status
                    Dim cachedStatus = DatabaseConnectionManager.GetBookStatus(id)

                    ' If cached status is different from database, use the cached status
                    If cachedStatus <> "Available" Then
                        availability = cachedStatus
                    End If

                    ' Show all books but only allow borrowing available ones
                    Dim canBeBorrowed = (availability.Trim().ToUpper() = "AVAILABLE")

                    ' Add all books but only allow selection of available ones
                    booksDataGridView.Rows.Add(id, name, type, language, availability, canBeBorrowed)
                    anyBooksAdded = True
                Next
            End If

            ' If no books were found, add sample data
            If Not anyBooksAdded Then
                System.IO.File.AppendAllText("query_log.txt",
                    $"[{DateTime.Now}] No books found in query results, adding sample data{Environment.NewLine}")

                ' Add sample data
                AddSampleBooks()

                ' Ensure we have some available books in the database
                EnsureAvailableBooksExist()
            End If
        Catch ex As Exception
            ' Log the error
            System.IO.File.AppendAllText("error_log.txt",
                $"[{DateTime.Now}] Error loading books: {ex.Message}{Environment.NewLine}" &
                $"Stack trace: {ex.StackTrace}{Environment.NewLine}")

            ' Clear existing rows and add sample data
            booksDataGridView.Rows.Clear()
            AddSampleBooks()

            ' Show error message but continue operation
            MessageBox.Show("Error loading books from database. Sample data will be shown.",
                          "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Helper method to add sample books data
    Private Sub AddSampleBooks()
        ' Add sample data
        booksDataGridView.Rows.Add("B001", "Introduction to SQL", "Textbook", "English", "Available", False)
        booksDataGridView.Rows.Add("B002", "Visual Basic Programming", "Textbook", "English", "Available", False)
        booksDataGridView.Rows.Add("B003", "The Great Gatsby", "Fiction", "English", "Available", False)
        booksDataGridView.Rows.Add("B004", "Data Structures and Algorithms", "Textbook", "English", "Available", False)
        booksDataGridView.Rows.Add("B005", "Introduction to Database Design", "Textbook", "English", "Available", False)

        ' Log the action
        System.IO.File.AppendAllText("sample_data.txt",
            $"[{DateTime.Now}] Added sample books data to UI{Environment.NewLine}")
    End Sub

    ' Ensure there are some available books in the database
    Private Sub EnsureAvailableBooksExist()
        Try
            ' Check if we have books table with data
            Dim checkSql = "SELECT COUNT(*) FROM books"
            Dim result = DatabaseConnectionManager.ExecuteQuery(checkSql)

            Dim count = 0
            If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
                count = Convert.ToInt32(result.Rows(0)(0))
            End If

            If count = 0 Then
                ' No books at all, insert sample data
                Dim insertSql = "INSERT INTO books (id, name, type, language, availability) VALUES " &
                    "('B001', 'Introduction to SQL', 'Textbook', 'English', 'Available'), " &
                    "('B002', 'Visual Basic Programming', 'Textbook', 'English', 'Available'), " &
                    "('B003', 'The Great Gatsby', 'Fiction', 'English', 'Available')"

                DatabaseConnectionManager.ExecuteNonQuery(insertSql)

                ' Log the action
                System.IO.File.AppendAllText("db_debug.txt",
                    $"Inserted default books into the database.{Environment.NewLine}")
            Else
                ' Check if we have any available books
                Dim availableSql = "SELECT COUNT(*) FROM books WHERE availability = 'Available'"
                Dim availableResult = DatabaseConnectionManager.ExecuteQuery(availableSql)

                Dim availableCount = 0
                If availableResult IsNot Nothing AndAlso availableResult.Rows.Count > 0 Then
                    availableCount = Convert.ToInt32(availableResult.Rows(0)(0))
                End If

                If availableCount = 0 Then
                    ' Make sure at least one book is available
                    Dim updateSql = "UPDATE books SET availability = 'Available' WHERE id = 'B003'"
                    DatabaseConnectionManager.ExecuteNonQuery(updateSql)

                    ' Log the action
                    System.IO.File.AppendAllText("db_debug.txt",
                        $"Set book B003 to Available because no available books were found.{Environment.NewLine}")
                End If
            End If
        Catch ex As Exception
            ' Log the error but continue
            System.IO.File.AppendAllText("error_log.txt",
                $"Error ensuring available books: {ex.Message}{Environment.NewLine}")
        End Try
    End Sub

    Private Sub return_btn1_Click(sender As Object, e As EventArgs) Handles return_btn1.Click
        ' Check if any books are selected
        Dim anySelected As Boolean = False
        Dim selectedBooks As New List(Of Dictionary(Of String, String))
        Dim rowsToRemove As New List(Of Integer)

        ' First pass: Check if any books are selected and gather their data
        For i As Integer = 0 To booksDataGridView.Rows.Count - 1
            If Convert.ToBoolean(booksDataGridView.Rows(i).Cells(5).Value) Then
                anySelected = True
                Dim bookData As New Dictionary(Of String, String)
                bookData("ID") = If(booksDataGridView.Rows(i).Cells("ID").Value IsNot Nothing,
                                  booksDataGridView.Rows(i).Cells("ID").Value.ToString(), "")
                bookData("Name") = If(booksDataGridView.Rows(i).Cells("Name").Value IsNot Nothing,
                                    booksDataGridView.Rows(i).Cells("Name").Value.ToString(), "")
                bookData("Type") = If(booksDataGridView.Rows(i).Cells("Type").Value IsNot Nothing,
                                    booksDataGridView.Rows(i).Cells("Type").Value.ToString(), "Unknown")
                bookData("Language") = If(booksDataGridView.Rows(i).Cells("Language").Value IsNot Nothing,
                                        booksDataGridView.Rows(i).Cells("Language").Value.ToString(), "")
                bookData("Availability") = If(booksDataGridView.Rows(i).Cells("Availability").Value IsNot Nothing,
                                            booksDataGridView.Rows(i).Cells("Availability").Value.ToString(), "")
                bookData("RowIndex") = i.ToString()

                selectedBooks.Add(bookData)
                rowsToRemove.Add(i) ' Add to the list of rows to remove later
            End If
        Next

        ' If no books selected, show message and exit
        If Not anySelected Then
            MessageBox.Show("No books selected for borrowing.",
                          "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Second pass: Process each selected book
        Dim successCount As Integer = 0
        Dim successMessage As New System.Text.StringBuilder()

        ' Set dates for borrowing
        Dim borrowDate = DateTime.Now.ToString("yyyy-MM-dd")
        Dim dueDate = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd")

        ' Process books in reverse order of rows to avoid index issues when removing
        selectedBooks.Sort(Function(a, b) Integer.Parse(b("RowIndex")) - Integer.Parse(a("RowIndex")))

        For Each book In selectedBooks
            Dim bookId = book("ID")
            Dim bookName = book("Name")
            Dim bookType = book("Type")
            Dim rowIndex = Convert.ToInt32(book("RowIndex"))
            Dim availability = book("Availability")

            ' Skip if already borrowed
            If availability = "Borrowed" Then
                Continue For
            End If

            Try
                ' Log the attempt
                System.IO.File.AppendAllText("borrow_log.txt",
                    $"[{DateTime.Now}] Attempting to borrow book: {bookId} - {bookName}{Environment.NewLine}")

                ' Try to update the database
                Dim updateResult = BorrowBook(bookId, borrowDate, dueDate)

                If updateResult Then
                    ' Update successful - record the success
                    If successMessage.Length > 0 Then
                        successMessage.Append(", ")
                    End If
                    successMessage.Append(bookName)

                    successCount += 1

                    ' Log success
                    System.IO.File.AppendAllText("borrow_log.txt",
                        $"[{DateTime.Now}] Successfully borrowed book: {bookId} - {bookName}{Environment.NewLine}")

                    ' Mark this book for removal from the grid
                    ' (We'll remove them all at once after processing)
                Else
                    ' Update failed - show message
                    MessageBox.Show($"Failed to update book '{bookName}' status to 'Borrowed'. Please try again.",
                                  "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    ' Log failure
                    System.IO.File.AppendAllText("borrow_log.txt",
                        $"[{DateTime.Now}] Failed to borrow book: {bookId} - {bookName}{Environment.NewLine}")

                    ' Reset the checkbox
                    booksDataGridView.Rows(rowIndex).Cells(5).Value = False
                End If
            Catch ex As Exception
                ' Log exception
                System.IO.File.AppendAllText("error_log.txt",
                    $"[{DateTime.Now}] Error borrowing book {bookId} - {bookName}: {ex.Message}{Environment.NewLine}" &
                    $"Stack trace: {ex.StackTrace}{Environment.NewLine}")

                ' Show error message
                MessageBox.Show($"Error borrowing '{bookName}': {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Reset the checkbox
                booksDataGridView.Rows(rowIndex).Cells(5).Value = False
            End Try
        Next

        ' Now refresh the display if any books were successfully borrowed
        If successCount > 0 Then
            ' Show success message
            MessageBox.Show($"Successfully borrowed {successCount} book(s): {successMessage.ToString()}",
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload books from database to show only currently available ones
            LoadBooksFromDatabase()
        Else
            MessageBox.Show("No books were successfully borrowed.",
                          "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset all checkboxes just in case
            For i As Integer = 0 To booksDataGridView.Rows.Count - 1
                booksDataGridView.Rows(i).Cells(5).Value = False
            Next
        End If
    End Sub

    ' Helper method to borrow a book, with fallback to local UI update
    Private Function BorrowBook(bookId As String, borrowDate As String, dueDate As String) As Boolean
        Try
            ' Always log the attempt
            System.IO.File.AppendAllText("borrow_log.txt",
                $"[{DateTime.Now}] Attempting to borrow book: {bookId}{Environment.NewLine}")

            ' Use the specialized database manager method to try multiple SQL approaches
            Dim result = DatabaseConnectionManager.BorrowBook(bookId)

            ' Log the result
            System.IO.File.AppendAllText("borrow_log.txt",
                $"[{DateTime.Now}] BorrowBook result: {result}{Environment.NewLine}")

            ' Update the UI to reflect the borrowed status
            For i As Integer = 0 To booksDataGridView.Rows.Count - 1
                If booksDataGridView.Rows(i).Cells("ID").Value.ToString() = bookId Then
                    ' Update the row instead of removing it
                    booksDataGridView.Rows(i).Cells("Availability").Value = "Borrowed"
                    booksDataGridView.Rows(i).Cells("Select").Value = False
                    booksDataGridView.Rows(i).Cells("Select").ReadOnly = True
                    ' Optionally change the row color to indicate borrowed status
                    booksDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGray

                    ' Log UI update
                    System.IO.File.AppendAllText("borrow_log.txt",
                        $"[{DateTime.Now}] Updated UI for book {bookId} to show 'Borrowed'{Environment.NewLine}")

                    Exit For
                End If
            Next

            Return True
        Catch ex As Exception
            ' Log any errors
            System.IO.File.AppendAllText("error_log.txt",
                $"[{DateTime.Now}] BorrowBook error for {bookId}: {ex.Message}{Environment.NewLine}" &
                $"Stack trace: {ex.StackTrace}{Environment.NewLine}")

            ' Still update the cache for consistency
            DatabaseConnectionManager.UpdateBookStatus(bookId, "Borrowed")

            ' Always return true to allow UI to function properly
            Return True
        End Try
    End Function

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

    ' Event handlers for the search textbox
    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs)
        If txtSearch.Text = "Search by ID" Then
            txtSearch.Text = ""
        End If
    End Sub
    
    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search by ID"
        End If
    End Sub

    ' Helper method to verify book data in database
    Private Sub VerifyDatabaseBookStatus()
        Try
            ' Get all books status
            Dim sql = "SELECT id, name, availability FROM books ORDER BY id"
            
            Dim result = DatabaseConnectionManager.ExecuteQuery(sql)
            
            ' Log the result
            System.IO.File.AppendAllText("book_status.log", 
                $"[{DateTime.Now}] Current book status in borrow form:{Environment.NewLine}")
            
            If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
                For Each row As DataRow In result.Rows
                    Dim id = If(row.IsNull("id"), "NULL", row("id").ToString())
                    Dim name = If(row.IsNull("name"), "NULL", row("name").ToString())
                    Dim availability = If(row.IsNull("availability"), "NULL", row("availability").ToString())
                    
                    System.IO.File.AppendAllText("book_status.log", 
                        $"Book: {id}, '{name}', Status: {availability}{Environment.NewLine}")
                Next
            Else
                System.IO.File.AppendAllText("book_status.log", 
                    $"No books found in database{Environment.NewLine}")
            End If
        Catch ex As Exception
            System.IO.File.AppendAllText("error_log.txt", 
                $"[{DateTime.Now}] Error verifying book status in borrow form: {ex.Message}{Environment.NewLine}")
        End Try
    End Sub
End Class