Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Text = Button1.Text
        Button1.Text = Button2.Text
        Button2.Text = Me.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Text = Button2.Text
        Button2.Text = Button1.Text
        Button1.Text = Me.Text
    End Sub
End Class
