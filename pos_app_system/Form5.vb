Imports System.Data.OleDb
Public Class Penerimaan
    Sub Kosongkan()
        TKode.Text = ""
        TNama.Text = ""
        TStok.Text = ""
        TTerima.Text = ""
        TKode.Focus()

    End Sub

    Sub Tampilkan()
        DA = New OleDbDataAdapter("Select * from Table_TMPTerima", CONN)
        Ds = New DataSet
        Ds.Clear()
        DA.Fill(Ds, "Table_TMPTerima")
        DGV.DataSource = (Ds.Tables("Table_TMPTerima"))
        DGV.ReadOnly = True
        Call AturKolom()
    End Sub

    Sub AturKolom()
        DGV.Columns("Kode").Width = 50
        DGV.Columns(1).Width = 250
        DGV.Columns(2).Width = 75
        DGV.Columns(3).Width = 75
    End Sub

    Sub HapusGrid()
        DA = New OleDbDataAdapter("Delete * from Table_TMPTerima", CONN)
        Ds = New DataSet
        Ds.Clear()
        DA.Fill(Ds, "Table_TMPTerima")
        DGV.DataSource = (Ds.Tables("Table_TMPTerima"))

    End Sub

    Sub CariTotalTerima()

        On Error Resume Next
        Cmd = New OleDbCommand("select sum (Diterima) as ketemu from Table_TMPTerima", CONN)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TotalTerima.Text = RD.GetValue(0)
        Else
            TotalTerima.Text = 0
        End If
    End Sub

    Private Sub Otomatis()
        Cmd = New OleDbCommand("Select * from Table_Penerimaan_Barang where NomorTrm in (select max (NomorTrm) from Table_Penerimaan_Barang) order by NomorTrm desc", CONN)
        Dim urutan As String
        Dim hitung As Long
        RD = Cmd.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            urutan = "TR" + Format(Now, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(RD.GetString(0), 3, 6) <> Format(Now, "yyMMdd") Then
                urutan = "TR" + Format(Now, "yyMMdd") + "01"
            Else
                hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 2) + urutan = "TR" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("00" & hitung, 2)
            End If
        End If
        LBLNomor.Text = urutan
    End Sub

    Sub TampilTable_Pemasok()
        Cmd = New OleDbCommand("select * from Table_Pemasok", CONN)
        RD = Cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(0))
        Loop
    End Sub

    Private Sub Penerimaan_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Koneksi()
        Call Otomatis()
        LBLTanggal.Text = Today
    End Sub

    Private Sub Penerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call HapusGrid()
        Call Tampilkan()
        Call TampilTable_Pemasok()
    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 3 Then
            DGV.Rows(e.RowIndex).Cells(4).Value =
            DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            Call CariTotalTerima()
            Call Kosongkan()
        End If
    End Sub

    Private Sub DGV_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGV.CellValidating
        If e.ColumnIndex = 0 Then
            Cmd = New OleDbCommand("Select * from Tabel_Barang where KodeBrg='" & e.FormattedValue.ToString & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                DGV.Rows(e.RowIndex).Cells(0).Value = RD.GetString(0)
                DGV.Rows(e.RowIndex).Cells(1).Value = RD.GetString(1)
                DGV.Rows(e.RowIndex).Cells(2).Value = RD.GetValue(2)
                Exit Sub
            Else
                Beep()
            End If
        End If

        If e.ColumnIndex = 3 Then
            DGV.Rows(e.RowIndex).Cells(4).Value =
            DGV.Rows(e.RowIndex).Cells(2).Value * e.FormattedValue.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or NomorReff.Text = "" Or TxtBoxTotalTerima.Text = "" Then
            MsgBox("Data belum lengkap")

            Exit Sub
        End If

        Try
            ' Simpan ke tabel Penerimaan
            Dim Simpan As String
            Simpan = "INSERT INTO Table_Penerimaan_Barang (NomorTrm, TanggalTrm, KodePms, NomorBon, TotalTrm, KodePmk) VALUES " &
            "('" & LBLNomor.Text & "','" & LBLTanggal.Text & "','" & ComboBox1.Text & "','" & NomorReff.Text & "','" & TxtBoxTotalTerima.Text & "','" & MenuUtama.Panel1.Text & "')"
            Cmd = New OleDbCommand(Simpan, CONN)
            Cmd.ExecuteNonQuery()

            ' Baca tabel Table_TMPTerima
            DA = New OleDbDataAdapter("SELECT * FROM Table_TMPTerima", CONN)
            Ds = New DataSet
            DA.Fill(Ds)
            DGV.DataSource = Ds.Tables(0)

            ' Simpan detail terima
            For Each row As DataGridViewRow In DGV.Rows
                Dim sglsimpan As String = "INSERT INTO Table_Detail_Terima (NomorTrm, KodeBrg, StokAwal, QtyTrm, StokAkhir) VALUES " &
                "('" & LBLNomor.Text & "','" & row.Cells(0).Value.ToString() & "','" & row.Cells(2).Value.ToString() & "','" & row.Cells(3).Value.ToString() & "','" & row.Cells(2).Value.ToString() + row.Cells(3).Value.ToString() & "')"
                Cmd = New OleDbCommand(sglsimpan, CONN)
                Cmd.ExecuteNonQuery()

                ' Tambah stok barang
                Cmd = New OleDbCommand("SELECT * FROM Tabel_Barang WHERE KodeBrg='" & row.Cells(0).Value.ToString() & "'", CONN)
                RD = Cmd.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    Dim TambahStok As String = "UPDATE Tabel_Barang SET JumlahBrg='" & Convert.ToInt32(RD.GetValue(3)) + Convert.ToInt32(row.Cells(3).Value.ToString()) & "' WHERE KodeBrg='" & row.Cells(0).Value.ToString() & "'"
                    Cmd = New OleDbCommand(TambahStok, CONN)
                    Cmd.ExecuteNonQuery()
                End If
            Next

            Call HapusGrid()
            Call Tampilkan()
            Call Kosongkan()
            Call Otomatis()
            Call HapusMaster()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub TKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TKode.KeyPress
        If e.KeyChar = Chr(13) Then
            If TKode.Text = "" Then
                MsgBox("Kode barang masih kosong")
            Else
                ' Check in Table_TMPTerima
                Cmd = New OleDbCommand("SELECT * FROM Table_TMPTerima WHERE Kode='" & TKode.Text & "'", CONN)
                RD = Cmd.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    TNama.Text = RD.GetString(1)
                    TStok.Text = RD.GetValue(2)
                    MsgBox("Kode barang sudah ada dalam transaksi, edit saja jumlahnya")
                    TStok.Focus()
                    Exit Sub
                Else
                    ' Check in Tabel_Barang
                    Cmd = New OleDbCommand("SELECT * FROM Tabel_Barang WHERE KodeBrg='" & TKode.Text & "'", CONN)
                    RD = Cmd.ExecuteReader
                    RD.Read()
                    If RD.HasRows Then
                        TNama.Text = RD.GetString(1)
                        TStok.Text = RD.GetValue(3)
                        TTerima.Focus()
                    Else
                        MsgBox("Kode tidak terdaftar")
                        TKode.Text = ""
                        TKode.Focus()
                    End If
                End If
            End If
        End If

        If e.KeyChar = Chr(27) Then
            Cmd = New OleDbCommand("SELECT * FROM Table_TMPTerima WHERE Kode='" & TKode.Text & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Dim sqlhapus As String = "DELETE FROM Table_TMPTerima WHERE Kode='" & TKode.Text & "'"
                Cmd = New OleDbCommand(sqlhapus, CONN)
                Cmd.ExecuteNonQuery()
                Call Tampilkan()
                Call CariTotalTerima()
                If DGV.Rows.Count - 1 = 0 Then
                    Call HapusMaster()
                End If
                TKode.Text = ""
            Else
                MsgBox("Kode tidak ada dalam transaksi. Focus ()")
            End If
        End If
        'If e.KeyChar = Chr (9) Then TDibayar.Focus (
    End Sub

    Private Sub TTerima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTerima.KeyPress
        If e.KeyChar = Chr(13) Then
            Cmd = New OleDbCommand("SELECT * FROM Table_TMPTerima WHERE Kode='" & TKode.Text & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Dim editjumlah As String = "UPDATE Table_TMPTerima SET Diterima='" & TTerima.Text & "' WHERE Kode='" & TKode.Text & "'"
                Cmd = New OleDbCommand(editjumlah, CONN)
                Cmd.ExecuteNonQuery()
                Call Tampilkan()
                Call CariTotalTerima()
                Call Kosongkan()
            Else
                Dim sglsimpan As String = "INSERT INTO Table_TMPTerima (Kode, Nama, StokAwal, Diterima) VALUES ('" & TKode.Text & "','" & TNama.Text & "','" & TStok.Text & "','" & TTerima.Text & "')"
                Cmd = New OleDbCommand(sglsimpan, CONN)
                Cmd.ExecuteNonQuery()
                Call Tampilkan()
                Call CariTotalTerima()
                Call Kosongkan()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Sub HapusMaster()
        ComboBox1.Text = ""
        LBLPerson.Text = ""
        LBLNama.Text = ""
        NomorReff.Text = ""
        TotalTerima.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Kosongkan()
        Call HapusGrid()
        Call HapusMaster()
        Call Tampilkan()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If ComboBox1.Text = "" Then
                MsgBox("Kode Table_Pemasok masih kosong")
            Else
                NomorReff.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Cmd = New OleDbCommand("select * from Table_Pemasok where KodePms='" & ComboBox1.Text & "'", CONN)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LBLPerson.Text = RD.Item(5)
            LBLNama.Text = RD.Item(2)
        Else
            MsgBox("Kode Table_Pemasok tidak terdaftar")
        End If
    End Sub

    Private Sub NomorReff_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NomorReff.KeyPress
        If e.KeyChar = Chr(13) Then TKode.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        D_Barang.ShowDialog()
    End Sub
End Class