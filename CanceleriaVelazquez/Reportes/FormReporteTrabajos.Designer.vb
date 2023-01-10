<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteTrabajos
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteTrabajos))
        Me.ClientesTrabajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBCanceleriaVelazquezDataSet = New CanceleriaVelazquez.DBCanceleriaVelazquezDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClientesTrabajosTableAdapter = New CanceleriaVelazquez.DBCanceleriaVelazquezDataSetTableAdapters.ClientesTrabajosTableAdapter()
        CType(Me.ClientesTrabajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBCanceleriaVelazquezDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientesTrabajosBindingSource
        '
        Me.ClientesTrabajosBindingSource.DataMember = "ClientesTrabajos"
        Me.ClientesTrabajosBindingSource.DataSource = Me.DBCanceleriaVelazquezDataSet
        '
        'DBCanceleriaVelazquezDataSet
        '
        Me.DBCanceleriaVelazquezDataSet.DataSetName = "DBCanceleriaVelazquezDataSet"
        Me.DBCanceleriaVelazquezDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsClientesTrabajos"
        ReportDataSource1.Value = Me.ClientesTrabajosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CanceleriaVelazquez.ReportTrabajos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1200, 727)
        Me.ReportViewer1.TabIndex = 0
        '
        'ClientesTrabajosTableAdapter
        '
        Me.ClientesTrabajosTableAdapter.ClearBeforeFill = True
        '
        'FormReporteTrabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 727)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormReporteTrabajos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelería Velázquez - Reporte de Trabajos"
        CType(Me.ClientesTrabajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBCanceleriaVelazquezDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClientesTrabajosBindingSource As BindingSource
    Friend WithEvents DBCanceleriaVelazquezDataSet As DBCanceleriaVelazquezDataSet
    Friend WithEvents ClientesTrabajosTableAdapter As DBCanceleriaVelazquezDataSetTableAdapters.ClientesTrabajosTableAdapter
End Class
