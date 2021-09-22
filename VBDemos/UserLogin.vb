Public Class UserLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        LoginSystemHandler.LoginSystem(UsernameTextBox, PasswordTextBox, loginoutput)
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        LoginSystemHandler.LoginSystem(UsernameTextBox, PasswordTextBox)
        loginoutput.Text = "Reset!"
    End Sub
End Class
