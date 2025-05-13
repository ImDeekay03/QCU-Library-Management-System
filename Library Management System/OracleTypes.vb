Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Transactions

''' <summary>
''' Oracle data types enum for use when the original Oracle types aren't available
''' </summary>
Public Enum OracleDbType
    BFile = 101
    Blob = 102
    [Byte] = 103
    [Char] = 104
    Clob = 105
    [Date] = 106
    [Decimal] = 107
    [Double] = 108
    [Long] = 109
    LongRaw = 110
    Int16 = 111
    Int32 = 112
    Int64 = 113
    IntervalDS = 114
    IntervalYM = 115
    NClob = 116
    NChar = 117
    NVarchar2 = 119
    Raw = 120
    RefCursor = 121
    [Single] = 122
    TimeStamp = 123
    TimeStampLTZ = 124
    TimeStampTZ = 125
    Varchar2 = 126
    XmlType = 127
    BinaryDouble = 132
    BinaryFloat = 133
    [Boolean] = 134
End Enum

''' <summary>
''' Oracle compatibility namespace with basic classes
''' </summary>
Namespace Oracle.ManagedDataAccess.Client
    ''' <summary>
    ''' Compatibility class for OracleConnection when the original isn't available
    ''' </summary>
    Public Class OracleConnection
        Inherits DbConnection

        Private _connectionString As String
        
        ' Book status cache to keep track of book availability across the application
        Public Shared BookStatusCache As New Dictionary(Of String, String)
        
        Public Sub New()
        End Sub
        
        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub
        
        Public Overrides Property ConnectionString() As String
            Get
                Return _connectionString
            End Get
            Set(value As String)
                _connectionString = value
            End Set
        End Property
        
        Public Overrides ReadOnly Property State As ConnectionState
            Get
                Return ConnectionState.Closed
            End Get
        End Property
        
        Public Overrides ReadOnly Property Database As String
            Get
                Return "OracleDB"
            End Get
        End Property
        
        Public Overrides ReadOnly Property DataSource As String
            Get
                Return "Oracle"
            End Get
        End Property
        
        Public Overrides ReadOnly Property ServerVersion As String
            Get
                Return "Compatibility Layer"
            End Get
        End Property
        
        Protected Overrides Function CreateDbCommand() As DbCommand
            Return New OracleCommand()
        End Function
        
        Public Overrides Sub Open()
            ' Does nothing in compatibility layer
        End Sub
        
        Public Overrides Sub Close()
            ' Does nothing in compatibility layer
        End Sub
        
        Public Overrides Sub ChangeDatabase(databaseName As String)
            ' Does nothing in compatibility layer
        End Sub

        ' Additional required overrides for DbConnection
        Protected Overrides Sub Dispose(disposing As Boolean)
            MyBase.Dispose(disposing)
        End Sub

        ' Match the abstract DbConnection signature exactly:
        Protected Overrides Function BeginDbTransaction( _
            isolationLevel As System.Data.IsolationLevel _
        ) As DbTransaction
            ' Compatibility stub—no real transaction support
            Return Nothing
        End Function
        
        ' Remove or correct this—DbConnection.EnlistTransaction is a Sub, not a Function:
        Public Overrides Sub EnlistTransaction( _
            transaction As System.Transactions.Transaction _
        )
            ' No-op in compatibility layer
        End Sub

        Public Overrides ReadOnly Property ConnectionTimeout As Integer
            Get
                Return 0
            End Get
        End Property
    End Class
    
    ''' <summary>
    ''' Compatibility class for OracleCommand
    ''' </summary>
    Public Class OracleCommand
        Inherits DbCommand
        
        Private _connection As OracleConnection
        Private _commandText As String
        Private _parameters As New OracleParameterCollection()
        Private _transaction As DbTransaction
        
        Public Sub New()
        End Sub
        
        Public Sub New(commandText As String)
            _commandText = commandText
        End Sub
        
        Public Sub New(commandText As String, connection As OracleConnection)
            _commandText = commandText
            _connection = connection
        End Sub
        
        ' --------------------------------------------------------------------
        ' Fulfill DbCommand's remaining MustOverride members
        ' --------------------------------------------------------------------
        Protected Overrides Function ExecuteDbDataReader( _
            behavior As CommandBehavior _
        ) As DbDataReader
            Return Me.ExecuteReader()
        End Function
        
        Public Overrides Property DesignTimeVisible As Boolean
            Get
                Return False
            End Get
            Set(value As Boolean)
                ' No-op
            End Set
        End Property

        Public Overrides Property CommandText As String
            Get
                Return _commandText
            End Get
            Set(value As String)
                _commandText = value
            End Set
        End Property
        
        Public Shadows Property Connection As DbConnection
            Get
                Return _connection
            End Get
            Set(value As DbConnection)
                _connection = DirectCast(value, OracleConnection)
            End Set
        End Property
        
        Public Shadows ReadOnly Property Parameters As DbParameterCollection
            Get
                Return _parameters
            End Get
        End Property
        
        Public Overrides Property CommandTimeout As Integer
            Get
                Return 30
            End Get
            Set(value As Integer)
                ' Does nothing in compatibility layer
            End Set
        End Property
        
        Public Overrides Property CommandType As CommandType
            Get
                Return CommandType.Text
            End Get
            Set(value As CommandType)
                ' Does nothing in compatibility layer
            End Set
        End Property
        
        Protected Overrides ReadOnly Property DbParameterCollection As DbParameterCollection
            Get
                Return _parameters
            End Get
        End Property
        
        Protected Overrides Property DbConnection As DbConnection
            Get
                Return _connection
            End Get
            Set(value As DbConnection)
                _connection = DirectCast(value, OracleConnection)
            End Set
        End Property
        
        Protected Overrides Property DbTransaction As DbTransaction
            Get
                Return _transaction
            End Get
            Set(value As DbTransaction)
                _transaction = value
            End Set
        End Property
        
        Public Overrides Property UpdatedRowSource As UpdateRowSource
            Get
                Return UpdateRowSource.None
            End Get
            Set(value As UpdateRowSource)
                ' Does nothing in compatibility layer
            End Set
        End Property
        
        Public Shadows Function ExecuteReader() As DbDataReader
            ' Log execution
            Dim logPath = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            IO.File.AppendAllText(IO.Path.Combine(logPath, "oracle_exec.log"), 
                $"[{DateTime.Now}] ExecuteReader called: {_commandText}{Environment.NewLine}")
            
            ' Return specialized reader with the SQL command
            Return New OracleDataReader(_commandText)
        End Function
        
        Public Overrides Function ExecuteNonQuery() As Integer
            ' Always return 1 to indicate a successful operation for our compatibility layer
            ' This ensures fallback functionality works when database connection fails
            System.IO.File.AppendAllText("oracle_exec.log", 
                $"[{DateTime.Now}] Compatibility layer ExecuteNonQuery called, returning success (1){Environment.NewLine}")
                
            Return 1
        End Function
        
        Public Overrides Function ExecuteScalar() As Object
            Return Nothing
        End Function
        
        Public Overrides Sub Cancel()
            ' Does nothing in compatibility layer
        End Sub
        
        Protected Overrides Function CreateDbParameter() As DbParameter
            Return New OracleParameter()
        End Function
        
        Protected Overrides Sub Dispose(disposing As Boolean)
            MyBase.Dispose(disposing)
        End Sub
        
        Public Overrides Sub Prepare()
            ' Does nothing in compatibility layer
        End Sub
    End Class
    
    ''' <summary>
    ''' Compatibility class for OracleParameter
    ''' </summary>
    Public Class OracleParameter
        Inherits DbParameter
        
        Private _parameterName As String
        Private _value As Object
        Private _dbType As OracleDbType = OracleDbType.Varchar2
        Private _sourceColumn As String = String.Empty
        Private _sourceColumnNullMapping As Boolean = False
        Private _sourceVersion As DataRowVersion = DataRowVersion.Current
        
        Public Sub New()
        End Sub
        
        Public Sub New(parameterName As String, oracleDbType As OracleDbType)
            _parameterName = parameterName
            _dbType = oracleDbType
        End Sub
        
        Public Sub New(parameterName As String, value As Object)
            _parameterName = parameterName
            _value = value
        End Sub
        
        Public Property OracleDbType As OracleDbType
            Get
                Return _dbType
            End Get
            Set(value As OracleDbType)
                _dbType = value
            End Set
        End Property
        
        Public Overrides Property ParameterName As String
            Get
                Return _parameterName
            End Get
            Set(value As String)
                _parameterName = value
            End Set
        End Property
        
        Public Overrides Property Value As Object
            Get
                Return _value
            End Get
            Set(value As Object)
                _value = value
            End Set
        End Property
        
        Public Overrides Property DbType As DbType
            Get
                Return DbType.String
            End Get
            Set(value As DbType)
                ' Does nothing in compatibility layer
            End Set
        End Property
        
        Public Overrides Property Direction As ParameterDirection
            Get
                Return ParameterDirection.Input
            End Get
            Set(value As ParameterDirection)
                ' Does nothing in compatibility layer
            End Set
        End Property
        
        Public Overrides Property IsNullable As Boolean
            Get
                Return False
            End Get
            Set(value As Boolean)
                ' Does nothing in compatibility layer
            End Set
        End Property
        
        Public Overrides Property SourceColumn As String
            Get
                Return _sourceColumn
            End Get
            Set(value As String)
                _sourceColumn = value
            End Set
        End Property
        
        Public Overrides Property SourceColumnNullMapping As Boolean
            Get
                Return _sourceColumnNullMapping
            End Get
            Set(value As Boolean)
                _sourceColumnNullMapping = value
            End Set
        End Property
        
        Public Overrides Property Size As Integer
            Get
                Return 0
            End Get
            Set(value As Integer)
                ' Does nothing in compatibility layer
            End Set
        End Property

        Public Overrides Property SourceVersion As DataRowVersion
            Get
                Return _sourceVersion
            End Get
            Set(value As DataRowVersion)
                _sourceVersion = value
            End Set
        End Property

        Public Overrides Sub ResetDbType()
            ' Does nothing in compatibility layer
        End Sub
    End Class
    
    ''' <summary>
    ''' Compatibility class for OracleParameterCollection
    ''' </summary>
    Public Class OracleParameterCollection
        Inherits DbParameterCollection
        
        Private _parameters As New List(Of OracleParameter)()
        
        Public Overrides ReadOnly Property Count As Integer
            Get
                Return _parameters.Count
            End Get
        End Property
        
        Public Overrides ReadOnly Property SyncRoot As Object
            Get
                Return Me
            End Get
        End Property
        
        Public Overrides Function Add(value As Object) As Integer
            Dim param As OracleParameter = DirectCast(value, OracleParameter)
            _parameters.Add(param)
            Return _parameters.Count - 1
        End Function
        
        Public Overrides Sub AddRange(values As Array)
            For Each value As Object In values
                Add(value)
            Next
        End Sub
        
        Public Overrides Sub Clear()
            _parameters.Clear()
        End Sub
        
        Public Overrides Function Contains(value As Object) As Boolean
            Return _parameters.Contains(DirectCast(value, OracleParameter))
        End Function
        
        Public Overrides Function Contains(value As String) As Boolean
            Return _parameters.Any(Function(p) p.ParameterName = value)
        End Function
        
        Public Overrides Sub CopyTo(array As Array, index As Integer)
            For i As Integer = 0 To _parameters.Count - 1
                array.SetValue(_parameters(i), index + i)
            Next
        End Sub
        
        Public Overrides Function GetEnumerator() As System.Collections.IEnumerator
            Return _parameters.GetEnumerator()
        End Function
        
        Public Overrides Function IndexOf(value As Object) As Integer
            Return _parameters.IndexOf(DirectCast(value, OracleParameter))
        End Function
        
        Public Overrides Function IndexOf(parameterName As String) As Integer
            For i As Integer = 0 To _parameters.Count - 1
                If _parameters(i).ParameterName = parameterName Then
                    Return i
                End If
            Next
            Return -1
        End Function
        
        Public Overrides Sub Insert(index As Integer, value As Object)
            _parameters.Insert(index, DirectCast(value, OracleParameter))
        End Sub
        
        Public Overrides Sub Remove(value As Object)
            _parameters.Remove(DirectCast(value, OracleParameter))
        End Sub
        
        Public Overrides Sub RemoveAt(index As Integer)
            _parameters.RemoveAt(index)
        End Sub
        
        Public Overrides Sub RemoveAt(parameterName As String)
            Dim index As Integer = IndexOf(parameterName)
            If index >= 0 Then
                _parameters.RemoveAt(index)
            End If
        End Sub
        
        Protected Overrides Function GetParameter(index As Integer) As DbParameter
            Return _parameters(index)
        End Function
        
        Protected Overrides Sub SetParameter(index As Integer, value As DbParameter)
            _parameters(index) = DirectCast(value, OracleParameter)
        End Sub
        
        Protected Overrides Function GetParameter(parameterName As String) As DbParameter
            Dim index As Integer = IndexOf(parameterName)
            If index >= 0 Then
                Return _parameters(index)
            End If
            Return Nothing
        End Function
        
        Protected Overrides Sub SetParameter(parameterName As String, value As DbParameter)
            Dim index As Integer = IndexOf(parameterName)
            If index >= 0 Then
                _parameters(index) = DirectCast(value, OracleParameter)
            End If
        End Sub
    End Class
    
    ''' <summary>
    ''' Compatibility class for OracleDataReader
    ''' </summary>
    Public Class OracleDataReader
        Inherits DbDataReader
        
        Private _data As New DataTable()
        Private _currentRow As Integer = -1
        Private _closed As Boolean = False
        
        Public Sub New()
            ' Create sample data for the compatibility layer
            _data.Columns.Add("id", GetType(String))
            _data.Columns.Add("name", GetType(String))
            _data.Columns.Add("type", GetType(String))
            _data.Columns.Add("language", GetType(String))
            _data.Columns.Add("availability", GetType(String))
            _data.Columns.Add("borrow_date", GetType(String))
            _data.Columns.Add("due_date", GetType(String))
            _data.Columns.Add("return_date", GetType(String))
            
            ' Check our status cache for sample data
            CreateSampleData()
        End Sub
        
        ' Specialized constructor for query result simulation
        Public Sub New(sql As String)
            ' Initialize basic table structure
            _data.Columns.Add("id", GetType(String))
            _data.Columns.Add("name", GetType(String))
            _data.Columns.Add("type", GetType(String))
            _data.Columns.Add("language", GetType(String))
            _data.Columns.Add("availability", GetType(String))
            _data.Columns.Add("borrow_date", GetType(String))
            _data.Columns.Add("due_date", GetType(String))
            _data.Columns.Add("return_date", GetType(String))
            
            ' Populate data based on the query
            Try
                Dim queryType As String = "default"
                
                ' Log the query for debugging
                Dim logPath = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
                IO.File.AppendAllText(IO.Path.Combine(logPath, "oracle_reader.log"), 
                    $"[{DateTime.Now}] Query: {sql}{Environment.NewLine}")
                
                ' Create customized sample data
                If sql.ToUpper().Contains("WHERE AVAILABILITY = 'BORROWED'") Then
                    queryType = "borrowed"
                ElseIf sql.ToUpper().Contains("WHERE AVAILABILITY = 'AVAILABLE'") Then
                    queryType = "available"
                ElseIf sql.ToUpper().Contains("WHERE AVAILABILITY = 'RETURNED'") Then
                    queryType = "returned"
                ElseIf sql.ToUpper().Contains("SELECT AVAILABILITY FROM BOOKS WHERE ID =") Then
                    queryType = "status"
                    
                    ' Extract the book ID from the query
                    Dim idStart = sql.LastIndexOf("'") - 4
                    Dim idEnd = sql.LastIndexOf("'")
                    
                    If idStart >= 0 And idEnd > idStart Then
                        Dim bookId = sql.Substring(idStart, idEnd - idStart).Trim().TrimStart("'"c).TrimEnd("'"c)
                        
                        ' Get the status from our cache
                        Dim status = If(Oracle.ManagedDataAccess.Client.OracleConnection.BookStatusCache.ContainsKey(bookId),
                                      Oracle.ManagedDataAccess.Client.OracleConnection.BookStatusCache(bookId),
                                      "Available")
                                      
                        ' Just return the status column as requested
                        _data.Columns.Clear()
                        _data.Columns.Add("availability", GetType(String))
                        _data.Rows.Add(status)
                        
                        ' Log what we're returning
                        IO.File.AppendAllText(IO.Path.Combine(logPath, "oracle_reader.log"), 
                            $"[{DateTime.Now}] Status query for book {bookId}: Returning '{status}'{Environment.NewLine}")
                            
                        Return
                    End If
                End If
                
                ' Log the query type we determined
                IO.File.AppendAllText(IO.Path.Combine(logPath, "oracle_reader.log"), 
                    $"[{DateTime.Now}] Query type: {queryType}{Environment.NewLine}")
                
                ' Create appropriate sample data
                CreateSampleData(queryType)
                
            Catch ex As Exception
                ' Log the error
                Dim logPath = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
                IO.File.AppendAllText(IO.Path.Combine(logPath, "oracle_reader_error.log"), 
                    $"[{DateTime.Now}] Error creating reader for query: {ex.Message}{Environment.NewLine}" & 
                    $"SQL: {sql}{Environment.NewLine}" &
                    $"Stack trace: {ex.StackTrace}{Environment.NewLine}")
                    
                ' Fall back to default sample data
                CreateSampleData()
            End Try
        End Sub
        
        ' Status cache for disconnected operation
        Private Shared _statusCache As New Dictionary(Of String, String)
        
        ' Create sample data that syncs with our cached book statuses
        Private Sub CreateSampleData(Optional queryType As String = "default")
            Try
                Dim today = DateTime.Now.ToString("yyyy-MM-dd")
                Dim dueDate = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd")
                Dim returnDate = DateTime.Now.AddDays(-3).ToString("yyyy-MM-dd")
                
                ' Create sample books
                Dim bookData As New Dictionary(Of String, Dictionary(Of String, String))
                
                ' Book 1
                Dim book1 = New Dictionary(Of String, String)
                book1.Add("id", "B001")
                book1.Add("name", "Introduction to SQL")
                book1.Add("type", "Textbook")
                book1.Add("language", "English")
                book1.Add("borrow_date", today)
                book1.Add("due_date", dueDate)
                book1.Add("return_date", "")
                
                ' Book 2
                Dim book2 = New Dictionary(Of String, String)
                book2.Add("id", "B002")
                book2.Add("name", "Visual Basic Programming")
                book2.Add("type", "Textbook")
                book2.Add("language", "English")
                book2.Add("borrow_date", today)
                book2.Add("due_date", dueDate)
                book2.Add("return_date", "")
                
                ' Book 3
                Dim book3 = New Dictionary(Of String, String)
                book3.Add("id", "B003")
                book3.Add("name", "The Great Gatsby")
                book3.Add("type", "Fiction")
                book3.Add("language", "English")
                book3.Add("borrow_date", today)
                book3.Add("due_date", dueDate)
                book3.Add("return_date", "")
                
                ' Get statuses from cache if available
                book1("availability") = If(Oracle.ManagedDataAccess.Client.OracleConnection.BookStatusCache.ContainsKey("B001"),
                                         Oracle.ManagedDataAccess.Client.OracleConnection.BookStatusCache("B001"),
                                         "Available")
                book2("availability") = If(Oracle.ManagedDataAccess.Client.OracleConnection.BookStatusCache.ContainsKey("B002"),
                                         Oracle.ManagedDataAccess.Client.OracleConnection.BookStatusCache("B002"),
                                         "Available")
                book3("availability") = If(Oracle.ManagedDataAccess.Client.OracleConnection.BookStatusCache.ContainsKey("B003"),
                                         Oracle.ManagedDataAccess.Client.OracleConnection.BookStatusCache("B003"),
                                         "Available")
                
                ' Store all books
                bookData.Add("B001", book1)
                bookData.Add("B002", book2)
                bookData.Add("B003", book3)
                
                ' Clear existing rows
                _data.Rows.Clear()
                
                ' Add rows based on queryType
                Select Case queryType
                    Case "borrowed"
                        ' Only add borrowed books
                        For Each book In bookData.Values
                            If book("availability") = "Borrowed" Then
                                _data.Rows.Add(book("id"), book("name"), book("type"), book("language"),
                                             book("availability"), book("borrow_date"), book("due_date"), DBNull.Value)
                            End If
                        Next
                        
                        ' If no borrowed books found, add at least one for testing
                        If _data.Rows.Count = 0 Then
                            _data.Rows.Add("B001", "Introduction to SQL", "Textbook", "English",
                                         "Borrowed", today, dueDate, DBNull.Value)
                        End If
                        
                    Case "available"
                        ' Only add available books
                        For Each book In bookData.Values
                            If book("availability") = "Available" Then
                                _data.Rows.Add(book("id"), book("name"), book("type"), book("language"),
                                             book("availability"), DBNull.Value, DBNull.Value, DBNull.Value)
                            End If
                        Next
                        
                        ' If no available books found, add at least one for testing
                        If _data.Rows.Count = 0 Then
                            _data.Rows.Add("B003", "The Great Gatsby", "Fiction", "English",
                                         "Available", DBNull.Value, DBNull.Value, DBNull.Value)
                        End If
                        
                    Case "returned"
                        ' Add fixed sample returned books
                        _data.Rows.Add("B004", "Data Structures and Algorithms", "Textbook", "English",
                                     "Returned", today, dueDate, returnDate)
                        _data.Rows.Add("B005", "Introduction to Database Design", "Textbook", "English",
                                     "Returned", today, dueDate, returnDate)
                        
                    Case Else ' Default or unrecognized
                        ' Add all books from the cache with their current status
                        For Each book In bookData.Values
                            _data.Rows.Add(book("id"), book("name"), book("type"), book("language"),
                                         book("availability"), book("borrow_date"), book("due_date"), DBNull.Value)
                        Next
                End Select
                
                ' If still no rows, add default data
                If _data.Rows.Count = 0 Then
                    _data.Rows.Add("B001", "Introduction to SQL", "Textbook", "English", "Available", DBNull.Value, DBNull.Value, DBNull.Value)
                    _data.Rows.Add("B002", "Visual Basic Programming", "Textbook", "English", "Available", DBNull.Value, DBNull.Value, DBNull.Value)
                    _data.Rows.Add("B003", "The Great Gatsby", "Fiction", "English", "Available", DBNull.Value, DBNull.Value, DBNull.Value)
                End If
                
                ' Log what we're returning
                Dim logPath = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
                IO.File.AppendAllText(IO.Path.Combine(logPath, "oracle_reader.log"), 
                    $"[{DateTime.Now}] Created sample data for query type '{queryType}' with {_data.Rows.Count} rows{Environment.NewLine}")
                
            Catch ex As Exception
                ' Log error
                Dim logPath = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
                IO.File.AppendAllText(IO.Path.Combine(logPath, "oracle_reader_error.log"), 
                    $"[{DateTime.Now}] Error creating sample data: {ex.Message}{Environment.NewLine}" &
                    $"Stack trace: {ex.StackTrace}{Environment.NewLine}")
                
                ' Add minimal data
                _data.Rows.Add("B001", "Introduction to SQL", "Textbook", "English", "Available", DBNull.Value, DBNull.Value, DBNull.Value)
                _data.Rows.Add("B002", "Visual Basic Programming", "Textbook", "English", "Available", DBNull.Value, DBNull.Value, DBNull.Value)
                _data.Rows.Add("B003", "The Great Gatsby", "Fiction", "English", "Available", DBNull.Value, DBNull.Value, DBNull.Value)
            End Try
        End Sub
        
        Public Overrides Sub Close()
            _closed = True
        End Sub
        
        Public Overrides ReadOnly Property Depth As Integer
            Get
                Return 0
            End Get
        End Property
        
        Public Overrides ReadOnly Property FieldCount As Integer
            Get
                Return _data.Columns.Count
            End Get
        End Property
        
        Public Overrides ReadOnly Property HasRows As Boolean
            Get
                Return _data.Rows.Count > 0
            End Get
        End Property
        
        Public Overrides ReadOnly Property IsClosed As Boolean
            Get
                Return _closed
            End Get
        End Property
        
        Public Overrides ReadOnly Property RecordsAffected As Integer
            Get
                Return -1
            End Get
        End Property
        
        Public Overrides ReadOnly Property Item(ordinal As Integer) As Object
            Get
                If _currentRow >= 0 AndAlso _currentRow < _data.Rows.Count Then
                    Return _data.Rows(_currentRow)(ordinal)
                End If
                Return DBNull.Value
            End Get
        End Property
        
        Public Overrides ReadOnly Property Item(name As String) As Object
            Get
                If _currentRow >= 0 AndAlso _currentRow < _data.Rows.Count Then
                    Return _data.Rows(_currentRow)(name)
                End If
                Return DBNull.Value
            End Get
        End Property
        
        Public Overrides Function GetBoolean(ordinal As Integer) As Boolean
            Return Boolean.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetByte(ordinal As Integer) As Byte
            Return Byte.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetBytes(ordinal As Integer, dataOffset As Long, buffer() As Byte, bufferOffset As Integer, length As Integer) As Long
            Return 0
        End Function
        
        Public Overrides Function GetChar(ordinal As Integer) As Char
            Return GetValue(ordinal).ToString()(0)
        End Function
        
        Public Overrides Function GetChars(ordinal As Integer, dataOffset As Long, buffer() As Char, bufferOffset As Integer, length As Integer) As Long
            Return 0
        End Function
        
        Public Overrides Function GetDataTypeName(ordinal As Integer) As String
            Return _data.Columns(ordinal).DataType.Name
        End Function
        
        Public Overrides Function GetDateTime(ordinal As Integer) As Date
            Return Date.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetDecimal(ordinal As Integer) As Decimal
            Return Decimal.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetDouble(ordinal As Integer) As Double
            Return Double.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetFieldType(ordinal As Integer) As Type
            Return _data.Columns(ordinal).DataType
        End Function
        
        Public Overrides Function GetFloat(ordinal As Integer) As Single
            Return Single.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetGuid(ordinal As Integer) As Guid
            Return Guid.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetInt16(ordinal As Integer) As Short
            Return Short.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetInt32(ordinal As Integer) As Integer
            Return Integer.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetInt64(ordinal As Integer) As Long
            Return Long.Parse(GetValue(ordinal).ToString())
        End Function
        
        Public Overrides Function GetName(ordinal As Integer) As String
            Return _data.Columns(ordinal).ColumnName
        End Function
        
        Public Overrides Function GetOrdinal(name As String) As Integer
            Return _data.Columns(name).Ordinal
        End Function
        
        Public Overrides Function GetString(ordinal As Integer) As String
            Return GetValue(ordinal).ToString()
        End Function
        
        Public Overrides Function GetValue(ordinal As Integer) As Object
            Return Item(ordinal)
        End Function
        
        Public Overrides Function GetValues(values() As Object) As Integer
            Dim count As Integer = Math.Min(values.Length, FieldCount)
            For i As Integer = 0 To count - 1
                values(i) = GetValue(i)
            Next
            Return count
        End Function
        
        Public Overrides Function IsDBNull(ordinal As Integer) As Boolean
            Return Item(ordinal) Is DBNull.Value
        End Function
        
        Public Overrides Function NextResult() As Boolean
            Return False
        End Function
        
        Public Overrides Function Read() As Boolean
            _currentRow += 1
            Return _currentRow < _data.Rows.Count
        End Function
        
        Public Shadows Function GetData(ordinal As Integer) As DbDataReader
            Return Nothing
        End Function

        Public Overrides ReadOnly Property VisibleFieldCount As Integer
            Get
                Return FieldCount
            End Get
        End Property
        
        Public Overrides Function GetSchemaTable() As DataTable
            Return _data.Clone()
        End Function
        
        Public Overrides Function GetEnumerator() As System.Collections.IEnumerator
            Return _data.Rows.GetEnumerator()
        End Function
    End Class
End Namespace 