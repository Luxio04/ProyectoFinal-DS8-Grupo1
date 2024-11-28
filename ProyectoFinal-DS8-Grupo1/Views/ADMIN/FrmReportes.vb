Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports com.itextpdf.text.pdf
Imports ProyectoFinal_DS8_Grupo1.clsReportes

Public Class FrmReportes
    'Variables
    Public Property ReporteId As Integer

    Private Sub ButtonGenerarReporteRolesYUsuarios(sender As Object, e As EventArgs)
        clsReportes.GenerarReporteRolesYUsuarios()
    End Sub

    Private Sub ButtonGenerarReportePedidosProcesadosYNoProcesados(sender As Object, e As EventArgs) Handles Button3.Click
        clsReportes.GenerarReportePedidosProcesadosYNoProcesados()
    End Sub

    Private Sub ButtonGenerarReporteMovimientoInventario(sender As Object, e As EventArgs) Handles Button2.Click
        clsReportes.GenerarReporteMovimientoInventario()
    End Sub

    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case ReporteId
            Case 1
                grupoInventario.Visible = False
                grupoPedidos.Visible = False
                listDatos.Items.Clear()
                Dim datos As List(Of RolColaborador) = clsReportes.FetchRolesUsuarios()
                For Each dato In datos
                    With listDatos.Items.Add($"{dato.Usuario}")
                        .SubItems.Add($"{dato.Correo}")
                        .SubItems.Add($"{dato.Rol}")
                    End With
                Next
            Case 2
                grupoUsuarios.Visible = False
                grupoPedidos.Visible = False
            Case 3
                grupoUsuarios.Visible = False
                grupoInventario.Visible = False
        End Select
    End Sub

End Class