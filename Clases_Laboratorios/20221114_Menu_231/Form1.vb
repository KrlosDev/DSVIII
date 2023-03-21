Public Class Form1
    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim fCliente As New Cliente
        fCliente.MdiParent = Me

        fCliente.Show()

    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim fProducto As New Productos
        fProducto.MdiParent = Me
        fProducto.Show()
    End Sub
End Class
