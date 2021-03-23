<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventarisir
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.IdinventarisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KondisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdjenisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglregisterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdruangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeinventarisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdpetugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventarisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaris_barangDataSetInventaris = New Aplikasi_inventaris.inventaris_barangDataSetInventaris()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InventarisTableAdapter = New Aplikasi_inventaris.inventaris_barangDataSetInventarisTableAdapters.inventarisTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_jml = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id_j = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_id_r = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_kode_i = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_id_p = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_kon = New System.Windows.Forms.ComboBox()
        Me.DG_JENIS = New System.Windows.Forms.DataGridView()
        Me.IdjenisDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamajenisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaris_barangDataSetJenis = New Aplikasi_inventaris.inventaris_barangDataSetJenis()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_RUANG = New System.Windows.Forms.DataGridView()
        Me.IdruangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaruangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KoderuangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RuangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaris_barangDataSetRuang2 = New Aplikasi_inventaris.inventaris_barangDataSetRuang2()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.JenisTableAdapter = New Aplikasi_inventaris.inventaris_barangDataSetJenisTableAdapters.jenisTableAdapter()
        Me.RuangTableAdapter = New Aplikasi_inventaris.inventaris_barangDataSetRuang2TableAdapters.ruangTableAdapter()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.lbl_tanggal = New System.Windows.Forms.Label()
        Me.lbl_id_inv = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventaris_barangDataSetInventaris, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_JENIS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventaris_barangDataSetJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_RUANG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RuangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventaris_barangDataSetRuang2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoGenerateColumns = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdinventarisDataGridViewTextBoxColumn, Me.NamabarangDataGridViewTextBoxColumn, Me.KondisiDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn, Me.IdjenisDataGridViewTextBoxColumn, Me.TglregisterDataGridViewTextBoxColumn, Me.IdruangDataGridViewTextBoxColumn, Me.KodeinventarisDataGridViewTextBoxColumn, Me.IdpetugasDataGridViewTextBoxColumn})
        Me.dg.DataSource = Me.InventarisBindingSource
        Me.dg.Location = New System.Drawing.Point(39, 42)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(684, 158)
        Me.dg.TabIndex = 0
        '
        'IdinventarisDataGridViewTextBoxColumn
        '
        Me.IdinventarisDataGridViewTextBoxColumn.DataPropertyName = "id_inventaris"
        Me.IdinventarisDataGridViewTextBoxColumn.HeaderText = "id_inventaris"
        Me.IdinventarisDataGridViewTextBoxColumn.Name = "IdinventarisDataGridViewTextBoxColumn"
        Me.IdinventarisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamabarangDataGridViewTextBoxColumn
        '
        Me.NamabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang"
        Me.NamabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang"
        Me.NamabarangDataGridViewTextBoxColumn.Name = "NamabarangDataGridViewTextBoxColumn"
        Me.NamabarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KondisiDataGridViewTextBoxColumn
        '
        Me.KondisiDataGridViewTextBoxColumn.DataPropertyName = "kondisi"
        Me.KondisiDataGridViewTextBoxColumn.HeaderText = "kondisi"
        Me.KondisiDataGridViewTextBoxColumn.Name = "KondisiDataGridViewTextBoxColumn"
        Me.KondisiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        Me.JumlahDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdjenisDataGridViewTextBoxColumn
        '
        Me.IdjenisDataGridViewTextBoxColumn.DataPropertyName = "id_jenis"
        Me.IdjenisDataGridViewTextBoxColumn.HeaderText = "id_jenis"
        Me.IdjenisDataGridViewTextBoxColumn.Name = "IdjenisDataGridViewTextBoxColumn"
        Me.IdjenisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglregisterDataGridViewTextBoxColumn
        '
        Me.TglregisterDataGridViewTextBoxColumn.DataPropertyName = "tgl_register"
        Me.TglregisterDataGridViewTextBoxColumn.HeaderText = "tgl_register"
        Me.TglregisterDataGridViewTextBoxColumn.Name = "TglregisterDataGridViewTextBoxColumn"
        Me.TglregisterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdruangDataGridViewTextBoxColumn
        '
        Me.IdruangDataGridViewTextBoxColumn.DataPropertyName = "id_ruang"
        Me.IdruangDataGridViewTextBoxColumn.HeaderText = "id_ruang"
        Me.IdruangDataGridViewTextBoxColumn.Name = "IdruangDataGridViewTextBoxColumn"
        Me.IdruangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KodeinventarisDataGridViewTextBoxColumn
        '
        Me.KodeinventarisDataGridViewTextBoxColumn.DataPropertyName = "kode_inventaris"
        Me.KodeinventarisDataGridViewTextBoxColumn.HeaderText = "kode_inventaris"
        Me.KodeinventarisDataGridViewTextBoxColumn.Name = "KodeinventarisDataGridViewTextBoxColumn"
        Me.KodeinventarisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdpetugasDataGridViewTextBoxColumn
        '
        Me.IdpetugasDataGridViewTextBoxColumn.DataPropertyName = "id_petugas"
        Me.IdpetugasDataGridViewTextBoxColumn.HeaderText = "id_petugas"
        Me.IdpetugasDataGridViewTextBoxColumn.Name = "IdpetugasDataGridViewTextBoxColumn"
        Me.IdpetugasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventarisBindingSource
        '
        Me.InventarisBindingSource.DataMember = "inventaris"
        Me.InventarisBindingSource.DataSource = Me.Inventaris_barangDataSetInventaris
        '
        'Inventaris_barangDataSetInventaris
        '
        Me.Inventaris_barangDataSetInventaris.DataSetName = "inventaris_barangDataSetInventaris"
        Me.Inventaris_barangDataSetInventaris.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(321, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cari Nama Barang"
        '
        'InventarisTableAdapter
        '
        Me.InventarisTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NAMA BARANG"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(128, 227)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(123, 20)
        Me.txt_nama.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "KONDISI"
        '
        'txt_jml
        '
        Me.txt_jml.Location = New System.Drawing.Point(128, 322)
        Me.txt_jml.Name = "txt_jml"
        Me.txt_jml.Size = New System.Drawing.Size(123, 20)
        Me.txt_jml.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "JUMLAH"
        '
        'txt_id_j
        '
        Me.txt_id_j.Enabled = False
        Me.txt_id_j.Location = New System.Drawing.Point(128, 374)
        Me.txt_id_j.Name = "txt_id_j"
        Me.txt_id_j.Size = New System.Drawing.Size(123, 20)
        Me.txt_id_j.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ID JENIS"
        '
        'txt_id_r
        '
        Me.txt_id_r.Enabled = False
        Me.txt_id_r.Location = New System.Drawing.Point(405, 225)
        Me.txt_id_r.Name = "txt_id_r"
        Me.txt_id_r.Size = New System.Drawing.Size(123, 20)
        Me.txt_id_r.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(301, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ID RUANG"
        '
        'txt_kode_i
        '
        Me.txt_kode_i.Enabled = False
        Me.txt_kode_i.Location = New System.Drawing.Point(405, 273)
        Me.txt_kode_i.Name = "txt_kode_i"
        Me.txt_kode_i.Size = New System.Drawing.Size(123, 20)
        Me.txt_kode_i.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(301, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "KODE INVENTARIS"
        '
        'txt_id_p
        '
        Me.txt_id_p.Enabled = False
        Me.txt_id_p.Location = New System.Drawing.Point(405, 322)
        Me.txt_id_p.Name = "txt_id_p"
        Me.txt_id_p.Size = New System.Drawing.Size(123, 20)
        Me.txt_id_p.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(301, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ID PETUGAS"
        '
        'cbo_kon
        '
        Me.cbo_kon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_kon.FormattingEnabled = True
        Me.cbo_kon.Items.AddRange(New Object() {"BAIK", "RUSAK", "BARU"})
        Me.cbo_kon.Location = New System.Drawing.Point(128, 271)
        Me.cbo_kon.Name = "cbo_kon"
        Me.cbo_kon.Size = New System.Drawing.Size(121, 21)
        Me.cbo_kon.TabIndex = 26
        '
        'DG_JENIS
        '
        Me.DG_JENIS.AllowUserToAddRows = False
        Me.DG_JENIS.AllowUserToDeleteRows = False
        Me.DG_JENIS.AutoGenerateColumns = False
        Me.DG_JENIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_JENIS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdjenisDataGridViewTextBoxColumn1, Me.NamajenisDataGridViewTextBoxColumn})
        Me.DG_JENIS.DataSource = Me.JenisBindingSource
        Me.DG_JENIS.Location = New System.Drawing.Point(18, 19)
        Me.DG_JENIS.Name = "DG_JENIS"
        Me.DG_JENIS.ReadOnly = True
        Me.DG_JENIS.Size = New System.Drawing.Size(244, 135)
        Me.DG_JENIS.TabIndex = 27
        '
        'IdjenisDataGridViewTextBoxColumn1
        '
        Me.IdjenisDataGridViewTextBoxColumn1.DataPropertyName = "id_jenis"
        Me.IdjenisDataGridViewTextBoxColumn1.HeaderText = "id_jenis"
        Me.IdjenisDataGridViewTextBoxColumn1.Name = "IdjenisDataGridViewTextBoxColumn1"
        Me.IdjenisDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NamajenisDataGridViewTextBoxColumn
        '
        Me.NamajenisDataGridViewTextBoxColumn.DataPropertyName = "nama_jenis"
        Me.NamajenisDataGridViewTextBoxColumn.HeaderText = "nama_jenis"
        Me.NamajenisDataGridViewTextBoxColumn.Name = "NamajenisDataGridViewTextBoxColumn"
        Me.NamajenisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JenisBindingSource
        '
        Me.JenisBindingSource.DataMember = "jenis"
        Me.JenisBindingSource.DataSource = Me.Inventaris_barangDataSetJenis
        '
        'Inventaris_barangDataSetJenis
        '
        Me.Inventaris_barangDataSetJenis.DataSetName = "inventaris_barangDataSetJenis"
        Me.Inventaris_barangDataSetJenis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG_JENIS)
        Me.GroupBox1.Location = New System.Drawing.Point(569, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 160)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA JENIS BARANG"
        '
        'DG_RUANG
        '
        Me.DG_RUANG.AllowUserToAddRows = False
        Me.DG_RUANG.AllowUserToDeleteRows = False
        Me.DG_RUANG.AutoGenerateColumns = False
        Me.DG_RUANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_RUANG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdruangDataGridViewTextBoxColumn1, Me.NamaruangDataGridViewTextBoxColumn, Me.KoderuangDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.DG_RUANG.DataSource = Me.RuangBindingSource
        Me.DG_RUANG.Location = New System.Drawing.Point(15, 19)
        Me.DG_RUANG.Name = "DG_RUANG"
        Me.DG_RUANG.ReadOnly = True
        Me.DG_RUANG.Size = New System.Drawing.Size(301, 135)
        Me.DG_RUANG.TabIndex = 27
        '
        'IdruangDataGridViewTextBoxColumn1
        '
        Me.IdruangDataGridViewTextBoxColumn1.DataPropertyName = "id_ruang"
        Me.IdruangDataGridViewTextBoxColumn1.HeaderText = "id_ruang"
        Me.IdruangDataGridViewTextBoxColumn1.Name = "IdruangDataGridViewTextBoxColumn1"
        Me.IdruangDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NamaruangDataGridViewTextBoxColumn
        '
        Me.NamaruangDataGridViewTextBoxColumn.DataPropertyName = "nama_ruang"
        Me.NamaruangDataGridViewTextBoxColumn.HeaderText = "nama_ruang"
        Me.NamaruangDataGridViewTextBoxColumn.Name = "NamaruangDataGridViewTextBoxColumn"
        Me.NamaruangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KoderuangDataGridViewTextBoxColumn
        '
        Me.KoderuangDataGridViewTextBoxColumn.DataPropertyName = "kode_ruang"
        Me.KoderuangDataGridViewTextBoxColumn.HeaderText = "kode_ruang"
        Me.KoderuangDataGridViewTextBoxColumn.Name = "KoderuangDataGridViewTextBoxColumn"
        Me.KoderuangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        Me.KeteranganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RuangBindingSource
        '
        Me.RuangBindingSource.DataMember = "ruang"
        Me.RuangBindingSource.DataSource = Me.Inventaris_barangDataSetRuang2
        '
        'Inventaris_barangDataSetRuang2
        '
        Me.Inventaris_barangDataSetRuang2.DataSetName = "inventaris_barangDataSetRuang2"
        Me.Inventaris_barangDataSetRuang2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DG_RUANG)
        Me.GroupBox2.Location = New System.Drawing.Point(738, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 160)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA RUANG"
        '
        'JenisTableAdapter
        '
        Me.JenisTableAdapter.ClearBeforeFill = True
        '
        'RuangTableAdapter
        '
        Me.RuangTableAdapter.ClearBeforeFill = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(836, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 20)
        Me.TextBox2.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(737, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Cari Nama Ruang"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(464, 358)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 34
        Me.btn_hapus.Text = "&HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Location = New System.Drawing.Point(383, 358)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(75, 23)
        Me.btn_ubah.TabIndex = 33
        Me.btn_ubah.Text = "&UBAH"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(302, 358)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 32
        Me.btn_simpan.Text = "&SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'lbl_tanggal
        '
        Me.lbl_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggal.Location = New System.Drawing.Point(3, 1)
        Me.lbl_tanggal.Name = "lbl_tanggal"
        Me.lbl_tanggal.Size = New System.Drawing.Size(140, 23)
        Me.lbl_tanggal.TabIndex = 36
        '
        'lbl_id_inv
        '
        Me.lbl_id_inv.AutoSize = True
        Me.lbl_id_inv.Location = New System.Drawing.Point(36, 203)
        Me.lbl_id_inv.Name = "lbl_id_inv"
        Me.lbl_id_inv.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id_inv.TabIndex = 37
        Me.lbl_id_inv.Text = "ID"
        Me.lbl_id_inv.Visible = False
        '
        'lbl_id
        '
        Me.lbl_id.Location = New System.Drawing.Point(127, 203)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(26, 13)
        Me.lbl_id.TabIndex = 38
        Me.lbl_id.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(383, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "&Backup Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Inventarisir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1072, 464)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_id_inv)
        Me.Controls.Add(Me.lbl_tanggal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbo_kon)
        Me.Controls.Add(Me.txt_id_p)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_kode_i)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_id_r)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_id_j)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_jml)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg)
        Me.Name = "Inventarisir"
        Me.Text = "Inventarisir"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventaris_barangDataSetInventaris, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_JENIS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventaris_barangDataSetJenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_RUANG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RuangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventaris_barangDataSetRuang2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Inventaris_barangDataSetInventaris As Aplikasi_inventaris.inventaris_barangDataSetInventaris
    Friend WithEvents InventarisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarisTableAdapter As Aplikasi_inventaris.inventaris_barangDataSetInventarisTableAdapters.inventarisTableAdapter
    Friend WithEvents IdinventarisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamabarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KondisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdjenisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglregisterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdruangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeinventarisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdpetugasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_jml As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id_j As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_id_r As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_kode_i As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_id_p As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbo_kon As System.Windows.Forms.ComboBox
    Friend WithEvents DG_JENIS As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_RUANG As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Inventaris_barangDataSetJenis As Aplikasi_inventaris.inventaris_barangDataSetJenis
    Friend WithEvents JenisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JenisTableAdapter As Aplikasi_inventaris.inventaris_barangDataSetJenisTableAdapters.jenisTableAdapter
    Friend WithEvents IdjenisDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamajenisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inventaris_barangDataSetRuang2 As Aplikasi_inventaris.inventaris_barangDataSetRuang2
    Friend WithEvents RuangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RuangTableAdapter As Aplikasi_inventaris.inventaris_barangDataSetRuang2TableAdapters.ruangTableAdapter
    Friend WithEvents IdruangDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaruangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KoderuangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents lbl_tanggal As System.Windows.Forms.Label
    Friend WithEvents lbl_id_inv As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
