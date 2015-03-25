Imports DataAccess
Imports Stimulsoft.Report.Win
Public Class CourseSchedule
    Private ReadOnly _takedCourseOperation As New TakedCourseOperation
    Private Sub CourseSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim takedCourseDt = _takedCourseOperation.LoadCoursesForReport(Integer.Parse(My.Settings.UserInfo.StudentId))
        Dim reportPath = Environment.CurrentDirectory + "\Report.mrt"
        StiReport1.Load(reportPath)
        StiReport1.RegData("TakedCourseDT", takedCourseDt)
        StiReport1.Show()
    End Sub
End Class