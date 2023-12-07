﻿Imports System.Data.OleDb

Public Class Pemakai
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox1.Focus()

    End Sub

    Sub DataBaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox2.Focus()
    End Sub

    Sub Tampilkan()
        DA = New OleDbDataAdapter("Select * from Pemakai ORDER BY 1", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(Ds, "Pemakai")
        DGV.DataSource = (Ds.Tables("Pemakai"))
        DGV.ReadOnly = True
    End Sub

    Private Sub Pemakai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
        ComboBox1.Items.Add("ADMINISTRATOR")
        ComboBox1.Items.Add("OPERATOR")
        ComboBox1.Items.Add("KASIR")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 5
        If e.KeyChar = Chr(13) Then
            Cmd = New OleDbCommand("select * from Pemakai where kodePMK='" & TextBox1.Text & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                TextBox2.Text = RD.GetString(1)
                TextBox3.Text = RD.GetString(2)
                ComboBox1.Text = RD.GetString(3)
                TextBox2.Focus()
            Else
                Call DataBaru()
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then ComboBox1.Focus()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then Button1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Cmd = New OleDbCommand("Select * from Pemakal where kodePMK='" & TextBox1.Text & "'", CONN)
            RD = Cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                Dim sgltambah As String = "Insert into Pemakai (kodePMK, namaPMK, PassPMK, StatusPMK) values " & "('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
                Cmd = New OleDbCommand(sgltambah, CONN)
                Cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()

            Else
                Dim sgledit As String = "Update Pemakal set " & "NamaPMK='" & TextBox2.Text & "', " & "PassPMK='" & TextBox3.Text & "', " & "StatusPMK='" & ComboBox1.Text & "' where kodePMK='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(sgledit, CONN)
                Cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi kode Pemakai terlebih dahulu")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Cmd = New OleDbCommand("Delete * from Pemakai where kodePMK='" & TextBox1.Text & "'", CONN)
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