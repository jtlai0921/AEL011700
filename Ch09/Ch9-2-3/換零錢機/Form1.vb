Public Class Form1

    Function ReturnChange(ByVal Amount As Integer, ByVal Unit As Integer)
        Dim Change As Integer = 0
        Do While True  ' 無窮迴圈
            Amount = Amount - Unit
            If Amount >= 0 Then
                Change = Change + 1
            Else
                Return Change
                Exit Function ' 跳出函數
            End If
        Loop
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Amount As Integer = CInt(txtAmount.Text)
        Dim Change, Type As Integer
        ' 選擇零錢種類
        If rdb50.Checked Then
            Change = ReturnChange(Amount, 50) ' 呼叫函數
            Type = 50
        End If
        If rdb10.Checked Then
            Change = ReturnChange(Amount, 10) ' 呼叫函數
            Type = 10
        End If
        If rdb5.Checked Then
            Change = ReturnChange(Amount, 5)  ' 呼叫函數
            Type = 5
        End If
        lblOutput.Text = Type & "元: " & Change & "個" & vbNewLine
        ' 計算剩下多少錢
        lblOutput.Text &= "剩下: " & (Amount - Type * Change) & "元"
    End Sub
End Class
