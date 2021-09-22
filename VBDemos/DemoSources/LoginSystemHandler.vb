Public Class LoginSystemHandler
    Class UserData
        Shared username As String
        Shared password As String
        Shared email As String

        Public Property _username As String
            Get
                Return username
            End Get
            Set(ByVal value As String)
                username = value
            End Set
        End Property

        Public Property _password As String
            Get
                Return password
            End Get
            Set(ByVal value As String)
                password = value
            End Set
        End Property

        Public Property _email As String
            Get
                Return email
            End Get
            Set(ByVal value As String)
                email = value
            End Set
        End Property
    End Class

    Public Shared Sub LoginSystem(ByVal _username As TextBox, ByVal _password As TextBox, ByVal _callback As Label)
        Dim data As UserData = New UserData

        If _username.Text = Nothing Then
            _callback.Text = "Username Is Missing"
            _callback.ForeColor = Color.Red
        ElseIf _password.Text = Nothing Then
            _callback.Text = "Password Is Missing"
            _callback.ForeColor = Color.Red
        ElseIf _username.Text = "TestDemo" And _password.Text = "Demo123" Or _username.Text = data._username And _password.Text = data._password Then
            _callback.Text = "Login Succesfully! | Username: " + _username.Text + " | " + data._email
            _callback.ForeColor = Color.Green
        Else
            _callback.Text = "Username Or Password is Wrong"
            _callback.ForeColor = Color.Red
        End If
    End Sub

    Public Shared Sub LoginSystem(ByVal _username As TextBox, ByVal _password As TextBox)
        _username.Text = ""
        _password.Text = ""
    End Sub

    Public Shared Sub RegisterSystem(ByVal _username As TextBox, ByVal _password As TextBox, ByVal _email As TextBox, ByVal _callback As Label)
        Dim data As UserData = New UserData

        If _username.Text = Nothing Then
            _callback.Text = "Missing Username Input"
            _callback.ForeColor = Color.Red
        ElseIf _password.Text = Nothing Then
            _callback.Text = "Missing Password Input"
            _callback.ForeColor = Color.Red
        ElseIf _email.Text = Nothing Then
            _callback.Text = "Missing Email Input"
            _callback.ForeColor = Color.Red
        Else
            _callback.Text = "Acount Created Succesfully!"
            data._username = _username.Text
            data._password = _password.Text
            data._email = _email.Text
            _callback.ForeColor = Color.Green
        End If
    End Sub
    Public Shared Sub RegisterSystem(ByVal _form As Form)
        Dim data As UserData = New UserData

        If data._username = Nothing Then
            'do nothing
        Else
            MsgBox("Account Created Succesfully")
            _form.Hide()
        End If
    End Sub
End Class
