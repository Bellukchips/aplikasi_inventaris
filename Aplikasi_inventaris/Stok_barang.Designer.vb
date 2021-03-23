<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stok_barang
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
        Me.InventarisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventaris_barangDataSetInventaris1 = New Aplikasi_inventaris.inventaris_barangDataSetInventaris1()
        Me.InventarisTableAdapter = New Aplikasi_inventaris.inventaris_barangDataSetInventaris1TableAdapters.inventarisTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_stok = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_id1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventaris_barangDataSetInventaris1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_stok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoGenerateColumns = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdinventarisDataGridViewTextBoxColumn, Me.NamabarangDataGridViewTextBoxColumn, Me.KondisiDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn})
        Me.dg.DataSource = Me.InventarisBindingSource
        Me.dg.Location = New System.Drawing.Point(20, 18)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(328, 150)
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
        'InventarisBindingSource
        '
        Me.InventarisBindingSource.DataMember = "inventaris"
        Me.InventarisBindingSource.DataSource = Me.Inventaris_barangDataSetInventaris1
        '
        'Inventaris_barangDataSetInventaris1
        '
        Me.Inventaris_barangDataSetInventaris1.DataSetName = "inventaris_barangDataSetInventaris1"
        Me.Inventaris_barangDataSetInventaris1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventarisTableAdapter
        '
        Me.InventarisTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(180, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cari Nama Barang"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 174)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA INVENTARIS"
        '
        'dg_stok
        '
        Me.dg_stok.AllowUserToAddRows = False
        Me.dg_stok.AllowUserToDeleteRows = False
        Me.dg_stok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_stok.Location = New System.Drawing.Point(5, 18)
        Me.dg_stok.Name = "dg_stok"
        Me.dg_stok.ReadOnly = True
        Me.dg_stok.Size = New System.Drawing.Size(583, 168)
        Me.dg_stok.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_stok)
        Me.GroupBox2.Location = New System.Drawing.Point(444, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 196)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA STOK BARANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID INVENTARIS"
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(156, 335)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(207, 20)
        Me.txt_jumlah.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "JUMLAH"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(391, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(553, 276)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 43
        Me.btn_hapus.Text = "&HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Location = New System.Drawing.Point(472, 276)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(75, 23)
        Me.btn_ubah.TabIndex = 42
        Me.btn_ubah.Text = "&UBAH"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(391, 276)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 41
        Me.btn_simpan.Text = "&SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(158, 293)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(79, 35)
        Me.lbl_id.TabIndex = 45
        '
        'lbl_id1
        '
        Me.lbl_id1.Location = New System.Drawing.Point(245, 358)
        Me.lbl_id1.Name = "lbl_id1"
        Me.lbl_id1.Size = New System.Drawing.Size(86, 13)
        Me.lbl_id1.TabIndex = 46
        Me.lbl_id1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "ID STOK"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "ID STOK"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(553, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 20)
        Me.TextBox2.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(454, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Cari Nama Barang"
        '
        'Stok_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1061, 399)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_id1)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_jumlah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Stok_barang"
        Me.Text = "Stok Barang"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventaris_barangDataSetInventaris1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_stok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Inventaris_barangDataSetInventaris1 As Aplikasi_inventaris.inventaris_barangDataSetInventaris1
    Friend WithEvents InventarisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarisTableAdapter As Aplikasi_inventaris.inventaris_barangDataSetInventaris1TableAdapters.inventarisTableAdapter
    Friend WithEvents IdinventarisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamabarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KondisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_stok As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_id1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
