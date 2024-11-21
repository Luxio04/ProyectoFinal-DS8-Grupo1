Public Class FrmPrincipal
    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        FrmUser.Show()
        Me.Hide()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ADMINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem.Click
        FrmAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
