Public Class UserDashboard
    Private Sub logoutBtnUser_Click(sender As Object, e As EventArgs) Handles logoutBtnUser.Click
        Dim form1 As New Form1
        form1.Show()

        Me.Hide()

    End Sub

    Private Sub statusBtnUser_Click(sender As Object, e As EventArgs) Handles statusBtnUser.Click
        Dim statusView As New StatusView

        statusView.Show()

        Me.Hide()
    End Sub

    Private Sub emailsBtnUser_Click(sender As Object, e As EventArgs) Handles emailsBtnUser.Click
        Dim reApply As New ReApply

        reApply.Show()

        Me.Hide()
    End Sub

    Private Sub dashboardBtnUser_Click(sender As Object, e As EventArgs) Handles dashboardBtnUser.Click
        Dim userDashboard As New UserDashboard

        userDashboard.Show()

        Me.Hide()

    End Sub
End Class