Public Class frmEditarProducto
    Private Sub frmEditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Farmacia24BDDS.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.Farma24BDDS.Producto)

    End Sub


    Private Sub frmEditarProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmProducto.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim mP As New Producto

            mP.IdProducto = CInt(txtEditarId.SelectedValue)
            mP.NombreProducto = txtNombre.Text.Trim
            mP.DescripProd = txtDescripcion.Text.Trim
            mP.PrecioProd = CDbl(txtPrecio.Text)
            mP.ExisProd = CInt(txtExistencia.Text)
            mP.ExpProd = CDate(txtExp.Text)
            mP.DosisProd = txtDosis.Text.Trim
            mP.PermisoProd = txtPermiso.Text.Trim



            frmProducto.ProductoTableAdapter.sp_EditarProducto(mP.IdProducto, mP.NombreProducto, mP.DescripProd,
                    mP.PrecioProd, mP.ExisProd, mP.ExpProd, mP.DosisProd, mP.PermisoProd)
            frmProducto.ProductoTableAdapter.Fill(frmProducto.Farma24BDDS.Producto)
            MsgBox("Producto editado satisfactoriamente",
                MsgBoxStyle.Information, "Productos")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
               MsgBoxStyle.Critical, "Error al guardar")

        End Try
        frmProducto.ProductoTableAdapter.Fill(Me.Farma24BDDS.Producto)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class