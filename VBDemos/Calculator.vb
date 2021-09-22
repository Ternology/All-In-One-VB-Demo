Public Class Calculator

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CalculatorHandler.CalculatorDEMO(caltextbox)
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        CalculatorHandler.AddZero()
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        CalculatorHandler.AddPeriod()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        CalculatorHandler.CalculatorDEMO("1")
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        CalculatorHandler.CalculatorDEMO("2")
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        CalculatorHandler.CalculatorDEMO("3")
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        CalculatorHandler.CalculatorDEMO("4")
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        CalculatorHandler.CalculatorDEMO("5")
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        CalculatorHandler.CalculatorDEMO("6")
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        CalculatorHandler.CalculatorDEMO("7")
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        CalculatorHandler.CalculatorDEMO("8")
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        CalculatorHandler.CalculatorDEMO("9")
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        CalculatorHandler.ClearOutput()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        CalculatorHandler.CalculatorAddition()
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        CalculatorHandler.CalculatorSubtraction()
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        CalculatorHandler.CalculatorMultiplication()
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        CalculatorHandler.CalculatorDivision()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        CalculatorHandler.CalculatorResult()
    End Sub
End Class