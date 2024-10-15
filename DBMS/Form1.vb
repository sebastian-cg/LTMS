Public Class Form1
    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub signUpBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signUpBtn.LinkClicked
        Dim signUpForm As New SignUpForm

        signUpForm.Show()

        Me.Hide()

    End Sub
End Class
