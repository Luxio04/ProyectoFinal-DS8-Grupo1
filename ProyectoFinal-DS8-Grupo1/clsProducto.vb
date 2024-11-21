Imports System.Data.SqlClient
Imports System.Configuration
Public Class clsProducto
    Private connectionString As String = My.Settings.ConexionBD

    ' Inserta un nuevo producto en la base de datos.
    Public Function InsertarProducto(nombre As String, precio As String, stock As String, fechaIngreso As Date, proveedorID As String, categoriaID As String, estado As String) As String
        Dim mensaje As String = ""
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand("InsertarProducto", conn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Agregar los parámetros
                cmd.Parameters.AddWithValue("@NombreProducto", nombre)
                cmd.Parameters.AddWithValue("@Precio", CDec(precio))
                cmd.Parameters.AddWithValue("@Stock", CInt(stock))
                ' Ejecutar el comando
                cmd.ExecuteNonQuery()
                mensaje = "Producto insertado correctamente"
            Catch ex As Exception
                mensaje = "Error: " & ex.Message
            Finally
                conn.Close()
            End Try
        End Using
        Return mensaje
    End Function

    ' Actualiza un producto existente en la base de datos.
    Public Function ActualizarProducto(nombre As String, precio As String, stock As String, fechaIngreso As Date, proveedorID As String, categoriaID As String, productoID As Integer) As String
        Dim mensaje As String = ""
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand("ModificarProducto", conn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Agregar los parámetros
                cmd.Parameters.AddWithValue("@ProductoID", CInt(productoID))
                cmd.Parameters.AddWithValue("@NombreProducto", nombre)
                cmd.Parameters.AddWithValue("@Precio", CDec(precio))
                cmd.Parameters.AddWithValue("@Stock", CInt(stock))

                ' Ejecutar el comando
                cmd.ExecuteNonQuery()
                mensaje = "Producto actualizado correctamente"
            Catch ex As Exception
                mensaje = "Error: " & ex.Message
            Finally
                conn.Close()
            End Try
        End Using
        Return mensaje
    End Function

    Public Function EliminarProducto(id As Integer) As String
        Dim mensaje As String = ""
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand("EliminarProducto", conn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Agregar el parámetro
                cmd.Parameters.AddWithValue("@ID", id)

                ' Ejecutar el comando
                cmd.ExecuteNonQuery()
                mensaje = "Producto eliminado correctamente"
            Catch ex As Exception
                mensaje = "Error: " & ex.Message
            Finally
                conn.Close()
            End Try
        End Using
        Return mensaje
    End Function

    ' Lee todos los productos de la base de datos.
    Public Function LeerProductos() As DataTable
        Dim table As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand("MostrarProducto", conn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(table)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        Return table
    End Function

    ' Valida si un producto puede ser insertado.
    Public Function ValidarInsercionProducto(nombreProducto As String, precio As Decimal, proveedorID As Integer) As Boolean
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand("ValidarProductosInsercion", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@NombreProducto", nombreProducto)
                cmd.Parameters.AddWithValue("@Precio", precio)
                Dim totalProductos As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If totalProductos > 0 Then
                    MessageBox.Show("Ya existe un producto con estos datos. Inserción no permitida.")
                    Return False
                End If
            End Using
        End Using
        Return True
    End Function

    ' Valida si un producto puede ser actualizado.
    Public Function ValidarActualizacionProducto(productoID As Integer, nombreProducto As String, precio As Decimal, proveedorID As Integer) As Boolean
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand("ValidarProductosActualizacion", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ProductoID", productoID)
                cmd.Parameters.AddWithValue("@NombreProducto", nombreProducto)
                cmd.Parameters.AddWithValue("@Precio", precio)

                Dim totalProductos As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If totalProductos > 0 Then
                    MessageBox.Show("Ya existe un producto con estos datos. Actualización no permitida.")
                    Return False
                End If
            End Using
        End Using
        Return True
    End Function
End Class
