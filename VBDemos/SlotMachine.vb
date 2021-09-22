Public Class SlotMachine

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        slot1.Text = Int(Rnd() * 10)
        slot2.Text = Int(Rnd() * 10)
        slot3.Text = Int(Rnd() * 10)
    End Sub

    Private Sub slotstop_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slotstop_BTN.Click
        Timer1.Stop()

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

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Timer1.Enabled = True
        slotstop_BTN.Enabled = True
        Timer1.Start()

        slot1.ForeColor = Color.Black
        slot2.ForeColor = Color.Black
        slot3.ForeColor = Color.Black
    End Sub
End Class