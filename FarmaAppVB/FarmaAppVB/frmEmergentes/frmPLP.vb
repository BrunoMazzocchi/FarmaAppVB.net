Imports MaterialSkin

Public Class frmPLP
    Private Sub frmPLP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS1.PLP' Puede moverla o quitarla según sea necesario.
        Me.PLPTableAdapter.Fill(Me.Farma24BDDS1.PLP)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS1.PLP' Puede moverla o quitarla según sea necesario.
        Me.PLPTableAdapter.Fill(Me.Farma24BDDS1.PLP)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Laboratorio' Puede moverla o quitarla según sea necesario.
        Me.LaboratorioTableAdapter.Fill(Me.Farma24BDDS.Laboratorio)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Presentacion' Puede moverla o quitarla según sea necesario.
        Me.PresentacionTableAdapter.Fill(Me.Farma24BDDS.Presentacion)
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.Farma24BDDS.Producto)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE)
    End Sub

    Private Sub MostrarNombreProdToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ProductoTableAdapter.MostrarNombreProd(Me.Farma24BDDS.Producto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MostrarPlpToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PLPTableAdapter.MostrarPlp(Me.Farma24BDDS.PLP)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MostrarPlpToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.PLPTableAdapter.MostrarPlp(Me.Farma24BDDS.PLP)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim idPres As Integer = CInt(cbPres.SelectedValue)
            Dim idLab As Integer = CInt(cbLab.SelectedValue)
            Dim idProd As Integer = CInt(cbProducto.SelectedValue)

            Me.PLPTableAdapter.sp_InsertarPLP(idProd, idPres, idLab)
            Me.PLPTableAdapter.Fill(Me.Farma24BDDS.PLP)
            MsgBox("Producto agregado satisfactoriamente",
                MsgBoxStyle.Information, "PLP")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message,
               MsgBoxStyle.Critical, "Error al guardar")

        End Try

    End Sub
End Class