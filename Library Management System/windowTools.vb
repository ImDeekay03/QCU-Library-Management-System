Imports System.Windows.Forms
Public Class windowTools
    Public Sub windowSwitch(currentForm As Form, toSwitchForm As Form)
        toSwitchForm.Show()
        currentForm.Hide()
    End Sub
End Class
