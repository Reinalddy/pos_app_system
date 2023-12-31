Imports System.Data.OleDb
Public Class D_Barang

    Sub Tampilkan()
        DA = New OleDbDataAdapter("Select KodeBrg,NamaBrg, Harga from Tabel_Barang", CONN)
        Ds = New DataSet
        Ds.Clear()
        DA.Fill(Ds, "Tabel_Barang")
        DGV.DataSource = (Ds.Tables("Tabel_Barang"))
        DGV.ReadOnly = True

    End Sub

    Private Sub D_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick

        Dim i As Integer
        i = Me.DGV.CurrentRow.Index

        ' Mendapatkan nilai dari sel-sel di baris saat ini
        Dim newRow As New List(Of Object)()

        With Me.DGV.Rows.Item(i)
            ' Menyalin nilai dari sel-sel di baris saat ini ke newRow
            For Each cell As DataGridViewCell In .Cells
                newRow.Add(cell.Value)
                Transaksi.Item.Text = .Cells(1).Value
            Next

        End With

        ' Mengakses form Transaksi
        Dim transaksiForm As New Transaksi()

        ' Menambahkan kolom ke DataGridView di form Transaksi jika belum ada
        If Transaksi.DGV.Columns.Count = 0 Then
            For Each col As DataGridViewColumn In Me.DGV.Columns
                Transaksi.DGV.Columns.Add(col.Clone())
            Next
        End If

        ' Menambahkan baris baru ke DataGridView di form Transaksi
        Transaksi.DGV.Rows.Add(newRow.ToArray())


        'Transaksi.Close()
        Transaksi.Show()
        Me.Close()
        Penerimaan.TTerima.Focus()
    End Sub

End Class