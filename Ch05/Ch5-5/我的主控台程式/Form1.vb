Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim int1, int2, int3 As Integer ' 整數
        Dim dfloat As Double            ' 浮點數
        Dim sfloat As Single
        Dim isFound As Boolean = True  ' 布林
        Dim str1 As String = "Visual Basic程式設計" ' 字串
        Dim str2 As String = "Hello World!"
        Dim title As String = "我的""Visual Basic""程式"
        Dim aChar As Char = "A"c        ' 字元
        Dim tday As Date = #12/30/2010# ' 日期
        ' 指定變數值
        int1 = 19I        ' 十進位
        int2 = &O377      ' 八進位
        int3 = &H3E7      ' 十六進位
        dfloat = 0.0005   ' 科學記法
        sfloat = 45.67F
        txtOutput.Text = "int1= " & int1 & vbNewLine
        txtOutput.Text &= "int2= " & int2 & vbNewLine
        txtOutput.Text &= "int3= " & int3 & vbNewLine
        txtOutput.Text &= "dfloat= " & dfloat & vbNewLine
        txtOutput.Text &= "sfloat= " & sfloat & vbNewLine
        txtOutput.Text &= "isFound = " & isFound & vbNewLine
        txtOutput.Text &= "str1 & str2 = " & str1 & str2 & vbNewLine
        txtOutput.Text &= "title = " & title & vbNewLine
        txtOutput.Text &= "aChar = " & aChar & vbNewLine
        txtOutput.Text &= "tday = " & tday & vbNewLine
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
