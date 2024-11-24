Public Class FrmCompra
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

    End Sub

    Private Sub BntQuitar_Click(sender As Object, e As EventArgs) Handles BntQuitar.Click

    End Sub

    Private Sub BntCompra_Click(sender As Object, e As EventArgs) Handles BntCompra.Click

    End Sub

    Private Sub BntFactura_Click(sender As Object, e As EventArgs) Handles BntFactura.Click
        FrmFactura.Show()
        Me.Hide()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class