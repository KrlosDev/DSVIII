Public Class Form1
    Private Sub btn_Cargar_Click(sender As Object, e As EventArgs) Handles btn_Cargar.Click
        Dim entero As Integer
        Dim doble As Double
        Dim cadena As String
        'entero = 876.38374
        doble = 342.532
        cadena = "Hola"
        txt_Entero.Text = entero + 20
        txt_Double.Text = doble
        txt_String.Text = cadena

    End Sub

    Private Sub btn_Cambiar_Click(sender As Object, e As EventArgs) Handles btn_Cambiar.Click
        lbl_Entero.Text = "Integer"
    End Sub
End Class
