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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.txt20 = New System.Windows.Forms.TextBox()
        Me.txt50 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk5 = New System.Windows.Forms.CheckBox()
        Me.chk10 = New System.Windows.Forms.CheckBox()
        Me.chk20 = New System.Windows.Forms.CheckBox()
        Me.chk50 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "換零錢"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(61, 18)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(171, 22)
        Me.txtAmount.TabIndex = 4
        Me.txtAmount.Text = "350"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "金額:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.txt5)
        Me.GroupBox1.Controls.Add(Me.txt10)
        Me.GroupBox1.Controls.Add(Me.txt20)
        Me.GroupBox1.Controls.Add(Me.txt50)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chk5)
        Me.GroupBox1.Controls.Add(Me.chk10)
        Me.GroupBox1.Controls.Add(Me.chk20)
        Me.GroupBox1.Controls.Add(Me.chk50)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 92)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "兌換種類"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(267, 55)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(56, 22)
        Me.txt1.TabIndex = 13
        Me.txt1.Text = "0"
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(205, 55)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(56, 22)
        Me.txt5.TabIndex = 12
        Me.txt5.Text = "0"
        '
        'txt10
        '
        Me.txt10.Location = New System.Drawing.Point(143, 55)
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(56, 22)
        Me.txt10.TabIndex = 11
        Me.txt10.Text = "0"
        '
        'txt20
        '
        Me.txt20.Location = New System.Drawing.Point(81, 55)
        Me.txt20.Name = "txt20"
        Me.txt20.Size = New System.Drawing.Size(56, 22)
        Me.txt20.TabIndex = 10
        Me.txt20.Text = "0"
        '
        'txt50
        '
        Me.txt50.Location = New System.Drawing.Point(19, 55)
        Me.txt50.Name = "txt50"
        Me.txt50.Size = New System.Drawing.Size(56, 22)
        Me.txt50.TabIndex = 9
        Me.txt50.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "$1元"
        Me.Label2.UseMnemonic = False
        '
        'chk5
        '
        Me.chk5.AutoSize = True
        Me.chk5.Checked = True
        Me.chk5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk5.Location = New System.Drawing.Point(205, 26)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(48, 16)
        Me.chk5.TabIndex = 7
        Me.chk5.Text = "$5元"
        Me.chk5.UseVisualStyleBackColor = True
        '
        'chk10
        '
        Me.chk10.AutoSize = True
        Me.chk10.Checked = True
        Me.chk10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk10.Location = New System.Drawing.Point(143, 26)
        Me.chk10.Name = "chk10"
        Me.chk10.Size = New System.Drawing.Size(54, 16)
        Me.chk10.TabIndex = 6
        Me.chk10.Text = "$10元"
        Me.chk10.UseVisualStyleBackColor = True
        '
        'chk20
        '
        Me.chk20.AutoSize = True
        Me.chk20.Location = New System.Drawing.Point(81, 26)
        Me.chk20.Name = "chk20"
        Me.chk20.Size = New System.Drawing.Size(54, 16)
        Me.chk20.TabIndex = 5
        Me.chk20.Text = "$20元"
        Me.chk20.UseVisualStyleBackColor = True
        '
        'chk50
        '
        Me.chk50.AutoSize = True
        Me.chk50.Checked = True
        Me.chk50.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk50.Location = New System.Drawing.Point(19, 26)
        Me.chk50.Name = "chk50"
        Me.chk50.Size = New System.Drawing.Size(54, 16)
        Me.chk50.TabIndex = 4
        Me.chk50.Text = "$50元"
        Me.chk50.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 162)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "換零錢機"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents txt10 As System.Windows.Forms.TextBox
    Friend WithEvents txt20 As System.Windows.Forms.TextBox
    Friend WithEvents txt50 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk10 As System.Windows.Forms.CheckBox
    Friend WithEvents chk20 As System.Windows.Forms.CheckBox
    Friend WithEvents chk50 As System.Windows.Forms.CheckBox

End Class
