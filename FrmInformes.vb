' FrmInforme.vb
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmInforme
    Private conexion As New MySqlConnection(ModuleConexion.ConexionString)

    Private Sub FrmInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDesde.Value = Date.Today.AddMonths(-1)
        dtpHasta.Value = Date.Today
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            conexion.Open()
            Dim desde As Date = dtpDesde.Value.Date
            Dim hasta As Date = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1)

            Dim sql As String = "SELECT v.ID AS IDVenta, v.Fecha, v.Total, c.Cliente AS Cliente FROM ventas v LEFT JOIN clientes c ON v.IDCliente = c.ID WHERE v.Fecha BETWEEN @d AND @h ORDER BY v.Fecha"
            Dim cmd As New MySqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@d", desde)
            cmd.Parameters.AddWithValue("@h", hasta)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvVentasInforme.DataSource = dt
        Catch ex As Exception
            MsgBox("Error al generar informe: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
