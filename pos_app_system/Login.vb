Imports System.Data.OleDb

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Koneksi()
        Cmd = New OleDbCommand("select * from Table_Pemakai where NamaPmk='" &
        TextBox1.Text & "' and PassPmk='" & TextBox2.Text & "'", CONN)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Me.Visible = False
            Splash.Show()

        Else
            MsgBox("login salah, periksan kembali user name dan password")
            TextBox1.Focus()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then TextBox2.Focus()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then Button1.Focus()
    End Sub
End Class