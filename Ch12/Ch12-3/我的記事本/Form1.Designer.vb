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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuItemSend = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemEmail = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemNote = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemDraw = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemInput = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuItemCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuItemCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuItemPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsEdit = New System.Windows.Forms.ToolStrip()
        Me.tlsbCut = New System.Windows.Forms.ToolStripButton()
        Me.tlsbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tlsbPaste = New System.Windows.Forms.ToolStripButton()
        Me.tlssOne = New System.Windows.Forms.ToolStripSeparator()
        Me.tlstSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.tlsbSearch = New System.Windows.Forms.ToolStripButton()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.mnuMain.SuspendLayout()
        Me.mnuEdit.SuspendLayout()
        Me.tlsEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemFile, Me.mnuItemEdit})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(384, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuItemFile
        '
        Me.mnuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemOpen, Me.mnuItemSave, Me.mnuItemSeparator, Me.mnuItemSend, Me.mnuItemInput, Me.mnuItemExit})
        Me.mnuItemFile.Name = "mnuItemFile"
        Me.mnuItemFile.Size = New System.Drawing.Size(58, 20)
        Me.mnuItemFile.Text = "檔案(&F)"
        '
        'mnuItemOpen
        '
        Me.mnuItemOpen.Name = "mnuItemOpen"
        Me.mnuItemOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuItemOpen.Size = New System.Drawing.Size(164, 22)
        Me.mnuItemOpen.Text = "開啟(&O)"
        '
        'mnuItemSave
        '
        Me.mnuItemSave.Name = "mnuItemSave"
        Me.mnuItemSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuItemSave.Size = New System.Drawing.Size(164, 22)
        Me.mnuItemSave.Text = "儲存(&S)"
        '
        'mnuItemSeparator
        '
        Me.mnuItemSeparator.Name = "mnuItemSeparator"
        Me.mnuItemSeparator.Size = New System.Drawing.Size(161, 6)
        '
        'mnuItemSend
        '
        Me.mnuItemSend.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemEmail, Me.mnuItemNote, Me.mnuItemDraw})
        Me.mnuItemSend.Name = "mnuItemSend"
        Me.mnuItemSend.Size = New System.Drawing.Size(164, 22)
        Me.mnuItemSend.Text = "傳送到應用程式"
        '
        'mnuItemEmail
        '
        Me.mnuItemEmail.Name = "mnuItemEmail"
        Me.mnuItemEmail.Size = New System.Drawing.Size(124, 22)
        Me.mnuItemEmail.Text = "電子郵件"
        '
        'mnuItemNote
        '
        Me.mnuItemNote.Name = "mnuItemNote"
        Me.mnuItemNote.Size = New System.Drawing.Size(124, 22)
        Me.mnuItemNote.Text = "記事本"
        '
        'mnuItemDraw
        '
        Me.mnuItemDraw.Name = "mnuItemDraw"
        Me.mnuItemDraw.Size = New System.Drawing.Size(124, 22)
        Me.mnuItemDraw.Text = "小畫家"
        '
        'mnuItemInput
        '
        Me.mnuItemInput.Checked = True
        Me.mnuItemInput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuItemInput.Name = "mnuItemInput"
        Me.mnuItemInput.Size = New System.Drawing.Size(164, 22)
        Me.mnuItemInput.Text = "允許輸入(&I)"
        '
        'mnuItemExit
        '
        Me.mnuItemExit.Name = "mnuItemExit"
        Me.mnuItemExit.Size = New System.Drawing.Size(164, 22)
        Me.mnuItemExit.Text = "離開(&X)"
        '
        'mnuItemEdit
        '
        Me.mnuItemEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemCut, Me.mnuItemCopy, Me.mnuItemPaste})
        Me.mnuItemEdit.Name = "mnuItemEdit"
        Me.mnuItemEdit.Size = New System.Drawing.Size(59, 20)
        Me.mnuItemEdit.Text = "編輯(&E)"
        '
        'mnuItemCut
        '
        Me.mnuItemCut.Name = "mnuItemCut"
        Me.mnuItemCut.Size = New System.Drawing.Size(116, 22)
        Me.mnuItemCut.Text = "剪下(&T)"
        '
        'mnuItemCopy
        '
        Me.mnuItemCopy.Name = "mnuItemCopy"
        Me.mnuItemCopy.Size = New System.Drawing.Size(116, 22)
        Me.mnuItemCopy.Text = "複製(&C)"
        '
        'mnuItemPaste
        '
        Me.mnuItemPaste.Name = "mnuItemPaste"
        Me.mnuItemPaste.Size = New System.Drawing.Size(116, 22)
        Me.mnuItemPaste.Text = "貼上(&P)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuItemCut, Me.cmnuItemCopy, Me.cmnuItemPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(101, 70)
        '
        'cmnuItemCut
        '
        Me.cmnuItemCut.Name = "cmnuItemCut"
        Me.cmnuItemCut.Size = New System.Drawing.Size(152, 22)
        Me.cmnuItemCut.Text = "剪下"
        '
        'cmnuItemCopy
        '
        Me.cmnuItemCopy.Name = "cmnuItemCopy"
        Me.cmnuItemCopy.Size = New System.Drawing.Size(152, 22)
        Me.cmnuItemCopy.Text = "複製"
        '
        'cmnuItemPaste
        '
        Me.cmnuItemPaste.Name = "cmnuItemPaste"
        Me.cmnuItemPaste.Size = New System.Drawing.Size(152, 22)
        Me.cmnuItemPaste.Text = "貼上"
        '
        'tlsEdit
        '
        Me.tlsEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsbCut, Me.tlsbCopy, Me.tlsbPaste, Me.tlssOne, Me.tlstSearch, Me.tlsbSearch})
        Me.tlsEdit.Location = New System.Drawing.Point(0, 24)
        Me.tlsEdit.Name = "tlsEdit"
        Me.tlsEdit.Size = New System.Drawing.Size(384, 25)
        Me.tlsEdit.TabIndex = 2
        Me.tlsEdit.Text = "編輯"
        '
        'tlsbCut
        '
        Me.tlsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsbCut.Image = CType(resources.GetObject("tlsbCut.Image"), System.Drawing.Image)
        Me.tlsbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbCut.Name = "tlsbCut"
        Me.tlsbCut.Size = New System.Drawing.Size(23, 22)
        Me.tlsbCut.Text = "剪下"
        '
        'tlsbCopy
        '
        Me.tlsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsbCopy.Image = CType(resources.GetObject("tlsbCopy.Image"), System.Drawing.Image)
        Me.tlsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbCopy.Name = "tlsbCopy"
        Me.tlsbCopy.Size = New System.Drawing.Size(23, 22)
        Me.tlsbCopy.Text = "ToolStripButton1"
        Me.tlsbCopy.ToolTipText = "複製"
        '
        'tlsbPaste
        '
        Me.tlsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsbPaste.Image = CType(resources.GetObject("tlsbPaste.Image"), System.Drawing.Image)
        Me.tlsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbPaste.Name = "tlsbPaste"
        Me.tlsbPaste.Size = New System.Drawing.Size(23, 22)
        Me.tlsbPaste.Text = "ToolStripButton1"
        Me.tlsbPaste.ToolTipText = "貼上"
        '
        'tlssOne
        '
        Me.tlssOne.Name = "tlssOne"
        Me.tlssOne.Size = New System.Drawing.Size(6, 25)
        '
        'tlstSearch
        '
        Me.tlstSearch.Name = "tlstSearch"
        Me.tlstSearch.Size = New System.Drawing.Size(100, 25)
        Me.tlstSearch.Text = "VBE"
        '
        'tlsbSearch
        '
        Me.tlsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlsbSearch.Image = CType(resources.GetObject("tlsbSearch.Image"), System.Drawing.Image)
        Me.tlsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbSearch.Name = "tlsbSearch"
        Me.tlsbSearch.Size = New System.Drawing.Size(36, 22)
        Me.tlsbSearch.Text = "搜尋"
        '
        'txtNote
        '
        Me.txtNote.ContextMenuStrip = Me.mnuEdit
        Me.txtNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNote.Font = New System.Drawing.Font("新細明體", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtNote.Location = New System.Drawing.Point(0, 49)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNote.Size = New System.Drawing.Size(384, 163)
        Me.txtNote.TabIndex = 3
        Me.txtNote.Text = "在VBE開啟「工具箱」視窗後，可以在【功能表與工具列】區段看到建立功能表所需的MenuStrip控制項。VBE可以直接在表單設計工具上新增MenuStrip功能表" & _
            "控制項，並且編輯其選項和子選單。"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 212)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.tlsEdit)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "Form1"
        Me.Text = "我的記事本"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.mnuEdit.ResumeLayout(False)
        Me.tlsEdit.ResumeLayout(False)
        Me.tlsEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuItemSend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemEmail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemNote As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemDraw As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemInput As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuItemCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuItemCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuItemPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsEdit As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsbCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsbCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsbPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlssOne As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlsbSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNote As System.Windows.Forms.TextBox

End Class
