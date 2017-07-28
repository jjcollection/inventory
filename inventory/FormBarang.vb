Public Class FormBarang

    Private Sub BarangBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbInventoryDataSet)

    End Sub

    Private Sub FormBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbInventoryDataSet.Jenis' table. You can move, or remove it, as needed.
        Me.JenisTableAdapter.Fill(Me.DbInventoryDataSet.Jenis)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.Merk' table. You can move, or remove it, as needed.
        Me.MerkTableAdapter.Fill(Me.DbInventoryDataSet.Merk)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.GridBarang' table. You can move, or remove it, as needed.
        Me.GridBarangTableAdapter.Fill(Me.DbInventoryDataSet.GridBarang)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DbInventoryDataSet.Barang)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            BarangTableAdapter.InsertBarang(KodeBarangTextBox.Text, IdMerkComboBox.SelectedValue, UkuranTextBox.Text, 0, 0, 0, IdJenisComboBox.SelectedValue, IdJenisComboBox.Text & "#" & IdMerkComboBox.Text & "#" & UkuranTextBox.Text)
            MsgBox("data telah disimpan", MsgBoxStyle.Information, "Informasi")
            Me.GridBarangTableAdapter.Fill(Me.DbInventoryDataSet.GridBarang)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        KodeBarangTextBox.Text = ""
        KodeBarangTextBox.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class