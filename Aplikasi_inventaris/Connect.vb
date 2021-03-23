Imports System.Data.SqlClient

Module Connect
    Public rd As SqlDataReader
    Public da As SqlDataAdapter
    Public dt As DataTable
    Public ds As DataSet
    Public cmd As SqlCommand
    Public i As Integer
    Public cek, ubah, simpan, hapus, cari, cek1 As String
    Public con As New SqlConnection
    Public str As String = "server=RPL31-PC;database=inventaris_barang;Integrated security=true"
    Public Sub bukacon()
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = str
            Try
                con.Open()

            Catch ex As Exception
                MsgBox("KONEKSI GAGAL")
            End Try
        End If
    End Sub
    Public Sub tutupcon()
        If con.State = ConnectionState.Open Then
            con.ConnectionString = str
            Try
                con.Close()

            Catch ex As Exception
                MsgBox("KONEKSI BUKA")
            End Try
        End If
    End Sub
End Module
