Imports System.Configuration
Imports System.Data.SqlClient
Imports DomainModel

Public Class StudentOperation
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

    Public Function GetStudent(ByVal studentId As Integer) As Student
        Dim stu As New Student

        Const cmdText As String = "SELECT * FROM Student WHERE  StudentId = @StudentId "
        _cmd = SetSqlCommand(cmdText)
        _cmd.Parameters.Add("StudentId", SqlDbType.Int)
        _cmd.Parameters("StudentId").Value = studentId

        _cmd.Connection.Open()

        Dim reader As SqlDataReader = _cmd.ExecuteReader()

        If reader.Read() Then
            stu.StudentId = Integer.Parse(reader("StudentId").ToString())
            stu.FirstName = reader("FirstName").ToString()
            stu.LastName = reader("LastName").ToString()
            stu.PersoanlId = Int64.Parse(reader("PersonalId").ToString())
        End If
        _cmd.Connection.Close()
        Return stu
    End Function

    Public Function GetAllStudents() As DataTable
        _dataTable = New DataTable("Student")
        Const cmdText As String = "SELECT * FROM Student"
        _cmd = SetSqlCommand(cmdText)
        _sqlAdapter = New SqlDataAdapter(_cmd)
        _sqlAdapter.Fill(_dataTable)
        Return _dataTable
    End Function

    Public Sub AddNewStudent(student As Student)
        If Not IsNothing(student) Then
            Const cmdText As String = "INSERT INTO Student (StudentId,FirstName,LastName,PersonalId) VALUES  (@StudentId,@FirstName, @LastName,@PersonalId)"
            _cmd = SetSqlCommand(cmdText)

            _cmd.Parameters.Add("StudentId", SqlDbType.Int)
            _cmd.Parameters("StudentId").Value = student.StudentId

            _cmd.Parameters.Add("FirstName", SqlDbType.NVarChar)
            _cmd.Parameters("FirstName").Value = student.FirstName

            _cmd.Parameters.Add("LastName", SqlDbType.NVarChar)
            _cmd.Parameters("LastName").Value = student.LastName

            _cmd.Parameters.Add("PersonalId", SqlDbType.Int)
            _cmd.Parameters("PersonalId").Value = student.PersoanlId
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
        End If
    End Sub
    Public Sub EditStudent(studentId As Integer, student As Student)
        Dim stu As Student = GetStudent(studentId)

        If Not IsNothing(stu) Then
            Const cmdText As String = "UPDATE Student SET  FirstName = @FirstName ,LastName = @LastName, PersonalId = @PersonalId"
            _cmd = SetSqlCommand(cmdText)

            

            _cmd.Parameters.Add("FirstName", SqlDbType.NVarChar)
            _cmd.Parameters("FirstName").Value = student.FirstName

            _cmd.Parameters.Add("LastName", SqlDbType.NVarChar)
            _cmd.Parameters("LastName").Value = student.LastName

            _cmd.Parameters.Add("PersonalId", SqlDbType.Int)
            _cmd.Parameters("PersonalId").Value = student.PersoanlId
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
        End If

    End Sub

    Public Sub EditStudentAsAdmin(student As Student)
        If Not IsNothing(student) Then
            Const cmdText As String = "UPDATE Student SET StudentId = @StudentId ,FirstName = @FirstName ,LastName = @LastName, PersonalId = @PersonalId"
            _cmd = SetSqlCommand(cmdText)

            _cmd.Parameters.Add("StudentId", SqlDbType.Int)
            _cmd.Parameters("StudentId").Value = student.StudentId

            _cmd.Parameters.Add("FirstName", SqlDbType.NVarChar)
            _cmd.Parameters("FirstName").Value = student.FirstName

            _cmd.Parameters.Add("LastName", SqlDbType.NVarChar)
            _cmd.Parameters("LastName").Value = student.LastName

            _cmd.Parameters.Add("PersonalId", SqlDbType.Int)
            _cmd.Parameters("PersonalId").Value = student.PersoanlId
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
        End If

    End Sub
    
    Public Sub DeleteStudent(studentId As Integer)

        Const cmdText As String = "Delete from student where StudentId = @StudentId"
        _cmd = SetSqlCommand(cmdText)

        _cmd.Parameters.Add("StudentId", SqlDbType.Int)
        _cmd.Parameters("StudentId").Value = studentId


        _cmd.Connection.Open()
        _cmd.ExecuteNonQuery()

    End Sub
End Class
