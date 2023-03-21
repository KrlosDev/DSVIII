Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class BD


    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim Mysql As String
    Dim SqlReader As MySqlDataReader


    Private connectionString As String = "server=localhost;user=root;password=i9d0fn93cb;database=proyecto_dsviii"

    Public Sub Abrir()
        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()
        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try
    End Sub

    Public Sub executeReader(Mysql As String)
        Try
            Abrir()
            command = New MySqlCommand(Mysql, connection)
            SqlReader = command.ExecuteReader()
        Catch ex As Exception
            ' MsgBox("error " & ex.ToString)
        End Try
    End Sub
    Public Function Read() As Boolean
        Return SqlReader.Read()
    End Function
    Public Function Item(campo As String) As String
        Return SqlReader.Item(campo)
    End Function
    Public Sub Cerrar()
        connection.Close()
    End Sub
    Public Function MsqlR() As MySqlDataReader
        Return SqlReader
    End Function
    Public Sub executeNonQuery(Mysql As String)
        Try
            Abrir()
            command = New MySqlCommand(Mysql, connection)

            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try

    End Sub

End Class