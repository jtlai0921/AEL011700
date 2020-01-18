Public Class Form1

    Dim total As Integer = 0

    Private Sub txtName_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.DoubleClick
        If txtName.BackColor = Color.Yellow Then
            txtName.BackColor = Color.White
        Else
            txtName.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub lblButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblButton.Click
        If ltbName.Items.IndexOf(txtName.Text) = -1 Then
            ' 姓名不存在, 所以新增參與投票的使用者名稱
            ltbName.Items.Add(txtName.Text)
            total += 1
            txtTotal.Text = total
        Else
            MsgBox("使用者姓名已經存在!")
        End If
    End Sub

    Private Sub ltbName_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltbName.MouseEnter
        ltbName.BackColor = Color.LightGray
    End Sub

    Private Sub ltbName_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltbName.MouseLeave
        ltbName.BackColor = Color.White
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.BackColor = Color.Yellow  ' 指定背景色彩
        txtName.ReadOnly = True           ' 改為唯讀
        txtName.Focus()                   ' 取得焦點
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        txtName.Text = e.KeyCode
        If e.Alt Then
            txtName.Text &= " - 按下Alt鍵"
        End If
        If e.Shift Then
            txtName.Text &= " - 按下Shift鍵"
        End If
        If e.Control Then
            txtName.Text &= " - 按下Ctrl鍵"
        End If
    End Sub

    Private Sub txtName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyUp
        ' 取得控制項座標
        Dim left As Integer = txtName.Left
        Dim top As Integer = txtName.Top
        ' 取得表單尺寸
        Dim maxWidth As Integer = Me.ClientSize.Width
        Dim maxHeight As Integer = Me.ClientSize.Height
        ' 移動文字方塊控制項
        Select Case e.KeyCode
            Case Keys.Up
                If top > 0 Then
                    top -= 20
                End If
            Case Keys.Down
                If top + txtName.Height < maxHeight Then
                    top += 20
                End If
            Case Keys.Left
                If left > 0 Then
                    left -= 30
                End If
            Case Keys.Right
                If left + txtName.Width < maxWidth Then
                    left += 30
                End If
        End Select
        ' 指定成新的位置
        txtName.Left = left
        txtName.Top = top
        txtName.Focus()     ' 取得焦點
    End Sub
End Class
