<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSaboresCliente
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.grpSabores = New System.Windows.Forms.GroupBox()
        Me.clbSabores = New System.Windows.Forms.CheckedListBox()
        Me.lblLimiteSabores = New System.Windows.Forms.Label()
        Me.GBNotasAdicionales = New System.Windows.Forms.GroupBox()
        Me.txtNotasAdicionales = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAgregarPedido = New System.Windows.Forms.Button()
        Me.grpSabores.SuspendLayout()
        Me.GBNotasAdicionales.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "imagen"
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(135, 154)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(87, 13)
        Me.lblNombreProducto.TabIndex = 1
        Me.lblNombreProducto.Text = "nombre producto"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(155, 181)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(36, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "precio"
        '
        'grpSabores
        '
        Me.grpSabores.Controls.Add(Me.clbSabores)
        Me.grpSabores.Controls.Add(Me.lblLimiteSabores)
        Me.grpSabores.Location = New System.Drawing.Point(11, 215)
        Me.grpSabores.Name = "grpSabores"
        Me.grpSabores.Size = New System.Drawing.Size(319, 100)
        Me.grpSabores.TabIndex = 4
        Me.grpSabores.TabStop = False
        Me.grpSabores.Text = "Sabores"
        '
        'clbSabores
        '
        Me.clbSabores.FormattingEnabled = True
        Me.clbSabores.Location = New System.Drawing.Point(6, 29)
        Me.clbSabores.Name = "clbSabores"
        Me.clbSabores.Size = New System.Drawing.Size(156, 34)
        Me.clbSabores.TabIndex = 1
        '
        'lblLimiteSabores
        '
        Me.lblLimiteSabores.AutoSize = True
        Me.lblLimiteSabores.Location = New System.Drawing.Point(276, 16)
        Me.lblLimiteSabores.Name = "lblLimiteSabores"
        Me.lblLimiteSabores.Size = New System.Drawing.Size(33, 13)
        Me.lblLimiteSabores.TabIndex = 0
        Me.lblLimiteSabores.Text = " 0 / 4"
        '
        'GBNotasAdicionales
        '
        Me.GBNotasAdicionales.Controls.Add(Me.txtNotasAdicionales)
        Me.GBNotasAdicionales.Location = New System.Drawing.Point(11, 342)
        Me.GBNotasAdicionales.Name = "GBNotasAdicionales"
        Me.GBNotasAdicionales.Size = New System.Drawing.Size(319, 100)
        Me.GBNotasAdicionales.TabIndex = 5
        Me.GBNotasAdicionales.TabStop = False
        Me.GBNotasAdicionales.Text = "Notas Adicionales"
        '
        'txtNotasAdicionales
        '
        Me.txtNotasAdicionales.Location = New System.Drawing.Point(6, 28)
        Me.txtNotasAdicionales.Name = "txtNotasAdicionales"
        Me.txtNotasAdicionales.Size = New System.Drawing.Size(291, 20)
        Me.txtNotasAdicionales.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 467)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(278, 467)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(42, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "total ($)"
        '
        'btnAgregarPedido
        '
        Me.btnAgregarPedido.Location = New System.Drawing.Point(122, 504)
        Me.btnAgregarPedido.Name = "btnAgregarPedido"
        Me.btnAgregarPedido.Size = New System.Drawing.Size(100, 23)
        Me.btnAgregarPedido.TabIndex = 8
        Me.btnAgregarPedido.Text = "Agregar al Pedido"
        Me.btnAgregarPedido.UseVisualStyleBackColor = True
        '
        'FormSaboresCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 554)
        Me.Controls.Add(Me.btnAgregarPedido)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GBNotasAdicionales)
        Me.Controls.Add(Me.grpSabores)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormSaboresCliente"
        Me.Text = "FormSaboresCliente"
        Me.grpSabores.ResumeLayout(False)
        Me.grpSabores.PerformLayout()
        Me.GBNotasAdicionales.ResumeLayout(False)
        Me.GBNotasAdicionales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents grpSabores As GroupBox
    Friend WithEvents GBNotasAdicionales As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAgregarPedido As Button
    Friend WithEvents clbSabores As CheckedListBox
    Friend WithEvents lblLimiteSabores As Label
    Friend WithEvents txtNotasAdicionales As TextBox
End Class
