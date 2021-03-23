Imports System.Data.SqlClient
Public Class Register_peminjam

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If TextBox1.Text = "" Or UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
            cek = "select * from pegawai where nama_pegawai='" & TextBox1.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = 0 Then
                con.Close()
                con.Open()
                MsgBox("NAMA TIDAK TERDETEKSI DALAM DATA, MOHON CHECK KEMBALI")
            Else
                con.Close()
                con.Open()
                simpan = "insert into petugas values('" & UsernameTextBox.Text & "','" & PasswordTextBox.Text & "','" & TextBox1.Text & "',3)"
                cmd = New SqlCommand(simpan, con)
                cmd.ExecuteNonQuery()
                MsgBox("BERHASIL REGISTER")
                Me.Hide()
                LoginForm1.Show()
            End If
        End If
    End Sub

    Private Sub Register_peminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukacon()
    End Sub
End Class