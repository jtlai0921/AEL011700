Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim year, totalYear As Integer
        Dim interest As Double
        Dim principal As Double = CDbl(txtPrincipal.Text)
        Dim rate As Double = CInt(txtRate.Text) / 100.0
        totalYear = CInt(txtTotalYear.Text)
        For year = 1 To totalYear
            interest = principal * rate
            principal = principal + interest
        Next year
        lblOutput.Text = principal.ToString("C")
    End Sub
End Class
