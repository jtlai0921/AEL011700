<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtChicken = New System.Windows.Forms.TextBox()
        Me.txtFish = New System.Windows.Forms.TextBox()
        Me.txtBeef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.chkFish = New System.Windows.Forms.CheckBox()
        Me.chkBeef = New System.Windows.Forms.CheckBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbCoffee = New System.Windows.Forms.RadioButton()
        Me.rdbBlackTea = New System.Windows.Forms.RadioButton()
        Me.rdbCoke = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbLarge = New System.Windows.Forms.RadioButton()
        Me.rdbSmall = New System.Windows.Forms.RadioButton()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtChicken
        '
        Me.txtChicken.Location = New System.Drawing.Point(206, 58)
        Me.txtChicken.Name = "txtChicken"
        Me.txtChicken.Size = New System.Drawing.Size(55, 22)
        Me.txtChicken.TabIndex = 13
        Me.txtChicken.Text = "1"
        Me.txtChicken.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFish
        '
        Me.txtFish.Location = New System.Drawing.Point(114, 58)
        Me.txtFish.Name = "txtFish"
        Me.txtFish.Size = New System.Drawing.Size(55, 22)
        Me.txtFish.TabIndex = 12
        Me.txtFish.Text = "1"
        Me.txtFish.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBeef
        '
        Me.txtBeef.Location = New System.Drawing.Point(22, 58)
        Me.txtBeef.Name = "txtBeef"
        Me.txtBeef.Size = New System.Drawing.Size(55, 22)
        Me.txtBeef.TabIndex = 11
        Me.txtBeef.Text = "1"
        Me.txtBeef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "數量:"
        '
        'chkChicken
        '
        Me.chkChicken.AutoSize = True
        Me.chkChicken.Checked = True
        Me.chkChicken.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChicken.Location = New System.Drawing.Point(206, 18)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(60, 16)
        Me.chkChicken.TabIndex = 9
        Me.chkChicken.Text = "麥香雞"
        Me.chkChicken.UseVisualStyleBackColor = True
        '
        'chkFish
        '
        Me.chkFish.AutoSize = True
        Me.chkFish.Location = New System.Drawing.Point(114, 18)
        Me.chkFish.Name = "chkFish"
        Me.chkFish.Size = New System.Drawing.Size(60, 16)
        Me.chkFish.TabIndex = 8
        Me.chkFish.Text = "麥香魚"
        Me.chkFish.UseVisualStyleBackColor = True
        '
        'chkBeef
        '
        Me.chkBeef.AutoSize = True
        Me.chkBeef.Location = New System.Drawing.Point(20, 18)
        Me.chkBeef.Name = "chkBeef"
        Me.chkBeef.Size = New System.Drawing.Size(60, 16)
        Me.chkBeef.TabIndex = 7
        Me.chkBeef.Text = "麥香堡"
        Me.chkBeef.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOutput.Location = New System.Drawing.Point(21, 207)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(176, 41)
        Me.lblOutput.TabIndex = 14
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "結帳"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbCoffee)
        Me.GroupBox1.Controls.Add(Me.rdbBlackTea)
        Me.GroupBox1.Controls.Add(Me.rdbCoke)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 40)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "飲料"
        '
        'rdbCoffee
        '
        Me.rdbCoffee.AutoSize = True
        Me.rdbCoffee.Location = New System.Drawing.Point(103, 18)
        Me.rdbCoffee.Name = "rdbCoffee"
        Me.rdbCoffee.Size = New System.Drawing.Size(47, 16)
        Me.rdbCoffee.TabIndex = 11
        Me.rdbCoffee.TabStop = True
        Me.rdbCoffee.Text = "咖啡"
        Me.rdbCoffee.UseVisualStyleBackColor = True
        '
        'rdbBlackTea
        '
        Me.rdbBlackTea.AutoSize = True
        Me.rdbBlackTea.Location = New System.Drawing.Point(195, 18)
        Me.rdbBlackTea.Name = "rdbBlackTea"
        Me.rdbBlackTea.Size = New System.Drawing.Size(47, 16)
        Me.rdbBlackTea.TabIndex = 12
        Me.rdbBlackTea.TabStop = True
        Me.rdbBlackTea.Text = "紅茶"
        Me.rdbBlackTea.UseVisualStyleBackColor = True
        '
        'rdbCoke
        '
        Me.rdbCoke.AutoSize = True
        Me.rdbCoke.Checked = True
        Me.rdbCoke.Location = New System.Drawing.Point(11, 18)
        Me.rdbCoke.Name = "rdbCoke"
        Me.rdbCoke.Size = New System.Drawing.Size(47, 16)
        Me.rdbCoke.TabIndex = 10
        Me.rdbCoke.TabStop = True
        Me.rdbCoke.Text = "可樂"
        Me.rdbCoke.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbLarge)
        Me.GroupBox2.Controls.Add(Me.rdbSmall)
        Me.GroupBox2.Controls.Add(Me.chkFries)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 41)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'rdbLarge
        '
        Me.rdbLarge.AutoSize = True
        Me.rdbLarge.Location = New System.Drawing.Point(154, 15)
        Me.rdbLarge.Name = "rdbLarge"
        Me.rdbLarge.Size = New System.Drawing.Size(59, 16)
        Me.rdbLarge.TabIndex = 17
        Me.rdbLarge.Text = "大薯條"
        Me.rdbLarge.UseVisualStyleBackColor = True
        '
        'rdbSmall
        '
        Me.rdbSmall.AutoSize = True
        Me.rdbSmall.Checked = True
        Me.rdbSmall.Location = New System.Drawing.Point(19, 15)
        Me.rdbSmall.Name = "rdbSmall"
        Me.rdbSmall.Size = New System.Drawing.Size(59, 16)
        Me.rdbSmall.TabIndex = 16
        Me.rdbSmall.TabStop = True
        Me.rdbSmall.Text = "小薯條"
        Me.rdbSmall.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(11, 0)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(48, 16)
        Me.chkFries.TabIndex = 15
        Me.chkFries.Text = "薯條"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(206, 197)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(48, 16)
        Me.chkDelivery.TabIndex = 18
        Me.chkDelivery.Text = "外送"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.chkDelivery)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtChicken)
        Me.Controls.Add(Me.txtFish)
        Me.Controls.Add(Me.txtBeef)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkChicken)
        Me.Controls.Add(Me.chkFish)
        Me.Controls.Add(Me.chkBeef)
        Me.Name = "Form1"
        Me.Text = "速食店點餐系統"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtChicken As System.Windows.Forms.TextBox
    Friend WithEvents txtFish As System.Windows.Forms.TextBox
    Friend WithEvents txtBeef As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkChicken As System.Windows.Forms.CheckBox
    Friend WithEvents chkFish As System.Windows.Forms.CheckBox
    Friend WithEvents chkBeef As System.Windows.Forms.CheckBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBlackTea As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCoke As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbLarge As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSmall As System.Windows.Forms.RadioButton
    Friend WithEvents chkFries As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelivery As System.Windows.Forms.CheckBox

End Class
