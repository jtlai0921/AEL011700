Public Class Form1

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("確認結束表單 ?", MsgBoxStyle.OkCancel) =
                                 MsgBoxResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Width = 310
        Me.Height = 190
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Width = 310
        Me.Height = 190
    End Sub
End Class
