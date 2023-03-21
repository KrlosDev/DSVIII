Public Class Form1
    Dim vbtn_Boton(4) As Button

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vbtn_Boton(1) = btn_1
        vbtn_Boton(2) = btn_2
        vbtn_Boton(3) = btn_3
        vbtn_Boton(4) = btn_4

    End Sub

    Private Sub btn_Iniciar_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click
        tmr_Mover.Start()
    End Sub

    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick
        Dim x, y As Integer
        Dim rnd As New Random()
        Dim indice As Integer
        'x = btn_1.Location.X
        'y = btn_1.Location.Y
        'btn_1.Location = New Point(x, y + 1)
        indice = rnd.Next(1, 4 + 1)
        x = vbtn_Boton(indice).Location.X
        y = vbtn_Boton(indice).Location.Y
        vbtn_Boton(indice).Location = New Point(x, y + rnd.Next(4))

    End Sub
End Class
