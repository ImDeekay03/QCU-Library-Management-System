Imports System.Data
' Imports Oracle.ManagedDataAccess.Client  ' Uncomment after installing Oracle.ManagedDataAccess package
Imports System.Configuration
Imports System.Text
Imports System.Data.Common

Public Class DatabaseTester
    Private Sub DatabaseTester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the connection text box with the current connection string
        txtConnectionString.Text = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        ' Testing connection with current connection string
        txtResults.Clear()
        txtResults.AppendText("Testing database connection..." & vbCrLf & vbCrLf)
        
        Dim result As New StringBuilder()
        
        Try
            ' Test the connection
            Using conn As New Oracle.ManagedDataAccess.Client.OracleConnection(txtConnectionString.Text)
                Try
                    conn.Open()
                    result.AppendLine("✅ Successfully connected to database")
                    result.AppendLine($"    Database version: {conn.ServerVersion}")
                    
                    ' Check that the essential tables exist
                    Dim tables As New List(Of String) From {"STUDENTS", "ADMIN", "BOOKS"}
                    
                    For Each tableName As String In tables
                        If TableExists(conn, tableName) Then
                            Dim count As Integer = GetTableRowCount(conn, tableName)
                            result.AppendLine($"✅ Table {tableName} exists with {count} rows")
                        Else
                            result.AppendLine($"❌ Table {tableName} does not exist")
                        End If
                    Next
                    
                Catch ex As Exception
                    result.AppendLine("❌ Connected but encountered an error:")
                    result.AppendLine("    " & ex.Message)
                End Try
            End Using
            
        Catch ex As Exception
            result.AppendLine("❌ Failed to connect to database:")
            result.AppendLine("    " & ex.Message)
            
            ' Check if it might be a connection string issue
            Try
                Dim connStr As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
                result.AppendLine(vbCrLf & "Current connection string:")
                result.AppendLine("    " & connStr.Replace("Password=", "Password=********"))
            Catch configEx As Exception
                result.AppendLine(vbCrLf & "❌ Error reading connection string from config:")
                result.AppendLine("    " & configEx.Message)
            End Try
        End Try
        
        txtResults.AppendText(result.ToString())
    End Sub

    Private Sub btnRunQuery_Click(sender As Object, e As EventArgs) Handles btnRunQuery.Click
        ' Run a custom query to test
        If String.IsNullOrWhiteSpace(txtQuery.Text) Then
            MessageBox.Show("Please enter a SQL query to execute.", "Query Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        txtResults.Clear()
        txtResults.AppendText("Executing query: " & txtQuery.Text & vbCrLf & vbCrLf)
        
        Try
            ' Execute the query
            Using conn As New Oracle.ManagedDataAccess.Client.OracleConnection(txtConnectionString.Text)
                conn.Open()
                Dim cmd As DbCommand = conn.CreateCommand()
                cmd.CommandText = txtQuery.Text
                    
                Using reader As DbDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    
                    ' Display column headers
                    Dim headers As New StringBuilder()
                    For Each column As DataColumn In dt.Columns
                        headers.Append(column.ColumnName.PadRight(20))
                    Next
                    txtResults.AppendText(headers.ToString() & vbCrLf)
                    
                    ' Add a separator line
                    txtResults.AppendText(New String("-"c, headers.Length) & vbCrLf)
                    
                    ' Display rows
                    For Each row As DataRow In dt.Rows
                        Dim rowText As New StringBuilder()
                        For Each column As DataColumn In dt.Columns
                            Dim value As String = If(row(column) Is DBNull.Value, "NULL", row(column).ToString())
                            rowText.Append(value.PadRight(20))
                        Next
                        txtResults.AppendText(rowText.ToString() & vbCrLf)
                    Next
                    
                    txtResults.AppendText(vbCrLf & dt.Rows.Count & " row(s) returned")
                End Using
            End Using
            
        Catch ex As Exception
            txtResults.AppendText("Error executing query: " & vbCrLf & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Checks if a table exists in the database
    ''' </summary>
    ''' <param name="conn">An open database connection</param>
    ''' <param name="tableName">The name of the table to check</param>
    ''' <returns>True if the table exists</returns>
    Private Function TableExists(conn As Oracle.ManagedDataAccess.Client.OracleConnection, tableName As String) As Boolean
        Dim cmd As DbCommand = conn.CreateCommand()
        cmd.CommandText = "SELECT COUNT(*) FROM USER_TABLES WHERE TABLE_NAME = :tableName"
        Dim parameter As DbParameter = cmd.CreateParameter()
        parameter.ParameterName = "tableName"
        parameter.Value = tableName.ToUpper()
        cmd.Parameters.Add(parameter)
        
        Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return result > 0
    End Function
    
    ''' <summary>
    ''' Gets the row count of a table
    ''' </summary>
    ''' <param name="conn">An open database connection</param>
    ''' <param name="tableName">The name of the table to check</param>
    ''' <returns>The number of rows in the table</returns>
    Private Function GetTableRowCount(conn As Oracle.ManagedDataAccess.Client.OracleConnection, tableName As String) As Integer
        Dim cmd As DbCommand = conn.CreateCommand()
        cmd.CommandText = $"SELECT COUNT(*) FROM {tableName}"
        
        Try
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Return -1 ' Error getting count
        End Try
    End Function

    Private Sub btnSaveConnection_Click(sender As Object, e As EventArgs) Handles btnSaveConnection.Click
        ' This would update the app.config, which requires more code to modify XML
        ' For simplicity, just show a message instead
        MessageBox.Show("To update the connection string, edit the App.config file directly." & vbCrLf & 
                        "The application needs to be restarted for changes to take effect.",
                        "Connection String", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class 