Imports MaterialSkin

Public Class frmPLP
    Dim plp As New DPLP
    Private Sub frmPLP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS2.Laboratorio' Puede moverla o quitarla según sea necesario.
        Me.LaboratorioTableAdapter.Fill(Me.Farma24BDDS2.Laboratorio)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS2.Presentacion' Puede moverla o quitarla según sea necesario.
        Me.PresentacionTableAdapter.Fill(Me.Farma24BDDS2.Presentacion)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS2.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.Farma24BDDS2.Producto)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS2.PLP' Puede moverla o quitarla según sea necesario.
        Me.PLPTableAdapter.Fill(Me.Farma24BDDS2.PLP)


        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE)
        llenarGrid()
    End Sub

    Sub llenarGrid()
        dgvPLP.DataSource = plp.verProductos().Tables(0)
        dgvPLP.Refresh()
    End Sub


    Sub guardarProductos()
        Try

            Dim idPres As Integer = CInt(cbPres.SelectedValue)
            Dim idLab As Integer = CInt(cbLab.SelectedValue)
            Dim idProd As Integer = CInt(cbProducto.SelectedValue)

            plp.llenarDatos(idProd, idLab, idPres)

            MsgBox("Producto agregado satisfactoriamente",
                MsgBoxStyle.Information, "PLP")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
               MsgBoxStyle.Critical, "Error al guardar")

        End Try
        Me.PLPTableAdapter.Fill(Me.Farma24BDDS2.PLP)
        llenarGrid()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardarProductos()
    End Sub
End Class