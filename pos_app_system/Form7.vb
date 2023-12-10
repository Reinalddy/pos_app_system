Imports System.Data.OleDb
Public Class Transaksi
    Sub BersihkanText()
        Total.Text = ""
        Dibayar.Text = ""
        Kembali.Text = ""
        Item.Text = ""
    End Sub

    Sub BuatKolomBaru()

        DGV.Columns.Add("Kode", "Kode")
        DGV.Columns.Add("Nama", "Nama Barang")
        DGV.Columns.Add("Harga", "Harga")
        DGV.Columns.Add("Jumlah", "Jumlah")
        DGV.Columns.Add("Total", "SubTotal")
        Call AturLebarKolom()
    End Sub

    Sub AturLebarKolom()
        DGV.Columns(0).Width = 50
        DGV.Columns(1).Width = 175
        DGV.Columns(2).Width = 75
        DGV.Columns(3).Width = 75
        DGV.Columns(4).Width = 100
    End Sub

    Sub FakturOtomatis()
        Cmd = New OleDbCommand("Select * from penjualan where faktur in (select max (faktur) from penjualan) order by faktur desc", CONN)
        Dim urutan As String
        Dim hitung As Long
        RD = Cmd.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            urutan = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(RD.GetString(0), 6) <>
            Format(Now, "yyMMdd") Then
                urutan = Format(Now, "yyMMdd") + "0001"
            Else
                hitung = RD.GetString(0) + 1
                urutan = Format(Now, "yyMMdd") +
                Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
        End If
        Faktur.Text = urutan
    End Sub

    Private Sub Transaksi_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Call FakturOtomatis()
        Tanggal.Text = Today
    End Sub
    Sub TampilPelanggan()
        Cmd = New OleDbCommand("select * from Pelanggan", CONN)
        RD = Cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read

            ComboBox1.Items.Add(RD.Item(0))
        Loop
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call BuatKolomBaru()
        Call TampilPelanggan()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Jam.Text = TimeOfDay
    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 0 Then
            Cmd = New OleDbCommand("select * from barang where KodeBrg='" &
            DGV.Rows(e.RowIndex).Cells(0).Value & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                DGV.Rows(e.RowIndex).Cells(1).Value = RD.Item(1)
                DGV.Rows(e.RowIndex).Cells(2).Value = RD.Item(5)
                DGV.Rows(e.RowIndex).Cells(3).Value = 1
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value

                Call TotalItem()
                Call TotalHarga()

            Else
                MsgBox("Kode barang tidak terdaftar")
            End If
        End If

        If e.ColumnIndex = 3 Then

            Cmd = New OleDbCommand("select * from barang where KodeBrg='" &
            DGV.Rows(e.RowIndex).Cells(0).Value & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                If DGV.Rows(e.RowIndex).Cells(3).Value > RD.Item(4) Then
                    MsgBox("Stok barang hanya ada " & RD.Item(4) & "")
                    DGV.Rows(e.RowIndex).Cells(3).Value = 1
                    DGV.Rows(e.RowIndex).Cells(4).Value =
                    DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                Else
                    DGV.Rows(e.RowIndex).Cells(4).Value =
                    DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                End If
            End If
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If
    End Sub

    Sub kena(ByVal myGrid As DataGrid)
        myGrid.CurrentCell = New DataGridCell(1, 1)
    End Sub

    Sub TotalItem()
        Dim HitungItem As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungItem = HitungItem + Val(DGV.Rows(I).Cells(3).Value)
            Item.Text = HitungItem
        Next

    End Sub

    Sub TotalHarga()
        Dim HitungHarga As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungHarga = HitungHarga + Val(DGV.Rows(I).Cells(4).Value)
            Total.Text = HitungHarga
        Next

    End Sub

    Sub HapusBaris()
        On Error Resume Next
        Dim baris As Integer = DGV.CurrentCell.RowIndex
        DGV.Rows(baris).Cells(0).Value = ""
        Chr(30)
    End Sub

    Private Sub DGV_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV.KeyDown
        If e.KeyCode = Keys.Up Then
            DGV.CurrentCell = DGV.Rows(0).Cells(3)
        End If
    End Sub

    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next

        If e.KeyChar = Chr(27) Then
            DGV.Rows.RemoveAt(DGV.CurrentCell.RowIndex)
            Call TotalItem()
            Call TotalHarga()
            Dibayar.Clear()
            Kembali.Text = ""

        End If

    End Sub

    Private Sub Dibayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Dibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(Dibayar.Text) < Val(Total.Text) Then
                MsgBox("Pembayaran kurang")
                Kembali.Text = ""
                Dibayar.Focus()
                Exit Sub
            ElseIf Val(Dibayar.Text) = Val(Total.Text) Then
                Kembali.Text = 0
                BTNSimpan.Focus()
            Else
                Kembali.Text = Val(Dibayar.Text) - Val(Total.Text)
                BTNSimpan.Focus()
            End If
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        If Total.Text = "" Or Dibayar.Text = "" Or Kembali.Text = "" Or
            Item.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau pembayaran
            masih kosong")
            Exit Sub
        End If
        'simpan ke tabel penjualan
        Dim simpanmaster As String = "Insert into penjualan (faktur, tanggal, item, total, dibayar, kembali, KodePmk, KodePlg) values " &
        "('" & Faktur.Text & "','" & Tanggal.Text & "','" & Item.Text &
        "','" & Total.Text & "','" & Dibayar.Text & "','" & Kembali.Text & "','" &
        Menuutama.Panel1.Text & "','" & ComboBox1.Text & "')"

        Cmd = New OleDbCommand(simpanmaster, CONN)
        Cmd.ExecuteNonQuery()

        For baris As Integer = 0 To DGV.Rows.Count - 2

            'simpan ke tabel detail

            Dim sglsimpan As String = "Insert into detailjual (faktur,KodeBrg, nama Barang,harga Jual,jumlah, subtotal) values " &
                "('" & Faktur.Text & "','" & DGV.Rows(baris).Cells(0).Value &
                "','" & DGV.Rows(baris).Cells(3).Value & "','" & DGV.Rows(baris).Cells(3).Value &
                "','" & DGV.Rows(baris).Cells(4).Value & "')"

            CMD = New OleDbCommand(sglsimpan, CONN)

            CMD.ExecuteNonQuery()

            'kurangi stok barang

            CMD = New OleDbCommand("select * from barang where KodeBrg='" &
            DGV.Rows(baris).Cells(0).Value & "'", CONN)

            RD = CMD.ExecuteReader

            RD.Read()

            If RD.HasRows Then
                Dim kurangistok As String = "update barang set JumlahBrg= '" &
                    RD.Item(3) - DGV.Rows(baris).Cells(3).Value & "' where KodeBrg='" &
                    DGV.Rows(baris).Cells(0).Value & "'"
                Cmd = New OleDbCommand(kurangistok, CONN)
                Cmd.ExecuteNonQuery()
            End If

        Next baris
        DGV.Columns.Clear()
        Call BuatKolomBaru()
        Call FakturOtomatis()
        Call BersihkanText()
    End Sub

    Private Sub BTNBatal_Click(sender As Object, e As EventArgs) Handles BTNBatal.Click
        Call BersihkanText()
        DGV.Columns.Clear()
        Call BuatKolomBaru()
        DGV.Focus()
    End Sub

    Private Sub BTNTutup_Click(sender As Object, e As EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        D_Barang.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        D_Pelanggan.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Cmd = New OleDbCommand("select * from Pelanggan where KodePlg='" &
                               ComboBox1.Text & "'", CONN)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextBox1.Text = RD.Item(1)
            TextBox2.Text = RD.Item(2)
            TextBox3.Text = RD.Item(3)
            TextBox4.Text = RD.Item(4)
            TextBox5.Text = RD.Item(5)
        Else
            MsgBox("Kode Pelanggan tidak terdaftar")
        End If
    End Sub
End Class