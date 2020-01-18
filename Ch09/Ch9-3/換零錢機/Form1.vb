Public Class Form1

    Function ReturnChange(ByRef Amount As Integer, ByVal Unit As Integer)
        Dim Change As Integer
        Change = Amount \ Unit   ' 整數除法
        Amount = Amount Mod Unit ' 餘數
        Return Change
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Amount As Integer = CInt(txtAmount.Text)
        Dim Change As Integer
        ' 選擇零錢種類
        If rdb50.Checked Then
            Change = ReturnChange(Amount, 50) ' 呼叫函數
            lblOutput.Text = "50元"
        End If
        If rdb10.Checked Then
            Change = ReturnChange(Amount, 10) ' 呼叫函數
            lblOutput.Text = "10元"
        End If
        If rdb5.Checked Then
            Change = ReturnChange(Amount, 5)  ' 呼叫函數
            lblOutput.Text = "5元"
        End If
        lblOutput.Text &= Change & "個" & vbNewLine
        lblOutput.Text &= "剩下: " & Amount & "元"
    End Sub
End Class
