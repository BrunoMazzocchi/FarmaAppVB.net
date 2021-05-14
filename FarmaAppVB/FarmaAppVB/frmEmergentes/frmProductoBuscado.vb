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
End Class