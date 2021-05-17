Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmIniciarSesion
    Dim cn As New SqlConnection("Data Source=DESKTOP-96F57BE;Initial Catalog=Farma24BD;Persist Security Info=True;User ID=sa;Password=123")
    Dim cont As Integer
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ''Cierra el formulario 
        Me.Close()
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

    Private Sub txtPwd_MouseEnter(sender As Object, e As EventArgs) Handles txtPwd.MouseEnter
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

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        ''Inicio de sesion en sql server (Esta manera es de prueba)
        Dim sql As String
        sql = "SELECT * FROM Usuario WHERE nombres='" & txtNombre.Text & "'AND pwd='" & txtPwd.Text & "'"
        Dim cmd As New SqlCommand(sql, cn)
        Dim dr As SqlDataReader
        cn.Open()
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MessageBox.Show("Bienvenido", "Mensaje")
            frmProducto.Show()
            Me.Hide()
        Else
            cont = cont + 1
            MsgBox("El usuario o contraseña no coinciden", 32, "Advertencia")
            txtNombre.Text = ""
            txtPwd.Text = ""
            txtNombre.Focus()
            If cont > 2 Then
                MsgBox("Excedio los intentos", 16, "Advertencia")
                Me.Close()
            End If
        End If

        cn.Close()

    End Sub

    Private Sub frmIniciarSesion_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        txtNombre.Text = ""
        txtPwd.Text = ""
    End Sub
End Class
