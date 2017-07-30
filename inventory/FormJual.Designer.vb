<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NoTransaksiLabel = New System.Windows.Forms.Label()
        Me.JumlahBeliLabel = New System.Windows.Forms.Label()
        Me.KodeBarangLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.KodeBarangTextBox = New System.Windows.Forms.TextBox()
        Me.JumlahBeliTextBox = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbTanggal = New System.Windows.Forms.Label()
        Me.NoTransaksiTextBox = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.GridPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbInventoryDataSet = New inventory.dbInventoryDataSet()
        Me.idPenjulanDetil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridPenjualanTableAdapter = New inventory.dbInventoryDataSetTableAdapters.GridPenjualanTableAdapter()
        Me.TableAdapterManager = New inventory.dbInventoryDataSetTableAdapters.TableAdapterManager()
        Me.BarangTableAdapter = New inventory.dbInventoryDataSetTableAdapters.BarangTableAdapter()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanDetilTableAdapter = New inventory.dbInventoryDataSetTableAdapters.PenjualanDetilTableAdapter()
        Me.PenjualanMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanMasterTableAdapter = New inventory.dbInventoryDataSetTableAdapters.PenjualanMasterTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbitem = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridPenjualanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.GridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridPenjualanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoTransaksiLabel
        '
        Me.NoTransaksiLabel.AutoSize = True
        Me.NoTransaksiLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTransaksiLabel.Location = New System.Drawing.Point(7, 29)
        Me.NoTransaksiLabel.Name = "NoTransaksiLabel"
        Me.NoTransaksiLabel.Size = New System.Drawing.Size(107, 21)
        Me.NoTransaksiLabel.TabIndex = 3
        Me.NoTransaksiLabel.Text = "No Transaksi"
        '
        'JumlahBeliLabel
        '
        Me.JumlahBeliLabel.AutoSize = True
        Me.JumlahBeliLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahBeliLabel.Location = New System.Drawing.Point(7, 99)
        Me.JumlahBeliLabel.Name = "JumlahBeliLabel"
        Me.JumlahBeliLabel.Size = New System.Drawing.Size(70, 21)
        Me.JumlahBeliLabel.TabIndex = 7
        Me.JumlahBeliLabel.Text = "Jumlah "
        '
        'KodeBarangLabel
        '
        Me.KodeBarangLabel.AutoSize = True
        Me.KodeBarangLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeBarangLabel.Location = New System.Drawing.Point(7, 64)
        Me.KodeBarangLabel.Name = "KodeBarangLabel"
        Me.KodeBarangLabel.Size = New System.Drawing.Size(107, 21)
        Me.KodeBarangLabel.TabIndex = 5
        Me.KodeBarangLabel.Text = "Kode Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(127, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(127, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 21)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = ":"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1134, 239)
        Me.Panel4.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.KodeBarangTextBox)
        Me.Panel5.Controls.Add(Me.JumlahBeliTextBox)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.NoTransaksiLabel)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.JumlahBeliLabel)
        Me.Panel5.Controls.Add(Me.NoTransaksiTextBox)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.KodeBarangLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1132, 147)
        Me.Panel5.TabIndex = 14
        '
        'KodeBarangTextBox
        '
        Me.KodeBarangTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeBarangTextBox.Location = New System.Drawing.Point(145, 60)
        Me.KodeBarangTextBox.Name = "KodeBarangTextBox"
        Me.KodeBarangTextBox.Size = New System.Drawing.Size(340, 29)
        Me.KodeBarangTextBox.TabIndex = 6
        '
        'JumlahBeliTextBox
        '
        Me.JumlahBeliTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahBeliTextBox.Location = New System.Drawing.Point(145, 95)
        Me.JumlahBeliTextBox.Name = "JumlahBeliTextBox"
        Me.JumlahBeliTextBox.Size = New System.Drawing.Size(56, 29)
        Me.JumlahBeliTextBox.TabIndex = 8
        Me.JumlahBeliTextBox.Text = "1"
        Me.JumlahBeliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.lbTanggal)
        Me.Panel7.Location = New System.Drawing.Point(823, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(308, 30)
        Me.Panel7.TabIndex = 13
        '
        'lbTanggal
        '
        Me.lbTanggal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbTanggal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbTanggal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTanggal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTanggal.ForeColor = System.Drawing.Color.White
        Me.lbTanggal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbTanggal.Location = New System.Drawing.Point(0, 0)
        Me.lbTanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTanggal.Name = "lbTanggal"
        Me.lbTanggal.Size = New System.Drawing.Size(304, 26)
        Me.lbTanggal.TabIndex = 5
        Me.lbTanggal.Text = "## : ## : ####"
        Me.lbTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NoTransaksiTextBox
        '
        Me.NoTransaksiTextBox.BackColor = System.Drawing.Color.Black
        Me.NoTransaksiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NoTransaksiTextBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTransaksiTextBox.ForeColor = System.Drawing.Color.Lime
        Me.NoTransaksiTextBox.Location = New System.Drawing.Point(145, 25)
        Me.NoTransaksiTextBox.Name = "NoTransaksiTextBox"
        Me.NoTransaksiTextBox.ReadOnly = True
        Me.NoTransaksiTextBox.Size = New System.Drawing.Size(340, 28)
        Me.NoTransaksiTextBox.TabIndex = 4
        Me.NoTransaksiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.LabelInfo)
        Me.Panel9.Location = New System.Drawing.Point(2, 150)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1127, 83)
        Me.Panel9.TabIndex = 12
        '
        'LabelInfo
        '
        Me.LabelInfo.BackColor = System.Drawing.Color.White
        Me.LabelInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelInfo.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelInfo.Location = New System.Drawing.Point(0, 0)
        Me.LabelInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(1123, 79)
        Me.LabelInfo.TabIndex = 2
        Me.LabelInfo.Text = "-"
        Me.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridPenjualanBindingSource
        '
        Me.GridPenjualanBindingSource.DataMember = "GridPenjualan"
        Me.GridPenjualanBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'DbInventoryDataSet
        '
        Me.DbInventoryDataSet.DataSetName = "dbInventoryDataSet"
        Me.DbInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'idPenjulanDetil
        '
        Me.idPenjulanDetil.DataPropertyName = "idPenjulanDetil"
        Me.idPenjulanDetil.HeaderText = "idPenjulanDetil"
        Me.idPenjulanDetil.Name = "idPenjulanDetil"
        Me.idPenjulanDetil.ReadOnly = True
        Me.idPenjulanDetil.Visible = False
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "kodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodeBarangDataGridViewTextBoxColumn.Width = 150
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        Me.NamaBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn.Width = 280
        '
        'SatuanDataGridViewTextBoxColumn
        '
        Me.SatuanDataGridViewTextBoxColumn.DataPropertyName = "satuan"
        Me.SatuanDataGridViewTextBoxColumn.HeaderText = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.Name = "SatuanDataGridViewTextBoxColumn"
        Me.SatuanDataGridViewTextBoxColumn.ReadOnly = True
        Me.SatuanDataGridViewTextBoxColumn.Width = 80
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        Me.HargaDataGridViewTextBoxColumn.Width = 180
        '
        'JumlahBeliDataGridViewTextBoxColumn
        '
        Me.JumlahBeliDataGridViewTextBoxColumn.DataPropertyName = "jumlahBeli"
        Me.JumlahBeliDataGridViewTextBoxColumn.HeaderText = "Jml"
        Me.JumlahBeliDataGridViewTextBoxColumn.Name = "JumlahBeliDataGridViewTextBoxColumn"
        Me.JumlahBeliDataGridViewTextBoxColumn.ReadOnly = True
        Me.JumlahBeliDataGridViewTextBoxColumn.Width = 50
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "subTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "Sub Total"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GridPenjualanTableAdapter
        '
        Me.GridPenjualanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.JenisTableAdapter = Nothing
        Me.TableAdapterManager.KaryawanTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.PembelianDetilTableAdapter = Nothing
        Me.TableAdapterManager.PembelianMasterTableAdapter = Nothing
        Me.TableAdapterManager.PengaturanTableAdapter = Nothing
        Me.TableAdapterManager.PengeluaranTableAdapter = Nothing
        Me.TableAdapterManager.PenjualanDetilTableAdapter = Nothing
        Me.TableAdapterManager.PenjualanMasterTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = inventory.dbInventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'PenjualanDetilBindingSource
        '
        Me.PenjualanDetilBindingSource.DataMember = "PenjualanDetil"
        Me.PenjualanDetilBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'PenjualanDetilTableAdapter
        '
        Me.PenjualanDetilTableAdapter.ClearBeforeFill = True
        '
        'PenjualanMasterBindingSource
        '
        Me.PenjualanMasterBindingSource.DataMember = "PenjualanMaster"
        Me.PenjualanMasterBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'PenjualanMasterTableAdapter
        '
        Me.PenjualanMasterTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.lbitem)
        Me.Panel3.Controls.Add(Me.lbTotal)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.btnHapus)
        Me.Panel3.Controls.Add(Me.btnBayar)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 691)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1134, 41)
        Me.Panel3.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.inventory.My.Resources.Resources.Search_16px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(986, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 32)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cari"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lbitem
        '
        Me.lbitem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbitem.BackColor = System.Drawing.Color.Red
        Me.lbitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbitem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbitem.ForeColor = System.Drawing.Color.White
        Me.lbitem.Location = New System.Drawing.Point(664, 6)
        Me.lbitem.Name = "lbitem"
        Me.lbitem.Size = New System.Drawing.Size(89, 28)
        Me.lbitem.TabIndex = 7
        Me.lbitem.Text = "0"
        Me.lbitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotal
        '
        Me.lbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTotal.BackColor = System.Drawing.Color.Red
        Me.lbTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.White
        Me.lbTotal.Location = New System.Drawing.Point(759, 6)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(219, 28)
        Me.lbTotal.TabIndex = 6
        Me.lbTotal.Text = "Rp0"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Maroon
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.inventory.My.Resources.Resources.Cancel_25px
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(1051, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Keluar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHapus.Image = Global.inventory.My.Resources.Resources.Eraser_25px
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(249, 4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(81, 32)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBayar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBayar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBayar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBayar.Image = Global.inventory.My.Resources.Resources.Edit_25px
        Me.btnBayar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBayar.Location = New System.Drawing.Point(172, 4)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(75, 32)
        Me.btnBayar.TabIndex = 3
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Image = Global.inventory.My.Resources.Resources.Add_Shopping_Cart_25px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(82, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tambah"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.Image = Global.inventory.My.Resources.Resources.Plus_25px
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(3, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(77, 32)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Baru"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GridPenjualanDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 239)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 452)
        Me.Panel1.TabIndex = 18
        '
        'GridPenjualanDataGridView
        '
        Me.GridPenjualanDataGridView.AllowUserToAddRows = False
        Me.GridPenjualanDataGridView.AllowUserToDeleteRows = False
        Me.GridPenjualanDataGridView.AutoGenerateColumns = False
        Me.GridPenjualanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPenjualanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4})
        Me.GridPenjualanDataGridView.DataSource = Me.GridPenjualanBindingSource
        Me.GridPenjualanDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPenjualanDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.GridPenjualanDataGridView.Name = "GridPenjualanDataGridView"
        Me.GridPenjualanDataGridView.ReadOnly = True
        Me.GridPenjualanDataGridView.Size = New System.Drawing.Size(1134, 452)
        Me.GridPenjualanDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idPenjulanDetil"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idPenjulanDetil"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "noTransaksi"
        Me.DataGridViewTextBoxColumn1.HeaderText = "noTransaksi"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "kodeBarang"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Kode Barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "namaBarang"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "jumlahBeli"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jml"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "hargaJual"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.HeaderText = "Harga Jual"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "subTotal"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 180
        '
        'FormJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1134, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormJual"
        Me.Text = "FormJual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.GridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridPenjualanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents KodeBarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JumlahBeliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoTransaksiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents LabelInfo As System.Windows.Forms.Label
    Friend WithEvents lbTanggal As System.Windows.Forms.Label
    Friend WithEvents idPenjulanDetil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoTransaksiLabel As System.Windows.Forms.Label
    Friend WithEvents JumlahBeliLabel As System.Windows.Forms.Label
    Friend WithEvents KodeBarangLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DbInventoryDataSet As inventory.dbInventoryDataSet
    Friend WithEvents GridPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridPenjualanTableAdapter As inventory.dbInventoryDataSetTableAdapters.GridPenjualanTableAdapter
    Friend WithEvents TableAdapterManager As inventory.dbInventoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BarangTableAdapter As inventory.dbInventoryDataSetTableAdapters.BarangTableAdapter
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenjualanDetilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenjualanDetilTableAdapter As inventory.dbInventoryDataSetTableAdapters.PenjualanDetilTableAdapter
    Friend WithEvents PenjualanMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenjualanMasterTableAdapter As inventory.dbInventoryDataSetTableAdapters.PenjualanMasterTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbitem As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBayar As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridPenjualanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
