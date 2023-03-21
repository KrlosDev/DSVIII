Public Class Form1
    Private Sub btn_Iniciar_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click
        Dim rnd As New Random()
        txt_Computadora.Text = rnd.Next(1, 100 + 1)
        txt_Usuario.Clear()
        txt_Mensaje.Clear()
        txt_Intentos.Clear()
    End Sub

    Private Sub btn_Verificar_Click(sender As Object, e As EventArgs) Handles btn_Verificar.Click
        If txt_Usuario.Text < txt_Computadora.Text Then
            txt_Mensaje.Text = "Muy Bajo"
        ElseIf txt_Usuario.Text > txt_Computadora.Text Then
            txt_Mensaje.Text = "Muy Alto"
        Else
            txt_Mensaje.Text = "Correcto"
        End If
        txt_Intentos.Text = Val(txt_Intentos.Text) + 1


    End Sub

    Private Sub btn_Ocultar_Click(sender As Object, e As EventArgs) Handles btn_Ocultar.Click
        If txt_Computadora.Visible Then
            txt_Computadora.Visible = False
            btn_Ocultar.Text = "Mostrar"
        Else
            txt_Computadora.Visible = True
            btn_Ocultar.Text = "Ocultar"
        End If


    End Sub
End Class
