Imports System.Data.SqlClient
Public Class Inventarisir

    Private Sub Inventarisir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventaris_barangDataSetRuang2.ruang' table. You can move, or remove it, as needed.
        Me.RuangTableAdapter.Fill(Me.Inventaris_barangDataSetRuang2.ruang)
        'TODO: This line of code loads data into the 'Inventaris_barangDataSetJenis.jenis' table. You can move, or remove it, as needed.
        Me.JenisTableAdapter.Fill(Me.Inventaris_barangDataSetJenis.jenis)
        'TODO: This line of code loads data into the 'Inventaris_barangDataSetNama_ruang.ruang' table. You can move, or remove it, as needed.
     'TODO: This line of code loads data into the 'Inventaris_barangDataSetInventaris.inventaris' table. You can move, or remove it, as needed.
        Me.InventarisTableAdapter.Fill(Me.Inventaris_barangDataSetInventaris.inventaris)
        auto()
        lbl_tanggal.Text = DateString
    End Sub
   
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New SqlDataAdapter("select * from inventaris where nama_barang like '%" & TextBox1.Text & "%'", con)
        ds = New DataSet
        da.Fill(ds)
        dg.DataSource = ds.Tables(0)
    End Sub
  

    Private Sub txt_id_j_TextChanged(sender As Object, e As EventArgs) Handles txt_id_j.TextChanged

    End Sub

    Private Sub cmb_jenis_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DG_JENIS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_JENIS.CellClick
        Dim a As Integer
        a = DG_JENIS.CurrentRow.Index
        txt_id_j.Text = DG_JENIS.Item(0, a).Value
    End Sub

    Private Sub DG_JENIS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_JENIS.CellContentClick

    End Sub

    Private Sub DG_RUANG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_RUANG.CellClick
        Dim c As Integer
        c = DG_RUANG.CurrentRow.Index
        txt_id_r.Text = DG_RUANG.Item(0, c).Value

    End Sub

    Private Sub DG_RUANG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_RUANG.CellContentClick

    End Sub
    Sub kosong()
        txt_id_j.Text = ""
        txt_id_r.Text = ""
        txt_jml.Text = ""
        txt_kode_i.Text = ""
        txt_nama.Text = ""
        auto()
        lbl_id.Text = ""
        lbl_id.Visible = False
        lbl_id_inv.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosong()

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_id_j.Text = "" Or txt_id_p.Text = "" Or txt_id_r.Text = "" Or txt_jml.Text = "" Or txt_kode_i.Text = "" Or txt_nama.Text = "" Or cbo_kon.Text = "" Then
            MsgBox("Harus di isi semua")
        Else
            cek = "select * from inventaris where kode_inventaris='" & txt_kode_i.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("KODE INVENTARIS SUDAH DI GUNAKAN ,MOHON HUBUNGI ADMIN UNTUK MELAKUKAN BACKUP DATA")
            Else
                con.Close()
                con.Open()
                cek1 = "select * from inventaris where nama_barang like '%" & txt_nama.Text & "%'"
                cmd = New SqlCommand(cek1, con)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    con.Close()
                    con.Open()
                    MsgBox("NAMA BARANG SUDAH ADA , JIKA MEMILIKI PERBEDAAN KETIKAN LENGKAP SPESIFIKASI BARANG", vbExclamation)
                Else
                    con.Close()
                    con.Open()
                    simpan = "insert into inventaris values('" & txt_nama.Text & "','" & cbo_kon.Text & "','" & txt_jml.Text & "','" & txt_id_j.Text & "','" & lbl_tanggal.Text & "','" & txt_id_r.Text & "','" & txt_kode_i.Text & "','" & txt_id_p.Text & "')"
                    cmd = New SqlCommand(simpan, con)
                    cmd.ExecuteNonQuery()
                    Me.InventarisTableAdapter.Fill(Me.Inventaris_barangDataSetInventaris.inventaris)

                    MsgBox("BERHASIL DI SIMPAN", vbInformation)
                    auto()
                End If
            End If
            con.Close()
            con.Open()

        End If
    End Sub

    Private Sub txt_kode_i_TextChanged(sender As Object, e As EventArgs) Handles txt_kode_i.TextChanged

    End Sub
    Sub auto()
        bukacon()

        cek = "select * from inventaris order by kode_inventaris DESC"
        cmd = New SqlCommand(cek, con)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            con.Close()
            con.Open()
            txt_kode_i.Text = "INV" + "00001"
        Else
            txt_kode_i.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("kode_inventaris").ToString, 6, 3)) + 1
            If Len(txt_kode_i.Text) = "1" Then
                txt_kode_i.Text = "INV0000" & txt_kode_i.Text & ""
            ElseIf Len(txt_kode_i.Text) = "2" Then
                txt_kode_i.Text = "INV000" & txt_kode_i.Text & ""
            ElseIf Len(txt_kode_i.Text) = "3" Then
                txt_kode_i.Text = "INV00" & txt_kode_i.Text & ""
            ElseIf Len(txt_kode_i.Text) = "4" Then
                txt_kode_i.Text = "INV0" & txt_kode_i.Text & ""
            ElseIf Len(txt_kode_i.Text) = "5" Then
                txt_kode_i.Text = "INV" & txt_kode_i.Text & ""
            End If
            rd.Close()
            cmd.Dispose()
            con.Close()
            con.Open()
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        lbl_id.Visible = True
        lbl_id_inv.Visible = True
        lbl_id.Text = dg.Item(0, i).Value
        txt_nama.Text = dg.Item(1, i).Value
        cbo_kon.Text = dg.Item(2, i).Value
        txt_jml.Text = dg.Item(3, i).Value
        txt_id_j.Text = dg.Item(4, i).Value
        txt_id_r.Text = dg.Item(6, i).Value
        txt_kode_i.Text = dg.Item(7, i).Value


    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        If txt_id_j.Text = "" Or txt_id_p.Text = "" Or txt_id_r.Text = "" Or txt_jml.Text = "" Or txt_kode_i.Text = "" Or txt_nama.Text = "" Or cbo_kon.Text = "" Or lbl_id.Text = "" Then
            MsgBox("Harus di isi semua")
        Else
            ubah = "update inventaris set nama_barang='" & txt_nama.Text & "',kondisi='" & cbo_kon.Text & "',jumlah='" & txt_jml.Text & "',id_jenis='" & txt_id_j.Text & "',id_ruang='" & txt_id_r.Text & "',kode_inventaris='" & txt_kode_i.Text & "' where id_inventaris='" & lbl_id.Text & "'"
            cmd = New SqlCommand(ubah, con)
            cmd.ExecuteNonQuery()
            MsgBox("BERHASIL UPDATE", vbInformation)
            Me.InventarisTableAdapter.Fill(Me.Inventaris_barangDataSetInventaris.inventaris)

        End If
        con.Close()
        con.Open()

    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If lbl_id.Text = "" Then
            MsgBox("CARI DATA TERLEBIH DAHULU")
        ElseIf MsgBox("Yakin ingin hapus data", vbExclamation + vbYesNo) = vbYes Then

            cek = "select * from stok where id_inventaris='" & lbl_id.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("DATA TIDAK BISA DI HAPUS KARENA ADA KETERKAITAN DENGAN STOK")
            ElseIf MsgBox("ANDA AKAN MENGHAPUS DATA '" & txt_nama.Text & "' ?", vbQuestion + vbYesNo) = vbYes Then
                con.Close()
                con.Open()
                hapus = "delete from inventaris where id_inventaris='" & lbl_id.Text & "'"
                cmd = New SqlCommand(hapus, con)
                cmd.ExecuteNonQuery()
                Me.InventarisTableAdapter.Fill(Me.Inventaris_barangDataSetInventaris.inventaris)

                MsgBox("BERHASIL HAPUS")
            Else
                MsgBox("DATA TIDAK DI HAPUS")

            End If
        Else
            MsgBox("HAPUS DI BATALKAN")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        da = New SqlDataAdapter("select * from ruang where nama_ruang like '%" & TextBox2.Text & "%'", con)
        ds = New DataSet
        da.Fill(ds)
        DG_RUANG.DataSource = ds.Tables(0)
    End Sub

    Private Sub txt_jml_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jml.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

    End Sub

    Private Sub txt_jml_TextChanged(sender As Object, e As EventArgs) Handles txt_jml.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object
        Dim i As Integer
        Dim j As Integer

        'create object of excel
        ExcelApp = CreateObject("Excel.Application")
        ExcelBook = ExcelApp.WorkBooks.Add
        ExcelSheet = ExcelBook.WorkSheets(1)

        With ExcelSheet
            For Each column As DataGridViewColumn In dg.Columns
                .cells(1, column.Index + 1) = column.HeaderText
            Next
            For i = 1 To Me.dg.RowCount
                .cells(i + 1, 1) = Me.dg.Rows(i - 1).Cells(0).Value
                For j = 1 To dg.Columns.Count - 1
                    .cells(i + 1, j + 1) = dg.Rows(i - 1).Cells(j).Value
                Next

            Next
            MsgBox("exported successfully to Excel")
            ExcelApp.Visible = True
            ExcelApp.Columns.AutoFit()
            ExcelApp.Rows("1:1").Font.FontStyle = "Bold"
            ExcelApp.Rows("1:1").Font.Size = 12
            ExcelApp.Cells.Select()
            ExcelApp.Cells.EntireColumn.AutoFit()
            ExcelApp.Cells(1, 1).Select()
        End With

        ExcelApp.Visible = True
        '
        ExcelSheet = Nothing
        ExcelBook = Nothing
        ExcelApp = Nothing
    End Sub
End Class