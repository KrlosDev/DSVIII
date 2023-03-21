Public Class Form1
    Dim proceso As Process
    Private Sub btn_Notepad_Click(sender As Object, e As EventArgs) Handles btn_Notepad.Click
        proceso = Process.Start("notepad")
    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        proceso.CloseMainWindow()
    End Sub

    Private Sub btn_Kill_Click(sender As Object, e As EventArgs) Handles btn_Kill.Click
        proceso.Kill()
    End Sub

    Private Sub btn_Listar_Click(sender As Object, e As EventArgs) Handles btn_Listar.Click
        lst_Procesos.Items.Clear()
        For Each p As Process In Process.GetProcesses()
            lst_Procesos.Items.Add(p.ProcessName() + " " + p.Id.ToString())
        Next
    End Sub

    Private Sub btn_ListarNotepad_Click(sender As Object, e As EventArgs) Handles btn_ListarNotepad.Click
        lst_Procesos.Items.Clear()
        For Each p As Process In Process.GetProcessesByName("notepad")
            lst_Procesos.Items.Add(p.ProcessName() + " " + p.Id.ToString())
        Next
    End Sub

    Private Sub btn_KillNotepads_Click(sender As Object, e As EventArgs) Handles btn_KillNotepads.Click
        For Each p As Process In Process.GetProcessesByName("notepad")
            p.Kill()
        Next
    End Sub

    Private Sub btn_Kill_PID_Click(sender As Object, e As EventArgs) Handles btn_Kill_PID.Click
        Dim vector() As String = Split(lst_Procesos.SelectedItem)
        txt_Id.Text = vector(vector.Length - 1)
        proceso = Process.GetProcessById(Val(txt_Id.Text))
        proceso.Kill()
    End Sub
End Class
