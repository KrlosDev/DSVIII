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
        Me.btn_Notepad = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Kill = New System.Windows.Forms.Button()
        Me.lst_Procesos = New System.Windows.Forms.ListBox()
        Me.btn_Listar = New System.Windows.Forms.Button()
        Me.btn_ListarNotepad = New System.Windows.Forms.Button()
        Me.btn_KillNotepads = New System.Windows.Forms.Button()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.btn_Kill_PID = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Notepad
        '
        Me.btn_Notepad.Location = New System.Drawing.Point(75, 57)
        Me.btn_Notepad.Name = "btn_Notepad"
        Me.btn_Notepad.Size = New System.Drawing.Size(75, 23)
        Me.btn_Notepad.TabIndex = 0
        Me.btn_Notepad.Text = "Notepad"
        Me.btn_Notepad.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Location = New System.Drawing.Point(183, 57)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Kill
        '
        Me.btn_Kill.Location = New System.Drawing.Point(289, 57)
        Me.btn_Kill.Name = "btn_Kill"
        Me.btn_Kill.Size = New System.Drawing.Size(75, 23)
        Me.btn_Kill.TabIndex = 2
        Me.btn_Kill.Text = "Kill"
        Me.btn_Kill.UseVisualStyleBackColor = True
        '
        'lst_Procesos
        '
        Me.lst_Procesos.FormattingEnabled = True
        Me.lst_Procesos.ItemHeight = 15
        Me.lst_Procesos.Location = New System.Drawing.Point(75, 144)
        Me.lst_Procesos.Name = "lst_Procesos"
        Me.lst_Procesos.Size = New System.Drawing.Size(264, 214)
        Me.lst_Procesos.TabIndex = 3
        '
        'btn_Listar
        '
        Me.btn_Listar.Location = New System.Drawing.Point(75, 106)
        Me.btn_Listar.Name = "btn_Listar"
        Me.btn_Listar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Listar.TabIndex = 4
        Me.btn_Listar.Text = "Listar"
        Me.btn_Listar.UseVisualStyleBackColor = True
        '
        'btn_ListarNotepad
        '
        Me.btn_ListarNotepad.Location = New System.Drawing.Point(183, 106)
        Me.btn_ListarNotepad.Name = "btn_ListarNotepad"
        Me.btn_ListarNotepad.Size = New System.Drawing.Size(95, 23)
        Me.btn_ListarNotepad.TabIndex = 5
        Me.btn_ListarNotepad.Text = "Listar Notepad"
        Me.btn_ListarNotepad.UseVisualStyleBackColor = True
        '
        'btn_KillNotepads
        '
        Me.btn_KillNotepads.Location = New System.Drawing.Point(303, 105)
        Me.btn_KillNotepads.Name = "btn_KillNotepads"
        Me.btn_KillNotepads.Size = New System.Drawing.Size(104, 23)
        Me.btn_KillNotepads.TabIndex = 6
        Me.btn_KillNotepads.Text = "Kill Notepads"
        Me.btn_KillNotepads.UseVisualStyleBackColor = True
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(345, 180)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(81, 23)
        Me.txt_Id.TabIndex = 7
        '
        'btn_Kill_PID
        '
        Me.btn_Kill_PID.Location = New System.Drawing.Point(345, 144)
        Me.btn_Kill_PID.Name = "btn_Kill_PID"
        Me.btn_Kill_PID.Size = New System.Drawing.Size(75, 23)
        Me.btn_Kill_PID.TabIndex = 8
        Me.btn_Kill_PID.Text = "Kill PID"
        Me.btn_Kill_PID.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Kill_PID)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.btn_KillNotepads)
        Me.Controls.Add(Me.btn_ListarNotepad)
        Me.Controls.Add(Me.btn_Listar)
        Me.Controls.Add(Me.lst_Procesos)
        Me.Controls.Add(Me.btn_Kill)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.btn_Notepad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Notepad As Button
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents btn_Kill As Button
    Friend WithEvents lst_Procesos As ListBox
    Friend WithEvents btn_Listar As Button
    Friend WithEvents btn_ListarNotepad As Button
    Friend WithEvents btn_KillNotepads As Button
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents btn_Kill_PID As Button
End Class
