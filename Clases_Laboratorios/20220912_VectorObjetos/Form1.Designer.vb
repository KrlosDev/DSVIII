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
        Me.txt_Valor1 = New System.Windows.Forms.TextBox()
        Me.txt_Valor2 = New System.Windows.Forms.TextBox()
        Me.txt_Valor3 = New System.Windows.Forms.TextBox()
        Me.txt_Valor4 = New System.Windows.Forms.TextBox()
        Me.btn_Manual = New System.Windows.Forms.Button()
        Me.btn_For = New System.Windows.Forms.Button()
        Me.txt_Indice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Indice = New System.Windows.Forms.Button()
        Me.btn_1x1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(203, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vector de Objetos"
        '
        'txt_Valor1
        '
        Me.txt_Valor1.Location = New System.Drawing.Point(112, 110)
        Me.txt_Valor1.Name = "txt_Valor1"
        Me.txt_Valor1.Size = New System.Drawing.Size(100, 23)
        Me.txt_Valor1.TabIndex = 1
        '
        'txt_Valor2
        '
        Me.txt_Valor2.Location = New System.Drawing.Point(112, 151)
        Me.txt_Valor2.Name = "txt_Valor2"
        Me.txt_Valor2.Size = New System.Drawing.Size(100, 23)
        Me.txt_Valor2.TabIndex = 2
        '
        'txt_Valor3
        '
        Me.txt_Valor3.Location = New System.Drawing.Point(112, 190)
        Me.txt_Valor3.Name = "txt_Valor3"
        Me.txt_Valor3.Size = New System.Drawing.Size(100, 23)
        Me.txt_Valor3.TabIndex = 3
        '
        'txt_Valor4
        '
        Me.txt_Valor4.Location = New System.Drawing.Point(112, 234)
        Me.txt_Valor4.Name = "txt_Valor4"
        Me.txt_Valor4.Size = New System.Drawing.Size(100, 23)
        Me.txt_Valor4.TabIndex = 4
        '
        'btn_Manual
        '
        Me.btn_Manual.Location = New System.Drawing.Point(267, 112)
        Me.btn_Manual.Name = "btn_Manual"
        Me.btn_Manual.Size = New System.Drawing.Size(75, 23)
        Me.btn_Manual.TabIndex = 5
        Me.btn_Manual.Text = "Manual"
        Me.btn_Manual.UseVisualStyleBackColor = True
        '
        'btn_For
        '
        Me.btn_For.Location = New System.Drawing.Point(267, 151)
        Me.btn_For.Name = "btn_For"
        Me.btn_For.Size = New System.Drawing.Size(75, 23)
        Me.btn_For.TabIndex = 6
        Me.btn_For.Text = "For"
        Me.btn_For.UseVisualStyleBackColor = True
        '
        'txt_Indice
        '
        Me.txt_Indice.Location = New System.Drawing.Point(332, 190)
        Me.txt_Indice.Name = "txt_Indice"
        Me.txt_Indice.Size = New System.Drawing.Size(100, 23)
        Me.txt_Indice.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Indice"
        '
        'btn_Indice
        '
        Me.btn_Indice.Location = New System.Drawing.Point(267, 228)
        Me.btn_Indice.Name = "btn_Indice"
        Me.btn_Indice.Size = New System.Drawing.Size(75, 23)
        Me.btn_Indice.TabIndex = 9
        Me.btn_Indice.Text = "Indice"
        Me.btn_Indice.UseVisualStyleBackColor = True
        '
        'btn_1x1
        '
        Me.btn_1x1.Location = New System.Drawing.Point(271, 271)
        Me.btn_1x1.Name = "btn_1x1"
        Me.btn_1x1.Size = New System.Drawing.Size(75, 23)
        Me.btn_1x1.TabIndex = 10
        Me.btn_1x1.Text = "1 x 1"
        Me.btn_1x1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_1x1)
        Me.Controls.Add(Me.btn_Indice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Indice)
        Me.Controls.Add(Me.btn_For)
        Me.Controls.Add(Me.btn_Manual)
        Me.Controls.Add(Me.txt_Valor4)
        Me.Controls.Add(Me.txt_Valor3)
        Me.Controls.Add(Me.txt_Valor2)
        Me.Controls.Add(Me.txt_Valor1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Valor1 As TextBox
    Friend WithEvents txt_Valor2 As TextBox
    Friend WithEvents txt_Valor3 As TextBox
    Friend WithEvents txt_Valor4 As TextBox
    Friend WithEvents btn_Manual As Button
    Friend WithEvents btn_For As Button
    Friend WithEvents txt_Indice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Indice As Button
    Friend WithEvents btn_1x1 As Button
End Class
