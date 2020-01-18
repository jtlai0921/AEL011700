Public Class Form1

    Dim strSelectedText As String

    Private Sub mnuItemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemExit.Click
        End
    End Sub

    Private Sub mnuItemInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemInput.Click
        If mnuItemInput.Checked Then
            txtNote.ReadOnly = True   ' 關
            mnuItemInput.Checked = False
        Else
            txtNote.ReadOnly = False  ' 開
            mnuItemInput.Checked = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNote.ReadOnly = False
        txtNote.SelectionStart = 0
        txtNote.SelectionLength = 0
        txtNote.Focus()
    End Sub

    Private Sub mnuItemCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemCut.Click
        Dim strLeft, strRight As String
        Dim str As String = txtNote.Text
        Dim length, pos As Integer
        strSelectedText = txtNote.SelectedText  ' 取得選取的內容
        length = Len(strSelectedText)           ' 選取內容的長度
        pos = txtNote.SelectionStart            ' 選取的位置
        ' 選取位置的左邊字串
        strLeft = Mid(str, 1, pos)
        ' 剪下文字內容的右邊字串
        strRight = Mid(str, pos + length + 1)
        ' 刪除選取的內容
        txtNote.Text = strLeft & strRight
    End Sub

    Private Sub mnuItemCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemCopy.Click
        strSelectedText = txtNote.SelectedText  ' 保留選取的內容
    End Sub

    Private Sub mnuItemPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemPaste.Click
        Dim strLeft, strRight As String
        Dim pos As Integer
        Dim str As String = txtNote.Text
        pos = txtNote.SelectionStart
        strLeft = Mid(str, 1, pos)
        strRight = Mid(str, pos + 1)
        ' 貼上剪貼簿的內容
        txtNote.Text = strLeft & strSelectedText & strRight
    End Sub
End Class
