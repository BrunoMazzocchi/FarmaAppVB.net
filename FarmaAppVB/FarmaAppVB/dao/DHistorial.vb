Imports System.Data.SqlClient

Public Class DHistorial

    Dim strCn As String = My.Settings.Farma24BDConnectionString
    Private cn As New SqlConnection(strCn)

    Public Function verHistorial() As DataSet
        Dim ds As New DataSet
        Dim consulta As String = ""
        If frmEntrada.Visible = True Then
            consulta = "SELECT        Usuario.nombreUser as 'Usuario', Entrada.fechaEntrada as 'Fecha Ingreso',  Producto.nombreProducto as 'Nombre Producto', Laboratorio.nombreLab as 'Laboratorio', Presentacion.nombrePres as 'Presentacion',Entrada.cantEntrada as 'Cantidad', Entrada.precioEntrada as 'Precio', Entrada.observacion as 'Observacion'
                         FROM            Entrada INNER JOIN
                         PLP ON Entrada.idPLP = PLP.idPLP INNER JOIN
                         Usuario ON Entrada.idUser = Usuario.idUser INNER JOIN
                         Laboratorio ON PLP.idLaboratorio = Laboratorio.idLaboratorio INNER JOIN
                         Presentacion ON PLP.idPresentacion = Presentacion.idPresentacion INNER JOIN
                         Producto ON PLP.idProducto = Producto.idProducto"

        ElseIf frmSalida.Visible = True Then
            consulta = "SELECT        Usuario.nombreUser as 'Usuario', Salida.fechaSalida as 'Fecha Salida',  Producto.nombreProducto as 'Nombre Producto', Laboratorio.nombreLab as 'Laboratorio', Presentacion.nombrePres as 'Presentacion', Salida.cantSalida as 'Cantidad', Salida.precioSalida as 'Precio', Salida.observacion as 'Observacion'
                         FROM            Salida INNER JOIN
                         PLP ON Salida.idPLP = PLP.idPLP INNER JOIN
                         Usuario ON Salida.idUser = Usuario.idUser INNER JOIN
                         Laboratorio ON PLP.idLaboratorio = Laboratorio.idLaboratorio INNER JOIN
                         Presentacion ON PLP.idPresentacion = Presentacion.idPresentacion INNER JOIN
                         Producto ON PLP.idProducto = Producto.idProducto"

        End If
        Try
                Dim tSql As String = consulta
                Dim da As New SqlDataAdapter(tSql, cn)
                da.Fill(ds)
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar datos")
        End Try
        Return ds
    End Function
End Class
