Imports System.Data.SqlClient
Public Class Hasil_cari

    Private Sub Hasil_cari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukacon()
        tampil()
        Label1.Text = DateString
    End Sub
    Sub tampil()
        da = New SqlDataAdapter("select peminjaman.id_peminjaman ,inventaris.id_inventaris,inventaris.nama_barang,detail_pinjam.jumlah,pegawai.nama_pegawai,peminjaman.tgl_pinjam ,peminjaman.tgl_kembali,peminjaman.status_peminjaman,peminjaman.bulan   from peminjaman inner join detail_pinjam on detail_pinjam.id_detail_pinjam = peminjaman.id_peminjaman inner join inventaris on inventaris.id_inventaris = detail_pinjam.id_inventaris inner join pegawai on pegawai.id_pegawai = peminjaman.id_pegawai  ", con)
        dt = New DataTable
        da.Fill(dt)
        dg.DataSource = dt
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        i = dg.CurrentRow.Index
        Label3.Text = dg.Item(0, i).Value
        Label8.Text = dg.Item(1, i).Value
        Label10.Text = dg.Item(3, i).Value

        Label3.Visible = True
        Label8.Visible = True
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub
    Sub kosong()
        ComboBox1.SelectedItem = ""
        Label3.Text = ""
        Label3.Visible = False
        TextBox2.Text = ""
        Label8.Visible = False
        Label8.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        kosong()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New SqlDataAdapter("select peminjaman.id_peminjaman ,inventaris.nama_barang,detail_pinjam.jumlah,pegawai.nama_pegawai,peminjaman.tgl_pinjam ,peminjaman.tgl_kembali,peminjaman.status_peminjaman from peminjaman inner join detail_pinjam on detail_pinjam.id_detail_pinjam = peminjaman.id_peminjaman inner join inventaris on inventaris.id_inventaris = detail_pinjam.id_inventaris inner join pegawai on pegawai.id_pegawai = peminjaman.id_pegawai where id_peminjaman like '%" & TextBox1.Text & "%'", con)
        ds = New DataSet
        da.Fill(ds)
        dg.DataSource = ds.Tables(0)
    End Sub
    Sub updatekuy()
        bukacon()
        cek1 = "update detail_pinjam set detail_pinjam.jumlah = detail_pinjam.jumlah - '" & TextBox2.Text & "' where id_detail_pinjam='" & Label3.Text & "'"
        cmd = New SqlCommand(cek1, con)
        cmd.ExecuteNonQuery()

    End Sub
    Sub tambah()
        bukacon()
        simpan = "update stok set stok.jumlah = stok.jumlah + '" & TextBox2.Text & "' where id_inventaris='" & Label8.Text & "'"
        cmd = New SqlCommand(simpan, con)
        cmd.ExecuteNonQuery()
        con.Close()
        con.Open()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label3.Text = "" Then
            MsgBox("CARI DATA DAHULU")
        Else
            cek = "select status_peminjaman from peminjaman where id_peminjaman='" & Label3.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.Item("status_peminjaman") = "KEMBALI" Then
                con.Close()
                con.Open()
                MsgBox("Barang Sudah Di kembalikan")
            ElseIf TextBox2.Text > Label10.Text Then
                MsgBox("JUMLAH MELEBIHI DATA PINJAM")
            Else
                con.Close()
                con.Open()
                ubah = "update peminjaman set status_peminjaman='" & ComboBox1.Text & "',tgl_kembali='" & Label1.Text & "' where id_peminjaman='" & Label3.Text & "'"
                cmd = New SqlCommand(ubah, con)
                cmd.ExecuteNonQuery()
                tambah()
                tampil()
                updatekuy()

                MsgBox("BERHASIL DI KEMBALIKAN")
                dg.Refresh()
                kosong()

            End If
            con.Close()
            con.Open()

        End If
    End Sub
    Sub hapus()
        bukacon()
        cek = "delete from peminjaman where id_peminjaman='" & Label3.Text & "'"
        cmd = New SqlCommand(cek, con)
        cmd.ExecuteNonQuery()
        con.Close()
        con.Open()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label3.Text = "" Then
            MsgBox("CARI DATA DAHULU")
        Else
            cek = "select status_peminjaman from peminjaman where id_peminjaman='" & Label3.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.Item("status_peminjaman") = "PINJAM" Or rd.Item("status_peminjaman") = "MASIH DI PINJAM" Then
                con.Close()
                con.Open()
                MsgBox("TIDAK BISA DI HAPUS")

            Else
                con.Close()
                con.Open()
                cek1 = "delete from detail_pinjam where id_detail_pinjam='" & Label3.Text & "'"
                cmd = New SqlCommand(cek1, con)
                cmd.ExecuteNonQuery()
                hapus()
                MsgBox("Berhasil Di hapus")
                tampil()
                kosong()
            End If
            con.Close()
            con.Open()

        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class