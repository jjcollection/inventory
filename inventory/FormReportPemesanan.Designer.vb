<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportPemesanan
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbInventoryDataSet = New inventory.dbInventoryDataSet()
        Me.GridPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridPembelianTableAdapter = New inventory.dbInventoryDataSetTableAdapters.GridPembelianTableAdapter()
        CType(Me.dbInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetOrder"
        ReportDataSource1.Value = Me.GridPembelianBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "inventory.ReportPemesanan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(549, 410)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbInventoryDataSet
        '
        Me.dbInventoryDataSet.DataSetName = "dbInventoryDataSet"
        Me.dbInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridPembelianBindingSource
        '
        Me.GridPembelianBindingSource.DataMember = "GridPembelian"
        Me.GridPembelianBindingSource.DataSource = Me.dbInventoryDataSet
        '
        'GridPembelianTableAdapter
        '
        Me.GridPembelianTableAdapter.ClearBeforeFill = True
        '
        'FormReportPemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 410)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReportPemesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReportPemesanan"
        CType(Me.dbInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GridPembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbInventoryDataSet As inventory.dbInventoryDataSet
    Friend WithEvents GridPembelianTableAdapter As inventory.dbInventoryDataSetTableAdapters.GridPembelianTableAdapter
End Class
