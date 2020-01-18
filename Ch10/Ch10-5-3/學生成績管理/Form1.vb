Public Class Form1

    ' 宣告一維陣列
    Dim MidTerm() As Integer = {70, 79, 65, 98, 60}
    Dim Final() As Integer = {60, 89, 75, 68, 90}

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim index As Integer
        Dim name As String
        ' 取得選取項目的索引值
        index = ltbName.SelectedIndex
        name = ltbName.Items(index)
        ' 顯示學生成績資料
        txtOutput.Text = "學生姓名: " & name & vbNewLine
        txtOutput.Text &= "期中考: " & MidTerm(index) & vbNewLine
        txtOutput.Text &= "期末考: " & Final(index) & vbNewLine
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Sums(1), Averages(1) As Single
        Dim index, i As Integer
        Dim name As String
        ' 計算總分
        For Each name In clbName.CheckedItems
            index = clbName.Items.IndexOf(name)
            Sums(0) = Sums(0) + MidTerm(index)
            Sums(1) = Sums(1) + Final(index)
        Next
        ' 計算平均
        For i = 0 To 1
            Averages(i) = Sums(i) / clbName.CheckedItems.Count
        Next i
        txtOutput.Text = "期中考總分: " & Sums(0) & vbNewLine
        txtOutput.Text &= "期中考平均: " & Averages(0) & vbNewLine
        txtOutput.Text &= "期末考總分: " & Sums(1) & vbNewLine
        txtOutput.Text &= "期末考平均: " & Averages(1) & vbNewLine
    End Sub
End Class
