
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmClientes

    Private conexion As New MySqlConnection(ModuleConexion.ConexionString)
    Private comando As MySqlCommand
    Private idseleccionado As Integer = 0

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub

    Private Sub CargarClientes()
        Try
            conexion.Open()
            Dim consulta As String = "SELECT ID, Cliente, Telefono, Correo FROM clientes"
            Dim da As New MySqlDataAdapter(consulta, conexion)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvClientes.DataSource = dt
            dgvClientes.ClearSelection()
        Catch ex As Exception
            MsgBox("Error al cargar clientes: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Try
            conexion.Open()
            Dim consulta As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@c,@t,@co)"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@c", txtCliente.Text.Trim())
            comando.Parameters.AddWithValue("@t", txtTelefono.Text.Trim())
            comando.Parameters.AddWithValue("@co", txtCorreo.Text.Trim())
            comando.ExecuteNonQuery()
            MsgBox("Cliente agregado correctamente")
        Catch ex As Exception
            MsgBox("Error al agregar cliente: " & ex.Message)
        Finally
            conexion.Close()
            CargarClientes()
            LimpiarCampos()
        End Try
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        If e.RowIndex >= 0 Then
            Dim fila = dgvClientes.Rows(e.RowIndex)
            If fila.Cells("ID").Value IsNot Nothing Then
                idseleccionado = Convert.ToInt32(fila.Cells("ID").Value)
                txtCliente.Text = fila.Cells("Cliente").Value.ToString()
                txtTelefono.Text = If(fila.Cells("Telefono").Value IsNot DBNull.Value, fila.Cells("Telefono").Value.ToString(), "")
                txtCorreo.Text = If(fila.Cells("Correo").Value IsNot DBNull.Value, fila.Cells("Correo").Value.ToString(), "")
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If idseleccionado = 0 Then
            MsgBox("Seleccione un cliente para modificar.")
            Return
        End If

        Try
            conexion.Open()
            Dim consulta As String = "UPDATE clientes SET Cliente=@c, Telefono=@t, Correo=@co WHERE ID=@id"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@c", txtCliente.Text.Trim())
            comando.Parameters.AddWithValue("@t", txtTelefono.Text.Trim())
            comando.Parameters.AddWithValue("@co", txtCorreo.Text.Trim())
            comando.Parameters.AddWithValue("@id", idseleccionado)
            comando.ExecuteNonQuery()
            MsgBox("Cliente actualizado")
        Catch ex As Exception
            MsgBox("Error al actualizar cliente: " & ex.Message)
        Finally
            conexion.Close()
            CargarClientes()
            LimpiarCampos()
        End Try
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If idseleccionado = 0 Then
            MsgBox("Seleccione un cliente para eliminar.")
            Return
        End If

        If MsgBox("¿Confirma eliminar el cliente seleccionado?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Return
        End If

        Try
            conexion.Open()
            Dim consulta As String = "DELETE FROM clientes WHERE ID=@id"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@id", idseleccionado)
            comando.ExecuteNonQuery()
            MsgBox("Cliente eliminado")
        Catch ex As Exception
            MsgBox("Error al eliminar cliente: " & ex.Message)
        Finally
            conexion.Close()
            CargarClientes()
            LimpiarCampos()
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtCliente.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        idseleccionado = 0
    End Sub
End Class
