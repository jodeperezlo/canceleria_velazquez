Imports System.Configuration

Public Class FormMateriales
    Public dbConnection As New OleDb.OleDbConnection(ConfigurationManager.AppSettings.Get("ConnStringCanceleria"))
    Private accion As Integer = 0 '1: Nuevo, 2: Actualiza
    Private selectedRowIndex As Integer = -1
#Region "Funciones necesarias"
    Private Sub CargarDataGridView()
        Try
            dbConnection.Open()
            Dim query As String = "SELECT Codigo, Material, Tipo, Color, Disponible FROM Materiales"
            Dim comando As New OleDb.OleDbCommand(query, dbConnection)

            Dim da As New OleDb.OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvMateriales.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la información de los materiales: " & ex.Message, "Error")
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
        txtTipo.Enabled = enabled
        txtColor.Enabled = enabled
        cbDisponible.Enabled = enabled
    End Sub

    Private Sub LimpiaTextBox()
        txtCodigo.Text = ""
        txtMaterial.Text = ""
        txtTipo.Text = ""
        txtColor.Text = ""
        cbDisponible.Checked = False
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
            Dim sql As String = "INSERT INTO Materiales(Material, Tipo, Color, Disponible) VALUES (@Mat, @Tipo, @Col, @Disp)"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Mat", txtMaterial.Text)
            comando.Parameters.AddWithValue("Tipo", txtTipo.Text)
            comando.Parameters.AddWithValue("Col", txtColor.Text)
            comando.Parameters.AddWithValue("Disp", cbDisponible.Checked)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se agregó el nuevo material correctamente", "Nuevo material guardado")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar el nuevo material: " & ex.Message, "Error al guardar material")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub ActualizaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "UPDATE Materiales SET Material = @Mat, Tipo = @Tipo, Color = @Col, Disponible = @Disp WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Mat", txtMaterial.Text)
            comando.Parameters.AddWithValue("Tipo", txtTipo.Text)
            comando.Parameters.AddWithValue("Col", txtColor.Text)
            comando.Parameters.AddWithValue("Disp", cbDisponible.Checked)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se actualizó el material correctamente", "Material actualizado")
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar la información del material: " & ex.Message, "Error al actualizar material")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub EliminaRegistro()
        Try
            dbConnection.Open()
            Dim sql As String = "DELETE FROM Materiales WHERE Codigo = @Cod"
            Dim comando As New OleDb.OleDbCommand(sql, dbConnection)
            comando.Parameters.AddWithValue("Cod", txtCodigo.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Se eliminó el material correctamente", "Material eliminado")
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar la información del material: " & ex.Message, "Error al eliminar el material")
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub SelectRowChanged(rowIndex)
        Dim FilaActual As Integer
        FilaActual = rowIndex
        selectedRowIndex = FilaActual
        txtCodigo.Text = dgvMateriales.Rows(FilaActual).Cells(0).Value
        txtMaterial.Text = dgvMateriales.Rows(FilaActual).Cells(1).Value
        txtTipo.Text = dgvMateriales.Rows(FilaActual).Cells(2).Value
        txtColor.Text = dgvMateriales.Rows(FilaActual).Cells(3).Value
        cbDisponible.Checked = dgvMateriales.Rows(FilaActual).Cells(4).Value
        EnabledButtons(False, False, True, True, True)
    End Sub
    Private Function ValidaFormulario() As Boolean
        If txtMaterial.Text.Trim() = "" Then
            MessageBox.Show("El nombre del material no puede ir vacío, introduzca el material.", "Error al intentar guardar - Ingrese el material")
            txtMaterial.Focus()
            Return False
        ElseIf txtTipo.Text.Trim() = "" Then
            MessageBox.Show("El tipo no puede ir vacío, introduzca el número de tipo.", "Error al intentar guardar - Ingrese el tipo")
            txtTipo.Focus()
            Return False
        ElseIf txtColor.Text.Trim() = "" Then
            MessageBox.Show("El color no puede ir vacío, introduzca el color.", "Error al intentar guardar - Ingrese el color")
            txtColor.Focus()
            Return False
        ElseIf txtMaterial.Text.Trim().Length < 2 Then
            MessageBox.Show("El nombre del material debe de tener al menos 2 caracteres para ser un nombre válido.", "Error al intentar guardar - Material no válido")
            txtMaterial.Focus()
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
        dgvMateriales.ClearSelection()
        dgvMateriales.Enabled = True
        btnReporteMateriales.Enabled = True
    End Sub

    Private Sub BuscarMaterial(buscar As String)
        ReseteaTodo()
        If (buscar.Trim().Equals("")) Then
            CargarDataGridView()
        Else
            Try
                dbConnection.Open()
                Dim query As String = "SELECT Codigo, Material, Tipo, Color, Disponible FROM Materiales WHERE Material LIKE '%" + buscar + "%' OR Tipo LIKE '%" + buscar + "%' OR Color LIKE '%" + buscar + "%'"
                Dim comando As New OleDb.OleDbCommand(query, dbConnection)

                Dim da As New OleDb.OleDbDataAdapter(comando)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvMateriales.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al cargar la información de los materiales: " & ex.Message, "Error")
            Finally
                dbConnection.Close()
            End Try
        End If
        dgvMateriales.ClearSelection()
    End Sub

    Private Sub BuscarMaterialPorNombre(nombre As String)
        If (nombre.Trim().Equals("")) Then
            CargarDataGridView()
        Else
            Try
                dbConnection.Open()
                Dim query As String = "SELECT Codigo, Material, Tipo, Color, Disponible FROM Materiales WHERE Material LIKE '%" + nombre + "%'"
                Dim comando As New OleDb.OleDbCommand(query, dbConnection)

                Dim da As New OleDb.OleDbDataAdapter(comando)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvMateriales.DataSource = dt
                dgvMateriales.ClearSelection()
            Catch ex As Exception
                MessageBox.Show("Error al cargar la información de los materiales: " & ex.Message, "Error")
            Finally
                dbConnection.Close()
            End Try
        End If
    End Sub

    Private Sub FormMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDataGridView()
        dgvMateriales.ClearSelection()
    End Sub

    Private Sub dgvMateriales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMateriales.CellClick
        SelectRowChanged(dgvMateriales.CurrentRow.Index)
        selectedRowIndex = dgvMateriales.CurrentRow.Index
        btnEliminar.Enabled = True
        If dgvMateriales.CurrentRow.Index > 0 Then
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
        Else
            btnSiguiente.Enabled = True
            btnAnterior.Enabled = False
        End If
        If dgvMateriales.CurrentRow.Index = dgvMateriales.Rows.Count - 1 Then
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
        dgvMateriales.Enabled = False
        btnReporteMateriales.Enabled = False
        txtBuscar.Text = ""
        CargarDataGridView()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        accion = 0
        CargarDataGridView()
        ReseteaTodo()
        dgvMateriales.Enabled = True
        txtBuscar.Text = ""
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        accion = 2
        EnabledTextBox(True)
        EnabledButtons(False, True, False, False, True)
        btnSiguiente.Enabled = False
        btnAnterior.Enabled = False
        dgvMateriales.Enabled = False
        btnReporteMateriales.Enabled = False
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
        If selectedRowIndex < dgvMateriales.Rows.Count - 1 Then
            dgvMateriales.ClearSelection()
            selectedRowIndex += 1
            dgvMateriales.Rows(selectedRowIndex).Selected = True
            SelectRowChanged(selectedRowIndex)
            If selectedRowIndex = dgvMateriales.Rows.Count - 1 Then
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
            dgvMateriales.ClearSelection()
            selectedRowIndex -= 1
            dgvMateriales.Rows(selectedRowIndex).Selected = True
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

    Private Sub btnReporteMateriales_EnabledChanged(sender As Object, e As EventArgs) Handles btnReporteMateriales.EnabledChanged
        DefinirButtonBackColor(sender)
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        BuscarMaterial(txtBuscar.Text)
    End Sub

    Private Sub txtMaterial_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaterial.KeyUp
        BuscarMaterialPorNombre(txtMaterial.Text)
    End Sub

    Private Sub dgvMateriales_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMateriales.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.PageUp Or Keys.PageDown Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnReporteMateriales_Click(sender As Object, e As EventArgs) Handles btnReporteMateriales.Click
        FormReporteMateriales.Show()
    End Sub
#End Region

End Class