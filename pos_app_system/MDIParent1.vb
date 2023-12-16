Imports System.Windows.Forms

Public Class MenuUtama

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Barang.ShowDialog()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Pelanggan.ShowDialog()
    End Sub

    Private Sub PemasokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemasokToolStripMenuItem.Click
        Pemasok.ShowDialog()
    End Sub

    Private Sub PemakaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemakaiToolStripMenuItem.Click
        Pemakai.ShowDialog()
    End Sub

    Private Sub PenerimaanBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanBarangToolStripMenuItem.Click
        Penerimaan.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Transaksi.ShowDialog()
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub RincianStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RincianStokToolStripMenuItem.Click
        RincianStok.ShowDialog()
    End Sub

    Private Sub RincianPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RincianPenjualanToolStripMenuItem.Click
        RincianTransaksi.ShowDialog()
    End Sub
End Class
