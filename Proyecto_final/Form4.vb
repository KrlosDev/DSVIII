

Public Class Form4
    Dim obj_profesor As New profesor()
    Dim orden As Integer
    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        orden = 0
        If rb_nombre.Checked = True Then

            orden = 1

        ElseIf rb_apellido.Checked = True Then
            orden = 2

        ElseIf rb_codigo.Checked = True Then
            orden = 0
        End If

        dgv_profesor.DataSource = obj_profesor.listar(orden)
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        txt_codigo.Enabled = False
        txt_cedula.Enabled = True
        txt_apellido.Enabled = True
        txt_nombre.Enabled = True
        txt_celular.Enabled = True
        txt_correo.Enabled = True
        txt_direccion.Enabled = True
        txt_salario.Enabled = True
        cb_facultad.Enabled = True
        cb_categoria.Enabled = True
        btn_buscar.Enabled = False


        'getting facultad combobox
        cb_facultad.DataSource = obj_profesor.getFacultad()
        cb_facultad.DisplayMember = "facultad"
        cb_facultad.ValueMember = "id"

        'getting categoria combobox
        cb_categoria.DataSource = obj_profesor.getCategoria()
        cb_categoria.DisplayMember = "categoria"
        cb_categoria.ValueMember = "id"


        '-------------------------------
        obj_profesor.buscar(txt_codigo.Text)
        txt_cedula.Text = obj_profesor.cedula
        txt_nombre.Text = obj_profesor.nombre
        txt_apellido.Text = obj_profesor.apellido
        txt_celular.Text = obj_profesor.celular
        txt_correo.Text = obj_profesor.correo
        txt_direccion.Text = obj_profesor.direccion
        txt_salario.Text = obj_profesor.salario
        cb_facultad.Text = obj_profesor.facultad
        cb_categoria.Text = obj_profesor.categoria

        If txt_nombre.Text = "" Then
            btn_buscar.Enabled = False
            btn_agregar.Enabled = True
        Else
            btn_modificar.Enabled = True
            btn_eliminar.Enabled = True

        End If

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Pasar_txt_obj()
        Try
            obj_profesor.Agregar()
            MsgBox("Se agrego el profesor satisfactoriamente")
        Catch ex As Exception
            MsgBox("error, no se pudo agregar")
        End Try


    End Sub




    Private Sub Pasar_txt_obj()
        obj_profesor.codigo = txt_codigo.Text
        obj_profesor.cedula = txt_cedula.Text
        obj_profesor.nombre = txt_nombre.Text
        obj_profesor.apellido = txt_apellido.Text
        obj_profesor.celular = txt_celular.Text
        obj_profesor.correo = txt_correo.Text
        obj_profesor.direccion = txt_direccion.Text
        obj_profesor.salario = txt_salario.Text
        obj_profesor.facultad = cb_facultad.SelectedValue
        obj_profesor.categoria = cb_categoria.SelectedValue

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            obj_profesor.Eliminar(txt_codigo.Text)
            MsgBox("Se elimino el profesor satisfactoriamente")
        Catch ex As Exception
            MsgBox("error, no se pudo eliminar")
        End Try

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        'Dim regexPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$"
        ' If txt_correo.Text Like regexPattern Then
        Pasar_txt_obj()
            Try
                obj_profesor.Modificar()
                MsgBox("Se modifico el profesor satisfactoriamente")
            Catch ex As Exception
                MsgBox("error, no se pudo modificar")
            End Try
        '       Else
        '      MsgBox("Ingrese un correo valido")
        '        End If

    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        For Each txt As Control In Me.Controls.OfType(Of TextBox)()
            txt.Text = ""
        Next
        For Each txt As Control In Me.Controls.OfType(Of ComboBox)()
            txt.Text = ""
        Next
        cb_categoria.DataSource = Nothing
        cb_facultad.DataSource = Nothing
        dgv_profesor.DataSource = Nothing
        txt_codigo.Enabled = True
        txt_cedula.Enabled = False
        txt_apellido.Enabled = False
        txt_nombre.Enabled = False
        txt_celular.Enabled = False
        txt_correo.Enabled = False
        txt_direccion.Enabled = False
        txt_salario.Enabled = False
        cb_facultad.Enabled = False
        cb_categoria.Enabled = False
        btn_agregar.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        btn_buscar.Enabled = True

    End Sub
    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txt_apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txt_celular_keyPress(sender As Object, e As KeyPressEventArgs) Handles txt_celular.KeyPress
        SoloNumeros(e)
    End Sub

    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
End Class