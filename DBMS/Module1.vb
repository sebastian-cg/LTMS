﻿Imports MySql.Data.MySqlClient

Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=;database=dlms"
        con.Open()
    End Sub

End Module
