Imports System.Data.OleDb
Public Class D_Barang

    Sub Tampilkan()
        DA = New OleDbDataAdapter("Select KodeBrg,NamaBrg,JumlahBrg from Tabel_Barang", CONN)
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

        With DGV.Rows.Item(i)

            Penerimaan.TKode.Text = .Cells(0).Value

            Penerimaan.TNama.Text = .Cells(1).Value

            Penerimaan.TStok.Text = .Cells(2).Value
        End With

        Penerimaan.Show()
        Me.Close()
        Penerimaan.TTerima.Focus()
    End Sub

End Class