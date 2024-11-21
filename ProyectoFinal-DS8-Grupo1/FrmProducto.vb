Public Class FrmProducto
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos iniciales en el DataGridView
        LeerRegistros()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim objConsulta As New clsProducto
        Dim mensaje As String

        ' Validar campos
        If Not ValidarCampos() Then Return

        ' Crear nuevo producto
        mensaje = objConsulta.InsertarProducto(txtNomProduct.Text, txtPrecio.Text, txtStock.Text, DateTime.Now, 1, 1, "Activo")
        MessageBox.Show(mensaje)

        ' Limpiar campos y actualizar DataGridView
        LimpiarCampos()
        LeerRegistros()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("Seleccione un producto para modificar.")
            Return
        End If

        Dim objConsulta As New clsProducto
        Dim mensaje As String

        ' Validar campos
        If Not ValidarCampos() Then Return

        ' Modificar producto
        mensaje = objConsulta.ActualizarProducto(txtNomProduct.Text, Convert.ToDecimal(txtPrecio.Text), txtStock.Text, DateTime.Now, 1, 1, CInt(txtID.Text))
        MessageBox.Show(mensaje)

        ' Limpiar campos y actualizar DataGridView
        LimpiarCampos()
        LeerRegistros()
    End Sub

    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        ' Leer registros y mostrarlos en el DataGridView
        LeerRegistros()
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Validar si los campos están vacíos
        If String.IsNullOrWhiteSpace(txtNomProduct.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtPrecio.Text) Then
            MessageBox.Show("El campo Precio es obligatorio.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtStock.Text) Then
            MessageBox.Show("El campo Stock es obligatorio.")
            Return False
        End If

        ' Campos válidos
        Return True
    End Function

    Private Sub LimpiarCampos()
        txtID.Clear()
        txtNomProduct.Clear()
        txtPrecio.Clear()
        txtStock.Clear()
    End Sub

    Private Sub LeerRegistros()
        ' Cargar los registros en el DataGridView
        Dim objConsulta As New clsProducto
        Dim table As DataTable = objConsulta.LeerProductos()
        dgvProductos.DataSource = table
    End Sub

    Private Sub dgvInventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        ' Cargar los datos de la fila seleccionada en los TextBox
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProductos.Rows(e.RowIndex)
            txtID.Text = row.Cells("ProductoID").Value.ToString()
            txtNomProduct.Text = row.Cells("NombreProducto").Value.ToString()
            txtPrecio.Text = row.Cells("Precio").Value.ToString()
            txtStock.Text = row.Cells("Stock").Value.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objConsulta As New clsProducto
        Dim mensaje As String

        ' Validar si se ha seleccionado un producto en el DataGridView
        If dgvProductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un producto para eliminar.")
            Return
        End If

        ' Obtener el ID del producto seleccionado
        Dim productoID As Integer = CInt(dgvProductos.SelectedRows(0).Cells("ProductoID").Value)

        ' Llamar a la función EliminarProducto
        mensaje = objConsulta.EliminarProducto(productoID)

        ' Mostrar mensaje de confirmación
        MessageBox.Show(mensaje)

        ' Actualizar DataGridView después de eliminar
        LeerRegistros()
    End Sub
End Class