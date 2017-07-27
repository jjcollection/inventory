<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IdSupplierComboBox = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbInventoryDataSet = New inventory.dbInventoryDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtTgl = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbItem = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GridBarangDataGridView = New System.Windows.Forms.DataGridView()
        Me.GridPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SupplierTableAdapter = New inventory.dbInventoryDataSetTableAdapters.SupplierTableAdapter()
        Me.TableAdapterManager = New inventory.dbInventoryDataSetTableAdapters.TableAdapterManager()
        Me.GridPembelianTableAdapter = New inventory.dbInventoryDataSetTableAdapters.GridPembelianTableAdapter()
        Me.PembelianMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianMasterTableAdapter = New inventory.dbInventoryDataSetTableAdapters.PembelianMasterTableAdapter()
        Me.PembelianDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianDetilTableAdapter = New inventory.dbInventoryDataSetTableAdapters.PembelianDetilTableAdapter()
        Me.IdPembelianMasterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPembelianDetilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaMerkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaJenisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UkuranDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridBarangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PembelianMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1003, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(52, 29)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "OK"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Yellow
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox1.Location = New System.Drawing.Point(742, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(261, 30)
        Me.TextBox1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.IdSupplierComboBox)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtNo)
        Me.Panel3.Controls.Add(Me.txtTgl)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1056, 31)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.inventory.My.Resources.Resources.Invoice_32px
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'IdSupplierComboBox
        '
        Me.IdSupplierComboBox.DataSource = Me.SupplierBindingSource
        Me.IdSupplierComboBox.DisplayMember = "namaSupplier"
        Me.IdSupplierComboBox.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.IdSupplierComboBox.FormattingEnabled = True
        Me.IdSupplierComboBox.Location = New System.Drawing.Point(395, 0)
        Me.IdSupplierComboBox.Name = "IdSupplierComboBox"
        Me.IdSupplierComboBox.Size = New System.Drawing.Size(230, 31)
        Me.IdSupplierComboBox.TabIndex = 19
        Me.IdSupplierComboBox.ValueMember = "idSupplier"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'DbInventoryDataSet
        '
        Me.DbInventoryDataSet.DataSetName = "dbInventoryDataSet"
        Me.DbInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.inventory.My.Resources.Resources.Search_32px
        Me.Label3.Location = New System.Drawing.Point(707, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.inventory.My.Resources.Resources.Calendar_32px
        Me.Label4.Location = New System.Drawing.Point(162, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 32)
        Me.Label4.TabIndex = 16
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.inventory.My.Resources.Resources.User_32px
        Me.Label2.Location = New System.Drawing.Point(357, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 32)
        Me.Label2.TabIndex = 16
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo
        '
        Me.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNo.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(31, 0)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.ReadOnly = True
        Me.txtNo.Size = New System.Drawing.Size(131, 30)
        Me.txtNo.TabIndex = 5
        Me.txtNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTgl
        '
        Me.txtTgl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTgl.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl.Location = New System.Drawing.Point(193, 0)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.ReadOnly = True
        Me.txtTgl.Size = New System.Drawing.Size(164, 30)
        Me.txtTgl.TabIndex = 5
        Me.txtTgl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbItem)
        Me.Panel1.Controls.Add(Me.lbTotal)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 534)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1056, 41)
        Me.Panel1.TabIndex = 2
        '
        'lbItem
        '
        Me.lbItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbItem.BackColor = System.Drawing.Color.Red
        Me.lbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItem.ForeColor = System.Drawing.Color.White
        Me.lbItem.Location = New System.Drawing.Point(653, 6)
        Me.lbItem.Name = "lbItem"
        Me.lbItem.Size = New System.Drawing.Size(89, 28)
        Me.lbItem.TabIndex = 5
        Me.lbItem.Text = "0"
        Me.lbItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotal
        '
        Me.lbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTotal.BackColor = System.Drawing.Color.Red
        Me.lbTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.White
        Me.lbTotal.Location = New System.Drawing.Point(748, 6)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(219, 28)
        Me.lbTotal.TabIndex = 5
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
        Me.Button5.Location = New System.Drawing.Point(973, 4)
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
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Image = Global.inventory.My.Resources.Resources.Eraser_25px
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(241, 4)
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
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Image = Global.inventory.My.Resources.Resources.Edit_25px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(165, 4)
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
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Image = Global.inventory.My.Resources.Resources.Plus_25px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(70, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Tambah"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Image = Global.inventory.My.Resources.Resources.Lightning_Bolt_25px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(2, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Baru"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GridBarangDataGridView
        '
        Me.GridBarangDataGridView.AllowUserToAddRows = False
        Me.GridBarangDataGridView.AllowUserToDeleteRows = False
        Me.GridBarangDataGridView.AutoGenerateColumns = False
        Me.GridBarangDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.GridBarangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBarangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPembelianMasterDataGridViewTextBoxColumn, Me.IdPembelianDetilDataGridViewTextBoxColumn, Me.kodeBarang, Me.NamaMerkDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.NamaJenisDataGridViewTextBoxColumn, Me.UkuranDataGridViewTextBoxColumn, Me.StokDataGridViewTextBoxColumn, Me.JumlahBeliDataGridViewTextBoxColumn, Me.HargaBeliDataGridViewTextBoxColumn, Me.SubTotalBeliDataGridViewTextBoxColumn})
        Me.GridBarangDataGridView.DataSource = Me.GridPembelianBindingSource
        Me.GridBarangDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarangDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.GridBarangDataGridView.Name = "GridBarangDataGridView"
        Me.GridBarangDataGridView.ReadOnly = True
        Me.GridBarangDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridBarangDataGridView.Size = New System.Drawing.Size(1056, 544)
        Me.GridBarangDataGridView.TabIndex = 0
        '
        'GridPembelianBindingSource
        '
        Me.GridPembelianBindingSource.DataMember = "GridPembelian"
        Me.GridPembelianBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridBarangDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1056, 544)
        Me.Panel2.TabIndex = 1
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarangTableAdapter = Nothing
        Me.TableAdapterManager.JenisTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.PembelianDetilTableAdapter = Nothing
        Me.TableAdapterManager.PembelianMasterTableAdapter = Nothing
        Me.TableAdapterManager.PengaturanTableAdapter = Nothing
        Me.TableAdapterManager.PengeluaranTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = inventory.dbInventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GridPembelianTableAdapter
        '
        Me.GridPembelianTableAdapter.ClearBeforeFill = True
        '
        'PembelianMasterBindingSource
        '
        Me.PembelianMasterBindingSource.DataMember = "PembelianMaster"
        Me.PembelianMasterBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'PembelianMasterTableAdapter
        '
        Me.PembelianMasterTableAdapter.ClearBeforeFill = True
        '
        'PembelianDetilBindingSource
        '
        Me.PembelianDetilBindingSource.DataMember = "PembelianDetil"
        Me.PembelianDetilBindingSource.DataSource = Me.DbInventoryDataSet
        '
        'PembelianDetilTableAdapter
        '
        Me.PembelianDetilTableAdapter.ClearBeforeFill = True
        '
        'IdPembelianMasterDataGridViewTextBoxColumn
        '
        Me.IdPembelianMasterDataGridViewTextBoxColumn.DataPropertyName = "idPembelianMaster"
        Me.IdPembelianMasterDataGridViewTextBoxColumn.HeaderText = "idPembelianMaster"
        Me.IdPembelianMasterDataGridViewTextBoxColumn.Name = "IdPembelianMasterDataGridViewTextBoxColumn"
        Me.IdPembelianMasterDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPembelianMasterDataGridViewTextBoxColumn.Visible = False
        '
        'IdPembelianDetilDataGridViewTextBoxColumn
        '
        Me.IdPembelianDetilDataGridViewTextBoxColumn.DataPropertyName = "idPembelianDetil"
        Me.IdPembelianDetilDataGridViewTextBoxColumn.HeaderText = "idPembelianDetil"
        Me.IdPembelianDetilDataGridViewTextBoxColumn.Name = "IdPembelianDetilDataGridViewTextBoxColumn"
        Me.IdPembelianDetilDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPembelianDetilDataGridViewTextBoxColumn.Visible = False
        '
        'kodeBarang
        '
        Me.kodeBarang.DataPropertyName = "kodeBarang"
        Me.kodeBarang.HeaderText = "Kode Barang"
        Me.kodeBarang.Name = "kodeBarang"
        Me.kodeBarang.ReadOnly = True
        '
        'NamaMerkDataGridViewTextBoxColumn
        '
        Me.NamaMerkDataGridViewTextBoxColumn.DataPropertyName = "NamaMerk"
        Me.NamaMerkDataGridViewTextBoxColumn.HeaderText = "Merk"
        Me.NamaMerkDataGridViewTextBoxColumn.Name = "NamaMerkDataGridViewTextBoxColumn"
        Me.NamaMerkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        Me.NamaBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn.Width = 250
        '
        'NamaJenisDataGridViewTextBoxColumn
        '
        Me.NamaJenisDataGridViewTextBoxColumn.DataPropertyName = "namaJenis"
        Me.NamaJenisDataGridViewTextBoxColumn.HeaderText = "Jenis"
        Me.NamaJenisDataGridViewTextBoxColumn.Name = "NamaJenisDataGridViewTextBoxColumn"
        Me.NamaJenisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UkuranDataGridViewTextBoxColumn
        '
        Me.UkuranDataGridViewTextBoxColumn.DataPropertyName = "ukuran"
        Me.UkuranDataGridViewTextBoxColumn.HeaderText = "Ukuran"
        Me.UkuranDataGridViewTextBoxColumn.Name = "UkuranDataGridViewTextBoxColumn"
        Me.UkuranDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "stok"
        Me.StokDataGridViewTextBoxColumn.HeaderText = "Stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        Me.StokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JumlahBeliDataGridViewTextBoxColumn
        '
        Me.JumlahBeliDataGridViewTextBoxColumn.DataPropertyName = "jumlahBeli"
        Me.JumlahBeliDataGridViewTextBoxColumn.HeaderText = "Jumlah"
        Me.JumlahBeliDataGridViewTextBoxColumn.Name = "JumlahBeliDataGridViewTextBoxColumn"
        Me.JumlahBeliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaBeliDataGridViewTextBoxColumn
        '
        Me.HargaBeliDataGridViewTextBoxColumn.DataPropertyName = "hargaBeli"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.HargaBeliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.HargaBeliDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaBeliDataGridViewTextBoxColumn.Name = "HargaBeliDataGridViewTextBoxColumn"
        Me.HargaBeliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubTotalBeliDataGridViewTextBoxColumn
        '
        Me.SubTotalBeliDataGridViewTextBoxColumn.DataPropertyName = "subTotalBeli"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.SubTotalBeliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SubTotalBeliDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.SubTotalBeliDataGridViewTextBoxColumn.Name = "SubTotalBeliDataGridViewTextBoxColumn"
        Me.SubTotalBeliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormPembelian"
        Me.Text = "FormPembelian"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridBarangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PembelianMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridBarangDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DbInventoryDataSet As inventory.dbInventoryDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As inventory.dbInventoryDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As inventory.dbInventoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdSupplierComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridPembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridPembelianTableAdapter As inventory.dbInventoryDataSetTableAdapters.GridPembelianTableAdapter
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTgl As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents PembelianMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembelianMasterTableAdapter As inventory.dbInventoryDataSetTableAdapters.PembelianMasterTableAdapter
    Friend WithEvents BarangkodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbItem As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents PembelianDetilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembelianDetilTableAdapter As inventory.dbInventoryDataSetTableAdapters.PembelianDetilTableAdapter
    Friend WithEvents IdPembelianMasterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPembelianDetilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaMerkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaJenisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UkuranDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
