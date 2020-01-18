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
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDivide = New System.Windows.Forms.RadioButton()
        Me.rdbMultiply = New System.Windows.Forms.RadioButton()
        Me.rdbSubtract = New System.Windows.Forms.RadioButton()
        Me.rdbAdd = New System.Windows.Forms.RadioButton()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtOpd2 = New System.Windows.Forms.TextBox()
        Me.txtOpd1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(18, 82)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(194, 31)
        Me.Button8.TabIndex = 27
        Me.Button8.Text = "計算"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbDivide)
        Me.GroupBox1.Controls.Add(Me.rdbMultiply)
        Me.GroupBox1.Controls.Add(Me.rdbSubtract)
        Me.GroupBox1.Controls.Add(Me.rdbAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(229, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 102)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "運算子"
        '
        'rdbDivide
        '
        Me.rdbDivide.AutoSize = True
        Me.rdbDivide.Location = New System.Drawing.Point(24, 79)
        Me.rdbDivide.Name = "rdbDivide"
        Me.rdbDivide.Size = New System.Drawing.Size(26, 16)
        Me.rdbDivide.TabIndex = 3
        Me.rdbDivide.Text = "/"
        Me.rdbDivide.UseVisualStyleBackColor = True
        '
        'rdbMultiply
        '
        Me.rdbMultiply.AutoSize = True
        Me.rdbMultiply.Location = New System.Drawing.Point(24, 58)
        Me.rdbMultiply.Name = "rdbMultiply"
        Me.rdbMultiply.Size = New System.Drawing.Size(29, 16)
        Me.rdbMultiply.TabIndex = 2
        Me.rdbMultiply.Text = "*"
        Me.rdbMultiply.UseVisualStyleBackColor = True
        '
        'rdbSubtract
        '
        Me.rdbSubtract.AutoSize = True
        Me.rdbSubtract.Location = New System.Drawing.Point(24, 37)
        Me.rdbSubtract.Name = "rdbSubtract"
        Me.rdbSubtract.Size = New System.Drawing.Size(27, 16)
        Me.rdbSubtract.TabIndex = 1
        Me.rdbSubtract.Text = "-"
        Me.rdbSubtract.UseVisualStyleBackColor = True
        '
        'rdbAdd
        '
        Me.rdbAdd.AutoSize = True
        Me.rdbAdd.Checked = True
        Me.rdbAdd.Location = New System.Drawing.Point(24, 16)
        Me.rdbAdd.Name = "rdbAdd"
        Me.rdbAdd.Size = New System.Drawing.Size(32, 16)
        Me.rdbAdd.TabIndex = 0
        Me.rdbAdd.TabStop = True
        Me.rdbAdd.Text = "+ "
        Me.rdbAdd.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(180, 202)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(106, 21)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "整數除法"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(99, 202)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 21)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "指數"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(18, 202)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 21)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "餘數"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(260, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 21)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "除法"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(179, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 21)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "乘法"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(99, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 21)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "減法"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "加法"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOutput.Location = New System.Drawing.Point(18, 123)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(316, 43)
        Me.lblOutput.TabIndex = 18
        '
        'txtOpd2
        '
        Me.txtOpd2.Location = New System.Drawing.Point(88, 49)
        Me.txtOpd2.Name = "txtOpd2"
        Me.txtOpd2.Size = New System.Drawing.Size(124, 22)
        Me.txtOpd2.TabIndex = 17
        Me.txtOpd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOpd1
        '
        Me.txtOpd1.Location = New System.Drawing.Point(88, 18)
        Me.txtOpd1.Name = "txtOpd1"
        Me.txtOpd1.Size = New System.Drawing.Size(124, 22)
        Me.txtOpd1.TabIndex = 16
        Me.txtOpd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "運算元2:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 12)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "運算元1:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 232)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtOpd2)
        Me.Controls.Add(Me.txtOpd1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "算術計算機"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDivide As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMultiply As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSubtract As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAdd As System.Windows.Forms.RadioButton
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents txtOpd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOpd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
