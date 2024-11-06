Imports MySql.Data.MySqlClient

Public Class FillUpForm
    Private Sub logoutBtnUser_Click(sender As Object, e As EventArgs) Handles logoutBtnUser.Click
        Dim form1 As New Form1
        form1.Show()

        Me.Hide()
    End Sub

    Private Sub reportBtnNewUser_Click(sender As Object, e As EventArgs) Handles reportBtnNewUser.Click
        Dim reportNewUser As New ReportNewUser

        reportNewUser.Show()

        Me.Hide()
    End Sub

    Private Sub submitBtnFF_Click(sender As Object, e As EventArgs) Handles submitBtnFF.Click
        'first part of the fill up form
        Dim fullname As String = fullNameTxtBoxNU.Text
        Dim sex As String = sexComboBxNU.ToString()
        Dim bday As String = datePickerNU.Value.ToString("yyyy-MM-dd")
        Dim address As String = addressTxtBxNU.Text
        Dim phone As String = phoneTxtBxNU.Text

        'second part of the fill up form
        Dim email As String = emailTxtBxNU.Text
        Dim nationality As String = nationalityTxtBxNU.Text
        Dim driving_license_no As String = dLicenseNoTxtBxNU.Text
        Dim license_ex_date As String = licenseExpiryPickerNU.Value.ToString("yyyy-MM-dd")

        Dim user_id As Integer = userID

        ' Inserts into database
        Dim clientQuery As String = "INSERT INTO clients (user_id, fullname, sex, birthdate, address, phone, email, nationality, driving_license_no, license_exp_date)" &
                                    "VALUES (@user_id, @fullname, @sex, @birthdate, @address, @phone, @email, @nationality, @driving_license_no, @license_exp_date)"

        'Update isNewUser to FALSE
        Dim updateUserQuery As String = "UPDATE users SET isNewUser = FALSE WHERE user_id = @user_id"

        'Open the database connection
        Try
            openCon()

            'inserts into client table
            Using clientCmd As New MySqlCommand(clientQuery, con)

                clientCmd.Parameters.AddWithValue("@user_id", userID)
                clientCmd.Parameters.AddWithValue("@fullname", fullname)
                clientCmd.Parameters.AddWithValue("@sex", sex)
                clientCmd.Parameters.AddWithValue("@birthdate", bday)
                clientCmd.Parameters.AddWithValue("@address", address)
                clientCmd.Parameters.AddWithValue("@phone", phone)
                clientCmd.Parameters.AddWithValue("@email", email)
                clientCmd.Parameters.AddWithValue("@nationality", nationality)
                clientCmd.Parameters.AddWithValue("@driving_license_no", driving_license_no)
                clientCmd.Parameters.AddWithValue("@license_exp_date", license_ex_date)
                clientCmd.ExecuteNonQuery()

            End Using

            ' update the isNewUser attribute to false after submitting the information so that the user cannot be determined as new user
            Using updateUserCmd As New MySqlCommand(updateUserQuery, con)
                updateUserCmd.Parameters.AddWithValue("user_id", userID)
                updateUserCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Information saved successfully.")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
