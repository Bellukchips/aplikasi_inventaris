Imports System.Data.SqlClient
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("HARUS DI ISI SEMUA")
        Else
            bukacon()

            cek = "select * from petugas where username='" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "'"
            cmd = New SqlCommand(cek, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd.Item("id_level") = "1" Then
                    Dashboard.Show()
                    Me.Hide()
                    Inventarisir.txt_id_p.Text = rd.Item("id_petugas")

                ElseIf rd.Item("id_level") = "2" Then

                    Dashboard.MasterToolStripMenuItem.Visible = False
                    Dashboard.ReportToolStripMenuItem.Visible = False
                    Dashboard.Show()
                    Me.Hide()

                ElseIf rd.Item("id_level") = "3" Then
                    Dashboard.MasterToolStripMenuItem.Visible = False
                    Dashboard.ReportToolStripMenuItem.Visible = False
                    Dashboard.PengembalianToolStripMenuItem.Visible = False
                    Dashboard.Show()
                    Me.Hide()

                End If
            Else
                MsgBox("CHECK USERNAME & PASSWORD", vbExclamation, "CHECK")
            End If
            con.Close()
            con.Open()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukacon()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register_peminjam.Show()
        Me.Hide()

    End Sub
End Class
