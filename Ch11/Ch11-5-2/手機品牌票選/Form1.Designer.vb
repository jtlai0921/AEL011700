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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHTC = New System.Windows.Forms.TextBox()
        Me.txtSamsung = New System.Windows.Forms.TextBox()
        Me.txtNokia = New System.Windows.Forms.TextBox()
        Me.txtSony = New System.Windows.Forms.TextBox()
        Me.txtMoto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbHTC = New System.Windows.Forms.RadioButton()
        Me.rdbSamsung = New System.Windows.Forms.RadioButton()
        Me.rdbNokia = New System.Windows.Forms.RadioButton()
        Me.rdbSony = New System.Windows.Forms.RadioButton()
        Me.rdbMoto = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.ltbName.Size = New System.Drawing.Size(161, 64)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHTC)
        Me.GroupBox2.Controls.Add(Me.txtSamsung)
        Me.GroupBox2.Controls.Add(Me.txtNokia)
        Me.GroupBox2.Controls.Add(Me.txtSony)
        Me.GroupBox2.Controls.Add(Me.txtMoto)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(77, 182)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "目前票數"
        '
        'txtHTC
        '
        Me.txtHTC.Location = New System.Drawing.Point(9, 149)
        Me.txtHTC.Name = "txtHTC"
        Me.txtHTC.ReadOnly = True
        Me.txtHTC.Size = New System.Drawing.Size(57, 22)
        Me.txtHTC.TabIndex = 4
        Me.txtHTC.Text = "0"
        Me.txtHTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSamsung
        '
        Me.txtSamsung.Location = New System.Drawing.Point(9, 118)
        Me.txtSamsung.Name = "txtSamsung"
        Me.txtSamsung.ReadOnly = True
        Me.txtSamsung.Size = New System.Drawing.Size(57, 22)
        Me.txtSamsung.TabIndex = 3
        Me.txtSamsung.Text = "0"
        Me.txtSamsung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNokia
        '
        Me.txtNokia.Location = New System.Drawing.Point(9, 86)
        Me.txtNokia.Name = "txtNokia"
        Me.txtNokia.ReadOnly = True
        Me.txtNokia.Size = New System.Drawing.Size(57, 22)
        Me.txtNokia.TabIndex = 2
        Me.txtNokia.Text = "0"
        Me.txtNokia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSony
        '
        Me.txtSony.Location = New System.Drawing.Point(9, 53)
        Me.txtSony.Name = "txtSony"
        Me.txtSony.ReadOnly = True
        Me.txtSony.Size = New System.Drawing.Size(57, 22)
        Me.txtSony.TabIndex = 1
        Me.txtSony.Text = "0"
        Me.txtSony.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMoto
        '
        Me.txtMoto.Location = New System.Drawing.Point(9, 21)
        Me.txtMoto.Name = "txtMoto"
        Me.txtMoto.ReadOnly = True
        Me.txtMoto.Size = New System.Drawing.Size(57, 22)
        Me.txtMoto.TabIndex = 0
        Me.txtMoto.Text = "0"
        Me.txtMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbHTC)
        Me.GroupBox1.Controls.Add(Me.rdbSamsung)
        Me.GroupBox1.Controls.Add(Me.rdbNokia)
        Me.GroupBox1.Controls.Add(Me.rdbSony)
        Me.GroupBox1.Controls.Add(Me.rdbMoto)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 183)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "選擇手機品牌"
        '
        'rdbHTC
        '
        Me.rdbHTC.AutoSize = True
        Me.rdbHTC.Location = New System.Drawing.Point(16, 157)
        Me.rdbHTC.Name = "rdbHTC"
        Me.rdbHTC.Size = New System.Drawing.Size(70, 16)
        Me.rdbHTC.TabIndex = 4
        Me.rdbHTC.Text = "HTC宏達"
        Me.rdbHTC.UseVisualStyleBackColor = True
        '
        'rdbSamsung
        '
        Me.rdbSamsung.AutoSize = True
        Me.rdbSamsung.Location = New System.Drawing.Point(16, 126)
        Me.rdbSamsung.Name = "rdbSamsung"
        Me.rdbSamsung.Size = New System.Drawing.Size(89, 16)
        Me.rdbSamsung.TabIndex = 3
        Me.rdbSamsung.Text = "Samsung三星"
        Me.rdbSamsung.UseVisualStyleBackColor = True
        '
        'rdbNokia
        '
        Me.rdbNokia.AutoSize = True
        Me.rdbNokia.Location = New System.Drawing.Point(16, 94)
        Me.rdbNokia.Name = "rdbNokia"
        Me.rdbNokia.Size = New System.Drawing.Size(87, 16)
        Me.rdbNokia.TabIndex = 2
        Me.rdbNokia.Text = "Nokia諾基亞"
        Me.rdbNokia.UseVisualStyleBackColor = True
        '
        'rdbSony
        '
        Me.rdbSony.AutoSize = True
        Me.rdbSony.Location = New System.Drawing.Point(16, 61)
        Me.rdbSony.Name = "rdbSony"
        Me.rdbSony.Size = New System.Drawing.Size(150, 16)
        Me.rdbSony.TabIndex = 1
        Me.rdbSony.Text = "SonyErricsson新力易利信"
        Me.rdbSony.UseVisualStyleBackColor = True
        '
        'rdbMoto
        '
        Me.rdbMoto.AutoSize = True
        Me.rdbMoto.Location = New System.Drawing.Point(16, 29)
        Me.rdbMoto.Name = "rdbMoto"
        Me.rdbMoto.Size = New System.Drawing.Size(114, 16)
        Me.rdbMoto.TabIndex = 0
        Me.rdbMoto.Text = "Motorola摩托羅拉"
        Me.rdbMoto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 312)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblButton)
        Me.Controls.Add(Me.ltbName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "手機品牌票選"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblButton As System.Windows.Forms.Label
    Friend WithEvents ltbName As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHTC As System.Windows.Forms.TextBox
    Friend WithEvents txtSamsung As System.Windows.Forms.TextBox
    Friend WithEvents txtNokia As System.Windows.Forms.TextBox
    Friend WithEvents txtSony As System.Windows.Forms.TextBox
    Friend WithEvents txtMoto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbHTC As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSamsung As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNokia As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSony As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMoto As System.Windows.Forms.RadioButton

End Class
