Public Class Form1
    Private Sub btn_Sumar_Click(sender As Object, e As EventArgs) Handles btn_Sumar.Click
        txt_Resultado.Text = Val(txt_Numero1.Text) + Val(txt_Numero2.Text)
    End Sub

    Private Sub btn_Restar_Click(sender As Object, e As EventArgs) Handles btn_Restar.Click
        txt_Resultado.Text = txt_Numero1.Text - txt_Numero2.Text

    End Sub
End Class
