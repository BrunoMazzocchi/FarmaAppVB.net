Public Class frmSalida
    Private Sub frmSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS1.PLP' Puede moverla o quitarla según sea necesario.
        Me.PLPTableAdapter.Fill(Me.Farma24BDDS1.PLP)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS1.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.Farma24BDDS1.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Salida' Puede moverla o quitarla según sea necesario.
        Me.SalidaTableAdapter.Fill(Me.Farma24BDDS.Salida)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try

            Dim idUser As Integer = CInt(cbIdUsuario.SelectedValue)
            Dim idPLP As Integer = CInt(cbIdPlp.SelectedValue)

            Dim fecha As DateTime = CDate(dtp.Text)
            Dim cSalida As Integer = CInt(txtCantidad.Text)
            Dim precio As Double = CDbl(txtPrecio.Text)
            Dim observ As String = txtObservacion.Text.Trim
            Dim estado As Integer = CInt(txtEstado.Text)



            Me.SalidaTableAdapter.sp_InsertarSalida(idPLP, idUser, fecha, cSalida, precio, observ)
            Me.SalidaTableAdapter.Fill(Me.Farma24BDDS.Salida)
            MsgBox("Salida agregada satisfactoriamente",
                MsgBoxStyle.Information, "PLP")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
               MsgBoxStyle.Critical, "Error al guardar")

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class