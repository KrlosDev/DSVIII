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
        Me.lbl_Numero = New System.Windows.Forms.Label()
        Me.txt_Numero = New System.Windows.Forms.TextBox()
        Me.btn_Generar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(207, 16)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(230, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Número Aleatorio"
        '
        'lbl_Numero
        '
        Me.lbl_Numero.AutoSize = True
        Me.lbl_Numero.Location = New System.Drawing.Point(99, 101)
        Me.lbl_Numero.Name = "lbl_Numero"
        Me.lbl_Numero.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Numero.TabIndex = 1
        Me.lbl_Numero.Text = "Numero"
        '
        'txt_Numero
        '
        Me.txt_Numero.Location = New System.Drawing.Point(183, 93)
        Me.txt_Numero.Name = "txt_Numero"
        Me.txt_Numero.Size = New System.Drawing.Size(100, 23)
        Me.txt_Numero.TabIndex = 2
        '
        'btn_Generar
        '
        Me.btn_Generar.Location = New System.Drawing.Point(183, 150)
        Me.btn_Generar.Name = "btn_Generar"
        Me.btn_Generar.Size = New System.Drawing.Size(87, 28)
        Me.btn_Generar.TabIndex = 3
        Me.btn_Generar.Text = "Generar"
        Me.btn_Generar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Generar)
        Me.Controls.Add(Me.txt_Numero)
        Me.Controls.Add(Me.lbl_Numero)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Numero As Label
    Friend WithEvents txt_Numero As TextBox
    Friend WithEvents btn_Generar As Button
End Class
