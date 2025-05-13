Imports System
Imports System.Windows.Forms
Imports System.IO

Module Program
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        
        Try
            ' Set up error handling
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
            AddHandler Application.ThreadException, AddressOf Application_ThreadException
            AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
            
            ' Initialize the database before starting the app
            InitializeDatabase()
            
            ' Start the application
            Application.Run(New Form1())
        Catch ex As Exception
            HandleStartupException(ex)
        End Try
    End Sub
    
    Private Sub InitializeDatabase()
        Try
            ' Initialize the database structure and test connections
            DatabaseConnectionManager.Initialize()
        Catch ex As Exception
            ' Log error but continue
            File.AppendAllText("startup_error.log", $"Error initializing database: {ex.Message}{Environment.NewLine}")
            
            ' Show warning to user
            MessageBox.Show("Warning: Could not initialize database properly. Some features may not work correctly." & 
                          Environment.NewLine & ex.Message,
                          "Database Initialization Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    
    Private Sub Application_ThreadException(sender As Object, e As System.Threading.ThreadExceptionEventArgs)
        ' Log the error
        File.AppendAllText("app_error.log", $"Thread Exception: {e.Exception.Message}{Environment.NewLine}" & 
                                           $"Stack Trace: {e.Exception.StackTrace}{Environment.NewLine}")
        
        ' Show error message
        MessageBox.Show("An error occurred in the application. The error has been logged." & 
                      Environment.NewLine & e.Exception.Message,
                      "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    
    Private Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
        Dim ex As Exception = DirectCast(e.ExceptionObject, Exception)
        
        ' Log the error
        File.AppendAllText("app_error.log", $"Unhandled Exception: {ex.Message}{Environment.NewLine}" & 
                                           $"Stack Trace: {ex.StackTrace}{Environment.NewLine}")
        
        ' Show error message
        MessageBox.Show("A fatal error occurred in the application. The application will close." & 
                      Environment.NewLine & ex.Message,
                      "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    
    Private Sub HandleStartupException(ex As Exception)
        ' Log the error
        File.AppendAllText("startup_error.log", $"Startup Exception: {ex.Message}{Environment.NewLine}" & 
                                               $"Stack Trace: {ex.StackTrace}{Environment.NewLine}")
        
        ' Show error message
        MessageBox.Show("An error occurred while starting the application. The application will close." & 
                      Environment.NewLine & ex.Message,
                      "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        
        Application.Exit()
    End Sub
End Module 