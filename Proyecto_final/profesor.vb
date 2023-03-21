Imports System.Runtime.ConstrainedExecution
Imports Org.BouncyCastle.Asn1.X500
Public Class profesor
    Dim obj_BD As New BD()
    Public cedula As String
    Public nombre As String
    Public apellido As String
    Public celular As String
    Public correo As String
    Public direccion As String
    Public salario As String
    Public codigo As String
    Public facultad As String
    Public categoria As String
    Public id As String
    Public Function listar(orden) As DataTable

        Dim dt As New DataTable()
        Dim Mysql As String

        Mysql = "Call sp_listar_profesor(" & orden & ")"
        obj_BD.executeReader(Mysql)
        dt.Load(obj_BD.MsqlR())
        obj_BD.Cerrar()
        Return dt

    End Function
    Public Sub buscar(cod As String)
        'Dim dt As New DataTable()
        Dim Mysql As String
        'Dim MySql2 As String
        Mysql = "Call sp_buscar_profesor('" + cod + "')"
        'MySql2 = "Call sp_selectFacultad()"
        'obj_BD.executeReader(MySql2)
        'dt.Load(obj_BD.MsqlR())
        obj_BD.executeReader(Mysql)
        If obj_BD.Read() Then
            codigo = obj_BD.Item("codigo")
            cedula = obj_BD.Item("cedula")
            nombre = obj_BD.Item("nombre")
            apellido = obj_BD.Item("apellido")
            celular = obj_BD.Item("celular")
            correo = obj_BD.Item("correo")
            direccion = obj_BD.Item("direccion")
            salario = obj_BD.Item("salario_base")
            facultad = obj_BD.Item("facultad")
            categoria = obj_BD.Item("categoria")

        Else
            codigo = cod
            cedula = ""
            nombre = ""
            apellido = ""
            celular = ""
            correo = ""
            direccion = ""
            salario = ""
            facultad = ""
            categoria = ""
        End If

        obj_BD.Cerrar()
        'Return dt


    End Sub

    Public Sub Eliminar(cod As String)
        Dim Mysql As String
        Mysql = "Call sp_delete_profesor('" + cod + "')"
        obj_BD.executeNonQuery(Mysql)
        obj_BD.Cerrar()
    End Sub

    Public Function getFacultad()
        Dim dt As New DataTable()

        Dim MySql2 As String

        MySql2 = "Call sp_selectFacultad()"
        obj_BD.executeReader(MySql2)
        dt.Load(obj_BD.MsqlR())

        Return dt


    End Function

    Public Function getCategoria()
        Dim dt As New DataTable()

        Dim MySql2 As String

        MySql2 = "Call sp_selectCategoria()"
        obj_BD.executeReader(MySql2)
        dt.Load(obj_BD.MsqlR())

        Return dt


    End Function

    Public Sub Agregar()
        Dim mysql As String

        mysql = "Call sp_insertar_profesor('" + codigo + "','" + cedula + "','" + nombre + "','" + apellido + "','" + direccion + "','" + celular + "','" + correo + "','" + salario + "','" + categoria + "','" + facultad + "')"


        obj_BD.executeNonQuery(mysql)
        obj_BD.Cerrar()
    End Sub
    Public Sub Modificar()
        Dim mysql As String
        mysql = "Call sp_modificar_profesor('" + codigo + "','" + cedula + "','" + nombre + "','" + apellido + "','" + direccion + "','" + celular + "','" + correo + "','" + salario + "','" + categoria + "','" + facultad + "')"

        obj_BD.executeNonQuery(mysql)
        obj_BD.Cerrar()

    End Sub
End Class
