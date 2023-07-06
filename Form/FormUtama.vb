Public Class FormUtama
    Private Sub OlahDataKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataKategoriToolStripMenuItem.Click
        FormKategori.Show()
        FormKasir.Close()
        FormMenu.Close()
        FormPenjualan.Close()
    End Sub

    Private Sub TransaksiBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiBaruToolStripMenuItem.Click
        FormMenu.Show()
        FormKategori.Close()
        FormKasir.Close()
        FormPenjualan.Close()
    End Sub

    Private Sub CatakDataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatakDataMenuToolStripMenuItem.Click
        FormKasir.Show()
        FormKategori.Close()
        FormMenu.Close()
        FormPenjualan.Close()
    End Sub

    Private Sub OlahDataKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataKasirToolStripMenuItem.Click
        FormPenjualan.Show()
        FormKategori.Close()
        FormMenu.Close()
        FormKasir.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim tanya
        tanya = MessageBox.Show("Anda yakin ingin keluar ?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            FormLogin.Show()
            Me.Close()
        End If
    End Sub
End Class