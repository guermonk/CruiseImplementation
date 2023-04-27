<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.RadioBus = New System.Windows.Forms.RadioButton()
        Me.RadioWhale = New System.Windows.Forms.RadioButton()
        Me.RadioFood = New System.Windows.Forms.RadioButton()
        Me.TextBoxPeople = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 341)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Expo M", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cruise Excursion Calculator"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(274, 296)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(211, 47)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClear.Location = New System.Drawing.Point(559, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(211, 47)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'RadioBus
        '
        Me.RadioBus.AllowDrop = True
        Me.RadioBus.AutoSize = True
        Me.RadioBus.Checked = True
        Me.RadioBus.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RadioBus.Location = New System.Drawing.Point(276, 110)
        Me.RadioBus.Name = "RadioBus"
        Me.RadioBus.Size = New System.Drawing.Size(172, 21)
        Me.RadioBus.TabIndex = 4
        Me.RadioBus.TabStop = True
        Me.RadioBus.Text = "Bus Tour ($30.00)"
        Me.RadioBus.UseVisualStyleBackColor = True
        '
        'RadioWhale
        '
        Me.RadioWhale.AutoSize = True
        Me.RadioWhale.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RadioWhale.Location = New System.Drawing.Point(274, 165)
        Me.RadioWhale.Name = "RadioWhale"
        Me.RadioWhale.Size = New System.Drawing.Size(243, 21)
        Me.RadioWhale.TabIndex = 5
        Me.RadioWhale.Text = "Whale Watching ($100.00)"
        Me.RadioWhale.UseVisualStyleBackColor = True
        '
        'RadioFood
        '
        Me.RadioFood.AutoSize = True
        Me.RadioFood.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RadioFood.Location = New System.Drawing.Point(274, 221)
        Me.RadioFood.Name = "RadioFood"
        Me.RadioFood.Size = New System.Drawing.Size(205, 21)
        Me.RadioFood.TabIndex = 6
        Me.RadioFood.Text = "Food Review ($40.00)"
        Me.RadioFood.UseVisualStyleBackColor = True
        '
        'TextBoxPeople
        '
        Me.TextBoxPeople.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBoxPeople.Location = New System.Drawing.Point(543, 214)
        Me.TextBoxPeople.Name = "TextBoxPeople"
        Me.TextBoxPeople.Size = New System.Drawing.Size(147, 25)
        Me.TextBoxPeople.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(536, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Number of People:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(116, 379)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(118, 32)
        Me.lblTotal.TabIndex = 10
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Expo M", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(12, 425)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(1210, 30)
        Me.lblMessage.TabIndex = 11
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioBus)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxPeople)
        Me.Controls.Add(Me.RadioFood)
        Me.Controls.Add(Me.RadioWhale)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Cruise Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents RadioWhale As RadioButton
    Friend WithEvents RadioFood As RadioButton
    Friend WithEvents TextBoxPeople As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents RadioBus As RadioButton
End Class
