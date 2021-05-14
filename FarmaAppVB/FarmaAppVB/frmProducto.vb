Public Class frmProducto
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.Farma24BDDS.Producto)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As VariantType
        respuesta = (MsgBox("Desea eliminar el producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso"))
        If (respuesta = vbNo) Then
            Exit Sub
        End If

        Dim mP As New Producto
        Try
            mP.IdProducto = CInt(txtBuscarID.Text)
            Me.ProductoTableAdapter.sp_EliminarProducto(mP.IdProducto)
            MsgBox("Producto eliminado correctamente", MsgBoxStyle.Information, "Eliminado")
            Me.ProductoTableAdapter.Fill(Me.Farma24BDDS.Producto)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
                   MsgBoxStyle.Critical, "Error al Eliminar")

        End Try
        Me.ProductoTableAdapter.Fill(Me.Farma24BDDS.Producto)

        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnAgregar.Enabled = True
        btnAgregar.PerformClick()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            frmEditarProducto.Show()

        Catch ex As Exception
            MsgBox("Error al editar", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class