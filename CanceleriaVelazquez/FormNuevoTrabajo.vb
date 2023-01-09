Imports System.Configuration

Public Class FormNuevoTrabajo
    Public dbConnection As New OleDb.OleDbConnection(ConfigurationManager.AppSettings.Get("ConnStringCanceleria"))
    Public codigoCliente As Integer = -1
    Public nombreCliente As String = ""
#Region "Funciones necesarias"
    Private Function ValidaFormulario() As Boolean
        If txtTrabajo.Text.Trim() = "" Then
            MessageBox.Show("El trabajo no puede ir vacío, introduzca el trabajo a realizar.", "Error al intentar guardar - Ingrese el trabajo")
            txtTrabajo.Focus()
            Return False
        ElseIf txtCosto.Text.Trim() = "" Then
            MessageBox.Show("El costo del trabajo no puede ir vacío, introduzca el costo del trabajo.", "Error al intentar guardar - Ingrese el costo")
            txtCosto.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub NumerosyDecimal(CajaTexto As TextBox, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarNuevoTrabajo()
        Try
            dbConnection.Open()
            Dim sql As String = "INSERT INTO Trabajos(Trabajo, Cliente, Costo, FechaTerminacion) VALUES (@Tra, @Cli, @Cost, @FechaTerm)"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Tra", txtTrabajo.Text)
            comando.Parameters.AddWithValue("Cli", codigoCliente)
            comando.Parameters.AddWithValue("Cost", txtCosto.Text)
            comando.Parameters.AddWithValue("FechaTerm", dtpFechaTerminacion.Value)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se agregó el nuevo trabajo correctamente", "Nuevo trabajo guardado")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar el nuevo trabajo: " & ex.Message, "Error al guardar trabajo")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub Salir()
        codigoCliente = -1
        nombreCliente = ""
        Close()
    End Sub

#End Region


    Private Sub FormNuevoTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCliente.Text = nombreCliente
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Salir()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidaFormulario() Then
            If MessageBox.Show("¿Está seguro de querer agregar el nuevo registro?", "Confirmación para guardar", MessageBoxButtons.YesNo) = vbYes Then
                GuardarNuevoTrabajo()
                Salir()
            End If
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        NumerosyDecimal(txtCosto, e)
    End Sub
End Class