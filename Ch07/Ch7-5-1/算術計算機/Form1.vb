Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 + opd2  ' 加
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 - opd2  ' 減
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 * opd2  ' 乘
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 / opd2  ' 除
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 Mod opd2  ' 餘數
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 ^ opd2  ' 指數
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 \ opd2  ' 整數除法
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim opd1, opd2 As Integer
        Dim op As Integer
        If rdbAdd.Checked Then op = 1
        If rdbSubtract.Checked Then op = 2
        If rdbMultiply.Checked Then op = 3
        If rdbDivide.Checked Then op = 4
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        If op = 1 Then
            lblOutput.Text = opd1 + opd2  ' 加 
        ElseIf op = 2 Then
            lblOutput.Text = opd1 - opd2  ' 減
        ElseIf op = 3 Then
            lblOutput.Text = opd1 * opd2  ' 乘
        ElseIf op = 4 Then
            lblOutput.Text = opd1 / opd2  ' 除
        Else
            lblOutput.Text = "錯誤: 沒有選擇運算子!"
        End If
    End Sub
End Class
