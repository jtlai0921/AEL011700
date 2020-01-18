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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuItemPen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuItemSolid = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemTexture = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemMethod = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemMethod, Me.mnuItemPen})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(334, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuItemPen
        '
        Me.mnuItemPen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemRed, Me.mnuItemGreen, Me.mnuItemBlue, Me.mnuItemSeparator, Me.mnuItemSolid, Me.mnuItemTexture})
        Me.mnuItemPen.Name = "mnuItemPen"
        Me.mnuItemPen.Size = New System.Drawing.Size(88, 20)
        Me.mnuItemPen.Text = "畫筆/筆刷(&P)"
        '
        'mnuItemRed
        '
        Me.mnuItemRed.Checked = True
        Me.mnuItemRed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuItemRed.Name = "mnuItemRed"
        Me.mnuItemRed.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemRed.Text = "紅色畫筆"
        '
        'mnuItemGreen
        '
        Me.mnuItemGreen.Name = "mnuItemGreen"
        Me.mnuItemGreen.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemGreen.Text = "綠色畫筆"
        '
        'mnuItemBlue
        '
        Me.mnuItemBlue.Name = "mnuItemBlue"
        Me.mnuItemBlue.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemBlue.Text = "藍色畫筆"
        '
        'mnuItemSeparator
        '
        Me.mnuItemSeparator.Name = "mnuItemSeparator"
        Me.mnuItemSeparator.Size = New System.Drawing.Size(149, 6)
        '
        'mnuItemSolid
        '
        Me.mnuItemSolid.Checked = True
        Me.mnuItemSolid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuItemSolid.Name = "mnuItemSolid"
        Me.mnuItemSolid.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemSolid.Text = "色彩筆刷"
        '
        'mnuItemTexture
        '
        Me.mnuItemTexture.Name = "mnuItemTexture"
        Me.mnuItemTexture.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemTexture.Text = "圖片筆刷"
        '
        'mnuItemMethod
        '
        Me.mnuItemMethod.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemLine, Me.mnuItemText})
        Me.mnuItemMethod.Name = "mnuItemMethod"
        Me.mnuItemMethod.Size = New System.Drawing.Size(88, 20)
        Me.mnuItemMethod.Text = "繪圖方法(&M)"
        '
        'mnuItemLine
        '
        Me.mnuItemLine.Checked = True
        Me.mnuItemLine.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuItemLine.Name = "mnuItemLine"
        Me.mnuItemLine.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemLine.Text = "畫線"
        '
        'mnuItemText
        '
        Me.mnuItemText.Name = "mnuItemText"
        Me.mnuItemText.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemText.Text = "繪出文字"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 212)
        Me.Controls.Add(Me.mnuMain)
        Me.Name = "Form1"
        Me.Text = "我的小畫家"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuItemPen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemRed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemGreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuItemSolid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemTexture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemMethod As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemLine As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemText As System.Windows.Forms.ToolStripMenuItem

End Class
