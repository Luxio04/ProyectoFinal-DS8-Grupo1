Public Class FrmFactura
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        FrmPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        FrmCompra.Show()
        Me.Close()

    End Sub
End Class