Public Class FormJual
    Dim tbl As New DataTable
    Dim tgl, tahun, digit, kodebr As String
    Dim subtotal, hargabr As Double
    Sub kode_otomatis()
        PenjualanMasterTableAdapter.DeletePenjualanMasterNol()
        tgl = Date.Now.Day
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = Me.PenjualanMasterTableAdapter.GetDataByDesc
        If tbl.Rows.Count = 0 Then
            NoTransaksiTextBox.Text = tgl + digit + "0001"
        Else
            With tbl.Rows(0)
                NoTransaksiTextBox.Text = .Item("noTransaksi")
            End With
            NoTransaksiTextBox.Text = Val(Microsoft.VisualBasic.Mid(NoTransaksiTextBox.Text, 5, 4)) + 1
            If Len(NoTransaksiTextBox.Text) = 1 Then
                NoTransaksiTextBox.Text = tgl + digit + "000" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 2 Then
                NoTransaksiTextBox.Text = tgl + digit + "00" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 3 Then
                NoTransaksiTextBox.Text = tgl + digit + "0" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 4 Then
                NoTransaksiTextBox.Text = tgl + digit + NoTransaksiTextBox.Text
            End If

        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Public Sub tampilbrg(ByVal kodebarang As String, ByVal jumlah As String)
        Dim dt = BarangTableAdapter.GetDataByKode(kodebarang)
        Dim br = BarangTableAdapter.FillByKode(DbInventoryDataSet.Barang, kodebarang)
        If dt.Rows.Count = 0 Then
            MsgBox("Barang tidak ditemukan", MsgBoxStyle.Information, "Informasi")
        Else
            kodebr = dt.Rows(0).Item("namaBarang")
            hargabr = dt.Rows(0).Item("hargaJual")
            LabelInfo.Text = dt.Rows(0).Item("namaBarang") & "#" & Format(hargabr, "currency")
            JumlahBeliTextBox.Focus()
            Dim brj = BarangTableAdapter.GetDataByKode(kodebarang)
            Dim jmlstok = brj.Rows(0).Item("stok")
            If (Val(jmlstok) < Val(JumlahBeliTextBox.Text)) Then
                MsgBox("Stok tidak cukup")
            Else
                PenjualanDetilTableAdapter.InsertQuery(NoTransaksiTextBox.Text, kodebarang.ToUpper, jumlah, Val(jumlah) * hargabr)
                GridPenjualanTableAdapter.FillByTransaksi(DbInventoryDataSet.GridPenjualan, NoTransaksiTextBox.Text)

                Dim totalbelanja = PenjualanDetilTableAdapter.subtotal(NoTransaksiTextBox.Text)
                Dim totalItem = PenjualanDetilTableAdapter.totalitem(NoTransaksiTextBox.Text)

                lbTotal.Text = Format(totalbelanja, "Currency")
                lbitem.Text = "Item :" & totalItem
                lbTanggal.Text = Date.Today.Date
                PenjualanMasterTableAdapter.UpdateTotal(NoTransaksiTextBox.Text, totalItem, totalbelanja, NoTransaksiTextBox.Text)
                BarangTableAdapter.UpdateKurangiStok(kodebarang, jumlah, kodebarang)
                ' KodeBarangTextBox.Focus()
                KodeBarangTextBox.Text = ""
                JumlahBeliTextBox.Text = "1"
                btnenable()
            End If
        End If


    End Sub

    Private Sub KodeBarangTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KodeBarangTextBox.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim dt = BarangTableAdapter.GetDataByKode(KodeBarangTextBox.Text)
            Dim br = BarangTableAdapter.FillByKode(DbInventoryDataSet.Barang, KodeBarangTextBox.Text)
            If dt.Rows.Count = 0 Then
                MsgBox("Barang tidak ditemukan", MsgBoxStyle.Information, "Informasi")
            Else
                kodebr = dt.Rows(0).Item("namaBarang")
                hargabr = dt.Rows(0).Item("hargaJual")
                LabelInfo.Text = dt.Rows(0).Item("namaBarang") & "#" & Format(hargabr, "currency")
                JumlahBeliTextBox.Focus()
            End If
        End If

    End Sub
    Sub btnenable()
        If GridPenjualanDataGridView.RowCount = 0 Then
            btnBayar.Enabled = False
            btnBayar.Enabled = False
        Else
            btnBayar.Enabled = True
            btnBayar.Enabled = True
        End If
    End Sub
    Private Sub JumlahBeliTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JumlahBeliTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim br = BarangTableAdapter.GetDataByKode(KodeBarangTextBox.Text)
            Dim jmlstok = br.Rows(0).Item("stok")
            If (Val(jmlstok) < Val(JumlahBeliTextBox.Text)) Then
                MsgBox("Stok tidak cukup")
            Else
                PenjualanDetilTableAdapter.InsertQuery(NoTransaksiTextBox.Text, KodeBarangTextBox.Text.ToUpper, JumlahBeliTextBox.Text, Val(JumlahBeliTextBox.Text) * hargabr)
                GridPenjualanTableAdapter.FillByTransaksi(DbInventoryDataSet.GridPenjualan, NoTransaksiTextBox.Text)

                Dim totalbelanja = PenjualanDetilTableAdapter.subtotal(NoTransaksiTextBox.Text)
                Dim totalItem = PenjualanDetilTableAdapter.totalitem(NoTransaksiTextBox.Text)

                lbTotal.Text = Format(totalbelanja, "Currency")
                lbitem.Text = "Item :" & totalItem
                lbTanggal.Text = Date.Today.Date
                PenjualanMasterTableAdapter.UpdateTotal(NoTransaksiTextBox.Text, totalItem, totalbelanja, NoTransaksiTextBox.Text)
                BarangTableAdapter.UpdateKurangiStok(KodeBarangTextBox.Text, JumlahBeliTextBox.Text, KodeBarangTextBox.Text)
                KodeBarangTextBox.Focus()
                KodeBarangTextBox.Text = ""
                JumlahBeliTextBox.Text = "1"
                btnenable()
            End If
        End If
    End Sub

    Private Sub FormJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbInventoryDataSet.PenjualanMaster' table. You can move, or remove it, as needed.
        Me.PenjualanMasterTableAdapter.Fill(Me.DbInventoryDataSet.PenjualanMaster)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.PenjualanDetil' table. You can move, or remove it, as needed.
        Me.PenjualanDetilTableAdapter.Fill(Me.DbInventoryDataSet.PenjualanDetil)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DbInventoryDataSet.Barang)
        'TODO: This line of code loads data into the 'DbInventoryDataSet.GridPenjualan' table. You can move, or remove it, as needed.
        Me.GridPenjualanTableAdapter.Fill(Me.DbInventoryDataSet.GridPenjualan)
        lbTanggal.Text = Date.Now.Date
        If GridPenjualanDataGridView.RowCount = 0 Then
            btnBayar.Enabled = False
            btnBayar.Enabled = False
        Else
            btnBayar.Enabled = True
            btnBayar.Enabled = True
        End If
        ambiltransaksi(NoTransaksiTextBox.Text)
    End Sub


    Private Sub PenjualanDetilDataGridView_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub KodeBarangTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KodeBarangTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NoTransaksiTextBox.ReadOnly = False
    End Sub
    Public Sub ambiltransaksi(ByVal no As String)
        GridPenjualanTableAdapter.FillByTransaksi(DbInventoryDataSet.GridPenjualan, no)
    End Sub
    Private Sub NoTransaksiTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NoTransaksiTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            'GridPenjualanTableAdapter .GetDataByTransaksi (NoTransaksiTextBox .Text )
            GridPenjualanTableAdapter.FillByTransaksi(DbInventoryDataSet.GridPenjualan, NoTransaksiTextBox.Text)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DialogPenjualan.ShowDialog()
    End Sub

  


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            PenjualanDetilTableAdapter.DeleteQuery(GridPenjualanDataGridView.SelectedCells(0).Value)


            Dim totalbelanja = PenjualanDetilTableAdapter.subtotal(NoTransaksiTextBox.Text)
            Dim totalItem = PenjualanDetilTableAdapter.totalitem(NoTransaksiTextBox.Text)

            lbTotal.Text = totalbelanja
            lbitem.Text = "Item :" & totalItem
            lbTanggal.Text = Date.Today.Date

            PenjualanMasterTableAdapter.UpdateTotal(NoTransaksiTextBox.Text, totalItem, totalbelanja, NoTransaksiTextBox.Text)
            KodeBarangTextBox.Focus()
            KodeBarangTextBox.Text = ""
            JumlahBeliTextBox.Text = "1"
            btnenable()
            GridPenjualanTableAdapter.FillByTransaksi(DbInventoryDataSet.GridPenjualan, NoTransaksiTextBox.Text)
        Catch ex As Exception
            PenjualanMasterTableAdapter.DeleteQuery(NoTransaksiTextBox.Text)
            GridPenjualanTableAdapter.FillByTransaksi(DbInventoryDataSet.GridPenjualan, NoTransaksiTextBox.Text)
            lbTotal.Text = "0"
            lbitem.Text = "Item : 0"
            LabelInfo.Text = "-"
            NoTransaksiTextBox.Text = "-"
        End Try
    End Sub


    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

   
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DialogPenjualan.ShowDialog()
    End Sub

   
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try

            kode_otomatis()
            PenjualanMasterTableAdapter.InsertQuery(NoTransaksiTextBox.Text, Date.Now, 0, 0, 0, 0)
            GridPenjualanTableAdapter.FillByTransaksi(DbInventoryDataSet.GridPenjualan, NoTransaksiTextBox.Text)
            KodeBarangTextBox.Focus()
            JumlahBeliTextBox.Text = "1"
            lbitem.Text = "Item : 0"
            lbTotal.Text = "0"
            LabelInfo.Text = "-"
            KodeBarangTextBox.Text = ""
            btnenable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBayar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBayar.Click
        DialogBayar.lbTotal.Text = lbTotal.Text
        DialogBayar.fokuskan()
        DialogBayar.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogPembelian.OK_Button.BackColor = Color.Teal
        DialogPembelian.Cancel_Button.BackColor = Color.Teal
        DialogPembelian.ShowDialog()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        PenjualanMasterTableAdapter.DeleteQuery(NoTransaksiTextBox.Text)
        Button8.PerformClick()
    End Sub
End Class