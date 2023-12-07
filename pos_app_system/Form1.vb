Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Barang
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        TextBox1.Focus()

    End Sub

    Sub DataBaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Focus()

    End Sub

    Sub Tampilkan()
        DA = New OleDbDataAdapter("Select * from barang", CONN)
        Ds = New DataSet
        Ds.Clear()
        DA.Fill(Ds, "Barang")
        DGV.DataSource = (Ds.Tables("Barang"))
        DGV.ReadOnly = True
    End Sub

    Sub TampilSatuan()

        ComboBox1.Items.Clear()

        Cmd = New OleDbCommand("select distinct satuan from Barang", CONN)

        RD = Cmd.ExecuteReader
        While RD.Read
            ComboBox1.Items.Add(RD.GetString(0))
        End While
    End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Koneksi()

        Call Tampilkan()

        Call TampilSatuan()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Cmd = New OleDbCommand("select * from barang where KodeBrg='" & TextBox1.Text & "'", CONN)
                RD = Cmd.ExecuteReader
                RD.Read()
                If RD.HasRows = True Then
                    TextBox2.Text = RD.GetString(1)
                    ComboBox1.Text = RD.GetString(2)
                    TextBox3.Text = RD.GetValue(3)
                    TextBox4.Text = RD.GetValue(4)
                    TextBox2.Focus()
                Else
                    Call DataBaru()
                    TextBox2.Focus()
                End If
            Catch ex As Exception

            End Try
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If e.KeyChar = Chr(13) Then ComboBox1.Focus()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then Button1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Cmd = New OleDbCommand("Select * from barang where KodeBrg='" & TextBox1.Text & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                Dim sgltambah As String = "Insert into barang (KodeBrg, NamaBrg, Satuan, JumlahBrg, Harga) values " & "('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                Cmd = New OleDbCommand(sgltambah, CONN)
                Cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim sgledit As String = "Update barang Set " & "NamaBrg='" & TextBox2.Text & "', " & "Satuan='" & ComboBox1.Text & "', " & "JumlahBrg='" & TextBox3.Text & "' " & "Harga='" & TextBox4.Text & "' " & "where KodeBrg='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(sgledit, CONN)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi kode barang terlebih dahulu")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "'",
            MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Cmd = New OleDbCommand("Delete * from barang where KodeBrg='" & TextBox1.Text & "'", CONN)
                Cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Kosongkan()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
