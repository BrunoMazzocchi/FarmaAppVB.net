Imports System.Data.SqlClient

Public Class frmProductoBuscadoID
    Private Sub frmProductoBuscadoID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub
    Sub llenarGrid()
        Dim producto As New DProducto
        Dim Id As Integer
        Id = CInt(frmProducto.txtBuscarID.Text)

        dgvProdID.DataSource = producto.verProductoXID(Id).Tables()
        dgvProdID.Refresh()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim MR As New VerReportes
        Dim Id As Integer = CInt(frmProducto.txtBuscarID.Text)
        Try
            Dim tSql As String = "SELECT idProducto as 'Código', nombreProducto as 'Nombre', descripProd as 'Descripción', 
            precioProd as 'Precio', existProd as 'Existencia', expProd as 'Expiración', dosisProd as 'Dosis', 
            permisoProd as 'Permiso' FROM  Producto WHERE idProducto = " + Id + ""

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