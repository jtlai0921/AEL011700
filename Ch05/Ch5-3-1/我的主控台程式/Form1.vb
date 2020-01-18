Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim size   ' 變數size的資料型態是Object
        ' 變數height和width都是Integer資料型態
        Dim height, width As Integer
        ' 指定變數的初值
        Dim name As String, depth = 100
        Dim title As String = "Visual Basic程式"
        lblOutput.Text = "變數size: " & size & vbNewLine
        lblOutput.Text &= "變數height: " & height & vbNewLine
        lblOutput.Text &= "變數width: " & width & vbNewLine
        lblOutput.Text &= "變數depth: " & depth & vbNewLine
        lblOutput.Text &= "標題文字: " & title & vbNewLine
        lblOutput.Text &= "作者姓名: " & name & vbNewLine
    End Sub
End Class
