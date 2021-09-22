Public Class UserRegister

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        LoginSystemHandler.RegisterSystem(UsernameTextBox, PasswordTextBox, EmailTextBox, loginoutput)
        LoginSystemHandler.RegisterSystem(Me)
    End Sub
End Class
