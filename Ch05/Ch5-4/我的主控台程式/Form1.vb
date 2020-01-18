Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Const MAX_WIDTH = 150 ' 符號常數宣告
        Const PI = 3.1415926
        Dim r As Integer
        r = 15   ' 半徑
        ' 顯示符號常數值
        txtOutput.Text = "最大寬度: " & MAX_WIDTH & vbNewLine
        txtOutput.Text &= "圖面積  : " & (PI * r * r) & vbNewLine
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
