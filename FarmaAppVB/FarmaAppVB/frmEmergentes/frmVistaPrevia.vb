Imports Microsoft.Reporting.WinForms

Public Class frmVistaPrevia
    Private Sub frmVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Farma24BDDS.Producto' Puede moverla o quitarla según sea necesario.
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class