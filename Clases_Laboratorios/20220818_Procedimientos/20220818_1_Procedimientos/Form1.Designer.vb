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
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.lbl_Mensaje = New System.Windows.Forms.Label()
        Me.txt_Mensaje = New System.Windows.Forms.TextBox()
        Me.btn_Proc_01 = New System.Windows.Forms.Button()
        Me.btn_Proc_01_Rep = New System.Windows.Forms.Button()
        Me.btn_Proc_Par_01 = New System.Windows.Forms.Button()
        Me.btn_Proc_Par_02 = New System.Windows.Forms.Button()
        Me.btn_Proc_Sobrecarga = New System.Windows.Forms.Button()
        Me.btn_Sobr_02 = New System.Windows.Forms.Button()
        Me.btn_Proc_Sobr_03 = New System.Windows.Forms.Button()
        Me.btn_Funcion_01 = New System.Windows.Forms.Button()
        Me.btn_Suma = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(113, 22)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(346, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Procedimientos y Funciones"
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.AutoSize = True
        Me.lbl_Mensaje.Location = New System.Drawing.Point(146, 99)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Mensaje.TabIndex = 1
        Me.lbl_Mensaje.Text = "Mensaje"
        '
        'txt_Mensaje
        '
        Me.txt_Mensaje.Location = New System.Drawing.Point(235, 96)
        Me.txt_Mensaje.Name = "txt_Mensaje"
        Me.txt_Mensaje.Size = New System.Drawing.Size(100, 23)
        Me.txt_Mensaje.TabIndex = 2
        '
        'btn_Proc_01
        '
        Me.btn_Proc_01.Location = New System.Drawing.Point(141, 155)
        Me.btn_Proc_01.Name = "btn_Proc_01"
        Me.btn_Proc_01.Size = New System.Drawing.Size(75, 23)
        Me.btn_Proc_01.TabIndex = 3
        Me.btn_Proc_01.Text = "Proc_01"
        Me.btn_Proc_01.UseVisualStyleBackColor = True
        '
        'btn_Proc_01_Rep
        '
        Me.btn_Proc_01_Rep.Location = New System.Drawing.Point(235, 155)
        Me.btn_Proc_01_Rep.Name = "btn_Proc_01_Rep"
        Me.btn_Proc_01_Rep.Size = New System.Drawing.Size(75, 23)
        Me.btn_Proc_01_Rep.TabIndex = 4
        Me.btn_Proc_01_Rep.Text = "Proc_01_Repetido"
        Me.btn_Proc_01_Rep.UseVisualStyleBackColor = True
        '
        'btn_Proc_Par_01
        '
        Me.btn_Proc_Par_01.Location = New System.Drawing.Point(337, 155)
        Me.btn_Proc_Par_01.Name = "btn_Proc_Par_01"
        Me.btn_Proc_Par_01.Size = New System.Drawing.Size(90, 23)
        Me.btn_Proc_Par_01.TabIndex = 5
        Me.btn_Proc_Par_01.Text = "Proc_Par_01"
        Me.btn_Proc_Par_01.UseVisualStyleBackColor = True
        '
        'btn_Proc_Par_02
        '
        Me.btn_Proc_Par_02.Location = New System.Drawing.Point(453, 155)
        Me.btn_Proc_Par_02.Name = "btn_Proc_Par_02"
        Me.btn_Proc_Par_02.Size = New System.Drawing.Size(75, 23)
        Me.btn_Proc_Par_02.TabIndex = 6
        Me.btn_Proc_Par_02.Text = "Proc_Par_02"
        Me.btn_Proc_Par_02.UseVisualStyleBackColor = True
        '
        'btn_Proc_Sobrecarga
        '
        Me.btn_Proc_Sobrecarga.Location = New System.Drawing.Point(113, 196)
        Me.btn_Proc_Sobrecarga.Name = "btn_Proc_Sobrecarga"
        Me.btn_Proc_Sobrecarga.Size = New System.Drawing.Size(103, 29)
        Me.btn_Proc_Sobrecarga.TabIndex = 7
        Me.btn_Proc_Sobrecarga.Text = "Proc_Sobrecarga"
        Me.btn_Proc_Sobrecarga.UseVisualStyleBackColor = True
        '
        'btn_Sobr_02
        '
        Me.btn_Sobr_02.Location = New System.Drawing.Point(235, 199)
        Me.btn_Sobr_02.Name = "btn_Sobr_02"
        Me.btn_Sobr_02.Size = New System.Drawing.Size(100, 23)
        Me.btn_Sobr_02.TabIndex = 8
        Me.btn_Sobr_02.Text = "Proc_Sobr_02"
        Me.btn_Sobr_02.UseVisualStyleBackColor = True
        '
        'btn_Proc_Sobr_03
        '
        Me.btn_Proc_Sobr_03.Location = New System.Drawing.Point(352, 199)
        Me.btn_Proc_Sobr_03.Name = "btn_Proc_Sobr_03"
        Me.btn_Proc_Sobr_03.Size = New System.Drawing.Size(75, 23)
        Me.btn_Proc_Sobr_03.TabIndex = 9
        Me.btn_Proc_Sobr_03.Text = "Proc_Sobr_03"
        Me.btn_Proc_Sobr_03.UseVisualStyleBackColor = True
        '
        'btn_Funcion_01
        '
        Me.btn_Funcion_01.Location = New System.Drawing.Point(114, 246)
        Me.btn_Funcion_01.Name = "btn_Funcion_01"
        Me.btn_Funcion_01.Size = New System.Drawing.Size(75, 23)
        Me.btn_Funcion_01.TabIndex = 10
        Me.btn_Funcion_01.Text = "Funcion 01"
        Me.btn_Funcion_01.UseVisualStyleBackColor = True
        '
        'btn_Suma
        '
        Me.btn_Suma.Location = New System.Drawing.Point(229, 242)
        Me.btn_Suma.Name = "btn_Suma"
        Me.btn_Suma.Size = New System.Drawing.Size(75, 23)
        Me.btn_Suma.TabIndex = 11
        Me.btn_Suma.Text = "Suma"
        Me.btn_Suma.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Suma)
        Me.Controls.Add(Me.btn_Funcion_01)
        Me.Controls.Add(Me.btn_Proc_Sobr_03)
        Me.Controls.Add(Me.btn_Sobr_02)
        Me.Controls.Add(Me.btn_Proc_Sobrecarga)
        Me.Controls.Add(Me.btn_Proc_Par_02)
        Me.Controls.Add(Me.btn_Proc_Par_01)
        Me.Controls.Add(Me.btn_Proc_01_Rep)
        Me.Controls.Add(Me.btn_Proc_01)
        Me.Controls.Add(Me.txt_Mensaje)
        Me.Controls.Add(Me.lbl_Mensaje)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Mensaje As Label
    Friend WithEvents txt_Mensaje As TextBox
    Friend WithEvents btn_Proc_01 As Button
    Friend WithEvents btn_Proc_01_Rep As Button
    Friend WithEvents btn_Proc_Par_01 As Button
    Friend WithEvents btn_Proc_Par_02 As Button
    Friend WithEvents btn_Proc_Sobrecarga As Button
    Friend WithEvents btn_Sobr_02 As Button
    Friend WithEvents btn_Proc_Sobr_03 As Button
    Friend WithEvents btn_Funcion_01 As Button
    Friend WithEvents btn_Suma As Button
End Class
