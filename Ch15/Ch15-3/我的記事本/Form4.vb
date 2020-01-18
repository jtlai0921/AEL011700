Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pos As Integer
        ' 搜尋字串
        pos = InStr(1, Form1.txtNote.Text, txtSearch.Text)
        If pos > 0 Then
            Form1.txtNote.SelectionStart = pos - 1
            Form1.txtNote.SelectionLength = Len(txtSearch.Text)
            Form1.txtNote.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pos As Integer
        ' 搜尋字串
        pos = InStr(1, Form1.txtNote.Text, txtSearch.Text)
        If pos > 0 Then ' 找到
            ' 取代字串
            Form1.txtNote.Text = Replace(Form1.txtNote.Text, txtSearch.Text, txtReplace.Text)
            ' 重設選取的文字範圍
            Form1.txtNote.SelectionStart = Len(Form1.txtNote.Text)
            Form1.txtNote.SelectionLength = 0
            Form1.txtNote.Focus()
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Text = Form1.strSearch ' 預設字串
        ' 設定焦點
        txtSearch.SelectionStart = Len(Form1.strSearch)
        txtSearch.SelectionLength = 0
        txtSearch.Focus()
    End Sub
End Class