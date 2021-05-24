Imports System.Data.SqlClient

Public Class DPLP
    Dim strCn As String = My.Settings.Farma24BDConnectionString
    Private cn As New SqlConnection(strCn)

    Public Function verProductos() As DataSet
        Dim ds As New DataSet
        Try
            Dim tSql As String = "select * from PLPconNombres"
            Dim da As New SqlDataAdapter(tSql, cn)
            da.Fill(ds)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar datos")
        End Try
        Return ds
    End Function

    Public Function llenarDatos(ByVal producto As Integer, ByVal laboratorio As Integer, ByVal presentacion As Integer)
        Try
            cn.Open()
            Dim tsql As String = "sp_insertarPLP"
            Dim cmd As New SqlCommand(tsql, cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idProd", producto)
            cmd.Parameters.AddWithValue("@idLab", laboratorio)
            cmd.Parameters.AddWithValue("@idPres", presentacion)

            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class
