Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 + opd2  ' 加
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 - opd2  ' 減
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 * opd2  ' 乘
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 / opd2  ' 除
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 Mod opd2  ' 餘數
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 ^ opd2  ' 指數
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim opd1, opd2 As Integer
        opd1 = CInt(txtOpd1.Text)
        opd2 = CInt(txtOpd2.Text)
        lblOutput.Text = opd1 \ opd2  ' 整數除法
    End Sub
End Class
