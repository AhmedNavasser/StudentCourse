Imports System.Configuration
Imports System.Data.SqlClient

Public Class CategoryOperation
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

    Public Function GetAllCategories() As DataTable
        _dataTable = New DataTable("Category")
        Const cmdText As String = "SELECT * FROM Category"
        _cmd = SetSqlCommand(cmdText)
        _sqlAdapter = New SqlDataAdapter(_cmd)
        _sqlAdapter.Fill(_dataTable)
        Return _dataTable
    End Function
End Class
