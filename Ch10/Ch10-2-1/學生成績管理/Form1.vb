Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Names(4) As String   ' 宣告一維陣列
        Dim MidTerm(0 To 4) As Integer
        Dim Final = {60, 89, 75, 68, 90}
        ' 指定一維陣列的元素值
        Names(0) = "陳會安"
        Names(1) = "江小魚"
        Names(2) = "陳允傑"
        Names(3) = "楊過"
        Names(4) = "小龍女"
        MidTerm(0) = 70
        MidTerm(1) = 79
        MidTerm(2) = 65
        MidTerm(3) = 98
        MidTerm(4) = 60
        Dim index As Integer
        index = CInt(txtNo.Text) ' 取得索引
        If index >= 0 And index <= 4 Then
            ' 顯示查詢結果
            txtName.Text = Names(index)
            txtMidTerm.Text = MidTerm(index)
            txtFinal.Text = Final(index)
        Else
            txtName.Text = "學號錯誤!"
        End If
    End Sub
End Class
