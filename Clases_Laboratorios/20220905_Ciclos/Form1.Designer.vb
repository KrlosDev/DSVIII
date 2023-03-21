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
        Me.lst_Valor = New System.Windows.Forms.ListBox()
        Me.btn_For = New System.Windows.Forms.Button()
        Me.btn_for2 = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_For3 = New System.Windows.Forms.Button()
        Me.btn_While1 = New System.Windows.Forms.Button()
        Me.btn_While2 = New System.Windows.Forms.Button()
        Me.btn_While3 = New System.Windows.Forms.Button()
        Me.btn_Loop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(223, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estructuras de Repetición"
        '
        'lst_Valor
        '
        Me.lst_Valor.FormattingEnabled = True
        Me.lst_Valor.ItemHeight = 15
        Me.lst_Valor.Location = New System.Drawing.Point(44, 100)
        Me.lst_Valor.Name = "lst_Valor"
        Me.lst_Valor.Size = New System.Drawing.Size(149, 169)
        Me.lst_Valor.TabIndex = 1
        '
        'btn_For
        '
        Me.btn_For.Location = New System.Drawing.Point(245, 100)
        Me.btn_For.Name = "btn_For"
        Me.btn_For.Size = New System.Drawing.Size(75, 23)
        Me.btn_For.TabIndex = 2
        Me.btn_For.Text = "For"
        Me.btn_For.UseVisualStyleBackColor = True
        '
        'btn_for2
        '
        Me.btn_for2.Location = New System.Drawing.Point(245, 145)
        Me.btn_for2.Name = "btn_for2"
        Me.btn_for2.Size = New System.Drawing.Size(75, 23)
        Me.btn_for2.TabIndex = 3
        Me.btn_for2.Text = "For 2"
        Me.btn_for2.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Location = New System.Drawing.Point(55, 66)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Limpiar.TabIndex = 4
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_For3
        '
        Me.btn_For3.Location = New System.Drawing.Point(245, 195)
        Me.btn_For3.Name = "btn_For3"
        Me.btn_For3.Size = New System.Drawing.Size(75, 23)
        Me.btn_For3.TabIndex = 5
        Me.btn_For3.Text = "For 3"
        Me.btn_For3.UseVisualStyleBackColor = True
        '
        'btn_While1
        '
        Me.btn_While1.Location = New System.Drawing.Point(353, 100)
        Me.btn_While1.Name = "btn_While1"
        Me.btn_While1.Size = New System.Drawing.Size(75, 23)
        Me.btn_While1.TabIndex = 6
        Me.btn_While1.Text = "While 1"
        Me.btn_While1.UseVisualStyleBackColor = True
        '
        'btn_While2
        '
        Me.btn_While2.Location = New System.Drawing.Point(354, 146)
        Me.btn_While2.Name = "btn_While2"
        Me.btn_While2.Size = New System.Drawing.Size(75, 23)
        Me.btn_While2.TabIndex = 7
        Me.btn_While2.Text = "While 2"
        Me.btn_While2.UseVisualStyleBackColor = True
        '
        'btn_While3
        '
        Me.btn_While3.Location = New System.Drawing.Point(357, 193)
        Me.btn_While3.Name = "btn_While3"
        Me.btn_While3.Size = New System.Drawing.Size(75, 23)
        Me.btn_While3.TabIndex = 8
        Me.btn_While3.Text = "While 3"
        Me.btn_While3.UseVisualStyleBackColor = True
        '
        'btn_Loop
        '
        Me.btn_Loop.Location = New System.Drawing.Point(469, 101)
        Me.btn_Loop.Name = "btn_Loop"
        Me.btn_Loop.Size = New System.Drawing.Size(75, 23)
        Me.btn_Loop.TabIndex = 9
        Me.btn_Loop.Text = "Loop"
        Me.btn_Loop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Loop)
        Me.Controls.Add(Me.btn_While3)
        Me.Controls.Add(Me.btn_While2)
        Me.Controls.Add(Me.btn_While1)
        Me.Controls.Add(Me.btn_For3)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_for2)
        Me.Controls.Add(Me.btn_For)
        Me.Controls.Add(Me.lst_Valor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lst_Valor As ListBox
    Friend WithEvents btn_For As Button
    Friend WithEvents btn_for2 As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents btn_For3 As Button
    Friend WithEvents btn_While1 As Button
    Friend WithEvents btn_While2 As Button
    Friend WithEvents btn_While3 As Button
    Friend WithEvents btn_Loop As Button
End Class
