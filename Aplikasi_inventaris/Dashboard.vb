Imports System.Data.SqlClient
Public Class Dashboard

    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        pegawai.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Close()
        Hak_akses.Hide()
        Hasil_cari.Hide()
        Inventarisir.Hide()
        MENUU.Hide()
        pegawai.Hide()
        Report_bulan.Hide()
        report_pegawai.Hide()
        Ruang.Hide()
        Stok_barang.Hide()
        LoginForm1.PasswordTextBox.Text = ""
        LoginForm1.UsernameTextBox.Text = ""
        LoginForm1.UsernameTextBox.Focus()
    End Sub

    Private Sub RuangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuangToolStripMenuItem.Click
        Ruang.Show()
    End Sub

    Private Sub InventarisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarisToolStripMenuItem.Click
        Inventarisir.Show()

    End Sub

    Private Sub HakAksesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HakAksesToolStripMenuItem.Click
        Hak_akses.Show()

    End Sub

    Private Sub AturStokBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturStokBarangToolStripMenuItem.Click
        Stok_barang.Show()
    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MENUU.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        Hasil_cari.Show()
    End Sub

    Private Sub PERBULANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERBULANToolStripMenuItem.Click
        Report_bulan.Show()
    End Sub

    Private Sub PEGAWAIToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PEGAWAIToolStripMenuItem1.Click
        report_pegawai.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = TimeOfDay
    End Sub
End Class
