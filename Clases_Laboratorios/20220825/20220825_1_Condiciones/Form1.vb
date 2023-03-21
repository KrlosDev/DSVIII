Public Class Form1
    Private Sub btn_ifSimple_Click(sender As Object, e As EventArgs) Handles btn_ifSimple.Click
        Dim valor As Integer
        valor = CInt(txt_Valor.Text)
        txt_Mensaje.Clear()

        If valor = 5 Then
            txt_Mensaje.Text = "es 5"
        End If
    End Sub

    Private Sub btn_ifElse_Click(sender As Object, e As EventArgs) Handles btn_ifElse.Click
        Dim valor As Integer
        valor = CInt(txt_Valor.Text)
        If valor = 5 Then
            txt_Mensaje.Text = "es 5"
        Else
            txt_Mensaje.Text = "no es 5"
        End If
    End Sub

    Private Sub btn_Mayor100_Click(sender As Object, e As EventArgs) Handles btn_Mayor100.Click
        Dim valor As Integer
        valor = CInt(txt_Valor.Text)
        If valor > 100 Then
            txt_Mensaje.Text = "es mayor que 100"
        Else
            txt_Mensaje.Text = "no es mayor que 100"
        End If
    End Sub

    Private Sub btn_IfAnidado_Click(sender As Object, e As EventArgs) Handles btn_IfAnidado.Click
        Dim valor As Integer
        valor = CInt(txt_Valor.Text)
        If valor = 5 Then
            txt_Mensaje.Text = "es 5"
        Else
            If valor = 8 Then
                txt_Mensaje.Text = "es 8"
            Else
                If valor = 10 Then
                    txt_Mensaje.Text = "es 10"
                Else
                    txt_Mensaje.Text = "no es 5, 8, ni 10"
                End If
            End If

        End If
    End Sub

    Private Sub btn_elseIf_Click(sender As Object, e As EventArgs) Handles btn_elseIf.Click
        Dim valor As Integer
        valor = CInt(txt_Valor.Text)
        If valor = 5 Then
            txt_Mensaje.Text = "es 5"
        ElseIf valor = 8 Then
            txt_Mensaje.Text = "es 8"
        ElseIf valor = 10 Then
            txt_Mensaje.Text = "es 10"
        Else
            txt_Mensaje.Text = "no es 5, 8 ni 10"
        End If
    End Sub

    Private Sub btn_NoAnidado_Click(sender As Object, e As EventArgs) Handles btn_NoAnidado.Click
        Dim valor As Integer
        valor = CInt(txt_Valor.Text)
        txt_Mensaje.Clear()

        If valor = 5 Then
            txt_Mensaje.Text = "es 5"
        End If
        If valor = 8 Then
            txt_Mensaje.Text = "es 8"
        End If
        If valor = 10 Then
            txt_Mensaje.Text = "es 10"
        Else
            'txt_Mensaje.Text = "no es 5, 8 , 10"
        End If
    End Sub

    Private Sub btn_AND_Click(sender As Object, e As EventArgs) Handles btn_AND.Click
        Dim valor As Integer
        valor = CInt(txt_Valor.Text)
        If valor = 5 And valor = 3 Then
            txt_Mensaje.Text = "es 5 y 3"
        Else
            txt_Mensaje.Text = "no es 5 y 3"
        End If
    End Sub

    Private Sub btn_Or_Click(sender As Object, e As EventArgs) Handles btn_Or.Click
        Dim valor As Integer
        valor = CInt(txt_Valor.Text)
        If valor = 5 Or valor = 3 And valor = 2 Then
            txt_Mensaje.Text = "es 5 o 3"
        Else
            txt_Mensaje.Text = "no es 5 o 3"
        End If

    End Sub
End Class
