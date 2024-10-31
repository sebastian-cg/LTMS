Public Class AdminDashboard
    Private Sub logoutBtnAdminDB_Click(sender As Object, e As EventArgs) Handles logoutBtnAdminDB.Click

        Dim form1 As New Form1
        form1.Show()

        Me.Hide()


    End Sub

    Private Sub reportBtnAdminDB_Click(sender As Object, e As EventArgs) Handles reportBtnAdminDB.Click
        panelDropdown.Visible = Not panelDropdown.Visible
    End Sub

    Private Sub btnCompletedAccounts_Click(sender As Object, e As EventArgs) Handles btnCompletedAccounts.Click
        panelDropdown.Visible = False

    End Sub

    Private Sub btnPendingAccounts_Click(sender As Object, e As EventArgs) Handles btnPendingAccounts.Click
        panelDropdown.Visible = False
    End Sub

    Private Sub btnDeclineAccounts_Click(sender As Object, e As EventArgs) Handles btnDeclineAccounts.Click
        panelDropdown.Visible = False
    End Sub
End Class