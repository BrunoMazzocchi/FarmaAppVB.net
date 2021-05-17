Public Class frmAgregarProducto
    Protected Overrides Sub Finalize()
        MyBase.Finalize()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim mP As New Producto


            mP.NombreProducto = txtNombre.Text.Trim
            mP.DescripProd = txtDescripcion.Text.Trim
            mP.PrecioProd = CDbl(txtPrecio.Text)
            mP.ExisProd = CInt(txtExistencia.Text)
            mP.ExpProd = CDate(txtExp.Text)
            mP.DosisProd = txtDosis.Text.Trim
            mP.PermisoProd = txtPermiso.Text.Trim



            frmProducto.ProductoTableAdapter.sp_InsertarProducto(mP.NombreProducto, mP.DescripProd,
                    mP.PrecioProd, mP.ExisProd, mP.ExpProd, mP.DosisProd, mP.PermisoProd)
            frmProducto.ProductoTableAdapter.Fill(frmProducto.Farma24BDDS.Producto)
            MsgBox("Producto agregado satisfactoriamente",
                MsgBoxStyle.Information, "Productos")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
               MsgBoxStyle.Critical, "Error al guardar")

        End Try
        frmProducto.ProductoTableAdapter.Fill(frmProducto.Farma24BDDS.Producto)

    End Sub

    Private Sub frmAgregarProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmProducto.Show()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtEstado.Text = ""
        txtDescripcion.Text = ""
        txtExistencia.Text = ""
        txtPermiso.Text = ""
        txtPrecio.Text = ""
        txtNombre.Text = ""
        txtDosis.Text = ""

    End Sub
End Class