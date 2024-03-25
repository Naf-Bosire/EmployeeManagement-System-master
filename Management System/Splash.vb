Public Class Splash

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        percentage.Text = ProgressBar1.Value & "%"

        If (ProgressBar1.Value = 100) Then
            Timer1.Stop()
            Timer1.Enabled = False

            Me.Hide()
            MainForm.Show()






        End If




    End Sub
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        Timer1.Start()





    End Sub

End Class