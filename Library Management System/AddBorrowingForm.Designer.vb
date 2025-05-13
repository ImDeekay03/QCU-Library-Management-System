<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBorrowingForm
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
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.dtpBorrowDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(92, 65)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(100, 20)
        Me.txtBookID.TabIndex = 0
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Location = New System.Drawing.Point(92, 130)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(100, 20)
        Me.txtBorrowerName.TabIndex = 1
        '
        'dtpBorrowDate
        '
        Me.dtpBorrowDate.Location = New System.Drawing.Point(92, 191)
        Me.dtpBorrowDate.Name = "dtpBorrowDate"
        Me.dtpBorrowDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpBorrowDate.TabIndex = 2
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.Location = New System.Drawing.Point(92, 258)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpReturnDate.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(150, 317)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Book ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Borrower Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Borrow Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Return Date"
        '
        'AddBorrowingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpReturnDate)
        Me.Controls.Add(Me.dtpBorrowDate)
        Me.Controls.Add(Me.txtBorrowerName)
        Me.Controls.Add(Me.txtBookID)
        Me.Name = "AddBorrowingForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents dtpBorrowDate As DateTimePicker
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
