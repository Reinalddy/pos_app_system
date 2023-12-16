Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class RincianStok

    Sub AturKolom()
        DGV.Columns(0).Width = 60
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 60
        DGV.Columns(3).Width = 60
        DGV.Columns(4).Width = 60
    End Sub

    Sub HitungTotal()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            subtot += Val(DGV.Rows(I).Cells(3).Value)
            TotalBarang.Text = subtot
        Next
    End Sub

    Private Sub RincianStok_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TextBox1Tanggal.Text = Today
    End Sub

    Private Sub RincianStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DA = New OleDbDataAdapter("SELECT * FROM Tabel_Barang WHERE JumlahBrg <= Stokminimal", CONN)
        Ds = New DataSet
        Ds.Clear()
        DA.Fill(Ds, "Tabel_Barang")
        DGV.DataSource = Ds.Tables("Tabel_Barang")
        Call AturKolom()
        Call HitungTotal()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TotalBarang.Text = "" Then
            MsgBox("Klik dulu tombol Cek stok Minimum")

        Else
            DGV.DataSource = Ds.Tables("Tabel_Barang")
            TotalBarang.Text = ""

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class