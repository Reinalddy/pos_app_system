Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Pemasok

    Private Sub Pemasok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
    End Sub
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Focus()

    End Sub

    Sub DataBaru()

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox6.Focus()

    End Sub

    Sub Tampilkan()
        DA = New OleDbDataAdapter("Select * from Table_Pemasok", CONN)
        Ds = New DataSet
        Ds.Clear()
        DA.Fill(Ds, "Table_Pemasok")
        DGV.DataSource = (Ds.Tables("Table_Pemasok"))
        DGV.ReadOnly = True

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 3
        If e.KeyChar = Chr(13) Then
            Try
                Cmd = New OleDbCommand("select * from Table_Pemasok where KodePms='" & TextBox1.Text & "'", CONN)
                RD = Cmd.ExecuteReader
                RD.Read()

                If RD.HasRows = True Then
                    TextBox2.Text = RD.GetString(1)
                    TextBox3.Text = RD.GetString(2)
                    TextBox4.Text = RD.GetString(3)
                    TextBox5.Text = RD.GetString(4)
                    TextBox6.Text = RD.GetString(5)
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
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then TextBox6.Focus()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then Button1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Cmd = New OleDbCommand("Select * from Table_Pemasok where KodePms='" & TextBox1.Text & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                Dim sqltambah As String = "Insert into Table_Pemasok (KodePms, NamaPms, AlamatPms, TeleponPms, PersonPms,EmailPms) values " &
            "('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
                Cmd = New OleDbCommand(sqltambah, CONN)
                Cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()

            Else

                Dim sqledit As String = "Update Table_Pemasok set " &
                "NamaPms='" & TextBox2.Text & "', " &
                "AlamatPms='" & TextBox3.Text & "', " &
                "TeleponPms='" & TextBox4.Text & "', " &
                "PersonPms='" & TextBox5.Text & "', " &
                "EmailPms='" & TextBox6.Text & "' " &
                "Where KodePms='" & TextBox1.Text & "'"

                Cmd = New OleDbCommand(sqledit, CONN)
                Cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("isi kode Pemasok dulu cess")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan di hapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Cmd = New OleDbCommand("Delete * From Table_Pemasok Where KodePms ='" & TextBox1.Text & "'", CONN)
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