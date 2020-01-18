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
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDoLoopUntil = New System.Windows.Forms.RadioButton()
        Me.rdbDoUntilLoop = New System.Windows.Forms.RadioButton()
        Me.rdbDoLoopWhile = New System.Windows.Forms.RadioButton()
        Me.rdbDoWhileLoop = New System.Windows.Forms.RadioButton()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(58, 12)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(86, 22)
        Me.txtPrincipal.TabIndex = 3
        Me.txtPrincipal.Text = "10000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "本金:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 21)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbDoLoopUntil)
        Me.GroupBox1.Controls.Add(Me.rdbDoUntilLoop)
        Me.GroupBox1.Controls.Add(Me.rdbDoLoopWhile)
        Me.GroupBox1.Controls.Add(Me.rdbDoWhileLoop)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 58)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "迴圈種類"
        '
        'rdbDoLoopUntil
        '
        Me.rdbDoLoopUntil.AutoSize = True
        Me.rdbDoLoopUntil.Location = New System.Drawing.Point(132, 37)
        Me.rdbDoLoopUntil.Name = "rdbDoLoopUntil"
        Me.rdbDoLoopUntil.Size = New System.Drawing.Size(91, 16)
        Me.rdbDoLoopUntil.TabIndex = 3
        Me.rdbDoLoopUntil.Text = "Do/Loop Until"
        Me.rdbDoLoopUntil.UseVisualStyleBackColor = True
        '
        'rdbDoUntilLoop
        '
        Me.rdbDoUntilLoop.AutoSize = True
        Me.rdbDoUntilLoop.Location = New System.Drawing.Point(132, 18)
        Me.rdbDoUntilLoop.Name = "rdbDoUntilLoop"
        Me.rdbDoUntilLoop.Size = New System.Drawing.Size(91, 16)
        Me.rdbDoUntilLoop.TabIndex = 2
        Me.rdbDoUntilLoop.Text = "Do Until/Loop"
        Me.rdbDoUntilLoop.UseVisualStyleBackColor = True
        '
        'rdbDoLoopWhile
        '
        Me.rdbDoLoopWhile.AutoSize = True
        Me.rdbDoLoopWhile.Location = New System.Drawing.Point(16, 37)
        Me.rdbDoLoopWhile.Name = "rdbDoLoopWhile"
        Me.rdbDoLoopWhile.Size = New System.Drawing.Size(96, 16)
        Me.rdbDoLoopWhile.TabIndex = 1
        Me.rdbDoLoopWhile.Text = "Do/Loop While"
        Me.rdbDoLoopWhile.UseVisualStyleBackColor = True
        '
        'rdbDoWhileLoop
        '
        Me.rdbDoWhileLoop.AutoSize = True
        Me.rdbDoWhileLoop.Checked = True
        Me.rdbDoWhileLoop.Location = New System.Drawing.Point(16, 18)
        Me.rdbDoWhileLoop.Name = "rdbDoWhileLoop"
        Me.rdbDoWhileLoop.Size = New System.Drawing.Size(96, 16)
        Me.rdbDoWhileLoop.TabIndex = 0
        Me.rdbDoWhileLoop.TabStop = True
        Me.rdbDoWhileLoop.Text = "Do While/Loop"
        Me.rdbDoWhileLoop.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(15, 112)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(254, 144)
        Me.txtOutput.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 272)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "利息計算程式"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDoLoopUntil As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDoUntilLoop As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDoLoopWhile As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDoWhileLoop As System.Windows.Forms.RadioButton
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox

End Class
