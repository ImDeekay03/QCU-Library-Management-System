Imports System
Imports System.Windows.Forms

Module TestConnection
    
    Sub Main()
        Try
            ' Display a message
            MessageBox.Show("Starting connection test. Results will be written to connection_test.log in the bin\Debug folder.", 
                           "Database Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' Run the test
            TestDbConnection.TestConnection()
            
            ' Display results
            MessageBox.Show("Test completed. Check connection_test.log for results.", 
                           "Database Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error running test: {ex.Message}", 
                           "Database Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
End Module 