<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotMachine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SlotMachine))
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.slotstop_BTN = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.slot3 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.slot2 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.slot1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.GroupBox4)
        Me.Panel9.Controls.Add(Me.GroupBox5)
        Me.Panel9.Location = New System.Drawing.Point(12, 12)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(615, 364)
        Me.Panel9.TabIndex = 16
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Button40)
        Me.GroupBox4.Controls.Add(Me.slotstop_BTN)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(607, 215)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Input"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(5, 198)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(174, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "@Copyright 2021 - Visual Studio"
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button40.ForeColor = System.Drawing.Color.Black
        Me.Button40.Location = New System.Drawing.Point(26, 129)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(560, 66)
        Me.Button40.TabIndex = 1
        Me.Button40.Text = "Start"
        Me.Button40.UseVisualStyleBackColor = False
        '
        'slotstop_BTN
        '
        Me.slotstop_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slotstop_BTN.Enabled = False
        Me.slotstop_BTN.ForeColor = System.Drawing.Color.Black
        Me.slotstop_BTN.Location = New System.Drawing.Point(63, 58)
        Me.slotstop_BTN.Name = "slotstop_BTN"
        Me.slotstop_BTN.Size = New System.Drawing.Size(496, 55)
        Me.slotstop_BTN.TabIndex = 0
        Me.slotstop_BTN.Text = "Stop"
        Me.slotstop_BTN.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Panel12)
        Me.GroupBox5.Controls.Add(Me.Panel11)
        Me.GroupBox5.Controls.Add(Me.Panel10)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(607, 125)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Output"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(449, 100)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(44, 19)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Slot 3"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(263, 100)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 19)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Slot 2"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(73, 100)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 19)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Slot 1"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Silver
        Me.Panel12.Controls.Add(Me.slot3)
        Me.Panel12.Location = New System.Drawing.Point(397, 36)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(148, 61)
        Me.Panel12.TabIndex = 2
        '
        'slot3
        '
        Me.slot3.AutoSize = True
        Me.slot3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.slot3.ForeColor = System.Drawing.Color.Black
        Me.slot3.Location = New System.Drawing.Point(62, 17)
        Me.slot3.Name = "slot3"
        Me.slot3.Size = New System.Drawing.Size(23, 28)
        Me.slot3.TabIndex = 0
        Me.slot3.Text = "0"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Silver
        Me.Panel11.Controls.Add(Me.slot2)
        Me.Panel11.Location = New System.Drawing.Point(215, 36)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(148, 61)
        Me.Panel11.TabIndex = 1
        '
        'slot2
        '
        Me.slot2.AutoSize = True
        Me.slot2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.slot2.ForeColor = System.Drawing.Color.Black
        Me.slot2.Location = New System.Drawing.Point(59, 17)
        Me.slot2.Name = "slot2"
        Me.slot2.Size = New System.Drawing.Size(23, 28)
        Me.slot2.TabIndex = 0
        Me.slot2.Text = "0"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Silver
        Me.Panel10.Controls.Add(Me.slot1)
        Me.Panel10.Location = New System.Drawing.Point(26, 36)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(148, 61)
        Me.Panel10.TabIndex = 0
        '
        'slot1
        '
        Me.slot1.AutoSize = True
        Me.slot1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.slot1.ForeColor = System.Drawing.Color.Black
        Me.slot1.Location = New System.Drawing.Point(57, 17)
        Me.slot1.Name = "slot1"
        Me.slot1.Size = New System.Drawing.Size(23, 28)
        Me.slot1.TabIndex = 0
        Me.slot1.Text = "0"
        '
        'Timer1
        '
        '
        'SlotMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 386)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SlotMachine"
        Me.Text = "Slot Machine Demo"
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents slotstop_BTN As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents slot3 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents slot2 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents slot1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
