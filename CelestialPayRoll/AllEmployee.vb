Public Class AllEmployee
    Private Sub AllEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.CelestialPayRollDatabaseDataSet.Employee)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class