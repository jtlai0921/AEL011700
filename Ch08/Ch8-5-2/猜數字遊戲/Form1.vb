Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim target, number, times As Integer
        Dim str As String
        Randomize()  ' 使用亂數取得1~100之間的值
        target = CInt(Rnd() * 100)
        times = 0  ' 猜測次數
        Do While True  ' 遊戲的無窮迴圈
            str = InputBox("請輸入數字1~100")
            times += 1
            If str = "" Then   ' 使用者放棄
                txtOutput.Text &= "使用者放棄..." & vbNewLine
                Exit Do
            End If
            number = CInt(str)
            ' 檢查是否超過範圍
            If number < 1 Or number > 100 Then
                txtOutput.Text &= "範圍錯誤: " & number & vbNewLine
                Continue Do
            End If
            If number = target Then      ' 是否猜中
                txtOutput.Text &= "在第" & times &
                    "次猜中" & target & vbNewLine
                Exit Do
            End If
            ' 判斷數字太大或太小
            If number > target Then
                txtOutput.Text &= number & "太大!"
            Else
                txtOutput.Text &= number & "太小!"
            End If
            txtOutput.Text &= vbNewLine ' 新增換行
        Loop
    End Sub
End Class
