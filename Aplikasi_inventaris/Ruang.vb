Imports System.Data.SqlClient

Public Class Ruang

    Private Sub Ruang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventaris_barangDataSetRuang.ruang' table. You can move, or remove it, as needed.
        Me.RuangTableAdapter.Fill(Me.Inventaris_barangDataSetRuang.ruang)
        bukacon()
        auto()
    End Sub
    Sub auto()
        cek = "select * from ruang order by kode_ruang DESC"
        cmd = New SqlCommand(cek, con)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            con.Close()
            con.Open()
            txt_kode.Text = "RG" + "00001"
        Else
            txt_kode.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("kode_ruang").ToString, 5, 3)) + 1
            If Len(txt_kode.Text) = "1" Then
                txt_kode.Text = "RG0000" & txt_kode.Text & ""
            ElseIf Len(txt_kode.Text) = "2" Then
                txt_kode.Text = "RG000" & txt_kode.Text & ""
            ElseIf Len(txt_kode.Text) = "3" Then
                txt_kode.Text = "RG00" & txt_kode.Text & ""
            ElseIf Len(txt_kode.Text) = "4" Then
                txt_kode.Text = "RG0" & txt_kode.Text & ""
            ElseIf Len(txt_kode.Text) = "5" Then
                txt_kode.Text = "RG" & txt_kode.Text & ""
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
        lbl_id.Text = dg.Item(0, i).Value
        txt_nama.Text = dg.Item(1, i).Value
        txt_kode.Text = dg.Item(2, i).Value
        txt_ket.Text = dg.Item(3, i).Value
        lbl_id.Visible = True
        lbl_id_ruang.Visible = True
        txt_kode.Enabled = False

    End Sub
    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub txt_kode_TextChanged(sender As Object, e As EventArgs) Handles txt_kode.TextChanged

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_ket.Text = "" Or txt_kode.Text = "" Or txt_nama.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
            cek = "select * from ruang where kode_ruang='" & txt_kode.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("KODE SUDAH ADA,HUBUNGI ADMIN", vbExclamation)
            Else
                con.Close()
                con.Open()
                cek1 = "select * from ruang where nama_ruang like'%" & txt_nama.Text & "%'"
                cmd = New SqlCommand(cek1, con)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    con.Close()
                    con.Open()
                    MsgBox("Ruang '" & txt_nama.Text & "' Sudah ada, Jika Ingin Mengubah Data Silahkan Cari data dahulu", vbExclamation)
                Else
                    con.Close()
                    con.Open()
                    simpan = "insert into ruang values('" & txt_nama.Text & "','" & txt_kode.Text & "','" & txt_ket.Text & "')"
                    cmd = New SqlCommand(simpan, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("BERHASIL DI SIMPAN", vbInformation)
                    Me.RuangTableAdapter.Fill(Me.Inventaris_barangDataSetRuang.ruang)
                    auto()
                End If
            End If
            rd.Close()
            cmd.Dispose()
            con.Close()
            con.Open()
        End If

    End Sub
    Sub kosong()
        txt_ket.Text = ""
        txt_kode.Text = ""
        txt_nama.Text = ""
        txt_kode.Enabled = False
        lbl_id_ruang.Text = ""
        lbl_id.Visible = False
        lbl_id_ruang.Visible = False
        auto()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosong()
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        If txt_ket.Text = "" Or txt_kode.Text = "" Or txt_nama.Text = "" Or lbl_id.Text = "" Then

            MsgBox("HARUS DI ISI SEMUA,PILIHLAH SALAH SATU DATA UNTUK DI UPDATE KEMUDIAN KLIK DATA TERSEBUT")

        Else
            ubah = "update ruang set nama_ruang='" & txt_nama.Text & "',kode_ruang='" & txt_kode.Text & "',keterangan='" & txt_ket.Text & "' where id_ruang='" & lbl_id.Text & "'"
            cmd = New SqlCommand(ubah, con)
            cmd.ExecuteNonQuery()
            MsgBox("BERHASIL DI UBAH")
            Me.RuangTableAdapter.Fill(Me.Inventaris_barangDataSetRuang.ruang)
        End If
        con.Close()
        con.Open()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If lbl_id_ruang.Text = "" Then
            MsgBox("CARI DATA DAHULU,KEMUDIAN KLIK DATA")
        Else
            cek = "select * from inventaris where id_ruang='" & lbl_id.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("RUANG '" & txt_nama.Text & "' Tidak bisa di hapus karena sudah digunakan dalam data inventaris", vbExclamation)
            ElseIf MsgBox("Data '" & txt_nama.Text & "' akan di hapus ?", vbQuestion + vbYesNo) = vbYes Then
                con.Close()
                con.Open()
                hapus = "delete from ruang where id_ruang='" & lbl_id.Text & "'"
                cmd = New SqlCommand(hapus, con)
                cmd.ExecuteNonQuery()
                Me.RuangTableAdapter.Fill(Me.Inventaris_barangDataSetRuang.ruang)
                MsgBox("BERHASIL DI HAPUS")
            Else
                MsgBox("Data Tidak Di hapus")

            End If
        End If
        con.Close()
        con.Open()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New SqlDataAdapter("select * from ruang where nama_ruang like '%" & TextBox1.Text & "%'", con)
        ds = New DataSet
        da.Fill(ds)
        dg.DataSource = ds.Tables(0)
    End Sub

    Private Sub txt_nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nama.KeyPress

    End Sub

    Private Sub txt_nama_TextChanged(sender As Object, e As EventArgs) Handles txt_nama.TextChanged

    End Sub
End Class