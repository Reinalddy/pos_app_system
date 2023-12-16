Imports System.Data.OleDb
Public Class RincianTransaksi

    Sub TampilFaktur()
        Cmd = New OleDbCommand("SELECT * FROM Table_Penjualan", CONN)
        RD = Cmd.ExecuteReader
        Do While RD.Read
            ComboBox1.Items.Add(RD.GetString(0))
        Loop
    End Sub

    Sub TampilData()
        DA = New OleDbDataAdapter("SELECT Nama_Barang,Harga_Jual,Jumlah,Subtotal FROM Table_DetailJual WHERE Faktur='" & ComboBox1.Text & "'", CONN)
        Ds = New DataSet
        DA.Fill(Ds, "Table_DetailJual")
        DGV.DataSource = Ds.Tables("Table_DetailJual")
        DGV.ReadOnly = True
        Cmd = New OleDbCommand("SELECT Tanggal, Item, Total, Dibayar, Kembali, NamaPmk FROM Table_Penjualan INNER JOIN Table_Pemakai ON Table_Penjualan.KodePmk=Table_Pemakai.KodePmk WHERE Faktur='" & ComboBox1.Text & "'", CONN)
        RD = Cmd.ExecuteReader
        RD.Read()
    End Sub

    Private Sub RincianTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilFaktur()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call TampilData()
    End Sub
End Class