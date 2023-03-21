Public Class Form1
    Private Sub btn_Crear_Click(sender As Object, e As EventArgs) Handles btn_Crear.Click
        Dim btn_Creado As Button
        btn_Creado = New Button()
        btn_Creado.Size = New Size(80, 30)
        btn_Creado.Text = "Creado"
        btn_Creado.Location = New Point(200, 127)
        Controls.Add(btn_Creado)
        AddHandler btn_Creado.Click, AddressOf btn_Creado_Click

    End Sub
    Private Sub btn_Creado_Click(sender As Object, e As EventArgs)
        txt_Valor.Text = "Hola"
    End Sub

    Private Sub btn_Varios_Click(sender As Object, e As EventArgs) Handles btn_Varios.Click
        Dim btn_CVarios As Button
        Dim i As Integer
        For i = 1 To 3
            btn_CVarios = New Button()
            btn_CVarios.Size = New Size(80, 30)
            btn_CVarios.Text = "Varios" & i
            btn_CVarios.Location = New Point(150 + (80 + 5) * i, 210)
            Controls.Add(btn_CVarios)
        Next
    End Sub
End Class
