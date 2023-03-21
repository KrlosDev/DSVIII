
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
            lst_Cliente.Items.Clear()
            While SqlReader.Read()
                lst_Cliente.Items.Add(SqlReader.Item("cedula") + SqlReader.Item("nombre") + SqlReader.Item("apellido"))
            End While
            SqlReader.Close()
            connection.Close()

        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try



    End Sub

    Private Sub lst_Cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Cliente.SelectedIndexChanged

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
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
            'sql = "select * from cliente where cedula = '8-3-1'"
            sql = "select * from cliente where cedula = '" + txt_Cedula.Text + "'"
            command = New SqlCommand(sql, connection)
            SqlReader = command.ExecuteReader()
            If SqlReader.Read() Then
                txt_Nombre.Text = SqlReader.Item("nombre")
                txt_Apellido.Text = SqlReader.Item("apellido")
            Else
                txt_Nombre.Clear()
                txt_Apellido.Clear()
            End If

            SqlReader.Close()
            connection.Close()

        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try


    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
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
            'sql = "insert into cliente (cedula,nombre,apellido) values('5-1-1','Jose','Castillo')"
            sql = "insert into cliente (cedula,nombre,apellido) values('" + txt_Cedula.Text + "','" + txt_Nombre.Text + "','" + txt_Apellido.Text + "')"

            command = New SqlCommand(sql, connection)
            command.ExecuteNonQuery()

            connection.Close()

        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try


    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
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
            'sql = "update cliente set nombre = 'RosaN', apellido = 'RodriguezN' where cedula = '8-3-1'"
            sql = "update cliente set nombre = '" + txt_Nombre.Text + "', apellido = '" + txt_Apellido.Text + "' where cedula = '" + txt_Cedula.Text + "'"

            command = New SqlCommand(sql, connection)
            command.ExecuteNonQuery()

            connection.Close()

        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try

    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
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
            sql = "delete from cliente where cedula = '" + txt_Cedula.Text + "'"

            command = New SqlCommand(sql, connection)
            command.ExecuteNonQuery()

            connection.Close()

        Catch ex As Exception
            MsgBox("error " & ex.ToString)
        End Try

    End Sub
End Class
