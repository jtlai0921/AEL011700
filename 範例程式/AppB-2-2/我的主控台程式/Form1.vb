Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       ' 宣告myTime類別的物件變數
        Dim open, close As MyTime
        ' 建立物件實例
        close = New MyTime()
        open = New MyTime()
        ' 設定open物件的成員變數
        open.SetTime(10, 30)
        ' 設定close物件的成員變數
        close.SetTime(22, 30, 0)
        txtOutput.Text = "開張時間: " & open.GetTime() & vbNewLine
        txtOutput.Text &= "結束時間: " & close.GetTime() & vbNewLine
        txtOutput.SelectionStart = 0
    End Sub
End Class
