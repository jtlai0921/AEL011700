Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim height
        Dim width As Integer
        depth = 135   ' 沒有宣告此變數
        height = 158
        width = 140
        ' 顯示變數值
        txtOutput.Text = "尺寸總和: " & (depth + height + width) & vbNewLine
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
