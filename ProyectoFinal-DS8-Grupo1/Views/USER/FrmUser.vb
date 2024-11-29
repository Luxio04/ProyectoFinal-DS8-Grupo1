Public Class FrmUser
    Private Sub RealizarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCompra.Show()
        Me.Hide()
    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub BtnCompra_Click(sender As Object, e As EventArgs) Handles BtnCompra.Click
        OpenForms(New FrmCompra())
    End Sub

    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnFactura.Click
        OpenForms(New FrmFactura())
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Hide()
        FrmPrincipal.Show()
    End Sub
    Private Property masterForms As Form = Nothing
    Private Sub OpenForms(formsDerivado As Form)
        If masterForms IsNot Nothing Then masterForms.Close()
        masterForms = formsDerivado
        formsDerivado.TopLevel = False
        formsDerivado.FormBorderStyle = FormBorderStyle.None
        formsDerivado.Dock = DockStyle.Fill
        PanelForms.Controls.Add(formsDerivado)
        PanelForms.Tag = formsDerivado
        formsDerivado.BringToFront()
        formsDerivado.Show()
    End Sub
End Class