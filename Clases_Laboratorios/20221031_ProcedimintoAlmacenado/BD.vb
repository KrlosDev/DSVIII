Imports Microsoft.Data.SqlClient

Public Class BD
    Dim connectionString As String
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sql As String
    Dim SqlReader As SqlDataReader
    Dim sqlAdapter As SqlDataAdapter


    Public Sub New()
        'connectionString = "Data Source=DESKTOP-JUHQR2B\SQLEXPRESS;Initial Catalog=20221LS231;User id=DS8;password=abcdef;TrustServerCertificate=True" 'Login con usuario y contraseña
        connectionString = "Data Source=DESKTOP-JUHQR2B\SQLEXPRESS;Initial Catalog=20221LS231;Integrated Security=True;TrustServerCertificate=True"  'login con Autenticación de Windows

    End Sub
    Public Sub Abrir()
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try
    End Sub
    Public Sub executeReader(sql As String)
        Try
            Abrir()
            command = New SqlCommand(sql, connection)
            SqlReader = command.ExecuteReader()
        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try
    End Sub
    Public Function Read() As Boolean
        Return SqlReader.Read()
    End Function
    Public Function Item(campo As String) As String
        Return SqlReader.Item(campo)
    End Function

    Public Sub executeNonQuery(sql As String)
        Try
            Abrir()
            command = New SqlCommand(sql, connection)
            MsgBox(sql)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try
    End Sub
    Public Sub Cerrar()
        connection.Close()
    End Sub
    Public Function sqlR() As SqlDataReader
        Return SqlReader
    End Function

    Public Function sp_Select() As DataTable
        MsgBox("desde sp_Select")
        Dim dt As New DataTable
        Try
            Abrir()
            command = New SqlCommand("sp_Cliente_Select", connection)
            command.CommandType = CommandType.StoredProcedure
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Error ("error " & ex.ToString)
        Finally
            Cerrar()
        End Try
    End Function

    Public Function sp_Buscar(ced As String) As DataTable
        MsgBox("desde sp_Select")
        Dim dt As New DataTable
        Try
            Abrir()
            command = New SqlCommand("sp_Cliente_Select", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cedula", ced)
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Error ("error " & ex.ToString)
        Finally
            Cerrar()
        End Try
    End Function

End Class
