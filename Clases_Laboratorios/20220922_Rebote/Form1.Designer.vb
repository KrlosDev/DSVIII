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
        Me.btn_Boton = New System.Windows.Forms.Button()
        Me.btn_Subir = New System.Windows.Forms.Button()
        Me.btn_Bajar = New System.Windows.Forms.Button()
        Me.btn_Mover = New System.Windows.Forms.Button()
        Me.tmr_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Y = New System.Windows.Forms.Label()
        Me.txt_Y = New System.Windows.Forms.TextBox()
        Me.lbl_Height = New System.Windows.Forms.Label()
        Me.txt_Height = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_Boton
        '
        Me.btn_Boton.Location = New System.Drawing.Point(173, 139)
        Me.btn_Boton.Name = "btn_Boton"
        Me.btn_Boton.Size = New System.Drawing.Size(75, 23)
        Me.btn_Boton.TabIndex = 0
        Me.btn_Boton.Text = "Boton"
        Me.btn_Boton.UseVisualStyleBackColor = True
        '
        'btn_Subir
        '
        Me.btn_Subir.Location = New System.Drawing.Point(547, 55)
        Me.btn_Subir.Name = "btn_Subir"
        Me.btn_Subir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Subir.TabIndex = 1
        Me.btn_Subir.Text = "Subir"
        Me.btn_Subir.UseVisualStyleBackColor = True
        '
        'btn_Bajar
        '
        Me.btn_Bajar.Location = New System.Drawing.Point(547, 99)
        Me.btn_Bajar.Name = "btn_Bajar"
        Me.btn_Bajar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Bajar.TabIndex = 2
        Me.btn_Bajar.Text = "Bajar"
        Me.btn_Bajar.UseVisualStyleBackColor = True
        '
        'btn_Mover
        '
        Me.btn_Mover.Location = New System.Drawing.Point(547, 139)
        Me.btn_Mover.Name = "btn_Mover"
        Me.btn_Mover.Size = New System.Drawing.Size(75, 23)
        Me.btn_Mover.TabIndex = 3
        Me.btn_Mover.Text = "Mover"
        Me.btn_Mover.UseVisualStyleBackColor = True
        '
        'tmr_Mover
        '
        '
        'lbl_Y
        '
        Me.lbl_Y.AutoSize = True
        Me.lbl_Y.Location = New System.Drawing.Point(547, 178)
        Me.lbl_Y.Name = "lbl_Y"
        Me.lbl_Y.Size = New System.Drawing.Size(14, 15)
        Me.lbl_Y.TabIndex = 4
        Me.lbl_Y.Text = "Y"
        '
        'txt_Y
        '
        Me.txt_Y.Location = New System.Drawing.Point(584, 175)
        Me.txt_Y.Name = "txt_Y"
        Me.txt_Y.Size = New System.Drawing.Size(100, 23)
        Me.txt_Y.TabIndex = 5
        '
        'lbl_Height
        '
        Me.lbl_Height.AutoSize = True
        Me.lbl_Height.Location = New System.Drawing.Point(547, 215)
        Me.lbl_Height.Name = "lbl_Height"
        Me.lbl_Height.Size = New System.Drawing.Size(43, 15)
        Me.lbl_Height.TabIndex = 6
        Me.lbl_Height.Text = "Height"
        '
        'txt_Height
        '
        Me.txt_Height.Location = New System.Drawing.Point(596, 207)
        Me.txt_Height.Name = "txt_Height"
        Me.txt_Height.Size = New System.Drawing.Size(100, 23)
        Me.txt_Height.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_Height)
        Me.Controls.Add(Me.lbl_Height)
        Me.Controls.Add(Me.txt_Y)
        Me.Controls.Add(Me.lbl_Y)
        Me.Controls.Add(Me.btn_Mover)
        Me.Controls.Add(Me.btn_Bajar)
        Me.Controls.Add(Me.btn_Subir)
        Me.Controls.Add(Me.btn_Boton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Boton As Button
    Friend WithEvents btn_Subir As Button
    Friend WithEvents btn_Bajar As Button
    Friend WithEvents btn_Mover As Button
    Friend WithEvents tmr_Mover As Timer
    Friend WithEvents lbl_Y As Label
    Friend WithEvents txt_Y As TextBox
    Friend WithEvents lbl_Height As Label
    Friend WithEvents txt_Height As TextBox
End Class
