Public Class FrmUser
    Private Sub RealizarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCompra.Show()
        Me.Hide()
    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub BtnCatalogo_Click(sender As Object, e As EventArgs) Handles BtnCatalogo.Click

    End Sub

    Private Sub BtnCompra_Click(sender As Object, e As EventArgs) Handles BtnCompra.Click

    End Sub

    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnFactura.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

    End Sub
End Class