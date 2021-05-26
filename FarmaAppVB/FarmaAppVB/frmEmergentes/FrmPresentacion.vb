Public Class FrmPresentacion
    Private Sub FrmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Farma24BDDS.Presentacion' table. You can move, or remove it, as needed.
        Me.PresentacionTableAdapter.Fill(Me.Farma24BDDS.Presentacion)
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        btnNuevo.PerformClick()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombreP.Text = ""
        txtIdPres.Text = ""
        txtViaAdmin.Text = ""
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim mP As New Presentacion

        Try
            mP.NombrePres = txtNombreP.Text.Trim
            mP.ViaAdmin = txtViaAdmin.Text.Trim
            Me.PresentacionTableAdapter.sp_InsertarPresentacion(mP.NombrePres, mP.ViaAdmin)
            Me.PresentacionTableAdapter.Fill(Me.Farma24BDDS.Presentacion)
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
            MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information, "Presentacion")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al guardar")
            btnEditar.Enabled = False
            btnAgregar.Enabled = True
            btnEliminar.Enabled = False
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnEditar.Enabled = False
        Dim mP As New Presentacion

        Try
            mP.IdPresentacion = CInt(txtIdPres.Text)
            mP.NombrePres = txtNombreP.Text.Trim
            mP.ViaAdmin = txtViaAdmin.Text.Trim
            Me.PresentacionTableAdapter.sp_EditarPresentacion(mP.IdPresentacion, mP.NombrePres, mP.ViaAdmin)
            Me.PresentacionTableAdapter.Fill(Me.Farma24BDDS.Presentacion)
            MsgBox("Registro editado satisfactoriamente", MsgBoxStyle.Information, "Presentacion")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al guardar")
        End Try
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        Me.PresentacionTableAdapter.Fill(Me.Farma24BDDS.Presentacion)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As VariantType
        respuesta = (MsgBox("Desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso"))
        If (respuesta = vbNo) Then
            Exit Sub
        End If

        Dim mP As New Presentacion
        Try
            mP.IdPresentacion = CInt(txtIdPres.Text)
            Me.PresentacionTableAdapter.sp_EliminarPresentacion(mP.IdPresentacion)
            MsgBox("Registro eliminado correctamente", MsgBoxStyle.Information, "Eliminado")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
                       MsgBoxStyle.Critical, "Error al Eliminar")
        End Try
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnAgregar.Enabled = True
        btnNuevo.PerformClick()
        Me.PresentacionTableAdapter.Fill(Me.Farma24BDDS.Presentacion)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dgvPresentacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPresentacion.CellContentClick

        btnEliminar.Enabled = True
        btnEditar.Enabled = True
    End Sub
End Class
