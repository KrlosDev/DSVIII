Public Class Form1
    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim fCliente As New Cliente
        cerrarFormulario()
        fCliente.MdiParent = Me

        fCliente.Show()

    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim fProducto As New Productos
        cerrarFormulario()
        fProducto.MdiParent = Me
        fProducto.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cerrarFormulario()
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
    End Sub
End Class
