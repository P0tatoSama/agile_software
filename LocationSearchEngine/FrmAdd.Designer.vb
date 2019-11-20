<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdd
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtPostOffice = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.mskPostcode = New System.Windows.Forms.MaskedTextBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(80, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Location :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(80, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Post Office :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(80, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "State :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(80, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Postcode :"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(229, 33)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(132, 32)
        Me.txtLocation.TabIndex = 4
        '
        'txtPostOffice
        '
        Me.txtPostOffice.Location = New System.Drawing.Point(229, 79)
        Me.txtPostOffice.Multiline = True
        Me.txtPostOffice.Name = "txtPostOffice"
        Me.txtPostOffice.Size = New System.Drawing.Size(132, 34)
        Me.txtPostOffice.TabIndex = 5
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(229, 127)
        Me.txtState.Multiline = True
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(132, 32)
        Me.txtState.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(83, 244)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(268, 244)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'mskPostcode
        '
        Me.mskPostcode.Location = New System.Drawing.Point(229, 178)
        Me.mskPostcode.Mask = ">00000"
        Me.mskPostcode.Name = "mskPostcode"
        Me.mskPostcode.Size = New System.Drawing.Size(132, 22)
        Me.mskPostcode.TabIndex = 10
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'FrmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 300)
        Me.Controls.Add(Me.mskPostcode)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtPostOffice)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAdd"
        Me.Text = "Add Location"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtPostOffice As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents mskPostcode As MaskedTextBox
    Friend WithEvents err As ErrorProvider
End Class
