Public Class Form1
    Dim dirx, diry As Integer
    Dim rnd As New Random()
    Dim pic As PictureBox
    Dim vpic_Lechuga(3) As PictureBox
    Dim lechuga_dir(3, 1) As Integer


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim i As Integer
        dirx = 0
        diry = 0

        tmr_Mover.Start()

        For i = 0 To 3
            pic = New PictureBox()
            pic.Size = New Size(50, 50)
            pic.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
            pic.Image = My.Resources.ResourceManager.GetObject("lechuga")
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            vpic_Lechuga(i) = pic
            lechuga_dir(i, 0) = rnd.Next(-5, 5)
            lechuga_dir(i, 1) = rnd.Next(-5, 5)
            Controls.Add(pic)
        Next

    End Sub

    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick
        Dim x, y As Integer
        x = pic_Tigre.Location.X
        y = pic_Tigre.Location.Y
        If y <= 0 Or y >= Me.Height - pic_Tigre.Height - 30 Then
            diry *= -1
        End If
        If x <= 0 Or x >= Me.Width - pic_Tigre.Width - 10 Then
            dirx = -dirx
        End If
        pic_Tigre.Location = New Point(x + dirx, y + diry)

        'If pic_Tigre.Bounds.IntersectsWith(pic.Bounds) Then
        ''pic_Lechuga.Visible = False
        'pic.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
        'End If
        'For i = 1 To 4
        'If pic_Tigre.Bounds.IntersectsWith(vpic_Lechuga(i).Bounds) Then
        'vpic_Lechuga(i).Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
        'End If
        'Next

        For i = 0 To 3
            x = vpic_Lechuga(i).Location.X
            y = vpic_Lechuga(i).Location.Y
            If x <= 0 Or x >= Me.Width Then
                lechuga_dir(i, 0) *= -1
            End If
            If y <= 0 Or y >= Me.Height Then
                lechuga_dir(i, 1) *= -1
            End If
            vpic_Lechuga(i).Location = New Point(x + lechuga_dir(i, 0), y + lechuga_dir(i, 1))
        Next

        For Each lechuga As PictureBox In vpic_Lechuga
            If pic_Tigre.Bounds.IntersectsWith(lechuga.Bounds) Then
                lechuga.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
            End If
        Next

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                diry -= 1
            Case Keys.Down
                diry += 1
            Case Keys.Left
                dirx -= 1
            Case Keys.Right
                dirx += 1
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
