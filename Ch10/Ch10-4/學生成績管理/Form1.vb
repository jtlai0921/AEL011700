Public Class Form1

    ' 宣告一維陣列
    Dim Names() As String = {"陳會安", "江小魚", "陳允傑",
                             "楊過", "小龍女"}
    Dim MidTerm() As Integer = {70, 79, 65, 98, 60}
    Dim Final() As Integer = {60, 89, 75, 68, 90}
    Dim MaxIndex As Integer = 4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim index As Integer
        index = CInt(txtNo.Text) ' 取得索引
        If index >= 0 And index <= MaxIndex Then
            ' 顯示查詢結果
            txtName.Text = Names(index)
            txtMidTerm.Text = MidTerm(index)
            txtFinal.Text = Final(index)
        Else
            txtName.Text = "查詢的學號錯誤!"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MaxIndex = MaxIndex + 1   ' 最大索引值加一
        ' 調整陣列尺寸
        ReDim Preserve Names(MaxIndex)
        ReDim Preserve MidTerm(MaxIndex)
        ReDim Preserve Final(MaxIndex)
        ' 指定新元素值
        Names(MaxIndex) = txtName.Text
        MidTerm(MaxIndex) = CInt(txtMidTerm.Text)
        Final(MaxIndex) = CInt(txtFinal.Text)
        MsgBox("成功新增一筆學生資料!")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' 取得更新學生的索引
        Dim index As Integer = CInt(txtNo.Text)
        If index >= 0 And index <= MaxIndex Then
            '更新學生資料
            Names(index) = txtName.Text
            MidTerm(index) = CInt(txtMidTerm.Text)
            Final(index) = CInt(txtFinal.Text)
            MsgBox("成功更新一筆學生資料!")
        Else
            txtName.Text = "更新的學號錯誤!"
        End If
    End Sub
End Class
