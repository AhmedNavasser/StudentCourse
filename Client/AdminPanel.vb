Public Class AdminPanel

    Private Sub AdminPanel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        NewStudentForm.ShowDialog()
    End Sub

    Private Sub EditStudentButtonButton_Click(sender As Object, e As EventArgs) Handles EditStudentButtonButton.Click
        EditStudentInfoAdmin.ShowDialog()
    End Sub

    Private Sub DeleteStudentButton_Click(sender As Object, e As EventArgs) Handles DeleteStudentButton.Click
        DeleteInfoForm.ShowDialog()
    End Sub
End Class