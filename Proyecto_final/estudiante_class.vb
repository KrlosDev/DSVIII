Imports System.Runtime.ConstrainedExecution
Imports Org.BouncyCastle.Asn1.X500

Public Class estudiante_class
    Dim obj_BD As New BD()
    Public cedula As String
    Public nombre As String
    Public apellido As String
    Public celular As String
    Public correo As String
    Public direccion As String
    Public indice As String
    Public sexo As String
    Public facultad As String
    Public carrera As String
    Public id As String
    Public Function listar(orden) As DataTable

        Dim dt As New DataTable()
        Dim Mysql As String

        Mysql = "Call sp_listar_estudiante(" & orden & ")"
        obj_BD.executeReader(Mysql)
        dt.Load(obj_BD.MsqlR())
        obj_BD.Cerrar()
        Return dt

    End Function
    Public Sub buscar(ced1 As String)
        'Dim dt As New DataTable()
        Dim Mysql As String
        'Dim MySql2 As String
        Mysql = "Call sp_buscar_Estudiante('" + ced1 + "')"
        'MySql2 = "Call sp_selectFacultad()"
        'obj_BD.executeReader(MySql2)
        'dt.Load(obj_BD.MsqlR())
        obj_BD.executeReader(Mysql)
        If obj_BD.Read() Then
            cedula = obj_BD.Item("cedula")
            nombre = obj_BD.Item("nombre")
            apellido = obj_BD.Item("apellido")
            celular = obj_BD.Item("celular")
            correo = obj_BD.Item("correo")
            direccion = obj_BD.Item("direccion")
            sexo = obj_BD.Item("sexo")
            indice = obj_BD.Item("indice_academico")
            facultad = obj_BD.Item("facultad")
            carrera = obj_BD.Item("carrera")

        Else
            cedula = ced1
            nombre = ""
            apellido = ""
            celular = ""
            correo = ""
            direccion = ""
            sexo = ""
            indice = ""
            facultad = ""
            carrera = ""
        End If

        obj_BD.Cerrar()
        'Return dt


    End Sub

    Public Sub Eliminar(ced1 As String)
        Dim Mysql As String
        Mysql = "Call sp_delete_Estudiante('" + ced1 + "')"
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

    Public Function getCarrera(id)
        Dim dt As New DataTable()

        Dim MySql2 As String

        MySql2 = "Call sp_selectCarrera('" + id + "')"
        obj_BD.executeReader(MySql2)
        dt.Load(obj_BD.MsqlR())

        Return dt


    End Function

    Public Sub Agregar()
        Dim mysql As String

        mysql = "Call sp_insertar_Estudiante('" + cedula + "','" + nombre + "','" + apellido + "','" + direccion + "','" + celular + "','" + correo + "','" + indice + "','" + sexo + "','" + carrera + "','" + facultad + "')"


        obj_BD.executeNonQuery(mysql)
        obj_BD.Cerrar()
    End Sub
    Public Sub Modificar()
        Dim mysql As String
        mysql = "Call sp_modificar_estudiante('" + cedula + "','" + nombre + "','" + apellido + "','" + direccion + "','" + celular + "','" + correo + "','" + indice + "','" + sexo + "','" + carrera + "','" + facultad + "')"

        obj_BD.executeNonQuery(mysql)
        obj_BD.Cerrar()

    End Sub

End Class
