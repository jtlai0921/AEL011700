Public Class Form1

    Sub ShowPrompt()
        Dim msg As String
        msg = "50元: "
        lblOutput.Text = msg
    End Sub

    Function ReturnChange()
        Dim Amount As Integer
        Amount = CInt(txtAmount.Text)
        Dim Change As Integer = 0  ' 計算零錢數
        ' 換零錢的迴圈
        Do While Amount >= 50
            Amount = Amount - 50  ' 每次減50元
            Change = Change + 1
        Loop
        Return Change
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call ShowPrompt()   ' 呼叫程序
        lblOutput.Text &= ReturnChange()  ' 呼叫函數
    End Sub
End Class
