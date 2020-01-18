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
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMidTerm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(66, 82)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(100, 22)
        Me.txtFinal.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 12)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "期末考:"
        '
        'txtMidTerm
        '
        Me.txtMidTerm.Location = New System.Drawing.Point(66, 53)
        Me.txtMidTerm.Name = "txtMidTerm"
        Me.txtMidTerm.Size = New System.Drawing.Size(100, 22)
        Me.txtMidTerm.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 12)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "期中考:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "姓名:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "查詢"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "新增"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(190, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "更新"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Items.AddRange(New Object() {"陳會安", "江小魚", "陳允傑", "楊過", "小龍女"})
        Me.cboName.Location = New System.Drawing.Point(66, 21)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(110, 20)
        Me.cboName.TabIndex = 20
        Me.cboName.Text = "選擇姓名"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMidTerm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "學生成績管理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMidTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cboName As System.Windows.Forms.ComboBox

End Class
