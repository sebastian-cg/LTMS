Imports MySql.Data.MySqlClient


Public Class Form1
    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        MsgBox("Connected!")
        con.Close()

    End Sub

    Private Sub signUpBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signUpBtn.LinkClicked
        Dim signUpForm As New SignUpForm

        signUpForm.Show()

        Me.Hide()

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        openCon()

        Dim username As String = loginTxtBoxLogin.Text
        Dim password As String = passTxtBoxLogin.Text

        Dim userRole As String = ""
        Dim isNewUser As Boolean = False

        If ValidateLogin(username, password, userRole, isNewUser) Then
            MessageBox.Show("Login Successfully!")
            If isNewUser Then
                Dim fillUpForm As New FillUpForm()
                fillUpForm.Show()
            Else
                If userRole = "client" Then
                    Dim userDashboard As New UserDashboard()
                    userDashboard.Show()
                ElseIf userRole = "admin" Then
                    Dim adminDashboard As New AdminDashboard
                    adminDashboard.Show()

                End If
            End If
            Me.Hide()
        Else
            MessageBox.Show("Invalid username and password. Please Try again.")
        End If
        con.Close()
    End Sub
    Private Function ValidateLogin(username As String, password As String, ByRef userRole As String, ByRef isNewUser As Boolean) As Boolean
        Dim isValid As Boolean = False
        Dim query As String = "SELECT user_role, isNewUser FROM users WHERE username = @username AND password = @password"

        Using command As New MySqlCommand(query, con)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)

            Try
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' login succesfull
                        isValid = True
                        userRole = reader("user_role".ToString())
                        isNewUser = Convert.ToBoolean(reader("isNewUser"))
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

        End Using
        Return isValid
    End Function
End Class
