Public Class Form1

    Dim pen As Pen
    Dim brush1 As SolidBrush
    Dim brush2 As TextureBrush

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Dim g As Graphics = Me.CreateGraphics()
        g.Clear(Color.White)
        If mnuItemSolid.Checked Then
            g.FillEllipse(brush1, 120, 60, 190, 70)
        Else
            g.FillEllipse(brush2, 120, 60, 190, 70)
        End If
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics
        g.Clear(Color.White)
        pen.Width = 3
        g.DrawLine(pen, 130, 30, 200, 100)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pen = New Pen(Color.Red, 1)
        brush1 = New SolidBrush(Color.Blue)
        brush2 = New TextureBrush(New Bitmap("\VB2010\Ch14\back.bmp"))
    End Sub

    Private Sub mnuItemRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemRed.Click
        mnuItemRed.Checked = True
        mnuItemBlue.Checked = False
        mnuItemGreen.Checked = False
        pen.Color = Color.Red
    End Sub

    Private Sub mnuItemGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemGreen.Click
        mnuItemRed.Checked = False
        mnuItemBlue.Checked = False
        mnuItemGreen.Checked = True
        pen.Color = Color.Green
    End Sub

    Private Sub mnuItemBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemBlue.Click
        mnuItemRed.Checked = False
        mnuItemBlue.Checked = True
        mnuItemGreen.Checked = False
        pen.Color = Color.Blue
    End Sub

    Private Sub mnuItemSolid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemSolid.Click
        mnuItemSolid.Checked = True
        mnuItemTexture.Checked = False
    End Sub

    Private Sub mnuItemTexture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemTexture.Click
        mnuItemSolid.Checked = False
        mnuItemTexture.Checked = True
    End Sub
End Class
