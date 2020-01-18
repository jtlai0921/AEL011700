Public Class Form1

    Dim buffer As Bitmap
    Dim x, y As Integer
    Dim g As Graphics
    Dim pen As Pen
    Dim brush1 As SolidBrush
    Dim brush2 As TextureBrush

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pen = New Pen(Color.Red, 1)
        brush1 = New SolidBrush(Color.Blue)
        brush2 = New TextureBrush(New Bitmap("\VB2010\Ch14\back.bmp"))
        g = Me.CreateGraphics()
        ' 建立緩衝區的Bitmap物件
        buffer = New Bitmap(Me.ClientSize.Width, Me.ClientSize.Height)
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ' 準備繪出直線, 長方形和橢圓形
        If mnuItemLine.Checked Or mnuItemRectangle.Checked Or mnuItemEllipse.Checked Then
            x = e.X : y = e.Y  ' 指定開始座標
        End If
        If mnuItemText.Checked Then  ' 繪出文字內容
            Dim font As Font = New Font("標楷體", 14)
            Dim str As String = "Visual Basic程式設計"
            ' 繪在Buttfer
            Dim g1 As Graphics = Graphics.FromImage(buffer)
            If mnuItemSolid.Checked Then
                g1.DrawString(str, font, brush1, e.X, e.Y)
            Else
                g1.DrawString(str, font, brush2, e.X, e.Y)
            End If
            Me.Refresh()  ' 重繪
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If mnuItemRectangle.Checked Then ' 繪出長方形
            Dim g1 As Graphics = Graphics.FromImage(buffer)
            If mnuItemNotFill.Checked Then
                g1.DrawRectangle(pen, x, y, e.X - x, e.Y - y)
            Else
                If mnuItemSolid.Checked Then
                    g1.FillRectangle(brush1, x, y, e.X - x, e.Y - y)
                Else
                    g1.FillRectangle(brush2, x, y, e.X - x, e.Y - y)
                End If
            End If
            Me.Refresh()  ' 重繪
        End If
        If mnuItemEllipse.Checked Then   ' 繪出橢圓形
            Dim g1 As Graphics = Graphics.FromImage(buffer)
            If mnuItemNotFill.Checked Then
                g1.DrawEllipse(pen, x, y, e.X - x, e.Y - y)
            Else
                If mnuItemSolid.Checked Then
                    g1.FillEllipse(brush1, x, y, e.X - x, e.Y - y)
                Else
                    g1.FillEllipse(brush2, x, y, e.X - x, e.Y - y)
                End If
            End If
            Me.Refresh()  ' 重繪
        End If
    End Sub

    Private Sub mnuItemNotFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemNotFill.Click
        If mnuItemNotFill.Checked Then
            mnuItemNotFill.Checked = False
        Else
            mnuItemNotFill.Checked = True
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left And mnuItemLine.Checked Then
            pen.Width = 2
            ' 畫線在Buffer
            Dim g1 As Graphics = Graphics.FromImage(buffer)
            g1.DrawLine(pen, x, y, e.X, e.Y)
            ' 繪在畫布
            g.DrawLine(pen, x, y, e.X, e.Y)
            x = e.X
            y = e.Y
        End If
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        g.Clear(Color.White)
        g.DrawImage(buffer, 0, 0)  ' 重繪Bitmap物件
    End Sub

    Private Sub mnuItemLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemLine.Click
        mnuItemLine.Checked = True
        mnuItemText.Checked = False
        mnuItemRectangle.Checked = False
        mnuItemEllipse.Checked = False
    End Sub

    Private Sub mnuItemText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemText.Click
        mnuItemLine.Checked = False
        mnuItemText.Checked = True
        mnuItemRectangle.Checked = False
        mnuItemEllipse.Checked = False
    End Sub

    Private Sub mnuItemRectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemRectangle.Click
        mnuItemLine.Checked = False
        mnuItemText.Checked = False
        mnuItemRectangle.Checked = True
        mnuItemEllipse.Checked = False
    End Sub

    Private Sub mnuItemEllipse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemEllipse.Click
        mnuItemLine.Checked = False
        mnuItemText.Checked = False
        mnuItemRectangle.Checked = False
        mnuItemEllipse.Checked = True
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
