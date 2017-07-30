Imports System.Windows.Forms

Public Class DialogPembelian
    Public lb As New Label
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If OK_Button.BackColor = Color.Teal Then
            'FormJual.KodeBarangTextBox.Text = NamaBarangComboBox.SelectedValue
            'FormJual.JumlahBeliTextBox.Text = TextBox1.Text
            FormJual.tampilbrg(NamaBarangComboBox.SelectedValue, TextBox1.Text)
        ElseIf OK_Button.BackColor = Color.Maroon Then
            If lb.Text <> "" Then
                PembelianDetilTableAdapter.UpdateQuery(NamaBarangComboBox.SelectedValue, TextBox1.Text, CDbl(HargaBeliLabel1.Text) * Val(TextBox1.Text), 0, "Sedang Dipesan", lb.Text)
                FormPembelian.tampilPembelian()
                PembelianMasterTableAdapter.UpdateItemTotal(FormPembelian.txtNo.Text, FormPembelian.item, FormPembelian.total, FormPembelian.txtNo.Text)
                lb.Text = ""
            Else
                Dim cekbeli = PembelianDetilTableAdapter.cekJmlBeli(FormPembelian.txtNo.Text, NamaBarangComboBox.SelectedValue)
                If cekbeli > 0 Then
                    PembelianDetilTableAdapter.UpdateJumlahBeli(NamaBarangComboBox.SelectedValue, TextBox1.Text, CDbl(HargaBeliLabel1.Text) * Val(TextBox1.Text), CDbl(HargaBeliLabel1.Text), NamaBarangComboBox.SelectedValue, FormPembelian.txtNo.Text)
                    FormPembelian.tampilPembelian()
                    PembelianMasterTableAdapter.UpdateItemTotal(FormPembelian.txtNo.Text, FormPembelian.item, FormPembelian.total, FormPembelian.txtNo.Text)
                Else
                    PembelianDetilTableAdapter.InsertQuery(FormPembelian.txtNo.Text, NamaBarangComboBox.SelectedValue, TextBox1.Text, CDbl(HargaBeliLabel1.Text) * Val(TextBox1.Text), 0, "Sedang Dipesan")
                    FormPembelian.tampilPembelian()
                    PembelianMasterTableAdapter.UpdateItemTotal(FormPembelian.txtNo.Text, FormPembelian.item, FormPembelian.total, FormPembelian.txtNo.Text)
                    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    'Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BarangBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbInventoryDataSet)

    End Sub

    Private Sub DialogPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbInventoryDataSet.PembelianMaster' table. You can move, or remove it, as needed.
        Me.PembelianMasterTableAdapter.Fill(Me.DbInventoryDataSet.PembelianMaster)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.PembelianDetil' table. You can move, or remove it, as needed.
        Me.PembelianDetilTableAdapter.Fill(Me.DbInventoryDataSet.PembelianDetil)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DbInventoryDataSet.Barang)

    End Sub

    Private Sub NamaBarangLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NamaBarangComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NamaBarangComboBox.SelectedIndexChanged
        TextBox1.Focus()
    End Sub
End Class
