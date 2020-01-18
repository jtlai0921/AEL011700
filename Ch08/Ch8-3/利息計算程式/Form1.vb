Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rate, curRate, interest, principal As Double
        Dim loopType As Integer
        Dim output As String = ""
        ' 取得輸入的本金
        principal = CDbl(txtPrincipal.Text)
        ' 取得迴圈種類
        If rdbDoWhileLoop.Checked Then
            loopType = 1
        ElseIf rdbDoUntilLoop.Checked Then
            loopType = 2
        ElseIf rdbDoLoopWhile.Checked Then
            loopType = 3
        Else
            loopType = 4
        End If
        rate = 12 : txtOutput.Text = ""
        ' 計算本利和
        Select Case loopType
            Case 1
                ' Do While/Loop迴圈
                output = "Do While/Loop: " & vbNewLine
                Do While rate <= 18
                    curRate = rate / 100
                    interest = principal * curRate
                    txtOutput.Text &= rate & "%利息 = " &
                                       interest & vbNewLine
                    rate = rate + 1
                Loop
            Case 2
                ' Do Until/Loop迴圈
                output = "Do Until/Loop: " & vbNewLine
                Do Until rate > 18
                    curRate = rate / 100
                    interest = principal * curRate
                    txtOutput.Text &= rate & "%利息 = " &
                                       interest & vbNewLine
                    rate = rate + 1
                Loop
            Case 3
                ' Do/Loop While迴圈
                output = "Do/Loop While: " & vbNewLine
                Do
                    curRate = rate / 100
                    interest = principal * curRate
                    txtOutput.Text &= rate & "%利息 = " &
                                       interest & vbNewLine
                    rate = rate + 1
                Loop While rate <= 18
            Case 4
                ' Do/Loop Until迴圈
                output = "Do/Loop Until: " & vbNewLine
                Do
                    curRate = rate / 100
                    interest = principal * curRate
                    txtOutput.Text &= rate & "%利息 = " &
                                       interest & vbNewLine
                    rate = rate + 1
                Loop Until rate > 18
        End Select
    End Sub
End Class
