Public Class Form1
    Private Sub btn_Generar_Click(sender As Object, e As EventArgs) Handles btn_Generar.Click
        Dim rnd As New Random()
        txt_Numero.Text = rnd.Next(1, 100 + 1)
    End Sub
End Class
