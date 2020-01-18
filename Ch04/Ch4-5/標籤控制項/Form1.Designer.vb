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
        Me.lblSource = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(41, 35)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(110, 12)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "Visual Basic程式設計"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "複製"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.ForeColor = System.Drawing.SystemColors.Control
        Me.lblResult.Location = New System.Drawing.Point(12, 70)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(260, 83)
        Me.lblResult.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblSource)
        Me.Name = "Form1"
        Me.Text = "標籤控制項"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
