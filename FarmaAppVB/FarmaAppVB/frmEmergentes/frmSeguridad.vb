Public Class frmSeguridad
    Private Sub frmSeguridad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Farma24BDDS.Rol' table. You can move, or remove it, as needed.
        Me.RolTableAdapter.Fill(Me.Farma24BDDS.Rol)
        'TODO: This line of code loads data into the 'Farma24BDDS.userRol' table. You can move, or remove it, as needed.
        Me.UserRolTableAdapter.Fill(Me.Farma24BDDS.userRol)
        btnEditar.Enabled = False
        btnEliminar.Enabled = False

    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As VariantType
        respuesta = (MsgBox("Desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso"))
        If (respuesta = vbNo) Then
            Exit Sub
        End If


        Try
            Dim idUserRol As Integer = CInt(txtIdUserRol.Text)
            Me.UserRolTableAdapter.sp_EliminarUserRol(idUserRol)
            MsgBox("Registro eliminado correctamente", MsgBoxStyle.Information, "Eliminado")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
                       MsgBoxStyle.Critical, "Error al Eliminar")
        End Try
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnAgregar.Enabled = True
        btnNuevo.PerformClick()
        Me.UserRolTableAdapter.Fill(Me.Farma24BDDS.userRol)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnEditar.Enabled = False

        Try
            Dim idUserRol As Integer = CInt(txtIdUserRol.Text)
            Dim idUser As Integer = CInt(txtIdUser.Text)
            Dim idRol As Integer = CInt(cbIdRol.SelectedValue)
            Me.UserRolTableAdapter.sp_EditarUserRol(idUserRol, idRol, idUser)
            Me.UserRolTableAdapter.Fill(Me.Farma24BDDS.userRol)
            MsgBox("Registro editado satisfactoriamente", MsgBoxStyle.Information, "Laboratorio")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al guardar")
        End Try
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        Me.UserRolTableAdapter.Fill(Me.Farma24BDDS.userRol)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim idUser As Integer = CInt(txtIdUser.Text)
            Dim idRol As Integer = CInt(cbIdRol.SelectedValue)

            Me.UserRolTableAdapter.sp_InsertarUserRol(idRol, idUser)
            Me.UserRolTableAdapter.Fill(Me.Farma24BDDS.userRol)
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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdUserRol.Text = ""
        txtIdUser.Text = ""
        txtIdUserRol.Focus()
    End Sub

    Private Sub dgvUserRol_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserRol.CellContentClick
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class