Public Class ReportNewUser
    Private Sub fillUpBtn_Click(sender As Object, e As EventArgs) Handles fillUpBtn.Click
        Dim fillUpForm As New FillUpForm

        fillUpForm.Show()

        Me.Hide()

    End Sub

    Private Sub logoutBtnNewUser_Click(sender As Object, e As EventArgs) Handles logoutBtnNewUser.Click
        Dim form1 As New Form1
        form1.Show()

        Me.Hide()
    End Sub
End Class