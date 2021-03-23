<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hak_akses
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
        Me.dg_pegawai = New System.Windows.Forms.DataGridView()
        Me.IdpegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaris_barangDataSet = New Aplikasi_inventaris.inventaris_barangDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_petugas = New System.Windows.Forms.DataGridView()
        Me.IdpetugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapetugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdlevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaris_barangDataSet1 = New Aplikasi_inventaris.inventaris_barangDataSet1()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PegawaiTableAdapter = New Aplikasi_inventaris.inventaris_barangDataSetTableAdapters.pegawaiTableAdapter()
        Me.PetugasTableAdapter = New Aplikasi_inventaris.inventaris_barangDataSet1TableAdapters.petugasTableAdapter()
        CType(Me.dg_pegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventaris_barangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_petugas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventaris_barangDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_pegawai
        '
        Me.dg_pegawai.AllowUserToAddRows = False
        Me.dg_pegawai.AllowUserToDeleteRows = False
        Me.dg_pegawai.AutoGenerateColumns = False
        Me.dg_pegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pegawai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpegawaiDataGridViewTextBoxColumn, Me.NamapegawaiDataGridViewTextBoxColumn, Me.NipDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn})
        Me.dg_pegawai.DataSource = Me.PegawaiBindingSource
        Me.dg_pegawai.Location = New System.Drawing.Point(20, 19)
        Me.dg_pegawai.Name = "dg_pegawai"
        Me.dg_pegawai.ReadOnly = True
        Me.dg_pegawai.Size = New System.Drawing.Size(270, 197)
        Me.dg_pegawai.TabIndex = 0
        '
        'IdpegawaiDataGridViewTextBoxColumn
        '
        Me.IdpegawaiDataGridViewTextBoxColumn.DataPropertyName = "id_pegawai"
        Me.IdpegawaiDataGridViewTextBoxColumn.HeaderText = "id_pegawai"
        Me.IdpegawaiDataGridViewTextBoxColumn.Name = "IdpegawaiDataGridViewTextBoxColumn"
        Me.IdpegawaiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamapegawaiDataGridViewTextBoxColumn
        '
        Me.NamapegawaiDataGridViewTextBoxColumn.DataPropertyName = "nama_pegawai"
        Me.NamapegawaiDataGridViewTextBoxColumn.HeaderText = "nama_pegawai"
        Me.NamapegawaiDataGridViewTextBoxColumn.Name = "NamapegawaiDataGridViewTextBoxColumn"
        Me.NamapegawaiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NipDataGridViewTextBoxColumn
        '
        Me.NipDataGridViewTextBoxColumn.DataPropertyName = "nip"
        Me.NipDataGridViewTextBoxColumn.HeaderText = "nip"
        Me.NipDataGridViewTextBoxColumn.Name = "NipDataGridViewTextBoxColumn"
        Me.NipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PegawaiBindingSource
        '
        Me.PegawaiBindingSource.DataMember = "pegawai"
        Me.PegawaiBindingSource.DataSource = Me.Inventaris_barangDataSet
        '
        'Inventaris_barangDataSet
        '
        Me.Inventaris_barangDataSet.DataSetName = "inventaris_barangDataSet"
        Me.Inventaris_barangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg_pegawai)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 228)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA PEGAWAI"
        '
        'dg_petugas
        '
        Me.dg_petugas.AllowUserToAddRows = False
        Me.dg_petugas.AllowUserToDeleteRows = False
        Me.dg_petugas.AutoGenerateColumns = False
        Me.dg_petugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_petugas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpetugasDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.NamapetugasDataGridViewTextBoxColumn, Me.IdlevelDataGridViewTextBoxColumn})
        Me.dg_petugas.DataSource = Me.PetugasBindingSource
        Me.dg_petugas.Location = New System.Drawing.Point(20, 19)
        Me.dg_petugas.Name = "dg_petugas"
        Me.dg_petugas.ReadOnly = True
        Me.dg_petugas.Size = New System.Drawing.Size(270, 197)
        Me.dg_petugas.TabIndex = 0
        '
        'IdpetugasDataGridViewTextBoxColumn
        '
        Me.IdpetugasDataGridViewTextBoxColumn.DataPropertyName = "id_petugas"
        Me.IdpetugasDataGridViewTextBoxColumn.HeaderText = "id_petugas"
        Me.IdpetugasDataGridViewTextBoxColumn.Name = "IdpetugasDataGridViewTextBoxColumn"
        Me.IdpetugasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamapetugasDataGridViewTextBoxColumn
        '
        Me.NamapetugasDataGridViewTextBoxColumn.DataPropertyName = "nama_petugas"
        Me.NamapetugasDataGridViewTextBoxColumn.HeaderText = "nama_petugas"
        Me.NamapetugasDataGridViewTextBoxColumn.Name = "NamapetugasDataGridViewTextBoxColumn"
        Me.NamapetugasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdlevelDataGridViewTextBoxColumn
        '
        Me.IdlevelDataGridViewTextBoxColumn.DataPropertyName = "id_level"
        Me.IdlevelDataGridViewTextBoxColumn.HeaderText = "id_level"
        Me.IdlevelDataGridViewTextBoxColumn.Name = "IdlevelDataGridViewTextBoxColumn"
        Me.IdlevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PetugasBindingSource
        '
        Me.PetugasBindingSource.DataMember = "petugas"
        Me.PetugasBindingSource.DataSource = Me.Inventaris_barangDataSet1
        '
        'Inventaris_barangDataSet1
        '
        Me.Inventaris_barangDataSet1.DataSetName = "inventaris_barangDataSet1"
        Me.Inventaris_barangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_petugas)
        Me.GroupBox2.Location = New System.Drawing.Point(365, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 228)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA PETUGAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NAMA PEGAWAI"
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Location = New System.Drawing.Point(185, 336)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(142, 20)
        Me.txt_nama.TabIndex = 4
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(185, 372)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(142, 20)
        Me.txt_username.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "USERNAME"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(185, 409)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_password.Size = New System.Drawing.Size(142, 20)
        Me.txt_password.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PASSWORD"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(519, 302)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 39
        Me.btn_hapus.Text = "&HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Location = New System.Drawing.Point(438, 302)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(75, 23)
        Me.btn_ubah.TabIndex = 38
        Me.btn_ubah.Text = "&UBAH"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(357, 302)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 37
        Me.btn_simpan.Text = "&SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(891, -37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 20)
        Me.TextBox2.TabIndex = 36
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(333, 412)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox1.TabIndex = 41
        Me.CheckBox1.Text = "SHOW PASSWORD"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(182, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(85, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "ID"
        Me.Label5.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Cari Nama Pegawai"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(495, 18)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(140, 20)
        Me.TextBox3.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(392, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Cari Nama Petugas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(84, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "USERNAME LAMA"
        Me.Label8.Visible = False
        '
        'lbl_username
        '
        Me.lbl_username.Location = New System.Drawing.Point(188, 312)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(91, 13)
        Me.lbl_username.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(368, 372)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(330, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "ID"
        Me.Label10.Visible = False
        '
        'PegawaiTableAdapter
        '
        Me.PegawaiTableAdapter.ClearBeforeFill = True
        '
        'PetugasTableAdapter
        '
        Me.PetugasTableAdapter.ClearBeforeFill = True
        '
        'Hak_akses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(715, 438)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Hak_akses"
        Me.Text = "Hak Akses"
        CType(Me.dg_pegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventaris_barangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_petugas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventaris_barangDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg_pegawai As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_petugas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Inventaris_barangDataSet As Aplikasi_inventaris.inventaris_barangDataSet
    Friend WithEvents PegawaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PegawaiTableAdapter As Aplikasi_inventaris.inventaris_barangDataSetTableAdapters.pegawaiTableAdapter
    Friend WithEvents IdpegawaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamapegawaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inventaris_barangDataSet1 As Aplikasi_inventaris.inventaris_barangDataSet1
    Friend WithEvents PetugasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PetugasTableAdapter As Aplikasi_inventaris.inventaris_barangDataSet1TableAdapters.petugasTableAdapter
    Friend WithEvents IdpetugasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamapetugasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdlevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
