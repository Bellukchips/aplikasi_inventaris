<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ruang
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
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txt_ket = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.IdruangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaruangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KoderuangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RuangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaris_barangDataSetRuang = New Aplikasi_inventaris.inventaris_barangDataSetRuang()
        Me.RuangTableAdapter = New Aplikasi_inventaris.inventaris_barangDataSetRuangTableAdapters.ruangTableAdapter()
        Me.lbl_id_ruang = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RuangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventaris_barangDataSetRuang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(279, 397)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 23
        Me.btn_hapus.Text = "&HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Location = New System.Drawing.Point(198, 397)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(75, 23)
        Me.btn_ubah.TabIndex = 22
        Me.btn_ubah.Text = "&UBAH"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(117, 397)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 21
        Me.btn_simpan.Text = "&SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txt_ket
        '
        Me.txt_ket.Location = New System.Drawing.Point(159, 335)
        Me.txt_ket.Multiline = True
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.Size = New System.Drawing.Size(186, 46)
        Me.txt_ket.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "KETERANGAN"
        '
        'txt_kode
        '
        Me.txt_kode.Enabled = False
        Me.txt_kode.Location = New System.Drawing.Point(159, 299)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(186, 20)
        Me.txt_kode.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "KODE"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(159, 258)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(186, 20)
        Me.txt_nama.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(147, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cari Nama"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoGenerateColumns = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdruangDataGridViewTextBoxColumn, Me.NamaruangDataGridViewTextBoxColumn, Me.KoderuangDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.dg.DataSource = Me.RuangBindingSource
        Me.dg.Location = New System.Drawing.Point(105, 60)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(275, 168)
        Me.dg.TabIndex = 12
        '
        'IdruangDataGridViewTextBoxColumn
        '
        Me.IdruangDataGridViewTextBoxColumn.DataPropertyName = "id_ruang"
        Me.IdruangDataGridViewTextBoxColumn.HeaderText = "id_ruang"
        Me.IdruangDataGridViewTextBoxColumn.Name = "IdruangDataGridViewTextBoxColumn"
        Me.IdruangDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.RuangBindingSource.DataSource = Me.Inventaris_barangDataSetRuang
        '
        'Inventaris_barangDataSetRuang
        '
        Me.Inventaris_barangDataSetRuang.DataSetName = "inventaris_barangDataSetRuang"
        Me.Inventaris_barangDataSetRuang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RuangTableAdapter
        '
        Me.RuangTableAdapter.ClearBeforeFill = True
        '
        'lbl_id_ruang
        '
        Me.lbl_id_ruang.AutoSize = True
        Me.lbl_id_ruang.Location = New System.Drawing.Point(351, 261)
        Me.lbl_id_ruang.Name = "lbl_id_ruang"
        Me.lbl_id_ruang.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id_ruang.TabIndex = 24
        Me.lbl_id_ruang.Text = "ID"
        Me.lbl_id_ruang.Visible = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(375, 261)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 13)
        Me.lbl_id.TabIndex = 25
        Me.lbl_id.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Ruang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(464, 471)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_id_ruang)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Ruang"
        Me.Text = "Ruang"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RuangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventaris_barangDataSetRuang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents txt_ket As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_kode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Inventaris_barangDataSetRuang As Aplikasi_inventaris.inventaris_barangDataSetRuang
    Friend WithEvents RuangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RuangTableAdapter As Aplikasi_inventaris.inventaris_barangDataSetRuangTableAdapters.ruangTableAdapter
    Friend WithEvents IdruangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaruangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KoderuangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_id_ruang As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
