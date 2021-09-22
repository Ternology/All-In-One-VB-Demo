Public Class CalculatorHandler
    Shared _FirstNumber As Decimal
    Shared _SecondNumber As Decimal
    Shared _Operations As Integer

    Shared _OperatorSelect As Boolean

    Shared _textbox As TextBox

    Public Shared Sub CalculatorDEMO(ByVal _output As TextBox)
        _textbox = _output
        If _textbox.Text = Nothing Then
            _textbox.Text = "0"
        End If
    End Sub

    Public Shared Sub CalculatorDEMO(ByVal _addNumber As String)
        If _textbox.Text <> "0" Then
            _textbox.Text += _addNumber
        Else
            _textbox.Text = _addNumber
        End If
    End Sub

    Public Shared Sub CalculatorAddition()
        _FirstNumber = _textbox.Text
        _textbox.Text = ""

        _Operations = 1
        _OperatorSelect = True

    End Sub

    Public Shared Sub CalculatorSubtraction()
        _FirstNumber = _textbox.Text
        _textbox.Text = ""

        _Operations = 2
        _OperatorSelect = True

    End Sub

    Public Shared Sub CalculatorMultiplication()
        _FirstNumber = _textbox.Text
        _textbox.Text = ""

        _Operations = 3
        _OperatorSelect = True

    End Sub

    Public Shared Sub CalculatorDivision()
        _FirstNumber = _textbox.Text
        _textbox.Text = ""

        _Operations = 4
        _OperatorSelect = True

    End Sub

    Public Shared Sub CalculatorResult()
        If _OperatorSelect = True Then
            _SecondNumber = CDec(_textbox.Text)
            If _Operations = 1 Then
                _textbox.Text = _FirstNumber + _SecondNumber
            ElseIf _Operations = 2 Then
                _textbox.Text = _FirstNumber - _SecondNumber
            ElseIf _Operations = 3 Then
                _textbox.Text = _FirstNumber * _SecondNumber
            ElseIf _SecondNumber = Nothing Then
                _textbox.Text = "Syntax Error!"
            Else
                _textbox.Text = _FirstNumber / _SecondNumber
            End If
        End If
    End Sub

    Public Shared Sub AddPeriod()
        If Not (_textbox.Text.Contains(".")) Then
            _textbox.Text += "."
        End If
    End Sub

    Public Shared Sub AddZero()
        If _textbox.Text <> "0" Then
            _textbox.Text += "0"
        End If
    End Sub

    Public Shared Sub ClearOutput()
        _textbox.Text = "0"
    End Sub
End Class
