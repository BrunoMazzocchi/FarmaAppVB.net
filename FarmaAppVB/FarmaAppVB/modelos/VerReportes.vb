Imports Microsoft.Reporting.WinForms

Public Class VerReportes
    Sub verReporte(ByVal t As DataTable, ByVal ds As String, ByVal nompreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)

            frmVistaPrevia.ReportViewer1.LocalReport.DataSources.Clear()
            frmVistaPrevia.ReportViewer1.LocalReport.DataSources.Add(rpt)
            frmVistaPrevia.ReportViewer1.LocalReport.ReportPath = nompreRpt
            frmVistaPrevia.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar el reporte")
        End Try
    End Sub
End Class
