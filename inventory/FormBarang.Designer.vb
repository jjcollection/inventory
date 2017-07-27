<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Dim KodeBarangLabel As System.Windows.Forms.Label
        Dim UkuranLabel As System.Windows.Forms.Label
        Dim HargaJualLabel As System.Windows.Forms.Label
        Dim IdMerkLabel As System.Windows.Forms.Label
        Dim IdJenisLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GridBarangDataGridView = New System.Windows.Forms.DataGridView()
        Me.GridBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbInventoryDataSet = New inventory.dbInventoryDataSet()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdJenisComboBox = New System.Windows.Forms.ComboBox()
        Me.JenisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdMerkComboBox = New System.Windows.Forms.ComboBox()
        Me.MerkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KodeBarangTextBox = New System.Windows.Forms.TextBox()
        Me.UkuranTextBox = New System.Windows.Forms.TextBox()
        Me.HargaJualTextBox = New System.Windows.Forms.TextBox()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New inventory.dbInventoryDataSetTableAdapters.BarangTableAdapter()
        Me.TableAdapterManager = New inventory.dbInventoryDataSetTableAdapters.TableAdapterManager()
        Me.GridBarangTableAdapter = New inventory.dbInventoryDataSetTableAdapters.GridBarangTableAdapter()
        Me.MerkTableAdapter = New inventory.dbInventoryDataSetTableAdapters.MerkTableAdapter()
        Me.JenisTableAdapter = New inventory.dbInventoryDataSetTableAdapters.JenisTableAdapter()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        KodeBarangLabel = New System.Windows.Forms.Label()
        UkuranLabel = New System.Windows.Forms.Label()
        HargaJualLabel = New System.Windows.Forms.Label()
        IdMerkLabel = New System.Windows.Forms.Label()
        IdJenisLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridBarangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.JenisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KodeBarangLabel
        '
        KodeBarangLabel.AutoSize = True
        KodeBarangLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KodeBarangLabel.Location = New System.Drawing.Point(13, 22)
        KodeBarangLabel.Name = "KodeBarangLabel"
        KodeBarangLabel.Size = New System.Drawing.Size(90, 17)
        KodeBarangLabel.TabIndex = 0
        KodeBarangLabel.Text = "Kode Barang:"
        '
        'UkuranLabel
        '
        UkuranLabel.AutoSize = True
        UkuranLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UkuranLabel.Location = New System.Drawing.Point(47, 84)
        UkuranLabel.Name = "UkuranLabel"
        UkuranLabel.Size = New System.Drawing.Size(56, 17)
        UkuranLabel.TabIndex = 4
        UkuranLabel.Text = "Ukuran:"
        '
        'HargaJualLabel
        '
        HargaJualLabel.AutoSize = True
        HargaJualLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HargaJualLabel.Location = New System.Drawing.Point(309, 22)
        HargaJualLabel.Name = "HargaJualLabel"
        HargaJualLabel.Size = New System.Drawing.Size(78, 17)
        HargaJualLabel.TabIndex = 10
        HargaJualLabel.Text = "Harga Jual:"
        '
        'IdMerkLabel
        '
        IdMerkLabel.AutoSize = True
        IdMerkLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdMerkLabel.Location = New System.Drawing.Point(59, 53)
        IdMerkLabel.Name = "IdMerkLabel"
        IdMerkLabel.Size = New System.Drawing.Size(44, 17)
        IdMerkLabel.TabIndex = 13
        IdMerkLabel.Text = "Merk:"
        '
        'IdJenisLabel
        '
        IdJenisLabel.AutoSize = True
        IdJenisLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdJenisLabel.Location = New System.Drawing.Point(344, 53)
        IdJenisLabel.Name = "IdJenisLabel"
        IdJenisLabel.Size = New System.Drawing.Size(43, 17)
        IdJenisLabel.TabIndex = 14
        IdJenisLabel.Text = "Jenis:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 414)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 41)
        Me.Panel1.TabIndex = 0
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
        Me.Button5.Location = New System.Drawing.Point(738, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Keluar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Image = Global.inventory.My.Resources.Resources.Eraser_25px
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(263, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 32)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Hapus"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Image = Global.inventory.My.Resources.Resources.Edit_25px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(184, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Ubah"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Image = Global.inventory.My.Resources.Resources.Save_25px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(95, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Simpan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Image = Global.inventory.My.Resources.Resources.Plus_25px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tambah"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridBarangDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(821, 290)
        Me.Panel2.TabIndex = 0
        '
        'GridBarangDataGridView
        '
        Me.GridBarangDataGridView.AllowUserToAddRows = False
        Me.GridBarangDataGridView.AllowUserToDeleteRows = False
        Me.GridBarangDataGridView.AutoGenerateColumns = False
        Me.GridBarangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBarangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.namaBarang, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.GridBarangDataGridView.DataSource = Me.GridBarangBindingSource
        Me.GridBarangDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarangDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.GridBarangDataGridView.Name = "GridBarangDataGridView"
        Me.GridBarangDataGridView.ReadOnly = True
        Me.GridBarangDataGridView.Size = New System.Drawing.Size(821, 290)
        Me.GridBarangDataGridView.TabIndex = 0
        '
        'GridBarangBindingSource
        '
        Me.GridBarangBindingSource.DataMember = "GridBarang"
        Me.GridBarangBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'DbInventoryDataSet
        '
        Me.DbInventoryDataSet.DataSetName = "dbInventoryDataSet"
        Me.DbInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(IdJenisLabel)
        Me.Panel3.Controls.Add(Me.IdJenisComboBox)
        Me.Panel3.Controls.Add(IdMerkLabel)
        Me.Panel3.Controls.Add(Me.IdMerkComboBox)
        Me.Panel3.Controls.Add(KodeBarangLabel)
        Me.Panel3.Controls.Add(Me.KodeBarangTextBox)
        Me.Panel3.Controls.Add(UkuranLabel)
        Me.Panel3.Controls.Add(Me.UkuranTextBox)
        Me.Panel3.Controls.Add(HargaJualLabel)
        Me.Panel3.Controls.Add(Me.HargaJualTextBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(821, 124)
        Me.Panel3.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.inventory.My.Resources.Resources.Search_16px
        Me.Button6.Location = New System.Drawing.Point(774, 93)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(37, 25)
        Me.Button6.TabIndex = 18
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(582, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 25)
        Me.TextBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(513, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Pencarian :"
        '
        'IdJenisComboBox
        '
        Me.IdJenisComboBox.DataSource = Me.JenisBindingSource
        Me.IdJenisComboBox.DisplayMember = "namaJenis"
        Me.IdJenisComboBox.FormattingEnabled = True
        Me.IdJenisComboBox.Location = New System.Drawing.Point(393, 50)
        Me.IdJenisComboBox.Name = "IdJenisComboBox"
        Me.IdJenisComboBox.Size = New System.Drawing.Size(229, 25)
        Me.IdJenisComboBox.TabIndex = 4
        Me.IdJenisComboBox.ValueMember = "idJenis"
        '
        'JenisBindingSource
        '
        Me.JenisBindingSource.DataMember = "Jenis"
        Me.JenisBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'IdMerkComboBox
        '
        Me.IdMerkComboBox.DataSource = Me.MerkBindingSource
        Me.IdMerkComboBox.DisplayMember = "NamaMerk"
        Me.IdMerkComboBox.FormattingEnabled = True
        Me.IdMerkComboBox.Location = New System.Drawing.Point(109, 50)
        Me.IdMerkComboBox.Name = "IdMerkComboBox"
        Me.IdMerkComboBox.Size = New System.Drawing.Size(185, 25)
        Me.IdMerkComboBox.TabIndex = 1
        Me.IdMerkComboBox.ValueMember = "idMerk"
        '
        'MerkBindingSource
        '
        Me.MerkBindingSource.DataMember = "Merk"
        Me.MerkBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'KodeBarangTextBox
        '
        Me.KodeBarangTextBox.Location = New System.Drawing.Point(110, 19)
        Me.KodeBarangTextBox.Name = "KodeBarangTextBox"
        Me.KodeBarangTextBox.Size = New System.Drawing.Size(184, 25)
        Me.KodeBarangTextBox.TabIndex = 0
        '
        'UkuranTextBox
        '
        Me.UkuranTextBox.Location = New System.Drawing.Point(109, 81)
        Me.UkuranTextBox.Name = "UkuranTextBox"
        Me.UkuranTextBox.Size = New System.Drawing.Size(100, 25)
        Me.UkuranTextBox.TabIndex = 2
        '
        'HargaJualTextBox
        '
        Me.HargaJualTextBox.Location = New System.Drawing.Point(393, 19)
        Me.HargaJualTextBox.Name = "HargaJualTextBox"
        Me.HargaJualTextBox.Size = New System.Drawing.Size(229, 25)
        Me.HargaJualTextBox.TabIndex = 3
        Me.HargaJualTextBox.Text = "0"
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.JenisTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.PembelianDetilTableAdapter = Nothing
        Me.TableAdapterManager.PembelianMasterTableAdapter = Nothing
        Me.TableAdapterManager.PengaturanTableAdapter = Nothing
        Me.TableAdapterManager.PengeluaranTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = inventory.dbInventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GridBarangTableAdapter
        '
        Me.GridBarangTableAdapter.ClearBeforeFill = True
        '
        'MerkTableAdapter
        '
        Me.MerkTableAdapter.ClearBeforeFill = True
        '
        'JenisTableAdapter
        '
        Me.JenisTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "kodeBarang"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kode Barang"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'namaBarang
        '
        Me.namaBarang.DataPropertyName = "namaBarang"
        Me.namaBarang.HeaderText = "Nama Barang"
        Me.namaBarang.Name = "namaBarang"
        Me.namaBarang.ReadOnly = True
        Me.namaBarang.Width = 250
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NamaMerk"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Merk"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 180
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "namaJenis"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Jenis"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "stok"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Stok"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ukuran"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ukuran"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "hargaJual"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Harga Jual"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 180
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "hargaBeli"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "Harga Beli"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 455)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridBarangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.JenisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DbInventoryDataSet As inventory.dbInventoryDataSet
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarangTableAdapter As inventory.dbInventoryDataSetTableAdapters.BarangTableAdapter
    Friend WithEvents TableAdapterManager As inventory.dbInventoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KodeBarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UkuranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HargaJualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GridBarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridBarangTableAdapter As inventory.dbInventoryDataSetTableAdapters.GridBarangTableAdapter
    Friend WithEvents GridBarangDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdJenisComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdMerkComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MerkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MerkTableAdapter As inventory.dbInventoryDataSetTableAdapters.MerkTableAdapter
    Friend WithEvents JenisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JenisTableAdapter As inventory.dbInventoryDataSetTableAdapters.JenisTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
