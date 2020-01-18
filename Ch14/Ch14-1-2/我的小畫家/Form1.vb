Public Class Form1

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Dim g As Graphics = Me.CreateGraphics()
        g.Clear(Color.Red)
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics
        g.Clear(Color.Blue)
    End Sub
End Class
