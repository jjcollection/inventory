Public Class FormReportPenjualan

    Private Sub FormReportPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbInventoryDataSet.GridPenjualan' table. You can move, or remove it, as needed.
        Me.GridPenjualanTableAdapter.Fill(Me.dbInventoryDataSet.GridPenjualan)

        Me.ReportViewer1.RefreshReport()

    End Sub
    Private count As Integer = 0
    Private iniRow As Integer = 0
    Private iniGrp As Object = ""
    Public Function MatrixRow(ByVal rowNum As Integer, ByVal rowGrp As Object) As Integer

        If iniGrp = "" Then
            iniGrp = rowGrp
        End If

        If rowGrp <> iniGrp Then
            iniRow = 0
            count = 0
            iniGrp = rowGrp
        End If

        If iniRow = 0 Then
            iniRow = rowNum
        End If

        If rowNum = iniRow Then
            count = 0
        End If

        count = count + 1
        Return count
    End Function

    Private Sub FormReportPenjualan_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub
End Class