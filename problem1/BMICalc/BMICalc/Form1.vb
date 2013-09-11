Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click
        Dim hSt As String
        Dim wSt As String

        hSt = txtHeight.Text
        wSt = txtWeight.Text

        Dim h As Double
        Dim w As Double
        h = CDbl(hSt)
        w = CDbl(wSt)

        Dim BMI As Double
        BMI = (w * 703) / (h ^ 2)

        TextBox1.Text = CStr(BMI)

    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeight.TextChanged

    End Sub

    Private Sub txtHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHeight.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
