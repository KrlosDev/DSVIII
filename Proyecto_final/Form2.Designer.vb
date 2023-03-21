Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rb_nombre = New System.Windows.Forms.RadioButton()
        Me.rb_apellido = New System.Windows.Forms.RadioButton()
        Me.dgv_estudiante = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_sexo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_indice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cb_facultad = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_carrera = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rb_cedula = New System.Windows.Forms.RadioButton()
        CType(Me.dgv_estudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(493, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_buscar.Location = New System.Drawing.Point(26, 604)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(94, 29)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_agregar.Enabled = False
        Me.btn_agregar.Location = New System.Drawing.Point(154, 604)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(94, 29)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Location = New System.Drawing.Point(274, 604)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(94, 29)
        Me.btn_modificar.TabIndex = 3
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(399, 604)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(94, 29)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_listar
        '
        Me.btn_listar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_listar.Location = New System.Drawing.Point(581, 623)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(94, 29)
        Me.btn_listar.TabIndex = 5
        Me.btn_listar.Text = "Listar"
        Me.btn_listar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(499, 570)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Listar por:"
        '
        'rb_nombre
        '
        Me.rb_nombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rb_nombre.AutoSize = True
        Me.rb_nombre.Location = New System.Drawing.Point(499, 595)
        Me.rb_nombre.Name = "rb_nombre"
        Me.rb_nombre.Size = New System.Drawing.Size(85, 24)
        Me.rb_nombre.TabIndex = 8
        Me.rb_nombre.Text = "Nombre"
        Me.rb_nombre.UseVisualStyleBackColor = True
        '
        'rb_apellido
        '
        Me.rb_apellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rb_apellido.AutoSize = True
        Me.rb_apellido.Location = New System.Drawing.Point(590, 595)
        Me.rb_apellido.Name = "rb_apellido"
        Me.rb_apellido.Size = New System.Drawing.Size(87, 24)
        Me.rb_apellido.TabIndex = 9
        Me.rb_apellido.Text = "Apellido"
        Me.rb_apellido.UseVisualStyleBackColor = True
        '
        'dgv_estudiante
        '
        Me.dgv_estudiante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv_estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estudiante.Location = New System.Drawing.Point(26, 379)
        Me.dgv_estudiante.Name = "dgv_estudiante"
        Me.dgv_estudiante.RowHeadersWidth = 51
        Me.dgv_estudiante.RowTemplate.Height = 29
        Me.dgv_estudiante.Size = New System.Drawing.Size(757, 188)
        Me.dgv_estudiante.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cedula"
        '
        'txt_cedula
        '
        Me.txt_cedula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_cedula.Location = New System.Drawing.Point(26, 104)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(125, 27)
        Me.txt_cedula.TabIndex = 12
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_limpiar.Location = New System.Drawing.Point(689, 344)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(94, 29)
        Me.btn_limpiar.TabIndex = 13
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(168, 104)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(125, 27)
        Me.txt_nombre.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Apellido"
        '
        'txt_apellido
        '
        Me.txt_apellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Location = New System.Drawing.Point(304, 104)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(125, 27)
        Me.txt_apellido.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Direccion"
        '
        'txt_direccion
        '
        Me.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_direccion.Enabled = False
        Me.txt_direccion.Location = New System.Drawing.Point(26, 173)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(461, 27)
        Me.txt_direccion.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(438, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Celular"
        '
        'txt_celular
        '
        Me.txt_celular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_celular.Enabled = False
        Me.txt_celular.Location = New System.Drawing.Point(435, 104)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(125, 27)
        Me.txt_celular.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(567, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Correo"
        '
        'txt_correo
        '
        Me.txt_correo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_correo.Enabled = False
        Me.txt_correo.Location = New System.Drawing.Point(567, 104)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(216, 27)
        Me.txt_correo.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(493, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Sexo"
        '
        'cb_sexo
        '
        Me.cb_sexo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_sexo.Enabled = False
        Me.cb_sexo.FormattingEnabled = True
        Me.cb_sexo.Items.AddRange(New Object() {"-Selecciona-", "M", "F", "o"})
        Me.cb_sexo.Location = New System.Drawing.Point(493, 172)
        Me.cb_sexo.Name = "cb_sexo"
        Me.cb_sexo.Size = New System.Drawing.Size(136, 28)
        Me.cb_sexo.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(646, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Indice Academico"
        '
        'txt_indice
        '
        Me.txt_indice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_indice.Enabled = False
        Me.txt_indice.Location = New System.Drawing.Point(649, 172)
        Me.txt_indice.Name = "txt_indice"
        Me.txt_indice.Size = New System.Drawing.Size(134, 27)
        Me.txt_indice.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Facultad"
        '
        'cb_facultad
        '
        Me.cb_facultad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_facultad.Enabled = False
        Me.cb_facultad.FormattingEnabled = True
        Me.cb_facultad.Items.AddRange(New Object() {"--Seleccionar"})
        Me.cb_facultad.Location = New System.Drawing.Point(26, 261)
        Me.cb_facultad.Name = "cb_facultad"
        Me.cb_facultad.Size = New System.Drawing.Size(373, 28)
        Me.cb_facultad.TabIndex = 29
        Me.cb_facultad.Text = "--Seleccionar--"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(436, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Carrera"
        '
        'cb_carrera
        '
        Me.cb_carrera.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_carrera.Enabled = False
        Me.cb_carrera.FormattingEnabled = True
        Me.cb_carrera.Location = New System.Drawing.Point(436, 261)
        Me.cb_carrera.Name = "cb_carrera"
        Me.cb_carrera.Size = New System.Drawing.Size(338, 28)
        Me.cb_carrera.TabIndex = 31
        Me.cb_carrera.Text = "--Seleccionar--"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(7, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(776, 38)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Mantenimiento Estudiante"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rb_cedula
        '
        Me.rb_cedula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rb_cedula.AutoSize = True
        Me.rb_cedula.Location = New System.Drawing.Point(499, 625)
        Me.rb_cedula.Name = "rb_cedula"
        Me.rb_cedula.Size = New System.Drawing.Size(76, 24)
        Me.rb_cedula.TabIndex = 33
        Me.rb_cedula.Text = "Cedula"
        Me.rb_cedula.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 661)
        Me.Controls.Add(Me.rb_cedula)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cb_carrera)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cb_facultad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_indice)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cb_sexo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_estudiante)
        Me.Controls.Add(Me.rb_apellido)
        Me.Controls.Add(Me.rb_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_listar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Estudiante"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_estudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_listar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents rb_nombre As RadioButton
    Friend WithEvents rb_apellido As RadioButton
    Friend WithEvents dgv_estudiante As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cb_sexo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_indice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cb_facultad As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cb_carrera As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents rb_cedula As RadioButton
    Dim obj_estudiante As New estudiante_class()
    Dim orden As Integer

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        orden = 0
        If rb_nombre.Checked = True Then

            orden = 1

        ElseIf rb_apellido.Checked = True Then
            orden = 2

        ElseIf rb_cedula.Checked = True Then
            orden = 0
        End If

        dgv_estudiante.DataSource = obj_estudiante.listar(orden)




    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        If Not txt_cedula.Text Like "##-####-#####" Then

            MsgBox("formato debe ser 99-9999-99999")

        Else
            txt_cedula.Enabled = False
            txt_apellido.Enabled = True
            txt_nombre.Enabled = True
            txt_celular.Enabled = True
            txt_correo.Enabled = True
            txt_direccion.Enabled = True
            cb_sexo.Enabled = True
            txt_indice.Enabled = True
            cb_facultad.Enabled = True
            cb_carrera.Enabled = True
            btn_buscar.Enabled = False


            'getting facultad combobox
            cb_facultad.DataSource = obj_estudiante.getFacultad()
            cb_facultad.DisplayMember = "facultad"
            cb_facultad.ValueMember = "id"

            'getting carrera combobox



            '-------------------------------
            obj_estudiante.buscar(txt_cedula.Text)
            txt_nombre.Text = obj_estudiante.nombre
            txt_apellido.Text = obj_estudiante.apellido
            txt_celular.Text = obj_estudiante.celular
            txt_correo.Text = obj_estudiante.correo
            txt_direccion.Text = obj_estudiante.direccion
            cb_sexo.Text = obj_estudiante.sexo
            txt_indice.Text = obj_estudiante.indice
            cb_facultad.Text = obj_estudiante.facultad
            cb_carrera.Text = obj_estudiante.carrera

            If txt_nombre.Text = "" Then
                btn_buscar.Enabled = False
                btn_agregar.Enabled = True
            Else
                btn_modificar.Enabled = True
                btn_eliminar.Enabled = True

            End If

        End If

    End Sub

    Private Sub cb_facultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_facultad.SelectedValueChanged

        Dim SB = cb_facultad.SelectedValue
        'getting carrera combobox
        cb_carrera.DisplayMember = "carrera"


        If SB IsNot Nothing Then

            cb_carrera.DataSource = obj_estudiante.getCarrera(cb_facultad.SelectedValue.ToString)

        End If


    End Sub



    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        'Dim regexPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$"
        'If txt_correo.Text Like regexPattern Then

        Pasar_txt_obj()
            Try
                obj_estudiante.Agregar()
                MsgBox("Se agrego el estudiante satisfactoriamente")
            Catch ex As Exception
                MsgBox("error, no se pudo agregar")
            End Try
        '   Else
        'MsgBox("ingrese un correo valido")
        'End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        'Dim regexPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$"
        'If txt_correo.Text Like regexPattern Then

        Pasar_txt_obj()
        Try
                obj_estudiante.Modificar()
                MsgBox("Se modifico el estudiante satisfactoriamente")
            Catch ex As Exception
                MsgBox("error, no se pudo modificar")
            End Try
        ' Else
        'MsgBox("ingrese un correo valido")

        ' End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            obj_estudiante.Eliminar(txt_cedula.Text)
            MsgBox("Se elimino el estudiante satisfactoriamente")
        Catch ex As Exception
            MsgBox("error, no se pudo eliminar")
        End Try

    End Sub

    Private Sub Pasar_txt_obj()
        obj_estudiante.cedula = txt_cedula.Text
        obj_estudiante.nombre = txt_nombre.Text
        obj_estudiante.apellido = txt_apellido.Text
        obj_estudiante.celular = txt_celular.Text
        obj_estudiante.correo = txt_correo.Text
        obj_estudiante.direccion = txt_direccion.Text
        obj_estudiante.sexo = cb_sexo.Text
        obj_estudiante.indice = txt_indice.Text
        obj_estudiante.facultad = cb_facultad.SelectedValue
        obj_estudiante.carrera = cb_carrera.Text

    End Sub
    'Private Sub cambiarCarrera(id1)
    '  cb_carrera.ValueMember = "id"
    '   cb_carrera.DisplayMember = "carrera"
    '    cb_carrera.DataSource = obj_estudiante.getCarrera(id1)
    ' End Sub
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        For Each txt As Control In Me.Controls.OfType(Of TextBox)()
            txt.Text = ""
        Next
        For Each txt As Control In Me.Controls.OfType(Of ComboBox)()
            txt.Text = ""
        Next
        cb_carrera.DataSource = Nothing
        cb_facultad.DataSource = Nothing
        dgv_estudiante.DataSource = Nothing
        txt_cedula.Enabled = True
        txt_apellido.Enabled = False
        txt_nombre.Enabled = False
        txt_celular.Enabled = False
        txt_correo.Enabled = False
        txt_direccion.Enabled = False
        cb_sexo.Enabled = False
        txt_indice.Enabled = False
        cb_facultad.Enabled = False
        cb_carrera.Enabled = False
        btn_agregar.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        btn_buscar.Enabled = True




    End Sub
    'validaciones
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
