Imports System.Data.OleDb
Public Class Pelanggan
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        TextBox1.Focus()

    End Sub

    Sub DataBaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Focus()
    End Sub

    Sub Tampilkan()
        DA = New OleDbDataAdapter("Select * from Table_Pelanggan", CONN)
        Ds = New DataSet
        Ds.Clear()
        DA.Fill(Ds, "Table_Pelanggan")
        DGV.DataSource = (Ds.Tables("Table_Pelanggan"))
        DGV.ReadOnly = True
    End Sub

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()

        Call Tampilkan()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 3
        If e.KeyChar = Chr(13) Then
            Try
                Cmd = New OleDbCommand("select * from Table_Pelanggan where KodePlg='" & TextBox1.Text & "'", CONN)

                RD = Cmd.ExecuteReader

                RD.Read()

                If RD.HasRows = True Then
                    TextBox2.Text = RD.GetString(1)
                    TextBox3.Text = RD.GetValue(2)
                    TextBox4.Text = RD.GetValue(3)
                    TextBox5.Text = RD.GetValue(4)
                    ComboBox1.Text = RD.GetString(5)
                    TextBox2.Focus()

                Else
                    Call DataBaru()
                    TextBox2.Focus()

                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then TextBox4.Focus()
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then TextBox5.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then ComboBox1.Focus()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then Button1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Cmd = New OleDbCommand("Select * from Table_Pelanggan where KodePlg='" & TextBox1.Text & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                Dim sqltambah As String = "INSERT INTO Table_Pelanggan (KodePlg, NamaPlg, AlamatPlg, TeleponPLg, EmailPlg, JK) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "')"
                Cmd = New OleDbCommand(sqltambah, CONN)
                Cmd.ExecuteNonQuery()

                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim sqledit As String = "UPDATE Table_Pelanggan SET NamaPlg='" & TextBox2.Text & "', AlamatPlg='" & TextBox3.Text & "', TeleponPLg='" & TextBox4.Text & "', EmailPlg='" & TextBox5.Text & "', JK='" & ComboBox1.Text & "' WHERE KodePlg='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(sqledit, CONN)
                Cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi kode Pelanggan terlebih dahulu")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Cmd = New OleDbCommand("Delete * from Table_Pelanggan where KodePlg ='" & TextBox1.Text & "'", CONN)
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