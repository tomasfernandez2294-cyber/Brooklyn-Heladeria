<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCarrito
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
        Me.dgvCarrito = New System.Windows.Forms.DataGridView()
        Me.ProductoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaboresCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnContinuarPedido = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCarrito
        '
        Me.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoCol, Me.SaboresCol, Me.CantidadCol, Me.SubtotalCol, Me.NotaCol})
        Me.dgvCarrito.Location = New System.Drawing.Point(12, 22)
        Me.dgvCarrito.Name = "dgvCarrito"
        Me.dgvCarrito.Size = New System.Drawing.Size(545, 150)
        Me.dgvCarrito.TabIndex = 0
        '
        'ProductoCol
        '
        Me.ProductoCol.HeaderText = "Producto"
        Me.ProductoCol.Name = "ProductoCol"
        '
        'SaboresCol
        '
        Me.SaboresCol.HeaderText = "Sabores"
        Me.SaboresCol.Name = "SaboresCol"
        '
        'CantidadCol
        '
        Me.CantidadCol.HeaderText = "Cantidad"
        Me.CantidadCol.Name = "CantidadCol"
        '
        'SubtotalCol
        '
        Me.SubtotalCol.HeaderText = "Subtotal"
        Me.SubtotalCol.Name = "SubtotalCol"
        '
        'NotaCol
        '
        Me.NotaCol.HeaderText = "Nota"
        Me.NotaCol.Name = "NotaCol"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(95, 237)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(19, 13)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "$0"
        '
        'btnContinuarPedido
        '
        Me.btnContinuarPedido.Location = New System.Drawing.Point(173, 282)
        Me.btnContinuarPedido.Name = "btnContinuarPedido"
        Me.btnContinuarPedido.Size = New System.Drawing.Size(125, 33)
        Me.btnContinuarPedido.TabIndex = 3
        Me.btnContinuarPedido.Text = "Continuar Pedido"
        Me.btnContinuarPedido.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total:"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(39, 404)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(58, 178)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(149, 178)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FormCarrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 450)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnContinuarPedido)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvCarrito)
        Me.Name = "FormCarrito"
        Me.Text = "FormCarrito"
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCarrito As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnContinuarPedido As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ProductoCol As DataGridViewTextBoxColumn
    Friend WithEvents SaboresCol As DataGridViewTextBoxColumn
    Friend WithEvents CantidadCol As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalCol As DataGridViewTextBoxColumn
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents NotaCol As DataGridViewTextBoxColumn
End Class
