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
        ElseIf e.ColumnIndex = 6 Then
            GridBarangDataGridView.Rows(e.RowIndex).Cells(7).Value = Val(GridBarangDataGridView.Rows(e.RowIndex).Cells(5).Value) * Val(GridBarangDataGridView.Rows(e.RowIndex).Cells(6).Value)
        End If
    End Sub
End Class