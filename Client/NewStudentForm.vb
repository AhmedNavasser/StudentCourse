Imports DataAccess
Imports DomainModel

Public Class NewStudentForm
    Private ReadOnly _studentOperation As New StudentOperation
    Private ReadOnly _termInfoOperation As New TermInfoOperation
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            Dim stu As New Student
            stu.StudentId = Integer.Parse(StudentIdTextBox.Text)
            stu.FirstName = FirstNameTextBox.Text
            stu.LastName = LastNameTextBox.Text
            stu.PersoanlId = Integer.Parse(PersonalIdTExtBox.Text)
            _studentOperation.AddNewStudent(stu)
            _termInfoOperation.AddStudentToTermInfo(stu.StudentId)
            MsgBox("دانشجو با موفقیت ثبت گردید")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class