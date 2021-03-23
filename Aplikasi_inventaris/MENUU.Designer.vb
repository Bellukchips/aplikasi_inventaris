<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENUU
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
        Me.lbl_pinjam = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_jmlh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id_pn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nama_p = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id_b = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama_b = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_tanggal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdpegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaris_barangDataSetdataku = New Aplikasi_inventaris.inventaris_barangDataSetdataku()
        Me.PegawaiTableAdapter = New Aplikasi_inventaris.inventaris_barangDataSetdatakuTableAdapters.pegawaiTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventaris_barangDataSetdataku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 51)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(488, 191)
        Me.dg.TabIndex = 62
        '
        'lbl_pinjam
        '
        Me.lbl_pinjam.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_pinjam.AutoSize = True
        Me.lbl_pinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pinjam.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_pinjam.Location = New System.Drawing.Point(633, 117)
        Me.lbl_pinjam.Name = "lbl_pinjam"
        Me.lbl_pinjam.Size = New System.Drawing.Size(95, 25)
        Me.lbl_pinjam.TabIndex = 61
        Me.lbl_pinjam.Text = "PINJAM"
        '
        'btn_simpan
        '
        Me.btn_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_simpan.Location = New System.Drawing.Point(896, 127)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(101, 46)
        Me.btn_simpan.TabIndex = 60
        Me.btn_simpan.Text = "&PINJAM"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_id.Location = New System.Drawing.Point(891, 78)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(189, 25)
        Me.lbl_id.TabIndex = 59
        Me.lbl_id.Text = "ID PEMINJAMAN"
        '
        'txt_jmlh
        '
        Me.txt_jmlh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_jmlh.Location = New System.Drawing.Point(896, 22)
        Me.txt_jmlh.Name = "txt_jmlh"
        Me.txt_jmlh.Size = New System.Drawing.Size(125, 20)
        Me.txt_jmlh.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(814, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "JUMLAH"
        '
        'txt_id_pn
        '
        Me.txt_id_pn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_id_pn.Enabled = False
        Me.txt_id_pn.Location = New System.Drawing.Point(638, 222)
        Me.txt_id_pn.Name = "txt_id_pn"
        Me.txt_id_pn.Size = New System.Drawing.Size(125, 20)
        Me.txt_id_pn.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(516, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "ID PEGAWAI"
        '
        'txt_nama_p
        '
        Me.txt_nama_p.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_nama_p.Location = New System.Drawing.Point(638, 175)
        Me.txt_nama_p.Name = "txt_nama_p"
        Me.txt_nama_p.Size = New System.Drawing.Size(125, 20)
        Me.txt_nama_p.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(516, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 15)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "NAMA PEGAWAI"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(516, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "STATUS"
        '
        'txt_id_b
        '
        Me.txt_id_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_id_b.Enabled = False
        Me.txt_id_b.Location = New System.Drawing.Point(638, 74)
        Me.txt_id_b.Name = "txt_id_b"
        Me.txt_id_b.Size = New System.Drawing.Size(125, 20)
        Me.txt_id_b.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(516, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "ID BARANG"
        '
        'txt_nama_b
        '
        Me.txt_nama_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_nama_b.Enabled = False
        Me.txt_nama_b.Location = New System.Drawing.Point(638, 24)
        Me.txt_nama_b.Name = "txt_nama_b"
        Me.txt_nama_b.Size = New System.Drawing.Size(125, 20)
        Me.txt_nama_b.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(516, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "NAMA BARANG"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(884, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 24)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "BULAN"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-2, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 24)
        Me.Label7.TabIndex = 64
        '
        'lbl_tanggal
        '
        Me.lbl_tanggal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_tanggal.BackColor = System.Drawing.Color.White
        Me.lbl_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggal.Location = New System.Drawing.Point(966, 424)
        Me.lbl_tanggal.Name = "lbl_tanggal"
        Me.lbl_tanggal.Size = New System.Drawing.Size(140, 24)
        Me.lbl_tanggal.TabIndex = 63
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpegawaiDataGridViewTextBoxColumn, Me.NamapegawaiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PegawaiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(849, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(243, 191)
        Me.DataGridView1.TabIndex = 66
        Me.DataGridView1.Visible = False
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
        'PegawaiBindingSource
        '
        Me.PegawaiBindingSource.DataMember = "pegawai"
        Me.PegawaiBindingSource.DataSource = Me.Inventaris_barangDataSetdataku
        '
        'Inventaris_barangDataSetdataku
        '
        Me.Inventaris_barangDataSetdataku.DataSetName = "inventaris_barangDataSetdataku"
        Me.Inventaris_barangDataSetdataku.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PegawaiTableAdapter
        '
        Me.PegawaiTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_inventaris.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(768, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(731, 55)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "FORM PEMINJAMAN BARANG"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(186, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(108, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Cari Barang"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(1003, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 46)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "&RESET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MENUU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1104, 448)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_tanggal)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.lbl_pinjam)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_jmlh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_id_pn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nama_p)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_id_b)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nama_b)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MENUU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENUU"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventaris_barangDataSetdataku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_pinjam As System.Windows.Forms.Label
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents txt_jmlh As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_id_pn As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nama_p As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_id_b As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nama_b As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_tanggal As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Inventaris_barangDataSetdataku As Aplikasi_inventaris.inventaris_barangDataSetdataku
    Friend WithEvents PegawaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PegawaiTableAdapter As Aplikasi_inventaris.inventaris_barangDataSetdatakuTableAdapters.pegawaiTableAdapter
    Friend WithEvents IdpegawaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamapegawaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
