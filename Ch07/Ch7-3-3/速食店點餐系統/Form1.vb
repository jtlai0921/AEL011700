Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim amount, amount_qty, quantity As Integer
        amount = 0 : quantity = 1 : amount_qty = 0
        If chkBeef.Checked Then
            quantity = CInt(txtBeef.Text)
            amount_qty += quantity
            amount += 80 * quantity
        End If
        If chkFish.Checked Then
            quantity = CInt(txtFish.Text)
            amount_qty += quantity
            amount += 75 * quantity
        End If
        If chkChicken.Checked Then
            quantity = CInt(txtChicken.Text)
            amount_qty += quantity
            amount += 70 * quantity
        End If
        ' 選項按鈕計算飲料的總價
        If rdbCoke.Checked Then
            amount += 30 * amount_qty
        End If
        If rdbCoffee.Checked Then
            amount += 35 * amount_qty
        End If
        If rdbBlackTea.Checked Then
            amount += 25 * amount_qty
        End If
        ' 是否有勾選購買薯條
        If chkFries.Checked Then
            If rdbSmall.Checked Then ' 小薯
                amount += 25 * amount_qty
            End If
            If rdbLarge.Checked Then ' 大薯
                amount += 35 * amount_qty
            End If
        End If
        lblOutput.Text = amount.ToString("C")
    End Sub
End Class
