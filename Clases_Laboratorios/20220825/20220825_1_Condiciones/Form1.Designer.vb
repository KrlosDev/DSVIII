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
        Me.lbl_Valor = New System.Windows.Forms.Label()
        Me.txt_Valor = New System.Windows.Forms.TextBox()
        Me.lbl_Mensaje = New System.Windows.Forms.Label()
        Me.txt_Mensaje = New System.Windows.Forms.TextBox()
        Me.btn_ifSimple = New System.Windows.Forms.Button()
        Me.btn_ifElse = New System.Windows.Forms.Button()
        Me.btn_Mayor100 = New System.Windows.Forms.Button()
        Me.btn_IfAnidado = New System.Windows.Forms.Button()
        Me.btn_elseIf = New System.Windows.Forms.Button()
        Me.btn_NoAnidado = New System.Windows.Forms.Button()
        Me.btn_AND = New System.Windows.Forms.Button()
        Me.btn_Or = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(163, 9)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(375, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "ESTRUCTURA ALTERNATIVA"
        '
        'lbl_Valor
        '
        Me.lbl_Valor.AutoSize = True
        Me.lbl_Valor.Location = New System.Drawing.Point(50, 93)
        Me.lbl_Valor.Name = "lbl_Valor"
        Me.lbl_Valor.Size = New System.Drawing.Size(33, 15)
        Me.lbl_Valor.TabIndex = 1
        Me.lbl_Valor.Text = "Valor"
        '
        'txt_Valor
        '
        Me.txt_Valor.Location = New System.Drawing.Point(129, 85)
        Me.txt_Valor.Name = "txt_Valor"
        Me.txt_Valor.Size = New System.Drawing.Size(100, 23)
        Me.txt_Valor.TabIndex = 2
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.AutoSize = True
        Me.lbl_Mensaje.Location = New System.Drawing.Point(56, 140)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Mensaje.TabIndex = 3
        Me.lbl_Mensaje.Text = "Mensaje"
        '
        'txt_Mensaje
        '
        Me.txt_Mensaje.Location = New System.Drawing.Point(129, 137)
        Me.txt_Mensaje.Name = "txt_Mensaje"
        Me.txt_Mensaje.Size = New System.Drawing.Size(100, 23)
        Me.txt_Mensaje.TabIndex = 4
        '
        'btn_ifSimple
        '
        Me.btn_ifSimple.Location = New System.Drawing.Point(72, 195)
        Me.btn_ifSimple.Name = "btn_ifSimple"
        Me.btn_ifSimple.Size = New System.Drawing.Size(75, 23)
        Me.btn_ifSimple.TabIndex = 5
        Me.btn_ifSimple.Text = "if Simple"
        Me.btn_ifSimple.UseVisualStyleBackColor = True
        '
        'btn_ifElse
        '
        Me.btn_ifElse.Location = New System.Drawing.Point(72, 240)
        Me.btn_ifElse.Name = "btn_ifElse"
        Me.btn_ifElse.Size = New System.Drawing.Size(75, 23)
        Me.btn_ifElse.TabIndex = 6
        Me.btn_ifElse.Text = "if else"
        Me.btn_ifElse.UseVisualStyleBackColor = True
        '
        'btn_Mayor100
        '
        Me.btn_Mayor100.Location = New System.Drawing.Point(76, 285)
        Me.btn_Mayor100.Name = "btn_Mayor100"
        Me.btn_Mayor100.Size = New System.Drawing.Size(75, 23)
        Me.btn_Mayor100.TabIndex = 7
        Me.btn_Mayor100.Text = "Mayor 100 o no"
        Me.btn_Mayor100.UseVisualStyleBackColor = True
        '
        'btn_IfAnidado
        '
        Me.btn_IfAnidado.Location = New System.Drawing.Point(76, 324)
        Me.btn_IfAnidado.Name = "btn_IfAnidado"
        Me.btn_IfAnidado.Size = New System.Drawing.Size(75, 23)
        Me.btn_IfAnidado.TabIndex = 8
        Me.btn_IfAnidado.Text = "if Anidado"
        Me.btn_IfAnidado.UseVisualStyleBackColor = True
        '
        'btn_elseIf
        '
        Me.btn_elseIf.Location = New System.Drawing.Point(245, 197)
        Me.btn_elseIf.Name = "btn_elseIf"
        Me.btn_elseIf.Size = New System.Drawing.Size(75, 23)
        Me.btn_elseIf.TabIndex = 9
        Me.btn_elseIf.Text = "elseIf"
        Me.btn_elseIf.UseVisualStyleBackColor = True
        '
        'btn_NoAnidado
        '
        Me.btn_NoAnidado.Location = New System.Drawing.Point(245, 240)
        Me.btn_NoAnidado.Name = "btn_NoAnidado"
        Me.btn_NoAnidado.Size = New System.Drawing.Size(75, 23)
        Me.btn_NoAnidado.TabIndex = 10
        Me.btn_NoAnidado.Text = "no anidado"
        Me.btn_NoAnidado.UseVisualStyleBackColor = True
        '
        'btn_AND
        '
        Me.btn_AND.Location = New System.Drawing.Point(245, 285)
        Me.btn_AND.Name = "btn_AND"
        Me.btn_AND.Size = New System.Drawing.Size(75, 23)
        Me.btn_AND.TabIndex = 11
        Me.btn_AND.Text = "AND"
        Me.btn_AND.UseVisualStyleBackColor = True
        '
        'btn_Or
        '
        Me.btn_Or.Location = New System.Drawing.Point(248, 324)
        Me.btn_Or.Name = "btn_Or"
        Me.btn_Or.Size = New System.Drawing.Size(75, 23)
        Me.btn_Or.TabIndex = 12
        Me.btn_Or.Text = "OR"
        Me.btn_Or.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Or)
        Me.Controls.Add(Me.btn_AND)
        Me.Controls.Add(Me.btn_NoAnidado)
        Me.Controls.Add(Me.btn_elseIf)
        Me.Controls.Add(Me.btn_IfAnidado)
        Me.Controls.Add(Me.btn_Mayor100)
        Me.Controls.Add(Me.btn_ifElse)
        Me.Controls.Add(Me.btn_ifSimple)
        Me.Controls.Add(Me.txt_Mensaje)
        Me.Controls.Add(Me.lbl_Mensaje)
        Me.Controls.Add(Me.txt_Valor)
        Me.Controls.Add(Me.lbl_Valor)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Valor As Label
    Friend WithEvents txt_Valor As TextBox
    Friend WithEvents lbl_Mensaje As Label
    Friend WithEvents txt_Mensaje As TextBox
    Friend WithEvents btn_ifSimple As Button
    Friend WithEvents btn_ifElse As Button
    Friend WithEvents btn_Mayor100 As Button
    Friend WithEvents btn_IfAnidado As Button
    Friend WithEvents btn_elseIf As Button
    Friend WithEvents btn_NoAnidado As Button
    Friend WithEvents btn_AND As Button
    Friend WithEvents btn_Or As Button
End Class
