Public Class Form1
    Dim pic_Leon As Leon
    Dim vLechuga(3) As Lechuga

    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick
        pic_Leon.Mover(Me)

        For i = 0 To 3
            vLechuga(i).Mover(Me)
        Next

    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        pic_Leon = New Leon()
        Controls.Add(pic_Leon.imagen)

        For i = 0 To 3
            vLechuga(i) = New Lechuga()
            Controls.Add(vLechuga(i).imagen)
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
