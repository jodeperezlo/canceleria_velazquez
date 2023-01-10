Imports System.Configuration

Public Class FormComprasAProveedores
    Public dbConnection As New OleDb.OleDbConnection(ConfigurationManager.AppSettings.Get("ConnStringCanceleria"))
    Private accion As Integer = 0 '1: Nuevo, 2: Actualiza
    Private selectedRowIndex As Integer = -1
    Private codigoMaterial As Integer = -1
    Private codigoProveedor As Integer = -1
#Region "Funciones necesarias"
    Private Sub obtenerProveedores(coleccionMateriales As AutoCompleteStringCollection, query As String)
        Try
            dbConnection.Open()
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)
            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                coleccionMateriales.Add(row(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información del autocompletado: " & ex.Message, "Error")
        Finally
            dbConnection.Close()
        End Try
    End Sub
    Private Sub obtenerMateriales(coleccionMateriales As AutoCompleteStringCollection, query As String)
        Try
            dbConnection.Open()
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)
            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                coleccionMateriales.Add(row(0).ToString() + " | " + row(1).ToString() + " | " + row(2).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información del autocompletado: " & ex.Message, "Error")
        Finally
            dbConnection.Close()
        End Try
    End Sub
    Private Sub CargarDataGridView()
        Try
            dbConnection.Open()
            Dim query As String = "SELECT C.Codigo AS [Código Compra], M.Material, M.Tipo, M.Color, P.Proveedor, C.Costo, C.Cantidad, C.Costo * C.Cantidad AS [Total], C.FechaCompra AS [Fecha de compra] FROM (ComprasAProveedor C INNER JOIN Materiales M ON C.Material = M.Codigo) INNER JOIN Proveedores P ON C.Proveedor = P.Codigo"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvCompras.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información de las compras: " & ex.Message, "Error")
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
        txtMaterial.Enabled = enabled
        txtProveedor.Enabled = enabled
        txtCosto.Enabled = enabled
        txtCantidad.Enabled = enabled
        dtpFechaCompra.Enabled = enabled
    End Sub

    Private Sub LimpiaTextBox()
        txtCodigo.Text = ""
        txtMaterial.Text = ""
        txtProveedor.Text = ""
        txtCosto.Text = ""
        txtCantidad.Text = ""
        dtpFechaCompra.Value = Now
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
            Dim sql As String = "INSERT INTO ComprasAProveedor(Material, Proveedor, Costo, Cantidad, FechaCompra) VALUES (@Mat, @Prov, @Cost, @Cant, @FechaComp)"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Mat", codigoMaterial)
            comando.Parameters.AddWithValue("Prov", codigoProveedor)
            comando.Parameters.AddWithValue("Cost", txtCosto.Text)
            comando.Parameters.AddWithValue("Cant", txtCantidad.Text)
            comando.Parameters.AddWithValue("FechaComp", dtpFechaCompra)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se agregó la nueva compra correctamente", "Nueva compra guardada")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar la nueva compra: " & ex.Message, "Error al guardar compra")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub ActualizaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "UPDATE ComprasAProveedor SET Material = @Mat, Proveedor = @Prov, Costo = @Cost, Cantidad = @Cant, FechaCompra = @FechaComp WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Mat", codigoMaterial)
            comando.Parameters.AddWithValue("Prov", codigoProveedor)
            comando.Parameters.AddWithValue("Cost", txtCosto.Text)
            comando.Parameters.AddWithValue("Cant", txtCantidad.Text)
            comando.Parameters.AddWithValue("FechaComp", dtpFechaCompra.Value)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se actualizó la compra correctamente", "Compra actualizada")
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar la información de la compra: " & ex.Message, "Error al actualizar compra")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub EliminaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "DELETE FROM ComprasAProveedor WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se eliminó la compra correctamente", "Compra eliminada")
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar la información de la compra: " & ex.Message, "Error al eliminar la compra")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub SelectRowChanged(rowIndex)
        Dim FilaActual As Integer
        FilaActual = rowIndex
        selectedRowIndex = FilaActual
        txtCodigo.Text = dgvCompras.Rows(FilaActual).Cells(0).Value
        txtMaterial.Text = dgvCompras.Rows(FilaActual).Cells(1).Value + " | " + dgvCompras.Rows(FilaActual).Cells(2).Value + " | " + dgvCompras.Rows(FilaActual).Cells(3).Value
        txtProveedor.Text = dgvCompras.Rows(FilaActual).Cells(4).Value
        txtCosto.Text = dgvCompras.Rows(FilaActual).Cells(5).Value
        txtCantidad.Text = dgvCompras.Rows(FilaActual).Cells(6).Value
        dtpFechaCompra.Value = dgvCompras.Rows(FilaActual).Cells(8).Value
        EnabledButtons(False, False, True, True, True)
    End Sub
    Private Function ValidaFormulario() As Boolean
        If txtCosto.Text.Trim() = "" Then
            MessageBox.Show("El costo no puede ir vacío, introduzca el costo del producto.", "Error al intentar guardar - Ingrese el costo")
            txtCosto.Focus()
            Return False
        ElseIf txtCantidad.Text.Trim() = "" Then
            MessageBox.Show("La cantidad no puede ir vacía, introduzca la cantidad de la compra.", "Error al intentar guardar - Ingrese la cantidad")
            txtCantidad.Focus()
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
        dgvCompras.ClearSelection()
        dgvCompras.Enabled = True
        btnReporteCompras.Enabled = True
        codigoMaterial = -1
        codigoProveedor = -1
    End Sub

    Private Sub BuscarCompra(buscar As String)
        ReseteaTodo()
        If (buscar.Trim().Equals("")) Then
            CargarDataGridView()
        Else
            Try
                dbConnection.Open()
                Dim query As String = "SELECT C.Codigo AS [Código Compra], M.Material, M.Tipo, M.Color, P.Proveedor, C.Costo, C.Cantidad, C.Costo * C.Cantidad AS [Total], C.FechaCompra AS [Fecha de compra] FROM (ComprasAProveedor C INNER JOIN Materiales M ON C.Material = M.Codigo) INNER JOIN Proveedores P ON C.Proveedor = P.Codigo WHERE M.Material LIKE '%" + buscar + "%' OR P.Proveedor LIKE '%" + buscar + "%' OR C.Costo LIKE '%" + buscar + "%'"
                Dim comando As New OleDb.OleDbCommand(query, dbConnection)

                Dim da As New OleDb.OleDbDataAdapter(comando)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvCompras.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al cargar la información de los clientes: " & ex.Message, "Error")
            Finally
                dbConnection.Close()
            End Try
        End If
        dgvCompras.ClearSelection()
    End Sub

    Private Sub BuscarPorFechas()
        Try
            dbConnection.Open()
            Dim query As String = "SELECT C.Codigo AS [Código Compra], M.Material, M.Tipo, M.Color, P.Proveedor, C.Costo, C.Cantidad, C.Costo * C.Cantidad AS [Total], C.FechaCompra AS [Fecha de compra] FROM (ComprasAProveedor C INNER JOIN Materiales M ON C.Material = M.Codigo) INNER JOIN Proveedores P ON C.Proveedor = P.Codigo WHERE C.FechaCompra BETWEEN #" & dtpFechaInicio.Value.Date & "# AND #" & dtpFechaFin.Value.Date & "# ORDER BY FechaCompra DESC"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvCompras.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información de las compras: " & ex.Message, "Error")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Function ObtenerCodigoMaterial() As Boolean
        Try
            dbConnection.Open()
            Dim query As String = "SELECT Codigo FROM Materiales WHERE Material = '" + txtMaterial.Text.Split("|").GetValue(0).ToString().Trim() + "' AND Tipo = '" + txtMaterial.Text.Split("|").GetValue(1).ToString().Trim() + "' AND Color = '" + txtMaterial.Text.Split("|").GetValue(2).ToString().Trim() + "'"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                codigoMaterial = Integer.Parse(row(0).ToString())
            Next
        Catch ex As Exception
            Console.WriteLine("Error al obtener código del material: ", ex.Message)
        Finally
            dbConnection.Close()
        End Try

        If codigoMaterial > -1 Then
            Return True
        Else
            MessageBox.Show("Elija un material válido en las opciones para poder guardar el registro.", "Error al guardar - Elija material válido")
            Return False
        End If
    End Function

    Private Function ObtenerCodigoProveedor() As Boolean
        Try
            dbConnection.Open()
            Dim query As String = "SELECT Codigo FROM Proveedores WHERE Proveedor = '" + txtProveedor.Text + "'"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                codigoProveedor = Integer.Parse(row(0).ToString())
            Next
        Catch ex As Exception
            Console.WriteLine("Error al obtener código del proveedor: ", ex.Message)
        Finally
            dbConnection.Close()
        End Try

        If codigoProveedor > -1 Then
            Return True
        Else
            MessageBox.Show("Elija un proveedor válido en las opciones para poder guardar el registro.", "Error al guardar - Elija proveedor válido")
            Return False
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
#End Region

    Private Sub FormComprarMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDataGridView()
        dgvCompras.ClearSelection()

        txtMaterial.AutoCompleteMode = AutoCompleteMode.Suggest
        txtMaterial.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim ColeccionMateriales As New AutoCompleteStringCollection()
        Dim queryMateriales As String = "SELECT Material, Tipo, Color FROM Materiales"
        obtenerMateriales(ColeccionMateriales, queryMateriales)
        txtMaterial.AutoCompleteCustomSource = ColeccionMateriales

        txtProveedor.AutoCompleteMode = AutoCompleteMode.Suggest
        txtProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim ColeccionProveedores As New AutoCompleteStringCollection()
        Dim queryProveedores As String = "SELECT Proveedor FROM Proveedores"
        obtenerProveedores(ColeccionProveedores, queryProveedores)
        txtProveedor.AutoCompleteCustomSource = ColeccionProveedores
    End Sub

    Private Sub dgvCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompras.CellClick
        SelectRowChanged(dgvCompras.CurrentRow.Index)
        selectedRowIndex = dgvCompras.CurrentRow.Index
        btnEliminar.Enabled = True
        If dgvCompras.CurrentRow.Index > 0 Then
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
        Else
            btnSiguiente.Enabled = True
            btnAnterior.Enabled = False
        End If
        If dgvCompras.CurrentRow.Index = dgvCompras.Rows.Count - 1 Then
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
        dgvCompras.Enabled = False
        btnReporteCompras.Enabled = False
        txtBuscar.Text = ""
        CargarDataGridView()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        accion = 0
        dtpFechaFin.Value = Now.AddDays(1)
        dtpFechaInicio.Value = Now
        CargarDataGridView()
        ReseteaTodo()
        dgvCompras.Enabled = True
        txtBuscar.Text = ""
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        accion = 2
        EnabledTextBox(True)
        EnabledButtons(False, True, False, False, True)
        btnSiguiente.Enabled = False
        btnAnterior.Enabled = False
        dgvCompras.Enabled = False
        btnReporteCompras.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidaFormulario() And ObtenerCodigoMaterial() And ObtenerCodigoProveedor() Then
            If accion = 1 Then
                If MessageBox.Show("¿Está seguro de querer guardar el registro?", "Confirmación para guardar", MessageBoxButtons.YesNo) = vbYes Then
                    GuardaNuevo()
                    txtBuscar.Text = ""
                    dtpFechaFin.Value = Now.AddDays(1)
                    dtpFechaInicio.Value = Now
                    CargarDataGridView()
                    ReseteaTodo()
                End If
            Else
                If MessageBox.Show("¿Está seguro de querer actualizar el registro?", "Confirmación para actualizar", MessageBoxButtons.YesNo) = vbYes Then
                    ActualizaRegistro()
                    txtBuscar.Text = ""
                    dtpFechaFin.Value = Now.AddDays(1)
                    dtpFechaInicio.Value = Now
                    CargarDataGridView()
                    ReseteaTodo()
                End If
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If selectedRowIndex < dgvCompras.Rows.Count - 1 Then
            dgvCompras.ClearSelection()
            selectedRowIndex += 1
            dgvCompras.Rows(selectedRowIndex).Selected = True
            SelectRowChanged(selectedRowIndex)
            If selectedRowIndex = dgvCompras.Rows.Count - 1 Then
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
            dgvCompras.ClearSelection()
            selectedRowIndex -= 1
            dgvCompras.Rows(selectedRowIndex).Selected = True
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
            dtpFechaFin.Value = Now.AddDays(1)
            dtpFechaInicio.Value = Now
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

    Private Sub btnSiguiente_EnabledChanged(sender As Object, e As EventArgs) Handles btnSiguiente.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnAnterior_EnabledChanged(sender As Object, e As EventArgs) Handles btnAnterior.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnReporteClientes_EnabledChanged(sender As Object, e As EventArgs) Handles btnReporteCompras.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        BuscarCompra(txtBuscar.Text)
    End Sub

    Private Sub dgvCompras_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCompras.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.PageUp Or Keys.PageDown Then
            e.SuppressKeyPress = True
        End If
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

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        NumerosyDecimal(txtCosto, e)
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        NumerosyDecimal(txtCosto, e)
    End Sub

    Private Sub btnReporteCompras_Click(sender As Object, e As EventArgs) Handles btnReporteCompras.Click
        FormReporteComprasAProveedor.Show()
    End Sub
End Class