Public Class FormReporteClientes
    Private Sub FormReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCanceleriaVelazquezDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.DBCanceleriaVelazquezDataSet.Clientes)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
    End Sub
End Class