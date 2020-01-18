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
        Me.txtTotalYear = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTotalYear
        '
        Me.txtTotalYear.Location = New System.Drawing.Point(66, 12)
        Me.txtTotalYear.Name = "txtTotalYear"
        Me.txtTotalYear.Size = New System.Drawing.Size(75, 22)
        Me.txtTotalYear.TabIndex = 5
        Me.txtTotalYear.Text = "5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "年限:"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(66, 46)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(78, 22)
        Me.txtRate.TabIndex = 7
        Me.txtRate.Text = "12"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "利率%:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 58)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 82)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalYear)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "利息計算程式"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotalYear As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
