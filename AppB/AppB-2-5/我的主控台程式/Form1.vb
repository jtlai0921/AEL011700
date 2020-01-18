Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' 宣告MyName類別的物件
        Dim name As New MyName("會安", "陳")
        ' 呼叫物件方法
        txtOutput.Text = name.GetName() & vbNewLine
        txtOutput.Text &= name.GetFirstName() & vbNewLine
        txtOutput.SelectionStart = 0
    End Sub
End Class
