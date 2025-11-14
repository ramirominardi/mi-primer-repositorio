<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        txtProdNombre = New TextBox()
        Label1 = New Label()
        txtProdPrecio = New TextBox()
        Label2 = New Label()
        txtProdCategoria = New TextBox()
        Label3 = New Label()
        dgvProductos = New DataGridView()
        btnProdAlta = New Button()
        btnProdModificar = New Button()
        btnProdBaja = New Button()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtProdNombre
        ' 
        txtProdNombre.Location = New Point(161, 55)
        txtProdNombre.Name = "txtProdNombre"
        txtProdNombre.Size = New Size(100, 23)
        txtProdNombre.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 1
        Label1.Text = "prod nombre"
        ' 
        ' txtProdPrecio
        ' 
        txtProdPrecio.Location = New Point(174, 125)
        txtProdPrecio.Name = "txtProdPrecio"
        txtProdPrecio.Size = New Size(100, 23)
        txtProdPrecio.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 15)
        Label2.TabIndex = 3
        Label2.Text = "precio producto"
        ' 
        ' txtProdCategoria
        ' 
        txtProdCategoria.Location = New Point(174, 195)
        txtProdCategoria.Name = "txtProdCategoria"
        txtProdCategoria.Size = New Size(100, 23)
        txtProdCategoria.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 15)
        Label3.TabIndex = 5
        Label3.Text = "categoria producto"
        ' 
        ' dgvProductos
        ' 
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(461, 95)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New Size(240, 150)
        dgvProductos.TabIndex = 6
        ' 
        ' btnProdAlta
        ' 
        btnProdAlta.Location = New Point(324, 98)
        btnProdAlta.Name = "btnProdAlta"
        btnProdAlta.Size = New Size(75, 23)
        btnProdAlta.TabIndex = 7
        btnProdAlta.Text = "alta"
        btnProdAlta.UseVisualStyleBackColor = True
        ' 
        ' btnProdModificar
        ' 
        btnProdModificar.Location = New Point(335, 154)
        btnProdModificar.Name = "btnProdModificar"
        btnProdModificar.Size = New Size(75, 23)
        btnProdModificar.TabIndex = 8
        btnProdModificar.Text = "modificar"
        btnProdModificar.UseVisualStyleBackColor = True
        ' 
        ' btnProdBaja
        ' 
        btnProdBaja.Location = New Point(336, 203)
        btnProdBaja.Name = "btnProdBaja"
        btnProdBaja.Size = New Size(75, 23)
        btnProdBaja.TabIndex = 9
        btnProdBaja.Text = "baja"
        btnProdBaja.UseVisualStyleBackColor = True
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnProdBaja)
        Controls.Add(btnProdModificar)
        Controls.Add(btnProdAlta)
        Controls.Add(dgvProductos)
        Controls.Add(Label3)
        Controls.Add(txtProdCategoria)
        Controls.Add(Label2)
        Controls.Add(txtProdPrecio)
        Controls.Add(Label1)
        Controls.Add(txtProdNombre)
        Name = "FrmProductos"
        Text = "FrmProductos"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtProdNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProdPrecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProdCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnProdAlta As Button
    Friend WithEvents btnProdModificar As Button
    Friend WithEvents btnProdBaja As Button
End Class
