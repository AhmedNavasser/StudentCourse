Imports System.Configuration
Imports System.Data.SqlClient
Imports DomainModel

Public Class TermInfoOperation
    Dim _cmd As SqlCommand
    Dim _sqlAdapter As SqlDataAdapter
    Dim _dataTable As DataTable

    Private Function GetConnectionString() As String
        Dim connectionString = ConfigurationManager.ConnectionStrings("CourseDbConnection").ConnectionString
        Return connectionString
    End Function

    Private Function SetSqlCommand(ByVal commandText As String) As SqlCommand
        _cmd = New SqlCommand()
        _cmd.Connection = New SqlConnection(GetConnectionString())
        _cmd.CommandType = CommandType.Text
        _cmd.CommandText = commandText
        Return _cmd
    End Function

    Public Function GetTermInfo() As DataTable
        _dataTable = New DataTable("Term")
        Const cmdText As String = "Select TermId,TermName from Term"
        _cmd = SetSqlCommand(cmdText)
        _sqlAdapter = New SqlDataAdapter(_cmd)
        _sqlAdapter.Fill(_dataTable)
        Return _dataTable
    End Function

    Public Sub AddStudentToTermInfo(ByVal studentId As Integer)
        Const cmdText As String = "insert into StudentTerm (StudentId,TermId)  select Student.StudentId,Term.TermId from Student,Term where Student.StudentId = @StudentId"
        _cmd = SetSqlCommand(cmdText)

        _cmd.Parameters.Add("StudentId", SqlDbType.Int)
        _cmd.Parameters("StudentId").Value = studentId
        _cmd.Connection.Open()
        _cmd.ExecuteNonQuery()
        _cmd.Connection.Close()
    End Sub
End Class
