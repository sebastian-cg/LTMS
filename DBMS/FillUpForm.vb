﻿Public Class FillUpForm
    Private Sub logoutBtnUser_Click(sender As Object, e As EventArgs) Handles logoutBtnUser.Click
        Dim form1 As New Form1
        form1.Show()

        Me.Hide()
    End Sub
End Class
