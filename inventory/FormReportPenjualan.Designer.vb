<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportPenjualan
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
        Me.GridPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbInventoryDataSet = New inventory.dbInventoryDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GridPenjualanTableAdapter = New inventory.dbInventoryDataSetTableAdapters.GridPenjualanTableAdapter()
        CType(Me.GridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPenjualanBindingSource
        '
        Me.GridPenjualanBindingSource.DataMember = "GridPenjualan"
        Me.GridPenjualanBindingSource.DataSource = Me.dbInventoryDataSet
        '
        'dbInventoryDataSet
        '
        Me.dbInventoryDataSet.DataSetName = "dbInventoryDataSet"
        Me.dbInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetPenjualan"
        ReportDataSource1.Value = Me.GridPenjualanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "inventory.ReportPenjualan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(764, 333)
        Me.ReportViewer1.TabIndex = 0
        '
        'GridPenjualanTableAdapter
        '
        Me.GridPenjualanTableAdapter.ClearBeforeFill = True
        '
        'FormReportPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 333)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReportPenjualan"
        Me.Text = "FormReportPenjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GridPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbInventoryDataSet As inventory.dbInventoryDataSet
    Friend WithEvents GridPenjualanTableAdapter As inventory.dbInventoryDataSetTableAdapters.GridPenjualanTableAdapter
End Class
