<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StiReport1 = New Stimulsoft.Report.StiReport()
        Me.StiViewerControl1 = New Stimulsoft.Report.Viewer.StiViewerControl()
        Me.SuspendLayout()
        '
        'StiReport1
        '
        Me.StiReport1.CookieContainer = Nothing
        Me.StiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2
        Me.StiReport1.ReferencedAssemblies = New String() {"System.Dll", "System.Drawing.Dll", "System.Windows.Forms.Dll", "System.Data.Dll", "System.Xml.Dll", "Stimulsoft.Controls.Dll", "Stimulsoft.Base.Dll", "Stimulsoft.Report.Dll"}
        Me.StiReport1.ReportAlias = "Report"
        Me.StiReport1.ReportGuid = "f354330eca634a6fa579798168569c60"
        Me.StiReport1.ReportName = "Report"
        Me.StiReport1.ReportSource = Nothing
        Me.StiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches
        Me.StiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp
        Me.StiReport1.UseProgressInThread = False
        '
        'StiViewerControl1
        '
        Me.StiViewerControl1.AllowDrop = True
        Me.StiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StiViewerControl1.Location = New System.Drawing.Point(0, 0)
        Me.StiViewerControl1.Name = "StiViewerControl1"
        Me.StiViewerControl1.Report = Me.StiReport1
        Me.StiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StiViewerControl1.ShowZoom = True
        Me.StiViewerControl1.Size = New System.Drawing.Size(803, 473)
        Me.StiViewerControl1.TabIndex = 0
        '
        'CourseSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 473)
        Me.Controls.Add(Me.StiViewerControl1)
        Me.Name = "CourseSchedule"
        Me.Text = "برنامه هفتگی"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents StiReport1 As Stimulsoft.Report.StiReport
    Friend WithEvents StiViewerControl1 As Stimulsoft.Report.Viewer.StiViewerControl
End Class
