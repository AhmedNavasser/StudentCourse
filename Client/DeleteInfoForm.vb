Imports DataAccess
Imports DomainModel

Public Class DeleteInfoForm
    Private ReadOnly _studentOperation As New StudentOperation
    Dim _student As New Student
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        _student = _studentOperation.GetStudent(Integer.Parse(StuIdInputTextBox.Text))
        If Not IsNothing(_student) Then
            StudentIdTextBox.Text = _student.StudentId.ToString()
            FirstNameTextBox.Text = _student.FirstName
            LastNameTextBox.Text = _student.LastName
            PersonalIdTExtBox.Text = _student.PersoanlId.ToString()
            DeleteButton.Enabled = True
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            Dim result As MsgBoxResult = MsgBox("آیا مطمئن هستید که میخواهید این رکورد را حذف نمایید", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "اخطار")
            If result = MsgBoxResult.Yes Then
                _studentOperation.DeleteStudent(_student.StudentId)
                MsgBox("عمل حذف با موفقیت انجام شد")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class