Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Text = Form1.strSearch  ' 取得預設值
        ' 設定焦點
        txtSearch.SelectionStart = Len(Form1.strSearch)
        txtSearch.SelectionLength = 0
        txtSearch.Focus()
    End Sub
End Class