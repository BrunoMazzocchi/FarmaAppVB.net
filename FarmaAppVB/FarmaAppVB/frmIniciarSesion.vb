Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MaterialSkin

Public Class frmIniciarSesion

    Private Sub frmIniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE)
    End Sub




    Private Sub txtNombre_MouseEnter(sender As Object, e As EventArgs) Handles txtNombre.MouseEnter
        Dim colorText As Color
        colorText = Color.FromArgb(54, 60, 72)
        If txtNombre.Text = "Nombre de usuario" Then
            txtNombre.Text = ""
            txtNombre.ForeColor = colorText
        End If
    End Sub

    Private Sub txtNombre_MouseLeave(sender As Object, e As EventArgs) Handles txtNombre.MouseLeave
        Dim colorHint As Color
        colorHint = Color.FromArgb(118, 132, 158)
        If txtNombre.Text = "" Then
            txtNombre.Text = "Nombre de usuario"
            txtNombre.ForeColor = colorHint
        End If
    End Sub

    Private Sub txtNombre_VisibleChanged(sender As Object, e As EventArgs) Handles txtNombre.VisibleChanged
        Dim colorHint As Color
        colorHint = Color.FromArgb(118, 132, 158)
        If txtNombre.Text = "" Then
            txtNombre.Text = "Nombre de usuario"
            txtNombre.ForeColor = colorHint
        End If
    End Sub

    Private Sub txtPwd_MouseEnter(sender As Object, e As EventArgs) Handles txtPwd.MouseEnter
        Dim colorText As Color
        colorText = Color.FromArgb(54, 60, 72)
        If txtPwd.Text = "Contraseña" Then
            txtPwd.Text = ""
            txtPwd.PasswordChar = "*"
            txtPwd.ForeColor = colorText
        End If
    End Sub

    Private Sub txtNombre_GotFocus(sender As Object, e As EventArgs) Handles txtNombre.GotFocus
        Dim colorText As Color
        colorText = Color.FromArgb(54, 60, 72)
        If txtNombre.Text = "Nombre de usuario" Then
            txtNombre.Text = ""
            txtNombre.ForeColor = colorText
        End If
    End Sub

    Private Sub txtPwd_GotFocus(sender As Object, e As EventArgs) Handles txtPwd.GotFocus
        Dim colorText As Color
        colorText = Color.FromArgb(54, 60, 72)
        If txtPwd.Text = "Contraseña" Then
            txtPwd.Text = ""
            txtPwd.PasswordChar = "*"
            txtPwd.ForeColor = colorText
        End If
    End Sub

    Private Sub txtPwd_MouseLeave(sender As Object, e As EventArgs) Handles txtPwd.MouseLeave
        Dim colorHint As Color
        colorHint = Color.FromArgb(118, 132, 158)
        If txtPwd.Text = "" Then
            txtPwd.Text = "Contraseña"
            txtPwd.PasswordChar = ""
            txtPwd.ForeColor = colorHint
        End If
    End Sub

    Private Sub txtPwd_VisibleChanged(sender As Object, e As EventArgs) Handles txtPwd.VisibleChanged
        Dim colorHint As Color
        colorHint = Color.FromArgb(118, 132, 158)
        If txtPwd.Text = "" Then
            txtPwd.Text = "Contraseña"
            txtPwd.PasswordChar = ""
            txtPwd.ForeColor = colorHint
        End If
    End Sub

    Private Sub frmIniciarSesion_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        txtNombre.Text = ""
        txtPwd.Text = ""
    End Sub




    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        Dim username As String = txtNombre.Text
        Dim pwd As String = txtPwd.Text
        Dim login As New DLogin
        Try
            login.iniciarSesion(username, pwd)

            txtNombre.Text = ""
            txtPwd.Text = ""
        Catch ex As Exception
            MsgBox("Error al iniciar sesion", MsgBoxStyle.Critical, "Advertencia")
        End Try
        login.verificarRol(username, pwd)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub




End Class
