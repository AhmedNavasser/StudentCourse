﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewStudentForm
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
        Me.EditButton = New System.Windows.Forms.Button()
        Me.UserInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.PersonalIdTExtBox = New System.Windows.Forms.TextBox()
        Me.PersonalIdLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.StudentIdTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIdLabel = New System.Windows.Forms.Label()
        Me.UserInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(12, 118)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 3
        Me.EditButton.Text = "ثبت"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'UserInfoGroupBox
        '
        Me.UserInfoGroupBox.Controls.Add(Me.PersonalIdTExtBox)
        Me.UserInfoGroupBox.Controls.Add(Me.PersonalIdLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.LastNameLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.StudentIdTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.StudentIdLabel)
        Me.UserInfoGroupBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInfoGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.UserInfoGroupBox.Name = "UserInfoGroupBox"
        Me.UserInfoGroupBox.Size = New System.Drawing.Size(679, 100)
        Me.UserInfoGroupBox.TabIndex = 2
        Me.UserInfoGroupBox.TabStop = False
        Me.UserInfoGroupBox.Text = "اطلاعات دانشجو"
        '
        'PersonalIdTExtBox
        '
        Me.PersonalIdTExtBox.Location = New System.Drawing.Point(10, 40)
        Me.PersonalIdTExtBox.Name = "PersonalIdTExtBox"
        Me.PersonalIdTExtBox.Size = New System.Drawing.Size(100, 21)
        Me.PersonalIdTExtBox.TabIndex = 15
        '
        'PersonalIdLabel
        '
        Me.PersonalIdLabel.AutoSize = True
        Me.PersonalIdLabel.Location = New System.Drawing.Point(116, 43)
        Me.PersonalIdLabel.Name = "PersonalIdLabel"
        Me.PersonalIdLabel.Size = New System.Drawing.Size(39, 13)
        Me.PersonalIdLabel.TabIndex = 14
        Me.PersonalIdLabel.Text = "کدملی"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(161, 40)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.LastNameTextBox.TabIndex = 13
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(267, 43)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(65, 13)
        Me.LastNameLabel.TabIndex = 12
        Me.LastNameLabel.Text = "نام خانوادگی"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(342, 40)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.FirstNameTextBox.TabIndex = 11
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(448, 43)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(20, 13)
        Me.FirstNameLabel.TabIndex = 10
        Me.FirstNameLabel.Text = "نام"
        '
        'StudentIdTextBox
        '
        Me.StudentIdTextBox.Location = New System.Drawing.Point(474, 40)
        Me.StudentIdTextBox.Name = "StudentIdTextBox"
        Me.StudentIdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.StudentIdTextBox.TabIndex = 9
        '
        'StudentIdLabel
        '
        Me.StudentIdLabel.AutoSize = True
        Me.StudentIdLabel.Location = New System.Drawing.Point(580, 40)
        Me.StudentIdLabel.Name = "StudentIdLabel"
        Me.StudentIdLabel.Size = New System.Drawing.Size(89, 13)
        Me.StudentIdLabel.TabIndex = 8
        Me.StudentIdLabel.Text = "شماره دانشجویی"
        '
        'NewStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 147)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.UserInfoGroupBox)
        Me.Name = "NewStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewStudentForm"
        Me.UserInfoGroupBox.ResumeLayout(False)
        Me.UserInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents UserInfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PersonalIdTExtBox As System.Windows.Forms.TextBox
    Friend WithEvents PersonalIdLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents StudentIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentIdLabel As System.Windows.Forms.Label
End Class
