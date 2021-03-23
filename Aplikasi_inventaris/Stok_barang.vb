Imports System.Data.SqlClient
Public Class Stok_barang
    
    Private Sub Stok_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventaris_barangDataSetInventaris1.inventaris' table. You can move, or remove it, as needed.
        Me.InventarisTableAdapter.Fill(Me.Inventaris_barangDataSetInventaris1.inventaris)
        bukacon()
        tampil()
        lbl_id1.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New SqlDataAdapter("select * from inventaris where nama_barang like '%" & TextBox1.Text & "%'", con)
        ds = New DataSet
        da.Fill(ds)
        dg.DataSource = ds.Tables(0)
    End Sub
    Sub tampil()
        bukacon()
        da = New SqlDataAdapter("select stok.id_stok,stok.id_inventaris,inventaris.nama_barang,inventaris.jumlah,stok.jumlah from stok inner join inventaris on inventaris.id_inventaris=stok.id_inventaris ", con)
        dt = New DataTable
        da.Fill(dt)
        dg_stok.DataSource = dt
        dg_stok.Columns(0).HeaderText = "ID STOK"
        dg_stok.Columns(1).HeaderText = "ID INVENTARIS"
        dg_stok.Columns(2).HeaderText = "NAMA BARANG"
        dg_stok.Columns(3).HeaderText = "JUMLAH KESELURUHAN"
        dg_stok.Columns(4).HeaderText = "JUMLAH YANG BOLEH DI PINJAM"

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_stok.CellClick
        i = dg_stok.CurrentRow.Index

        Label4.Text = dg_stok.Item(0, i).Value
        lbl_id.Text = dg_stok.Item(1, i).Value
        txt_jumlah.Text = dg_stok.Item(4, i).Value

        Label4.Visible = True
        Label4.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_stok.CellContentClick

    End Sub
    Sub kosong()
        lbl_id.Text = ""
        lbl_id1.Visible = False
        Label4.Visible = False
        Label4.Text = ""
        lbl_id1.Text = ""
        txt_jumlah.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosong()

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        i = dg.CurrentRow.Index
        lbl_id.Text = dg.Item(0, i).Value
        Label4.Visible = False
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If lbl_id.Text = "" Or txt_jumlah.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
            cek = "select * from stok where id_inventaris='" & lbl_id.Text & "' or id_stok='" & Val(Label4.Text) & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("JUMLAH BARANG SUDAH DI ATUR, JIKA INGIN MENGUBAH SILAHKAN KLIK TOMBOL UBAH", vbExclamation)
            Else
                con.Close()
                con.Open()
                cek = "select jumlah from inventaris where id_inventaris='" & lbl_id.Text & "'"
                cmd = New SqlCommand(cek, con)
                rd = cmd.ExecuteReader
                rd.Read()
                If txt_jumlah.Text > rd.Item("jumlah") Then
                    con.Close()
                    con.Open()
                    MsgBox("JUMLAH MELEBIHI STOK ASLI")
                Else
                    con.Close()
                    con.Open()
                    simpan = "insert into stok values('" & lbl_id.Text & "','" & txt_jumlah.Text & "')"
                    cmd = New SqlCommand(simpan, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("berhasil di simpan")
                    tampil()
                    kosong()

                End If
            End If
            rd.Close()
            cmd.Dispose()
            con.Close()
            con.Open()

        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        If lbl_id.Text = "" Or txt_jumlah.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
            cek = "select * from stok where id_inventaris='" & lbl_id.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = 0 Then
                con.Close()
                con.Open()
                MsgBox("DATA TIDAK BISA DI UPDATE KARENA BELUM TERSIMPAN")
            Else
                con.Close()
                con.Open()
                cek1 = "select jumlah from inventaris where id_inventaris='" & lbl_id.Text & "'"
                cmd = New SqlCommand(cek1, con)
                rd = cmd.ExecuteReader
                rd.Read()
                If txt_jumlah.Text > rd.Item("jumlah") Then
                    con.Close()
                    con.Open()
                    MsgBox("JUMLAH MELEBIHI STOK ASLI")
                Else
                    con.Close()
                    con.Open()
                    ubah = "update stok set jumlah='" & txt_jumlah.Text & "' where id_stok='" & Label4.Text & "'"
                    cmd = New SqlCommand(ubah, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("BERHASIL DI UBAH")
                    tampil()
                    kosong()

                End If
            End If
         

        End If
        con.Close()
        con.Open()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If lbl_id.Text = "" Or txt_jumlah.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
            cek1 = "select * from detail_pinjam where id_inventaris='" & lbl_id.Text & "'"
            cmd = New SqlCommand(cek1, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("DATA TIDAK BISA DI HAPUS")
            Else
                con.Close()
                con.Open()
                hapus = "delete from stok where id_stok='" & Label4.Text & "'"
                cmd = New SqlCommand(hapus, con)
                cmd.ExecuteNonQuery()
                MsgBox("BERHASIL DI HAPUS")
                tampil()
                kosong()

           
            End If
            con.Close()
            con.Open()

        End If


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        da = New SqlDataAdapter("select stok.id_stok,stok.id_inventaris,inventaris.nama_barang,inventaris.jumlah,stok.jumlah from stok inner join inventaris on inventaris.id_inventaris=stok.id_inventaris where nama_barang like '%" & TextBox2.Text & "%' ", con)
        ds = New DataSet
        da.Fill(ds)
        dg_stok.DataSource = ds.Tables(0)
    End Sub

    Private Sub txt_jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

    End Sub

    Private Sub txt_jumlah_TextChanged(sender As Object, e As EventArgs) Handles txt_jumlah.TextChanged

    End Sub
End Class