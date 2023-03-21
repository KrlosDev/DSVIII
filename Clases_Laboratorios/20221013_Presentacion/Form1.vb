Public Class Form1
    Private Sub btn_Presentacion_Click(sender As Object, e As EventArgs) Handles btn_Presentacion.Click
        Dim presentacion As New Presentacion()
        presentacion.Show()
        Me.Hide()
    End Sub
End Class
