Public Class Form1
    Private Sub btn_For_Click(sender As Object, e As EventArgs) Handles btn_For.Click
        Dim i As Integer
        For i = 1 To 10
            lst_Valor.Items.Add(i)
        Next
    End Sub

    Private Sub btn_for2_Click(sender As Object, e As EventArgs) Handles btn_for2.Click
        Dim i As Integer
        For i = 0 To 10 Step 2
            lst_Valor.Items.Add(i)
        Next

    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        lst_Valor.Items.Clear()
    End Sub

    Private Sub btn_For3_Click(sender As Object, e As EventArgs) Handles btn_For3.Click
        Dim i As Integer
        For i = 10 To 1 Step -1
            lst_Valor.Items.Add(i)
        Next
    End Sub

    Private Sub btn_While1_Click(sender As Object, e As EventArgs) Handles btn_While1.Click
        Dim i As Integer
        i = 1
        While i <= 10
            lst_Valor.Items.Add(i)
            i += 1
        End While
    End Sub

    Private Sub btn_While2_Click(sender As Object, e As EventArgs) Handles btn_While2.Click
        Dim i As Integer
        i = 0
        While i <= 10
            lst_Valor.Items.Add(i)
            i += 2
        End While
    End Sub

    Private Sub btn_While3_Click(sender As Object, e As EventArgs) Handles btn_While3.Click
        Dim i As Integer
        i = 10
        While i >= 1
            lst_Valor.Items.Add(i)
            i -= 1
        End While
    End Sub

    Private Sub btn_Loop_Click(sender As Object, e As EventArgs) Handles btn_Loop.Click
        Dim i As Integer
        i = 1
        Do
            lst_Valor.Items.Add(i)
            i = i + 1
        Loop Until i >= 10
    End Sub
End Class
