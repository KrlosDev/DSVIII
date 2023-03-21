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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Contador = New System.Windows.Forms.Label()
        Me.txt_Contador = New System.Windows.Forms.TextBox()
        Me.btn_Contar = New System.Windows.Forms.Button()
        Me.tmr_Contador = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Iniciar = New System.Windows.Forms.Button()
        Me.btn_Detener = New System.Windows.Forms.Button()
        Me.btn_Continuar = New System.Windows.Forms.Button()
        Me.btn_Iniciar2 = New System.Windows.Forms.Button()
        Me.btn_IncDet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(235, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIMER"
        '
        'lbl_Contador
        '
        Me.lbl_Contador.AutoSize = True
        Me.lbl_Contador.Location = New System.Drawing.Point(119, 97)
        Me.lbl_Contador.Name = "lbl_Contador"
        Me.lbl_Contador.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Contador.TabIndex = 1
        Me.lbl_Contador.Text = "Contador"
        '
        'txt_Contador
        '
        Me.txt_Contador.Location = New System.Drawing.Point(209, 89)
        Me.txt_Contador.Name = "txt_Contador"
        Me.txt_Contador.Size = New System.Drawing.Size(79, 23)
        Me.txt_Contador.TabIndex = 2
        '
        'btn_Contar
        '
        Me.btn_Contar.Location = New System.Drawing.Point(325, 91)
        Me.btn_Contar.Name = "btn_Contar"
        Me.btn_Contar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Contar.TabIndex = 3
        Me.btn_Contar.Text = "Contar"
        Me.btn_Contar.UseVisualStyleBackColor = True
        '
        'tmr_Contador
        '
        '
        'btn_Iniciar
        '
        Me.btn_Iniciar.Location = New System.Drawing.Point(325, 120)
        Me.btn_Iniciar.Name = "btn_Iniciar"
        Me.btn_Iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Iniciar.TabIndex = 4
        Me.btn_Iniciar.Text = "Iniciar"
        Me.btn_Iniciar.UseVisualStyleBackColor = True
        '
        'btn_Detener
        '
        Me.btn_Detener.Location = New System.Drawing.Point(325, 149)
        Me.btn_Detener.Name = "btn_Detener"
        Me.btn_Detener.Size = New System.Drawing.Size(75, 23)
        Me.btn_Detener.TabIndex = 5
        Me.btn_Detener.Text = "Detener"
        Me.btn_Detener.UseVisualStyleBackColor = True
        '
        'btn_Continuar
        '
        Me.btn_Continuar.Location = New System.Drawing.Point(235, 149)
        Me.btn_Continuar.Name = "btn_Continuar"
        Me.btn_Continuar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Continuar.TabIndex = 6
        Me.btn_Continuar.Text = "Continuar"
        Me.btn_Continuar.UseVisualStyleBackColor = True
        '
        'btn_Iniciar2
        '
        Me.btn_Iniciar2.Location = New System.Drawing.Point(331, 187)
        Me.btn_Iniciar2.Name = "btn_Iniciar2"
        Me.btn_Iniciar2.Size = New System.Drawing.Size(75, 23)
        Me.btn_Iniciar2.TabIndex = 7
        Me.btn_Iniciar2.Text = "Iniciar"
        Me.btn_Iniciar2.UseVisualStyleBackColor = True
        '
        'btn_IncDet
        '
        Me.btn_IncDet.Location = New System.Drawing.Point(230, 188)
        Me.btn_IncDet.Name = "btn_IncDet"
        Me.btn_IncDet.Size = New System.Drawing.Size(75, 23)
        Me.btn_IncDet.TabIndex = 8
        Me.btn_IncDet.Text = "Inc/Det"
        Me.btn_IncDet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_IncDet)
        Me.Controls.Add(Me.btn_Iniciar2)
        Me.Controls.Add(Me.btn_Continuar)
        Me.Controls.Add(Me.btn_Detener)
        Me.Controls.Add(Me.btn_Iniciar)
        Me.Controls.Add(Me.btn_Contar)
        Me.Controls.Add(Me.txt_Contador)
        Me.Controls.Add(Me.lbl_Contador)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Contador As Label
    Friend WithEvents txt_Contador As TextBox
    Friend WithEvents btn_Contar As Button
    Friend WithEvents tmr_Contador As Timer
    Friend WithEvents btn_Iniciar As Button
    Friend WithEvents btn_Detener As Button
    Friend WithEvents btn_Continuar As Button
    Friend WithEvents btn_Iniciar2 As Button
    Friend WithEvents btn_IncDet As Button
End Class
