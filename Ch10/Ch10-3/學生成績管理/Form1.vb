Public Class Form1
    ' 宣告一維陣列
    Dim Names() As String = {"陳會安", "江小魚", "陳允傑",
                             "楊過", "小龍女"}
    ' 宣告二維陣列
    Dim Grades(,) As Integer = {{70, 79, 65, 98, 60},
                                {60, 89, 75, 68, 90}}

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim index As Integer
        index = CInt(txtNo.Text) ' 取得索引
        If index >= 0 And index <= 4 Then
            ' 顯示查詢結果
            txtName.Text = Names(index)
            txtMidTerm.Text = Grades(0, index)
            txtFinal.Text = Grades(1, index)
        Else
            txtName.Text = "學號錯誤!"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Sums(1), Averages(1) As Single
        Dim i, j As Integer
        ' 二層巢狀迴圈來計算總分
        For i = 0 To 1
            For j = 0 To 4
                Sums(i) += Grades(i, j)
            Next j
        Next i
        ' 計算平均
        For i = 0 To 1
            Averages(i) = Sums(i) / 5
        Next i
        txtOutput.Text = "期中考總分: " & Sums(0) & vbNewLine
        txtOutput.Text &= "期中考平均: " & Averages(0) & vbNewLine
        txtOutput.Text &= "期末考總分: " & Sums(1) & vbNewLine
        txtOutput.Text &= "期末考平均: " & Averages(1) & vbNewLine
    End Sub
End Class
