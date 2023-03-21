Public Class Form1
    Private Sub btn_Iniciar_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click
        txt_Inferior.Text = 1
        txt_Superior.Text = 100
        Generar()
    End Sub

    Private Sub btn_Bajo_Click(sender As Object, e As EventArgs) Handles btn_Bajo.Click
        txt_Inferior.Text = txt_Computadora.Text + 1
        Generar()
    End Sub
    Private Sub Generar()
        Dim rnd As New Random()
        txt_Computadora.Text = rnd.Next(txt_Inferior.Text, txt_Superior.Text + 1)
    End Sub

    Private Sub btn_Alto_Click(sender As Object, e As EventArgs) Handles btn_Alto.Click
        txt_Superior.Text = txt_Computadora.Text - 1
        Generar()
    End Sub
End Class
