Public Class Form1
    Private Sub btn_Sumar_Click(sender As Object, e As EventArgs) Handles btn_Sumar.Click
        txt_Resultado.Text = Val(txt_Numero1.Text) + Val(txt_Numero2.Text)
    End Sub

    Private Sub btn_Restar_Click(sender As Object, e As EventArgs) Handles btn_Restar.Click
        txt_Resultado.Text = CInt(txt_Numero1.Text) - CInt(txt_Numero2.Text)

    End Sub

    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click
        txt_Oper.Text = cmb_Oper.SelectedItem
        If txt_Oper.Text = "+" Then
            txt_Resultado.Text = Val(txt_Numero1.Text) + Val(txt_Numero2.Text)
        End If
        If txt_Oper.Text = "-" Then
            txt_Resultado.Text = Val(txt_Numero1.Text) - Val(txt_Numero2.Text)
        End If
    End Sub
End Class
