Imports DataAccess
Imports DomainModel


Public Class LoginForm
    Private ReadOnly _operation As New StudentOperation

    Public Sub SetDomain()
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.CurrentDirectory)
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDomain()
    End Sub
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Try
            Dim student As Student
            student = _operation.GetStudent(Integer.Parse(_studentIdTextBox.Text))
            If student.StudentId = _studentIdTextBox.Text And student.PersoanlId = _personalIdTextBox.Text Then
                My.Settings.UserInfo = student
                My.Settings.Save()
                Hide()
                MainForm.ShowDialog()

            Else
                MsgBox("اطلاعات وارد شده صحیح نمیباشد. لطفاً ورودی های خود را مجدداً بررسی نمایید")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AdminLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AdminLinkLabel.LinkClicked
        Hide()
        AdminLogin.ShowDialog()
    End Sub
End Class
