Imports System.Data.SqlClient

Public Class frmProductoBuscado
    Private Sub frmProductoBuscado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub


    Sub llenarGrid()
        Dim producto As New DProducto
        Dim nombre As String
        nombre = frmProducto.txtBuscar.Text.Trim
        dgvProductosFiltrados.DataSource = producto.verProductos(nombre).Tables(0)
        dgvProductosFiltrados.Refresh()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim MR As New VerReportes
        Dim nombre As String = frmProducto.txtBuscar.Text
        Try
            Dim tSql As String = "SELECT idProducto as 'Código', nombreProducto as 'Nombre', descripProd as 'Descripción', 
            precioProd as 'Precio', existProd as 'Existencia', expProd as 'Expiración', dosisProd as 'Dosis', 
            permisoProd as 'Permiso'
            FROM     Producto WHERE Producto.nombreProducto like '" + nombre + "%'"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "ImprimirDS", "reportes\rptImprimir.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub
End Class