<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllPaymentForm
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CelestialPayRollDatabaseDataSet1 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet1()
        Me.PayRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayRecordsTableAdapter = New CelestialPayRoll.CelestialPayRollDatabaseDataSet1TableAdapters.PayRecordsTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CelestialPayRollDatabaseDataSet5 = New CelestialPayRoll.CelestialPayRollDatabaseDataSet5()
        Me.PayRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayRecordTableAdapter = New CelestialPayRoll.CelestialPayRollDatabaseDataSet5TableAdapters.PayRecordTableAdapter()
        CType(Me.CelestialPayRollDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CelestialPayRollDatabaseDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CelestialPayRollDatabaseDataSet1
        '
        Me.CelestialPayRollDatabaseDataSet1.DataSetName = "CelestialPayRollDatabaseDataSet1"
        Me.CelestialPayRollDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayRecordsBindingSource
        '
        Me.PayRecordsBindingSource.DataMember = "PayRecords"
        Me.PayRecordsBindingSource.DataSource = Me.CelestialPayRollDatabaseDataSet1
        '
        'PayRecordsTableAdapter
        '
        Me.PayRecordsTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PayRecordBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CelestialPayRoll.AllPayment.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'CelestialPayRollDatabaseDataSet5
        '
        Me.CelestialPayRollDatabaseDataSet5.DataSetName = "CelestialPayRollDatabaseDataSet5"
        Me.CelestialPayRollDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayRecordBindingSource
        '
        Me.PayRecordBindingSource.DataMember = "PayRecord"
        Me.PayRecordBindingSource.DataSource = Me.CelestialPayRollDatabaseDataSet5
        '
        'PayRecordTableAdapter
        '
        Me.PayRecordTableAdapter.ClearBeforeFill = True
        '
        'AllPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "AllPaymentForm"
        Me.ShowIcon = False
        Me.Text = "All Payment "
        CType(Me.CelestialPayRollDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CelestialPayRollDatabaseDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PayRecordsBindingSource As BindingSource
    Friend WithEvents CelestialPayRollDatabaseDataSet1 As CelestialPayRollDatabaseDataSet1
    Friend WithEvents PayRecordsTableAdapter As CelestialPayRollDatabaseDataSet1TableAdapters.PayRecordsTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PayRecordBindingSource As BindingSource
    Friend WithEvents CelestialPayRollDatabaseDataSet5 As CelestialPayRollDatabaseDataSet5
    Friend WithEvents PayRecordTableAdapter As CelestialPayRollDatabaseDataSet5TableAdapters.PayRecordTableAdapter
End Class
