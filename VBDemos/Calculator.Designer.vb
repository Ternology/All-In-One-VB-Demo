<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.CalculatorDemo = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.caltextbox = New System.Windows.Forms.TextBox()
        Me.CalculatorDemo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculatorDemo
        '
        Me.CalculatorDemo.BackColor = System.Drawing.Color.Gainsboro
        Me.CalculatorDemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CalculatorDemo.Controls.Add(Me.GroupBox3)
        Me.CalculatorDemo.Controls.Add(Me.GroupBox2)
        Me.CalculatorDemo.Location = New System.Drawing.Point(12, 12)
        Me.CalculatorDemo.Name = "CalculatorDemo"
        Me.CalculatorDemo.Size = New System.Drawing.Size(353, 339)
        Me.CalculatorDemo.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Button39)
        Me.GroupBox3.Controls.Add(Me.Button38)
        Me.GroupBox3.Controls.Add(Me.Button37)
        Me.GroupBox3.Controls.Add(Me.Button36)
        Me.GroupBox3.Controls.Add(Me.Button35)
        Me.GroupBox3.Controls.Add(Me.Button34)
        Me.GroupBox3.Controls.Add(Me.Button33)
        Me.GroupBox3.Controls.Add(Me.Button32)
        Me.GroupBox3.Controls.Add(Me.Button29)
        Me.GroupBox3.Controls.Add(Me.Button30)
        Me.GroupBox3.Controls.Add(Me.Button31)
        Me.GroupBox3.Controls.Add(Me.Button26)
        Me.GroupBox3.Controls.Add(Me.Button27)
        Me.GroupBox3.Controls.Add(Me.Button28)
        Me.GroupBox3.Controls.Add(Me.Button25)
        Me.GroupBox3.Controls.Add(Me.Button24)
        Me.GroupBox3.Controls.Add(Me.Button23)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(345, 241)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 227)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(174, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "@Copyright 2021 - Visual Studio"
        '
        'Button39
        '
        Me.Button39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button39.ForeColor = System.Drawing.Color.Black
        Me.Button39.Location = New System.Drawing.Point(204, 32)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(135, 42)
        Me.Button39.TabIndex = 16
        Me.Button39.Text = "Clear"
        Me.Button39.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button38.ForeColor = System.Drawing.Color.Black
        Me.Button38.Location = New System.Drawing.Point(267, 80)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(72, 42)
        Me.Button38.TabIndex = 15
        Me.Button38.Text = "/"
        Me.Button38.UseVisualStyleBackColor = True
        '
        'Button37
        '
        Me.Button37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button37.ForeColor = System.Drawing.Color.Black
        Me.Button37.Location = New System.Drawing.Point(204, 80)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(57, 42)
        Me.Button37.TabIndex = 14
        Me.Button37.Text = "*"
        Me.Button37.UseVisualStyleBackColor = True
        '
        'Button36
        '
        Me.Button36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button36.ForeColor = System.Drawing.Color.Black
        Me.Button36.Location = New System.Drawing.Point(267, 128)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(72, 42)
        Me.Button36.TabIndex = 13
        Me.Button36.Text = "-"
        Me.Button36.UseVisualStyleBackColor = True
        '
        'Button35
        '
        Me.Button35.ForeColor = System.Drawing.Color.Black
        Me.Button35.Location = New System.Drawing.Point(204, 128)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(57, 42)
        Me.Button35.TabIndex = 12
        Me.Button35.Text = "+"
        Me.Button35.UseVisualStyleBackColor = True
        '
        'Button34
        '
        Me.Button34.ForeColor = System.Drawing.Color.Black
        Me.Button34.Location = New System.Drawing.Point(249, 177)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(90, 39)
        Me.Button34.TabIndex = 11
        Me.Button34.Text = "="
        Me.Button34.UseVisualStyleBackColor = True
        '
        'Button33
        '
        Me.Button33.ForeColor = System.Drawing.Color.Black
        Me.Button33.Location = New System.Drawing.Point(204, 177)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(44, 39)
        Me.Button33.TabIndex = 10
        Me.Button33.Text = "."
        Me.Button33.UseVisualStyleBackColor = True
        '
        'Button32
        '
        Me.Button32.ForeColor = System.Drawing.Color.Black
        Me.Button32.Location = New System.Drawing.Point(6, 177)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(190, 39)
        Me.Button32.TabIndex = 9
        Me.Button32.Text = "0"
        Me.Button32.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.ForeColor = System.Drawing.Color.Black
        Me.Button29.Location = New System.Drawing.Point(136, 128)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(60, 42)
        Me.Button29.TabIndex = 8
        Me.Button29.Text = "3"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Button30
        '
        Me.Button30.ForeColor = System.Drawing.Color.Black
        Me.Button30.Location = New System.Drawing.Point(70, 129)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(60, 42)
        Me.Button30.TabIndex = 7
        Me.Button30.Text = "2"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.ForeColor = System.Drawing.Color.Black
        Me.Button31.Location = New System.Drawing.Point(6, 129)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(60, 42)
        Me.Button31.TabIndex = 6
        Me.Button31.Text = "1"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.ForeColor = System.Drawing.Color.Black
        Me.Button26.Location = New System.Drawing.Point(136, 80)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(60, 42)
        Me.Button26.TabIndex = 5
        Me.Button26.Text = "6"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.ForeColor = System.Drawing.Color.Black
        Me.Button27.Location = New System.Drawing.Point(70, 80)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(60, 42)
        Me.Button27.TabIndex = 4
        Me.Button27.Text = "5"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.ForeColor = System.Drawing.Color.Black
        Me.Button28.Location = New System.Drawing.Point(6, 81)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(60, 42)
        Me.Button28.TabIndex = 3
        Me.Button28.Text = "4"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.ForeColor = System.Drawing.Color.Black
        Me.Button25.Location = New System.Drawing.Point(138, 32)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(60, 42)
        Me.Button25.TabIndex = 2
        Me.Button25.Text = "9"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.ForeColor = System.Drawing.Color.Black
        Me.Button24.Location = New System.Drawing.Point(72, 32)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(60, 42)
        Me.Button24.TabIndex = 1
        Me.Button24.Text = "8"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.ForeColor = System.Drawing.Color.Black
        Me.Button23.Location = New System.Drawing.Point(6, 32)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(60, 42)
        Me.Button23.TabIndex = 0
        Me.Button23.Text = "7"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.caltextbox)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'caltextbox
        '
        Me.caltextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caltextbox.Location = New System.Drawing.Point(20, 28)
        Me.caltextbox.Name = "caltextbox"
        Me.caltextbox.ReadOnly = True
        Me.caltextbox.Size = New System.Drawing.Size(288, 24)
        Me.caltextbox.TabIndex = 0
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 364)
        Me.Controls.Add(Me.CalculatorDemo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Calculator"
        Me.Text = "Calculator Demo"
        Me.CalculatorDemo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CalculatorDemo As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents caltextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
