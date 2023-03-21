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
        Me.btn_Crear = New System.Windows.Forms.Button()
        Me.txt_Valor = New System.Windows.Forms.TextBox()
        Me.btn_Varios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(213, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Creación de Botones"
        '
        'btn_Crear
        '
        Me.btn_Crear.Location = New System.Drawing.Point(291, 84)
        Me.btn_Crear.Name = "btn_Crear"
        Me.btn_Crear.Size = New System.Drawing.Size(91, 26)
        Me.btn_Crear.TabIndex = 1
        Me.btn_Crear.Text = "Crear"
        Me.btn_Crear.UseVisualStyleBackColor = True
        '
        'txt_Valor
        '
        Me.txt_Valor.Location = New System.Drawing.Point(291, 127)
        Me.txt_Valor.Name = "txt_Valor"
        Me.txt_Valor.Size = New System.Drawing.Size(100, 23)
        Me.txt_Valor.TabIndex = 2
        '
        'btn_Varios
        '
        Me.btn_Varios.Location = New System.Drawing.Point(297, 187)
        Me.btn_Varios.Name = "btn_Varios"
        Me.btn_Varios.Size = New System.Drawing.Size(75, 23)
        Me.btn_Varios.TabIndex = 3
        Me.btn_Varios.Text = "Varios"
        Me.btn_Varios.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Varios)
        Me.Controls.Add(Me.txt_Valor)
        Me.Controls.Add(Me.btn_Crear)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Crear As Button
    Friend WithEvents txt_Valor As TextBox
    Friend WithEvents btn_Varios As Button
End Class
