Public Class FormPembelian
    Dim tbl As New DataTable
    Dim tgl, tahun, digit, kodebr As String
    Dim subtotal, hargabr As Double
    Public total, item As Double

    Sub kode_otomatis()
        PembelianMasterTableAdapter.DeletePembelianItemNol()
        tgl = Date.Now.Day
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = Me.PembelianMasterTableAdapter.GetDataByDesc
        If tbl.Rows.Count = 0 Then
            txtNo.Text = tgl + digit + "0001"
        Else
            With tbl.Rows(0)
                txtNo.Text = .Item("idPembelianMaster")
            End With
            txtNo.Text = Val(Microsoft.VisualBasic.Mid(txtNo.Text, 5, 4)) + 1
            If Len(txtNo.Text) = 1 Then
                txtNo.Text = tgl + digit + "000" & txtNo.Text & ""
            ElseIf Len(txtNo.Text) = 2 Then
                txtNo.Text = tgl + digit + "00" & txtNo.Text & ""
            ElseIf Len(txtNo.Text) = 3 Then
                txtNo.Text = tgl + digit + "0" & txtNo.Text & ""
            ElseIf Len(txtNo.Text) = 4 Then
                txtNo.Text = tgl + digit + txtNo.Text
            End If

        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kode_otomatis()
        PembelianMasterTableAdapter.InsertQuery(txtNo.Text, IdSupplierComboBox.SelectedValue, Date.Now.Date, 0, 0, "Sedang dipesan")
        txtTgl.Text = Date.Now.Date
    End Sub

    Private Sub SupplierBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbInventoryDataSet)

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

    Private Sub FormPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kode_otomatis()
        'TODO: This line of code loads data into the 'DbInventoryDataSet.PembelianDetil' table. You can move, or remove it, as needed.
        Me.PembelianDetilTableAdapter.Fill(Me.DbInventoryDataSet.PembelianDetil)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.PembelianMaster' table. You can move, or remove it, as needed.
        Me.PembelianMasterTableAdapter.Fill(Me.DbInventoryDataSet.PembelianMaster)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.GridPembelian' table. You can move, or remove it, as needed.
        tampilPembelian()
        'TODO: This line of code loads data into the 'DbInventoryDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DbInventoryDataSet.Supplier)

    End Sub

    Private Sub TextBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.MouseHover, txtTgl.MouseHover, txtNo.MouseHover
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DialogPembelian.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Try
            Me.GridPembelianTableAdapter.FillByKode(Me.DbInventoryDataSet.GridPembelian, TextBox1.Text)
            Dim dt = GridPembelianTableAdapter.GetDataByKode(TextBox1.Text)
            txtNo.Text = dt.Rows(0).Item("idPembelianMaster")
            txtTgl.Text = dt.Rows(0).Item("tanggalBeli")
            IdSupplierComboBox.SelectedValue = dt.Rows(0).Item("idSupplier")
            total = PembelianDetilTableAdapter.ScalarSumSubTotal(txtNo.Text)
            item = PembelianDetilTableAdapter.ScalarItem(txtNo.Text)
            lbTotal.Text = "Total : " & Format(total, "Currency")
            lbItem.Text = "Item : " & item
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub

    Private Sub GridBarangDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridBarangDataGridView.CellClick

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DialogPembelian.NamaBarangComboBox.SelectedValue = GridBarangDataGridView.SelectedCells(2).Value
        DialogPembelian.TextBox1.Text = GridBarangDataGridView.SelectedCells(8).Value
        DialogPembelian.lb.Text = GridBarangDataGridView.SelectedCells(1).Value
        DialogPembelian.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PembelianDetilTableAdapter.DeleteQuery(GridBarangDataGridView.SelectedCells(1).Value)
        tampilPembelian()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If MessageBox.Show("Anda yakin akan mengahpus pemesanan no " & txtNo.Text & " ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                PembelianMasterTableAdapter.DeleteQuery(txtNo.Text)
                tampilPembelian()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class