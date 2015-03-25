Imports System.Configuration
Imports System.Data.SqlClient

Public Class TakedCourseOperation
    Dim _cmd As SqlCommand
    Dim _sqlAdapter As SqlDataAdapter
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

    Public Sub AddCourse(ByVal id As Integer, ByVal studentId As Integer, ByVal courseId As Integer, ByVal termName As String)
        Const cmdText As String = "INSERT INTO TakedCourse (Id,StudentId,CourseId,termName) VALUES (@id,@StudentId,@CourseId,@termName)"
        _cmd = SetSqlCommand(cmdText)

        _cmd.Parameters.Add("id", SqlDbType.Int)
        _cmd.Parameters("id").Value = id
        _cmd.Parameters.Add("studentId", SqlDbType.Int)
        _cmd.Parameters("studentId").Value = studentId
        _cmd.Parameters.Add("courseId", SqlDbType.Int)
        _cmd.Parameters("courseId").Value = courseId
        _cmd.Parameters.Add("termName", SqlDbType.NVarChar)
        _cmd.Parameters("termName").Value = termName

        _cmd.Connection.Open()

        _cmd.ExecuteNonQuery()
    End Sub

    Public Function LoadCoursesForReport(studentId As Integer) As DataTable
        Dim takedCourseDt As New DataTable("takedCourseTable")
        Const cmdText As String = "SELECT c.CourseId,c.CourseName,s.StudentId,s.FirstName,s.LastName,tk.TermName FROM Course c INNER JOIN TakedCourse tk ON  c.CourseId = tk.CourseId JOIN Student s ON tk.StudentId = s.StudentId WHERE s.StudentId = @studentId"
        _cmd = SetSqlCommand(cmdText)
        _cmd.Parameters.Add("studentId", SqlDbType.Int)
        _cmd.Parameters("studentId").Value = studentId
        _sqlAdapter = New SqlDataAdapter(_cmd)
        _sqlAdapter.Fill(takedCourseDt)
        Return takedCourseDt
    End Function
    
End Class
