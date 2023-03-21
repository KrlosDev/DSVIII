Public Class Form1
    Dim diry As Integer
    Dim dirx As Integer
    Private Sub btn_Subir_Click(sender As Object, e As EventArgs) Handles btn_Subir.Click
        'Dim x, y As Integer
        'x = btn_Boton.Location.X
        'y = btn_Boton.Location.Y
        'btn_Boton.Location = New Point(x, y - 1)
        diry -= 1
    End Sub

    Private Sub btn_Bajar_Click(sender As Object, e As EventArgs) Handles btn_Bajar.Click
        'Dim x, y As Integer
        'x = btn_Boton.Location.X
        'y = btn_Boton.Location.Y
        'btn_Boton.Location = New Point(x, y + 1)
        diry += 1
    End Sub

    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick
        Dim x, y As Integer
        x = btn_Boton.Location.X
        y = btn_Boton.Location.Y

        txt_Y.Text = y
        txt_Height.Text = Me.Height - 40 - btn_Boton.Height
        If y <= 0 Then
            diry *= -1
            y = 0
        End If
        If y >= Me.Height - 40 - btn_Boton.Height Then
            diry *= -1
        End If
        If x <= 0 Or x >= Me.Width - btn_Boton.Width - 10 Then
            dirx *= -1

        End If
        btn_Boton.Location = New Point(x + dirx, y + diry)
    End Sub

    Private Sub btn_Mover_Click(sender As Object, e As EventArgs) Handles btn_Mover.Click
        diry = 0
        dirx = 0
        tmr_Mover.Start()


    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                diry -= 1
            Case Keys.Down
                diry += 1
            Case Keys.Left
                dirx -= 1
            Case Keys.Right
                dirx += 1
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
