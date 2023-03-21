Public Class Form1
    Dim pic_Leon As Leon

    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick
        pic_Leon.Mover(Me)
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        pic_Leon = New Leon()
        Controls.Add(pic_Leon.imagen)
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
