Public Class FormReporteComprasAProveedor
    Private Sub FormReporteComprasAProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCanceleriaVelazquezDataSet.ReporteComprasAProveedor' table. You can move, or remove it, as needed.
        Me.ReporteComprasAProveedorTableAdapter.Fill(Me.DBCanceleriaVelazquezDataSet.ReporteComprasAProveedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class