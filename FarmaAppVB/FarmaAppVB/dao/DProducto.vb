Imports System.Data.SqlClient

Public Class DProducto
    Dim strCn As String = My.Settings.Farma24BDConnectionString
    Private cn As New SqlConnection(strCn)

    Public Function verProductos(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim tSql As String = "Select Producto.nombreProducto as 'ID', Producto.descripProd as 'Descripcion', Producto.precioProd as 'Precio', 
        Producto.existProd as 'Existencia', Producto.expProd as 'Expiracion', Producto.dosisProd as 'Dosis',
		Producto.permisoProd as 'Permiso', Presentacion.nombrePres as 'Presentacion', Presentacion.viaAdmin as 'Via', Laboratorio.nombreLab as 'Laboratorio'
		From Producto INNER JOIN
			PLP ON Producto.idProducto = PLP.idProducto INNER JOIN
			Presentacion ON PLP.idPresentacion = Presentacion.idPresentacion INNER JOIN
			Laboratorio ON PLP.idLaboratorio = Laboratorio.idLaboratorio
	        WHERE Producto.nombreProducto = '" + nombre + "%'"
            Dim da As New SqlDataAdapter(tSql, cn)
            da.Fill(ds)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar datos")
        End Try
        Return ds
    End Function

End Class
