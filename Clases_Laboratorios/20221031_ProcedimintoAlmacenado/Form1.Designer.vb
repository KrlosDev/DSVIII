<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lst_Cliente = New System.Windows.Forms.ListBox()
        Me.btn_Listar = New System.Windows.Forms.Button()
        Me.lbl_Cedula = New System.Windows.Forms.Label()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.dgv_Cliente = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_Cliente
        '
        Me.lst_Cliente.FormattingEnabled = True
        Me.lst_Cliente.ItemHeight = 15
        Me.lst_Cliente.Location = New System.Drawing.Point(12, 75)
        Me.lst_Cliente.Name = "lst_Cliente"
        Me.lst_Cliente.Size = New System.Drawing.Size(252, 109)
        Me.lst_Cliente.TabIndex = 0
        '
        'btn_Listar
        '
        Me.btn_Listar.Location = New System.Drawing.Point(66, 32)
        Me.btn_Listar.Name = "btn_Listar"
        Me.btn_Listar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Listar.TabIndex = 1
        Me.btn_Listar.Text = "Listar"
        Me.btn_Listar.UseVisualStyleBackColor = True
        '
        'lbl_Cedula
        '
        Me.lbl_Cedula.AutoSize = True
        Me.lbl_Cedula.Location = New System.Drawing.Point(317, 59)
        Me.lbl_Cedula.Name = "lbl_Cedula"
        Me.lbl_Cedula.Size = New System.Drawing.Size(44, 15)
        Me.lbl_Cedula.TabIndex = 2
        Me.lbl_Cedula.Text = "Cédula"
        '
        'txt_Cedula
        '
        Me.txt_Cedula.Location = New System.Drawing.Point(384, 51)
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(107, 23)
        Me.txt_Cedula.TabIndex = 3
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(317, 99)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Nombre.TabIndex = 4
        Me.lbl_Nombre.Text = "Nombre"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(384, 91)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(107, 23)
        Me.txt_Nombre.TabIndex = 5
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Location = New System.Drawing.Point(317, 150)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Apellido.TabIndex = 6
        Me.lbl_Apellido.Text = "Apellido"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(384, 147)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(107, 23)
        Me.txt_Apellido.TabIndex = 7
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(512, 50)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 8
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(512, 95)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 9
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(512, 142)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 10
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(512, 185)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 11
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'dgv_Cliente
        '
        Me.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Cliente.Location = New System.Drawing.Point(35, 200)
        Me.dgv_Cliente.Name = "dgv_Cliente"
        Me.dgv_Cliente.RowTemplate.Height = 25
        Me.dgv_Cliente.Size = New System.Drawing.Size(456, 150)
        Me.dgv_Cliente.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgv_Cliente)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.lbl_Apellido)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.txt_Cedula)
        Me.Controls.Add(Me.lbl_Cedula)
        Me.Controls.Add(Me.btn_Listar)
        Me.Controls.Add(Me.lst_Cliente)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_Cliente As ListBox
    Friend WithEvents btn_Listar As Button
    Friend WithEvents lbl_Cedula As Label
    Friend WithEvents txt_Cedula As TextBox
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents lbl_Apellido As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents dgv_Cliente As DataGridView
End Class
