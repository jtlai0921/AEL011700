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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOutput.Location = New System.Drawing.Point(21, 164)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(301, 41)
        Me.lblOutput.TabIndex = 25
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(220, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 42)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "計算BMI"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(67, 134)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtWeight.TabIndex = 23
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(67, 105)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 22)
        Me.txtHeight.TabIndex = 22
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 12)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "體重:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "身高:"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(8, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 9)
        Me.Label3.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(135, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 21)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(220, 30)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(102, 22)
        Me.txtC.TabIndex = 16
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(20, 30)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(102, 22)
        Me.txtF.TabIndex = 15
        Me.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "攝氏（Celsius）"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "華氏（Fahrenheit）"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 212)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "多功能計算機"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
