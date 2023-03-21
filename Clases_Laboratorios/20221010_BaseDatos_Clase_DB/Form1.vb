
Imports Microsoft.Data.SqlClient

Public Class Form1
    Private Sub btn_Listar_Click(sender As Object, e As EventArgs) Handles btn_Listar.Click
        Dim obj_BD As New BD()

        obj_BD.executeReader("select * from cliente")

        lst_Cliente.Items.Clear()
        While obj_BD.Read()
            lst_Cliente.Items.Add(obj_BD.Item("cedula") + obj_BD.Item("nombre") + obj_BD.Item("apellido"))
        End While
        obj_BD.Cerrar()

    End Sub

    Private Sub lst_Cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Cliente.SelectedIndexChanged

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim obj_BD As New BD()
        obj_BD.executeReader("select * from cliente where cedula = '" + txt_Cedula.Text + "'")

        If obj_BD.Read() Then
            txt_Nombre.Text = obj_BD.Item("nombre")
            txt_Apellido.Text = obj_BD.Item("apellido")
        Else
            txt_Nombre.Clear()
            txt_Apellido.Clear()
        End If

        obj_BD.Cerrar()

    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Dim obj_BD As New BD()
        obj_BD.executeNonQuery("insert into cliente (cedula,nombre,apellido) values('" + txt_Cedula.Text + "','" + txt_Nombre.Text + "','" + txt_Apellido.Text + "')")
        obj_BD.Cerrar()

    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Dim obj_BD As New BD()
        obj_BD.executeNonQuery("update cliente set nombre = '" + txt_Nombre.Text + "', apellido = '" + txt_Apellido.Text + "' where cedula = '" + txt_Cedula.Text + "'")
        obj_BD.Cerrar()
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim obj_BD As New BD()
        obj_BD.executeNonQuery("delete from cliente where cedula = '" + txt_Cedula.Text + "'")
        obj_BD.Cerrar()

    End Sub
End Class
