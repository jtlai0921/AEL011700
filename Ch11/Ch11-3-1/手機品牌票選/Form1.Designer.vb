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
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblButton = New System.Windows.Forms.Label()
        Me.ltbName = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(186, 57)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(95, 22)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "總投票人數:"
        '
        'lblButton
        '
        Me.lblButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblButton.Location = New System.Drawing.Point(186, 11)
        Me.lblButton.Name = "lblButton"
        Me.lblButton.Size = New System.Drawing.Size(95, 21)
        Me.lblButton.TabIndex = 9
        Me.lblButton.Text = "參與投票"
        Me.lblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ltbName
        '
        Me.ltbName.FormattingEnabled = True
        Me.ltbName.ItemHeight = 12
        Me.ltbName.Location = New System.Drawing.Point(16, 42)
        Me.ltbName.Name = "ltbName"
        Me.ltbName.Size = New System.Drawing.Size(161, 100)
        Me.ltbName.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(68, 14)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(109, 22)
        Me.txtName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "輸入姓名:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 152)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblButton)
        Me.Controls.Add(Me.ltbName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "手機品牌票選"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblButton As System.Windows.Forms.Label
    Friend WithEvents ltbName As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
