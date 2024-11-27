Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class FrmReportes
    Private Sub ButtonGenerarReporteRolesYUsuarios(sender As Object, e As EventArgs)
        GenerarReporteRolesYUsuarios()
    End Sub

    Private Sub ButtonGenerarReportePedidosProcesadosYNoProcesados(sender As Object, e As EventArgs) Handles Button3.Click
        GenerarReportePedidosProcesadosYNoProcesados()
    End Sub

    Private Sub ButtonGenerarReporteMovimientoInventario(sender As Object, e As EventArgs) Handles Button2.Click
        GenerarReporteMovimientoInventario()
    End Sub

    Private Sub GenerarReporteRolesYUsuarios()
        Dim rutaPDF As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "RolesYUsuarios.pdf")
        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
        Dim connectionString As String = My.Settings.ConexionBD

        Try
            ' Crear carpeta para guardar el PDF si no existe
            Dim rutaCarpeta As String = Path.GetDirectoryName(rutaPDF)
            If Not Directory.Exists(rutaCarpeta) Then
                Directory.CreateDirectory(rutaCarpeta)
            End If

            ' Inicializar el PDF
            PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))
            doc.Open()

            ' Agregar encabezado al PDF
            doc.Add(New Paragraph("Reporte de Roles y Usuarios"))
            doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString()))
            doc.Add(New Paragraph(" "))

            ' Crear tabla para el reporte
            Dim tabla As New PdfPTable(3)
            tabla.AddCell("Rol")
            tabla.AddCell("Usuario")
            tabla.AddCell("Correo")

            ' Conectar a la base de datos y ejecutar la consulta
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT r.NombreRol AS Rol, " &
                                      "c.Nombre + ' ' + c.Apellido AS Usuario, " &
                                      "c.Correo AS Correo " &
                                      "FROM Roles r " &
                                      "INNER JOIN Colaboradores c ON r.RolID = c.RolID"

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            tabla.AddCell(reader("Rol").ToString())
                            tabla.AddCell(reader("Usuario").ToString())
                            tabla.AddCell(reader("Correo").ToString())
                        End While
                    End Using
                End Using
            End Using

            ' Agregar la tabla al PDF
            doc.Add(tabla)

            ' Mensaje de confirmación y apertura del PDF
            MessageBox.Show("Reporte de roles y usuarios generado exitosamente en: " & rutaPDF)
            AbrirPDF(rutaPDF)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If doc.IsOpen Then doc.Close()
        End Try
    End Sub

    Private Sub AbrirPDF(ByVal rutaPDF As String)
        Try
            If File.Exists(rutaPDF) Then
                Process.Start(New ProcessStartInfo With {
                    .FileName = rutaPDF,
                    .UseShellExecute = True ' Permite abrir el archivo con la aplicación predeterminada
                })
            Else
                MessageBox.Show("El archivo PDF no se encontró en la ruta especificada.")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerarReporteMovimientoInventario()
        Dim rutaPDF As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "MovimientoInventario.pdf")
        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
        Dim connectionString As String = My.Settings.ConexionBD

        Try
            ' Crear el directorio si no existe
            Dim rutaCarpeta As String = Path.GetDirectoryName(rutaPDF)
            If Not Directory.Exists(rutaCarpeta) Then
                Directory.CreateDirectory(rutaCarpeta)
            End If

            ' Crear el archivo PDF
            PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))
            doc.Open()

            ' Crear la conexión SQL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Definir la consulta SQL
                Dim query As String = "SELECT NombreProducto, Stock, FechaIngreso, PrecioUnitario FROM Productos"

                ' Ejecutar la consulta
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Agregar el título y la fecha al documento
                        doc.Add(New Paragraph("Reporte de Movimiento de Inventario"))
                        doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString("yyyy-MM-dd")))
                        doc.Add(New Paragraph(" "))

                        ' Crear la tabla PDF
                        Dim tabla As New PdfPTable(4)
                        tabla.AddCell("Producto")
                        tabla.AddCell("Stock")
                        tabla.AddCell("Fecha Ingreso")
                        tabla.AddCell("Precio Unitario")

                        ' Agregar los datos de la consulta a la tabla
                        While reader.Read()
                            tabla.AddCell(reader("NombreProducto").ToString())
                            tabla.AddCell(reader("Stock").ToString())
                            tabla.AddCell(Convert.ToDateTime(reader("FechaIngreso")).ToString("yyyy-MM-dd"))
                            tabla.AddCell(Convert.ToDecimal(reader("PrecioUnitario")).ToString("C"))
                        End While

                        ' Agregar la tabla al documento PDF
                        doc.Add(tabla)
                    End Using
                End Using
            End Using

            ' Mostrar mensaje de éxito
            MessageBox.Show("Reporte de movimiento de inventario generado exitosamente en: " & rutaPDF)
            AbrirPDF(rutaPDF)

        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Cerrar el documento PDF si está abierto
            If doc.IsOpen Then doc.Close()
        End Try
    End Sub

    Private Sub GenerarReportePedidosProcesadosYNoProcesados()
        Dim rutaPDF As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "PedidosProcesadosYNoProcesados.pdf")
        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
        Dim connectionString As String = My.Settings.ConexionBD

        Try
            ' Crear el directorio si no existe
            Dim rutaCarpeta As String = Path.GetDirectoryName(rutaPDF)
            If Not Directory.Exists(rutaCarpeta) Then
                Directory.CreateDirectory(rutaCarpeta)
            End If

            ' Crear el archivo PDF
            PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))
            doc.Open()

            ' Crear la conexión SQL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Definir la consulta SQL
                Dim query As String = "SELECT p.PedidoID, pr.NombreProveedor, p.FechaPedido, p.EstadoPedido, p.TotalPedido " &
                                  "FROM Pedidos p " &
                                  "INNER JOIN Proveedores pr ON p.ProveedorID = pr.ProveedorID"

                ' Ejecutar la consulta
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Agregar el título y la fecha al documento
                        doc.Add(New Paragraph("Reporte de Pedidos Procesados y No Procesados"))
                        doc.Add(New Paragraph("Fecha: " & DateTime.Now.ToString("yyyy-MM-dd")))
                        doc.Add(New Paragraph(" "))

                        ' Crear la tabla PDF
                        Dim tabla As New PdfPTable(5)
                        tabla.AddCell("Pedido ID")
                        tabla.AddCell("Proveedor")
                        tabla.AddCell("Fecha Pedido")
                        tabla.AddCell("Estado")
                        tabla.AddCell("Total")

                        ' Agregar los datos de la consulta a la tabla
                        While reader.Read()
                            tabla.AddCell(reader("PedidoID").ToString())
                            tabla.AddCell(reader("NombreProveedor").ToString())
                            tabla.AddCell(Convert.ToDateTime(reader("FechaPedido")).ToString("yyyy-MM-dd"))
                            tabla.AddCell(reader("EstadoPedido").ToString())
                            tabla.AddCell(Convert.ToDecimal(reader("TotalPedido")).ToString("C"))
                        End While

                        ' Agregar la tabla al documento PDF
                        doc.Add(tabla)
                    End Using
                End Using
            End Using

            ' Mostrar mensaje de éxito
            MessageBox.Show("Reporte de pedidos procesados y no procesados generado exitosamente en: " & rutaPDF)
            AbrirPDF(rutaPDF)

        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Cerrar el documento PDF si está abierto
            If doc.IsOpen Then doc.Close()
        End Try
    End Sub


End Class