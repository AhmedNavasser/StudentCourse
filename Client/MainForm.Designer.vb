<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EditInfoLinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PersonalIdTExtBox = New System.Windows.Forms.TextBox()
        Me.PersonalIdLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.StudentIdTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIdLabel = New System.Windows.Forms.Label()
        Me.AvailableCoursesGroupBox = New System.Windows.Forms.GroupBox()
        Me.AvailableCoursesDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddToListButton = New System.Windows.Forms.Button()
        Me.CourseCategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.CourseCategory = New System.Windows.Forms.Label()
        Me.SelectedCoursesGroupBox = New System.Windows.Forms.GroupBox()
        Me.ShowReportButton = New System.Windows.Forms.Button()
        Me.FinalEnterButton = New System.Windows.Forms.Button()
        Me.SelectedCoursesListBox = New System.Windows.Forms.ListBox()
        Me.RemoveFromListButton = New System.Windows.Forms.Button()
        Me.TermInfoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.AvailableCoursesGroupBox.SuspendLayout()
        CType(Me.AvailableCoursesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectedCoursesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EditInfoLinkLabel1)
        Me.GroupBox1.Controls.Add(Me.PersonalIdTExtBox)
        Me.GroupBox1.Controls.Add(Me.PersonalIdLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.StudentIdTextBox)
        Me.GroupBox1.Controls.Add(Me.StudentIdLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(821, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطلاعات پرسنلی"
        '
        'EditInfoLinkLabel1
        '
        Me.EditInfoLinkLabel1.AutoSize = True
        Me.EditInfoLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.EditInfoLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EditInfoLinkLabel1.Location = New System.Drawing.Point(57, 39)
        Me.EditInfoLinkLabel1.Name = "EditInfoLinkLabel1"
        Me.EditInfoLinkLabel1.Size = New System.Drawing.Size(40, 13)
        Me.EditInfoLinkLabel1.TabIndex = 2
        Me.EditInfoLinkLabel1.TabStop = True
        Me.EditInfoLinkLabel1.Text = "ویرایش"
        '
        'PersonalIdTExtBox
        '
        Me.PersonalIdTExtBox.Location = New System.Drawing.Point(119, 36)
        Me.PersonalIdTExtBox.Name = "PersonalIdTExtBox"
        Me.PersonalIdTExtBox.ReadOnly = True
        Me.PersonalIdTExtBox.Size = New System.Drawing.Size(100, 21)
        Me.PersonalIdTExtBox.TabIndex = 7
        '
        'PersonalIdLabel
        '
        Me.PersonalIdLabel.AutoSize = True
        Me.PersonalIdLabel.Location = New System.Drawing.Point(225, 39)
        Me.PersonalIdLabel.Name = "PersonalIdLabel"
        Me.PersonalIdLabel.Size = New System.Drawing.Size(39, 13)
        Me.PersonalIdLabel.TabIndex = 6
        Me.PersonalIdLabel.Text = "کدملی"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(270, 36)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.ReadOnly = True
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.LastNameTextBox.TabIndex = 5
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(376, 39)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(65, 13)
        Me.LastNameLabel.TabIndex = 4
        Me.LastNameLabel.Text = "نام خانوادگی"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(451, 36)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.ReadOnly = True
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(557, 39)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(20, 13)
        Me.FirstNameLabel.TabIndex = 2
        Me.FirstNameLabel.Text = "نام"
        '
        'StudentIdTextBox
        '
        Me.StudentIdTextBox.Location = New System.Drawing.Point(583, 36)
        Me.StudentIdTextBox.Name = "StudentIdTextBox"
        Me.StudentIdTextBox.ReadOnly = True
        Me.StudentIdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.StudentIdTextBox.TabIndex = 1
        '
        'StudentIdLabel
        '
        Me.StudentIdLabel.AutoSize = True
        Me.StudentIdLabel.Location = New System.Drawing.Point(689, 36)
        Me.StudentIdLabel.Name = "StudentIdLabel"
        Me.StudentIdLabel.Size = New System.Drawing.Size(89, 13)
        Me.StudentIdLabel.TabIndex = 0
        Me.StudentIdLabel.Text = "شماره دانشجویی"
        '
        'AvailableCoursesGroupBox
        '
        Me.AvailableCoursesGroupBox.Controls.Add(Me.AvailableCoursesDataGridView)
        Me.AvailableCoursesGroupBox.Controls.Add(Me.AddToListButton)
        Me.AvailableCoursesGroupBox.Controls.Add(Me.CourseCategoryComboBox)
        Me.AvailableCoursesGroupBox.Controls.Add(Me.CourseCategory)
        Me.AvailableCoursesGroupBox.Location = New System.Drawing.Point(363, 155)
        Me.AvailableCoursesGroupBox.Name = "AvailableCoursesGroupBox"
        Me.AvailableCoursesGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AvailableCoursesGroupBox.Size = New System.Drawing.Size(470, 328)
        Me.AvailableCoursesGroupBox.TabIndex = 1
        Me.AvailableCoursesGroupBox.TabStop = False
        Me.AvailableCoursesGroupBox.Text = "لیست دروس ارائه شده"
        '
        'AvailableCoursesDataGridView
        '
        Me.AvailableCoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvailableCoursesDataGridView.Location = New System.Drawing.Point(81, 63)
        Me.AvailableCoursesDataGridView.Name = "AvailableCoursesDataGridView"
        Me.AvailableCoursesDataGridView.Size = New System.Drawing.Size(378, 225)
        Me.AvailableCoursesDataGridView.TabIndex = 4
        '
        'AddToListButton
        '
        Me.AddToListButton.Location = New System.Drawing.Point(8, 148)
        Me.AddToListButton.Name = "AddToListButton"
        Me.AddToListButton.Size = New System.Drawing.Size(67, 23)
        Me.AddToListButton.TabIndex = 3
        Me.AddToListButton.Text = "==>"
        Me.AddToListButton.UseVisualStyleBackColor = True
        '
        'CourseCategoryComboBox
        '
        Me.CourseCategoryComboBox.FormattingEnabled = True
        Me.CourseCategoryComboBox.Location = New System.Drawing.Point(228, 39)
        Me.CourseCategoryComboBox.Name = "CourseCategoryComboBox"
        Me.CourseCategoryComboBox.Size = New System.Drawing.Size(201, 21)
        Me.CourseCategoryComboBox.TabIndex = 1
        '
        'CourseCategory
        '
        Me.CourseCategory.AutoSize = True
        Me.CourseCategory.Location = New System.Drawing.Point(435, 42)
        Me.CourseCategory.Name = "CourseCategory"
        Me.CourseCategory.Size = New System.Drawing.Size(27, 13)
        Me.CourseCategory.TabIndex = 0
        Me.CourseCategory.Text = "گروه"
        '
        'SelectedCoursesGroupBox
        '
        Me.SelectedCoursesGroupBox.Controls.Add(Me.ShowReportButton)
        Me.SelectedCoursesGroupBox.Controls.Add(Me.FinalEnterButton)
        Me.SelectedCoursesGroupBox.Controls.Add(Me.SelectedCoursesListBox)
        Me.SelectedCoursesGroupBox.Controls.Add(Me.RemoveFromListButton)
        Me.SelectedCoursesGroupBox.Location = New System.Drawing.Point(12, 155)
        Me.SelectedCoursesGroupBox.Name = "SelectedCoursesGroupBox"
        Me.SelectedCoursesGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SelectedCoursesGroupBox.Size = New System.Drawing.Size(335, 328)
        Me.SelectedCoursesGroupBox.TabIndex = 0
        Me.SelectedCoursesGroupBox.TabStop = False
        Me.SelectedCoursesGroupBox.Text = "دروس انتخاب شده"
        '
        'ShowReportButton
        '
        Me.ShowReportButton.Location = New System.Drawing.Point(238, 206)
        Me.ShowReportButton.Name = "ShowReportButton"
        Me.ShowReportButton.Size = New System.Drawing.Size(67, 23)
        Me.ShowReportButton.TabIndex = 7
        Me.ShowReportButton.Text = "چاپ"
        Me.ShowReportButton.UseVisualStyleBackColor = True
        '
        'FinalEnterButton
        '
        Me.FinalEnterButton.Location = New System.Drawing.Point(238, 177)
        Me.FinalEnterButton.Name = "FinalEnterButton"
        Me.FinalEnterButton.Size = New System.Drawing.Size(67, 23)
        Me.FinalEnterButton.TabIndex = 6
        Me.FinalEnterButton.Text = "ثبت نهایی"
        Me.FinalEnterButton.UseVisualStyleBackColor = True
        '
        'SelectedCoursesListBox
        '
        Me.SelectedCoursesListBox.FormattingEnabled = True
        Me.SelectedCoursesListBox.Location = New System.Drawing.Point(27, 63)
        Me.SelectedCoursesListBox.Name = "SelectedCoursesListBox"
        Me.SelectedCoursesListBox.Size = New System.Drawing.Size(201, 225)
        Me.SelectedCoursesListBox.TabIndex = 5
        '
        'RemoveFromListButton
        '
        Me.RemoveFromListButton.Location = New System.Drawing.Point(238, 148)
        Me.RemoveFromListButton.Name = "RemoveFromListButton"
        Me.RemoveFromListButton.Size = New System.Drawing.Size(67, 23)
        Me.RemoveFromListButton.TabIndex = 5
        Me.RemoveFromListButton.Text = "<=="
        Me.RemoveFromListButton.UseVisualStyleBackColor = True
        '
        'TermInfoLabel
        '
        Me.TermInfoLabel.AutoSize = True
        Me.TermInfoLabel.Font = New System.Drawing.Font("B Titr", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TermInfoLabel.ForeColor = System.Drawing.Color.Sienna
        Me.TermInfoLabel.Location = New System.Drawing.Point(412, 32)
        Me.TermInfoLabel.Name = "TermInfoLabel"
        Me.TermInfoLabel.Size = New System.Drawing.Size(0, 37)
        Me.TermInfoLabel.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 495)
        Me.Controls.Add(Me.TermInfoLabel)
        Me.Controls.Add(Me.SelectedCoursesGroupBox)
        Me.Controls.Add(Me.AvailableCoursesGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.AvailableCoursesGroupBox.ResumeLayout(False)
        Me.AvailableCoursesGroupBox.PerformLayout()
        CType(Me.AvailableCoursesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectedCoursesGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PersonalIdTExtBox As System.Windows.Forms.TextBox
    Friend WithEvents PersonalIdLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents StudentIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentIdLabel As System.Windows.Forms.Label
    Friend WithEvents AvailableCoursesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SelectedCoursesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AddToListButton As System.Windows.Forms.Button
    Friend WithEvents AvailableCoursesCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents CourseCategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CourseCategory As System.Windows.Forms.Label
    Friend WithEvents SelectedCoursesCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents RemoveFromListButton As System.Windows.Forms.Button
    Friend WithEvents AvailableCoursesListBox As System.Windows.Forms.ListBox
    Friend WithEvents SelectedCoursesListBox As System.Windows.Forms.ListBox
    Friend WithEvents ShowReportButton As System.Windows.Forms.Button
    Friend WithEvents FinalEnterButton As System.Windows.Forms.Button
    Friend WithEvents AvailableCoursesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EditInfoLinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TermInfoLabel As System.Windows.Forms.Label
End Class
