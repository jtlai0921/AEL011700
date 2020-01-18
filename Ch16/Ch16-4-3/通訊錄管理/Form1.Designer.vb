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
        Me.通訊錄DataSet = New 通訊錄管理.通訊錄DataSet()
        Me.通訊錄BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.通訊錄TableAdapter = New 通訊錄管理.通訊錄DataSetTableAdapters.通訊錄TableAdapter()
        Me.TableAdapterManager = New 通訊錄管理.通訊錄DataSetTableAdapters.TableAdapterManager()
        Me.通訊錄BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsbRecord = New System.Windows.Forms.ToolStripButton()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.薪水 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.通訊錄DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.通訊錄BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.通訊錄BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.通訊錄BindingNavigator.SuspendLayout()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.通訊錄BindingNavigator.AddNewItem = Nothing
        Me.通訊錄BindingNavigator.BindingSource = Me.通訊錄BindingSource
        Me.通訊錄BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.通訊錄BindingNavigator.DeleteItem = Nothing
        Me.通訊錄BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tlsbRecord})
        Me.通訊錄BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.通訊錄BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.通訊錄BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.通訊錄BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.通訊錄BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.通訊錄BindingNavigator.Name = "通訊錄BindingNavigator"
        Me.通訊錄BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.通訊錄BindingNavigator.Size = New System.Drawing.Size(484, 25)
        Me.通訊錄BindingNavigator.TabIndex = 0
        Me.通訊錄BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
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
        'tlsbRecord
        '
        Me.tlsbRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlsbRecord.Image = CType(resources.GetObject("tlsbRecord.Image"), System.Drawing.Image)
        Me.tlsbRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbRecord.Name = "tlsbRecord"
        Me.tlsbRecord.Size = New System.Drawing.Size(60, 22)
        Me.tlsbRecord.Text = "單筆編輯"
        '
        'dgvOutput
        '
        Me.dgvOutput.AllowUserToAddRows = False
        Me.dgvOutput.AllowUserToDeleteRows = False
        Me.dgvOutput.AutoGenerateColumns = False
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.薪水})
        Me.dgvOutput.DataSource = Me.通訊錄BindingSource
        Me.dgvOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOutput.Location = New System.Drawing.Point(0, 25)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.ReadOnly = True
        Me.dgvOutput.RowTemplate.Height = 24
        Me.dgvOutput.Size = New System.Drawing.Size(484, 237)
        Me.dgvOutput.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "編號"
        Me.DataGridViewTextBoxColumn1.HeaderText = "編號"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "姓名"
        Me.DataGridViewTextBoxColumn2.HeaderText = "姓名"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "地址"
        Me.DataGridViewTextBoxColumn3.HeaderText = "地址"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "電話"
        Me.DataGridViewTextBoxColumn4.HeaderText = "電話"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "生日"
        Me.DataGridViewTextBoxColumn5.HeaderText = "生日"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        '薪水
        '
        Me.薪水.DataPropertyName = "薪水"
        Me.薪水.HeaderText = "薪水"
        Me.薪水.Name = "薪水"
        Me.薪水.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.通訊錄BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "通訊錄管理"
        CType(Me.通訊錄DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.通訊錄BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.通訊錄BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.通訊錄BindingNavigator.ResumeLayout(False)
        Me.通訊錄BindingNavigator.PerformLayout()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 通訊錄DataSet As 通訊錄管理.通訊錄DataSet
    Friend WithEvents 通訊錄BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 通訊錄TableAdapter As 通訊錄管理.通訊錄DataSetTableAdapters.通訊錄TableAdapter
    Friend WithEvents TableAdapterManager As 通訊錄管理.通訊錄DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 通訊錄BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsbRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvOutput As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 薪水 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
