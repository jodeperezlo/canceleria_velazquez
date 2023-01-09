Imports System.Configuration

Public Class FormClientes
    Public dbConnection As New OleDb.OleDbConnection(ConfigurationManager.AppSettings.Get("ConnStringCanceleria"))
    Private accion As Integer = 0 '1: Nuevo, 2: Actualiza
    Private selectedRowIndex As Integer = -1
#Region "Funciones necesarias"
    Private Sub CargarDataGridView()
        Try
            dbConnection.Open()
            Dim query As String = "SELECT Codigo, Nombre, Telefono, Domicilio FROM Clientes"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvClientes.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información de los: " & ex.Message, "Error")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub DefinirButtonBackColor(btn As Button)
        If btn.Enabled Then
            btn.BackColor = Color.FromArgb(250, 253, 255)
        Else
            btn.BackColor = Color.FromArgb(200, 200, 200)
        End If
    End Sub
    Private Sub EnabledTextBox(enabled As Boolean)
        txtNombre.Enabled = enabled
        txtDomicilio.Enabled = enabled
        txtTelefono.Enabled = enabled
    End Sub

    Private Sub LimpiaTextBox()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
    End Sub

    Private Sub EnabledButtons(botonNuevo As Boolean, botonGuardar As Boolean, botonActualizar As Boolean, botonEliminar As Boolean, botonCancelar As Boolean)
        btnNuevo.Enabled = botonNuevo
        btnGuardar.Enabled = botonGuardar
        btnEditar.Enabled = botonActualizar
        btnEliminar.Enabled = botonEliminar
        btnCancelar.Enabled = botonCancelar
    End Sub

    Private Sub GuardaNuevo()
        Try
            dbConnection.Open()
            Dim sql As String = "INSERT INTO Clientes(Nombre, Telefono, Domicilio) VALUES (@Nom, @Tel, @Dom)"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Nom", txtNombre.Text)
            comando.Parameters.AddWithValue("Tel", txtTelefono.Text)
            comando.Parameters.AddWithValue("Dom", txtDomicilio.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se agregó el nuevo cliente correctamente", "Nuevo cliente guardado")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar el nuevo cliente: " & ex.Message, "Error al guardar cliente")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub ActualizaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "UPDATE Clientes SET Nombre = @Nom, Telefono = @Tel, Domicilio = @Dom WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Nom", txtNombre.Text)
            comando.Parameters.AddWithValue("Tel", txtTelefono.Text)
            comando.Parameters.AddWithValue("Dom", txtDomicilio.Text)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se actualizó el cliente correctamente", "Cliente actualizado")
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar la información del cliente: " & ex.Message, "Error al actualizar cliente")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub EliminaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "DELETE FROM Clientes WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se eliminó al cliente correctamente", "Cliente eliminado")
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar la información del cliente: " & ex.Message, "Error al eliminar el cliente")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub SelectRowChanged(rowIndex)
        Dim FilaActual As Integer
        FilaActual = rowIndex
        selectedRowIndex = FilaActual
        txtCodigo.Text = dgvClientes.Rows(FilaActual).Cells(0).Value
        txtNombre.Text = dgvClientes.Rows(FilaActual).Cells(1).Value
        txtTelefono.Text = dgvClientes.Rows(FilaActual).Cells(2).Value
        txtDomicilio.Text = dgvClientes.Rows(FilaActual).Cells(3).Value
        EnabledButtons(False, False, True, True, True)
        btnNuevoTrabajo.Enabled = True
    End Sub
    Private Function ValidaFormulario() As Boolean
        If txtNombre.Text.Trim() = "" Then
            MessageBox.Show("El nombre no puede ir vacío, introduzca el nombre.", "Error al intentar guardar - Ingrese el nombre")
            txtNombre.Focus()
            Return False
        ElseIf txtTelefono.Text.Trim() = "" Then
            MessageBox.Show("El teléfono no puede ir vacío, introduzca el número de teléfono.", "Error al intentar guardar - Ingrese el teléfono")
            txtTelefono.Focus()
            Return False
        ElseIf txtDomicilio.Text.Trim() = "" Then
            MessageBox.Show("El domicilio no puede ir vacío, introduzca el domicilio.", "Error al intentar guardar - Ingrese el domicilio")
            txtDomicilio.Focus()
            Return False
        ElseIf txtNombre.Text.Trim().Length < 2 Then
            MessageBox.Show("El nombre debe de tener al menos 2 caracteres para ser un nombre válido.", "Error al intentar guardar - Nombre no válido")
            txtNombre.Focus()
            Return False
        ElseIf txtTelefono.Text.Trim().Length < 10 Then
            MessageBox.Show("El teléfono debe de tener al menos 10 caracteres para ser un teléfono válido.", "Error al intentar guardar - Telefono no válido")
            txtTelefono.Focus()
            Return False
        ElseIf txtDomicilio.Text.Trim().Length < 4 Then
            MessageBox.Show("El domicilio es muy corto, ingrese un domicilio válido.", "Error al intentar guardar - Domicilio no válido")
            txtDomicilio.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ReseteaTodo()
        EnabledTextBox(False)
        EnabledButtons(True, False, False, False, False)
        LimpiaTextBox()
        btnSiguiente.Enabled = True
        btnAnterior.Enabled = False
        selectedRowIndex = -1
        dgvClientes.ClearSelection()
        dgvClientes.Enabled = True
        btnNuevoTrabajo.Enabled = False
        btnReporteClientes.Enabled = True
    End Sub

    Private Sub BuscarCliente(buscar As String)
        ReseteaTodo()
        If (buscar.Trim().Equals("")) Then
            CargarDataGridView()
        Else
            Try
                dbConnection.Open()
                Dim query As String = "SELECT Codigo, Nombre, Telefono, Domicilio FROM Clientes WHERE Nombre LIKE '%" + buscar + "%' OR Telefono LIKE '%" + buscar + "%' OR Domicilio LIKE '%" + buscar + "%'"
                Dim comando As New OleDb.OleDbCommand(query, dbConnection)

                Dim da As New OleDb.OleDbDataAdapter(comando)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvClientes.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al cargar la información de los clientes: " & ex.Message, "Error")
            Finally
                dbConnection.Close()
            End Try
        End If
        dgvClientes.ClearSelection()
    End Sub

    Private Sub BuscarClientePorNombre(nombre As String)
        If (nombre.Trim().Equals("")) Then
            CargarDataGridView()
        Else
            Try
                dbConnection.Open()
                Dim query As String = "SELECT Codigo, Nombre, Telefono, Domicilio FROM Clientes WHERE Nombre LIKE '%" + nombre + "%'"
                Dim comando As New OleDb.OleDbCommand(query, dbConnection)

                Dim da As New OleDb.OleDbDataAdapter(comando)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvClientes.DataSource = dt
                dgvClientes.ClearSelection()
            Catch ex As Exception
                MessageBox.Show("Error al cargar la información de los clientes: " & ex.Message, "Error")
            Finally
                dbConnection.Close()
            End Try
        End If
    End Sub
