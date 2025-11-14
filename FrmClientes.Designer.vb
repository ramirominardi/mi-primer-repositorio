<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        txtCliente = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtTelefono = New TextBox()
        Label3 = New Label()
        txtCorreo = New TextBox()
        dgvClientes = New DataGridView()
        btnAlta = New Button()
        btnModificar = New Button()
        btnBaja = New Button()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(127, 97)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(100, 23)
        txtCliente.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 1
        Label1.Text = "Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 2
        Label2.Text = "telefono"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(128, 175)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(52, 250)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 4
        Label3.Text = "correo"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(130, 250)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(100, 23)
        txtCorreo.TabIndex = 5
        ' 
        ' dgvClientes
        ' 
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Location = New Point(474, 89)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.Size = New Size(240, 150)
        dgvClientes.TabIndex = 6
        ' 
        ' btnAlta
        ' 
        btnAlta.Location = New Point(327, 71)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(75, 23)
        btnAlta.TabIndex = 7
        btnAlta.Text = "alta"
        btnAlta.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(330, 139)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 23)
        btnModificar.TabIndex = 8
        btnModificar.Text = "modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnBaja
        ' 
        btnBaja.Location = New Point(335, 213)
        btnBaja.Name = "btnBaja"
        btnBaja.Size = New Size(75, 23)
        btnBaja.TabIndex = 9
        btnBaja.Text = "baja"
        btnBaja.UseVisualStyleBackColor = True
        ' 
        ' FrmClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBaja)
        Controls.Add(btnModificar)
        Controls.Add(btnAlta)
        Controls.Add(dgvClientes)
        Controls.Add(txtCorreo)
        Controls.Add(Label3)
        Controls.Add(txtTelefono)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtCliente)
        Name = "FrmClientes"
        Text = "FrmClientes"
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBaja As Button
End Class
