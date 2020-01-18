Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       ' 宣告myTime類別的物件變數
        Dim now, open, close As MyTime
        ' 建立物件實例
        now = New MyTime()
        close = New MyTime(10, 30)
        open = New MyTime(22, 30, 0)
        txtOutput.Text = "現在時間: " & now.GetTime() & vbNewLine
        txtOutput.Text &= "開張時間: " & open.GetTime() & vbNewLine
        txtOutput.Text &= "結束時間: " & close.GetTime() & vbNewLine
        txtOutput.SelectionStart = 0
    End Sub
End Class
