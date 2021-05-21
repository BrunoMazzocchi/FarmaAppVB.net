Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmProducto
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.Farma24BDDS.Producto)

    End Sub
    Sub LeerUsuario(ByVal nombre As String)
        lbUser.Text = nombre
    End Sub


    Private Sub frmProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmIniciarSesion.Show()

    End Sub


    Private Sub btnHistorial_Click(sender As Object, e As EventArgs)
        MsgBox("Boton aun en desarrollo", MsgBoxStyle.Information, "Hola Mundo")
    End Sub


    Private Sub btnBuscarID_Click(sender As Object, e As EventArgs)
        MsgBox("Boton aun en desarrollo", MsgBoxStyle.Information, "Hola Mundo")
    End Sub


    Private Sub cbHistorial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHistorial.SelectedIndexChanged
        If cbHistorial.SelectedItem.Equals("Entradas") Then
            frmEntrada.Show()
        ElseIf cbHistorial.SelectedItem.Equals("Salidas") Then
            frmSalida.Show()

        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            frmAgregarProducto.Show()

        Catch ex As Exception
            MsgBox("Error al agregar", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            frmEditarProducto.Show()

        Catch ex As Exception
            MsgBox("Error al editar", MsgBoxStyle.Critical, "Error")
        End Try
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

    End Sub

    Private Sub btnLaboratorio_Click(sender As Object, e As EventArgs) Handles btnLaboratorio.Click
        FrmLaboratorio.Show()
    End Sub

    Private Sub btnPresentacion_Click(sender As Object, e As EventArgs) Handles btnPresentacion.Click
        FrmPresentacion.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnPlp_Click(sender As Object, e As EventArgs) Handles btnPlp.Click
        frmPLP.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text.Equals("") Then
            MsgBox("Campo vacio", MsgBoxStyle.Information)
            Exit Sub
        End If
        frmProductoBuscado.Show()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        frmReportes.Show()
        Me.Hide()
    End Sub
End Class