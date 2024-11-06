Imports MySql.Data.MySqlClient

Public Class SignUpForm
    Private Sub backBtnSign_Click(sender As Object, e As EventArgs) Handles backBtnSign.Click
        Dim form1 As New Form1

        form1.Show()

        Me.Hide()

    End Sub

    Private Sub signUpMainBtn_Click(sender As Object, e As EventArgs) Handles signUpMainBtn.Click

        Dim username As String = usernameTxtBoxSign.Text.Trim
        Dim password As String = passTxtBoxSign.Text.Trim
        Dim repass As String = reEnterPassSignUp.Text.Trim

        ' checks if any text fields are empty
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Or String.IsNullOrEmpty(repass) Then

            MessageBox.Show("Please fill up all fields before sigining up.")
            Return

        End If
        'check if the pass and repass is equal
        If password <> repass Then
            MessageBox.Show("Password do not match. Please try again.")
            Return
        End If

        'make the new sign up user into default which is client
        Dim user_role As String = "client"

        Try
            'check if the username is already exists in database
            openCon()

            Dim checkUserQuery As String = "SELECT COUNT(*) FROM users WHERE username = @username"
            Dim userExists As Boolean

            Using checkCmd As New MySqlCommand(checkUserQuery, con)
                checkCmd.Parameters.AddWithValue("@username", username)
                userExists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0
            End Using

            If userExists Then
                MessageBox.Show("Username already exists. Please choose another one.")
                Return
            End If

            ' insert new user into users table if haven't detect similar one
            Dim insertUserQuery As String = "INSERT INTO users (username, password, user_role, isNewUser) VALUES (@username, @password, @user_role, @isNewUser)"

            Using insertCmd As New MySqlCommand(insertUserQuery, con)

                insertCmd.Parameters.AddWithValue("@username", username)
                insertCmd.Parameters.AddWithValue("@password", password)
                insertCmd.Parameters.AddWithValue("@user_role", user_role)
                insertCmd.Parameters.AddWithValue("@isNewUser", True)
                insertCmd.ExecuteNonQuery()

            End Using

            ' get the user_id of the new created user
            Dim newUserId As Integer
            Dim getUserIdQuery As String = "SELECT user_id FROM users WHERE username = @username"

            Using getUserIdCmd As New MySqlCommand(getUserIdQuery, con)
                getUserIdCmd.Parameters.AddWithValue("@username", username)
                newUserId = Convert.ToInt32(getUserIdCmd.ExecuteScalar())
            End Using

            ' insert a blank entry in the client table for the user, which can be updated in fillup form
            Dim insertClientQuery As String = "INSERT INTO clients (user_id) VALUES (@user_id)"

            Using insertClientCmd As New MySqlCommand(insertClientQuery, con)

                insertClientCmd.Parameters.AddWithValue("@user_id", newUserId)
                insertClientCmd.ExecuteNonQuery()
                MessageBox.Show("Account created successfully! Please log in.")

            End Using

            ' redirect to login form or form1
            Dim form1 As New Form1
            form1.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        Finally
            con.Close()
        End Try
    End Sub
End Class