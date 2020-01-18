Public Class Form2

    Private Sub 通訊錄BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 通訊錄BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.通訊錄BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.通訊錄DataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '通訊錄DataSet.通訊錄' 資料表。您可以視需要進行移動或移除。
        Me.通訊錄TableAdapter.Fill(Me.通訊錄DataSet.通訊錄)

    End Sub
End Class