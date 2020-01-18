Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim year, totalYear As Integer
        Dim ret As Integer
        Dim msgStyle As Integer
        Dim principal As Double
        Dim rate As Double = CInt(txtRate.Text) / 100.0
        totalYear = CInt(txtTotalYear.Text)
        Dim strValue As String
        ' InputBox輸入視窗
        strValue = InputBox("請輸入金額?", "輸入金額")
        principal = CDbl(strValue)  ' 輸入的金額
        ' 計算本利和
        For year = 1 To totalYear
            principal += principal * rate
        Next year
        msgStyle = MsgBoxStyle.OkCancel +
                   MsgBoxStyle.Information
        ' MsgBox訊息視窗
        ret = MsgBox(principal.ToString("C"), msgStyle, "本利和")
        If ret = MsgBoxResult.Ok Then End ' 結束程式
    End Sub
End Class
