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

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Dim ch As Integer
        ch = Asc(e.KeyChar) ' 取得ASCII碼
        ' 是否是Backspace, 逗號, space或減號
        If ch = 8 Or ch = Asc(",") Or ch = Asc("-") _
                Or ch = Asc(" ") Then
            Exit Sub
        End If
        ' 是否是小寫英文字母
        If ch < 97 Or ch > 122 Then
            e.Handled = True
        End If
    End Sub
End Class
