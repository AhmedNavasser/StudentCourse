﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteInfoForm
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
        Me.InputParameterGroupBox = New System.Windows.Forms.GroupBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.StuIdInputTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UserInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.PersonalIdTExtBox = New System.Windows.Forms.TextBox()
        Me.PersonalIdLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.StudentIdTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIdLabel = New System.Windows.Forms.Label()
        Me.InputParameterGroupBox.SuspendLayout()
        Me.UserInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputParameterGroupBox
        '
        Me.InputParameterGroupBox.Controls.Add(Me.SearchButton)
        Me.InputParameterGroupBox.Controls.Add(Me.StuIdInputTextBox)
        Me.InputParameterGroupBox.Controls.Add(Me.Label1)
        Me.InputParameterGroupBox.Location = New System.Drawing.Point(255, 12)
        Me.InputParameterGroupBox.Name = "InputParameterGroupBox"
        Me.InputParameterGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.InputParameterGroupBox.Size = New System.Drawing.Size(435, 71)
        Me.InputParameterGroupBox.TabIndex = 9
        Me.InputParameterGroupBox.TabStop = False
        Me.InputParameterGroupBox.Text = "جستجوی دانشجو"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(15, 32)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "جستجو"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'StuIdInputTextBox
        '
        Me.StuIdInputTextBox.Location = New System.Drawing.Point(107, 32)
        Me.StuIdInputTextBox.Name = "StuIdInputTextBox"
        Me.StuIdInputTextBox.Size = New System.Drawing.Size(215, 21)
        Me.StuIdInputTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(332, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره دانشجویی"
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(11, 204)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 8
        Me.DeleteButton.Text = "حذف"
        Me.DeleteButton.UseVisualStyleBackColor = True
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
        Me.UserInfoGroupBox.Location = New System.Drawing.Point(11, 98)
        Me.UserInfoGroupBox.Name = "UserInfoGroupBox"
        Me.UserInfoGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UserInfoGroupBox.Size = New System.Drawing.Size(679, 100)
        Me.UserInfoGroupBox.TabIndex = 7
        Me.UserInfoGroupBox.TabStop = False
        Me.UserInfoGroupBox.Text = "اطلاعات دانشجو"
        '
        'PersonalIdTExtBox
        '
        Me.PersonalIdTExtBox.Location = New System.Drawing.Point(10, 40)
        Me.PersonalIdTExtBox.Name = "PersonalIdTExtBox"
        Me.PersonalIdTExtBox.ReadOnly = True
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
        Me.LastNameTextBox.ReadOnly = True
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
        Me.FirstNameTextBox.ReadOnly = True
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
        Me.StudentIdTextBox.ReadOnly = True
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
        'DeleteInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 242)
        Me.Controls.Add(Me.InputParameterGroupBox)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UserInfoGroupBox)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DeleteInfoForm"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteInfoForm"
        Me.InputParameterGroupBox.ResumeLayout(False)
        Me.InputParameterGroupBox.PerformLayout()
        Me.UserInfoGroupBox.ResumeLayout(False)
        Me.UserInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputParameterGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents StuIdInputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
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
