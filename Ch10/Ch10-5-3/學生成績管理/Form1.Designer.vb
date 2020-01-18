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
        Me.ltbName = New System.Windows.Forms.ListBox()
        Me.clbName = New System.Windows.Forms.CheckedListBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltbName
        '
        Me.ltbName.FormattingEnabled = True
        Me.ltbName.ItemHeight = 12
        Me.ltbName.Items.AddRange(New Object() {"陳會安", "江小魚", "陳允傑", "楊過", "小龍女"})
        Me.ltbName.Location = New System.Drawing.Point(12, 16)
        Me.ltbName.Name = "ltbName"
        Me.ltbName.Size = New System.Drawing.Size(131, 100)
        Me.ltbName.TabIndex = 1
        '
        'clbName
        '
        Me.clbName.FormattingEnabled = True
        Me.clbName.Items.AddRange(New Object() {"陳會安", "江小魚", "陳允傑", "楊過", "小龍女"})
        Me.clbName.Location = New System.Drawing.Point(151, 16)
        Me.clbName.Name = "clbName"
        Me.clbName.Size = New System.Drawing.Size(121, 89)
        Me.clbName.TabIndex = 2
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(13, 157)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(258, 70)
        Me.txtOutput.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(150, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 29)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "計算"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "查詢"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 242)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.clbName)
        Me.Controls.Add(Me.ltbName)
        Me.Name = "Form1"
        Me.Text = "學生成績管理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ltbName As System.Windows.Forms.ListBox
    Friend WithEvents clbName As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
