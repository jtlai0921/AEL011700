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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb5 = New System.Windows.Forms.RadioButton()
        Me.rdb10 = New System.Windows.Forms.RadioButton()
        Me.rdb50 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOutput.Location = New System.Drawing.Point(24, 100)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(239, 41)
        Me.lblOutput.TabIndex = 8
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "換零錢"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(61, 20)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(122, 22)
        Me.txtAmount.TabIndex = 6
        Me.txtAmount.Text = "350"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "金額:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb5)
        Me.GroupBox1.Controls.Add(Me.rdb10)
        Me.GroupBox1.Controls.Add(Me.rdb50)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 42)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "種類"
        '
        'rdb5
        '
        Me.rdb5.AutoSize = True
        Me.rdb5.Location = New System.Drawing.Point(176, 21)
        Me.rdb5.Name = "rdb5"
        Me.rdb5.Size = New System.Drawing.Size(41, 16)
        Me.rdb5.TabIndex = 2
        Me.rdb5.Text = "5元"
        Me.rdb5.UseVisualStyleBackColor = True
        '
        'rdb10
        '
        Me.rdb10.AutoSize = True
        Me.rdb10.Location = New System.Drawing.Point(100, 21)
        Me.rdb10.Name = "rdb10"
        Me.rdb10.Size = New System.Drawing.Size(47, 16)
        Me.rdb10.TabIndex = 1
        Me.rdb10.Text = "10元"
        Me.rdb10.UseVisualStyleBackColor = True
        '
        'rdb50
        '
        Me.rdb50.AutoSize = True
        Me.rdb50.Checked = True
        Me.rdb50.Location = New System.Drawing.Point(15, 21)
        Me.rdb50.Name = "rdb50"
        Me.rdb50.Size = New System.Drawing.Size(47, 16)
        Me.rdb50.TabIndex = 0
        Me.rdb50.TabStop = True
        Me.rdb50.Text = "50元"
        Me.rdb50.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblOutput)
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
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb5 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb10 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb50 As System.Windows.Forms.RadioButton

End Class
