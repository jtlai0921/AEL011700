﻿Public Class Form1

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
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If mnuItemLine.Checked Then
            x = e.X  ' 開始畫線
            y = e.Y
        Else
            Dim font As Font = New Font("標楷體", 14)
            Dim str As String = "Visual Basic程式設計"
            If mnuItemSolid.Checked Then
                g.DrawString(str, font, brush1, e.X, e.Y)
            Else
                g.DrawString(str, font, brush2, e.X, e.Y)
            End If
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left And mnuItemLine.Checked Then
            ' 繪在畫布
            pen.Width = 2
            g.DrawLine(pen, x, y, e.X, e.Y)
            x = e.X
            y = e.Y
        End If
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
         g.Clear(Color.White)
    End Sub

    Private Sub mnuItemLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemLine.Click
        mnuItemLine.Checked = True
        mnuItemText.Checked = False
    End Sub

    Private Sub mnuItemText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemText.Click
        mnuItemLine.Checked = False
        mnuItemText.Checked = True
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
