<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CurrentMonthPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PayRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CelestialPayRollDatabaseDataSet5 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet5()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PayRecordTableAdapter = New CelestialPayRoll.CelestialPayRollDatabaseDataSet5TableAdapters.PayRecordTableAdapter()
        CType(Me.PayRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CelestialPayRollDatabaseDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PayRecordBindingSource
        '
        Me.PayRecordBindingSource.DataMember = "PayRecord"
        Me.PayRecordBindingSource.DataSource = Me.CelestialPayRollDatabaseDataSet5
        '
        'CelestialPayRollDatabaseDataSet5
        '
        Me.CelestialPayRollDatabaseDataSet5.DataSetName = "CelestialPayRollDatabaseDataSet5"
        Me.CelestialPayRollDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PayRecordBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CelestialPayRoll.CurrentMonthPayment.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'PayRecordTableAdapter
        '
        Me.PayRecordTableAdapter.ClearBeforeFill = True
        '
        'CurrentMonthPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CurrentMonthPayment"
        Me.ShowIcon = False
        Me.Text = "Current Month Payment"
        CType(Me.PayRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CelestialPayRollDatabaseDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PayRecordBindingSource As BindingSource
    Friend WithEvents CelestialPayRollDatabaseDataSet5 As CelestialPayRollDatabaseDataSet5
    Friend WithEvents PayRecordTableAdapter As CelestialPayRollDatabaseDataSet5TableAdapters.PayRecordTableAdapter
End Class
