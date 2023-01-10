Imports System.Configuration

Public Class FormTrabajos
    Public dbConnection As New OleDb.OleDbConnection(ConfigurationManager.AppSettings.Get("ConnStringCanceleria"))
    Private selectedRowIndex As Integer = -1
    Private codigoCliente As Integer = -1
#Region "Funciones necesarias"
    Private Sub CargarDataGridView()
        Try
            dbConnection.Open()
            Dim query As String = "SELECT T.Codigo, T.Trabajo, C.Codigo AS [Código del cliente], C.Nombre AS Cliente, T.Costo, T.FechaTerminacion AS [Fecha de terminación] FROM Trabajos T INNER JOIN Clientes C ON C.Codigo = T.Cliente ORDER BY FechaTerminacion DESC"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvTrabajos.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información de los proveedores: " & ex.Message, "Error")
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
        txtTrabajo.Enabled = enabled
        txtCosto.Enabled = enabled
        dtpFechaTerminacion.Enabled = enabled
    End Sub

    Private Sub LimpiaTextBox()
        txtCodigo.Text = ""
        txtTrabajo.Text = ""
        txtCosto.Text = ""
        txtCliente.Text = ""
        dtpFechaTerminacion.Value = Now
    End Sub

    Private Sub EnabledButtons(botonGuardar As Boolean, botonActualizar As Boolean, botonEliminar As Boolean, botonCancelar As Boolean)
        btnGuardar.Enabled = botonGuardar
        btnEditar.Enabled = botonActualizar
        btnEliminar.Enabled = botonEliminar
        btnCancelar.Enabled = botonCancelar
    End Sub

    Private Sub ActualizaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "UPDATE TRABAJOS SET Trabajo = @Trab, Cliente = @Cli, Costo = @Cost, FechaTerminacion = @FechTerm WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Trab", txtTrabajo.Text)
            comando.Parameters.AddWithValue("Cli", codigoCliente)
            comando.Parameters.AddWithValue("Cost", txtCosto.Text)
            comando.Parameters.AddWithValue("Cost", dtpFechaTerminacion.Value)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se actualizó el trabajo correctamente", "Trabajo actualizado")
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar la información del proveedor: " & ex.Message, "Error al actualizar proveedor")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub EliminaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "DELETE FROM Trabajos WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se eliminó al cliente correctamente", "Cliente eliminado")
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar la información del proveedor: " & ex.Message, "Error al eliminar el proveedor")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub SelectRowChanged(rowIndex)
        Dim FilaActual As Integer
        FilaActual = rowIndex
        selectedRowIndex = FilaActual
        txtCodigo.Text = dgvTrabajos.Rows(FilaActual).Cells(0).Value
        txtTrabajo.Text = dgvTrabajos.Rows(FilaActual).Cells(1).Value
        codigoCliente = dgvTrabajos.Rows(FilaActual).Cells(2).Value
        txtCliente.Text = dgvTrabajos.Rows(FilaActual).Cells(3).Value
        txtCosto.Text = dgvTrabajos.Rows(FilaActual).Cells(4).Value
        dtpFechaTerminacion.Value = dgvTrabajos.Rows(FilaActual).Cells(5).Value
        EnabledButtons(False, True, True, True)
    End Sub
    Private Function ValidaFormulario() As Boolean
        If txtTrabajo.Text.Trim() = "" Then
            MessageBox.Show("El nombre del trabajo no puede ir vacío, introduzca el trabajo.", "Error al intentar guardar - Ingrese el trabajo")
            Return False
        ElseIf txtCosto.Text.Trim() = "" Then
            MessageBox.Show("El costo no puede ir vacío, introduzca el costo.", "Error al intentar guardar - Ingrese el costo")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ReseteaTodo()
        EnabledTextBox(False)
        EnabledButtons(False, False, False, False)
        LimpiaTextBox()
        btnSiguiente.Enabled = True
        btnAnterior.Enabled = False
        selectedRowIndex = -1
        dgvTrabajos.ClearSelection()
        dgvTrabajos.Enabled = True
        btnReporteTrabajos.Enabled = True
    End Sub

    Private Sub BuscarTrabajo(buscar As String)
        ReseteaTodo()
        If (buscar.Trim().Equals("")) Then
            CargarDataGridView()
        Else
            Try
                dbConnection.Open()
                Dim query As String = "SELECT T.Codigo, T.Trabajo, C.Codigo AS [Código del cliente], C.Nombre AS Cliente, T.Costo, T.FechaTerminacion AS [Fecha de terminación] FROM Trabajos T INNER JOIN Clientes C ON C.Codigo = T.Cliente WHERE T.Trabajo LIKE '%" + buscar + "%' OR T.Costo LIKE '%" + buscar + "%' OR T.FechaTerminacion LIKE '%" + buscar + "%' OR C.Nombre LIKE '%" + buscar + "%' ORDER BY FechaTerminacion DESC"
                Dim comando As New OleDb.OleDbCommand(query, dbConnection)

                Dim da As New OleDb.OleDbDataAdapter(comando)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvTrabajos.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al cargar la información de los trabajos: " & ex.Message, "Error")
            Finally
                dbConnection.Close()
            End Try
        End If
        dgvTrabajos.ClearSelection()
    End Sub

    Private Sub BuscarTrabajoPorTrabajo(trabajo As String)
        If (trabajo.Trim().Equals("")) Then
            CargarDataGridView()
        Else
            Try
                dbConnection.Open()
                Dim query As String = "SELECT T.Codigo, T.Trabajo, C.Codigo AS [Código del cliente], C.Nombre AS Cliente, T.Costo, T.FechaTerminacion AS [Fecha de terminación] FROM Trabajos T INNER JOIN Clientes C ON C.Codigo = T.Cliente WHERE Trabajo LIKE '%" + trabajo + "%' ORDER BY FechaTerminacion DESC"
                Dim comando As New OleDb.OleDbCommand(query, dbConnection)

                Dim da As New OleDb.OleDbDataAdapter(comando)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvTrabajos.DataSource = dt
                dgvTrabajos.ClearSelection()
            Catch ex As Exception
                MessageBox.Show("Error al cargar la información de los trabajos: " & ex.Message, "Error")
            Finally
                dbConnection.Close()
            End Try
        End If
    End Sub

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

    Private Sub BuscarPorFechas()
        Try
            dbConnection.Open()
            Dim query As String = "SELECT T.Codigo, T.Trabajo, C.Codigo AS [Código del cliente], C.Nombre AS Cliente, T.Costo, T.FechaTerminacion AS [Fecha de terminación] FROM Trabajos T INNER JOIN Clientes C ON C.Codigo = T.Cliente WHERE FechaTerminacion BETWEEN #" & dtpFechaInicio.Value.Date & "# AND #" & dtpFechaFin.Value.Date & "# ORDER BY FechaTerminacion DESC"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvTrabajos.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información de los trabajos: " & ex.Message, "Error")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub ImprimirTicketTrabajo()
        Try
            dbConnection.Open()
            Dim query As String = "
                         SELECT Trabajos.Codigo AS NumeroFactura, Trabajos.Trabajo, Clientes.Codigo AS CodigoCliente, 
                         Clientes.Nombre, Clientes.Telefono, Clientes.Domicilio, Trabajos.Costo, 
                         Trabajos.FechaTerminacion AS FechaEstimadaTerminacion
                         FROM (Clientes INNER JOIN
                         Trabajos ON Clientes.Codigo = Trabajos.Cliente)
                         WHERE Trabajos.Codigo = " + txtCodigo.Text + "
                         ORDER BY Trabajos.Codigo DESC"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim ds As New DataSet()
            da.Fill(ds)

            FormTicketTrabajo.dsFormTicketTrabajo = ds

            FormTicketTrabajo.Show()
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información de los proveedores: " & ex.Message, "Error")
        Finally
            dbConnection.Close()
        End Try
    End Sub
