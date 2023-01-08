<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.pnlFondo = New System.Windows.Forms.Panel()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.pnlBarraIzquierda = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnMaterial = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.pnlBarraSuperior = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.pnlFondo.SuspendLayout()
        Me.pnlContenido.SuspendLayout()
        Me.pnlBarraIzquierda.SuspendLayout()
        Me.pnlBarraSuperior.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFondo
        '
        Me.pnlFondo.Controls.Add(Me.pnlContenido)
        Me.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFondo.Location = New System.Drawing.Point(0, 0)
        Me.pnlFondo.Name = "pnlFondo"
        Me.pnlFondo.Size = New System.Drawing.Size(1266, 691)
        Me.pnlFondo.TabIndex = 1
        '
        'pnlContenido
        '
        Me.pnlContenido.Controls.Add(Me.pnlBarraIzquierda)
        Me.pnlContenido.Controls.Add(Me.pnlBarraSuperior)
        Me.pnlContenido.Controls.Add(Me.pbLogo)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1266, 691)
        Me.pnlContenido.TabIndex = 2
        '
        'pnlBarraIzquierda
        '
        Me.pnlBarraIzquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlBarraIzquierda.Controls.Add(Me.Button1)
        Me.pnlBarraIzquierda.Controls.Add(Me.btnProveedores)
        Me.pnlBarraIzquierda.Controls.Add(Me.btnMaterial)
        Me.pnlBarraIzquierda.Controls.Add(Me.btnClientes)
        Me.pnlBarraIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBarraIzquierda.Location = New System.Drawing.Point(0, 69)
        Me.pnlBarraIzquierda.Name = "pnlBarraIzquierda"
        Me.pnlBarraIzquierda.Size = New System.Drawing.Size(181, 622)
        Me.pnlBarraIzquierda.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(19, 420)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 75)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Trabajos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProveedores.Location = New System.Drawing.Point(19, 299)
        Me.btnProveedores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(130, 75)
        Me.btnProveedores.TabIndex = 2
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnMaterial
        '
        Me.btnMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaterial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnMaterial.Image = CType(resources.GetObject("btnMaterial.Image"), System.Drawing.Image)
        Me.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMaterial.Location = New System.Drawing.Point(19, 175)
        Me.btnMaterial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMaterial.Name = "btnMaterial"
        Me.btnMaterial.Size = New System.Drawing.Size(130, 75)
        Me.btnMaterial.TabIndex = 1
        Me.btnMaterial.Text = "Material"
        Me.btnMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMaterial.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.Location = New System.Drawing.Point(19, 54)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(130, 75)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'pnlBarraSuperior
        '
        Me.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlBarraSuperior.Controls.Add(Me.Label1)
        Me.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarraSuperior.Name = "pnlBarraSuperior"
        Me.pnlBarraSuperior.Size = New System.Drawing.Size(1266, 69)
        Me.pnlBarraSuperior.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cancelería Velázquez"
        '
        'pbLogo
        '
        Me.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(1266, 691)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLogo.TabIndex = 3
        Me.pbLogo.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1266, 691)
        Me.Controls.Add(Me.pnlFondo)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canceleria Velázquez"
        Me.pnlFondo.ResumeLayout(False)
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlBarraIzquierda.ResumeLayout(False)
        Me.pnlBarraSuperior.ResumeLayout(False)
        Me.pnlBarraSuperior.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFondo As Panel
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents pnlBarraIzquierda As Panel
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnMaterial As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents pnlBarraSuperior As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Button1 As Button
End Class
