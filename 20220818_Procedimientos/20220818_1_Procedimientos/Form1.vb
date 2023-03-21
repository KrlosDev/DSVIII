Public Class Form1
    Private Sub btn_Proc_01_Click(sender As Object, e As EventArgs) Handles btn_Proc_01.Click
        Procedimiento01()
    End Sub
    Private Sub Procedimiento01()
        txt_Mensaje.Text = "Proc 01"
    End Sub
    Private Sub Procedimiento01(ByVal valor As String)
        txt_Mensaje.Text = "sobrecargado"
    End Sub
    Private Sub Procedimiento01(ByVal valor As String, ByVal num As Integer)
        If num = 1 Then
            txt_Mensaje.Text = valor + " uno"
        End If
        If num = 2 Then
            txt_Mensaje.Text = "dos " + valor
        End If
    End Sub

    Private Sub btn_Proc_01_Rep_Click(sender As Object, e As EventArgs) Handles btn_Proc_01_Rep.Click
        Procedimiento01()
    End Sub
    Private Sub Procedimiento_Par_01(ByVal valor As String)
        txt_Mensaje.Text = valor
    End Sub

    Private Sub btn_Proc_Par_01_Click(sender As Object, e As EventArgs) Handles btn_Proc_Par_01.Click
        Procedimiento_Par_01("Parametro 01")
    End Sub

    Private Sub btn_Proc_Par_02_Click(sender As Object, e As EventArgs) Handles btn_Proc_Par_02.Click
        Procedimiento_Par_01("Parametro 02")
    End Sub

    Private Sub btn_Proc_Sobrecarga_Click(sender As Object, e As EventArgs) Handles btn_Proc_Sobrecarga.Click
        Procedimiento01("nada")
    End Sub

    Private Sub btn_Sobr_02_Click(sender As Object, e As EventArgs) Handles btn_Sobr_02.Click
        Procedimiento01("algo", 1)
    End Sub

    Private Sub btn_Proc_Sobr_03_Click(sender As Object, e As EventArgs) Handles btn_Proc_Sobr_03.Click
        Procedimiento01("otra cosa", 2)
    End Sub
    Private Function Funcion_01() As String
        Return "calculo valor"
    End Function

    Private Sub btn_Funcion_01_Click(sender As Object, e As EventArgs) Handles btn_Funcion_01.Click
        txt_Mensaje.Text = Funcion_01()
    End Sub
    Private Function Sumar(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim resultado As Integer
        resultado = num1 + num2
        Return resultado
    End Function

    Private Sub btn_Suma_Click(sender As Object, e As EventArgs) Handles btn_Suma.Click
        txt_Mensaje.Text = Sumar(32, 74)
    End Sub
End Class
