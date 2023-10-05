Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim grade As String
        grade = Microsoft.VisualBasic.UCase(txtGrade.Text)

        Select Case grade
            Case "A"
                txtResult.Text = "High Distinction"
            Case "A-"
                txtResult.Text = "Distinction"
            Case "B"
                txtResult.Text = "Credit"
            Case "C"
                txtResult.Text = "Pass"
            Case Else
                txtResult.Text = "Fail"
        End Select
    End Sub

End Class
