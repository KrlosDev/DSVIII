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
        Me.lbl_Numero1 = New System.Windows.Forms.Label()
        Me.txt_Numero1 = New System.Windows.Forms.TextBox()
        Me.lbl_Numero2 = New System.Windows.Forms.Label()
        Me.txt_Numero2 = New System.Windows.Forms.TextBox()
        Me.lbl_Resultado = New System.Windows.Forms.Label()
        Me.txt_Resultado = New System.Windows.Forms.TextBox()
        Me.btn_Sumar = New System.Windows.Forms.Button()
        Me.btn_Restar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(309, 25)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(158, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Calculadora"
        '
        'lbl_Numero1
        '
        Me.lbl_Numero1.AutoSize = True
        Me.lbl_Numero1.Location = New System.Drawing.Point(133, 125)
        Me.lbl_Numero1.Name = "lbl_Numero1"
        Me.lbl_Numero1.Size = New System.Drawing.Size(60, 15)
        Me.lbl_Numero1.TabIndex = 1
        Me.lbl_Numero1.Text = "Numero 1"
        '
        'txt_Numero1
        '
        Me.txt_Numero1.Location = New System.Drawing.Point(208, 117)
        Me.txt_Numero1.Name = "txt_Numero1"
        Me.txt_Numero1.Size = New System.Drawing.Size(100, 23)
        Me.txt_Numero1.TabIndex = 2
        '
        'lbl_Numero2
        '
        Me.lbl_Numero2.AutoSize = True
        Me.lbl_Numero2.Location = New System.Drawing.Point(133, 172)
        Me.lbl_Numero2.Name = "lbl_Numero2"
        Me.lbl_Numero2.Size = New System.Drawing.Size(60, 15)
        Me.lbl_Numero2.TabIndex = 3
        Me.lbl_Numero2.Text = "Numero 2"
        '
        'txt_Numero2
        '
        Me.txt_Numero2.Location = New System.Drawing.Point(208, 164)
        Me.txt_Numero2.Name = "txt_Numero2"
        Me.txt_Numero2.Size = New System.Drawing.Size(100, 23)
        Me.txt_Numero2.TabIndex = 4
        '
        'lbl_Resultado
        '
        Me.lbl_Resultado.AutoSize = True
        Me.lbl_Resultado.Location = New System.Drawing.Point(133, 214)
        Me.lbl_Resultado.Name = "lbl_Resultado"
        Me.lbl_Resultado.Size = New System.Drawing.Size(59, 15)
        Me.lbl_Resultado.TabIndex = 5
        Me.lbl_Resultado.Text = "Resultado"
        Me.lbl_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Resultado
        '
        Me.txt_Resultado.Location = New System.Drawing.Point(208, 206)
        Me.txt_Resultado.Name = "txt_Resultado"
        Me.txt_Resultado.Size = New System.Drawing.Size(100, 23)
        Me.txt_Resultado.TabIndex = 6
        '
        'btn_Sumar
        '
        Me.btn_Sumar.Location = New System.Drawing.Point(369, 113)
        Me.btn_Sumar.Name = "btn_Sumar"
        Me.btn_Sumar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sumar.TabIndex = 7
        Me.btn_Sumar.Text = "Sumar"
        Me.btn_Sumar.UseVisualStyleBackColor = True
        '
        'btn_Restar
        '
        Me.btn_Restar.Location = New System.Drawing.Point(369, 163)
        Me.btn_Restar.Name = "btn_Restar"
        Me.btn_Restar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Restar.TabIndex = 8
        Me.btn_Restar.Text = "Restar"
        Me.btn_Restar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Restar)
        Me.Controls.Add(Me.btn_Sumar)
        Me.Controls.Add(Me.txt_Resultado)
        Me.Controls.Add(Me.lbl_Resultado)
        Me.Controls.Add(Me.txt_Numero2)
        Me.Controls.Add(Me.lbl_Numero2)
        Me.Controls.Add(Me.txt_Numero1)
        Me.Controls.Add(Me.lbl_Numero1)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Numero1 As Label
    Friend WithEvents txt_Numero1 As TextBox
    Friend WithEvents lbl_Numero2 As Label
    Friend WithEvents txt_Numero2 As TextBox
    Friend WithEvents lbl_Resultado As Label
    Friend WithEvents txt_Resultado As TextBox
    Friend WithEvents btn_Sumar As Button
    Friend WithEvents btn_Restar As Button
End Class
