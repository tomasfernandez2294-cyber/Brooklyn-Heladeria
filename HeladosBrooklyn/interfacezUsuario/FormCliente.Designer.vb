<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCliente))
        Me.flpContenido = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.picPortada = New System.Windows.Forms.PictureBox()
        Me.pnlContacto = New System.Windows.Forms.Panel()
        Me.btnCompartir = New System.Windows.Forms.Button()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.btnWhatsApp = New System.Windows.Forms.Button()
        Me.flpCategorias = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpProductos = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlProducto1 = New System.Windows.Forms.Panel()
        Me.btnVerCarrito = New System.Windows.Forms.Button()
        Me.flpContenido.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        CType(Me.picPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContacto.SuspendLayout()
        Me.flpProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpContenido
        '
        Me.flpContenido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpContenido.AutoScroll = True
        Me.flpContenido.Controls.Add(Me.pnlCabecera)
        Me.flpContenido.Controls.Add(Me.pnlContacto)
        Me.flpContenido.Controls.Add(Me.flpCategorias)
        Me.flpContenido.Controls.Add(Me.flpProductos)
        Me.flpContenido.Controls.Add(Me.btnVerCarrito)
        Me.flpContenido.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpContenido.Location = New System.Drawing.Point(9, 9)
        Me.flpContenido.Name = "flpContenido"
        Me.flpContenido.Size = New System.Drawing.Size(348, 589)
        Me.flpContenido.TabIndex = 0
        Me.flpContenido.WrapContents = False
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.picPortada)
        Me.pnlCabecera.Location = New System.Drawing.Point(9, 3)
        Me.pnlCabecera.Margin = New System.Windows.Forms.Padding(9, 3, 9, 9)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(317, 156)
        Me.pnlCabecera.TabIndex = 0
        '
        'picPortada
        '
        Me.picPortada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picPortada.Image = CType(resources.GetObject("picPortada.Image"), System.Drawing.Image)
        Me.picPortada.Location = New System.Drawing.Point(0, 0)
        Me.picPortada.Name = "picPortada"
        Me.picPortada.Size = New System.Drawing.Size(317, 156)
        Me.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPortada.TabIndex = 0
        Me.picPortada.TabStop = False
        '
        'pnlContacto
        '
        Me.pnlContacto.Controls.Add(Me.btnCompartir)
        Me.pnlContacto.Controls.Add(Me.btnRegistrarse)
        Me.pnlContacto.Controls.Add(Me.btnWhatsApp)
        Me.pnlContacto.Location = New System.Drawing.Point(9, 171)
        Me.pnlContacto.Margin = New System.Windows.Forms.Padding(9, 3, 9, 9)
        Me.pnlContacto.Name = "pnlContacto"
        Me.pnlContacto.Size = New System.Drawing.Size(317, 52)
        Me.pnlContacto.TabIndex = 1
        '
        'btnCompartir
        '
        Me.btnCompartir.Location = New System.Drawing.Point(238, 16)
        Me.btnCompartir.Name = "btnCompartir"
        Me.btnCompartir.Size = New System.Drawing.Size(64, 20)
        Me.btnCompartir.TabIndex = 2
        Me.btnCompartir.Text = "Compartir"
        Me.btnCompartir.UseVisualStyleBackColor = True
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.Location = New System.Drawing.Point(133, 16)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(70, 20)
        Me.btnRegistrarse.TabIndex = 1
        Me.btnRegistrarse.Text = "Registrarse"
        Me.btnRegistrarse.UseVisualStyleBackColor = True
        '
        'btnWhatsApp
        '
        Me.btnWhatsApp.Location = New System.Drawing.Point(27, 16)
        Me.btnWhatsApp.Name = "btnWhatsApp"
        Me.btnWhatsApp.Size = New System.Drawing.Size(64, 20)
        Me.btnWhatsApp.TabIndex = 0
        Me.btnWhatsApp.Text = "WhatsApp"
        Me.btnWhatsApp.UseVisualStyleBackColor = True
        '
        'flpCategorias
        '
        Me.flpCategorias.Location = New System.Drawing.Point(9, 235)
        Me.flpCategorias.Margin = New System.Windows.Forms.Padding(9, 3, 9, 9)
        Me.flpCategorias.Name = "flpCategorias"
        Me.flpCategorias.Size = New System.Drawing.Size(317, 87)
        Me.flpCategorias.TabIndex = 2
        '
        'flpProductos
        '
        Me.flpProductos.Controls.Add(Me.pnlProducto1)
        Me.flpProductos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpProductos.Location = New System.Drawing.Point(9, 334)
        Me.flpProductos.Margin = New System.Windows.Forms.Padding(9, 3, 9, 9)
        Me.flpProductos.Name = "flpProductos"
        Me.flpProductos.Size = New System.Drawing.Size(317, 219)
        Me.flpProductos.TabIndex = 3
        Me.flpProductos.WrapContents = False
        '
        'pnlProducto1
        '
        Me.pnlProducto1.Location = New System.Drawing.Point(3, 3)
        Me.pnlProducto1.MaximumSize = New System.Drawing.Size(280, 120)
        Me.pnlProducto1.Name = "pnlProducto1"
        Me.pnlProducto1.Size = New System.Drawing.Size(280, 0)
        Me.pnlProducto1.TabIndex = 0
        '
        'btnVerCarrito
        '
        Me.btnVerCarrito.Location = New System.Drawing.Point(3, 565)
        Me.btnVerCarrito.Name = "btnVerCarrito"
        Me.btnVerCarrito.Size = New System.Drawing.Size(308, 54)
        Me.btnVerCarrito.TabIndex = 5
        Me.btnVerCarrito.Text = "Ver carrito"
        Me.btnVerCarrito.UseVisualStyleBackColor = True
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 616)
        Me.Controls.Add(Me.flpContenido)
        Me.MaximizeBox = False
        Me.Name = "FormCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brooklyn Helados"
        Me.flpContenido.ResumeLayout(False)
        Me.pnlCabecera.ResumeLayout(False)
        CType(Me.picPortada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContacto.ResumeLayout(False)
        Me.flpProductos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpContenido As FlowLayoutPanel
    Friend WithEvents pnlCabecera As Panel
    Friend WithEvents picPortada As PictureBox
    Friend WithEvents pnlContacto As Panel
    Friend WithEvents btnCompartir As Button
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents btnWhatsApp As Button
    Friend WithEvents flpCategorias As FlowLayoutPanel
    Friend WithEvents flpProductos As FlowLayoutPanel
    Friend WithEvents btnVerCarrito As Button
    Friend WithEvents pnlProducto1 As Panel
End Class
