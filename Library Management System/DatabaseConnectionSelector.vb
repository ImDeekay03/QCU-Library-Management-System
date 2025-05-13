Imports System.Data
Imports System.Configuration
Imports System.Reflection
Imports System.IO

Public Class DatabaseConnectionSelector
    Private Sub DatabaseConnectionSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Try to load the Oracle assembly earlier
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveOracleAssembly
            
            ' Populate the connection combo box with available connections from the manager
            Dim connections = DatabaseConnectionManager.GetAvailableConnections()
            For Each connName As String In connections
                cboConnections.Items.Add(connName)
            Next
            
            ' Select the default connection
            If cboConnections.Items.Count > 0 Then
                cboConnections.SelectedIndex = 0
            End If
            
            ' Try to find a working connection automatically
            Dim workingConn = DatabaseConnectionManager.TestAllConnections()
            If Not String.IsNullOrEmpty(workingConn) Then
                ' Found a working connection, select it
                cboConnections.SelectedItem = workingConn
                txtDefaultConnection.Text = workingConn
            End If
        Catch ex As ConfigurationErrorsException
            MessageBox.Show($"Error loading configuration: {ex.Message}{Environment.NewLine}{Environment.NewLine}" & 
                           "Please check your App.config file. The application will continue with limited functionality.", 
                           "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            
            ' Add a default connection option
            cboConnections.Items.Add("DefaultManual")
        Catch ex As Exception
            MessageBox.Show($"Error loading connection settings: {ex.Message}", 
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' Handle assembly resolution for Oracle.ManagedDataAccess
    Private Function ResolveOracleAssembly(sender As Object, args As ResolveEventArgs) As Assembly
        If args.Name.StartsWith("Oracle.ManagedDataAccess") Then
            Try
                ' Try to load from application directory
                Dim appPath As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                Dim dllPath As String = Path.Combine(appPath, "Oracle.ManagedDataAccess.dll")
                
                If File.Exists(dllPath) Then
                    Return Assembly.LoadFrom(dllPath)
                End If
                
                ' Try packages folder
                dllPath = Path.Combine(appPath, "packages", "Oracle.ManagedDataAccess.21.10.0", "lib", "net462", "Oracle.ManagedDataAccess.dll")
                If File.Exists(dllPath) Then
                    Return Assembly.LoadFrom(dllPath)
                End If
            Catch ex As Exception
                ' Ignore errors, we'll handle them elsewhere
            End Try
        End If
        
        Return Nothing
    End Function

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        If cboConnections.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a connection to test.", "No Connection Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Get the selected connection string
        Dim connName As String = cboConnections.SelectedItem.ToString()
        
        ' Test using the connection manager
        Try
            If DatabaseConnectionManager.TestConnection(connName) Then
                ' Set as the active connection
                DatabaseConnectionManager.ActiveConnectionName = connName
                
                MessageBox.Show("Successfully connected to database." &
                             Environment.NewLine & Environment.NewLine &
                             "This connection will be used for database operations.", 
                          "Connection Success", 
                          MessageBoxButtons.OK, 
                          MessageBoxIcon.Information)
                
                ' Save as default
                txtDefaultConnection.Text = connName
            Else
                MessageBox.Show("Failed to connect to database. The connection was not successful.", 
                              "Connection Failed", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Show error message
            MessageBox.Show($"Error connecting to database: {ex.Message}", 
                          "Connection Failed", 
                          MessageBoxButtons.OK, 
                          MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If String.IsNullOrEmpty(txtDefaultConnection.Text) Then
            MessageBox.Show("Please test and select a working connection first.", 
                          "No Connection Selected", 
                          MessageBoxButtons.OK, 
                          MessageBoxIcon.Warning)
            Return
        End If
        
        Try
            ' Set the active connection
            DatabaseConnectionManager.ActiveConnectionName = txtDefaultConnection.Text
            
            ' Test simple database query
            Try
                Dim testData = DatabaseConnectionManager.ExecuteQuery("SELECT 1 FROM DUAL")
                ' If successful, continue
            Catch
                ' If test fails, still continue - our fallback system will handle it
            End Try
            
            ' Proceed to the login screen
            Dim loginForm As New UserPopUp()
            loginForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show($"Error opening login form: {ex.Message}", 
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOpenTester_Click(sender As Object, e As EventArgs) Handles btnOpenTester.Click
        ' Open the database tester form
        Try
            Dim tester As New DatabaseTester()
            tester.ShowDialog()
        Catch ex As Exception
            MessageBox.Show($"Error opening database tester: {ex.Message}", 
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class 