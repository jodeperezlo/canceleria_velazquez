Imports Microsoft.Reporting.WinForms

Public Class FormTicketTrabajo
    Public dsFormTicketTrabajo As DataSet
    Private Sub FormTicketTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCanceleriaVelazquezDataSet.TicketTrabajo' table. You can move, or remove it, as needed.
        TicketTrabajoTableAdapter.Fill(Me.DBCanceleriaVelazquezDataSet.TicketTrabajo)
        Dim rds As New ReportDataSource("dsTicketTrabajo", dsFormTicketTrabajo.Tables(0))
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()
    End Sub
End Class