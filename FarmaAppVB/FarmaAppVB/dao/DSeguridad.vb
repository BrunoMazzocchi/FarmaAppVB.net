Imports System.Data.SqlClient

Public Class DSeguridad
    Dim strCn As String = My.Settings.Farma24BDConnectionString
    Private cn As New SqlConnection(strCn)

    Public Function verUserRole() As DataSet
        Dim ds As New DataSet
        Try
            Dim tSql As String = "SELECT Rol.rolName as 'Nombre de rol', Usuario.nombreUser as 'Usuario'
                  FROM     userRol INNER JOIN
                  Rol ON userRol.idRol = Rol.idRol INNER JOIN
                  Usuario ON userRol.idUser = Usuario.idUser"
            Dim da As New SqlDataAdapter(tSql, cn)
            da.Fill(ds)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar datos")
        End Try
        Return ds
    End Function

    Public Function cb(ByVal cbUserRol As ComboBox)

        Dim tsql As String = "SELECT      userRol.idUserRol, Usuario.nombreUser + ' | ' + Rol.rolName AS 'userrol'
                        FROM            userRol INNER JOIN
                         Usuario ON userRol.idUser = Usuario.idUser INNER JOIN
                         Rol ON userRol.idRol = Rol.idRol"

        Dim cmd As SqlCommand = New SqlCommand(tsql, cn)
        cn.Open()


        Dim ad As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim t As DataTable = New DataTable("UserRol")

        ad.Fill(t)

        cbUserRol.DataSource = t
        cbUserRol.DisplayMember = "userrol"
        cbUserRol.ValueMember = "idUserRol"

    End Function

End Class
