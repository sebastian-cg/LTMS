Public Class SignUpForm
    Private Sub backBtnSign_Click(sender As Object, e As EventArgs) Handles backBtnSign.Click
        Dim form1 As New Form1

        form1.Show()

        Me.Hide()

    End Sub
End Class