Public Class FrmCreateUser
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BntRegistrar_Click(sender As Object, e As EventArgs) Handles BntRegistrar.Click

    End Sub

    Private Function ValidarCampos() As Boolean
        ' Verificar si alguno de los TextBox está vacío
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("El campo Contraseña es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Validar longitud de la contraseña
        Dim password As String = txtPass.Text
        If password.Length < 8 OrElse password.Length > 13 Then
            MessageBox.Show("La contraseña debe tener entre 8 y 13 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Validar caracteres especiales permitidos
        Dim permitido As String = "_*-.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        If Not password.All(Function(c) permitido.Contains(c)) Then
            MessageBox.Show("La contraseña contiene caracteres no permitidos. Solo se permiten: _*-.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Validar que tenga al menos una letra mayúscula
        If Not password.Any(AddressOf Char.IsUpper) Then
            MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Validar que tenga al menos un número
        If Not password.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("La contraseña debe contener al menos un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Focus()
            Return False
        End If

        ' Si todas las validaciones pasan
        Return True
    End Function

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub
End Class