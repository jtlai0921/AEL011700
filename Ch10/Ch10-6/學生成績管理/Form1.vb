Public Class Form1

    ' 宣告一維陣列
    Dim MidTerm() As Integer = {70, 79, 65, 98, 60}
    Dim Final() As Integer = {60, 89, 75, 68, 90}

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim index As Integer
        Dim name As String
        ' 取得選取項目的索引值
        index = ltbName.SelectedIndex
        name = ltbName.Items(index)
        ' 顯示學生成績資料
        txtOutput.Text = "學生姓名: " & name & vbNewLine
        txtOutput.Text &= "期中考: " & MidTerm(index) & vbNewLine
        txtOutput.Text &= "期末考: " & Final(index) & vbNewLine
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Sums(1), Averages(1) As Single
        Dim index, i As Integer
        Dim name As String
        ' 計算總分
        For Each name In clbName.CheckedItems
            index = clbName.Items.IndexOf(name)
            Sums(0) = Sums(0) + MidTerm(index)
            Sums(1) = Sums(1) + Final(index)
        Next
        ' 計算平均
        For i = 0 To 1
            Averages(i) = Sums(i) / clbName.CheckedItems.Count
        Next i
        txtOutput.Text = "期中考總分: " & Sums(0) & vbNewLine
        txtOutput.Text &= "期中考平均: " & Averages(0) & vbNewLine
        txtOutput.Text &= "期末考總分: " & Sums(1) & vbNewLine
        txtOutput.Text &= "期末考平均: " & Averages(1) & vbNewLine
    End Sub

    Dim Data(4) As Integer

    Sub Bubble(ByVal Data() As Integer)
        Dim i, j, length, temp As Integer
        length = UBound(Data)
        For i = length To 0 Step -1
            For j = 0 To length - 1
                If Data(j + 1) < Data(j) Then
                    temp = Data(j + 1) ' 交換
                    Data(j + 1) = Data(j)
                    Data(j) = temp
                End If
            Next j
        Next i
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Bubble(Data)  ' 泡沫排序
        txtOutput.Text = ""
        For i As Integer = 0 To 4
            txtOutput.Text &= Data(i) & vbNewLine
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim low, mid, high, target As Integer
        Dim isFound As Boolean = False
        target = CInt(InputBox("請輸入搜尋的平均成績"))
        low = 0 : high = UBound(Data)
        Do
            mid = (low + high) \ 2
            If Data(mid) = target Then
                txtOutput.Text &= "鍵值位置: " & mid & vbNewLine
                isFound = True
                Exit Do
            ElseIf Data(mid) > target Then
                high = mid - 1  ' 前半段
            Else
                low = mid + 1   ' 後半段
            End If
        Loop Until low > high
        If Not isFound Then
            txtOutput.Text &= "沒有找到鍵值.." & vbNewLine
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 4
            Data(i) = (MidTerm(i) + Final(i)) / 2
        Next
    End Sub
End Class
