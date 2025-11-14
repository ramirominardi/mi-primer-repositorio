
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmProductos

    Private conexion As New MySqlConnection(ModuleConexion.ConexionString)
    Private comando As MySqlCommand
    Private idSeleccionado As Integer = 0

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
    End Sub

    Private Sub CargarProductos()
        Try
            conexion.Open()
            Dim consulta As String = "SELECT ID, Nombre, Precio, Categoria FROM productos"
            Dim da As New MySqlDataAdapter(consulta, conexion)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvProductos.DataSource = dt
            dgvProductos.ClearSelection()
        Catch ex As Exception
            MsgBox("Error al cargar productos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnProdAlta_Click(sender As Object, e As EventArgs) Handles btnProdAlta.Click
        Try
            conexion.Open()
            Dim consulta As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@n,@p,@cat)"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@n", txtProdNombre.Text.Trim())
            Dim precioDec As Decimal = 0
            Decimal.TryParse(txtProdPrecio.Text, precioDec)
            comando.Parameters.AddWithValue("@p", precioDec)
            comando.Parameters.AddWithValue("@cat", txtProdCategoria.Text.Trim())
            comando.ExecuteNonQuery()
            MsgBox("Producto agregado")
        Catch ex As Exception
            MsgBox("Error al agregar producto: " & ex.Message)
        Finally
            conexion.Close()
            CargarProductos()
            LimpiarCampos()
        End Try
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvProductos.Rows(e.RowIndex)
            If row.Cells("ID").Value IsNot Nothing Then
                idSeleccionado = Convert.ToInt32(row.Cells("ID").Value)
                txtProdNombre.Text = row.Cells("Nombre").Value.ToString()
                txtProdPrecio.Text = row.Cells("Precio").Value.ToString()
                txtProdCategoria.Text = If(row.Cells("Categoria").Value IsNot DBNull.Value, row.Cells("Categoria").Value.ToString(), "")
            End If
        End If
    End Sub

    Private Sub btnProdModificar_Click(sender As Object, e As EventArgs) Handles btnProdModificar.Click
        If idSeleccionado = 0 Then
            MsgBox("Seleccione un producto para modificar.")
            Return
        End If

        Try
            conexion.Open()
            Dim consulta As String = "UPDATE productos SET Nombre=@n, Precio=@p, Categoria=@cat WHERE ID=@id"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@n", txtProdNombre.Text.Trim())
            Dim precioDec As Decimal = 0
            Decimal.TryParse(txtProdPrecio.Text, precioDec)
            comando.Parameters.AddWithValue("@p", precioDec)
            comando.Parameters.AddWithValue("@cat", txtProdCategoria.Text.Trim())
            comando.Parameters.AddWithValue("@id", idSeleccionado)
            comando.ExecuteNonQuery()
            MsgBox("Producto actualizado")
        Catch ex As Exception
            MsgBox("Error al actualizar producto: " & ex.Message)
        Finally
            conexion.Close()
            CargarProductos()
            LimpiarCampos()
        End Try
    End Sub

    Private Sub btnProdBaja_Click(sender As Object, e As EventArgs) Handles btnProdBaja.Click
        If idSeleccionado = 0 Then
            MsgBox("Seleccione un producto para eliminar.")
            Return
        End If

        If MsgBox("Confirma eliminar el producto?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Return
        End If

        Try
            conexion.Open()
            Dim consulta As String = "DELETE FROM productos WHERE ID=@id"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@id", idSeleccionado)
            comando.ExecuteNonQuery()
            MsgBox("Producto eliminado")
        Catch ex As Exception
            MsgBox("Error al eliminar producto: " & ex.Message)
        Finally
            conexion.Close()
            CargarProductos()
            LimpiarCampos()
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtProdNombre.Clear()
        txtProdPrecio.Clear()
        txtProdCategoria.Clear()
        idSeleccionado = 0
    End Sub
End Class
