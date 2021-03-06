Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms



Public Class frmReportes

    Dim MR As New VerReportes



    Private Sub frmReportes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmProducto.Show()
    End Sub


    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Try
            Dim tSql As String = "SELECT idProducto as 'Código', nombreProducto as 'Nombre', descripProd as 'Descripción', 
            precioProd as 'Precio', existProd as 'Existencia', expProd as 'Expiración', dosisProd as 'Dosis', 
            permisoProd as 'Permiso'
            FROM     Producto"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "ImprimirDS", "reportes\rptImprimir.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub btnPresentacion_Click(sender As Object, e As EventArgs) Handles btnPresentacion.Click
        Try
            Dim tSql As String = "SELECT idPresentacion as 'Código', nombrePres as 'Nombre', viaAdmin as 'Administración'  FROM  Presentacion"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "PresentacionDS", "reportes\rptPresentacion.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub btnLab_Click(sender As Object, e As EventArgs) Handles btnLab.Click
        Try
            Dim tSql As String = "SELECT idLaboratorio as 'Código', nombreLab as 'Nombre'
            FROM  Laboratorio"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "LaboratorioDS", "reportes\rptLaboratorio.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        Try
            Dim tSql As String = "   SELECT        Usuario.nombreUser as 'Usuario', Entrada.fechaEntrada as 'Fecha',  Producto.nombreProducto as 'Producto', Laboratorio.nombreLab as 'Laboratorio', Presentacion.nombrePres as 'Presentacion',Entrada.cantEntrada as 'Cantidad', Entrada.precioEntrada as 'Precio', Entrada.observacion as 'Observacion'
                         FROM            Entrada INNER JOIN
                         PLP ON Entrada.idPLP = PLP.idPLP INNER JOIN
                         Usuario ON Entrada.idUser = Usuario.idUser INNER JOIN
                         Laboratorio ON PLP.idLaboratorio = Laboratorio.idLaboratorio INNER JOIN
                         Presentacion ON PLP.idPresentacion = Presentacion.idPresentacion INNER JOIN
                         Producto ON PLP.idProducto = Producto.idProducto"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "EntradaDS", "reportes\rptEntrada.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        Try
            Dim tSql As String = "  SELECT Usuario.nombreUser as 'Usuario', Salida.fechaSalida as 'Fecha',  Producto.nombreProducto as 'Producto', Laboratorio.nombreLab as 'Laboratorio', Presentacion.nombrePres as 'Presentacion', Salida.cantSalida as 'Cantidad', Salida.precioSalida as 'Precio', Salida.observacion as 'Observacion'
                         FROM            Salida INNER JOIN
                         PLP ON Salida.idPLP = PLP.idPLP INNER JOIN
                         Usuario ON Salida.idUser = Usuario.idUser INNER JOIN
                         Laboratorio ON PLP.idLaboratorio = Laboratorio.idLaboratorio INNER JOIN
                         Presentacion ON PLP.idPresentacion = Presentacion.idPresentacion INNER JOIN
                         Producto ON PLP.idProducto = Producto.idProducto"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "SalidaDS", "reportes\rptSalida.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        Try
            Dim tSql As String = "Select nombreUser as 'Username', nombres as 'Nombre', apellidos as 'Apellidos', emailUser as 'Email', direccionUser as 'Direccion' from Usuario"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "UsuarioDS", "reportes\rptUsuarios.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub
End Class