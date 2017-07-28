Public Class FormTerimaBarang
    Dim total, item As Double
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Try
            Me.GridPembelianTableAdapter.FillByKode(Me.DbInventoryDataSet.GridPembelian, TextBox1.Text)
            Dim dt = GridPembelianTableAdapter.GetDataByKode(TextBox1.Text)
            txtNo.Text = dt.Rows(0).Item("idPembelianMaster")
            txtTgl.Text = dt.Rows(0).Item("tanggalBeli")
            IdSupplierComboBox.SelectedValue = dt.Rows(0).Item("idSupplier")
            Dim total = PembelianDetilTableAdapter.ScalarSumSubTotal(txtNo.Text)
            Dim jitem = PembelianDetilTableAdapter.ScalarItem(txtNo.Text)
            lbTotal.Text = "Total : " & Format(total, "Currency")
            lbItem.Text = "Item : " & jitem
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub hitungsummary()
        Dim qry0 = From theRow As DataGridViewRow In GridBarangDataGridView.Rows Select theRow
        total = qry0.Sum(Function(x As DataGridViewRow) CDec(x.Cells(11).Value))
        lbTotal.Text = Format(total, "Currency")
    End Sub
    Public Sub hitungItem()
        item = GridBarangDataGridView.Rows.Count
        lbitem.Text = "Item : " & Format(item, "0.###")
    End Sub
    Public Sub tampilPembelian()
        Try
            Me.GridPembelianTableAdapter.FillByKode(Me.DbInventoryDataSet.GridPembelian, txtNo.Text)
            total = PembelianDetilTableAdapter.ScalarSumSubTotal(txtNo.Text)
            item = PembelianDetilTableAdapter.ScalarItem(txtNo.Text)
            lbTotal.Text = "Total : " & Format(total, "Currency")
            lbItem.Text = "Item : " & item
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormTerimaBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbInventoryDataSet.Pengaturan' table. You can move, or remove it, as needed.
        Me.PengaturanTableAdapter.Fill(Me.DbInventoryDataSet.Pengaturan)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DbInventoryDataSet.Barang)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.PembelianMaster' table. You can move, or remove it, as needed.
        Me.PembelianMasterTableAdapter.Fill(Me.DbInventoryDataSet.PembelianMaster)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.PembelianDetil' table. You can move, or remove it, as needed.
        Me.PembelianDetilTableAdapter.Fill(Me.DbInventoryDataSet.PembelianDetil)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.GridPembelian' table. You can move, or remove it, as needed.
        tampilPembelian()
    End Sub


    Private Sub TextBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.MouseHover
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub GridBarangDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridBarangDataGridView.CellEndEdit
        If e.ColumnIndex = 5 Then
            'Dim mEditRow As Integer = -1
            'Dim NewRow As Integer = mEditRow
            'mEditRow = -1
            'PenjualanDetilDataGridView.CurrentCell = PenjualanDetilDataGridView.Rows(NewRow).Cells(PenjualanDetilDataGridView.CurrentCell.ColumnIndex)
        ElseIf e.ColumnIndex = 10 Then
            GridBarangDataGridView.Rows(e.RowIndex).Cells(11).Value = Val(GridBarangDataGridView.Rows(e.RowIndex).Cells(9).Value) * Val(GridBarangDataGridView.Rows(e.RowIndex).Cells(10).Value)
            hitungItem()
            hitungsummary()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim atur = PengaturanTableAdapter.GetDataByKeuntungan
        Dim persen As Double
        persen = atur.Rows(0).Item("Keuntungan")
        Try
            For i As Integer = 0 To GridBarangDataGridView.Rows.Count - 1
                PembelianDetilTableAdapter.UpdateQuery(GridBarangDataGridView.Rows(i).Cells(2).Value, Val(GridBarangDataGridView.Rows(i).Cells(9).Value), CDbl(GridBarangDataGridView.Rows(i).Cells(11).Value), CDbl(GridBarangDataGridView.Rows(i).Cells(10).Value), "Baik", Val(GridBarangDataGridView.Rows(i).Cells(1).Value))
                BarangTableAdapter.UpdateJumlah(GridBarangDataGridView.Rows(i).Cells(2).Value, Val(GridBarangDataGridView.Rows(i).Cells(9).Value), CDbl(GridBarangDataGridView.Rows(i).Cells(10).Value), ((CDbl(persen) / 100) * CDbl(GridBarangDataGridView.Rows(i).Cells(10).Value)) + CDbl(GridBarangDataGridView.Rows(i).Cells(10).Value), GridBarangDataGridView.Rows(i).Cells(2).Value)
            Next
            PembelianMasterTableAdapter.UpdateTotalItemStatus(txtNo.Text, item, total, txtNo.Text)
            MsgBox("Data telah disimpan.", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class