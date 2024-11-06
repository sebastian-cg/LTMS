Imports MySql.Data.MySqlClient

Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    'make this a global variable
    Public userID As Integer

    Sub openCon()
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = "server=localhost;username=root;password=;database=dlms"
            con.Open()
        End If
    End Sub

End Module
