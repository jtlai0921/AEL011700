Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim amount, quantity As Integer
        amount = 0 : quantity = 1
        If chkBeef.Checked Then
            quantity = CInt(txtBeef.Text)
            amount += 80 * quantity
        End If
        If chkFish.Checked Then
            quantity = CInt(txtFish.Text)
            amount += 75 * quantity
        End If
        If chkChicken.Checked Then
            quantity = CInt(txtChicken.Text)
            amount += 70 * quantity
        End If
        lblOutput.Text = amount.ToString("C")
    End Sub
End Class