#End Region

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDataGridView()
        dgvClientes.ClearSelection()
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        SelectRowChanged(dgvClientes.CurrentRow.Index)
        selectedRowIndex = dgvClientes.CurrentRow.Index
        btnEliminar.Enabled = True
        If dgvClientes.CurrentRow.Index > 0 Then
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
        Else
            btnSiguiente.Enabled = True
            btnAnterior.Enabled = False
        End If
        If dgvClientes.CurrentRow.Index = dgvClientes.Rows.Count - 1 Then
            btnSiguiente.Enabled = False
            btnAnterior.Enabled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        accion = 1
        LimpiaTextBox()
        EnabledTextBox(True)
        EnabledButtons(False, True, False, False, True)
        btnSiguiente.Enabled = False
        btnAnterior.Enabled = False
        dgvClientes.Enabled = False
        btnReporteClientes.Enabled = False
        btnNuevoTrabajo.Enabled = False
        txtBuscar.Text = ""
        CargarDataGridView()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        accion = 0
        CargarDataGridView()
        ReseteaTodo()
        dgvClientes.Enabled = True
        txtBuscar.Text = ""
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        accion = 2
        EnabledTextBox(True)
        EnabledButtons(False, True, False, False, True)
        btnSiguiente.Enabled = False
        btnAnterior.Enabled = False
        dgvClientes.Enabled = False
        btnNuevoTrabajo.Enabled = False
        btnReporteClientes.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidaFormulario() Then
            If accion = 1 Then
                If MessageBox.Show("¿Está seguro de querer guardar el registro?", "Confirmación para guardar", MessageBoxButtons.YesNo) = vbYes Then
                    GuardaNuevo()
                    CargarDataGridView()
                    ReseteaTodo()
                End If
            Else
                If MessageBox.Show("¿Está seguro de querer actualizar el registro?", "Confirmación para actualizar", MessageBoxButtons.YesNo) = vbYes Then
                    ActualizaRegistro()
                    CargarDataGridView()
                    ReseteaTodo()
                End If
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If selectedRowIndex < dgvClientes.Rows.Count - 1 Then
            dgvClientes.ClearSelection()
            selectedRowIndex += 1
            dgvClientes.Rows(selectedRowIndex).Selected = True
            SelectRowChanged(selectedRowIndex)
            If selectedRowIndex = dgvClientes.Rows.Count - 1 Then
                btnSiguiente.Enabled = False
            End If
        Else
            btnSiguiente.Enabled = False
        End If

        If selectedRowIndex > 0 Then
            btnAnterior.Enabled = True
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If selectedRowIndex > 0 Then
            dgvClientes.ClearSelection()
            selectedRowIndex -= 1
            dgvClientes.Rows(selectedRowIndex).Selected = True
            SelectRowChanged(selectedRowIndex)
            If selectedRowIndex = 0 Then
                btnSiguiente.Enabled = True
                btnAnterior.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Está seguro de querer eliminar el registro? No se podrá recuperar.", "Confirmación para eliminar", MessageBoxButtons.YesNo) = vbYes Then
            EliminaRegistro()
            CargarDataGridView()
            ReseteaTodo()
        End If
    End Sub

    Private Sub btnNuevo_EnabledChanged(sender As Object, e As EventArgs) Handles btnNuevo.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnGuardar_EnabledChanged(sender As Object, e As EventArgs) Handles btnGuardar.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnEditar_EnabledChanged(sender As Object, e As EventArgs) Handles btnEditar.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnEliminar_EnabledChanged(sender As Object, e As EventArgs) Handles btnEliminar.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnCancelar_EnabledChanged(sender As Object, e As EventArgs) Handles btnCancelar.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnNuevoTrabajo_EnabledChanged(sender As Object, e As EventArgs) Handles btnNuevoTrabajo.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnReporteClientes_EnabledChanged(sender As Object, e As EventArgs) Handles btnReporteClientes.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        BuscarCliente(txtBuscar.Text)
    End Sub

    Private Sub txtNombre_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyUp
        BuscarClientePorNombre(txtNombre.Text)
    End Sub

    Private Sub dgvClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvClientes.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.PageUp Or Keys.PageDown Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub btnNuevoTrabajo_Click(sender As Object, e As EventArgs) Handles btnNuevoTrabajo.Click
        FormNuevoTrabajo.codigoCliente = Integer.Parse(txtCodigo.Text)
        FormNuevoTrabajo.nombreCliente = txtNombre.Text
        FormNuevoTrabajo.Show()
    End Sub

    Private Sub btnReporteClientes_Click(sender As Object, e As EventArgs) Handles btnReporteClientes.Click
        FormReporteClientes.Show()
    End Sub
End Class