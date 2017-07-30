Imports System.Windows.Forms

Public Class DialogPenjualan

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        FormJual.NoTransaksiTextBox.Text = NoTransaksiComboBox.Text
        FormJual.ambiltransaksi(NoTransaksiComboBox.Text)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

   

    Private Sub DialogPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbInventoryDataSet.PenjualanMaster' table. You can move, or remove it, as needed.
        Me.PenjualanMasterTableAdapter.Fill(Me.DbInventoryDataSet.PenjualanMaster)
        'TODO: This line of code loads data into the 'PenjualanDataSet.PenjualanMaster' table. You can move, or remove it, as needed.
        ' Me.PenjualanMasterTableAdapter.FillByPilihDe(Me.PenjualanDataSet.PenjualanMaster)

    End Sub

    Private Sub PenjualanMasterBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanMasterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PenjualanMasterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbInventoryDataSet)

    End Sub
End Class
