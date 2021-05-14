Public Class FrmLaboratorio
    Private Sub FrmLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Farma24BDDS.Laboratorio' table. You can move, or remove it, as needed.
        Me.LaboratorioTableAdapter.Fill(Me.Farma24BDDS.Laboratorio)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtnombreLab.Text = ""
        txtnombreL.Text = ""
        txtidLab.Text = ""
        txtIdL.Text = ""
        txtnombreLab.Focus()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim mL As New Laboratorio

        Try
            mL.NombreLab = txtnombreLab.Text.Trim
            Me.LaboratorioTableAdapter.sp_InsertarLaboratorio(mL.NombreLab)
            Me.LaboratorioTableAdapter.Fill(Me.Farma24BDDS.Laboratorio)
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
        Dim mL As New Laboratorio

        Try
            mL.IdLaboratorio = CInt(txtidLab.Text)
            mL.NombreLab = txtnombreL.Text.Trim
            Me.LaboratorioTableAdapter.sp_EditarLaboratorio(mL.IdLaboratorio, mL.NombreLab)
            Me.LaboratorioTableAdapter.Fill(Me.Farma24BDDS.Laboratorio)
            MsgBox("Registro editado satisfactoriamente", MsgBoxStyle.Information, "Laboratorio")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al guardar")
        End Try
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        Me.LaboratorioTableAdapter.Fill(Me.Farma24BDDS.Laboratorio)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As VariantType
        respuesta = (MsgBox("Desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso"))
        If (respuesta = vbNo) Then
            Exit Sub
        End If

        Dim mL As New Laboratorio
        Try
            mL.IdLaboratorio = CInt(txtIdL.Text)
            Me.LaboratorioTableAdapter.sp_EliminarLaboratorio(mL.IdLaboratorio)
            MsgBox("Registro eliminado correctamente", MsgBoxStyle.Information, "Eliminado")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
                       MsgBoxStyle.Critical, "Error al Eliminar")
        End Try
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnAgregar.Enabled = True
        btnNuevo.PerformClick()
        Me.LaboratorioTableAdapter.Fill(Me.Farma24BDDS.Laboratorio)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        btnAgregar.Enabled = False
        btnEliminar.Enabled = True
        btnEditar.Enabled = True
    End Sub
End Class