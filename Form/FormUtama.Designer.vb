<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataKategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataKasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatakDataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatTransaksiPerBulanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakDataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakDataKasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.KategoriToolStripMenuItem, Me.PenjualanToolStripMenuItem, Me.KasirToolStripMenuItem, Me.CetakToolStripMenuItem, Me.CetakToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KategoriToolStripMenuItem
        '
        Me.KategoriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataKategoriToolStripMenuItem})
        Me.KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem"
        Me.KategoriToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.KategoriToolStripMenuItem.Text = "Kategori"
        '
        'OlahDataKategoriToolStripMenuItem
        '
        Me.OlahDataKategoriToolStripMenuItem.Name = "OlahDataKategoriToolStripMenuItem"
        Me.OlahDataKategoriToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OlahDataKategoriToolStripMenuItem.Text = "Olah Data Kategori"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiBaruToolStripMenuItem})
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PenjualanToolStripMenuItem.Text = "Barang"
        '
        'TransaksiBaruToolStripMenuItem
        '
        Me.TransaksiBaruToolStripMenuItem.Name = "TransaksiBaruToolStripMenuItem"
        Me.TransaksiBaruToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TransaksiBaruToolStripMenuItem.Text = "Olah Data Barang"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataKasirToolStripMenuItem, Me.LihatTransaksiPerBulanToolStripMenuItem})
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.KasirToolStripMenuItem.Text = "Penjualan"
        '
        'OlahDataKasirToolStripMenuItem
        '
        Me.OlahDataKasirToolStripMenuItem.Name = "OlahDataKasirToolStripMenuItem"
        Me.OlahDataKasirToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OlahDataKasirToolStripMenuItem.Text = "Transaksi Baru"
        '
        'CetakToolStripMenuItem
        '
        Me.CetakToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatakDataMenuToolStripMenuItem})
        Me.CetakToolStripMenuItem.Name = "CetakToolStripMenuItem"
        Me.CetakToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.CetakToolStripMenuItem.Text = "Kasir"
        '
        'CatakDataMenuToolStripMenuItem
        '
        Me.CatakDataMenuToolStripMenuItem.Name = "CatakDataMenuToolStripMenuItem"
        Me.CatakDataMenuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CatakDataMenuToolStripMenuItem.Text = "Olah Data Kasir"
        '
        'LihatTransaksiPerBulanToolStripMenuItem
        '
        Me.LihatTransaksiPerBulanToolStripMenuItem.Name = "LihatTransaksiPerBulanToolStripMenuItem"
        Me.LihatTransaksiPerBulanToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.LihatTransaksiPerBulanToolStripMenuItem.Text = "Lihat Transaksi perBulan"
        '
        'CetakToolStripMenuItem1
        '
        Me.CetakToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CetakDataMenuToolStripMenuItem, Me.CetakDataKasirToolStripMenuItem})
        Me.CetakToolStripMenuItem1.Name = "CetakToolStripMenuItem1"
        Me.CetakToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.CetakToolStripMenuItem1.Text = "Cetak"
        '
        'CetakDataMenuToolStripMenuItem
        '
        Me.CetakDataMenuToolStripMenuItem.Name = "CetakDataMenuToolStripMenuItem"
        Me.CetakDataMenuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CetakDataMenuToolStripMenuItem.Text = "Cetak Data Menu"
        '
        'CetakDataKasirToolStripMenuItem
        '
        Me.CetakDataKasirToolStripMenuItem.Name = "CetakDataKasirToolStripMenuItem"
        Me.CetakDataKasirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CetakDataKasirToolStripMenuItem.Text = "Cetak Data Kasir"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataKategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiBaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataKasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatakDataMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatTransaksiPerBulanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CetakDataMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakDataKasirToolStripMenuItem As ToolStripMenuItem
End Class
