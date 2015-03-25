Imports Client.Infrastructure
Imports DataAccess
Imports DomainModel

Public Class MainForm
    ''' <summary>
    ''' 'تعریف اشیا کلاسهای عملیاتی برای کار بر روی جدولهای مختلف
    ''' </summary>
    ''' <remarks></remarks>
    Private ReadOnly _categoryOperation As New CategoryOperation
    Private ReadOnly _courseOperation As New CourseOperation
    Private ReadOnly _takedCourseOperation As New TakedCourseOperation
    Private ReadOnly _termInfoOperation As New TermInfoOperation

    'تعریف یک لیست از یک شی کورس. از این لیست برای لود کردن کل دروس در حافظه استفاده می شود
    Private ReadOnly _allCourseListEnumerable As New List(Of CustomizedCourse)
    Dim _customCourse As CustomizedCourse
    'تعریف یک دیکشنری برای دروس انتخاب شده توسط دانشجو
    Private ReadOnly _selectedCourseList As New Dictionary(Of Integer, CustomizedCourse)
    Private _courseToAdd As CustomizedCourse
    Private _courseToRemove As CustomizedCourse
    ReadOnly _term As New Term


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserInfo()
        LoadTermInfo()
        LoadCategories()
        LoadCustomCoursesAsEnumerable()
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    ''' <summary>
    ''' لود کردن اطلاعات یک ترم شامل کد و عنوان ترم
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTermInfo()

        Dim termDataTable = _termInfoOperation.GetTermInfo()

        For Each row As DataRow In termDataTable.Rows
            _term.TermId = row("TermId")
            _term.TermName = row("TermName")
        Next
        TermInfoLabel.Text = "ترم" + _term.TermName
    End Sub
    ''' <summary>
    ''' لود کردن اطلاعات یک دانشجو و ذخیره آنها در تنظیمات برنامه
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadUserInfo()
        StudentIdTextBox.Text = My.Settings.UserInfo.StudentId.ToString()
        FirstNameTextBox.Text = My.Settings.UserInfo.FirstName
        LastNameTextBox.Text = My.Settings.UserInfo.LastName
        PersonalIdTExtBox.Text = My.Settings.UserInfo.PersoanlId.ToString()
    End Sub
    ''' <summary>
    ''' لود کردن گروههای درسی و پر کردن کومبوباکس
    ''' و با هر بار انتخاب یک مورد از کومبوباکس دیتا گرید با فیلدهای مربوط به دروس پرمیشود 
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadCategories()
        Dim categoryDataTable As DataTable
        categoryDataTable = _categoryOperation.GetAllCategories()

        For Each row As DataRow In categoryDataTable.Rows
            CourseCategoryComboBox.Items.Add(row(1))
        Next
    End Sub
    ''' <summary>
    ''' لود کردن تمام دروس ارائه شده در حافظه برای جلوگیری از هدر رفتن زمان برای کوئری داده های 
    ''' متعدد به پایگاه داده
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadCustomCoursesAsEnumerable()
        Dim allCustomCoursesTable As DataTable

        allCustomCoursesTable = _courseOperation.GetAllCoursesByCategoryAsEnumerable()
        For Each dataRow As DataRow In allCustomCoursesTable.Rows
            _customCourse = New CustomizedCourse()
            _customCourse.CourseId = dataRow("CourseId")
            _customCourse.CourseName = dataRow("CourseName")
            _customCourse.CategoryId = dataRow("CategoryId")
            _customCourse.CategoryName = dataRow("CategoryName")
            _allCourseListEnumerable.Add(_customCourse)
        Next
    End Sub
    ''' <summary>
    ''' لود کردن دروس بر اساس گروه
    ''' هر گروه از کومبوباکس انتخاب شده و لیست دروس آن در دیتا گرید قرار می گیرد
    ''' </summary>
    ''' <param name="categoryName"></param>
    ''' <remarks></remarks>
    Private Sub LoadCourses(ByVal categoryName As String)
        Try
            Dim s = _allCourseListEnumerable.Where(Function(c) c.CategoryName = categoryName).Select(Function(p) p)
            _AvailableCoursesDataGridView.DataSource = s.ToList()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CourseCategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CourseCategoryComboBox.SelectedIndexChanged
        LoadCourses(CourseCategoryComboBox.SelectedItem.ToString())
    End Sub


    Private Sub AddToListButton_Click(sender As Object, e As EventArgs) Handles AddToListButton.Click
        Try
            _selectedCourseList.Add(_courseToAdd.CourseId, _courseToAdd)
            SelectedCoursesListBox.Items.Add(_courseToAdd.CourseName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditInfoLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles EditInfoLinkLabel1.LinkClicked
        EditInfoForm.ShowDialog()
    End Sub

    Private Sub AvailableCoursesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AvailableCoursesDataGridView.CellClick
        _courseToAdd = New CustomizedCourse()
        _courseToAdd.CourseId = Integer.Parse(AvailableCoursesDataGridView.CurrentRow.Cells(0).Value.ToString())
        _courseToAdd.CourseName = AvailableCoursesDataGridView.CurrentRow.Cells(1).Value
        _courseToAdd.CategoryId = AvailableCoursesDataGridView.CurrentRow.Cells(2).Value
        _courseToAdd.CategoryName = AvailableCoursesDataGridView.CurrentRow.Cells(3).Value
    End Sub

    ''' <summary>
    ''' حذف یک درس از دروس انتخابی
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RemoveFromListButton_Click(sender As Object, e As EventArgs) Handles RemoveFromListButton.Click
        Try
            Dim courseTitle As String = SelectedCoursesListBox.SelectedItem
            _courseToRemove = New CustomizedCourse()
            _courseToRemove = _allCourseListEnumerable.SingleOrDefault(Function(c) c.CourseName = courseTitle)

            If _selectedCourseList.ContainsKey(_courseToRemove.CourseId) Then
                _selectedCourseList.Remove(_courseToRemove.CourseId)
            End If

            SelectedCoursesListBox.Items.Remove(courseTitle)
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' ثبت درس به صورت نهایی در پایگاه داده
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FinalEnterButton_Click(sender As Object, e As EventArgs) Handles FinalEnterButton.Click
        Try
            For i As Integer = 0 To _selectedCourseList.Count - 1
                _courseToAdd = New CustomizedCourse()
                _courseToAdd = _selectedCourseList.Values(i)
                _takedCourseOperation.AddCourse(i + Integer.Parse(My.Settings.UserInfo.StudentId), Integer.Parse(My.Settings.UserInfo.StudentId), _courseToAdd.CourseId, _term.TermName)

            Next
            MsgBox("ثبت دروس با موفقیت انجام شد")
            _FinalEnterButton.Enabled = False
            AddToListButton.Enabled = False
            RemoveFromListButton.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowReportButton_Click(sender As Object, e As EventArgs) Handles ShowReportButton.Click
        CourseSchedule.ShowDialog()
    End Sub
End Class