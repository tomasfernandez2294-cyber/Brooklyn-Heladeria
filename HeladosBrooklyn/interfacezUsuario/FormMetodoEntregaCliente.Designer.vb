<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMetodoEntregaCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbDelivery = New System.Windows.Forms.RadioButton()
        Me.rbRetiro = New System.Windows.Forms.RadioButton()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Como queres retirar tu pedido?"
        '
        'rbDelivery
        '
        Me.rbDelivery.AutoSize = True
        Me.rbDelivery.Location = New System.Drawing.Point(52, 119)
        Me.rbDelivery.Name = "rbDelivery"
        Me.rbDelivery.Size = New System.Drawing.Size(63, 17)
        Me.rbDelivery.TabIndex = 1
        Me.rbDelivery.TabStop = True
        Me.rbDelivery.Text = "Delivery"
        Me.rbDelivery.UseVisualStyleBackColor = True
        '
        'rbRetiro
        '
        Me.rbRetiro.AutoSize = True
        Me.rbRetiro.Location = New System.Drawing.Point(52, 160)
        Me.rbRetiro.Name = "rbRetiro"
        Me.rbRetiro.Size = New System.Drawing.Size(104, 17)
        Me.rbRetiro.TabIndex = 2
        Me.rbRetiro.TabStop = True
        Me.rbRetiro.Text = "Retiro en el local"
        Me.rbRetiro.UseVisualStyleBackColor = True
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(52, 217)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(75, 23)
        Me.btnContinuar.TabIndex = 3
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'FormMetodoEntregaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 450)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.rbRetiro)
        Me.Controls.Add(Me.rbDelivery)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMetodoEntregaCliente"
        Me.Text = "FormMetodoEntregaCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rbDelivery As RadioButton
    Friend WithEvents rbRetiro As RadioButton
    Friend WithEvents btnContinuar As Button
End Class