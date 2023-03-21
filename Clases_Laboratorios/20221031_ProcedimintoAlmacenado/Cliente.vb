Public Class Cliente
    Dim obj_BD As New BD()
    Private _cedula As String
    Public Property cedula() As String
        Get
            Return _cedula
        End Get
        Set(ByVal value As String)
            _cedula = value
        End Set
    End Property
    Private _xyz As String  'en vez de nombre podemos utilizar cualquier nombre en esta clase
    Public Property nombre() As String
        Get
            Return _xyz
        End Get
        Set(ByVal value As String)
            _xyz = value
        End Set
    End Property
    Private _apellido As String
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Public Function listar() As DataTable
        Dim dt As New DataTable()
        'Dim sql As String

        'sql = "select * from cliente order by cedula"
        'obj_BD.executeReader(sql)
        'dt.Load(obj_BD.sqlR())

        dt = obj_BD.sp_Select()

        'obj_BD.Cerrar()
        Return dt

    End Function

    Public Sub buscar(ced As String)
        Dim dt As New DataTable

        dt = obj_BD.sp_Buscar(ced)
        If dt.Rows.Count() > 0 Then
            cedula = dt.Rows(0).Item("cedula")
            nombre = dt.Rows(0).Item("nombre")
            apellido = dt.Rows(0).Item("apellido")
        Else
            cedula = ced
            nombre = ""
            apellido = ""
        End If


        'Dim sql As String
        'sql = "select * from cliente where cedula = '" + ced + "'"
        'obj_BD.executeReader(sql)
        'If obj_BD.Read() Then
        'cedula = obj_BD.Item("cedula")
        'nombre = obj_BD.Item("nombre")
        'apellido = obj_BD.Item("apellido")
        'Else
        'cedula = ced
        'nombre = ""
        'apellido = ""
        'End If

        'obj_BD.Cerrar()
    End Sub

    Public Sub Agregar()
        Dim sql As String
        'sql = "insert into cliente(cedula,nombre,apellido) values('9-4-5','Rosa','Gutierrez')"
        'sql = "insert into cliente(cedula,nombre,apellido) values('" + cedula + "','" + nombre + "','" + apellido + "')"
        sql = "insert into cliente(cedula,nombre,apellido) values("
        sql = sql + "'" + cedula + "',"
        sql = sql + "'" + nombre + "',"
        sql = sql + "'" + apellido + "')"

        obj_BD.executeNonQuery(sql)
        obj_BD.Cerrar()

    End Sub

    Public Sub Modificar()
        Dim sql As String
        sql = "update cliente set nombre='" + nombre + "', "
        sql = sql + "apellido = '" + apellido + "' "
        sql = sql + "where cedula='" + cedula + "'"

        obj_BD.executeNonQuery(sql)
        obj_BD.Cerrar()

    End Sub

    Public Sub Eliminar()
        Dim sql As String
        sql = "delete from cliente where cedula = '" + cedula + "'"
        obj_BD.executeNonQuery(sql)
        obj_BD.Cerrar()
    End Sub

End Class
