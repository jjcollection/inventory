Public Class FormReportPenjualan

    Private Sub FormReportPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbInventoryDataSet.GridPenjualan' table. You can move, or remove it, as needed.
        Me.GridPenjualanTableAdapter.Fill(Me.dbInventoryDataSet.GridPenjualan)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class