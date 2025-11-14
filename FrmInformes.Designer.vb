<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformes
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
        dtpDesde = New DateTimePicker()
        dtpHasta = New DateTimePicker()
        btnBuscar = New Button()
        dgvVentasInforme = New DataGridView()
        CType(dgvVentasInforme, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpDesde
        ' 
        dtpDesde.Location = New Point(138, 64)
        dtpDesde.Name = "dtpDesde"
        dtpDesde.Size = New Size(229, 23)
        dtpDesde.TabIndex = 0
        dtpDesde.Value = New Date(2025, 11, 12, 15, 7, 0, 0)
        ' 
        ' dtpHasta
        ' 
        dtpHasta.Location = New Point(173, 124)
        dtpHasta.Name = "dtpHasta"
        dtpHasta.Size = New Size(200, 23)
        dtpHasta.TabIndex = 1
        dtpHasta.Value = New Date(2025, 11, 12, 15, 8, 0, 0)
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(206, 222)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvVentasInforme
        ' 
        dgvVentasInforme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVentasInforme.Location = New Point(515, 149)
        dgvVentasInforme.Name = "dgvVentasInforme"
        dgvVentasInforme.Size = New Size(240, 150)
        dgvVentasInforme.TabIndex = 3
        ' 
        ' FrmInformes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvVentasInforme)
        Controls.Add(btnBuscar)
        Controls.Add(dtpHasta)
        Controls.Add(dtpDesde)
        Name = "FrmInformes"
        Text = "FrmInformes"
        CType(dgvVentasInforme, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvVentasInforme As DataGridView
End Class
