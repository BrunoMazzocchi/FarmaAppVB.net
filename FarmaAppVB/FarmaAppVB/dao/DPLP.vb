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
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Public Function cbPLP(ByVal cbIdPlp As ComboBox)

        Dim tsql As String = "SELECT PLP.idPLP, Producto.nombreProducto + ' | ' + Laboratorio.nombreLab + ' | ' + Presentacion.nombrePres as 'Nombre PLP'
                    FROM     PLP INNER JOIN
                  Laboratorio ON PLP.idLaboratorio = Laboratorio.idLaboratorio INNER JOIN
                  Presentacion ON PLP.idPresentacion = Presentacion.idPresentacion INNER JOIN
                  Producto ON PLP.idProducto = Producto.idProducto "

        Dim cmd As SqlCommand = New SqlCommand(tsql, cn)
        cn.Open()


        Dim ad As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim t As DataTable = New DataTable("PLP")

        ad.Fill(t)

        cbIdPlp.DataSource = t
        cbIdPlp.DisplayMember = "Nombre PLP"
        cbIdPlp.ValueMember = "idPLP"

    End Function
End Class
