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
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_Iniciar = New System.Windows.Forms.Button()
        Me.tmr_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(308, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carrera"
        '
        'btn_1
        '
        Me.btn_1.Location = New System.Drawing.Point(59, 88)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(75, 23)
        Me.btn_1.TabIndex = 1
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Location = New System.Drawing.Point(156, 88)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(75, 23)
        Me.btn_2.TabIndex = 2
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Location = New System.Drawing.Point(250, 88)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(75, 23)
        Me.btn_3.TabIndex = 3
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_4
        '
        Me.btn_4.Location = New System.Drawing.Point(351, 88)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(75, 23)
        Me.btn_4.TabIndex = 4
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_Iniciar
        '
        Me.btn_Iniciar.Location = New System.Drawing.Point(467, 88)
        Me.btn_Iniciar.Name = "btn_Iniciar"
        Me.btn_Iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Iniciar.TabIndex = 5
        Me.btn_Iniciar.Text = "Iniciar"
        Me.btn_Iniciar.UseVisualStyleBackColor = True
        '
        'tmr_Mover
        '
        Me.tmr_Mover.Interval = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Iniciar)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_Iniciar As Button
    Friend WithEvents tmr_Mover As Timer
End Class
