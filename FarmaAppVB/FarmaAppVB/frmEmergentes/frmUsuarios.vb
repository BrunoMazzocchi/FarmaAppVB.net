Public Class frmUsuarios
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Farma24BDDS.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.Farma24BDDS.Usuario)
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        btnNuevo.PerformClick()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdUser.Clear()
        txtUsername.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtPwd.Clear()
        txtEmail.Clear()
        txtDireccion.Clear()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim U As New Usuario

        Try
            U.Username = txtUsername.Text.Trim
            U.Nombres = txtNombre.Text.Trim
            U.Apellidos = txtApellido.Text.Trim
            U.Pwd = txtPwd.Text.Trim
            U.EmailUser = txtEmail.Text.Trim
            U.Direccion = txtDireccion.Text.Trim
            Me.UsuarioTableAdapter.sp_InsertarUser(U.Username, U.Nombres, U.Apellidos, U.Pwd, U.EmailUser, U.Direccion)
            Me.UsuarioTableAdapter.Fill(Me.Farma24BDDS.Usuario)
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
            MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information, "Laboratorios")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al guardar")
            btnEditar.Enabled = False
            btnAgregar.Enabled = True
            btnEliminar.Enabled = False
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnEditar.Enabled = False
        Dim U As New Usuario

        Try
            U.IdUser = CInt(txtIdUser.Text)
            U.Username = txtUsername.Text.Trim
            U.Nombres = txtNombre.Text.Trim
            U.Apellidos = txtApellido.Text.Trim
            U.Pwd = txtPwd.Text.Trim
            U.EmailUser = txtEmail.Text.Trim
            U.Direccion = txtDireccion.Text.Trim
            Me.UsuarioTableAdapter.sp_EditarUser(U.IdUser, U.Username, U.Nombres, U.Apellidos, U.Pwd, U.EmailUser, U.Direccion)
            Me.UsuarioTableAdapter.Fill(Me.Farma24BDDS.Usuario)
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
            MsgBox("Registro editado satisfactoriamente", MsgBoxStyle.Information, "Laboratorio")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al guardar")
        End Try
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        Me.UsuarioTableAdapter.Fill(Me.Farma24BDDS.Usuario)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As VariantType
        respuesta = (MsgBox("Desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso"))
        If (respuesta = vbNo) Then
            Exit Sub
        End If

        Dim U As New Usuario
        Try
            U.IdUser = CInt(txtIdUser.Text)
            Me.UsuarioTableAdapter.sp_EliminarUser(U.IdUser)
            Me.UsuarioTableAdapter.Fill(Me.Farma24BDDS.Usuario)
            MsgBox("Registro eliminado correctamente", MsgBoxStyle.Information, "Eliminado")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
                       MsgBoxStyle.Critical, "Error al Eliminar")
        End Try
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnAgregar.Enabled = True
        btnNuevo.PerformClick()
        Me.UsuarioTableAdapter.Fill(Me.Farma24BDDS.Usuario)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick

        btnEliminar.Enabled = True
        btnEditar.Enabled = True
    End Sub

    Private Sub btnSeguridad_Click(sender As Object, e As EventArgs) Handles btnSeguridad.Click
        frmSeguridad.Show()
    End Sub
End Class