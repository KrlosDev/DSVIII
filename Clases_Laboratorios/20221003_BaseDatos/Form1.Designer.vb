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
        Me.lst_Cliente = New System.Windows.Forms.ListBox()
        Me.btn_Listar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_Cliente
        '
        Me.lst_Cliente.FormattingEnabled = True
        Me.lst_Cliente.ItemHeight = 15
        Me.lst_Cliente.Location = New System.Drawing.Point(76, 70)
        Me.lst_Cliente.Name = "lst_Cliente"
        Me.lst_Cliente.Size = New System.Drawing.Size(252, 109)
        Me.lst_Cliente.TabIndex = 0
        '
        'btn_Listar
        '
        Me.btn_Listar.Location = New System.Drawing.Point(173, 25)
        Me.btn_Listar.Name = "btn_Listar"
        Me.btn_Listar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Listar.TabIndex = 1
        Me.btn_Listar.Text = "Listar"
        Me.btn_Listar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Listar)
        Me.Controls.Add(Me.lst_Cliente)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst_Cliente As ListBox
    Friend WithEvents btn_Listar As Button
End Class
