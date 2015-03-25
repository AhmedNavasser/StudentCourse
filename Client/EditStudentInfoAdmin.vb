Imports DataAccess
Imports DomainModel

Public Class EditStudentInfoAdmin
    Private ReadOnly _studentOperation As New StudentOperation
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim student = _studentOperation.GetStudent(Integer.Parse(StuIdInputTextBox.Text))
        If Not IsNothing(student) Then
            StudentIdTextBox.Text = student.StudentId.ToString()
            FirstNameTextBox.Text = student.FirstName
            LastNameTextBox.Text = student.LastName
            PersonalIdTExtBox.Text = student.PersoanlId.ToString()
            EditButton.Enabled = True
        End If

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            Dim stu As New Student
            stu.StudentId = Integer.Parse(StudentIdTextBox.Text)
            stu.FirstName = FirstNameTextBox.Text
            stu.LastName = LastNameTextBox.Text
            stu.PersoanlId = PersonalIdTExtBox.Text
            _studentOperation.EditStudentAsAdmin(stu)
            MsgBox("اطلاعات با موفقیت ویرایش شد")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class