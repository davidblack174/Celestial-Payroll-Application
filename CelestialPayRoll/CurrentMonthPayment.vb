Public Class CurrentMonthPayment
    Private Sub CurrentMonthPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CelestialPayRollDatabaseDataSet5.PayRecord' table. You can move, or remove it, as needed.
        Me.PayRecordTableAdapter.Fill(Me.CelestialPayRollDatabaseDataSet5.PayRecord)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class