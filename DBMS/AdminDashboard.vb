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

    Private Sub databaseBtnAdmin_Click(sender As Object, e As EventArgs) Handles databaseBtnAdmin.Click
        databaseDDPanel.Visible = Not databaseDDPanel.Visible
    End Sub

    Private Sub clientsBtnAdmin_Click(sender As Object, e As EventArgs) Handles clientsBtnAdmin.Click
        databaseDDPanel.Visible = False
    End Sub

    Private Sub vehiclesBtnAdmin_Click(sender As Object, e As EventArgs) Handles vehiclesBtnAdmin.Click
        databaseDDPanel.Visible = False
    End Sub

    Private Sub appointmentBtnAdmin_Click(sender As Object, e As EventArgs) Handles appointmentBtnAdmin.Click
        databaseDDPanel.Visible = False
    End Sub

    Private Sub violationBtnAdmin_Click(sender As Object, e As EventArgs) Handles violationBtnAdmin.Click
        databaseDDPanel.Visible = False
    End Sub

    Private Sub accidentBtnAdmin_Click(sender As Object, e As EventArgs) Handles accidentBtnAdmin.Click
        databaseDDPanel.Visible = False
    End Sub
End Class