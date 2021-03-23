Imports System.Data.SqlClient
Public Class MENUU
  
    Sub auto()
        bukacon()
        cek = "select * from peminjaman order by id_peminjaman DESC"
        cmd = New SqlCommand(cek, con)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            con.Close()
            con.Open()
            lbl_id.Text = "P" + "00001"
        Else
            lbl_id.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("id_peminjaman").ToString, 5, 3)) + 1
            If Len(lbl_id.Text) = "1" Then
                lbl_id.Text = "P0000" & lbl_id.Text & ""
            ElseIf Len(lbl_id.Text) = "2" Then
                lbl_id.Text = "P000" & lbl_id.Text & ""
            ElseIf Len(lbl_id.Text) = "3" Then
                lbl_id.Text = "P00" & lbl_id.Text & ""
            ElseIf Len(lbl_id.Text) = "4" Then
                lbl_id.Text = "P0" & lbl_id.Text & ""
            ElseIf Len(lbl_id.Text) = "5" Then
                lbl_id.Text = "P" & lbl_id.Text & ""

            End If
            rd.Close()
            cmd.Dispose()
            con.Close()
            con.Open()
        End If
    End Sub
    Private Sub MENUU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventaris_barangDataSetdataku.pegawai' table. You can move, or remove it, as needed.
        Me.PegawaiTableAdapter.Fill(Me.Inventaris_barangDataSetdataku.pegawai)
        tampil()
        lbl_tanggal.Text = DateString
        Label7.Text = TimeOfDay
        auto()
        Dim a As Integer
        a = Today.Month
        Label8.Text = MonthName(a, False)
    End Sub
    Sub tampil()
        bukacon()
        da = New SqlDataAdapter("select stok.id_stok,stok.id_inventaris,inventaris.nama_barang,stok.jumlah from stok inner join inventaris on inventaris.id_inventaris=stok.id_inventaris ", con)
        dt = New DataTable
        da.Fill(dt)
        dg.DataSource = dt
        dg.Columns(0).HeaderText = "ID STOK"
        dg.Columns(1).HeaderText = "ID INVENTARIS"
        dg.Columns(2).HeaderText = "NAMA BARANG"
        dg.Columns(3).HeaderText = "JUMLAH"

    End Sub
    Sub kurang()
        bukacon()
        ubah = "update stok set stok.jumlah = stok.jumlah - '" & txt_jmlh.Text & "' where id_inventaris='" & txt_id_b.Text & "'"
        cmd = New SqlCommand(ubah, con)
        cmd.ExecuteNonQuery()

    End Sub
    Sub save_detail()
        con.Close()
        con.Open()

        cek = "insert into detail_pinjam values('" & lbl_id.Text & "','" & txt_id_b.Text & "','" & txt_jmlh.Text & "')"
        cmd = New SqlCommand(cek, con)
        cmd.ExecuteNonQuery()
        con.Close()
        con.Open()

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_id_b.Text = "" Or txt_id_pn.Text = "" Or txt_jmlh.Text = "" Or txt_nama_b.Text = "" Or txt_nama_p.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
            cek = "select * from peminjaman where id_peminjaman='" & lbl_id.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("ID SUDAH ADA", MsgBoxStyle.Critical)
            Else
                con.Close()
                con.Open()
                cek1 = "select jumlah from stok where id_inventaris='" & txt_id_b.Text & "'"
                cmd = New SqlCommand(cek1, con)
                rd = cmd.ExecuteReader
                rd.Read()
                If txt_jmlh.Text > rd.Item("jumlah") Then
                    con.Close()
                    con.Open()
                    MsgBox("JUMLAH STOK TERBATAS")
                ElseIf rd.Item("jumlah") = 0 Then
                    con.Close()
                    con.Close()
                    MsgBox("STOK HABIS, TUNGGU BARANG DI KEMBALIKAN")
                Else
                    con.Close()
                    con.Open()
                    simpan = "insert into peminjaman values('" & lbl_id.Text & "','" & lbl_tanggal.Text & "',null,'" & lbl_pinjam.Text & "','" & Label8.Text & "','" & txt_id_pn.Text & "')"
                    cmd = New SqlCommand(simpan, con)
                    cmd.ExecuteNonQuery()
                    kurang()
                    MsgBox("BERHASIL DI SIMPAN")
                    save_detail()
                    tampil()
                    auto()
                    dg.Refresh()
                    kosong()

                End If

            End If
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        i = dg.CurrentRow.Index
        txt_id_b.Text = dg.Item(1, i).Value
        txt_nama_b.Text = dg.Item(2, i).Value
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        da = New SqlDataAdapter("select * from pegawai where nama_pegawai like '%" & txt_nama_p.Text & "%'", con)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Visible = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        txt_id_pn.Text = DataGridView1.Item(0, i).Value
        DataGridView1.Visible = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txt_jmlh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jmlh.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

    End Sub

   
    Private Sub txt_jmlh_TextChanged(sender As Object, e As EventArgs) Handles txt_jmlh.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New SqlDataAdapter("select stok.id_stok,stok.id_inventaris,inventaris.nama_barang,stok.jumlah from stok inner join inventaris on inventaris.id_inventaris=stok.id_inventaris where nama_barang like '%" & TextBox1.Text & "%' ", con)
        ds = New DataSet
        da.Fill(ds)
        dg.DataSource = ds.Tables(0)
    End Sub
    Sub kosong()
        txt_id_b.Text = ""
        txt_jmlh.Text = ""
        txt_id_pn.Text = ""
        txt_nama_b.Text = ""
        txt_nama_p.Text = ""
        TextBox1.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosong()

    End Sub
End Class