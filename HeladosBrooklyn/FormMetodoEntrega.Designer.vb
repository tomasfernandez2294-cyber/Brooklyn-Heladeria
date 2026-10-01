<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMetodoEntrega
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.chkHabilitado = New System.Windows.Forms.CheckBox()
        Me.chkPermitirPedidos = New System.Windows.Forms.CheckBox()
        Me.chkSolicitarEntreCalles = New System.Windows.Forms.CheckBox()
        Me.lblRecargoDescuento = New System.Windows.Forms.Label()
        Me.txtRecargoDescuento = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(13, 13)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(81, 13)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(127, 22)
        Me.txtNombre.TabIndex = 1
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(81, 77)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipo.TabIndex = 2
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(16, 83)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(40, 17)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "Tipo:"
        '
        'chkHabilitado
        '
        Me.chkHabilitado.AutoSize = True
        Me.chkHabilitado.Checked = True
        Me.chkHabilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHabilitado.Location = New System.Drawing.Point(16, 143)
        Me.chkHabilitado.Name = "chkHabilitado"
        Me.chkHabilitado.Size = New System.Drawing.Size(93, 21)
        Me.chkHabilitado.TabIndex = 4
        Me.chkHabilitado.Text = "Habilitado"
        Me.chkHabilitado.UseVisualStyleBackColor = True
        '
        'chkPermitirPedidos
        '
        Me.chkPermitirPedidos.AutoSize = True
        Me.chkPermitirPedidos.Checked = True
        Me.chkPermitirPedidos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPermitirPedidos.Location = New System.Drawing.Point(16, 184)
        Me.chkPermitirPedidos.Name = "chkPermitirPedidos"
        Me.chkPermitirPedidos.Size = New System.Drawing.Size(132, 21)
        Me.chkPermitirPedidos.TabIndex = 5
        Me.chkPermitirPedidos.Text = "Permitir pedidos"
        Me.chkPermitirPedidos.UseVisualStyleBackColor = True
        '
        'chkSolicitarEntreCalles
        '
        Me.chkSolicitarEntreCalles.AutoSize = True
        Me.chkSolicitarEntreCalles.Location = New System.Drawing.Point(16, 220)
        Me.chkSolicitarEntreCalles.Name = "chkSolicitarEntreCalles"
        Me.chkSolicitarEntreCalles.Size = New System.Drawing.Size(157, 21)
        Me.chkSolicitarEntreCalles.TabIndex = 6
        Me.chkSolicitarEntreCalles.Text = "Solicitar entre calles"
        Me.chkSolicitarEntreCalles.UseVisualStyleBackColor = True
        '
        'lblRecargoDescuento
        '
        Me.lblRecargoDescuento.AutoSize = True
        Me.lblRecargoDescuento.Location = New System.Drawing.Point(19, 261)
        Me.lblRecargoDescuento.Name = "lblRecargoDescuento"
        Me.lblRecargoDescuento.Size = New System.Drawing.Size(172, 17)
        Me.lblRecargoDescuento.TabIndex = 7
        Me.lblRecargoDescuento.Text = "Recargo / Descuento (%):"
        '
        'txtRecargoDescuento
        '
        Me.txtRecargoDescuento.Location = New System.Drawing.Point(81, 294)
        Me.txtRecargoDescuento.Name = "txtRecargoDescuento"
        Me.txtRecargoDescuento.Size = New System.Drawing.Size(121, 22)
        Me.txtRecargoDescuento.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(116, 331)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 35)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'FormMetodoEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtRecargoDescuento)
        Me.Controls.Add(Me.lblRecargoDescuento)
        Me.Controls.Add(Me.chkSolicitarEntreCalles)
        Me.Controls.Add(Me.chkPermitirPedidos)
        Me.Controls.Add(Me.chkHabilitado)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FormMetodoEntrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Método de Entrega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents chkHabilitado As CheckBox
    Friend WithEvents chkPermitirPedidos As CheckBox
    Friend WithEvents chkSolicitarEntreCalles As CheckBox
    Friend WithEvents lblRecargoDescuento As Label
    Friend WithEvents txtRecargoDescuento As TextBox
    Friend WithEvents btnGuardar As Button
End Class
