Public Class FormReportPemesanan

    Private Sub FormReportPemesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbInventoryDataSet.GridPembelian' table. You can move, or remove it, as needed.
        Me.GridPembelianTableAdapter.FillByKode(Me.dbInventoryDataSet.GridPembelian, FormPembelian.txtNo.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FormReportPemesanan_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub
End Class