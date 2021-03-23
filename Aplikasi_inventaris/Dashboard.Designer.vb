<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RuangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HakAksesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AturStokBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PERBULANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEGAWAIToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_tanggal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.PengembalianToolStripMenuItem, Me.ReportToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1174, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PegawaiToolStripMenuItem, Me.InventarisToolStripMenuItem, Me.RuangToolStripMenuItem, Me.HakAksesToolStripMenuItem, Me.AturStokBarangToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'PegawaiToolStripMenuItem
        '
        Me.PegawaiToolStripMenuItem.Name = "PegawaiToolStripMenuItem"
        Me.PegawaiToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PegawaiToolStripMenuItem.Text = "Pegawai"
        '
        'InventarisToolStripMenuItem
        '
        Me.InventarisToolStripMenuItem.Name = "InventarisToolStripMenuItem"
        Me.InventarisToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.InventarisToolStripMenuItem.Text = "Inventaris"
        '
        'RuangToolStripMenuItem
        '
        Me.RuangToolStripMenuItem.Name = "RuangToolStripMenuItem"
        Me.RuangToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RuangToolStripMenuItem.Text = "Ruang"
        '
        'HakAksesToolStripMenuItem
        '
        Me.HakAksesToolStripMenuItem.Name = "HakAksesToolStripMenuItem"
        Me.HakAksesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.HakAksesToolStripMenuItem.Text = "Hak Akses"
        '
        'AturStokBarangToolStripMenuItem
        '
        Me.AturStokBarangToolStripMenuItem.Name = "AturStokBarangToolStripMenuItem"
        Me.AturStokBarangToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AturStokBarangToolStripMenuItem.Text = "Atur Stok Barang"
        '
        'PengembalianToolStripMenuItem
        '
        Me.PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        Me.PengembalianToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.PengembalianToolStripMenuItem.Text = "Pengembalian"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PERBULANToolStripMenuItem, Me.PEGAWAIToolStripMenuItem1})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'PERBULANToolStripMenuItem
        '
        Me.PERBULANToolStripMenuItem.Name = "PERBULANToolStripMenuItem"
        Me.PERBULANToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PERBULANToolStripMenuItem.Text = "PERBULAN"
        '
        'PEGAWAIToolStripMenuItem1
        '
        Me.PEGAWAIToolStripMenuItem1.Name = "PEGAWAIToolStripMenuItem1"
        Me.PEGAWAIToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.PEGAWAIToolStripMenuItem1.Text = "PERPEGAWAI"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'lbl_tanggal
        '
        Me.lbl_tanggal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_tanggal.BackColor = System.Drawing.Color.White
        Me.lbl_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggal.Location = New System.Drawing.Point(1034, 0)
        Me.lbl_tanggal.Name = "lbl_tanggal"
        Me.lbl_tanggal.Size = New System.Drawing.Size(140, 24)
        Me.lbl_tanggal.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(506, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 24)
        Me.Label7.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1001, 110)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "APLIKASI INVENTARIS BARANG"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(322, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(657, 167)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "KLIK DISINI UNTUK PINJAM"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(173, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1001, 110)
        Me.Label2.TabIndex = 48
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1174, 426)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_tanggal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RuangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HakAksesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AturStokBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_tanggal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PERBULANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEGAWAIToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
