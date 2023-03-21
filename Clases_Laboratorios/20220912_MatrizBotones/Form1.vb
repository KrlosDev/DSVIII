Public Class Form1
    Private Sub btn_Crear_Click(sender As Object, e As EventArgs) Handles btn_Crear.Click
        Dim i As Integer
        Dim btn_Boton As Button

        For i = 1 To 9
            btn_Boton = New Button()
            btn_Boton.Size = New Size(50, 50)
            btn_Boton.Location = New Point(100 + 60 * ((i - 1) Mod 3), 100 + 60 * ((i - 1) \ 3))
            btn_Boton.Text = "Boton " & i
            Controls.Add(btn_Boton)
        Next
    End Sub
End Class
