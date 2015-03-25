<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.UserInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.personalIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.studentIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdminLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.UserInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnterButton
        '
        Me.EnterButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterButton.Location = New System.Drawing.Point(6, 156)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(75, 23)
        Me.EnterButton.TabIndex = 4
        Me.EnterButton.Text = "ورود"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'UserInfoGroupBox
        '
        Me.UserInfoGroupBox.Controls.Add(Me.personalIdTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.Label2)
        Me.UserInfoGroupBox.Controls.Add(Me.studentIdTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.Label1)
        Me.UserInfoGroupBox.Location = New System.Drawing.Point(6, 46)
        Me.UserInfoGroupBox.Name = "UserInfoGroupBox"
        Me.UserInfoGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UserInfoGroupBox.Size = New System.Drawing.Size(292, 104)
        Me.UserInfoGroupBox.TabIndex = 5
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "رمز عبور"
        '
        'studentIdTextBox
        '
        Me.studentIdTextBox.Location = New System.Drawing.Point(23, 20)
        Me.studentIdTextBox.Name = "studentIdTextBox"
        Me.studentIdTextBox.Size = New System.Drawing.Size(187, 21)
        Me.studentIdTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "نام کاربری"
        '
        'AdminLinkLabel
        '
        Me.AdminLinkLabel.AutoSize = True
        Me.AdminLinkLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AdminLinkLabel.LinkColor = System.Drawing.Color.OrangeRed
        Me.AdminLinkLabel.Location = New System.Drawing.Point(3, 18)
        Me.AdminLinkLabel.Name = "AdminLinkLabel"
        Me.AdminLinkLabel.Size = New System.Drawing.Size(42, 14)
        Me.AdminLinkLabel.TabIndex = 6
        Me.AdminLinkLabel.TabStop = True
        Me.AdminLinkLabel.Text = "مدیریت"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.EnterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 186)
        Me.Controls.Add(Me.AdminLinkLabel)
        Me.Controls.Add(Me.UserInfoGroupBox)
        Me.Controls.Add(Me.EnterButton)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ورود"
        Me.UserInfoGroupBox.ResumeLayout(False)
        Me.UserInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnterButton As System.Windows.Forms.Button
    Friend WithEvents UserInfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents personalIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents studentIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AdminLinkLabel As System.Windows.Forms.LinkLabel

End Class
