Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class pegawai

    Private Sub pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventaris_barangDataSetPegawai.pegawai' table. You can move, or remove it, as needed.
        Me.PegawaiTableAdapter.Fill(Me.Inventaris_barangDataSetPegawai.pegawai)
        bukacon()

    End Sub
    Sub kosong()
        txt_ket.Text = ""
        txt_kode.Text = ""
        txt_nama.Text = ""
        txt_kode.Enabled = True
        lbl_id.Visible = False
        lbl_id_pegawai.Visible = False
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_ket.Text = "" Or txt_kode.Text = "" Or txt_nama.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
            cek = "select * from pegawai where nip='" & txt_kode.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("NIP SUDAH ADA", vbExclamation)
            Else
                con.Close()
                con.Open()
                cek1 = "select * from pegawai where nama_pegawai like'%" & txt_nama.Text & "%'"
                cmd = New SqlCommand(cek1, con)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    con.Close()
                    con.Open()
                    MsgBox("Nama Pegawai Sudah ada , Jika ingin mengubah data silahkan cari data terlebih dahulu", vbExclamation)
                Else
                    con.Close()
                    con.Open()
                    simpan = "insert into pegawai values('" & txt_nama.Text & "','" & txt_kode.Text & "','" & txt_ket.Text & "')"
                    cmd = New SqlCommand(simpan, con)
                    cmd.ExecuteNonQuery()
                    Me.PegawaiTableAdapter.Fill(Me.Inventaris_barangDataSetPegawai.pegawai)

                    MsgBox("BERHASIL DI SIMPAN", vbInformation)

                End If
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
        lbl_id_pegawai.Visible = True
        txt_kode.Enabled = False

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosong()
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        If txt_ket.Text = "" Or txt_kode.Text = "" Or txt_nama.Text = "" Or lbl_id.Text = "" Then

            MsgBox("HARUS DI ISI SEMUA,PILIHLAH SALAH SATU DATA UNTUK DI UPDATE KEMUDIAN KLIK DATA TERSEBUT")

        Else
            ubah = "update pegawai set nama_pegawai='" & txt_nama.Text & "',nip='" & txt_kode.Text & "',alamat='" & txt_ket.Text & "' where id_pegawai='" & lbl_id.Text & "'"
            cmd = New SqlCommand(ubah, con)
            cmd.ExecuteNonQuery()
            MsgBox("BERHASIL DI UBAH")
            Me.PegawaiTableAdapter.Fill(Me.Inventaris_barangDataSetPegawai.pegawai)
        End If
        con.Close()
        con.Open()

    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If lbl_id.Text = "" Then
            MsgBox("CARI DATA DAHULU,KEMUDIAN KLIK DATA")
        Else
            cek = "select * from peminjaman where id_pegawai='" & lbl_id.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                con.Close()
                con.Open()
                MsgBox("GAGAL HAPUS , DATA DENGAN NAMA '" & txt_nama.Text & "' ADA DALAM PEMINJAMAN BARANG")
            ElseIf MsgBox("Anda Ingin menghapus data", vbQuestion + vbYesNo) = vbYes Then
                con.Close()
                con.Open()
                hapus = "delete from pegawai where id_pegawai='" & lbl_id.Text & "'"
                cmd = New SqlCommand(hapus, con)
                cmd.ExecuteNonQuery()
                Me.PegawaiTableAdapter.Fill(Me.Inventaris_barangDataSetPegawai.pegawai)
                MsgBox("BERHASIL DI HAPUS")
            Else
                MsgBox("Data Tidak Di hapus")
            End If
            con.Close()
            con.Open()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New SqlDataAdapter("select * from pegawai where nama_pegawai like '%" & TextBox1.Text & "%'", con)
        ds = New DataSet
        da.Fill(ds)
        dg.DataSource = ds.Tables(0)
    End Sub

    Private Sub txt_kode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kode.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

   
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_nama_TextChanged(sender As Object, e As EventArgs) Handles txt_nama.TextChanged

    End Sub

    Private Sub txt_kode_TextChanged(sender As Object, e As EventArgs) Handles txt_kode.TextChanged

    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txt_file.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_file.Text = "" Then
            MsgBox("BROWSE DATA DAHULU")
        Else
            Dim koneksi_e As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLDB.12.0;Data source='" & txt_file.Text & "',Extended Properties=""Excel 12.0""")
            koneksi_e.Open()
            Dim s As String = "select * from [Sheet$1]"
            Dim q As New OleDbCommand(s, koneksi_e)
            Dim dr As OleDbDataReader
            bukacon()
            dr = q.ExecuteReader
            rd.Read()
            Using SqlBulkCopy = New SqlBulkCopy(s)
                SqlBulkCopy.DestinationTableName = "dbo.pegawai"
                Try
                    rd.Close()
                    q.Dispose()
                    MsgBox("Berhasil")
                Catch ex As Exception
                    MsgBox("ERRROR")
                End Try
            End Using


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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