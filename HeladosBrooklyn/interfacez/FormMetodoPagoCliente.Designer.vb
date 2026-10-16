<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMetodoPagoCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.rbMercadoPago = New System.Windows.Forms.RadioButton()
        Me.rbTarjeta = New System.Windows.Forms.RadioButton()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnIrPedido = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Como queres pagar?"
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Location = New System.Drawing.Point(82, 100)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rbEfectivo.TabIndex = 1
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "Efectivo"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'rbMercadoPago
        '
        Me.rbMercadoPago.AutoSize = True
        Me.rbMercadoPago.Location = New System.Drawing.Point(82, 146)
        Me.rbMercadoPago.Name = "rbMercadoPago"
        Me.rbMercadoPago.Size = New System.Drawing.Size(95, 17)
        Me.rbMercadoPago.TabIndex = 2
        Me.rbMercadoPago.TabStop = True
        Me.rbMercadoPago.Text = "Mercado Pago"
        Me.rbMercadoPago.UseVisualStyleBackColor = True
        '
        'rbTarjeta
        '
        Me.rbTarjeta.AutoSize = True
        Me.rbTarjeta.Location = New System.Drawing.Point(82, 187)
        Me.rbTarjeta.Name = "rbTarjeta"
        Me.rbTarjeta.Size = New System.Drawing.Size(58, 17)
        Me.rbTarjeta.TabIndex = 3
        Me.rbTarjeta.TabStop = True
        Me.rbTarjeta.Text = "Tarjeta"
        Me.rbTarjeta.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(82, 247)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(95, 38)
        Me.btnConfirmar.TabIndex = 4
        Me.btnConfirmar.Text = "Confirmar Pedido"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(45, 389)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnIrPedido
        '
        Me.btnIrPedido.Location = New System.Drawing.Point(357, 389)
        Me.btnIrPedido.Name = "btnIrPedido"
        Me.btnIrPedido.Size = New System.Drawing.Size(75, 23)
        Me.btnIrPedido.TabIndex = 6
        Me.btnIrPedido.Text = "IrPedido"
        Me.btnIrPedido.UseVisualStyleBackColor = True
        '
        'FormMetodoPagoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnIrPedido)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.rbTarjeta)
        Me.Controls.Add(Me.rbMercadoPago)
        Me.Controls.Add(Me.rbEfectivo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMetodoPagoCliente"
        Me.Text = "FormMetodoPagoCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rbEfectivo As RadioButton
    Friend WithEvents rbMercadoPago As RadioButton
    Friend WithEvents rbTarjeta As RadioButton
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnIrPedido As Button
End Class
