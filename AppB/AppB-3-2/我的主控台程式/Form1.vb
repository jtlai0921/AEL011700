Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim line As MyLine = New MyLine()
        Dim txtline As TextLine = New TextLine("THIS IS A BOOK.")
        txtOutput.Text = txtline.GetText() & vbNewLine
        txtOutput.Text &= "第1個字: " & txtline.GetWord() & vbNewLine
        line.Line = "That is a pen."
        txtOutput.Text &= line.GetText() & vbNewLine
        txtOutput.Text &= "字串長度: " & line.Length & vbNewLine
        txtOutput.Text &= "第1個字: " & line.GetWord() & vbNewLine
        txtOutput.Text &= "找尋is: " & line.InStr("is")
        line = Nothing : txtline = Nothing
        txtOutput.SelectionStart = 0
    End Sub
End Class
