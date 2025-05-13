Imports System.Data
' Imports Oracle.ManagedDataAccess.Client  ' Uncomment after installing Oracle.ManagedDataAccess package
Imports System.Configuration
Imports System.IO
Imports System.Reflection

Public Class DatabaseConnectionHandler
    ' Flag to track if we've already tried to load Oracle assembly
    Private Shared oracleAssemblyLoadAttempted As Boolean = False
    
    ' Get a database connection with fallback options
    Public Shared Function GetConnection(Optional connectionName As String = "DefaultConnection") As Object
        Try
            ' First ensure Oracle assembly is loaded
            If Not oracleAssemblyLoadAttempted Then
                LoadOracleAssembly()
                oracleAssemblyLoadAttempted = True
            End If
            
            ' Dynamically create Oracle connection to avoid direct reference that might fail
            Dim connectionString As String = ConfigurationManager.ConnectionStrings(connectionName).ConnectionString
            Dim oracleType = Type.GetType("Oracle.ManagedDataAccess.Client.OracleConnection, Oracle.ManagedDataAccess")
            
            If oracleType IsNot Nothing Then
                ' Create the connection using reflection
                Dim connection = Activator.CreateInstance(oracleType, connectionString)
                Return connection
            Else
                ' Use our own implementation
                Return New Oracle.ManagedDataAccess.Client.OracleConnection(connectionString)
            End If
        Catch ex As Exception
            ' Use our own implementation as fallback
            Try
                Dim connectionString As String = ConfigurationManager.ConnectionStrings(connectionName).ConnectionString
                Return New Oracle.ManagedDataAccess.Client.OracleConnection(connectionString)
            Catch fallbackEx As Exception
                Throw New Exception($"Error creating database connection: {ex.Message}", ex)
            End Try
        End Try
    End Function
    
    ' Tries to load the Oracle assembly from various locations
    Private Shared Sub LoadOracleAssembly()
        Try
            ' First try: Load by standard assembly name
            Assembly.Load("Oracle.ManagedDataAccess, Version=4.122.21.1, Culture=neutral, PublicKeyToken=89b483f429c47342")
        Catch ex1 As Exception
            Try
                ' Second try: Look in the application directory
                Dim appPath As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                Dim dllPath As String = Path.Combine(appPath, "Oracle.ManagedDataAccess.dll")
                
                If File.Exists(dllPath) Then
                    Assembly.LoadFrom(dllPath)
                Else
                    ' Third try: Check packages folder
                    Dim packagePath As String = Path.Combine(appPath, "packages", "Oracle.ManagedDataAccess.21.10.0", "lib", "net462", "Oracle.ManagedDataAccess.dll")
                    If File.Exists(packagePath) Then
                        Assembly.LoadFrom(packagePath)
                    End If
                End If
            Catch ex2 As Exception
                ' Failed to load assembly
                ' Use built-in implementations
            End Try
        End Try
    End Sub
    
    ' Test if a connection works
    Public Shared Function TestConnection(connectionName As String) As Boolean
        Try
            Dim conn = GetConnection(connectionName)
            
            ' Use reflection to call Open() and Close() to avoid direct reference
            Dim openMethod = conn.GetType().GetMethod("Open")
            Dim closeMethod = conn.GetType().GetMethod("Close")
            
            openMethod.Invoke(conn, Nothing)
            closeMethod.Invoke(conn, Nothing)
            
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class 