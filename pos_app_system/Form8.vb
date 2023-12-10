Imports System.Data.OleDb

Public Class D_Pelanggan

    Sub Tampilkan()
        DA = New OleDbDataAdapter("Select * from Pelanggan", CONN)
        Ds = New DataSet
        Ds.Clear()
        DA.Fill(Ds, "Pelanggan")
        DGV.DataSource = (Ds.Tables("Pelanggan"))
        DGV.ReadOnly = True
    End Sub

    Private Sub D_Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim i As Integer
        i = Me.DGV.CurrentRow.Index
        With DGV.Rows.Item(i)

            Transaksi.ComboBox1.Text = .Cells(0).Value
            Transaksi.TextBox1.Text = .Cells(1).Value
            Transaksi.TextBox2.Text = .Cells(2).Value
            Transaksi.TextBox3.Text = .Cells(3).Value

            Transaksi.TextBox4.Text = .Cells(4).Value
            Transaksi.TextBox5.Text = .Cells(5).Value
        End With
        Transaksi.Show()
        Me.Close()
    End Sub
End Class