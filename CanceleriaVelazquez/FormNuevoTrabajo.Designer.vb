<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoTrabajo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNuevoTrabajo))
        Me.pnlBackground = New System.Windows.Forms.Panel()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblTrabajoPara = New System.Windows.Forms.Label()
        Me.dtpFechaTerminacion = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.txtTrabajo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.pnlBarraIzquierda = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlBarraSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBackground.SuspendLayout()
        Me.pnlContenido.SuspendLayout()
        Me.pnlBarraIzquierda.SuspendLayout()
        Me.pnlBarraSuperior.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBackground
        '
        Me.pnlBackground.Controls.Add(Me.pnlContenido)
        Me.pnlBackground.Controls.Add(Me.pnlBarraIzquierda)
        Me.pnlBackground.Controls.Add(Me.pnlBarraSuperior)
        Me.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBackground.Location = New System.Drawing.Point(0, 0)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(499, 387)
        Me.pnlBackground.TabIndex = 2
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlContenido.Controls.Add(Me.lblCliente)
        Me.pnlContenido.Controls.Add(Me.lblTrabajoPara)
        Me.pnlContenido.Controls.Add(Me.dtpFechaTerminacion)
        Me.pnlContenido.Controls.Add(Me.Label5)
        Me.pnlContenido.Controls.Add(Me.txtCosto)
        Me.pnlContenido.Controls.Add(Me.lblDomicilio)
        Me.pnlContenido.Controls.Add(Me.txtTrabajo)
        Me.pnlContenido.Controls.Add(Me.lblNombre)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(159, 69)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(340, 318)
        Me.pnlContenido.TabIndex = 8
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(111, 13)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(151, 21)
        Me.lblCliente.TabIndex = 22
        Me.lblCliente.Text = "Nombre del cliente"
        '
        'lblTrabajoPara
        '
        Me.lblTrabajoPara.AutoSize = True
        Me.lblTrabajoPara.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrabajoPara.Location = New System.Drawing.Point(6, 13)
        Me.lblTrabajoPara.Name = "lblTrabajoPara"
        Me.lblTrabajoPara.Size = New System.Drawing.Size(99, 21)
        Me.lblTrabajoPara.TabIndex = 21
        Me.lblTrabajoPara.Text = "Trabajo para:"
        '
        'dtpFechaTerminacion
        '
        Me.dtpFechaTerminacion.Location = New System.Drawing.Point(10, 240)
        Me.dtpFechaTerminacion.Name = "dtpFechaTerminacion"
        Me.dtpFechaTerminacion.Size = New System.Drawing.Size(271, 29)
        Me.dtpFechaTerminacion.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 21)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Fecha de terminación:"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(10, 155)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(271, 29)
        Me.txtCosto.TabIndex = 18
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(6, 122)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(57, 21)
        Me.lblDomicilio.TabIndex = 17
        Me.lblDomicilio.Text = "Costo:"
        '
        'txtTrabajo
        '
        Me.txtTrabajo.Location = New System.Drawing.Point(10, 88)
        Me.txtTrabajo.Name = "txtTrabajo"
        Me.txtTrabajo.Size = New System.Drawing.Size(271, 29)
        Me.txtTrabajo.TabIndex = 16
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(6, 55)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 21)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Trabajo:"
        '
        'pnlBarraIzquierda
        '
        Me.pnlBarraIzquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlBarraIzquierda.Controls.Add(Me.btnCancelar)
        Me.pnlBarraIzquierda.Controls.Add(Me.btnGuardar)
        Me.pnlBarraIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBarraIzquierda.Location = New System.Drawing.Point(0, 69)
        Me.pnlBarraIzquierda.Name = "pnlBarraIzquierda"
        Me.pnlBarraIzquierda.Size = New System.Drawing.Size(159, 318)
        Me.pnlBarraIzquierda.TabIndex = 7
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(13, 144)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 75)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(13, 24)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(130, 75)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'pnlBarraSuperior
        '
        Me.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlBarraSuperior.Controls.Add(Me.PictureBox2)
        Me.pnlBarraSuperior.Controls.Add(Me.Label1)
        Me.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarraSuperior.Name = "pnlBarraSuperior"
        Me.pnlBarraSuperior.Size = New System.Drawing.Size(499, 69)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo Trabajo"
        '
        'FormNuevoTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 387)
        Me.Controls.Add(Me.pnlBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FormNuevoTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Trabajo"
        Me.pnlBackground.ResumeLayout(False)
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        Me.pnlBarraIzquierda.ResumeLayout(False)
        Me.pnlBarraSuperior.ResumeLayout(False)
        Me.pnlBarraSuperior.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBackground As Panel
    Friend WithEvents pnlBarraIzquierda As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pnlBarraSuperior As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents dtpFechaTerminacion As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents txtTrabajo As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTrabajoPara As Label
    Friend WithEvents lblCliente As Label
End Class
