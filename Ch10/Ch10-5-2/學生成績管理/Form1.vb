Public Class Form1

    ' 宣告一維陣列
    Dim MidTerm() As Integer = {70, 79, 65, 98, 60}
    Dim Final() As Integer = {60, 89, 75, 68, 90}

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       Dim index As Integer
        index = cboName.SelectedIndex ' 取得索引
        If index >= 0 And index <= cboName.Items.Count - 1 Then
            ' 顯示查詢結果
            txtMidTerm.Text = MidTerm(index)
            txtFinal.Text = Final(index)
        Else
            MsgBox("查詢的學號錯誤!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cboName.Items.IndexOf(cboName.Text) = -1 Then
            Dim MaxIndex As Integer
            cboName.Items.Add(cboName.Text)
            MaxIndex = cboName.Items.Count - 1   ' 最大索引值加一
            ' 調整陣列尺寸
            ReDim Preserve MidTerm(MaxIndex)
            ReDim Preserve Final(MaxIndex)
            ' 指定新元素值
            MidTerm(MaxIndex) = CInt(txtMidTerm.Text)
            Final(MaxIndex) = CInt(txtFinal.Text)
            MsgBox("成功新增一筆學生資料!")
        Else
            MsgBox("學生姓名已經存在!")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' 取得更新學生的索引
        Dim index As Integer = cboName.SelectedIndex
        If index >= 0 And index <= cboName.Items.Count - 1 Then
            '更新學生資料
            MidTerm(index) = CInt(txtMidTerm.Text)
            Final(index) = CInt(txtFinal.Text)
            MsgBox("成功更新一筆學生資料!")
        Else
            MsgBox("更新的學號錯誤!")
        End If
    End Sub
End Class
