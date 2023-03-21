Public Class Form1
    Dim vtxt_Valor(4) As TextBox

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vtxt_Valor(0) = txt_Valor1
        vtxt_Valor(1) = txt_Valor2
        vtxt_Valor(2) = txt_Valor3
        vtxt_Valor(3) = txt_Valor4

    End Sub

    Private Sub btn_Manual_Click(sender As Object, e As EventArgs) Handles btn_Manual.Click
        txt_Valor1.Text = "1"
        txt_Valor2.Text = "2"
        txt_Valor3.Text = "3"
        txt_Valor4.Text = "4"
    End Sub

    Private Sub btn_For_Click(sender As Object, e As EventArgs) Handles btn_For.Click
        Dim i As Integer
        For i = 0 To 3
            vtxt_Valor(i).Text = i * 100
        Next
    End Sub

    Private Sub btn_Indice_Click(sender As Object, e As EventArgs) Handles btn_Indice.Click
        vtxt_Valor(txt_Indice.Text).Text = "Hola"
    End Sub

    Private Sub btn_1x1_Click(sender As Object, e As EventArgs) Handles btn_1x1.Click
        vtxt_Valor(Val(txt_Indice.Text)).Text &= "A"
        txt_Indice.Text = Val(txt_Indice.Text) + 1
        If txt_Indice.Text = 4 Then
            txt_Indice.Text = 0
        End If
    End Sub
End Class
