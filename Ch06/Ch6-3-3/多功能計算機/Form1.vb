Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fahr, cels As Double
        fahr = CDbl(txtF.Text)    ' 取得華氏溫度
        ' 華氏轉攝氏
        cels = (5.0 / 9.0) * (fahr - 32.0)
        txtC.Text = cels
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fahr, cels As Double
        cels = CDbl(txtC.Text)    ' 取得攝氏溫度
        ' 攝氏轉華氏
        fahr = (9.0 * cels) / 5.0 + 32.0
        txtF.Text = fahr
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim weight, height As Double
        weight = CDbl(txtWeight.Text)
        height = CDbl(txtHeight.Text) / 100.0  ' 轉換成公尺
        lblOutput.Text = "BMI值: " & weight / height ^ 2   ' 計算BMI值
    End Sub
End Class
