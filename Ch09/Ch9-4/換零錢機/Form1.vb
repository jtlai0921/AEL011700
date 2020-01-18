Public Class Form1

    Dim Amount As Integer

    Function ReturnChange(ByVal Unit As Integer)
        Dim Change As Integer
        Change = Amount \ Unit   ' 整數除法
        Amount = Amount Mod Unit ' 餘數
        Return Change
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Change As Integer
        txt50.Text = "0"  ' 清除文字方塊控制項
        txt20.Text = "0"
        txt10.Text = "0"
        txt5.Text = "0"
        txt1.Text = "0"
        Amount = CInt(txtAmount.Text) ' 金額
        ' 檢查是否需兌換此種零錢
        If chk50.Checked Then
            Change = ReturnChange(50) ' 呼叫函數
            txt50.Text = Change
        End If
        If chk20.Checked Then
            Change = ReturnChange(20) ' 呼叫函數
            txt20.Text = Change
        End If
        If chk10.Checked Then
            Change = ReturnChange(10) ' 呼叫函數
            txt10.Text = Change
        End If
        If chk5.Checked Then
            Change = ReturnChange(5)  ' 呼叫函數
            txt5.Text = Change
        End If
        txt1.Text = Amount   ' 剩下的金額
    End Sub
End Class
