Imports System.Data
Imports System.IO
Imports System.Configuration

Public Class TestDbConnection
    
    ''' <summary>
    ''' Directly test the database connection and write results to a log file
    ''' </summary>
    Public Shared Sub TestConnection()
        Try
            ' Get the connection strings from app.config
            Dim defaultConnection = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
            Dim systemConnection = ConfigurationManager.ConnectionStrings("SystemConnection").ConnectionString
            Dim legacyConnection = ConfigurationManager.ConnectionStrings("LegacyConnection").ConnectionString
            
            ' Log the connection strings (mask passwords)
            Dim logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connection_test.log")
            
            File.WriteAllText(logFilePath, $"Testing database connections at {DateTime.Now}{Environment.NewLine}")
            File.AppendAllText(logFilePath, 
                $"Default connection: {MaskPassword(defaultConnection)}{Environment.NewLine}")
            File.AppendAllText(logFilePath, 
                $"System connection: {MaskPassword(systemConnection)}{Environment.NewLine}")
            File.AppendAllText(logFilePath, 
                $"Legacy connection: {MaskPassword(legacyConnection)}{Environment.NewLine}")
            
            ' Test each connection
            TestSingleConnection("DefaultConnection", defaultConnection, logFilePath)
            TestSingleConnection("SystemConnection", systemConnection, logFilePath)
            TestSingleConnection("LegacyConnection", legacyConnection, logFilePath)
            
            ' Add a simple book update test
            Try
                File.AppendAllText(logFilePath, $"{Environment.NewLine}Testing book update...{Environment.NewLine}")
                
                ' Create a connection using the default connection string
                Using conn = New Oracle.ManagedDataAccess.Client.OracleConnection(defaultConnection)
                    conn.Open()
                    
                    ' Try to update a book
                    Using cmd = New Oracle.ManagedDataAccess.Client.OracleCommand("UPDATE books SET availability = 'Available' WHERE id = 'B001'", conn)
                        Dim result = cmd.ExecuteNonQuery()
                        File.AppendAllText(logFilePath, $"Book update result: {result} rows affected{Environment.NewLine}")
                    End Using
                End Using
            Catch ex As Exception
                File.AppendAllText(logFilePath, $"Book update error: {ex.Message}{Environment.NewLine}")
                If ex.InnerException IsNot Nothing Then
                    File.AppendAllText(logFilePath, $"Inner exception: {ex.InnerException.Message}{Environment.NewLine}")
                End If
            End Try
            
        Catch ex As Exception
            ' Handle configuration errors
            Dim logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connection_test_error.log")
            File.WriteAllText(logFilePath, $"Error testing connections: {ex.Message}{Environment.NewLine}")
            If ex.InnerException IsNot Nothing Then
                File.AppendAllText(logFilePath, $"Inner exception: {ex.InnerException.Message}{Environment.NewLine}")
            End If
        End Try
    End Sub
    
    ''' <summary>
    ''' Test a single connection and log the result
    ''' </summary>
    Private Shared Sub TestSingleConnection(connectionName As String, connectionString As String, logFilePath As String)
        Try
            File.AppendAllText(logFilePath, $"{Environment.NewLine}Testing {connectionName}...{Environment.NewLine}")
            
            ' Create and open the connection
            Using conn = New Oracle.ManagedDataAccess.Client.OracleConnection(connectionString)
                conn.Open()
                
                ' Connection opened successfully
                File.AppendAllText(logFilePath, $"Connection succeeded! State: {conn.State}{Environment.NewLine}")
                
                ' Try a simple query
                Using cmd = New Oracle.ManagedDataAccess.Client.OracleCommand("SELECT COUNT(*) FROM books", conn)
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    File.AppendAllText(logFilePath, $"Book count: {count}{Environment.NewLine}")
                End Using
                
                conn.Close()
            End Using
        Catch ex As Exception
            ' Log the connection error
            File.AppendAllText(logFilePath, $"Connection failed: {ex.Message}{Environment.NewLine}")
            If ex.InnerException IsNot Nothing Then
                File.AppendAllText(logFilePath, $"Inner exception: {ex.InnerException.Message}{Environment.NewLine}")
            End If
        End Try
    End Sub
    
    ''' <summary>
    ''' Mask the password in a connection string for logging
    ''' </summary>
    Private Shared Function MaskPassword(connectionString As String) As String
        ' Simple regex replacement to hide the password
        Return System.Text.RegularExpressions.Regex.Replace(
            connectionString,
            "Password=([^;]+)",
            "Password=********")
    End Function
    
End Class 