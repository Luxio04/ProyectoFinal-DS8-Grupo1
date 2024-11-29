Imports System.Text.RegularExpressions

Public Class FrmColaborador
    Dim objColab As New clsColaborador
    Private Sub BtnRegistrarColab_Click(sender As Object, e As EventArgs) Handles BtnRegistrarColab.Click

    End Sub

    Private Sub BtnPassword_Click(sender As Object, e As EventArgs) Handles BtnPassword.Click

    End Sub

    Private Sub BtnEmail_Click(sender As Object, e As EventArgs) Handles BtnEmail.Click

    End Sub

    Private Sub FrmColaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCorreoColab.Enabled = False
        txtPassColab.Enabled = False
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Verificar si alguno de los TextBox está vacío
        If String.IsNullOrWhiteSpace(txtNombreColab.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreColab.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtApellidoColab.Text) Then
            MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApellidoColab.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtTelefonoColab.Text) Then
            MessageBox.Show("El campo Telefono es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelefonoColab.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtDireccionColab.Text) Then
            MessageBox.Show("El campo Direccion es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDireccionColab.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtUserName.Text) Then
            MessageBox.Show("El campo UserName es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserName.Focus()
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtPassColab.Text) Then
            MessageBox.Show("El campo Contraseña es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If

        ' Validar longitud de la contraseña
        Dim password As String = txtPassColab.Text
        If password.Length < 8 OrElse password.Length > 13 Then
            MessageBox.Show("La contraseña debe tener entre 8 y 13 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If

        ' Validar caracteres especiales permitidos
        Dim permitido As String = "_*-.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        If Not password.All(Function(c) permitido.Contains(c)) Then
            MessageBox.Show("La contraseña contiene caracteres no permitidos. Solo se permiten: _*-.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If

        ' Validar que tenga al menos una letra mayúscula
        If Not password.Any(AddressOf Char.IsUpper) Then
            MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If

        ' Validar que tenga al menos un número
        If Not password.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("La contraseña debe contener al menos un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassColab.Focus()
            Return False
        End If

        ' Si todas las validaciones pasan
        Return True
    End Function

    Public Function EsCorreoValido(correo As String) As Boolean
        Dim regex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Return regex.IsMatch(correo)
    End Function

    Private Sub LimpiarCampos()
        txtUserName.Clear()
        txtPassColab.Clear()
        txtNombreColab.Clear()
        txtApellidoColab.Clear()
        txtCorreoColab.Clear()
        txtDireccionColab.Clear()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

    End Sub
End Class