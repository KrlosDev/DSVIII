<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_salario = New System.Windows.Forms.TextBox()
        Me.cb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_facultad = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rb_codigo = New System.Windows.Forms.RadioButton()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.dgv_profesor = New System.Windows.Forms.DataGridView()
        Me.rb_apellido = New System.Windows.Forms.RadioButton()
        Me.rb_nombre = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        CType(Me.dgv_profesor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(12, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(776, 38)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Mantenimiento Profesor"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(603, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Correo"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(500, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Celular"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(369, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Cedula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(629, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Codigo"
        '
        'txt_codigo
        '
        Me.txt_codigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_codigo.Location = New System.Drawing.Point(13, 107)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(78, 27)
        Me.txt_codigo.TabIndex = 41
        '
        'txt_celular
        '
        Me.txt_celular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_celular.Enabled = False
        Me.txt_celular.Location = New System.Drawing.Point(500, 107)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(93, 27)
        Me.txt_celular.TabIndex = 45
        '
        'txt_apellido
        '
        Me.txt_apellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Location = New System.Drawing.Point(369, 107)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(125, 27)
        Me.txt_apellido.TabIndex = 44
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(236, 107)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(125, 27)
        Me.txt_nombre.TabIndex = 43
        '
        'txt_cedula
        '
        Me.txt_cedula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_cedula.Enabled = False
        Me.txt_cedula.Location = New System.Drawing.Point(103, 107)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(125, 27)
        Me.txt_cedula.TabIndex = 42
        '
        'txt_correo
        '
        Me.txt_correo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_correo.Enabled = False
        Me.txt_correo.Location = New System.Drawing.Point(599, 107)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(190, 27)
        Me.txt_correo.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Direccion"
        '
        'txt_direccion
        '
        Me.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_direccion.Enabled = False
        Me.txt_direccion.Location = New System.Drawing.Point(13, 179)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(461, 27)
        Me.txt_direccion.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(500, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 20)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Salario Base"
        '
        'txt_salario
        '
        Me.txt_salario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_salario.Enabled = False
        Me.txt_salario.Location = New System.Drawing.Point(500, 179)
        Me.txt_salario.Name = "txt_salario"
        Me.txt_salario.Size = New System.Drawing.Size(211, 27)
        Me.txt_salario.TabIndex = 50
        '
        'cb_categoria
        '
        Me.cb_categoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_categoria.Enabled = False
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(423, 239)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(338, 28)
        Me.cb_categoria.TabIndex = 54
        Me.cb_categoria.Text = "--Seleccionar--"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(423, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 20)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Categoria"
        '
        'cb_facultad
        '
        Me.cb_facultad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_facultad.Enabled = False
        Me.cb_facultad.FormattingEnabled = True
        Me.cb_facultad.Items.AddRange(New Object() {"--Seleccionar"})
        Me.cb_facultad.Location = New System.Drawing.Point(13, 239)
        Me.cb_facultad.Name = "cb_facultad"
        Me.cb_facultad.Size = New System.Drawing.Size(373, 28)
        Me.cb_facultad.TabIndex = 52
        Me.cb_facultad.Text = "--Seleccionar--"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 20)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Facultad"
        '
        'rb_codigo
        '
        Me.rb_codigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rb_codigo.AutoSize = True
        Me.rb_codigo.Location = New System.Drawing.Point(535, 576)
        Me.rb_codigo.Name = "rb_codigo"
        Me.rb_codigo.Size = New System.Drawing.Size(79, 24)
        Me.rb_codigo.TabIndex = 65
        Me.rb_codigo.Text = "Codigo"
        Me.rb_codigo.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_limpiar.Location = New System.Drawing.Point(676, 286)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(94, 29)
        Me.btn_limpiar.TabIndex = 64
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'dgv_profesor
        '
        Me.dgv_profesor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv_profesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_profesor.Location = New System.Drawing.Point(13, 321)
        Me.dgv_profesor.Name = "dgv_profesor"
        Me.dgv_profesor.RowHeadersWidth = 51
        Me.dgv_profesor.RowTemplate.Height = 29
        Me.dgv_profesor.Size = New System.Drawing.Size(757, 188)
        Me.dgv_profesor.TabIndex = 63
        '
        'rb_apellido
        '
        Me.rb_apellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rb_apellido.AutoSize = True
        Me.rb_apellido.Location = New System.Drawing.Point(626, 546)
        Me.rb_apellido.Name = "rb_apellido"
        Me.rb_apellido.Size = New System.Drawing.Size(87, 24)
        Me.rb_apellido.TabIndex = 62
        Me.rb_apellido.Text = "Apellido"
        Me.rb_apellido.UseVisualStyleBackColor = True
        '
        'rb_nombre
        '
        Me.rb_nombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rb_nombre.AutoSize = True
        Me.rb_nombre.Location = New System.Drawing.Point(535, 546)
        Me.rb_nombre.Name = "rb_nombre"
        Me.rb_nombre.Size = New System.Drawing.Size(85, 24)
        Me.rb_nombre.TabIndex = 61
        Me.rb_nombre.Text = "Nombre"
        Me.rb_nombre.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(535, 521)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Listar por:"
        '
        'btn_listar
        '
        Me.btn_listar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_listar.Location = New System.Drawing.Point(617, 574)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(94, 29)
        Me.btn_listar.TabIndex = 59
        Me.btn_listar.Text = "Listar"
        Me.btn_listar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(386, 546)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(94, 29)
        Me.btn_eliminar.TabIndex = 58
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Location = New System.Drawing.Point(261, 546)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(94, 29)
        Me.btn_modificar.TabIndex = 57
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_agregar.Enabled = False
        Me.btn_agregar.Location = New System.Drawing.Point(141, 546)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(94, 29)
        Me.btn_agregar.TabIndex = 56
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_buscar.Location = New System.Drawing.Point(13, 550)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(94, 29)
        Me.btn_buscar.TabIndex = 55
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 635)
        Me.Controls.Add(Me.rb_codigo)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.dgv_profesor)
        Me.Controls.Add(Me.rb_apellido)
        Me.Controls.Add(Me.rb_nombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_listar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cb_categoria)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cb_facultad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_salario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Name = "Form4"
        Me.Text = "Profesor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_profesor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_salario As TextBox
    Friend WithEvents cb_categoria As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cb_facultad As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents rb_codigo As RadioButton
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents dgv_profesor As DataGridView
    Friend WithEvents rb_apellido As RadioButton
    Friend WithEvents rb_nombre As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_listar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_buscar As Button
End Class
