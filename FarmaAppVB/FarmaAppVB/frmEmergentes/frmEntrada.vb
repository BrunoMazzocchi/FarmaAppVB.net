Imports MaterialSkin

Public Class frmEntrada
    Private Sub frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class