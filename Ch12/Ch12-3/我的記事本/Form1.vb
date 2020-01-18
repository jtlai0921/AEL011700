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
        strSelectedText = txtNote.SelectedText  ' 取得選取內容
        ' 呼叫strCut()函數
        txtNote.Text = strCut(txtNote.Text, txtNote.SelectionStart, Len(strSelectedText))
    End Sub

    Private Sub mnuItemCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemCopy.Click
        strSelectedText = txtNote.SelectedText  ' 保留選取的內容
    End Sub

    Private Sub mnuItemPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemPaste.Click
       ' 呼叫strPaste()函數
        txtNote.Text = strPaste(txtNote.Text, strSelectedText, txtNote.SelectionStart)
    End Sub

    Private Sub cmnuItemCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuItemCut.Click
        strSelectedText = txtNote.SelectedText  ' 取得選取內容
        ' 呼叫strCut()函數
        txtNote.Text = strCut(txtNote.Text, txtNote.SelectionStart, Len(strSelectedText))
    End Sub

    Private Sub cmnuItemCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuItemCopy.Click
        strSelectedText = txtNote.SelectedText  ' 保留選取的內容
    End Sub

    Private Sub cmnuItemPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuItemPaste.Click
        ' 呼叫strPaste()函數
        txtNote.Text = strPaste(txtNote.Text, strSelectedText, txtNote.SelectionStart)
    End Sub

    Function strCut(ByVal str As String, ByVal pos As Integer, ByVal length As Integer) As String
        Dim strLeft, strRight As String
        ' 選取位置的左邊字串
        strLeft = Mid(str, 1, pos)
        ' 剪下文字內容的右邊字串
        strRight = Mid(str, pos + length + 1)
        ' 刪除選取的內容
        Return strLeft & strRight
    End Function

    Function strPaste(ByVal str As String, ByVal selectedText As String, ByVal pos As Integer) As String
        Dim strLeft, strRight As String
        strLeft = Mid(str, 1, pos)
        strRight = Mid(str, pos + 1)
        Return strLeft & selectedText & strRight
    End Function

    Private Sub tlsbCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsbCut.Click
        strSelectedText = txtNote.SelectedText  ' 取得選取內容
        txtNote.Text = strCut(txtNote.Text, txtNote.SelectionStart, Len(strSelectedText))
    End Sub

    Private Sub tlsbCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsbCopy.Click
        strSelectedText = txtNote.SelectedText  ' 保留選取的內容
    End Sub

    Private Sub tlsbPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsbPaste.Click
        txtNote.Text = strPaste(txtNote.Text, strSelectedText, txtNote.SelectionStart)
    End Sub

    Private Sub tlsbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsbSearch.Click
        Dim pos As Integer
        pos = InStr(1, txtNote.Text, tlstSearch.Text)
        If pos > 0 Then ' 找到
            txtNote.SelectionStart = pos - 1
            txtNote.SelectionLength = Len(tlstSearch.Text)
            txtNote.Focus()  ' 取得焦點
        End If
    End Sub
End Class
