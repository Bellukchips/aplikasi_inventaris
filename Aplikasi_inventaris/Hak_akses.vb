Imports System.Data.SqlClient
Public Class Hak_akses

    Private Sub Hak_akses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventaris_barangDataSet1.petugas' table. You can move, or remove it, as needed.
        Me.PetugasTableAdapter.Fill(Me.Inventaris_barangDataSet1.petugas)
        'TODO: This line of code loads data into the 'Inventaris_barangDataSet.pegawai' table. You can move, or remove it, as needed.
        Me.PegawaiTableAdapter.Fill(Me.Inventaris_barangDataSet.pegawai)
        'TODO: This line of code loads data into the 'Inventaris_barangDataSetPetugas1.petugas' table. You can move, or remove it, as needed.
        bukacon()
    End Sub

    Private Sub dg_pegawai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pegawai.CellClick
        i = dg_pegawai.CurrentRow.Index
        Label9.Text = dg_pegawai.Item(0, i).Value

        txt_nama.Text = dg_pegawai.Item(1, i).Value
        Label10.Visible = True
    End Sub

    Private Sub dg_pegawai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pegawai.CellContentClick

    End Sub

    Private Sub dg_petugas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_petugas.CellClick
        i = dg_petugas.CurrentRow.Index
        Label4.Text = dg_petugas.Item(0, i).Value
        Label5.Visible = True
        lbl_username.Text = dg_petugas.Item(1, i).Value
        txt_password.Text = dg_petugas.Item(2, i).Value
        txt_nama.Text = dg_petugas.Item(3, i).Value
        Label2.Text = "USERNAME BARU"
        Label8.Visible = True
    End Sub

    Private Sub dg_petugas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_petugas.CellContentClick

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_nama.Text = "" Or txt_password.Text = "" Or txt_username.Text = "" Or Label9.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
            cek = "select * from petugas where username='" & txt_username.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("USERNAME SUDAH DI GUNAKAN , GUNAKAN USERNAME YANG BERBEDA")
            Else
                con.Close()
                con.Open()
                cek1 = "select * from petugas where nama_petugas='" & txt_nama.Text & "'"
                cmd = New SqlCommand(cek1, con)
                rd = cmd.ExecuteReader
                rd.Read()
                If Not rd.HasRows Then
                    con.Close()
                    con.Open()
                    simpan = "insert into petugas values('" & txt_username.Text & "','" & txt_password.Text & "','" & txt_nama.Text & "',2,'" & Label9.Text & "')"
                    cmd = New SqlCommand(simpan, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("BERHASIL DI SIMPAN")
                    Me.PetugasTableAdapter.Fill(Me.Inventaris_barangDataSet1.petugas)
                    kosong()
                Else
                    con.Close()
                    con.Open()

                    MsgBox("GAGAL SIMPAN ,DATA SUDAH DI GUNAKAN")

                End If
            End If
            con.Close()
            con.Open()

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "•"
        End If
    End Sub
    Sub kosong()
        txt_nama.Text = ""
        Label5.Visible = False
        Label10.Visible = False
        Label4.Text = ""
        txt_password.Text = ""
        Label8.Visible = False
        lbl_username.Text = ""
        Label9.Text = ""
        txt_username.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosong()
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        If txt_nama.Text = "" Or txt_password.Text = "" Or txt_username.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
          
                con.Close()
                con.Open()
            cek = "select * from petugas where username='" & txt_username.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("USERNAME SUDAH DI GUNAKAN")
            Else
                con.Close()
                con.Open()
                ubah = "update petugas set nama_petugas='" & txt_nama.Text & "',username='" & txt_username.Text & "',password='" & txt_password.Text & "' where id_petugas='" & Label4.Text & "'"
                cmd = New SqlCommand(ubah, con)
                cmd.ExecuteNonQuery()
                MsgBox("BERHASIL DI UPDATE")
                Me.PetugasTableAdapter.Fill(Me.Inventaris_barangDataSet1.petugas)
                kosong()
            End If


        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If Label4.Text = "" Then
            MsgBox("Cari data dahulu")
        Else
            cek = "select * from inventaris where id_petugas='" & Label4.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("DATA PETUGAS DENGAN NAMA '" & txt_nama.Text & "' TIDAK BISA DI HAPUS", MsgBoxStyle.Critical)
            ElseIf MsgBox("ANDA YAKIN INGIN MENGHAPUS DATA User ''" & txt_nama.Text & "' ?", vbQuestion + vbYesNo) = vbYes Then
                con.Close()
                con.Open()
                hapus = "delete from petugas where id_petugas='" & Label4.Text & "'"
                cmd = New SqlCommand(hapus, con)
                cmd.ExecuteNonQuery()
                MsgBox("BERHASIL DI HAPUS", vbInformation)
                Me.PetugasTableAdapter.Fill(Me.Inventaris_barangDataSet1.petugas)
                kosong()
            Else
                MsgBox("DATA TIDAK DI HAPUS")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New SqlDataAdapter("select * from pegawai where nama_pegawai like '%" & TextBox1.Text & "%'", con)
        ds = New DataSet
        da.Fill(ds)
        dg_pegawai.DataSource = ds.Tables(0)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        da = New SqlDataAdapter("select * from petugas where nama_petugas like '%" & TextBox3.Text & "%'", con)
        ds = New DataSet
        da.Fill(ds)
        dg_petugas.DataSource = ds.Tables(0)
    End Sub
End Class