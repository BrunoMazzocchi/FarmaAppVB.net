Imports System.Data.SqlClient

Public Class DLogin
    Dim strCn As String = My.Settings.Farma24BDConnectionString
    Private cn As New SqlConnection(strCn)
    Public Function verificarRol(username As String, pwd As String) As Integer
        Dim sql As String
        Dim permiso As Integer

        Try

            sql = " declare @rol int 
            exec sp_verificarUserRol @username, @password, @rol output
            select @rol"

            Dim cmd As New SqlCommand(sql, cn)
            cmd.CommandType = CommandType.Text
            cn.Open()


            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", pwd)
            permiso = cmd.ExecuteScalar()



            frmProducto.permiso(permiso)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return permiso
    End Function

    Sub iniciarSesion(username As String, pwd As String)
        Dim sql As String
        sql = "SELECT * FROM Usuario WHERE nombreUser='" & username & "'AND pwd='" & pwd & "'"
        Dim cmd As New SqlCommand(sql, cn)
        Dim dr As SqlDataReader
        cn.Open()
        dr = cmd.ExecuteReader



        If dr.Read = True Then
            MsgBox("Bienvenido " + username, MsgBoxStyle.Information, "Mensaje")
            frmProducto.LeerUsuario(username)
            frmProducto.Show()
            frmIniciarSesion.Hide()
        Else
            MsgBox("El usuario o contraseña no coinciden", MsgBoxStyle.Critical, "Advertencia")
        End If
        cn.Close()
    End Sub

End Class
