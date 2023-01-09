Public Class FormReporteTrabajos
    Private Sub FormReporteTrabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCanceleriaVelazquezDataSet.ClientesTrabajos' table. You can move, or remove it, as needed.
        Me.ClientesTrabajosTableAdapter.Fill(Me.DBCanceleriaVelazquezDataSet.ClientesTrabajos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class