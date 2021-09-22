Public Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormFormat.CornerRadius.FormRoundRadius(Me, 15)

        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 50
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        loading_MSG.Text = "Loading Please Wait... (" + ProgressBar1.Value.ToString() + ")"
        If (ProgressBar1.Value = 100) Then
            Timer1.Stop()
            Me.Hide()
            MainForm.Show()
        End If
    End Sub
End Class
