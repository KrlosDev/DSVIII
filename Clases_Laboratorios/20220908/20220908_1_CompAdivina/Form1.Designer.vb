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
        Me.lbl_Computadora = New System.Windows.Forms.Label()
        Me.txt_Computadora = New System.Windows.Forms.TextBox()
        Me.btn_Bajo = New System.Windows.Forms.Button()
        Me.btn_Alto = New System.Windows.Forms.Button()
        Me.btn_Correcto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Superior = New System.Windows.Forms.TextBox()
        Me.lbl_Inferior = New System.Windows.Forms.Label()
        Me.txt_Inferior = New System.Windows.Forms.TextBox()
        Me.btn_Iniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(291, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Computador Adivina"
        '
        'lbl_Computadora
        '
        Me.lbl_Computadora.AutoSize = True
        Me.lbl_Computadora.Location = New System.Drawing.Point(78, 99)
        Me.lbl_Computadora.Name = "lbl_Computadora"
        Me.lbl_Computadora.Size = New System.Drawing.Size(81, 15)
        Me.lbl_Computadora.TabIndex = 1
        Me.lbl_Computadora.Text = "Computadora"
        '
        'txt_Computadora
        '
        Me.txt_Computadora.Location = New System.Drawing.Point(165, 91)
        Me.txt_Computadora.Name = "txt_Computadora"
        Me.txt_Computadora.Size = New System.Drawing.Size(100, 23)
        Me.txt_Computadora.TabIndex = 2
        '
        'btn_Bajo
        '
        Me.btn_Bajo.Location = New System.Drawing.Point(110, 146)
        Me.btn_Bajo.Name = "btn_Bajo"
        Me.btn_Bajo.Size = New System.Drawing.Size(75, 23)
        Me.btn_Bajo.TabIndex = 3
        Me.btn_Bajo.Text = "Bajo"
        Me.btn_Bajo.UseVisualStyleBackColor = True
        '
        'btn_Alto
        '
        Me.btn_Alto.Location = New System.Drawing.Point(201, 146)
        Me.btn_Alto.Name = "btn_Alto"
        Me.btn_Alto.Size = New System.Drawing.Size(75, 23)
        Me.btn_Alto.TabIndex = 4
        Me.btn_Alto.Text = "Alto"
        Me.btn_Alto.UseVisualStyleBackColor = True
        '
        'btn_Correcto
        '
        Me.btn_Correcto.Location = New System.Drawing.Point(291, 146)
        Me.btn_Correcto.Name = "btn_Correcto"
        Me.btn_Correcto.Size = New System.Drawing.Size(75, 23)
        Me.btn_Correcto.TabIndex = 5
        Me.btn_Correcto.Text = "Correcto"
        Me.btn_Correcto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(419, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Superior"
        '
        'txt_Superior
        '
        Me.txt_Superior.Location = New System.Drawing.Point(487, 86)
        Me.txt_Superior.Name = "txt_Superior"
        Me.txt_Superior.Size = New System.Drawing.Size(100, 23)
        Me.txt_Superior.TabIndex = 7
        '
        'lbl_Inferior
        '
        Me.lbl_Inferior.AutoSize = True
        Me.lbl_Inferior.Location = New System.Drawing.Point(419, 124)
        Me.lbl_Inferior.Name = "lbl_Inferior"
        Me.lbl_Inferior.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Inferior.TabIndex = 8
        Me.lbl_Inferior.Text = "Inferior"
        '
        'txt_Inferior
        '
        Me.txt_Inferior.Location = New System.Drawing.Point(487, 121)
        Me.txt_Inferior.Name = "txt_Inferior"
        Me.txt_Inferior.Size = New System.Drawing.Size(100, 23)
        Me.txt_Inferior.TabIndex = 9
        '
        'btn_Iniciar
        '
        Me.btn_Iniciar.Location = New System.Drawing.Point(282, 91)
        Me.btn_Iniciar.Name = "btn_Iniciar"
        Me.btn_Iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Iniciar.TabIndex = 10
        Me.btn_Iniciar.Text = "Iniciar"
        Me.btn_Iniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Iniciar)
        Me.Controls.Add(Me.txt_Inferior)
        Me.Controls.Add(Me.lbl_Inferior)
        Me.Controls.Add(Me.txt_Superior)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Correcto)
        Me.Controls.Add(Me.btn_Alto)
        Me.Controls.Add(Me.btn_Bajo)
        Me.Controls.Add(Me.txt_Computadora)
        Me.Controls.Add(Me.lbl_Computadora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Computadora As Label
    Friend WithEvents txt_Computadora As TextBox
    Friend WithEvents btn_Bajo As Button
    Friend WithEvents btn_Alto As Button
    Friend WithEvents btn_Correcto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Superior As TextBox
    Friend WithEvents lbl_Inferior As Label
    Friend WithEvents txt_Inferior As TextBox
    Friend WithEvents btn_Iniciar As Button
End Class
