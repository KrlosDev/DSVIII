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
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Valor1 = New System.Windows.Forms.TextBox()
        Me.lbl_Valor2 = New System.Windows.Forms.Label()
        Me.txt_Valor2 = New System.Windows.Forms.TextBox()
        Me.lbl_Valor3 = New System.Windows.Forms.Label()
        Me.txt_Valor3 = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(194, 34)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(167, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "VALIDACION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor1"
        '
        'txt_Valor1
        '
        Me.txt_Valor1.Location = New System.Drawing.Point(152, 111)
        Me.txt_Valor1.Name = "txt_Valor1"
        Me.txt_Valor1.Size = New System.Drawing.Size(156, 23)
        Me.txt_Valor1.TabIndex = 2
        '
        'lbl_Valor2
        '
        Me.lbl_Valor2.AutoSize = True
        Me.lbl_Valor2.Location = New System.Drawing.Point(86, 161)
        Me.lbl_Valor2.Name = "lbl_Valor2"
        Me.lbl_Valor2.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Valor2.TabIndex = 3
        Me.lbl_Valor2.Text = "Valor2"
        '
        'txt_Valor2
        '
        Me.txt_Valor2.Location = New System.Drawing.Point(152, 153)
        Me.txt_Valor2.Name = "txt_Valor2"
        Me.txt_Valor2.Size = New System.Drawing.Size(156, 23)
        Me.txt_Valor2.TabIndex = 4
        '
        'lbl_Valor3
        '
        Me.lbl_Valor3.AutoSize = True
        Me.lbl_Valor3.Location = New System.Drawing.Point(86, 201)
        Me.lbl_Valor3.Name = "lbl_Valor3"
        Me.lbl_Valor3.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Valor3.TabIndex = 5
        Me.lbl_Valor3.Text = "Valor3"
        '
        'txt_Valor3
        '
        Me.txt_Valor3.Location = New System.Drawing.Point(152, 198)
        Me.txt_Valor3.Name = "txt_Valor3"
        Me.txt_Valor3.Size = New System.Drawing.Size(156, 23)
        Me.txt_Valor3.TabIndex = 6
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_Valor3)
        Me.Controls.Add(Me.lbl_Valor3)
        Me.Controls.Add(Me.txt_Valor2)
        Me.Controls.Add(Me.lbl_Valor2)
        Me.Controls.Add(Me.txt_Valor1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Valor1 As TextBox
    Friend WithEvents lbl_Valor2 As Label
    Friend WithEvents txt_Valor2 As TextBox
    Friend WithEvents lbl_Valor3 As Label
    Friend WithEvents txt_Valor3 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
