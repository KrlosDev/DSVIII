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
        Me.btn_Boton = New System.Windows.Forms.Button()
        Me.btn_Subir = New System.Windows.Forms.Button()
        Me.btn_Bajar = New System.Windows.Forms.Button()
        Me.btn_Izquierd = New System.Windows.Forms.Button()
        Me.btn_Derecha = New System.Windows.Forms.Button()
        Me.btn_Mover = New System.Windows.Forms.Button()
        Me.tmr_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_X = New System.Windows.Forms.Label()
        Me.txt_X = New System.Windows.Forms.TextBox()
        Me.lbl_Y = New System.Windows.Forms.Label()
        Me.txt_Y = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(207, 21)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(171, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Mover Boton"
        '
        'btn_Boton
        '
        Me.btn_Boton.Location = New System.Drawing.Point(123, 139)
        Me.btn_Boton.Name = "btn_Boton"
        Me.btn_Boton.Size = New System.Drawing.Size(75, 23)
        Me.btn_Boton.TabIndex = 1
        Me.btn_Boton.Text = "Boton"
        Me.btn_Boton.UseVisualStyleBackColor = True
        '
        'btn_Subir
        '
        Me.btn_Subir.Location = New System.Drawing.Point(469, 63)
        Me.btn_Subir.Name = "btn_Subir"
        Me.btn_Subir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Subir.TabIndex = 2
        Me.btn_Subir.Text = "Subir"
        Me.btn_Subir.UseVisualStyleBackColor = True
        '
        'btn_Bajar
        '
        Me.btn_Bajar.Location = New System.Drawing.Point(469, 122)
        Me.btn_Bajar.Name = "btn_Bajar"
        Me.btn_Bajar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Bajar.TabIndex = 3
        Me.btn_Bajar.Text = "Bajar"
        Me.btn_Bajar.UseVisualStyleBackColor = True
        '
        'btn_Izquierd
        '
        Me.btn_Izquierd.Location = New System.Drawing.Point(380, 92)
        Me.btn_Izquierd.Name = "btn_Izquierd"
        Me.btn_Izquierd.Size = New System.Drawing.Size(75, 23)
        Me.btn_Izquierd.TabIndex = 4
        Me.btn_Izquierd.Text = "Izquierda"
        Me.btn_Izquierd.UseVisualStyleBackColor = True
        '
        'btn_Derecha
        '
        Me.btn_Derecha.Location = New System.Drawing.Point(563, 92)
        Me.btn_Derecha.Name = "btn_Derecha"
        Me.btn_Derecha.Size = New System.Drawing.Size(75, 23)
        Me.btn_Derecha.TabIndex = 5
        Me.btn_Derecha.Text = "Derecha"
        Me.btn_Derecha.UseVisualStyleBackColor = True
        '
        'btn_Mover
        '
        Me.btn_Mover.Location = New System.Drawing.Point(469, 168)
        Me.btn_Mover.Name = "btn_Mover"
        Me.btn_Mover.Size = New System.Drawing.Size(75, 23)
        Me.btn_Mover.TabIndex = 6
        Me.btn_Mover.Text = "Mover"
        Me.btn_Mover.UseVisualStyleBackColor = True
        '
        'tmr_Mover
        '
        Me.tmr_Mover.Interval = 500
        '
        'lbl_X
        '
        Me.lbl_X.AutoSize = True
        Me.lbl_X.Location = New System.Drawing.Point(601, 137)
        Me.lbl_X.Name = "lbl_X"
        Me.lbl_X.Size = New System.Drawing.Size(14, 15)
        Me.lbl_X.TabIndex = 7
        Me.lbl_X.Text = "X"
        '
        'txt_X
        '
        Me.txt_X.Location = New System.Drawing.Point(563, 155)
        Me.txt_X.Name = "txt_X"
        Me.txt_X.Size = New System.Drawing.Size(100, 23)
        Me.txt_X.TabIndex = 8
        '
        'lbl_Y
        '
        Me.lbl_Y.AutoSize = True
        Me.lbl_Y.Location = New System.Drawing.Point(721, 137)
        Me.lbl_Y.Name = "lbl_Y"
        Me.lbl_Y.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_Y.Size = New System.Drawing.Size(14, 15)
        Me.lbl_Y.TabIndex = 9
        Me.lbl_Y.Text = "Y"
        '
        'txt_Y
        '
        Me.txt_Y.Location = New System.Drawing.Point(679, 155)
        Me.txt_Y.Name = "txt_Y"
        Me.txt_Y.Size = New System.Drawing.Size(100, 23)
        Me.txt_Y.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_Y)
        Me.Controls.Add(Me.lbl_Y)
        Me.Controls.Add(Me.txt_X)
        Me.Controls.Add(Me.lbl_X)
        Me.Controls.Add(Me.btn_Mover)
        Me.Controls.Add(Me.btn_Derecha)
        Me.Controls.Add(Me.btn_Izquierd)
        Me.Controls.Add(Me.btn_Bajar)
        Me.Controls.Add(Me.btn_Subir)
        Me.Controls.Add(Me.btn_Boton)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents btn_Boton As Button
    Friend WithEvents btn_Subir As Button
    Friend WithEvents btn_Bajar As Button
    Friend WithEvents btn_Izquierd As Button
    Friend WithEvents btn_Derecha As Button
    Friend WithEvents btn_Mover As Button
    Friend WithEvents tmr_Mover As Timer
    Friend WithEvents lbl_X As Label
    Friend WithEvents txt_X As TextBox
    Friend WithEvents lbl_Y As Label
    Friend WithEvents txt_Y As TextBox
End Class
