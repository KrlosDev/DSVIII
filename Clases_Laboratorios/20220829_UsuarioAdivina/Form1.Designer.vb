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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Computadora = New System.Windows.Forms.TextBox()
        Me.btn_Iniciar = New System.Windows.Forms.Button()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Mensaje = New System.Windows.Forms.Label()
        Me.txt_Mensaje = New System.Windows.Forms.TextBox()
        Me.btn_Verificar = New System.Windows.Forms.Button()
        Me.lbl_Intentos = New System.Windows.Forms.Label()
        Me.txt_Intentos = New System.Windows.Forms.TextBox()
        Me.btn_Ocultar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(228, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario Adivina Número"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Computadora"
        Me.Label2.Visible = False
        '
        'txt_Computadora
        '
        Me.txt_Computadora.Location = New System.Drawing.Point(191, 87)
        Me.txt_Computadora.Name = "txt_Computadora"
        Me.txt_Computadora.Size = New System.Drawing.Size(100, 23)
        Me.txt_Computadora.TabIndex = 2
        Me.txt_Computadora.Visible = False
        '
        'btn_Iniciar
        '
        Me.btn_Iniciar.Location = New System.Drawing.Point(357, 87)
        Me.btn_Iniciar.Name = "btn_Iniciar"
        Me.btn_Iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Iniciar.TabIndex = 3
        Me.btn_Iniciar.Text = "Iniciar"
        Me.btn_Iniciar.UseVisualStyleBackColor = True
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(76, 150)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(47, 15)
        Me.lbl_Usuario.TabIndex = 4
        Me.lbl_Usuario.Text = "Usuario"
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(191, 142)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(100, 23)
        Me.txt_Usuario.TabIndex = 5
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.AutoSize = True
        Me.lbl_Mensaje.Location = New System.Drawing.Point(80, 198)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Mensaje.TabIndex = 6
        Me.lbl_Mensaje.Text = "Mensaje"
        '
        'txt_Mensaje
        '
        Me.txt_Mensaje.Location = New System.Drawing.Point(191, 190)
        Me.txt_Mensaje.Name = "txt_Mensaje"
        Me.txt_Mensaje.Size = New System.Drawing.Size(100, 23)
        Me.txt_Mensaje.TabIndex = 7
        '
        'btn_Verificar
        '
        Me.btn_Verificar.Location = New System.Drawing.Point(357, 141)
        Me.btn_Verificar.Name = "btn_Verificar"
        Me.btn_Verificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Verificar.TabIndex = 8
        Me.btn_Verificar.Text = "Verificar"
        Me.btn_Verificar.UseVisualStyleBackColor = True
        '
        'lbl_Intentos
        '
        Me.lbl_Intentos.AutoSize = True
        Me.lbl_Intentos.Location = New System.Drawing.Point(85, 240)
        Me.lbl_Intentos.Name = "lbl_Intentos"
        Me.lbl_Intentos.Size = New System.Drawing.Size(50, 15)
        Me.lbl_Intentos.TabIndex = 9
        Me.lbl_Intentos.Text = "Intentos"
        '
        'txt_Intentos
        '
        Me.txt_Intentos.Location = New System.Drawing.Point(191, 232)
        Me.txt_Intentos.Name = "txt_Intentos"
        Me.txt_Intentos.Size = New System.Drawing.Size(100, 23)
        Me.txt_Intentos.TabIndex = 10
        '
        'btn_Ocultar
        '
        Me.btn_Ocultar.Location = New System.Drawing.Point(359, 191)
        Me.btn_Ocultar.Name = "btn_Ocultar"
        Me.btn_Ocultar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Ocultar.TabIndex = 11
        Me.btn_Ocultar.Text = "Ocultar"
        Me.btn_Ocultar.UseVisualStyleBackColor = True
        Me.btn_Ocultar.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Ocultar)
        Me.Controls.Add(Me.txt_Intentos)
        Me.Controls.Add(Me.lbl_Intentos)
        Me.Controls.Add(Me.btn_Verificar)
        Me.Controls.Add(Me.txt_Mensaje)
        Me.Controls.Add(Me.lbl_Mensaje)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.btn_Iniciar)
        Me.Controls.Add(Me.txt_Computadora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Computadora As TextBox
    Friend WithEvents btn_Iniciar As Button
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents lbl_Mensaje As Label
    Friend WithEvents txt_Mensaje As TextBox
    Friend WithEvents btn_Verificar As Button
    Friend WithEvents lbl_Intentos As Label
    Friend WithEvents txt_Intentos As TextBox
    Friend WithEvents btn_Ocultar As Button
End Class
