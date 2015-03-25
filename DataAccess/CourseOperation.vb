Imports System.Configuration
Imports System.Data.SqlClient

Public Class CourseOperation
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

    Public Function GetAllCoursesByCategory(categoryName As String) As DataTable
        _dataTable = New DataTable("Course")
        Const cmdText As String = "SELECT CourseId,CourseName,CategoryName FROM Course join Category on Category.CategoryId = Course.CategoryId and Category.Categoryname = @CategoryName"
        _cmd = SetSqlCommand(cmdText)
        _cmd.Parameters.Add("CategoryName", SqlDbType.NVarChar)
        _cmd.Parameters("CategoryName").Value = categoryName
        _sqlAdapter = New SqlDataAdapter(_cmd)
        _sqlAdapter.Fill(_dataTable)
        Return _dataTable
    End Function
    Public Function GetAllCoursesByCategoryAsEnumerable() As DataTable
        _dataTable = New DataTable("Course")
        Const cmdText As String = "SELECT * FROM Course,Category WHERE Course.CategoryId = Category.CategoryId"
        _cmd = SetSqlCommand(cmdText)
        _sqlAdapter = New SqlDataAdapter(_cmd)
        _sqlAdapter.Fill(_dataTable)
        Return _dataTable
    End Function

    Public Function GetAllCourses() As DataTable
        _dataTable = New DataTable("Course")
        Const cmdText As String = "SELECT CourseId,CourseName,CategoryId FROM Course"
        _cmd = SetSqlCommand(cmdText)
        _sqlAdapter = New SqlDataAdapter(_cmd)
        _sqlAdapter.Fill(_dataTable)
        Return _dataTable
    End Function
End Class