#End Region

    Private Sub FormTrabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDataGridView()
        dgvTrabajos.ClearSelection()
    End Sub

    Private Sub dgvTrabajos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrabajos.CellClick
        SelectRowChanged(dgvTrabajos.CurrentRow.Index)
        selectedRowIndex = dgvTrabajos.CurrentRow.Index
        btnEliminar.Enabled = True
        If dgvTrabajos.CurrentRow.Index > 0 Then
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
        Else
            btnSiguiente.Enabled = True
            btnAnterior.Enabled = False
        End If
        If dgvTrabajos.CurrentRow.Index = dgvTrabajos.Rows.Count - 1 Then
            btnSiguiente.Enabled = False
            btnAnterior.Enabled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dtpFechaFin.Value = Now.AddDays(1)
        dtpFechaInicio.Value = Now
        CargarDataGridView()
        ReseteaTodo()
        dgvTrabajos.Enabled = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EnabledTextBox(True)
        EnabledButtons(True, False, False, True)
        btnSiguiente.Enabled = False
        btnAnterior.Enabled = False
        dgvTrabajos.Enabled = False
        btnReporteTrabajos.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidaFormulario() Then
            If MessageBox.Show("¿Está seguro de querer actualizar el registro?", "Confirmación", MessageBoxButtons.YesNo) = vbYes Then
                ActualizaRegistro()
                ImprimirTicketTrabajo()
                txtBuscar.Text = ""
                dtpFechaFin.Value = Now.AddDays(1)
                dtpFechaInicio.Value = Now
                CargarDataGridView()
                ReseteaTodo()
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If selectedRowIndex < dgvTrabajos.Rows.Count - 1 Then
            dgvTrabajos.ClearSelection()
            selectedRowIndex += 1
            dgvTrabajos.Rows(selectedRowIndex).Selected = True
            SelectRowChanged(selectedRowIndex)
            If selectedRowIndex = dgvTrabajos.Rows.Count - 1 Then
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
            dgvTrabajos.ClearSelection()
            selectedRowIndex -= 1
            dgvTrabajos.Rows(selectedRowIndex).Selected = True
            SelectRowChanged(selectedRowIndex)
            If selectedRowIndex = 0 Then
                btnSiguiente.Enabled = True
                btnAnterior.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Está seguro de querer eliminar el registro? No se podrá recuperar.", "Confirmación", MessageBoxButtons.YesNo) = vbYes Then
            EliminaRegistro()
            dtpFechaFin.Value = Now.AddDays(1)
            dtpFechaInicio.Value = Now
            CargarDataGridView()
            ReseteaTodo()
        End If
    End Sub

    Private Sub btnEditar_EnabledChanged(sender As Object, e As EventArgs) Handles btnEditar.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnGuardar_EnabledChanged(sender As Object, e As EventArgs) Handles btnGuardar.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnEliminar_EnabledChanged(sender As Object, e As EventArgs) Handles btnEliminar.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnCancelar_EnabledChanged(sender As Object, e As EventArgs) Handles btnCancelar.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnReporteTrabajos_EnabledChanged(sender As Object, e As EventArgs) Handles btnReporteTrabajos.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnAnterior_EnabledChanged(sender As Object, e As EventArgs) Handles btnAnterior.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnSiguiente_EnabledChanged(sender As Object, e As EventArgs) Handles btnSiguiente.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        BuscarTrabajo(txtBuscar.Text)
    End Sub

    Private Sub txtTrabajo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTrabajo.KeyUp
        BuscarTrabajoPorTrabajo(txtTrabajo.Text)
    End Sub

    Private Sub dgvTrabajos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvTrabajos.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.PageUp Or Keys.PageDown Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        NumerosyDecimal(txtCosto, e)
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        If dtpFechaInicio.Value.Day = dtpFechaFin.Value.Day Then
            dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(1)
        End If
        BuscarPorFechas()
        dtpFechaFin.MinDate = dtpFechaInicio.Value
    End Sub

    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged
        If dtpFechaInicio.Value.Day = dtpFechaFin.Value.Day Then
            dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(1)
        End If
        BuscarPorFechas()
        dtpFechaInicio.MaxDate = dtpFechaFin.Value
    End Sub

    Private Sub btnReporteTrabajos_Click(sender As Object, e As EventArgs) Handles btnReporteTrabajos.Click
        FormReporteTrabajos.Show()
    End Sub
End Class