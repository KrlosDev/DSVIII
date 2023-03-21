Imports System.ComponentModel

Public Class Form1
    Private Sub txt_Valor1_Validating(sender As Object, e As CancelEventArgs) Handles txt_Valor1.Validating
        If String.IsNullOrEmpty(txt_Valor1.Text) Then
            'MsgBox("Valor 1 no puede estar vacio")
            ErrorProvider1.SetError(txt_Valor1, "no puede estar vacio")
            e.Cancel = True

        ElseIf Not txt_Valor1.Text Like "####" Then
            MsgBox("debe ser 4 digitos")
            ErrorProvider1.SetError(txt_Valor2, "4 digitos")

            e.Cancel = True

        End If
    End Sub

    Private Sub txt_Valor2_Validating(sender As Object, e As CancelEventArgs) Handles txt_Valor2.Validating
        If Not txt_Valor2.Text Like "####-####" Then
            MsgBox("formato debe ser 9999-9999")
            e.Cancel = True
        End If
    End Sub

    Private Sub txt_Valor3_Validating(sender As Object, e As CancelEventArgs) Handles txt_Valor3.Validating
        If Not txt_Valor3.Text Like "[a-d]?#" Then
            MsgBox("formato debe ser X99")
            e.Cancel = True
        End If
    End Sub
End Class
