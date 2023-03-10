<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteMateriales
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteMateriales))
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBCanceleriaVelazquezDataSet = New CanceleriaVelazquez.DBCanceleriaVelazquezDataSet()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClientesTableAdapter = New CanceleriaVelazquez.DBCanceleriaVelazquezDataSetTableAdapters.ClientesTableAdapter()
        Me.ProveedoresTableAdapter = New CanceleriaVelazquez.DBCanceleriaVelazquezDataSetTableAdapters.ProveedoresTableAdapter()
        Me.MaterialesTableAdapter = New CanceleriaVelazquez.DBCanceleriaVelazquezDataSetTableAdapters.MaterialesTableAdapter()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBCanceleriaVelazquezDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DBCanceleriaVelazquezDataSet
        '
        'DBCanceleriaVelazquezDataSet
        '
        Me.DBCanceleriaVelazquezDataSet.DataSetName = "DBCanceleriaVelazquezDataSet"
        Me.DBCanceleriaVelazquezDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DBCanceleriaVelazquezDataSet
        '
        'MaterialesBindingSource
        '
        Me.MaterialesBindingSource.DataMember = "Materiales"
        Me.MaterialesBindingSource.DataSource = Me.DBCanceleriaVelazquezDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsClientes"
        ReportDataSource1.Value = Me.ClientesBindingSource
        ReportDataSource2.Name = "dsProveedores"
        ReportDataSource2.Value = Me.ProveedoresBindingSource
        ReportDataSource3.Name = "dsMateriales"
        ReportDataSource3.Value = Me.MaterialesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CanceleriaVelazquez.ReportMateriales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1200, 727)
        Me.ReportViewer1.TabIndex = 0
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'MaterialesTableAdapter
        '
        Me.MaterialesTableAdapter.ClearBeforeFill = True
        '
        'FormReporteMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 727)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormReporteMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelería Velázquez - Reporte de Materiales"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBCanceleriaVelazquezDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents DBCanceleriaVelazquezDataSet As DBCanceleriaVelazquezDataSet
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents MaterialesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DBCanceleriaVelazquezDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ProveedoresTableAdapter As DBCanceleriaVelazquezDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents MaterialesTableAdapter As DBCanceleriaVelazquezDataSetTableAdapters.MaterialesTableAdapter
End Class
