Imports System.Configuration

Public Class FormProveedores
    Public dbConnection As New OleDb.OleDbConnection(ConfigurationManager.AppSettings.Get("ConnStringCanceleria"))
    Private accion As Integer = 0 '1: Nuevo, 2: Actualiza
    Private selectedRowIndex As Integer = -1
#Region "Funciones necesarias"
    Private Sub CargarDataGridView()
        Try
            dbConnection.Open()
            Dim query As String = "SELECT Codigo, Proveedor, RFC, Telefono FROM Proveedores"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvProveedores.DataSource = dt
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
        txtProveedor.Enabled = enabled
        txtRFC.Enabled = enabled
        txtTelefono.Enabled = enabled
    End Sub

    Private Sub LimpiaTextBox()
        txtCodigo.Text = ""
        txtProveedor.Text = ""
        txtRFC.Text = ""
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
            Dim sql As String = "INSERT INTO Proveedores(Proveedor, RFC, Telefono) VALUES (@Prov, @RFC, @Tel)"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Nom", txtProveedor.Text)
            comando.Parameters.AddWithValue("RFC", txtRFC.Text)
            comando.Parameters.AddWithValue("Tel", txtTelefono.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se agregó el nuevo proveedor correctamente", "Nuevo proveedor guardado")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar el nuevo proveedor: " & ex.Message, "Error al guardar proveedor")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub ActualizaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "UPDATE Proveedores SET Proveedor = @Prov, RFC = @RFC, Telefono = @Tel WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Prov", txtProveedor.Text)
            comando.Parameters.AddWithValue("RFC", txtRFC.Text)
            comando.Parameters.AddWithValue("Tel", txtTelefono.Text)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se actualizó el proveedor correctamente", "Proveedor actualizado")
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar la información del proveedor: " & ex.Message, "Error al actualizar proveedor")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub EliminaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "DELETE FROM Proveedores WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se eliminó al proveedor correctamente", "Proveedor eliminado")
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
        txtCodigo.Text = dgvProveedores.Rows(FilaActual).Cells(0).Value
        txtProveedor.Text = dgvProveedores.Rows(FilaActual).Cells(1).Value
        txtRFC.Text = dgvProveedores.Rows(FilaActual).Cells(3).Value
        txtTelefono.Text = dgvProveedores.Rows(FilaActual).Cells(2).Value
        EnabledButtons(False, False, True, True, True)
    End Sub
    Private Function ValidaFormulario() As Boolean
        If txtProveedor.Text.Trim() = "" Then
            MessageBox.Show("El nombre del proveedor no puede ir vacío, introduzca el nombre.", "Error al intentar guardar - Ingrese el proveedor")
            txtProveedor.Focus()
            Return False
        ElseIf txtRFC.Text.Trim() = "" Then
            MessageBox.Show("El RFC no puede ir vacío, introduzca el RFC.", "Error al intentar guardar - Ingrese el RFC")
            txtRFC.Focus()
            Return False
        ElseIf txtTelefono.Text.Trim() = "" Then
            MessageBox.Show("El teléfono no puede ir vacío, introduzca el número de teléfono.", "Error al intentar guardar - Ingrese el teléfono")
            txtTelefono.Focus()
            Return False
        ElseIf txtProveedor.Text.Trim().Length < 2 Then
            MessageBox.Show("El nombre del proveedor debe de tener al menos 2 caracteres para ser un nombre válido.", "Error al intentar guardar - Nombre no válido")
            txtProveedor.Focus()
            Return False
        ElseIf txtRFC.Text.Trim().Length < 13 Then
            MessageBox.Show("El RFC debe de tener al menos 13 caracteres para ser un RFC válido, ingrese un RFC válido.", "Error al intentar guardar - RFC no válido")
            txtRFC.Focus()
        ElseIf txtTelefono.Text.Trim().Length < 10 Then
            MessageBox.Show("El teléfono debe de tener al menos 10 caracteres para ser un teléfono válido.", "Error al intentar guardar - Telefono no válido")
            txtTelefono.Focus()
            Return False
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
        dgvProveedores.ClearSelection()
        dgvProveedores.Enabled = True
        btnReporteProveedores.Enabled = True
    End Sub

    Private Sub BuscarProveedor(buscar As String)
        ReseteaTodo()
        If (buscar.Trim().Equals("")) Then
            CargarDataGridView()
        Else
            Try
                dbConnection.Open()
                Dim query As String = "SELECT Codigo, Proveedor, RFC, Telefono FROM Proveedores WHERE Proveedor LIKE '%" + buscar + "%' OR RFC LIKE '%" + buscar + "%' OR Telefono LIKE '%" + buscar + "%'"
                Dim comando As New OleDb.OleDbCommand(query, dbConnection)

                Dim da As New OleDb.OleDbDataAdapter(comando)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvProveedores.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al cargar la información de los proveedores: " & ex.Message, "Error")
            Finally
                dbConnection.Close()
            End Try
        End If
        dgvProveedores.ClearSelection()
    End Sub

    Private Sub BuscarProveedorPorNombre(proveedor As String)
        If (proveedor.Trim().Equals("")) Then
            CargarDataGridView()
        Else
            Try
                dbConnection.Open()
                Dim query As String = "SELECT Codigo, Proveedor, RFC, Telefono FROM Proveedores WHERE Proveedor LIKE '%" + proveedor + "%'"
                Dim comando As New OleDb.OleDbCommand(query, dbConnection)

                Dim da As New OleDb.OleDbDataAdapter(comando)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvProveedores.DataSource = dt
                dgvProveedores.ClearSelection()
            Catch ex As Exception
                MessageBox.Show("Error al cargar la información de los proveedores: " & ex.Message, "Error")
            Finally
                dbConnection.Close()
            End Try
        End If
    End Sub
