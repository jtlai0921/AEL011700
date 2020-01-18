Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim path As String = "\VB2010\Ch15\" ' 檔案路徑
        Dim gif = New Bitmap(path & "sample.gif")
        ptbOutput.Image = gif
    End Sub
End Class