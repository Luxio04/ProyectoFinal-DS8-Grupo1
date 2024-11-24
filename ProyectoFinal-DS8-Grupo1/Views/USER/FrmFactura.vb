Public Class FrmFactura
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Hide()
        FrmUser.Show()
    End Sub
End Class