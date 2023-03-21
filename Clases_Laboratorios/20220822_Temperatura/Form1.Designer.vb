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
        Me.lbl_C = New System.Windows.Forms.Label()
        Me.txt_C = New System.Windows.Forms.TextBox()
        Me.lbl_F = New System.Windows.Forms.Label()
        Me.txt_F = New System.Windows.Forms.TextBox()
        Me.btn_CF = New System.Windows.Forms.Button()
        Me.btn_FC = New System.Windows.Forms.Button()
        Me.rb_C = New System.Windows.Forms.RadioButton()
        Me.rb_F = New System.Windows.Forms.RadioButton()
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.txt_Cualquiera = New System.Windows.Forms.TextBox()
        Me.hsb_Temperatura = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(177, 18)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(311, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Convertir Temperatura"
        '
        'lbl_C
        '
        Me.lbl_C.AutoSize = True
        Me.lbl_C.Location = New System.Drawing.Point(140, 93)
        Me.lbl_C.Name = "lbl_C"
        Me.lbl_C.Size = New System.Drawing.Size(20, 15)
        Me.lbl_C.TabIndex = 1
        Me.lbl_C.Text = "°C"
        '
        'txt_C
        '
        Me.txt_C.Location = New System.Drawing.Point(177, 90)
        Me.txt_C.Name = "txt_C"
        Me.txt_C.Size = New System.Drawing.Size(100, 23)
        Me.txt_C.TabIndex = 2
        '
        'lbl_F
        '
        Me.lbl_F.AutoSize = True
        Me.lbl_F.Location = New System.Drawing.Point(140, 132)
        Me.lbl_F.Name = "lbl_F"
        Me.lbl_F.Size = New System.Drawing.Size(18, 15)
        Me.lbl_F.TabIndex = 3
        Me.lbl_F.Text = "°F"
        '
        'txt_F
        '
        Me.txt_F.Location = New System.Drawing.Point(177, 129)
        Me.txt_F.Name = "txt_F"
        Me.txt_F.Size = New System.Drawing.Size(100, 23)
        Me.txt_F.TabIndex = 4
        '
        'btn_CF
        '
        Me.btn_CF.Location = New System.Drawing.Point(332, 89)
        Me.btn_CF.Name = "btn_CF"
        Me.btn_CF.Size = New System.Drawing.Size(75, 23)
        Me.btn_CF.TabIndex = 5
        Me.btn_CF.Text = "°C -> °F"
        Me.btn_CF.UseVisualStyleBackColor = True
        '
        'btn_FC
        '
        Me.btn_FC.Location = New System.Drawing.Point(332, 128)
        Me.btn_FC.Name = "btn_FC"
        Me.btn_FC.Size = New System.Drawing.Size(75, 23)
        Me.btn_FC.TabIndex = 6
        Me.btn_FC.Text = "°F -> °C"
        Me.btn_FC.UseVisualStyleBackColor = True
        '
        'rb_C
        '
        Me.rb_C.AutoSize = True
        Me.rb_C.Location = New System.Drawing.Point(109, 93)
        Me.rb_C.Name = "rb_C"
        Me.rb_C.Size = New System.Drawing.Size(14, 13)
        Me.rb_C.TabIndex = 7
        Me.rb_C.TabStop = True
        Me.rb_C.UseVisualStyleBackColor = True
        '
        'rb_F
        '
        Me.rb_F.AutoSize = True
        Me.rb_F.Location = New System.Drawing.Point(103, 130)
        Me.rb_F.Name = "rb_F"
        Me.rb_F.Size = New System.Drawing.Size(36, 19)
        Me.rb_F.TabIndex = 8
        Me.rb_F.TabStop = True
        Me.rb_F.Text = "°F"
        Me.rb_F.UseVisualStyleBackColor = True
        '
        'btn_Calcular
        '
        Me.btn_Calcular.Location = New System.Drawing.Point(177, 178)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_Calcular.TabIndex = 9
        Me.btn_Calcular.Text = "Calcular"
        Me.btn_Calcular.UseVisualStyleBackColor = True
        '
        'txt_Cualquiera
        '
        Me.txt_Cualquiera.Location = New System.Drawing.Point(466, 95)
        Me.txt_Cualquiera.Name = "txt_Cualquiera"
        Me.txt_Cualquiera.Size = New System.Drawing.Size(100, 23)
        Me.txt_Cualquiera.TabIndex = 10
        '
        'hsb_Temperatura
        '
        Me.hsb_Temperatura.LargeChange = 1
        Me.hsb_Temperatura.Location = New System.Drawing.Point(109, 255)
        Me.hsb_Temperatura.Name = "hsb_Temperatura"
        Me.hsb_Temperatura.Size = New System.Drawing.Size(314, 36)
        Me.hsb_Temperatura.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(398, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "100"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(630, 71)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(44, 229)
        Me.VScrollBar1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(686, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(704, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hsb_Temperatura)
        Me.Controls.Add(Me.txt_Cualquiera)
        Me.Controls.Add(Me.btn_Calcular)
        Me.Controls.Add(Me.rb_F)
        Me.Controls.Add(Me.rb_C)
        Me.Controls.Add(Me.btn_FC)
        Me.Controls.Add(Me.btn_CF)
        Me.Controls.Add(Me.txt_F)
        Me.Controls.Add(Me.lbl_F)
        Me.Controls.Add(Me.txt_C)
        Me.Controls.Add(Me.lbl_C)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_C As Label
    Friend WithEvents txt_C As TextBox
    Friend WithEvents lbl_F As Label
    Friend WithEvents txt_F As TextBox
    Friend WithEvents btn_CF As Button
    Friend WithEvents btn_FC As Button
    Friend WithEvents rb_C As RadioButton
    Friend WithEvents rb_F As RadioButton
    Friend WithEvents btn_Calcular As Button
    Friend WithEvents txt_Cualquiera As TextBox
    Friend WithEvents hsb_Temperatura As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
