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
        Me.pic_Tigre = New System.Windows.Forms.PictureBox()
        Me.tmr_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.pic_Lechuga = New System.Windows.Forms.PictureBox()
        CType(Me.pic_Tigre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Lechuga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_Tigre
        '
        Me.pic_Tigre.Image = Global._20220926_Imagen.My.Resources.Resources.tigre
        Me.pic_Tigre.Location = New System.Drawing.Point(232, 91)
        Me.pic_Tigre.Name = "pic_Tigre"
        Me.pic_Tigre.Size = New System.Drawing.Size(71, 60)
        Me.pic_Tigre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Tigre.TabIndex = 0
        Me.pic_Tigre.TabStop = False
        '
        'tmr_Mover
        '
        '
        'pic_Lechuga
        '
        Me.pic_Lechuga.Image = Global._20220926_Imagen.My.Resources.Resources.lechuga
        Me.pic_Lechuga.Location = New System.Drawing.Point(462, 243)
        Me.pic_Lechuga.Name = "pic_Lechuga"
        Me.pic_Lechuga.Size = New System.Drawing.Size(63, 50)
        Me.pic_Lechuga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Lechuga.TabIndex = 1
        Me.pic_Lechuga.TabStop = False
        Me.pic_Lechuga.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pic_Lechuga)
        Me.Controls.Add(Me.pic_Tigre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic_Tigre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Lechuga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_Tigre As PictureBox
    Friend WithEvents tmr_Mover As Timer
    Friend WithEvents pic_Lechuga As PictureBox
End Class
