Public Class FrmUser
    Private Sub RealizarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarCompraToolStripMenuItem.Click
        FrmCompra.Show()
        Me.Hide()
    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLVERToolStripMenuItem.Click
        FrmPrincipal.Show()
        Me.Close()
    End Sub
End Class