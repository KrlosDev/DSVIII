Public Class Lechuga

    Private _imagen As PictureBox
    Public Property imagen() As PictureBox
        Get
            Return _imagen
        End Get
        Set(ByVal value As PictureBox)
            _imagen = value
        End Set
    End Property

    Public Sub New()
        Dim rnd As New Random()
        _imagen = New PictureBox
        _imagen.Size = New Size(20, 20)
        _imagen.Location = New Point(rnd.Next(50, 400), rnd.Next(50, 400))
        _imagen.Image = Image.FromFile("imagen\lechuga.png")
        _imagen.SizeMode = PictureBoxSizeMode.StretchImage
        _imagen.BackColor = Color.Transparent
        dirx = rnd.Next(-3, 3)
        diry = rnd.Next(-3, 3)

    End Sub

    Private _x As Integer
    Public Property x() As Integer
        Get
            Return imagen.Location.X
        End Get
        Set(ByVal value As Integer)
            _x = value
        End Set
    End Property

    Private _y As Integer
    Public Property y() As Integer
        Get
            Return imagen.Location.Y
        End Get
        Set(ByVal value As Integer)
            y = value
        End Set
    End Property
    Private _dirx As Integer
    Public Property dirx() As Integer
        Get
            Return _dirx
        End Get
        Set(ByVal value As Integer)
            _dirx = value
        End Set
    End Property
    Private _diry As Integer
    Public Property diry() As Integer
        Get
            Return _diry
        End Get
        Set(ByVal value As Integer)
            _diry = value
        End Set
    End Property

    Public Sub Mover(formulario As Form)
        If x <= 0 Or x >= formulario.Width - imagen.Width - 10 Then
            dirx = -dirx
        End If
        If y <= 0 Or y >= formulario.Height - imagen.Height - 30 Then
            diry = -diry
        End If

        imagen.Location = New Point(x + dirx, y + diry)
    End Sub

End Class
