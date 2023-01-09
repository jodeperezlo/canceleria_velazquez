<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTicketTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTicketTrabajo))
        Me.TicketTrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBCanceleriaVelazquezDataSet = New CanceleriaVelazquez.DBCanceleriaVelazquezDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TicketTrabajoTableAdapter = New CanceleriaVelazquez.DBCanceleriaVelazquezDataSetTableAdapters.TicketTrabajoTableAdapter()
        CType(Me.TicketTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBCanceleriaVelazquezDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TicketTrabajoBindingSource
        '
        Me.TicketTrabajoBindingSource.DataMember = "TicketTrabajo"
        Me.TicketTrabajoBindingSource.DataSource = Me.DBCanceleriaVelazquezDataSet
        '
        'DBCanceleriaVelazquezDataSet
        '
        Me.DBCanceleriaVelazquezDataSet.DataSetName = "DBCanceleriaVelazquezDataSet"
        Me.DBCanceleriaVelazquezDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsTicketTrabajo"
        ReportDataSource1.Value = Me.TicketTrabajoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CanceleriaVelazquez.ReportTicketTrabajo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(480, 726)
        Me.ReportViewer1.TabIndex = 0
        '
        'TicketTrabajoTableAdapter
        '
        Me.TicketTrabajoTableAdapter.ClearBeforeFill = True
        '
        'FormTicketTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 726)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FormTicketTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket de Trabajo"
        CType(Me.TicketTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBCanceleriaVelazquezDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TicketTrabajoBindingSource As BindingSource
    Friend WithEvents DBCanceleriaVelazquezDataSet As DBCanceleriaVelazquezDataSet
    Friend WithEvents TicketTrabajoTableAdapter As DBCanceleriaVelazquezDataSetTableAdapters.TicketTrabajoTableAdapter
End Class
