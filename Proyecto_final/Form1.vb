Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudianteToolStripMenuItem.Click
        Me.IsMdiContainer = True
        With Form2
            .MdiParent = Me
            .Show()
        End With
        Form3.Close()
        Form4.Close()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.IsMdiContainer = True
        With Form3
            .MdiParent = Me
            .Show()
        End With
        Form2.Close()
        Form4.Close()
    End Sub

    Private Sub ProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesorToolStripMenuItem.Click
        Me.IsMdiContainer = True
        With Form4
            .MdiParent = Me
            .Show()
        End With
        Form2.Close()
        Form3.Close()
    End Sub
End Class
