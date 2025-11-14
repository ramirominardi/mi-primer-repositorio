' FrmVentas.vb
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmVentas

    Private conexion As New MySqlConnection(ModuleConexion.ConexionString)
    Private comando As MySqlCommand

    Private listaDetalles As New List(Of DetalleVenta)
    Private totalVenta As Decimal = 0

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
        CargarProductos()
        ReiniciarVenta()
    End Sub

    Private Sub CargarClientes()
        Try
            conexion.Open()
            Dim consulta As String = "SELECT ID, Cliente FROM clientes"
            Dim da As New MySqlDataAdapter(consulta, conexion)
            Dim dt As New DataTable
            da.Fill(dt)
            cmbClientes.DataSource = dt
            cmbClientes.DisplayMember = "Cliente"
            cmbClientes.ValueMember = "ID"
            cmbClientes.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error al cargar clientes: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub CargarProductos()
        Try
            conexion.Open()
            Dim consulta As String = "SELECT ID, Nombre, Precio FROM productos"
            Dim da As New MySqlDataAdapter(consulta, conexion)
            Dim dt As New DataTable
            da.Fill(dt)
            ' Para mostrar objetos Producto más firmes, convertimos a lista
            Dim lista As New List(Of Producto)
            For Each r As DataRow In dt.Rows
                Dim p As New Producto()
                p.Id = Convert.ToInt32(r("ID"))
                p.Nombre = r("Nombre").ToString()
                p.Precio = Convert.ToDecimal(r("Precio"))
                lista.Add(p)
            Next
            cmbProductos.DataSource = lista
            cmbProductos.DisplayMember = "Nombre"
            cmbProductos.ValueMember = "Id"
            cmbProductos.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error al cargar productos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub ReiniciarVenta()
        listaDetalles.Clear()
        totalVenta = 0
        dgvDetalleVenta.DataSource = Nothing
        lblTotal.Text = "Total: $0.00"
    End Sub

    Private Sub btnAgregarItem_Click(sender As Object, e As EventArgs) Handles btnAgregarItem.Click
        If cmbProductos.SelectedItem Is Nothing Then
            MsgBox("Seleccioná un producto.")
            Return
        End If

        Dim prod As Producto = CType(cmbProductos.SelectedItem, Producto)
        Dim cantidad As Integer = Convert.ToInt32(numCantidad.Value)
        If cantidad <= 0 Then
            MsgBox("La cantidad debe ser mayor a 0.")
            Return
        End If

        Dim detalle As New DetalleVenta()
        detalle.IdProducto = prod.Id
        detalle.PrecioUnitario = prod.Precio
        detalle.Cantidad = cantidad
        detalle.PrecioTotal = prod.Precio * cantidad

        listaDetalles.Add(detalle)
        totalVenta = listaDetalles.Sum(Function(d) d.PrecioTotal)

        ' Mostrar en la grilla una proyección simple
        dgvDetalleVenta.DataSource = listaDetalles.Select(Function(d) New With {
            Key .ProductoID = d.IdProducto,
            Key .PrecioUnitario = d.PrecioUnitario,
            Key .Cantidad = d.Cantidad,
            Key .PrecioTotal = d.PrecioTotal
        }).ToList()

        lblTotal.Text = "Total: $" & totalVenta.ToString("F2")
    End Sub

    Private Sub btnConfirmarVenta_Click(sender As Object, e As EventArgs) Handles btnConfirmarVenta.Click
        If cmbClientes.SelectedValue Is Nothing Then
            MsgBox("Seleccioná un cliente para la venta.")
            Return
        End If

        If listaDetalles.Count = 0 Then
            MsgBox("La venta no tiene ítems.")
            Return
        End If

        Dim idCliente As Integer = Convert.ToInt32(cmbClientes.SelectedValue)

        Try
            conexion.Open()
            ' 1) Insertar en ventas y obtener ID (LAST_INSERT_ID)
            Dim sqlVenta As String = "INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@idc, @f, @t); SELECT LAST_INSERT_ID();"
            comando = New MySqlCommand(sqlVenta, conexion)
            comando.Parameters.AddWithValue("@idc", idCliente)
            comando.Parameters.AddWithValue("@f", DateTime.Now.Date) ' o DateTime.Now si preferís time completo
            comando.Parameters.AddWithValue("@t", totalVenta)
            Dim objId = comando.ExecuteScalar()
            Dim idVenta As Integer = Convert.ToInt32(objId)

            ' 2) Insertar cada detalle en ventasitems
            For Each d In listaDetalles
                Dim sqlDet As String = "INSERT INTO ventasitems (IDVenta, IdProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@iv, @ip, @pu, @c, @pt)"
                Dim cmdDet As New MySqlCommand(sqlDet, conexion)
                cmdDet.Parameters.AddWithValue("@iv", idVenta)
                cmdDet.Parameters.AddWithValue("@ip", d.IdProducto)
                cmdDet.Parameters.AddWithValue("@pu", d.PrecioUnitario)
                cmdDet.Parameters.AddWithValue("@c", d.Cantidad)
                cmdDet.Parameters.AddWithValue("@pt", d.PrecioTotal)
                cmdDet.ExecuteNonQuery()
            Next

            MsgBox("Venta registrada correctamente. ID Venta: " & idVenta.ToString())
            ReiniciarVenta()
        Catch ex As Exception
            MsgBox("Error al registrar venta: " & ex.Message)
        Finally
            conexion.Close()
            ' Actualizamos listas por si algo cambió
            CargarClientes()
            CargarProductos()
        End Try
    End Sub

    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        ReiniciarVenta()
    End Sub
End Class
