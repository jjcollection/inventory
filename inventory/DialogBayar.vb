Imports System.Windows.Forms

Public Class DialogBayar

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

  

    Public Sub fokuskan()
        txtBayar.Text = ""
        txtBayar.Focus()

    End Sub
  
    Private Sub txtBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub txtBayar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim kembali = CDbl(txtBayar.Text) - CDbl(lbTotal.Text)
                lbKembali.Text = Format(kembali, "Currency")
                txtBayar.Text = Format(txtBayar.Text, "Currency")
                PenjualanMasterTableAdapter.UpdateBayar(FormJual.NoTransaksiTextBox.Text, txtBayar.Text, kembali, FormJual.NoTransaksiTextBox.Text)
                If MessageBox.Show("Cetak Kwitansi ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'FormReportKwitansi.ShowDialog()
                Else
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PenjualanMasterBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PenjualanMasterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbInventoryDataSet)

    End Sub

   
End Class
