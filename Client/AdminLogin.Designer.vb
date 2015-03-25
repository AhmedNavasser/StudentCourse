<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Me.UserInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.personalIdTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.UserInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserInfoGroupBox
        '
        Me.UserInfoGroupBox.Controls.Add(Me.personalIdTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.PasswordLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.UserIdTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.UserNameLabel)
        Me.UserInfoGroupBox.Enabled = False
        Me.UserInfoGroupBox.Location = New System.Drawing.Point(12, 29)
        Me.UserInfoGroupBox.Name = "UserInfoGroupBox"
        Me.UserInfoGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UserInfoGroupBox.Size = New System.Drawing.Size(292, 104)
        Me.UserInfoGroupBox.TabIndex = 7
        Me.UserInfoGroupBox.TabStop = False
        Me.UserInfoGroupBox.Text = "اطلاعات کاربر"
        '
        'personalIdTextBox
        '
        Me.personalIdTextBox.Location = New System.Drawing.Point(23, 60)
        Me.personalIdTextBox.Name = "personalIdTextBox"
        Me.personalIdTextBox.Size = New System.Drawing.Size(187, 21)
        Me.personalIdTextBox.TabIndex = 7
        Me.personalIdTextBox.UseSystemPasswordChar = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(224, 60)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(45, 13)
        Me.PasswordLabel.TabIndex = 6
        Me.PasswordLabel.Text = "رمز عبور"
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.Location = New System.Drawing.Point(23, 20)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(187, 21)
        Me.UserIdTextBox.TabIndex = 5
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(216, 23)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(53, 13)
        Me.UserNameLabel.TabIndex = 4
        Me.UserNameLabel.Text = "نام کاربری"
        '
        'EnterButton
        '
        Me.EnterButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterButton.Location = New System.Drawing.Point(12, 143)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(75, 23)
        Me.EnterButton.TabIndex = 6
        Me.EnterButton.Text = "ورود"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 184)
        Me.Controls.Add(Me.UserInfoGroupBox)
        Me.Controls.Add(Me.EnterButton)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AdminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminLogin"
        Me.UserInfoGroupBox.ResumeLayout(False)
        Me.UserInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserInfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents personalIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UserIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameLabel As System.Windows.Forms.Label
    Friend WithEvents EnterButton As System.Windows.Forms.Button
End Class
