Imports _20221020_1_Libreria
Public Class Form1
    Private Sub btn_Sumar_Click(sender As Object, e As EventArgs) Handles btn_Sumar.Click
        Dim obj_Calculo As New Calculo()
        txt_Res.Text = obj_Calculo.sumar(CInt(txt_Num1.Text), CInt(txt_Num2.Text))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj_calculo As New Calculo()
        txt_Res.Text = obj_calculo.restar(CInt(txt_Num1.Text), CInt(txt_Num2.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj_calculo As New Calculo2
        txt_Res.Text = obj_calculo.sumar(txt_Num1.Text, txt_Num2.Text)
    End Sub
End Class
