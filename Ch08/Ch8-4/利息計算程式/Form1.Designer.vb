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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtHighInterest = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLowInterest = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLongYears = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtShortYears = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(17, 100)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(254, 144)
        Me.txtOutput.TabIndex = 23
        Me.txtOutput.WordWrap = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 21)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtHighInterest
        '
        Me.txtHighInterest.Location = New System.Drawing.Point(214, 76)
        Me.txtHighInterest.Name = "txtHighInterest"
        Me.txtHighInterest.Size = New System.Drawing.Size(57, 22)
        Me.txtHighInterest.TabIndex = 21
        Me.txtHighInterest.Text = "18"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "最高利率:"
        '
        'txtLowInterest
        '
        Me.txtLowInterest.Location = New System.Drawing.Point(78, 76)
        Me.txtLowInterest.Name = "txtLowInterest"
        Me.txtLowInterest.Size = New System.Drawing.Size(61, 22)
        Me.txtLowInterest.TabIndex = 19
        Me.txtLowInterest.Text = "12"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 12)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "最低利率:"
        '
        'txtLongYears
        '
        Me.txtLongYears.Location = New System.Drawing.Point(214, 52)
        Me.txtLongYears.Name = "txtLongYears"
        Me.txtLongYears.Size = New System.Drawing.Size(57, 22)
        Me.txtLongYears.TabIndex = 17
        Me.txtLongYears.Text = "10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "最長年限:"
        '
        'txtShortYears
        '
        Me.txtShortYears.Location = New System.Drawing.Point(78, 52)
        Me.txtShortYears.Name = "txtShortYears"
        Me.txtShortYears.Size = New System.Drawing.Size(61, 22)
        Me.txtShortYears.TabIndex = 15
        Me.txtShortYears.Text = "5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "最短年限:"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(78, 21)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(126, 22)
        Me.txtPrincipal.TabIndex = 13
        Me.txtPrincipal.Text = "500000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "金額:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtHighInterest)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLowInterest)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLongYears)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtShortYears)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "利息計算程式"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtHighInterest As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLowInterest As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLongYears As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtShortYears As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