#End Region
    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDataGridView()
        dgvProveedores.ClearSelection()
    End Sub

    Private Sub dgvProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        SelectRowChanged(dgvProveedores.CurrentRow.Index)
        selectedRowIndex = dgvProveedores.CurrentRow.Index
        btnEliminar.Enabled = True
        If dgvProveedores.CurrentRow.Index > 0 Then
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
        Else
            btnSiguiente.Enabled = True
            btnAnterior.Enabled = False
        End If
        If dgvProveedores.CurrentRow.Index = dgvProveedores.Rows.Count - 1 Then
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
        dgvProveedores.Enabled = False
        btnReporteProveedores.Enabled = False
        txtBuscar.Text = ""
        CargarDataGridView()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        accion = 0
        CargarDataGridView()
        ReseteaTodo()
        dgvProveedores.Enabled = True
        txtBuscar.Text = ""
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        accion = 2
        EnabledTextBox(True)
        EnabledButtons(False, True, False, False, True)
        btnSiguiente.Enabled = False
        btnAnterior.Enabled = False
        dgvProveedores.Enabled = False
        btnReporteProveedores.Enabled = False
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
        If selectedRowIndex < dgvProveedores.Rows.Count - 1 Then
            dgvProveedores.ClearSelection()
            selectedRowIndex += 1
            dgvProveedores.Rows(selectedRowIndex).Selected = True
            SelectRowChanged(selectedRowIndex)
            If selectedRowIndex = dgvProveedores.Rows.Count - 1 Then
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
            dgvProveedores.ClearSelection()
            selectedRowIndex -= 1
            dgvProveedores.Rows(selectedRowIndex).Selected = True
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

    Private Sub btnAnterior_EnabledChanged(sender As Object, e As EventArgs) Handles btnAnterior.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnSiguiente_EnabledChanged(sender As Object, e As EventArgs) Handles btnSiguiente.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub btnReporteProveedores_EnabledChanged(sender As Object, e As EventArgs) Handles btnReporteProveedores.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        BuscarProveedor(txtBuscar.Text)
    End Sub

    Private Sub txtProveedor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyUp
        BuscarProveedorPorNombre(txtProveedor.Text)
    End Sub

    Private Sub dgvProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProveedores.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.PageUp Or Keys.PageDown Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub btnReporteProveedores_Click(sender As Object, e As EventArgs) Handles btnReporteProveedores.Click
        FormReporteProveedores.Show()
    End Sub
End Class