Imports System.Data.SqlClient
Public Class report_pegawai
    Sub tampil()
        bukacon()
        da = New SqlDataAdapter("select peminjaman.id_peminjaman ,inventaris.nama_barang,detail_pinjam.jumlah,peminjaman.tgl_pinjam,pegawai.nama_pegawai,peminjaman.status_peminjaman,peminjaman.bulan,peminjaman.tgl_kembali   from peminjaman inner join detail_pinjam on detail_pinjam.id_detail_pinjam = peminjaman.id_peminjaman inner join inventaris on inventaris.id_inventaris = detail_pinjam.id_inventaris inner join pegawai on pegawai.id_pegawai = peminjaman.id_pegawai  ", con)
        dt = New DataTable
        da.Fill(dt)
        dg.DataSource = dt
    End Sub

    Private Sub report_pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            MsgBox(" exported successfully to Excel")
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New SqlDataAdapter("select peminjaman.id_peminjaman ,inventaris.nama_barang,detail_pinjam.jumlah,peminjaman.tgl_pinjam,pegawai.nama_pegawai,peminjaman.status_peminjaman,peminjaman.bulan,peminjaman.tgl_kembali   from peminjaman inner join detail_pinjam on detail_pinjam.id_detail_pinjam = peminjaman.id_peminjaman inner join inventaris on inventaris.id_inventaris = detail_pinjam.id_inventaris inner join pegawai on pegawai.id_pegawai = peminjaman.id_pegawai where nama_pegawai like '%" & TextBox1.Text & "%' ", con)
        ds = New DataSet
        da.Fill(ds)
        dg.DataSource = ds.Tables(0)
    End Sub
End Class