Imports System.Data.SqlClient

Public Class frmSalida
    Dim dh As New DHistorial
    Dim dplp As New DPLP
    Private Sub frmSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS1.PLP' Puede moverla o quitarla según sea necesario.
        Me.PLPTableAdapter.Fill(Me.Farma24BDDS1.PLP)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS1.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.Farma24BDDS1.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Salida' Puede moverla o quitarla según sea necesario.
        Me.SalidaTableAdapter.Fill(Me.Farma24BDDS.Salida)
        llenarGrid()
        llenarPLP()
    End Sub


    Sub llenarGrid()


        dgvSalida.DataSource = dh.verHistorial().Tables(0)
        dgvSalida.Refresh()
    End Sub

    Sub llenarPLP()

        dplp.cbPLP(Me.cbIdPlp)
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try

            Dim idUser As Integer = CInt(cbIdUsuario.SelectedValue)
            Dim idPLP As Integer = CInt(cbIdPlp.SelectedValue)

            Dim fecha As Date = CDate(dtp.Text)
            Dim cSalida As Integer = CInt(txtCantidad.Text)
            Dim precio As Double = CDbl(txtPrecio.Text)
            Dim observ As String = txtObservacion.Text.Trim
            Dim estado As Integer = CInt(txtEstado.Text)



            Me.SalidaTableAdapter.sp_InsertarSalida(idPLP, idUser, fecha, cSalida, precio, observ)
            Me.SalidaTableAdapter.Fill(Me.Farma24BDDS.Salida)
            frmProducto.ProductoTableAdapter.Fill(Me.Farma24BDDS.Producto)
            llenarGrid()
            MsgBox("Salida agregada satisfactoriamente",
                MsgBoxStyle.Information, "PLP")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
               MsgBoxStyle.Critical, "Error al guardar")

        End Try
        frmProducto.ProductoTableAdapter.Fill(frmProducto.Farma24BDDS.Producto)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmProducto.ProductoTableAdapter.Fill(frmProducto.Farma24BDDS.Producto)
        frmProducto.Show()

    End Sub

    Private Sub frmSalida_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmProducto.Show()

    End Sub
End Class