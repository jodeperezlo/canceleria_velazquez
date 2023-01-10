<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTrabajos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTrabajos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBarraSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlBarraIzquierda = New System.Windows.Forms.Panel()
        Me.btnReporteTrabajos = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTrabajo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.pnlFormulario = New System.Windows.Forms.Panel()
        Me.dtpFechaTerminacion = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.pnlTable = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dgvTrabajos = New System.Windows.Forms.DataGridView()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.pnlBackground = New System.Windows.Forms.Panel()
        Me.pnlBarraSuperior.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBarraIzquierda.SuspendLayout()
        Me.pnlFormulario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTable.SuspendLayout()
        CType(Me.dgvTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenido.SuspendLayout()
        Me.pnlBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(926, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cancelería Velázquez - Administración de Trabajos"
        '
        'pnlBarraSuperior
        '
        Me.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlBarraSuperior.Controls.Add(Me.PictureBox2)
        Me.pnlBarraSuperior.Controls.Add(Me.Label1)
        Me.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarraSuperior.Name = "pnlBarraSuperior"
        Me.pnlBarraSuperior.Size = New System.Drawing.Size(1200, 69)
        Me.pnlBarraSuperior.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(13, 382)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 75)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(13, 255)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(130, 75)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Elimnar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(13, 21)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(130, 75)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(13, 140)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(130, 75)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'pnlBarraIzquierda
        '
        Me.pnlBarraIzquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlBarraIzquierda.Controls.Add(Me.btnCancelar)
        Me.pnlBarraIzquierda.Controls.Add(Me.btnEliminar)
        Me.pnlBarraIzquierda.Controls.Add(Me.btnEditar)
        Me.pnlBarraIzquierda.Controls.Add(Me.btnGuardar)
        Me.pnlBarraIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBarraIzquierda.Location = New System.Drawing.Point(0, 69)
        Me.pnlBarraIzquierda.Name = "pnlBarraIzquierda"
        Me.pnlBarraIzquierda.Size = New System.Drawing.Size(159, 658)
        Me.pnlBarraIzquierda.TabIndex = 7
        '
        'btnReporteTrabajos
        '
        Me.btnReporteTrabajos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporteTrabajos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReporteTrabajos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnReporteTrabajos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnReporteTrabajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteTrabajos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteTrabajos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnReporteTrabajos.Image = CType(resources.GetObject("btnReporteTrabajos.Image"), System.Drawing.Image)
        Me.btnReporteTrabajos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReporteTrabajos.Location = New System.Drawing.Point(26, 520)
        Me.btnReporteTrabajos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReporteTrabajos.Name = "btnReporteTrabajos"
        Me.btnReporteTrabajos.Size = New System.Drawing.Size(128, 112)
        Me.btnReporteTrabajos.TabIndex = 10
        Me.btnReporteTrabajos.Text = "Imprime reporte de trabajos"
        Me.btnReporteTrabajos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporteTrabajos.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(165, 21)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(42, 41)
        Me.btnSiguiente.TabIndex = 9
        Me.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnterior.Enabled = False
        Me.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(92, 21)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(42, 41)
        Me.btnAnterior.TabIndex = 8
        Me.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'txtCosto
        '
        Me.txtCosto.Enabled = False
        Me.txtCosto.Location = New System.Drawing.Point(26, 358)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(271, 29)
        Me.txtCosto.TabIndex = 7
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(22, 325)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(57, 21)
        Me.lblDomicilio.TabIndex = 6
        Me.lblDomicilio.Text = "Costo:"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(26, 275)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(271, 29)
        Me.txtCliente.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(22, 242)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(65, 21)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Cliente:"
        '
        'txtTrabajo
        '
        Me.txtTrabajo.Enabled = False
        Me.txtTrabajo.Location = New System.Drawing.Point(26, 188)
        Me.txtTrabajo.Name = "txtTrabajo"
        Me.txtTrabajo.Size = New System.Drawing.Size(271, 29)
        Me.txtTrabajo.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(22, 155)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 21)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Trabajo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(26, 106)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(271, 29)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(22, 73)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(68, 21)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'pnlFormulario
        '
        Me.pnlFormulario.Controls.Add(Me.dtpFechaTerminacion)
        Me.pnlFormulario.Controls.Add(Me.Label5)
        Me.pnlFormulario.Controls.Add(Me.btnReporteTrabajos)
        Me.pnlFormulario.Controls.Add(Me.btnSiguiente)
        Me.pnlFormulario.Controls.Add(Me.btnAnterior)
        Me.pnlFormulario.Controls.Add(Me.txtCosto)
        Me.pnlFormulario.Controls.Add(Me.lblDomicilio)
        Me.pnlFormulario.Controls.Add(Me.txtCliente)
        Me.pnlFormulario.Controls.Add(Me.lblTelefono)
        Me.pnlFormulario.Controls.Add(Me.txtTrabajo)
        Me.pnlFormulario.Controls.Add(Me.lblNombre)
        Me.pnlFormulario.Controls.Add(Me.txtCodigo)
        Me.pnlFormulario.Controls.Add(Me.lblCodigo)
        Me.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFormulario.Location = New System.Drawing.Point(0, 0)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(303, 658)
        Me.pnlFormulario.TabIndex = 0
        '
        'dtpFechaTerminacion
        '
        Me.dtpFechaTerminacion.Enabled = False
        Me.dtpFechaTerminacion.Location = New System.Drawing.Point(26, 442)
        Me.dtpFechaTerminacion.Name = "dtpFechaTerminacion"
        Me.dtpFechaTerminacion.Size = New System.Drawing.Size(271, 29)
        Me.dtpFechaTerminacion.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha de terminación:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(123, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(288, 29)
        Me.txtBuscar.TabIndex = 1
        '
        'pnlTable
        '
        Me.pnlTable.Controls.Add(Me.Label4)
        Me.pnlTable.Controls.Add(Me.Label3)
        Me.pnlTable.Controls.Add(Me.dtpFechaFin)
        Me.pnlTable.Controls.Add(Me.dtpFechaInicio)
        Me.pnlTable.Controls.Add(Me.PictureBox1)
        Me.pnlTable.Controls.Add(Me.Label2)
        Me.pnlTable.Controls.Add(Me.txtBuscar)
        Me.pnlTable.Controls.Add(Me.dgvTrabajos)
        Me.pnlTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTable.Location = New System.Drawing.Point(303, 0)
        Me.pnlTable.Name = "pnlTable"
        Me.pnlTable.Size = New System.Drawing.Size(738, 658)
        Me.pnlTable.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(572, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "al:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(425, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Del:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(604, 16)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(94, 29)
        Me.dtpFechaFin.TabIndex = 11
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(470, 17)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(94, 29)
        Me.dtpFechaInicio.TabIndex = 10
        '
        'dgvTrabajos
        '
        Me.dgvTrabajos.AllowUserToAddRows = False
        Me.dgvTrabajos.AllowUserToDeleteRows = False
        Me.dgvTrabajos.AllowUserToOrderColumns = True
        Me.dgvTrabajos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTrabajos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTrabajos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTrabajos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrabajos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvTrabajos.GridColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvTrabajos.Location = New System.Drawing.Point(23, 54)
        Me.dgvTrabajos.MultiSelect = False
        Me.dgvTrabajos.Name = "dgvTrabajos"
        Me.dgvTrabajos.ReadOnly = True
        Me.dgvTrabajos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTrabajos.Size = New System.Drawing.Size(703, 583)
        Me.dgvTrabajos.TabIndex = 0
        '
        'pnlContenido
        '
        Me.pnlContenido.Controls.Add(Me.pnlTable)
        Me.pnlContenido.Controls.Add(Me.pnlFormulario)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(159, 69)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1041, 658)
        Me.pnlContenido.TabIndex = 8
        '
        'pnlBackground
        '
        Me.pnlBackground.Controls.Add(Me.pnlContenido)
        Me.pnlBackground.Controls.Add(Me.pnlBarraIzquierda)
        Me.pnlBackground.Controls.Add(Me.pnlBarraSuperior)
        Me.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBackground.Location = New System.Drawing.Point(0, 0)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(1200, 727)
        Me.pnlBackground.TabIndex = 1
        '
        'FormTrabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 727)
        Me.Controls.Add(Me.pnlBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormTrabajos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelería Velázquez - Administración de Trabajos"
        Me.pnlBarraSuperior.ResumeLayout(False)
        Me.pnlBarraSuperior.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBarraIzquierda.ResumeLayout(False)
        Me.pnlFormulario.ResumeLayout(False)
        Me.pnlFormulario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTable.ResumeLayout(False)
        Me.pnlTable.PerformLayout()
        CType(Me.dgvTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlBackground.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlBarraSuperior As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pnlBarraIzquierda As Panel
    Friend WithEvents btnReporteTrabajos As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTrabajo As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents pnlTable As Panel
    Friend WithEvents dgvTrabajos As DataGridView
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents pnlBackground As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaTerminacion As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
