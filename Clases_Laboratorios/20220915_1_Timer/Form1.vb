Public Class Form1
    Private Sub btn_Contar_Click(sender As Object, e As EventArgs) Handles btn_Contar.Click
        txt_Contador.Text = Val(txt_Contador.Text) + 1
    End Sub

    Private Sub tmr_Contador_Tick(sender As Object, e As EventArgs) Handles tmr_Contador.Tick
        txt_Contador.Text = Val(txt_Contador.Text) + 1
    End Sub

    Private Sub btn_Iniciar_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click
        txt_Contador.Text = "0"
        tmr_Contador.Enabled = True
    End Sub

    Private Sub btn_Detener_Click(sender As Object, e As EventArgs) Handles btn_Detener.Click
        tmr_Contador.Enabled = False
    End Sub

    Private Sub btn_Continuar_Click(sender As Object, e As EventArgs) Handles btn_Continuar.Click
        tmr_Contador.Enabled = True
    End Sub

    Private Sub btn_Iniciar2_Click(sender As Object, e As EventArgs) Handles btn_Iniciar2.Click
        If tmr_Contador.Enabled Then
            tmr_Contador.Enabled = False
            btn_Iniciar2.Text = "Iniciar"
        Else
            tmr_Contador.Enabled = True
            btn_Iniciar2.Text = "Detener"
        End If
    End Sub

    Private Sub btn_IncDet_Click(sender As Object, e As EventArgs) Handles btn_IncDet.Click
        tmr_Contador.Enabled = Not tmr_Contador.Enabled

    End Sub
End Class
