Public Class FormPrincipal
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        FormClientes.Show()
    End Sub

    Private Sub btnMaterial_Click(sender As Object, e As EventArgs) Handles btnMaterial.Click

    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        FormProveedores.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormTrabajos.Show()
    End Sub
End Class
