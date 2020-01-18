Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' 宣告myTime類別的物件變數
        Dim now, open, close As MyTime
        ' 建立物件實例
        now = New MyTime()
        open = New MyTime()
        close = now
        ' 設定open物件的成員變數
        open.Hour = 10
        open.Minute = 30
        open.Second = 30
        txtOutput.Text = "開張時間: " & open.GetTime() & vbNewLine
        ' 設定close物件的成員變數
        close.SetTime(22, 30, 0)
        txtOutput.Text &= "結束時間: " & close.GetTime() & vbNewLine
        txtOutput.Text &= "現在時間: " & now.GetTime()
        txtOutput.SelectionStart = 0
    End Sub
End Class
