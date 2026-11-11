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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoCupon = New System.Windows.Forms.TextBox()
        Me.btnAplicarCupon = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCarrito
        '
        Me.dgvCarrito.AllowUserToAddRows = False
        Me.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoCol, Me.SaboresCol, Me.CantidadCol, Me.SubtotalCol, Me.NotaCol})
        Me.dgvCarrito.Location = New System.Drawing.Point(12, 54)
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
        Me.lblTotal.Location = New System.Drawing.Point(486, 416)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(19, 13)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "$0"
        '
        'btnContinuarPedido
        '
        Me.btnContinuarPedido.Location = New System.Drawing.Point(432, 449)
        Me.btnContinuarPedido.Name = "btnContinuarPedido"
        Me.btnContinuarPedido.Size = New System.Drawing.Size(125, 33)
        Me.btnContinuarPedido.TabIndex = 3
        Me.btnContinuarPedido.Text = "Continuar Pedido"
        Me.btnContinuarPedido.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total:"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(37, 459)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(312, 210)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(403, 210)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mi Carrito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "¿Tenés un cupón de descuento?"
        '
        'txtCodigoCupon
        '
        Me.txtCodigoCupon.Location = New System.Drawing.Point(30, 297)
        Me.txtCodigoCupon.Name = "txtCodigoCupon"
        Me.txtCodigoCupon.Size = New System.Drawing.Size(315, 20)
        Me.txtCodigoCupon.TabIndex = 10
        '
        'btnAplicarCupon
        '
        Me.btnAplicarCupon.Location = New System.Drawing.Point(377, 297)
        Me.btnAplicarCupon.Name = "btnAplicarCupon"
        Me.btnAplicarCupon.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicarCupon.TabIndex = 11
        Me.btnAplicarCupon.Text = "Aplicar"
        Me.btnAplicarCupon.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Resumen del Pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Sub Total"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(486, 374)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(19, 13)
        Me.lblSubtotal.TabIndex = 14
        Me.lblSubtotal.Text = "$0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Descuento"
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(486, 398)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(19, 13)
        Me.lblDescuento.TabIndex = 16
        Me.lblDescuento.Text = "$0"
        '
        'FormCarrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 506)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAplicarCupon)
        Me.Controls.Add(Me.txtCodigoCupon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoCupon As TextBox
    Friend WithEvents btnAplicarCupon As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDescuento As Label
End Class
