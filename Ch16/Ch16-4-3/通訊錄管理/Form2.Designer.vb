<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim 編號Label As System.Windows.Forms.Label
        Dim 姓名Label As System.Windows.Forms.Label
        Dim 地址Label As System.Windows.Forms.Label
        Dim 電話Label As System.Windows.Forms.Label
        Dim 生日Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim 薪水Label As System.Windows.Forms.Label
        Me.通訊錄DataSet = New 通訊錄管理.通訊錄DataSet()
        Me.通訊錄BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.通訊錄TableAdapter = New 通訊錄管理.通訊錄DataSetTableAdapters.通訊錄TableAdapter()
        Me.TableAdapterManager = New 通訊錄管理.通訊錄DataSetTableAdapters.TableAdapterManager()
        Me.通訊錄BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.通訊錄BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.編號TextBox = New System.Windows.Forms.TextBox()
        Me.姓名TextBox = New System.Windows.Forms.TextBox()
        Me.地址TextBox = New System.Windows.Forms.TextBox()
        Me.電話TextBox = New System.Windows.Forms.TextBox()
        Me.生日DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.薪水TextBox = New System.Windows.Forms.TextBox()
        編號Label = New System.Windows.Forms.Label()
        姓名Label = New System.Windows.Forms.Label()
        地址Label = New System.Windows.Forms.Label()
        電話Label = New System.Windows.Forms.Label()
        生日Label = New System.Windows.Forms.Label()
        薪水Label = New System.Windows.Forms.Label()
        CType(Me.通訊錄DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.通訊錄BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.通訊錄BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.通訊錄BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '編號Label
        '
        編號Label.AutoSize = True
        編號Label.Location = New System.Drawing.Point(23, 42)
        編號Label.Name = "編號Label"
        編號Label.Size = New System.Drawing.Size(32, 12)
        編號Label.TabIndex = 1
        編號Label.Text = "編號:"
        '
        '姓名Label
        '
        姓名Label.AutoSize = True
        姓名Label.Location = New System.Drawing.Point(23, 70)
        姓名Label.Name = "姓名Label"
        姓名Label.Size = New System.Drawing.Size(32, 12)
        姓名Label.TabIndex = 3
        姓名Label.Text = "姓名:"
        '
        '地址Label
        '
        地址Label.AutoSize = True
        地址Label.Location = New System.Drawing.Point(23, 98)
        地址Label.Name = "地址Label"
        地址Label.Size = New System.Drawing.Size(32, 12)
        地址Label.TabIndex = 5
        地址Label.Text = "地址:"
        '
        '電話Label
        '
        電話Label.AutoSize = True
        電話Label.Location = New System.Drawing.Point(23, 126)
        電話Label.Name = "電話Label"
        電話Label.Size = New System.Drawing.Size(32, 12)
        電話Label.TabIndex = 7
        電話Label.Text = "電話:"
        '
        '生日Label
        '
        生日Label.AutoSize = True
        生日Label.Location = New System.Drawing.Point(23, 155)
        生日Label.Name = "生日Label"
        生日Label.Size = New System.Drawing.Size(32, 12)
        生日Label.TabIndex = 9
        生日Label.Text = "生日:"
        '
        '通訊錄DataSet
        '
        Me.通訊錄DataSet.DataSetName = "通訊錄DataSet"
        Me.通訊錄DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '通訊錄BindingSource
        '
        Me.通訊錄BindingSource.DataMember = "通訊錄"
        Me.通訊錄BindingSource.DataSource = Me.通訊錄DataSet
        '
        '通訊錄TableAdapter
        '
        Me.通訊錄TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 通訊錄管理.通訊錄DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.通訊錄TableAdapter = Me.通訊錄TableAdapter
        '
        '通訊錄BindingNavigator
        '
        Me.通訊錄BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.通訊錄BindingNavigator.BindingSource = Me.通訊錄BindingSource
        Me.通訊錄BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.通訊錄BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.通訊錄BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.通訊錄BindingNavigatorSaveItem})
        Me.通訊錄BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.通訊錄BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.通訊錄BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.通訊錄BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.通訊錄BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.通訊錄BindingNavigator.Name = "通訊錄BindingNavigator"
        Me.通訊錄BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.通訊錄BindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.通訊錄BindingNavigator.TabIndex = 0
        Me.通訊錄BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "加入新的"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "刪除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "移到最前面"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一個"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "目前的位置"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一個"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "移到最後面"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        '通訊錄BindingNavigatorSaveItem
        '
        Me.通訊錄BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.通訊錄BindingNavigatorSaveItem.Image = CType(resources.GetObject("通訊錄BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.通訊錄BindingNavigatorSaveItem.Name = "通訊錄BindingNavigatorSaveItem"
        Me.通訊錄BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.通訊錄BindingNavigatorSaveItem.Text = "儲存資料"
        '
        '編號TextBox
        '
        Me.編號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.通訊錄BindingSource, "編號", True))
        Me.編號TextBox.Location = New System.Drawing.Point(61, 39)
        Me.編號TextBox.Name = "編號TextBox"
        Me.編號TextBox.Size = New System.Drawing.Size(200, 22)
        Me.編號TextBox.TabIndex = 2
        '
        '姓名TextBox
        '
        Me.姓名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.通訊錄BindingSource, "姓名", True))
        Me.姓名TextBox.Location = New System.Drawing.Point(61, 67)
        Me.姓名TextBox.Name = "姓名TextBox"
        Me.姓名TextBox.Size = New System.Drawing.Size(200, 22)
        Me.姓名TextBox.TabIndex = 4
        '
        '地址TextBox
        '
        Me.地址TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.通訊錄BindingSource, "地址", True))
        Me.地址TextBox.Location = New System.Drawing.Point(61, 95)
        Me.地址TextBox.Name = "地址TextBox"
        Me.地址TextBox.Size = New System.Drawing.Size(200, 22)
        Me.地址TextBox.TabIndex = 6
        '
        '電話TextBox
        '
        Me.電話TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.通訊錄BindingSource, "電話", True))
        Me.電話TextBox.Location = New System.Drawing.Point(61, 123)
        Me.電話TextBox.Name = "電話TextBox"
        Me.電話TextBox.Size = New System.Drawing.Size(200, 22)
        Me.電話TextBox.TabIndex = 8
        '
        '生日DateTimePicker
        '
        Me.生日DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.通訊錄BindingSource, "生日", True))
        Me.生日DateTimePicker.Location = New System.Drawing.Point(61, 151)
        Me.生日DateTimePicker.Name = "生日DateTimePicker"
        Me.生日DateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.生日DateTimePicker.TabIndex = 10
        '
        '薪水Label
        '
        薪水Label.AutoSize = True
        薪水Label.Location = New System.Drawing.Point(23, 186)
        薪水Label.Name = "薪水Label"
        薪水Label.Size = New System.Drawing.Size(32, 12)
        薪水Label.TabIndex = 11
        薪水Label.Text = "薪水:"
        '
        '薪水TextBox
        '
        Me.薪水TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.通訊錄BindingSource, "薪水", True))
        Me.薪水TextBox.Location = New System.Drawing.Point(61, 183)
        Me.薪水TextBox.Name = "薪水TextBox"
        Me.薪水TextBox.Size = New System.Drawing.Size(100, 22)
        Me.薪水TextBox.TabIndex = 12
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 222)
        Me.Controls.Add(薪水Label)
        Me.Controls.Add(Me.薪水TextBox)
        Me.Controls.Add(編號Label)
        Me.Controls.Add(Me.編號TextBox)
        Me.Controls.Add(姓名Label)
        Me.Controls.Add(Me.姓名TextBox)
        Me.Controls.Add(地址Label)
        Me.Controls.Add(Me.地址TextBox)
        Me.Controls.Add(電話Label)
        Me.Controls.Add(Me.電話TextBox)
        Me.Controls.Add(生日Label)
        Me.Controls.Add(Me.生日DateTimePicker)
        Me.Controls.Add(Me.通訊錄BindingNavigator)
        Me.Name = "Form2"
        Me.Text = "單筆編輯"
        CType(Me.通訊錄DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.通訊錄BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.通訊錄BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.通訊錄BindingNavigator.ResumeLayout(False)
        Me.通訊錄BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 通訊錄DataSet As 通訊錄管理.通訊錄DataSet
    Friend WithEvents 通訊錄BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 通訊錄TableAdapter As 通訊錄管理.通訊錄DataSetTableAdapters.通訊錄TableAdapter
    Friend WithEvents TableAdapterManager As 通訊錄管理.通訊錄DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 通訊錄BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 通訊錄BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents 編號TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 姓名TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 地址TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 電話TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 生日DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents 薪水TextBox As System.Windows.Forms.TextBox
End Class
