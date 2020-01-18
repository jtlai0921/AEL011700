Public Class Form1

    Dim intMoto As Integer = 0
    Dim intSony As Integer = 0
    Dim intNokia As Integer = 0
    Dim intSamsung As Integer = 0
    Dim intHTC As Integer = 0
    Dim total As Integer = 0

    Private Sub lblButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblButton.Click
        If ltbName.Items.IndexOf(txtName.Text) = -1 Then
            ' 姓名不存在, 所以新增參與投票的使用者名稱
            ltbName.Items.Add(txtName.Text)
            total += 1
            txtTotal.Text = total
            GroupBox1.Enabled = True  ' 啟用GroupBox
            lblButton.Enabled = False
            rdbMoto.Checked = False   ' 清除選擇
            rdbSony.Checked = False
            rdbNokia.Checked = False
            rdbSamsung.Checked = False
            rdbHTC.Checked = False
        Else
            MsgBox("使用者姓名已經存在!")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False  ' 不啟用GroupBox
    End Sub

    Private Sub rdbMoto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMoto.CheckedChanged
        If rdbMoto.Checked = True Then
            intMoto += 1
            txtMoto.Text = intMoto
            ltbChoice.Items.Add("M")
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub

    Private Sub rdbSony_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSony.CheckedChanged
        If rdbSony.Checked = True Then
            intSony += 1
            txtSony.Text = intSony
            ltbChoice.Items.Add("E")
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub

    Private Sub rdbNokia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbNokia.CheckedChanged
        If rdbNokia.Checked = True Then
            intNokia += 1
            txtNokia.Text = intNokia
            ltbChoice.Items.Add("N")
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub

    Private Sub rdbSamsung_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSamsung.CheckedChanged
        If rdbSamsung.Checked = True Then
            intSamsung += 1
            txtSamsung.Text = intSamsung
            ltbChoice.Items.Add("S")
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub

    Private Sub rdbHTC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbHTC.CheckedChanged
        If rdbHTC.Checked = True Then
            intHTC += 1
            txtHTC.Text = intHTC
            ltbChoice.Items.Add("H")
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub

    Private Sub ltbName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltbName.SelectedIndexChanged
        Dim index As Integer
        index = ltbName.SelectedIndex
        MsgBox(ltbName.Text & "選擇" & ltbChoice.Items(index) & "牌")
    End Sub
End Class
