Public Class Form1
    Dim pic_Leon As Leon
    Dim vleon(3) As Leon
    Dim rnd As New Random()

    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick
        For i = 0 To 3
            vleon(i).Mover(Me)
        Next
    End Sub

    Public Sub New()


        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        For i = 0 To 3
            pic_Leon = New Leon()
            vleon(i) = New Leon()
            pic_Leon.dirx = rnd.Next(-3, 3)
            pic_Leon.diry = rnd.Next(-3, 3)
            vleon(i) = pic_Leon

            Controls.Add(pic_Leon.imagen)
        Next

        tmr_Mover.Start()

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                pic_Leon.diry -= 1
            Case Keys.Down
                pic_Leon.diry += 1
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
