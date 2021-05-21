Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms



Public Class frmReportes

    Dim MR As New VerReportes
    Private Sub btnLab_Click(sender As Object, e As EventArgs) Handles btnLab.Click
        Try
            Dim tSql As String = "SELECT idLaboratorio as 'Código', nombreLab as 'Nombre',  estadoLab as 'Estado'
            FROM  Laboratorio"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "LaboratorioDS", "D:\Users\Bruno\Documents\GITHUB\FarmaApp\FarmaAppVB.net\FarmaAppVB\FarmaAppVB\reportes\rptLaboratorio.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Try
            Dim tSql As String = "SELECT idProducto as 'Código', nombreProducto as 'Nombre', descripProd as 'Descripción', 
            precioProd as 'Precio', existProd as 'Existencia', expProd as 'Expiración', dosisProd as 'Dosis', 
            permisoProd as 'Permiso', estadoProd as 'Estado'
            FROM     Producto"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "ImprimirDS", "D:\Users\Bruno\Documents\GITHUB\FarmaApp\FarmaAppVB.net\FarmaAppVB\FarmaAppVB\reportes\rptImprimir.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub frmReportes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmProducto.Show()
    End Sub

    Private Sub btnPresentacion_Click(sender As Object, e As EventArgs) Handles btnPresentacion.Click
        Try
            Dim tSql As String = "SELECT idPresentacion as 'Código', nombrePres as 'Nombre', viaAdmin as 'Administración', 
             estadoPres as 'Estado'  FROM  Presentacion"
            Dim conex As New SqlConnection(My.Settings.Farma24BDConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            MR.verReporte(t, "PresentacionDS", "D:\Users\Bruno\Documents\GITHUB\FarmaApp\FarmaAppVB.net\FarmaAppVB\FarmaAppVB\reportes\rptPresentacion.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub
End Class