<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cmbClientes = New ComboBox()
        Label1 = New Label()
        cmbProductos = New ComboBox()
        numCantidad = New NumericUpDown()
        btnAgregarItem = New Button()
        btnConfrimarVenta = New Button()
        btnNuevaVenta = New Button()
        dgvDetalleVenta = New DataGridView()
        lblTotal = New Label()
        CType(numCantidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDetalleVenta, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbClientes
        ' 
        cmbClientes.FormattingEnabled = True
        cmbClientes.Location = New Point(261, 95)
        cmbClientes.Name = "cmbClientes"
        cmbClientes.Size = New Size(121, 23)
        cmbClientes.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(155, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 1
        Label1.Text = "clientes"
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(289, 164)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(121, 23)
        cmbProductos.TabIndex = 2
        ' 
        ' numCantidad
        ' 
        numCantidad.Location = New Point(248, 223)
        numCantidad.Name = "numCantidad"
        numCantidad.Size = New Size(120, 23)
        numCantidad.TabIndex = 3
        ' 
        ' btnAgregarItem
        ' 
        btnAgregarItem.Location = New Point(98, 177)
        btnAgregarItem.Name = "btnAgregarItem"
        btnAgregarItem.Size = New Size(75, 23)
        btnAgregarItem.TabIndex = 4
        btnAgregarItem.Text = "agregar item"
        btnAgregarItem.UseVisualStyleBackColor = True
        ' 
        ' btnConfrimarVenta
        ' 
        btnConfrimarVenta.Location = New Point(131, 277)
        btnConfrimarVenta.Name = "btnConfrimarVenta"
        btnConfrimarVenta.Size = New Size(75, 23)
        btnConfrimarVenta.TabIndex = 5
        btnConfrimarVenta.Text = "confirmar venta"
        btnConfrimarVenta.UseVisualStyleBackColor = True
        ' 
        ' btnNuevaVenta
        ' 
        btnNuevaVenta.Location = New Point(87, 116)
        btnNuevaVenta.Name = "btnNuevaVenta"
        btnNuevaVenta.Size = New Size(75, 23)
        btnNuevaVenta.TabIndex = 6
        btnNuevaVenta.Text = "nueva venta"
        btnNuevaVenta.UseVisualStyleBackColor = True
        ' 
        ' dgvDetalleVenta
        ' 
        dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalleVenta.Location = New Point(554, 125)
        dgvDetalleVenta.Name = "dgvDetalleVenta"
        dgvDetalleVenta.Size = New Size(240, 150)
        dgvDetalleVenta.TabIndex = 7
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(591, 344)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(41, 15)
        lblTotal.TabIndex = 8
        lblTotal.Text = "Label2"
        ' 
        ' FrmVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(dgvDetalleVenta)
        Controls.Add(btnNuevaVenta)
        Controls.Add(btnConfrimarVenta)
        Controls.Add(btnAgregarItem)
        Controls.Add(numCantidad)
        Controls.Add(cmbProductos)
        Controls.Add(Label1)
        Controls.Add(cmbClientes)
        Name = "FrmVentas"
        Text = "FrmVentas"
        CType(numCantidad, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDetalleVenta, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents btnAgregarItem As Button
    Friend WithEvents btnConfrimarVenta As Button
    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents dgvDetalleVenta As DataGridView
    Friend WithEvents lblTotal As Label
End Class
