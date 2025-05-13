<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseConnectionSelector
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboConnections = New System.Windows.Forms.ComboBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDefaultConnection = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnOpenTester = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(289, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Database Connection Selection"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Available Connections:"
        '
        'cboConnections
        '
        Me.cboConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConnections.FormattingEnabled = True
        Me.cboConnections.Location = New System.Drawing.Point(137, 55)
        Me.cboConnections.Name = "cboConnections"
        Me.cboConnections.Size = New System.Drawing.Size(245, 21)
        Me.cboConnections.TabIndex = 2
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(388, 53)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 3
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Working Connection:"
        '
        'txtDefaultConnection
        '
        Me.txtDefaultConnection.Location = New System.Drawing.Point(137, 124)
        Me.txtDefaultConnection.Name = "txtDefaultConnection"
        Me.txtDefaultConnection.ReadOnly = True
        Me.txtDefaultConnection.Size = New System.Drawing.Size(245, 20)
        Me.txtDefaultConnection.TabIndex = 5
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(264, 172)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(118, 30)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "Continue to Login"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnOpenTester
        '
        Me.btnOpenTester.Location = New System.Drawing.Point(137, 172)
        Me.btnOpenTester.Name = "btnOpenTester"
        Me.btnOpenTester.Size = New System.Drawing.Size(118, 30)
        Me.btnOpenTester.TabIndex = 7
        Me.btnOpenTester.Text = "Open DB Tester"
        Me.btnOpenTester.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(449, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Select a connection from the list and click Test to verify it works. If the connec" &
    "tion is successful, you can continue to the login screen."
        '
        'DatabaseConnectionSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 214)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOpenTester)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtDefaultConnection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.cboConnections)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DatabaseConnectionSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents cboConnections As Windows.Forms.ComboBox
    Friend WithEvents btnTest As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtDefaultConnection As Windows.Forms.TextBox
    Friend WithEvents btnContinue As Windows.Forms.Button
    Friend WithEvents btnOpenTester As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
End Class 