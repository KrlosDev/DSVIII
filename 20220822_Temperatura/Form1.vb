Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_CF.Click
        'txt_F.Text = txt_C.Text * 9 / 5 + 32
        txt_F.Text = Calcular_CF(Val(txt_C.Text))
        txt_Cualquiera.Text = Calcular_CF(Val(txt_C.Text))
    End Sub

    Private Sub btn_FC_Click(sender As Object, e As EventArgs) Handles btn_FC.Click
        'txt_C.Text = (txt_F.Text - 32) * 5 / 9
        txt_C.Text = Calcular_FC(Val(txt_F.Text))
    End Sub

    Private Sub txt_C_TextChanged(sender As Object, e As EventArgs) Handles txt_C.TextChanged
        'txt_F.Text = txt_C.Text * 9 / 5 + 32
        txt_F.Text = Calcular_CF(Val(txt_C.Text))
    End Sub

    Private Sub txt_F_TextChanged(sender As Object, e As EventArgs) Handles txt_F.TextChanged
        'txt_C.Text = (txt_F.Text - 32) * 5 / 9
        'Calcular_FC()
        txt_C.Text = Calcular_FC(Val(txt_F.Text))
    End Sub

    Private Sub Calcular_CF1()
        txt_F.Text = Val(txt_C.Text) * 9 / 5 + 32
    End Sub
    Private Sub Calcular_FC1()
        txt_C.Text = (Val(txt_F.Text) - 32) * 5 / 9
    End Sub

    Private Function Calcular_CF(ByVal valor As Double) As Double
        Dim res As Double
        res = valor * 9 / 5 + 32
        Return res

    End Function

    Private Function Calcular_FC(ByVal valor As Double) As Double
        Dim res As Double
        res = (valor - 32) * 5 / 9
        Return res

    End Function

    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click
        If rb_C.Checked Then
            txt_F.Text = Calcular_CF(Val(txt_C.Text))
        End If
        If rb_F.Checked Then
            txt_C.Text = Calcular_FC(Val(txt_F.Text))
        End If
    End Sub

    Private Sub hsb_Temperatura_Scroll(sender As Object, e As ScrollEventArgs) Handles hsb_Temperatura.Scroll
        If rb_C.Checked Then
            txt_C.Text = hsb_Temperatura.Value
        End If
        If rb_F.Checked Then
            txt_F.Text = hsb_Temperatura.Value
        End If

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        txt_C.Text = VScrollBar1.Value
    End Sub
End Class
