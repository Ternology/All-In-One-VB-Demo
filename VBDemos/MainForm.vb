Public Class MainForm
#Region "Form Codes"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormFormat.CornerRadius.FormRoundRadius(Me, 20)
        FormFormat.CornerRadius.ObjectRoundRadius(Home_Panel, 15)

        CalculatorHandler.CalculatorDEMO(caltextbox)

        If Selected = Nothing Then
            ButtonClick(Button1, True)
        End If
    End Sub


    Private Sub MainForm_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown, Panel3.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub


    Private Sub MainForm_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp, Panel1.MouseUp, Panel3.MouseUp
        drag = False
    End Sub

    Private Sub MainForm_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove, Panel3.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
#End Region

#Region "Button Codes"
    Dim Selected As Int32

    Public Sub ButtonClick(ByVal obj As Button, ByVal isclicked As Boolean)
        If isclicked = True Then
            obj.BackColor = Color.FromArgb(64, 64, 64)
        Else
            obj.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ButtonClick(Button1, True)

        Home_Panel.Visible = True
        VBD_Panel.Visible = False
        SettingPanel.Visible = False

        ButtonClick(Button2, False)
        ButtonClick(Button3, False)
        ButtonClick(Button4, False)
        ButtonClick(Button5, False)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ButtonClick(Button2, True)

        Home_Panel.Visible = False
        VBD_Panel.Visible = True

        ButtonClick(Button1, False)
        ButtonClick(Button3, False)
        ButtonClick(Button4, False)
        ButtonClick(Button5, False)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        _Dialog = MessageBox.Show("Not Available for Development Build, Basic Database will implemented Soon", "Database Demo Panel")

        ButtonClick(Button3, True)

        ButtonClick(Button1, False)
        ButtonClick(Button2, False)
        ButtonClick(Button4, False)
        ButtonClick(Button5, False)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        _Dialog = MessageBox.Show("Not Available for Development Build, Advance Demo will implemented Soon", "Advance Demo Panel")

        ButtonClick(Button4, True)

        ButtonClick(Button1, False)
        ButtonClick(Button2, False)
        ButtonClick(Button3, False)
        ButtonClick(Button5, False)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ButtonClick(Button5, True)

        SettingPanel.Visible = True

        Home_Panel.Visible = False
        VBD_Panel.Visible = False

        ButtonClick(Button1, False)
        ButtonClick(Button2, False)
        ButtonClick(Button3, False)
        ButtonClick(Button4, False)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Application.Exit()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        AboutBox1.Show()
    End Sub
#End Region

#Region "Calculator Demo"
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Calculator.Show()
    End Sub
    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        CalculatorHandler.AddZero()
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

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        CalculatorHandler.AddPeriod()
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
#End Region

#Region "Export System"
    Dim _Dialog As DialogResult

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ExportHandler.SaveAsVB(SaveFileDialog1, "Calculator Demo", calcodeSave)
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ExportHandler.SaveAsVB(SaveFileDialog1, "Calculator Demo VB6", calVB6)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ExportHandler.SaveAsVB(SaveFileDialog1, "Slot Machine Demo", slotVBnet)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ExportHandler.SaveAsVB(SaveFileDialog1, "Slot Machine Demo VB6", slotVB6)
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        ExportHandler.SaveAsVB(SaveFileDialog1, "User Login Demo", loginVB)
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        ExportHandler.SaveAsVB(SaveFileDialog1, "User Login Demo VB6", loginuserVB6)
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        ExportHandler.SaveAsVB(SaveFileDialog1, "Basic Timer Use", TimerCDVB)
    End Sub
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        ExportHandler.SaveAsVB(SaveFileDialog1, "Basic Timer Use VB6", TimerCUVB6)
    End Sub
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        _Dialog = MessageBox.Show("Export are not available for Basic User Register you can visit to our Github to get the fully Login and Register System", "Not Available")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        _Dialog = MessageBox.Show("Export are not available for Basic User Register you can visit to our Github to get the fully Login and Register System", "Not Available")
    End Sub
#End Region

#Region "Slot Machine"
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        SlotMachine.Show()
    End Sub
    Private Sub slotTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slotTimer.Tick
        slot1.Text = Int(Rnd() * 10)
        slot2.Text = Int(Rnd() * 10)
        slot3.Text = Int(Rnd() * 10)
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        slotTimer.Enabled = True
        slotstop_BTN.Enabled = True
        slotTimer.Start()

        slot1.ForeColor = Color.Black
        slot2.ForeColor = Color.Black
        slot3.ForeColor = Color.Black
    End Sub

    Private Sub slotstop_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slotstop_BTN.Click
        slotTimer.Stop()

        Dim Result As DialogResult

        If slot1.Text = slot2.Text = slot3.Text Then
            Result = MessageBox.Show("You Won The Slot", "Slot Machine Demo")

            slot1.ForeColor = Color.Green
            slot2.ForeColor = Color.Green
            slot3.ForeColor = Color.Green
        Else
            Result = MessageBox.Show("You Lost The Slot", "Slot Machine Demo")

            slot1.ForeColor = Color.Red
            slot2.ForeColor = Color.Red
            slot3.ForeColor = Color.Red
        End If
    End Sub
#End Region

#Region "Login And Register System"
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        UserLogin.Show()
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        UserRegister.Show()
    End Sub
    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        LoginSystemHandler.LoginSystem(usernameTB, passwordTB, loginoutput)
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        LoginSystemHandler.LoginSystem(usernameTB, passwordTB)
        loginoutput.Text = "Reset!"
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        LoginSystemHandler.RegisterSystem(regusername, regpassword, regemail, regoutput)
    End Sub
#End Region

#Region "Timer Demo"
    Private Sub timerCD_Tick() Handles timerCD.Tick

        stopCD.Enabled = True
        CdLabel.Text -= 1

        AddTimerTextBox.ReadOnly = True
        If CdLabel.Text = "0" Then
            timerCD.Stop()
            AddTimerTextBox.ReadOnly = False
        End If

    End Sub
    Private Sub timerCU_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCU.Tick
        stopCU.Enabled = True
        cULabel.Text += 1

        AddTimerTextBox.ReadOnly = True
        If cULabel.Text = "0" Then
            timerCU.Stop()
            AddTimerTextBox.ReadOnly = False
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTimerTextBox.TextChanged
        CdLabel.Text = AddTimerTextBox.Text
        cULabel.Text = AddTimerTextBox.Text
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        If AddTimerTextBox.Text = Nothing Then
            MsgBox("Please Add Timer Value First")
        Else
            timerCD.Enabled = True
            timerCD.Start()
        End If
    End Sub

    Private Sub stopCD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopCD.Click
        timerCD.Stop()
        stopCD.Enabled = False
        AddTimerTextBox.ReadOnly = False
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        If AddTimerTextBox.Text = Nothing Then
            MsgBox("Please Add Timer Value First")
        Else
            timerCU.Enabled = True
            timerCU.Start()
        End If
    End Sub
    Private Sub stopCU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopCU.Click
        timerCU.Stop()
        stopCU.Enabled = False
        AddTimerTextBox.ReadOnly = False
    End Sub
#End Region




    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Process.Start("https://github.com/Ternology/All-In-One-VB-Demo")
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Process.Start("https://www.facebook.com/TernologyOfficial")
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        Process.Start("https://discord.gg/fvYeyrvGY9")
    End Sub
End Class