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
        Me.lbl_Entero = New System.Windows.Forms.Label()
        Me.txt_Entero = New System.Windows.Forms.TextBox()
        Me.lbl_Double = New System.Windows.Forms.Label()
        Me.txt_Double = New System.Windows.Forms.TextBox()
        Me.lbl_String = New System.Windows.Forms.Label()
        Me.txt_String = New System.Windows.Forms.TextBox()
        Me.btn_Cargar = New System.Windows.Forms.Button()
        Me.btn_Cambiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(258, 27)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(183, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Tipo de Datos"
        '
        'lbl_Entero
        '
        Me.lbl_Entero.AutoSize = True
        Me.lbl_Entero.Location = New System.Drawing.Point(64, 108)
        Me.lbl_Entero.Name = "lbl_Entero"
        Me.lbl_Entero.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Entero.TabIndex = 1
        Me.lbl_Entero.Text = "Entero"
        '
        'txt_Entero
        '
        Me.txt_Entero.Location = New System.Drawing.Point(123, 100)
        Me.txt_Entero.Name = "txt_Entero"
        Me.txt_Entero.Size = New System.Drawing.Size(100, 23)
        Me.txt_Entero.TabIndex = 2
        '
        'lbl_Double
        '
        Me.lbl_Double.AutoSize = True
        Me.lbl_Double.Location = New System.Drawing.Point(64, 150)
        Me.lbl_Double.Name = "lbl_Double"
        Me.lbl_Double.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Double.TabIndex = 3
        Me.lbl_Double.Text = "Double"
        '
        'txt_Double
        '
        Me.txt_Double.Location = New System.Drawing.Point(123, 142)
        Me.txt_Double.Name = "txt_Double"
        Me.txt_Double.Size = New System.Drawing.Size(100, 23)
        Me.txt_Double.TabIndex = 4
        '
        'lbl_String
        '
        Me.lbl_String.AutoSize = True
        Me.lbl_String.Location = New System.Drawing.Point(64, 192)
        Me.lbl_String.Name = "lbl_String"
        Me.lbl_String.Size = New System.Drawing.Size(38, 15)
        Me.lbl_String.TabIndex = 5
        Me.lbl_String.Text = "String"
        '
        'txt_String
        '
        Me.txt_String.Location = New System.Drawing.Point(123, 184)
        Me.txt_String.Name = "txt_String"
        Me.txt_String.Size = New System.Drawing.Size(100, 23)
        Me.txt_String.TabIndex = 6
        '
        'btn_Cargar
        '
        Me.btn_Cargar.Location = New System.Drawing.Point(123, 261)
        Me.btn_Cargar.Name = "btn_Cargar"
        Me.btn_Cargar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cargar.TabIndex = 7
        Me.btn_Cargar.Text = "Cargar"
        Me.btn_Cargar.UseVisualStyleBackColor = True
        '
        'btn_Cambiar
        '
        Me.btn_Cambiar.Location = New System.Drawing.Point(271, 99)
        Me.btn_Cambiar.Name = "btn_Cambiar"
        Me.btn_Cambiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cambiar.TabIndex = 8
        Me.btn_Cambiar.Text = "Cambiar"
        Me.btn_Cambiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Cambiar)
        Me.Controls.Add(Me.btn_Cargar)
        Me.Controls.Add(Me.txt_String)
        Me.Controls.Add(Me.lbl_String)
        Me.Controls.Add(Me.txt_Double)
        Me.Controls.Add(Me.lbl_Double)
        Me.Controls.Add(Me.txt_Entero)
        Me.Controls.Add(Me.lbl_Entero)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Entero As Label
    Friend WithEvents txt_Entero As TextBox
    Friend WithEvents lbl_Double As Label
    Friend WithEvents txt_Double As TextBox
    Friend WithEvents lbl_String As Label
    Friend WithEvents txt_String As TextBox
    Friend WithEvents btn_Cargar As Button
    Friend WithEvents btn_Cambiar As Button
End Class
