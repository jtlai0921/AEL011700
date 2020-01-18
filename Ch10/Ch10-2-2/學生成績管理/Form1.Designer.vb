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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(67, 122)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.ReadOnly = True
        Me.txtFinal.Size = New System.Drawing.Size(100, 22)
        Me.txtFinal.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 12)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "期末考:"
        '
        'txtMidTerm
        '
        Me.txtMidTerm.Location = New System.Drawing.Point(67, 93)
        Me.txtMidTerm.Name = "txtMidTerm"
        Me.txtMidTerm.ReadOnly = True
        Me.txtMidTerm.Size = New System.Drawing.Size(100, 22)
        Me.txtMidTerm.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 12)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "期中考:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(67, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 65)
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
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(67, 25)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(100, 22)
        Me.txtNo.TabIndex = 10
        Me.txtNo.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "學號:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(190, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 21)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "期末考"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 21)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "期中考"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMidTerm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "學生成績管理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMidTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
