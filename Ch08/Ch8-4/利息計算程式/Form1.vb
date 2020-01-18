Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim year As Integer
        Dim principal, oPrincipal As Double
        Dim sYears, eYears As Integer
        Dim hInterest, lInterest, interest As Double
        oPrincipal = CDbl(txtPrincipal.Text)          ' 金額
        sYears = CInt(txtShortYears.Text)      ' 最短年限
        eYears = CInt(txtLongYears.Text)       ' 最長年限
        hInterest = CDbl(txtHighInterest.Text) ' 最高年利率
        lInterest = CDbl(txtLowInterest.Text)  ' 最低年利率
        txtOutput.Text = "年利率" & vbTab
        ' 使用For迴圈顯示第1列標題列
        For interest = lInterest To hInterest
            txtOutput.Text &= interest & "%" & vbTab & vbTab
        Next interest
        txtOutput.Text &= vbNewLine
        ' 第一層For迴圈
        For year = sYears To eYears
            txtOutput.Text &= year & "年" & vbTab
            ' 第二層Do/Loop迴圈
            interest = lInterest   ' 指定年利率初值
            Do  ' 計算本利和
                principal = oPrincipal * (1 + interest / 100.0) ^ year
                txtOutput.Text &= principal.ToString("C") & vbTab
                interest += 1
            Loop Until interest > hInterest
            txtOutput.Text &= vbNewLine
        Next year
    End Sub
End Class
