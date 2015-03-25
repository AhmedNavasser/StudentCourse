<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.EditStudentButtonButton = New System.Windows.Forms.Button()
        Me.DeleteStudentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddStudentButton
        '
        Me.AddStudentButton.Location = New System.Drawing.Point(208, 46)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(110, 23)
        Me.AddStudentButton.TabIndex = 0
        Me.AddStudentButton.Text = "اضافه کردن دانشجو"
        Me.AddStudentButton.UseVisualStyleBackColor = True
        '
        'EditStudentButtonButton
        '
        Me.EditStudentButtonButton.Location = New System.Drawing.Point(117, 46)
        Me.EditStudentButtonButton.Name = "EditStudentButtonButton"
        Me.EditStudentButtonButton.Size = New System.Drawing.Size(75, 23)
        Me.EditStudentButtonButton.TabIndex = 1
        Me.EditStudentButtonButton.Text = "ویرایش"
        Me.EditStudentButtonButton.UseVisualStyleBackColor = True
        '
        'DeleteStudentButton
        '
        Me.DeleteStudentButton.Location = New System.Drawing.Point(22, 46)
        Me.DeleteStudentButton.Name = "DeleteStudentButton"
        Me.DeleteStudentButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteStudentButton.TabIndex = 2
        Me.DeleteStudentButton.Text = "حذف"
        Me.DeleteStudentButton.UseVisualStyleBackColor = True
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 110)
        Me.Controls.Add(Me.DeleteStudentButton)
        Me.Controls.Add(Me.EditStudentButtonButton)
        Me.Controls.Add(Me.AddStudentButton)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AdminPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminPanel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddStudentButton As System.Windows.Forms.Button
    Friend WithEvents EditStudentButtonButton As System.Windows.Forms.Button
    Friend WithEvents DeleteStudentButton As System.Windows.Forms.Button
End Class
