Imports DataAccess
Imports DomainModel

Public Class EditInfoForm
    Private ReadOnly _studentOperation As New StudentOperation
    Private Sub EditInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserInfo()
    End Sub
    Private Sub LoadUserInfo()
        StudentIdTextBox.Text = My.Settings.UserInfo.StudentId.ToString()
        FirstNameTextBox.Text = My.Settings.UserInfo.FirstName
        LastNameTextBox.Text = My.Settings.UserInfo.LastName
        PersonalIdTExtBox.Text = My.Settings.UserInfo.PersoanlId.ToString()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            Dim stu As New Student
            stu.StudentId = Integer.Parse(StudentIdTextBox.Text)
            stu.FirstName = FirstNameTextBox.Text
            stu.LastName = LastNameTextBox.Text
            stu.PersoanlId = PersonalIdTExtBox.Text
            _studentOperation.EditStudent(Integer.Parse(_StudentIdTextBox.Text), stu)
            MsgBox("اطلاعات با موفقیت ویرایش شد")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class