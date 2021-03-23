<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pegawai
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
        Me.IdpegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaris_barangDataSetPegawai = New Aplikasi_inventaris.inventaris_barangDataSetPegawai()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ket = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.PegawaiTableAdapter = New Aplikasi_inventaris.inventaris_barangDataSetPegawaiTableAdapters.pegawaiTableAdapter()
        Me.lbl_id_pegawai = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_file = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventaris_barangDataSetPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoGenerateColumns = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpegawaiDataGridViewTextBoxColumn, Me.NamapegawaiDataGridViewTextBoxColumn, Me.NipDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn})
        Me.dg.DataSource = Me.PegawaiBindingSource
        Me.dg.Location = New System.Drawing.Point(85, 43)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(275, 168)
        Me.dg.TabIndex = 0
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
        Me.PegawaiBindingSource.DataSource = Me.Inventaris_barangDataSetPegawai
        '
        'Inventaris_barangDataSetPegawai
        '
        Me.Inventaris_barangDataSetPegawai.DataSetName = "inventaris_barangDataSetPegawai"
        Me.Inventaris_barangDataSetPegawai.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari Nama"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(134, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(104, 241)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(186, 20)
        Me.txt_nama.TabIndex = 4
        '
        'txt_kode
        '
        Me.txt_kode.Location = New System.Drawing.Point(104, 282)
        Me.txt_kode.MaxLength = 20
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(186, 20)
        Me.txt_kode.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NIP"
        '
        'txt_ket
        '
        Me.txt_ket.Location = New System.Drawing.Point(104, 318)
        Me.txt_ket.Multiline = True
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.Size = New System.Drawing.Size(186, 46)
        Me.txt_ket.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alamat"
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(104, 380)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 9
        Me.btn_simpan.Text = "&SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Location = New System.Drawing.Point(185, 380)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(75, 23)
        Me.btn_ubah.TabIndex = 10
        Me.btn_ubah.Text = "&UBAH"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(266, 380)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 11
        Me.btn_hapus.Text = "&HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'PegawaiTableAdapter
        '
        Me.PegawaiTableAdapter.ClearBeforeFill = True
        '
        'lbl_id_pegawai
        '
        Me.lbl_id_pegawai.AutoSize = True
        Me.lbl_id_pegawai.Location = New System.Drawing.Point(296, 244)
        Me.lbl_id_pegawai.Name = "lbl_id_pegawai"
        Me.lbl_id_pegawai.Size = New System.Drawing.Size(24, 13)
        Me.lbl_id_pegawai.TabIndex = 12
        Me.lbl_id_pegawai.Text = "ID :"
        Me.lbl_id_pegawai.Visible = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(320, 244)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 13)
        Me.lbl_id.TabIndex = 13
        Me.lbl_id.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_file
        '
        Me.txt_file.Location = New System.Drawing.Point(358, 318)
        Me.txt_file.Name = "txt_file"
        Me.txt_file.Size = New System.Drawing.Size(156, 20)
        Me.txt_file.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(439, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "&Import"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(358, 344)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(75, 23)
        Me.btn_browse.TabIndex = 16
        Me.btn_browse.Text = "&Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(185, 409)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "&Export"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'pegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(673, 454)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.txt_file)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_id_pegawai)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_ket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_kode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Pegawai"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventaris_barangDataSetPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_kode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_ket As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents Inventaris_barangDataSetPegawai As Aplikasi_inventaris.inventaris_barangDataSetPegawai
    Friend WithEvents PegawaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PegawaiTableAdapter As Aplikasi_inventaris.inventaris_barangDataSetPegawaiTableAdapters.pegawaiTableAdapter
    Friend WithEvents IdpegawaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamapegawaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_id_pegawai As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_file As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
