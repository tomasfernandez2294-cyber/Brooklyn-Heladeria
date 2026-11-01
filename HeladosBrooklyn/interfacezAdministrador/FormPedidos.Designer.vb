<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.NunPedidoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnPreparacion = New System.Windows.Forms.Button()
        Me.btnFinalizados = New System.Windows.Forms.Button()
        Me.btnVerPedido = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPedidos
        '
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NunPedidoCol, Me.FechaCol, Me.EntregaCol, Me.PagoCol, Me.TotalCol})
        Me.dgvPedidos.Location = New System.Drawing.Point(55, 122)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.Size = New System.Drawing.Size(642, 150)
        Me.dgvPedidos.TabIndex = 0
        '
        'NunPedidoCol
        '
        Me.NunPedidoCol.HeaderText = "NumPedido"
        Me.NunPedidoCol.Name = "NunPedidoCol"
        '
        'FechaCol
        '
        Me.FechaCol.HeaderText = "Fecha"
        Me.FechaCol.Name = "FechaCol"
        '
        'EntregaCol
        '
        Me.EntregaCol.HeaderText = "Entrega"
        Me.EntregaCol.Name = "EntregaCol"
        '
        'PagoCol
        '
        Me.PagoCol.HeaderText = "Pago"
        Me.PagoCol.Name = "PagoCol"
        '
        'TotalCol
        '
        Me.TotalCol.HeaderText = "Total"
        Me.TotalCol.Name = "TotalCol"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(101, 51)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(91, 23)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnPreparacion
        '
        Me.btnPreparacion.Location = New System.Drawing.Point(281, 51)
        Me.btnPreparacion.Name = "btnPreparacion"
        Me.btnPreparacion.Size = New System.Drawing.Size(104, 23)
        Me.btnPreparacion.TabIndex = 2
        Me.btnPreparacion.Text = "En Preparacion"
        Me.btnPreparacion.UseVisualStyleBackColor = True
        '
        'btnFinalizados
        '
        Me.btnFinalizados.Location = New System.Drawing.Point(484, 51)
        Me.btnFinalizados.Name = "btnFinalizados"
        Me.btnFinalizados.Size = New System.Drawing.Size(93, 23)
        Me.btnFinalizados.TabIndex = 3
        Me.btnFinalizados.Text = "Finalizados"
        Me.btnFinalizados.UseVisualStyleBackColor = True
        '
        'btnVerPedido
        '
        Me.btnVerPedido.Location = New System.Drawing.Point(524, 389)
        Me.btnVerPedido.Name = "btnVerPedido"
        Me.btnVerPedido.Size = New System.Drawing.Size(75, 23)
        Me.btnVerPedido.TabIndex = 4
        Me.btnVerPedido.Text = "Ver Pedido"
        Me.btnVerPedido.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(55, 389)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "hacer conexion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnVerPedido)
        Me.Controls.Add(Me.btnFinalizados)
        Me.Controls.Add(Me.btnPreparacion)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Name = "FormPedidos"
        Me.Text = "FormPedidos"
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnPreparacion As Button
    Friend WithEvents btnFinalizados As Button
    Friend WithEvents btnVerPedido As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents NunPedidoCol As DataGridViewTextBoxColumn
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents EntregaCol As DataGridViewTextBoxColumn
    Friend WithEvents PagoCol As DataGridViewTextBoxColumn
    Friend WithEvents TotalCol As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
