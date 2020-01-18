Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f1 As Form1
        f1 = New Form1()
        f1.Show()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim path As String = "\VB2010\Ch15\" ' 檔案路徑
        Dim gif = New Bitmap(path & "start.gif")
        ptbOutput.Image = gif
    End Sub
End Class