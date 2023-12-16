Public NotInheritable Class Splash

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MenuUtama.Show()
            MenuUtama.Panel1.Text = RD.GetString(0)
            MenuUtama.Panel2.Text = RD.GetString(1)
            MenuUtama.Panel3.Text = RD.GetString(3)
            If MenuUtama.Panel3.Text <> "ADMIN" Then
                MenuUtama.StatusStrip1.Enabled = False
            Else
                MenuUtama.StatusStrip1.Enabled = True
            End If
            Me.Close()
        Else
            ProgressBar1.Value += 5
            Label1.Text = ProgressBar1.Value & "%"
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
