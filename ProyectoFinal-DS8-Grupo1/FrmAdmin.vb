Public Class FrmAdmin
    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubMenu()
    End Sub

    Private Sub HideSubMenu()
        PanelReportes.Visible = False
    End Sub

    Private Sub ShowSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            HideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        ShowSubMenu(PanelReportes)
    End Sub

    Private Sub BtnPedidos_Click(sender As Object, e As EventArgs) Handles BtnPedidos.Click
        FrmPedidos.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInvetario_Click(sender As Object, e As EventArgs) Handles BtnInvetario.Click
        FrmProducto.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReporteRoles_Click(sender As Object, e As EventArgs) Handles BtnReporteRoles.Click
        HideSubMenu()
    End Sub

    Private Sub BtnMovimientoInv_Click(sender As Object, e As EventArgs) Handles BtnMovimientoInv.Click
        HideSubMenu()
    End Sub

    Private Sub BtnProcesadosNot_Click(sender As Object, e As EventArgs) Handles BtnProcesadosNot.Click
        HideSubMenu()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        FrmPrincipal.Show()
        Me.Close()
    End Sub
End Class