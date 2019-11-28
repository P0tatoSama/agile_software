<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdate
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
        Me.mskPostcode = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtPostOffice = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mskPostcode
        '
        Me.mskPostcode.Location = New System.Drawing.Point(242, 202)
        Me.mskPostcode.Mask = ">00000"
        Me.mskPostcode.Name = "mskPostcode"
        Me.mskPostcode.Size = New System.Drawing.Size(132, 22)
        Me.mskPostcode.TabIndex = 20
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(332, 268)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(57, 268)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(242, 151)
        Me.txtState.Multiline = True
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(132, 32)
        Me.txtState.TabIndex = 17
        '
        'txtPostOffice
        '
        Me.txtPostOffice.Location = New System.Drawing.Point(242, 103)
        Me.txtPostOffice.Multiline = True
        Me.txtPostOffice.Name = "txtPostOffice"
        Me.txtPostOffice.Size = New System.Drawing.Size(132, 34)
        Me.txtPostOffice.TabIndex = 16
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(242, 57)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(132, 32)
        Me.txtLocation.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(93, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Postcode :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(93, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "State :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(93, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Post Office :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(93, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Location :"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(192, 268)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'FrmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 348)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.mskPostcode)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtPostOffice)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUpdate"
        Me.Text = "FrmUpdate"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mskPostcode As MaskedTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtPostOffice As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents err As ErrorProvider
End Class
