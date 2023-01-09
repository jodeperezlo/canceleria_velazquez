Public Class FormReporteProveedores
    Private Sub FormReporteProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCanceleriaVelazquezDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.DBCanceleriaVelazquezDataSet.Clientes)
        'TODO: This line of code loads data into the 'DBCanceleriaVelazquezDataSet.Proveedores' table. You can move, or remove it, as needed.
        Me.ProveedoresTableAdapter.Fill(Me.DBCanceleriaVelazquezDataSet.Proveedores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class