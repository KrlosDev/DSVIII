Public Class Form1
    Private Sub btn_Subir_Click(sender As Object, e As EventArgs) Handles btn_Subir.Click
        Dim x, y As Integer
        x = btn_Boton.Location.X
        y = btn_Boton.Location.Y
        btn_Boton.Location = New Point(x, y - 1)
    End Sub

    Private Sub btn_Bajar_Click(sender As Object, e As EventArgs) Handles btn_Bajar.Click
        Dim x, y As Integer
        x = btn_Boton.Location.X
        y = btn_Boton.Location.Y
        btn_Boton.Location = New Point(x, y + 1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Izquierd.Click
        Dim x, y As Integer
        x = btn_Boton.Location.X
        y = btn_Boton.Location.Y
        btn_Boton.Location = New Point(x - 1, y)
    End Sub

    Private Sub btn_Derecha_Click(sender As Object, e As EventArgs) Handles btn_Derecha.Click
        Dim x, y As Integer
        x = btn_Boton.Location.X
        y = btn_Boton.Location.Y
        btn_Boton.Location = New Point(x + 1, y)
    End Sub

    Private Sub btn_Mover_Click(sender As Object, e As EventArgs) Handles btn_Mover.Click
        tmr_Mover.Start()

    End Sub

    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick
        Dim x, y As Integer
        x = btn_Boton.Location.X
        y = btn_Boton.Location.Y
        txt_X.Text = x
        txt_Y.Text = y
        btn_Boton.Location = New Point(x, y + 1)
        If y >= 200 Then
            tmr_Mover.Stop()

        End If

    End Sub
End Class
