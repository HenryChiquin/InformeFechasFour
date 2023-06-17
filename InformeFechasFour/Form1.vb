Public Class Form1
    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Cargar()
    End Sub

    Private Sub Cargar()
        Dim oReporte As New FechasReporte
        oReporte.SetParameterValue("@Inicial", dtpInicio.Value.Date)
        oReporte.SetParameterValue("@Final", dtpFinal.Value.Date)

        oReporte.DataSourceConnections.Item(0).SetLogon("sa", "system")
        Me.crvFechasReporte.ReportSource = oReporte


    End Sub


End Class
