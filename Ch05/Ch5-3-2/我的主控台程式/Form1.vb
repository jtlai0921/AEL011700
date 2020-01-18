Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim title
        Dim depth, height, width As Integer
        Dim name As String
        ' 指定變數值
        title = 1000
        height = 135
        width = 157
        name = "陳會安"
        title = "Visual Basic程式設計"
        depth = height
        ' 顯示變數值
        txtOutput.Text = "尺寸總和: " & (depth + height + width) & vbNewLine
        txtOutput.Text &= "標題文字: " & title & vbNewLine
        txtOutput.Text &= "作者姓名: " & name & vbNewLine
    End Sub
End Class
