Public Class Form1
    ' 宣告一維陣列
    Dim Names() As String = {"陳會安", "江小魚", "陳允傑",
                             "楊過", "小龍女"}
    Dim MidTerm() As Integer = {70, 79, 65, 98, 60}
    Dim Final = {60, 89, 75, 68, 90}

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim index As Integer
        index = CInt(txtNo.Text) ' 取得索引
        If index >= 0 And index <= 4 Then
            ' 顯示查詢結果
            txtName.Text = Names(index)
            txtMidTerm.Text = MidTerm(index)
            txtFinal.Text = Final(index)
        Else
            txtName.Text = "學號錯誤!"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sum, average As Single
        Dim element As Integer
        sum = 0.0
        ' 計算總和
        For Each element In MidTerm
            sum += element
        Next
        average = sum / 5  ' 平均
        MsgBox("期中考總分: " & sum & vbNewLine _
                & "平均:" & average)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sum, average As Single
        Dim index As Integer
        sum = 0.0
        ' 計算總和
        For index = 0 To 4
            sum += Final(index)
        Next index
        average = sum / 5  ' 平均
        MsgBox("期末考總分: " & sum & vbNewLine _
                & "平均:" & average)
    End Sub
End Class
