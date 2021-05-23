Imports MaterialSkin

Public Class frmEntrada
    Private Sub frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Salida' Puede moverla o quitarla según sea necesario.
        Me.SalidaTableAdapter.Fill(Me.Farma24BDDS.Salida)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Entrada' Puede moverla o quitarla según sea necesario.
        Me.EntradaTableAdapter.Fill(Me.Farma24BDDS.Entrada)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.PLP' Puede moverla o quitarla según sea necesario.
        Me.PLPTableAdapter.Fill(Me.Farma24BDDS.PLP)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.Farma24BDDS.Usuario)


        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE)
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmProducto.Show()
    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try

            Dim idUser As Integer = CInt(cbIdUsuario.SelectedValue)
            Dim idPLP As Integer = CInt(cbIdPlp.SelectedValue)

            Dim fecha As DateTime = CDate(dtp.Text)
            Dim cEntrada As Integer = CInt(txtCantidad.Text)
            Dim precio As Double = CDbl(txtPrecio.Text)
            Dim observ As String = txtObservacion.Text.Trim
            Dim estado As Integer = CInt(txtEstado.Text)



            Me.EntradaTableAdapter.sp_InsertarEntrada(idPLP, idUser, fecha, cEntrada, precio, observ)
            Me.EntradaTableAdapter.Fill(Me.Farma24BDDS.Entrada)
            frmProducto.ProductoTableAdapter.Fill(Me.Farma24BDDS.Producto)
            MsgBox("Entrada agregada satisfactoriamente",
                MsgBoxStyle.Information, "Entradas")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
               MsgBoxStyle.Critical, "Error al guardar")

        End Try
        frmProducto.ProductoTableAdapter.Fill(frmProducto.Farma24BDDS.Producto)

    End Sub

    Private Sub frmEntrada_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmProducto.Show()
        frmProducto.ProductoTableAdapter.Fill(frmProducto.Farma24BDDS.Producto)

    End Sub
End Class