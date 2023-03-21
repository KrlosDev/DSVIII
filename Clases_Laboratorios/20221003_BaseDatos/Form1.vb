
Imports Microsoft.Data.SqlClient

Public Class Form1
    Private Sub btn_Listar_Click(sender As Object, e As EventArgs) Handles btn_Listar.Click
        Dim connectionString As String
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim sql As String
        Dim SqlReader As SqlDataReader

        'connectionString = "Data Source=DESKTOP-JUHQR2B\SQLEXPRESS;Initial Catalog=20221LS231;User id=DS8;password=abcdef;TrustServerCertificate=True" 'Login con usuario y contraseña
        connectionString = "Data Source=DESKTOP-JUHQR2B\SQLEXPRESS;Initial Catalog=20221LS231;Integrated Security=True;TrustServerCertificate=True"  'login con Autenticación de Windows
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
            sql = "select * from cliente"
            command = New SqlCommand(sql, connection)
            SqlReader = command.ExecuteReader()
            While SqlReader.Read()
                lst_Cliente.Items.Add(SqlReader.Item("cedula") + SqlReader.Item("nombre") + SqlReader.Item("apellido"))
            End While
            SqlReader.Close()
            connection.Close()

        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try



    End Sub
End Class
