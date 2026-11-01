<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelAdm
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
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnSabores = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnCategorias = New System.Windows.Forms.Button()
        Me.btnOpcionales = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.pnlConfiguracion = New System.Windows.Forms.Panel()
        Me.pnlMetodosPago = New System.Windows.Forms.Panel()
        Me.btnEliminarMetodoPago = New System.Windows.Forms.Button()
        Me.btnEditarMetodoPago = New System.Windows.Forms.Button()
        Me.btnCambiarEstadoPago = New System.Windows.Forms.Button()
        Me.lstMetodosPago = New System.Windows.Forms.ListBox()
        Me.btnAgregarMetodoPago = New System.Windows.Forms.Button()
        Me.lblTituloMetodosPago = New System.Windows.Forms.Label()
        Me.pnlMetodosEntrega = New System.Windows.Forms.Panel()
        Me.lblTituloMetodosEntrega = New System.Windows.Forms.Label()
        Me.btnEliminarMetodoEntrega = New System.Windows.Forms.Button()
        Me.btnEditarMetodoEntrega = New System.Windows.Forms.Button()
        Me.btnCambiarEstadoEntrega = New System.Windows.Forms.Button()
        Me.lstMetodosEntrega = New System.Windows.Forms.ListBox()
        Me.btnAgregarMetodoEntrega = New System.Windows.Forms.Button()
        Me.pnlConfiguracionPedidos = New System.Windows.Forms.Panel()
        Me.chkImprimirPedidos = New System.Windows.Forms.CheckBox()
        Me.nudRepeticionNotificacion = New System.Windows.Forms.NumericUpDown()
        Me.lblRepeticionNotificacion = New System.Windows.Forms.Label()
        Me.cmbTonoNotificacion = New System.Windows.Forms.ComboBox()
        Me.lblTonoNotificacion = New System.Windows.Forms.Label()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.nudCierrePedidos = New System.Windows.Forms.NumericUpDown()
        Me.lblCierrePedidos = New System.Windows.Forms.Label()
        Me.chkNotificacionSonora = New System.Windows.Forms.CheckBox()
        Me.lblMinutosPreparacion = New System.Windows.Forms.Label()
        Me.nudPreparacionEstimada = New System.Windows.Forms.NumericUpDown()
        Me.lblPreparacionEstimada = New System.Windows.Forms.Label()
        Me.btnGuardarConfiguracionPedidos = New System.Windows.Forms.Button()
        Me.rdbPanelWhatsapp = New System.Windows.Forms.RadioButton()
        Me.rdbSoloPanel = New System.Windows.Forms.RadioButton()
        Me.rdbSoloWhatsapp = New System.Windows.Forms.RadioButton()
        Me.lblTituloConfiguracionPedidos = New System.Windows.Forms.Label()
        Me.pnlClientes = New System.Windows.Forms.Panel()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.lblTituloClientes = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.txtDniCliente = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.lstClientes = New System.Windows.Forms.ListBox()
        Me.txtApellidoCliente = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.pnlPromociones = New System.Windows.Forms.Panel()
        Me.lstPromociones = New System.Windows.Forms.ListBox()
        Me.btnAgregarPromocion = New System.Windows.Forms.Button()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.txtDescripcionPromocion = New System.Windows.Forms.TextBox()
        Me.lblDescripcionPromocion = New System.Windows.Forms.Label()
        Me.txtNombrePromocion = New System.Windows.Forms.TextBox()
        Me.lblNombrePromocion = New System.Windows.Forms.Label()
        Me.lblTituloPromociones = New System.Windows.Forms.Label()
        Me.pnlSabores = New System.Windows.Forms.Panel()
        Me.lstSabores = New System.Windows.Forms.ListBox()
        Me.btnAgregarSabor = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDescripcionSabor = New System.Windows.Forms.Label()
        Me.txtNombreSabor = New System.Windows.Forms.TextBox()
        Me.lblNombreSabor = New System.Windows.Forms.Label()
        Me.pnlProductos = New System.Windows.Forms.Panel()
        Me.btnGuardarPrecioOpcional = New System.Windows.Forms.Button()
        Me.txtPrecioOpcionalProducto = New System.Windows.Forms.TextBox()
        Me.lblPrecioOpcionalProducto = New System.Windows.Forms.Label()
        Me.btnGuardarOpcionales = New System.Windows.Forms.Button()
        Me.nudMaxOpcionales = New System.Windows.Forms.NumericUpDown()
        Me.lblMaxOpcionales = New System.Windows.Forms.Label()
        Me.clbOpcionalesProducto = New System.Windows.Forms.CheckedListBox()
        Me.lblOpcionalesProducto = New System.Windows.Forms.Label()
        Me.chkPermiteNotas = New System.Windows.Forms.CheckBox()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnEditarProducto = New System.Windows.Forms.Button()
        Me.nudMaxSabores = New System.Windows.Forms.NumericUpDown()
        Me.lblMaxSabores = New System.Windows.Forms.Label()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.lblSaboresDisponibles = New System.Windows.Forms.Label()
        Me.clbSabores = New System.Windows.Forms.CheckedListBox()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lstProductos = New System.Windows.Forms.ListBox()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cmbCategorias = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.pnlCategorias = New System.Windows.Forms.Panel()
        Me.lblNombreCategoria = New System.Windows.Forms.Label()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.btnAgregarCategoria = New System.Windows.Forms.Button()
        Me.lstCategorias = New System.Windows.Forms.ListBox()
        Me.pnlOpcionales = New System.Windows.Forms.Panel()
        Me.btnAgregarOpcional = New System.Windows.Forms.Button()
        Me.lstOpcionales = New System.Windows.Forms.ListBox()
        Me.cmbGrupoOpcional = New System.Windows.Forms.ComboBox()
        Me.lblGrupoOpcional = New System.Windows.Forms.Label()
        Me.txtPrecioOpcional = New System.Windows.Forms.TextBox()
        Me.lblPrecioOpcional = New System.Windows.Forms.Label()
        Me.txtNombreOpcional = New System.Windows.Forms.TextBox()
        Me.lblNombreOpcional = New System.Windows.Forms.Label()
        Me.lblTituloOpcionales = New System.Windows.Forms.Label()
        Me.lblSeccion = New System.Windows.Forms.Label()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.btnVerCliente = New System.Windows.Forms.Button()
        Me.pnlMenu.SuspendLayout()
        Me.pnlContenido.SuspendLayout()
        Me.pnlConfiguracion.SuspendLayout()
        Me.pnlMetodosPago.SuspendLayout()
        Me.pnlMetodosEntrega.SuspendLayout()
        Me.pnlConfiguracionPedidos.SuspendLayout()
        CType(Me.nudRepeticionNotificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCierrePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreparacionEstimada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlClientes.SuspendLayout()
        Me.pnlPromociones.SuspendLayout()
        Me.pnlSabores.SuspendLayout()
        Me.pnlProductos.SuspendLayout()
        CType(Me.nudMaxOpcionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxSabores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCategorias.SuspendLayout()
        Me.pnlOpcionales.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnVerCliente)
        Me.pnlMenu.Controls.Add(Me.btnPedidos)
        Me.pnlMenu.Controls.Add(Me.btnConfiguracion)
        Me.pnlMenu.Controls.Add(Me.btnClientes)
        Me.pnlMenu.Controls.Add(Me.btnSabores)
        Me.pnlMenu.Controls.Add(Me.btnProductos)
        Me.pnlMenu.Controls.Add(Me.btnCategorias)
        Me.pnlMenu.Controls.Add(Me.btnOpcionales)
        Me.pnlMenu.Controls.Add(Me.lblTitulo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(132, 377)
        Me.pnlMenu.TabIndex = 0
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Location = New System.Drawing.Point(14, 196)
        Me.btnConfiguracion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(112, 26)
        Me.btnConfiguracion.TabIndex = 6
        Me.btnConfiguracion.Text = "CONFIGURACIÓN"
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(14, 152)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(105, 31)
        Me.btnClientes.TabIndex = 5
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnSabores
        '
        Me.btnSabores.Location = New System.Drawing.Point(14, 122)
        Me.btnSabores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSabores.Name = "btnSabores"
        Me.btnSabores.Size = New System.Drawing.Size(103, 19)
        Me.btnSabores.TabIndex = 3
        Me.btnSabores.Text = "SABORES"
        Me.btnSabores.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(14, 88)
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(103, 19)
        Me.btnProductos.TabIndex = 2
        Me.btnProductos.Text = "PRODUCTOS"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnCategorias
        '
        Me.btnCategorias.Location = New System.Drawing.Point(14, 50)
        Me.btnCategorias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCategorias.Name = "btnCategorias"
        Me.btnCategorias.Size = New System.Drawing.Size(102, 19)
        Me.btnCategorias.TabIndex = 1
        Me.btnCategorias.Text = "CATEGORIAS"
        Me.btnCategorias.UseVisualStyleBackColor = True
        '
        'btnOpcionales
        '
        Me.btnOpcionales.Location = New System.Drawing.Point(14, 235)
        Me.btnOpcionales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOpcionales.Name = "btnOpcionales"
        Me.btnOpcionales.Size = New System.Drawing.Size(112, 31)
        Me.btnOpcionales.TabIndex = 7
        Me.btnOpcionales.Text = "OPCIONALES"
        Me.btnOpcionales.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(26, 14)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(66, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "BROOKLYN"
        '
        'pnlContenido
        '
        Me.pnlContenido.Controls.Add(Me.pnlSabores)
        Me.pnlContenido.Controls.Add(Me.pnlConfiguracion)
        Me.pnlContenido.Controls.Add(Me.pnlClientes)
        Me.pnlContenido.Controls.Add(Me.pnlPromociones)
        Me.pnlContenido.Controls.Add(Me.pnlProductos)
        Me.pnlContenido.Controls.Add(Me.pnlCategorias)
        Me.pnlContenido.Controls.Add(Me.pnlOpcionales)
        Me.pnlContenido.Controls.Add(Me.lblSeccion)
        Me.pnlContenido.Controls.Add(Me.pnlMenu)
        Me.pnlContenido.Location = New System.Drawing.Point(9, 10)
        Me.pnlContenido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1352, 377)
        Me.pnlContenido.TabIndex = 0
        '
        'pnlConfiguracion
        '
        Me.pnlConfiguracion.Controls.Add(Me.pnlMetodosPago)
        Me.pnlConfiguracion.Controls.Add(Me.pnlMetodosEntrega)
        Me.pnlConfiguracion.Controls.Add(Me.pnlConfiguracionPedidos)
        Me.pnlConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConfiguracion.Location = New System.Drawing.Point(132, 0)
        Me.pnlConfiguracion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlConfiguracion.Name = "pnlConfiguracion"
        Me.pnlConfiguracion.Size = New System.Drawing.Size(1220, 377)
        Me.pnlConfiguracion.TabIndex = 18
        Me.pnlConfiguracion.Visible = False
        '
        'pnlMetodosPago
        '
        Me.pnlMetodosPago.AutoScrollMargin = New System.Drawing.Size(0, 250)
        Me.pnlMetodosPago.Controls.Add(Me.btnEliminarMetodoPago)
        Me.pnlMetodosPago.Controls.Add(Me.btnEditarMetodoPago)
        Me.pnlMetodosPago.Controls.Add(Me.btnCambiarEstadoPago)
        Me.pnlMetodosPago.Controls.Add(Me.lstMetodosPago)
        Me.pnlMetodosPago.Controls.Add(Me.btnAgregarMetodoPago)
        Me.pnlMetodosPago.Controls.Add(Me.lblTituloMetodosPago)
        Me.pnlMetodosPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMetodosPago.Location = New System.Drawing.Point(0, 222)
        Me.pnlMetodosPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlMetodosPago.Name = "pnlMetodosPago"
        Me.pnlMetodosPago.Size = New System.Drawing.Size(1220, 162)
        Me.pnlMetodosPago.TabIndex = 0
        '
        'btnEliminarMetodoPago
        '
        Me.btnEliminarMetodoPago.Location = New System.Drawing.Point(112, 80)
        Me.btnEliminarMetodoPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminarMetodoPago.Name = "btnEliminarMetodoPago"
        Me.btnEliminarMetodoPago.Size = New System.Drawing.Size(84, 31)
        Me.btnEliminarMetodoPago.TabIndex = 5
        Me.btnEliminarMetodoPago.Text = "ELIMINAR"
        Me.btnEliminarMetodoPago.UseVisualStyleBackColor = True
        '
        'btnEditarMetodoPago
        '
        Me.btnEditarMetodoPago.Location = New System.Drawing.Point(9, 80)
        Me.btnEditarMetodoPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditarMetodoPago.Name = "btnEditarMetodoPago"
        Me.btnEditarMetodoPago.Size = New System.Drawing.Size(87, 32)
        Me.btnEditarMetodoPago.TabIndex = 4
        Me.btnEditarMetodoPago.Text = "EDITAR"
        Me.btnEditarMetodoPago.UseVisualStyleBackColor = True
        '
        'btnCambiarEstadoPago
        '
        Me.btnCambiarEstadoPago.Location = New System.Drawing.Point(212, 80)
        Me.btnCambiarEstadoPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCambiarEstadoPago.Name = "btnCambiarEstadoPago"
        Me.btnCambiarEstadoPago.Size = New System.Drawing.Size(172, 36)
        Me.btnCambiarEstadoPago.TabIndex = 3
        Me.btnCambiarEstadoPago.Text = "HABILITAR / DESHABILITAR"
        Me.btnCambiarEstadoPago.UseVisualStyleBackColor = True
        '
        'lstMetodosPago
        '
        Me.lstMetodosPago.FormattingEnabled = True
        Me.lstMetodosPago.Location = New System.Drawing.Point(255, 15)
        Me.lstMetodosPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstMetodosPago.Name = "lstMetodosPago"
        Me.lstMetodosPago.Size = New System.Drawing.Size(251, 56)
        Me.lstMetodosPago.TabIndex = 2
        '
        'btnAgregarMetodoPago
        '
        Me.btnAgregarMetodoPago.Location = New System.Drawing.Point(104, 6)
        Me.btnAgregarMetodoPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarMetodoPago.Name = "btnAgregarMetodoPago"
        Me.btnAgregarMetodoPago.Size = New System.Drawing.Size(66, 26)
        Me.btnAgregarMetodoPago.TabIndex = 1
        Me.btnAgregarMetodoPago.Text = "+ AÑADIR"
        Me.btnAgregarMetodoPago.UseVisualStyleBackColor = True
        '
        'lblTituloMetodosPago
        '
        Me.lblTituloMetodosPago.AutoSize = True
        Me.lblTituloMetodosPago.Location = New System.Drawing.Point(10, 11)
        Me.lblTituloMetodosPago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloMetodosPago.Name = "lblTituloMetodosPago"
        Me.lblTituloMetodosPago.Size = New System.Drawing.Size(91, 13)
        Me.lblTituloMetodosPago.TabIndex = 0
        Me.lblTituloMetodosPago.Text = "Métodos de Pago"
        '
        'pnlMetodosEntrega
        '
        Me.pnlMetodosEntrega.Controls.Add(Me.lblTituloMetodosEntrega)
        Me.pnlMetodosEntrega.Controls.Add(Me.btnEliminarMetodoEntrega)
        Me.pnlMetodosEntrega.Controls.Add(Me.btnEditarMetodoEntrega)
        Me.pnlMetodosEntrega.Controls.Add(Me.btnCambiarEstadoEntrega)
        Me.pnlMetodosEntrega.Controls.Add(Me.lstMetodosEntrega)
        Me.pnlMetodosEntrega.Controls.Add(Me.btnAgregarMetodoEntrega)
        Me.pnlMetodosEntrega.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMetodosEntrega.Location = New System.Drawing.Point(0, 106)
        Me.pnlMetodosEntrega.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlMetodosEntrega.Name = "pnlMetodosEntrega"
        Me.pnlMetodosEntrega.Size = New System.Drawing.Size(1220, 116)
        Me.pnlMetodosEntrega.TabIndex = 1
        '
        'lblTituloMetodosEntrega
        '
        Me.lblTituloMetodosEntrega.AutoSize = True
        Me.lblTituloMetodosEntrega.Location = New System.Drawing.Point(7, 9)
        Me.lblTituloMetodosEntrega.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloMetodosEntrega.Name = "lblTituloMetodosEntrega"
        Me.lblTituloMetodosEntrega.Size = New System.Drawing.Size(103, 13)
        Me.lblTituloMetodosEntrega.TabIndex = 0
        Me.lblTituloMetodosEntrega.Text = "Métodos de Entrega"
        '
        'btnEliminarMetodoEntrega
        '
        Me.btnEliminarMetodoEntrega.Location = New System.Drawing.Point(104, 69)
        Me.btnEliminarMetodoEntrega.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminarMetodoEntrega.Name = "btnEliminarMetodoEntrega"
        Me.btnEliminarMetodoEntrega.Size = New System.Drawing.Size(82, 38)
        Me.btnEliminarMetodoEntrega.TabIndex = 5
        Me.btnEliminarMetodoEntrega.Text = "ELIMINAR"
        Me.btnEliminarMetodoEntrega.UseVisualStyleBackColor = True
        '
        'btnEditarMetodoEntrega
        '
        Me.btnEditarMetodoEntrega.Location = New System.Drawing.Point(7, 72)
        Me.btnEditarMetodoEntrega.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditarMetodoEntrega.Name = "btnEditarMetodoEntrega"
        Me.btnEditarMetodoEntrega.Size = New System.Drawing.Size(84, 38)
        Me.btnEditarMetodoEntrega.TabIndex = 4
        Me.btnEditarMetodoEntrega.Text = "EDITAR"
        Me.btnEditarMetodoEntrega.UseVisualStyleBackColor = True
        '
        'btnCambiarEstadoEntrega
        '
        Me.btnCambiarEstadoEntrega.Location = New System.Drawing.Point(195, 71)
        Me.btnCambiarEstadoEntrega.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCambiarEstadoEntrega.Name = "btnCambiarEstadoEntrega"
        Me.btnCambiarEstadoEntrega.Size = New System.Drawing.Size(190, 34)
        Me.btnCambiarEstadoEntrega.TabIndex = 3
        Me.btnCambiarEstadoEntrega.Text = "HABILITAR / DESHABILITAR"
        Me.btnCambiarEstadoEntrega.UseVisualStyleBackColor = True
        '
        'lstMetodosEntrega
        '
        Me.lstMetodosEntrega.FormattingEnabled = True
        Me.lstMetodosEntrega.Location = New System.Drawing.Point(255, 2)
        Me.lstMetodosEntrega.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstMetodosEntrega.Name = "lstMetodosEntrega"
        Me.lstMetodosEntrega.Size = New System.Drawing.Size(251, 56)
        Me.lstMetodosEntrega.TabIndex = 2
        '
        'btnAgregarMetodoEntrega
        '
        Me.btnAgregarMetodoEntrega.Location = New System.Drawing.Point(112, 5)
        Me.btnAgregarMetodoEntrega.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarMetodoEntrega.Name = "btnAgregarMetodoEntrega"
        Me.btnAgregarMetodoEntrega.Size = New System.Drawing.Size(121, 29)
        Me.btnAgregarMetodoEntrega.TabIndex = 1
        Me.btnAgregarMetodoEntrega.Text = "+ AÑADIR"
        Me.btnAgregarMetodoEntrega.UseVisualStyleBackColor = True
        '
        'pnlConfiguracionPedidos
        '
        Me.pnlConfiguracionPedidos.Controls.Add(Me.chkImprimirPedidos)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.nudRepeticionNotificacion)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.lblRepeticionNotificacion)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.cmbTonoNotificacion)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.lblTonoNotificacion)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.lblMinutos)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.nudCierrePedidos)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.lblCierrePedidos)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.chkNotificacionSonora)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.lblMinutosPreparacion)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.nudPreparacionEstimada)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.lblPreparacionEstimada)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.btnGuardarConfiguracionPedidos)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.rdbPanelWhatsapp)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.rdbSoloPanel)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.rdbSoloWhatsapp)
        Me.pnlConfiguracionPedidos.Controls.Add(Me.lblTituloConfiguracionPedidos)
        Me.pnlConfiguracionPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfiguracionPedidos.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfiguracionPedidos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlConfiguracionPedidos.Name = "pnlConfiguracionPedidos"
        Me.pnlConfiguracionPedidos.Size = New System.Drawing.Size(1220, 106)
        Me.pnlConfiguracionPedidos.TabIndex = 6
        '
        'chkImprimirPedidos
        '
        Me.chkImprimirPedidos.AutoSize = True
        Me.chkImprimirPedidos.Location = New System.Drawing.Point(500, 79)
        Me.chkImprimirPedidos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkImprimirPedidos.Name = "chkImprimirPedidos"
        Me.chkImprimirPedidos.Size = New System.Drawing.Size(156, 17)
        Me.chkImprimirPedidos.TabIndex = 16
        Me.chkImprimirPedidos.Text = "Imprimir pedidos al recibirlos"
        Me.chkImprimirPedidos.UseVisualStyleBackColor = True
        '
        'nudRepeticionNotificacion
        '
        Me.nudRepeticionNotificacion.Location = New System.Drawing.Point(521, 54)
        Me.nudRepeticionNotificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nudRepeticionNotificacion.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudRepeticionNotificacion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRepeticionNotificacion.Name = "nudRepeticionNotificacion"
        Me.nudRepeticionNotificacion.Size = New System.Drawing.Size(58, 20)
        Me.nudRepeticionNotificacion.TabIndex = 15
        Me.nudRepeticionNotificacion.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblRepeticionNotificacion
        '
        Me.lblRepeticionNotificacion.AutoSize = True
        Me.lblRepeticionNotificacion.Location = New System.Drawing.Point(458, 54)
        Me.lblRepeticionNotificacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRepeticionNotificacion.Name = "lblRepeticionNotificacion"
        Me.lblRepeticionNotificacion.Size = New System.Drawing.Size(61, 13)
        Me.lblRepeticionNotificacion.TabIndex = 14
        Me.lblRepeticionNotificacion.Text = "Repetición:"
        '
        'cmbTonoNotificacion
        '
        Me.cmbTonoNotificacion.FormattingEnabled = True
        Me.cmbTonoNotificacion.Items.AddRange(New Object() {"Ding"})
        Me.cmbTonoNotificacion.Location = New System.Drawing.Point(460, 27)
        Me.cmbTonoNotificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbTonoNotificacion.Name = "cmbTonoNotificacion"
        Me.cmbTonoNotificacion.Size = New System.Drawing.Size(89, 21)
        Me.cmbTonoNotificacion.TabIndex = 13
        '
        'lblTonoNotificacion
        '
        Me.lblTonoNotificacion.AutoSize = True
        Me.lblTonoNotificacion.Location = New System.Drawing.Point(452, 11)
        Me.lblTonoNotificacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTonoNotificacion.Name = "lblTonoNotificacion"
        Me.lblTonoNotificacion.Size = New System.Drawing.Size(109, 13)
        Me.lblTonoNotificacion.TabIndex = 12
        Me.lblTonoNotificacion.Text = "Tono de Notificación:"
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Location = New System.Drawing.Point(449, 79)
        Me.lblMinutos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(43, 13)
        Me.lblMinutos.TabIndex = 11
        Me.lblMinutos.Text = "minutos"
        '
        'nudCierrePedidos
        '
        Me.nudCierrePedidos.Location = New System.Drawing.Point(387, 79)
        Me.nudCierrePedidos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nudCierrePedidos.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.nudCierrePedidos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCierrePedidos.Name = "nudCierrePedidos"
        Me.nudCierrePedidos.Size = New System.Drawing.Size(58, 20)
        Me.nudCierrePedidos.TabIndex = 10
        Me.nudCierrePedidos.Value = New Decimal(New Integer() {240, 0, 0, 0})
        '
        'lblCierrePedidos
        '
        Me.lblCierrePedidos.AutoSize = True
        Me.lblCierrePedidos.Location = New System.Drawing.Point(292, 79)
        Me.lblCierrePedidos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCierrePedidos.Name = "lblCierrePedidos"
        Me.lblCierrePedidos.Size = New System.Drawing.Size(92, 13)
        Me.lblCierrePedidos.TabIndex = 9
        Me.lblCierrePedidos.Text = "Cierre de pedidos:"
        '
        'chkNotificacionSonora
        '
        Me.chkNotificacionSonora.AutoSize = True
        Me.chkNotificacionSonora.Checked = True
        Me.chkNotificacionSonora.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNotificacionSonora.Location = New System.Drawing.Point(296, 51)
        Me.chkNotificacionSonora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkNotificacionSonora.Name = "chkNotificacionSonora"
        Me.chkNotificacionSonora.Size = New System.Drawing.Size(156, 17)
        Me.chkNotificacionSonora.TabIndex = 8
        Me.chkNotificacionSonora.Text = "Habilitar notificación sonora"
        Me.chkNotificacionSonora.UseVisualStyleBackColor = True
        '
        'lblMinutosPreparacion
        '
        Me.lblMinutosPreparacion.AutoSize = True
        Me.lblMinutosPreparacion.Location = New System.Drawing.Point(347, 27)
        Me.lblMinutosPreparacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMinutosPreparacion.Name = "lblMinutosPreparacion"
        Me.lblMinutosPreparacion.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutosPreparacion.TabIndex = 7
        Me.lblMinutosPreparacion.Text = "Minutos"
        '
        'nudPreparacionEstimada
        '
        Me.nudPreparacionEstimada.Location = New System.Drawing.Point(296, 25)
        Me.nudPreparacionEstimada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nudPreparacionEstimada.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.nudPreparacionEstimada.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPreparacionEstimada.Name = "nudPreparacionEstimada"
        Me.nudPreparacionEstimada.Size = New System.Drawing.Size(47, 20)
        Me.nudPreparacionEstimada.TabIndex = 6
        Me.nudPreparacionEstimada.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'lblPreparacionEstimada
        '
        Me.lblPreparacionEstimada.AutoSize = True
        Me.lblPreparacionEstimada.Location = New System.Drawing.Point(293, 9)
        Me.lblPreparacionEstimada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPreparacionEstimada.Name = "lblPreparacionEstimada"
        Me.lblPreparacionEstimada.Size = New System.Drawing.Size(112, 13)
        Me.lblPreparacionEstimada.TabIndex = 5
        Me.lblPreparacionEstimada.Text = "Preparación estimada:"
        '
        'btnGuardarConfiguracionPedidos
        '
        Me.btnGuardarConfiguracionPedidos.Location = New System.Drawing.Point(154, 41)
        Me.btnGuardarConfiguracionPedidos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGuardarConfiguracionPedidos.Name = "btnGuardarConfiguracionPedidos"
        Me.btnGuardarConfiguracionPedidos.Size = New System.Drawing.Size(129, 36)
        Me.btnGuardarConfiguracionPedidos.TabIndex = 4
        Me.btnGuardarConfiguracionPedidos.Text = "GUARDAR CONFIGURACIÓN"
        Me.btnGuardarConfiguracionPedidos.UseVisualStyleBackColor = True
        '
        'rdbPanelWhatsapp
        '
        Me.rdbPanelWhatsapp.AutoSize = True
        Me.rdbPanelWhatsapp.Location = New System.Drawing.Point(18, 83)
        Me.rdbPanelWhatsapp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbPanelWhatsapp.Name = "rdbPanelWhatsapp"
        Me.rdbPanelWhatsapp.Size = New System.Drawing.Size(112, 17)
        Me.rdbPanelWhatsapp.TabIndex = 3
        Me.rdbPanelWhatsapp.Text = "Panel y Whatsapp"
        Me.rdbPanelWhatsapp.UseVisualStyleBackColor = True
        '
        'rdbSoloPanel
        '
        Me.rdbSoloPanel.AutoSize = True
        Me.rdbSoloPanel.Checked = True
        Me.rdbSoloPanel.Location = New System.Drawing.Point(18, 58)
        Me.rdbSoloPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbSoloPanel.Name = "rdbSoloPanel"
        Me.rdbSoloPanel.Size = New System.Drawing.Size(90, 17)
        Me.rdbSoloPanel.TabIndex = 2
        Me.rdbSoloPanel.TabStop = True
        Me.rdbSoloPanel.Text = "Solo en panel"
        Me.rdbSoloPanel.UseVisualStyleBackColor = True
        '
        'rdbSoloWhatsapp
        '
        Me.rdbSoloWhatsapp.AutoSize = True
        Me.rdbSoloWhatsapp.Location = New System.Drawing.Point(18, 37)
        Me.rdbSoloWhatsapp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbSoloWhatsapp.Name = "rdbSoloWhatsapp"
        Me.rdbSoloWhatsapp.Size = New System.Drawing.Size(113, 17)
        Me.rdbSoloWhatsapp.TabIndex = 1
        Me.rdbSoloWhatsapp.Text = "Solo en Whatsapp"
        Me.rdbSoloWhatsapp.UseVisualStyleBackColor = True
        '
        'lblTituloConfiguracionPedidos
        '
        Me.lblTituloConfiguracionPedidos.AutoSize = True
        Me.lblTituloConfiguracionPedidos.Location = New System.Drawing.Point(16, 10)
        Me.lblTituloConfiguracionPedidos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloConfiguracionPedidos.Name = "lblTituloConfiguracionPedidos"
        Me.lblTituloConfiguracionPedidos.Size = New System.Drawing.Size(138, 13)
        Me.lblTituloConfiguracionPedidos.TabIndex = 0
        Me.lblTituloConfiguracionPedidos.Text = "¿Dónde recibir los pedidos?"
        '
        'pnlClientes
        '
        Me.pnlClientes.Controls.Add(Me.btnEliminarCliente)
        Me.pnlClientes.Controls.Add(Me.btnEditarCliente)
        Me.pnlClientes.Controls.Add(Me.lblTituloClientes)
        Me.pnlClientes.Controls.Add(Me.lblNombre)
        Me.pnlClientes.Controls.Add(Me.txtEmailCliente)
        Me.pnlClientes.Controls.Add(Me.txtNombreCliente)
        Me.pnlClientes.Controls.Add(Me.lblEmail)
        Me.pnlClientes.Controls.Add(Me.txtTelefonoCliente)
        Me.pnlClientes.Controls.Add(Me.txtDniCliente)
        Me.pnlClientes.Controls.Add(Me.lblApellido)
        Me.pnlClientes.Controls.Add(Me.lblTelefono)
        Me.pnlClientes.Controls.Add(Me.btnAgregarCliente)
        Me.pnlClientes.Controls.Add(Me.lstClientes)
        Me.pnlClientes.Controls.Add(Me.txtApellidoCliente)
        Me.pnlClientes.Controls.Add(Me.lblDNI)
        Me.pnlClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlClientes.Location = New System.Drawing.Point(132, 0)
        Me.pnlClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlClientes.Name = "pnlClientes"
        Me.pnlClientes.Size = New System.Drawing.Size(1220, 377)
        Me.pnlClientes.TabIndex = 6
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(237, 175)
        Me.btnEliminarCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(80, 43)
        Me.btnEliminarCliente.TabIndex = 18
        Me.btnEliminarCliente.Text = "ELIMINAR"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Location = New System.Drawing.Point(120, 172)
        Me.btnEditarCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(89, 46)
        Me.btnEditarCliente.TabIndex = 17
        Me.btnEditarCliente.Text = "EDITAR"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        '
        'lblTituloClientes
        '
        Me.lblTituloClientes.AutoSize = True
        Me.lblTituloClientes.Location = New System.Drawing.Point(33, 11)
        Me.lblTituloClientes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloClientes.Name = "lblTituloClientes"
        Me.lblTituloClientes.Size = New System.Drawing.Size(98, 13)
        Me.lblTituloClientes.TabIndex = 0
        Me.lblTituloClientes.Text = "Gestión de Clientes"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(16, 41)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre:"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(82, 145)
        Me.txtEmailCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(128, 20)
        Me.txtEmailCliente.TabIndex = 15
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(80, 37)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(131, 20)
        Me.txtNombreCliente.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(24, 149)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(78, 119)
        Me.txtTelefonoCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(132, 20)
        Me.txtTelefonoCliente.TabIndex = 14
        '
        'txtDniCliente
        '
        Me.txtDniCliente.Location = New System.Drawing.Point(80, 92)
        Me.txtDniCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDniCliente.Name = "txtDniCliente"
        Me.txtDniCliente.Size = New System.Drawing.Size(131, 20)
        Me.txtDniCliente.TabIndex = 13
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(16, 68)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 7
        Me.lblApellido.Text = "Apellido:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(16, 122)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Teléfono:"
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(18, 175)
        Me.btnAgregarCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(91, 43)
        Me.btnAgregarCliente.TabIndex = 16
        Me.btnAgregarCliente.Text = "AGREGAR CLIENTE"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'lstClientes
        '
        Me.lstClientes.FormattingEnabled = True
        Me.lstClientes.Location = New System.Drawing.Point(16, 226)
        Me.lstClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstClientes.Name = "lstClientes"
        Me.lstClientes.Size = New System.Drawing.Size(194, 108)
        Me.lstClientes.TabIndex = 1
        '
        'txtApellidoCliente
        '
        Me.txtApellidoCliente.Location = New System.Drawing.Point(80, 64)
        Me.txtApellidoCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApellidoCliente.Name = "txtApellidoCliente"
        Me.txtApellidoCliente.Size = New System.Drawing.Size(128, 20)
        Me.txtApellidoCliente.TabIndex = 12
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(24, 92)
        Me.lblDNI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(29, 13)
        Me.lblDNI.TabIndex = 8
        Me.lblDNI.Text = "DNI:"
        '
        'pnlPromociones
        '
        Me.pnlPromociones.Controls.Add(Me.lstPromociones)
        Me.pnlPromociones.Controls.Add(Me.btnAgregarPromocion)
        Me.pnlPromociones.Controls.Add(Me.txtDescuento)
        Me.pnlPromociones.Controls.Add(Me.lblDescuento)
        Me.pnlPromociones.Controls.Add(Me.txtDescripcionPromocion)
        Me.pnlPromociones.Controls.Add(Me.lblDescripcionPromocion)
        Me.pnlPromociones.Controls.Add(Me.txtNombrePromocion)
        Me.pnlPromociones.Controls.Add(Me.lblNombrePromocion)
        Me.pnlPromociones.Controls.Add(Me.lblTituloPromociones)
        Me.pnlPromociones.Location = New System.Drawing.Point(850, 59)
        Me.pnlPromociones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlPromociones.Name = "pnlPromociones"
        Me.pnlPromociones.Size = New System.Drawing.Size(241, 269)
        Me.pnlPromociones.TabIndex = 17
        '
        'lstPromociones
        '
        Me.lstPromociones.FormattingEnabled = True
        Me.lstPromociones.Location = New System.Drawing.Point(13, 176)
        Me.lstPromociones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstPromociones.Name = "lstPromociones"
        Me.lstPromociones.Size = New System.Drawing.Size(217, 82)
        Me.lstPromociones.TabIndex = 8
        '
        'btnAgregarPromocion
        '
        Me.btnAgregarPromocion.Location = New System.Drawing.Point(71, 128)
        Me.btnAgregarPromocion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarPromocion.Name = "btnAgregarPromocion"
        Me.btnAgregarPromocion.Size = New System.Drawing.Size(92, 42)
        Me.btnAgregarPromocion.TabIndex = 7
        Me.btnAgregarPromocion.Text = "AGREGAR PROMOCIÓN"
        Me.btnAgregarPromocion.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(129, 93)
        Me.txtDescuento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(101, 20)
        Me.txtDescuento.TabIndex = 6
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(10, 93)
        Me.lblDescuento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(79, 13)
        Me.lblDescuento.TabIndex = 5
        Me.lblDescuento.Text = "Descuento (%):"
        '
        'txtDescripcionPromocion
        '
        Me.txtDescripcionPromocion.Location = New System.Drawing.Point(129, 63)
        Me.txtDescripcionPromocion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcionPromocion.Name = "txtDescripcionPromocion"
        Me.txtDescripcionPromocion.Size = New System.Drawing.Size(101, 20)
        Me.txtDescripcionPromocion.TabIndex = 4
        '
        'lblDescripcionPromocion
        '
        Me.lblDescripcionPromocion.AutoSize = True
        Me.lblDescripcionPromocion.Location = New System.Drawing.Point(17, 62)
        Me.lblDescripcionPromocion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcionPromocion.Name = "lblDescripcionPromocion"
        Me.lblDescripcionPromocion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcionPromocion.TabIndex = 3
        Me.lblDescripcionPromocion.Text = "Descripción:"
        '
        'txtNombrePromocion
        '
        Me.txtNombrePromocion.Location = New System.Drawing.Point(129, 34)
        Me.txtNombrePromocion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombrePromocion.Name = "txtNombrePromocion"
        Me.txtNombrePromocion.Size = New System.Drawing.Size(101, 20)
        Me.txtNombrePromocion.TabIndex = 2
        '
        'lblNombrePromocion
        '
        Me.lblNombrePromocion.AutoSize = True
        Me.lblNombrePromocion.Location = New System.Drawing.Point(10, 34)
        Me.lblNombrePromocion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombrePromocion.Name = "lblNombrePromocion"
        Me.lblNombrePromocion.Size = New System.Drawing.Size(114, 13)
        Me.lblNombrePromocion.TabIndex = 1
        Me.lblNombrePromocion.Text = "Nombre de promoción:"
        '
        'lblTituloPromociones
        '
        Me.lblTituloPromociones.AutoSize = True
        Me.lblTituloPromociones.Location = New System.Drawing.Point(10, 11)
        Me.lblTituloPromociones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloPromociones.Name = "lblTituloPromociones"
        Me.lblTituloPromociones.Size = New System.Drawing.Size(121, 13)
        Me.lblTituloPromociones.TabIndex = 0
        Me.lblTituloPromociones.Text = "Gestión de promociones"
        '
        'pnlSabores
        '
        Me.pnlSabores.Controls.Add(Me.lstSabores)
        Me.pnlSabores.Controls.Add(Me.btnAgregarSabor)
        Me.pnlSabores.Controls.Add(Me.TextBox1)
        Me.pnlSabores.Controls.Add(Me.lblDescripcionSabor)
        Me.pnlSabores.Controls.Add(Me.txtNombreSabor)
        Me.pnlSabores.Controls.Add(Me.lblNombreSabor)
        Me.pnlSabores.Location = New System.Drawing.Point(382, 102)
        Me.pnlSabores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlSabores.Name = "pnlSabores"
        Me.pnlSabores.Size = New System.Drawing.Size(332, 115)
        Me.pnlSabores.TabIndex = 16
        '
        'lstSabores
        '
        Me.lstSabores.FormattingEnabled = True
        Me.lstSabores.Location = New System.Drawing.Point(211, 5)
        Me.lstSabores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstSabores.Name = "lstSabores"
        Me.lstSabores.Size = New System.Drawing.Size(120, 108)
        Me.lstSabores.TabIndex = 5
        '
        'btnAgregarSabor
        '
        Me.btnAgregarSabor.Location = New System.Drawing.Point(7, 54)
        Me.btnAgregarSabor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarSabor.Name = "btnAgregarSabor"
        Me.btnAgregarSabor.Size = New System.Drawing.Size(88, 46)
        Me.btnAgregarSabor.TabIndex = 4
        Me.btnAgregarSabor.Text = "AGREGAR SABOR"
        Me.btnAgregarSabor.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 30)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 3
        '
        'lblDescripcionSabor
        '
        Me.lblDescripcionSabor.AutoSize = True
        Me.lblDescripcionSabor.Location = New System.Drawing.Point(4, 30)
        Me.lblDescripcionSabor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcionSabor.Name = "lblDescripcionSabor"
        Me.lblDescripcionSabor.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcionSabor.TabIndex = 2
        Me.lblDescripcionSabor.Text = "Descripción:"
        '
        'txtNombreSabor
        '
        Me.txtNombreSabor.Location = New System.Drawing.Point(100, 5)
        Me.txtNombreSabor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreSabor.Name = "txtNombreSabor"
        Me.txtNombreSabor.Size = New System.Drawing.Size(76, 20)
        Me.txtNombreSabor.TabIndex = 1
        '
        'lblNombreSabor
        '
        Me.lblNombreSabor.AutoSize = True
        Me.lblNombreSabor.Location = New System.Drawing.Point(2, 5)
        Me.lblNombreSabor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreSabor.Name = "lblNombreSabor"
        Me.lblNombreSabor.Size = New System.Drawing.Size(93, 13)
        Me.lblNombreSabor.TabIndex = 0
        Me.lblNombreSabor.Text = "Nombre del sabor:"
        '
        'pnlProductos
        '
        Me.pnlProductos.Controls.Add(Me.btnGuardarPrecioOpcional)
        Me.pnlProductos.Controls.Add(Me.txtPrecioOpcionalProducto)
        Me.pnlProductos.Controls.Add(Me.lblPrecioOpcionalProducto)
        Me.pnlProductos.Controls.Add(Me.btnGuardarOpcionales)
        Me.pnlProductos.Controls.Add(Me.nudMaxOpcionales)
        Me.pnlProductos.Controls.Add(Me.lblMaxOpcionales)
        Me.pnlProductos.Controls.Add(Me.clbOpcionalesProducto)
        Me.pnlProductos.Controls.Add(Me.lblOpcionalesProducto)
        Me.pnlProductos.Controls.Add(Me.chkPermiteNotas)
        Me.pnlProductos.Controls.Add(Me.btnEliminarProducto)
        Me.pnlProductos.Controls.Add(Me.btnEditarProducto)
        Me.pnlProductos.Controls.Add(Me.nudMaxSabores)
        Me.pnlProductos.Controls.Add(Me.lblMaxSabores)
        Me.pnlProductos.Controls.Add(Me.lblProductos)
        Me.pnlProductos.Controls.Add(Me.lblSaboresDisponibles)
        Me.pnlProductos.Controls.Add(Me.clbSabores)
        Me.pnlProductos.Controls.Add(Me.lblNombreProducto)
        Me.pnlProductos.Controls.Add(Me.txtNombreProducto)
        Me.pnlProductos.Controls.Add(Me.lstProductos)
        Me.pnlProductos.Controls.Add(Me.btnAgregarProducto)
        Me.pnlProductos.Controls.Add(Me.lblDescripcion)
        Me.pnlProductos.Controls.Add(Me.txtDescripcion)
        Me.pnlProductos.Controls.Add(Me.cmbCategorias)
        Me.pnlProductos.Controls.Add(Me.txtPrecio)
        Me.pnlProductos.Controls.Add(Me.lblPrecio)
        Me.pnlProductos.Location = New System.Drawing.Point(136, 2)
        Me.pnlProductos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlProductos.Name = "pnlProductos"
        Me.pnlProductos.Size = New System.Drawing.Size(688, 366)
        Me.pnlProductos.TabIndex = 15
        '
        'btnGuardarPrecioOpcional
        '
        Me.btnGuardarPrecioOpcional.Location = New System.Drawing.Point(543, 247)
        Me.btnGuardarPrecioOpcional.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGuardarPrecioOpcional.Name = "btnGuardarPrecioOpcional"
        Me.btnGuardarPrecioOpcional.Size = New System.Drawing.Size(116, 52)
        Me.btnGuardarPrecioOpcional.TabIndex = 32
        Me.btnGuardarPrecioOpcional.Text = "GUARDAR PRECIO OPCIONAL"
        Me.btnGuardarPrecioOpcional.UseVisualStyleBackColor = True
        '
        'txtPrecioOpcionalProducto
        '
        Me.txtPrecioOpcionalProducto.Location = New System.Drawing.Point(543, 223)
        Me.txtPrecioOpcionalProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrecioOpcionalProducto.Name = "txtPrecioOpcionalProducto"
        Me.txtPrecioOpcionalProducto.Size = New System.Drawing.Size(116, 20)
        Me.txtPrecioOpcionalProducto.TabIndex = 31
        '
        'lblPrecioOpcionalProducto
        '
        Me.lblPrecioOpcionalProducto.AutoSize = True
        Me.lblPrecioOpcionalProducto.Location = New System.Drawing.Point(494, 200)
        Me.lblPrecioOpcionalProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecioOpcionalProducto.Name = "lblPrecioOpcionalProducto"
        Me.lblPrecioOpcionalProducto.Size = New System.Drawing.Size(192, 13)
        Me.lblPrecioOpcionalProducto.TabIndex = 30
        Me.lblPrecioOpcionalProducto.Text = "Precio del opcional para este producto:"
        '
        'btnGuardarOpcionales
        '
        Me.btnGuardarOpcionales.Location = New System.Drawing.Point(361, 314)
        Me.btnGuardarOpcionales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGuardarOpcionales.Name = "btnGuardarOpcionales"
        Me.btnGuardarOpcionales.Size = New System.Drawing.Size(99, 41)
        Me.btnGuardarOpcionales.TabIndex = 29
        Me.btnGuardarOpcionales.Text = "GUARDAR OPCIONALES"
        Me.btnGuardarOpcionales.UseVisualStyleBackColor = True
        '
        'nudMaxOpcionales
        '
        Me.nudMaxOpcionales.Location = New System.Drawing.Point(361, 167)
        Me.nudMaxOpcionales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nudMaxOpcionales.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMaxOpcionales.Name = "nudMaxOpcionales"
        Me.nudMaxOpcionales.Size = New System.Drawing.Size(90, 20)
        Me.nudMaxOpcionales.TabIndex = 28
        Me.nudMaxOpcionales.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMaxOpcionales
        '
        Me.lblMaxOpcionales.AutoSize = True
        Me.lblMaxOpcionales.Location = New System.Drawing.Point(241, 167)
        Me.lblMaxOpcionales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaxOpcionales.Name = "lblMaxOpcionales"
        Me.lblMaxOpcionales.Size = New System.Drawing.Size(115, 13)
        Me.lblMaxOpcionales.TabIndex = 27
        Me.lblMaxOpcionales.Text = "Máximo de opcionales:"
        '
        'clbOpcionalesProducto
        '
        Me.clbOpcionalesProducto.FormattingEnabled = True
        Me.clbOpcionalesProducto.Location = New System.Drawing.Point(358, 223)
        Me.clbOpcionalesProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clbOpcionalesProducto.Name = "clbOpcionalesProducto"
        Me.clbOpcionalesProducto.Size = New System.Drawing.Size(179, 79)
        Me.clbOpcionalesProducto.TabIndex = 26
        '
        'lblOpcionalesProducto
        '
        Me.lblOpcionalesProducto.AutoSize = True
        Me.lblOpcionalesProducto.Location = New System.Drawing.Point(356, 202)
        Me.lblOpcionalesProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpcionalesProducto.Name = "lblOpcionalesProducto"
        Me.lblOpcionalesProducto.Size = New System.Drawing.Size(125, 13)
        Me.lblOpcionalesProducto.TabIndex = 25
        Me.lblOpcionalesProducto.Text = "Opcionales del producto:"
        '
        'chkPermiteNotas
        '
        Me.chkPermiteNotas.AutoSize = True
        Me.chkPermiteNotas.Checked = True
        Me.chkPermiteNotas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPermiteNotas.Location = New System.Drawing.Point(4, 167)
        Me.chkPermiteNotas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPermiteNotas.Name = "chkPermiteNotas"
        Me.chkPermiteNotas.Size = New System.Drawing.Size(148, 17)
        Me.chkPermiteNotas.TabIndex = 24
        Me.chkPermiteNotas.Text = "Permitir Notas Adicionales"
        Me.chkPermiteNotas.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(344, 113)
        Me.btnEliminarProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(94, 41)
        Me.btnEliminarProducto.TabIndex = 23
        Me.btnEliminarProducto.Text = "ELIMINAR PRODUCTO"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnEditarProducto
        '
        Me.btnEditarProducto.Location = New System.Drawing.Point(232, 113)
        Me.btnEditarProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditarProducto.Name = "btnEditarProducto"
        Me.btnEditarProducto.Size = New System.Drawing.Size(94, 46)
        Me.btnEditarProducto.TabIndex = 22
        Me.btnEditarProducto.Text = "EDITAR PRODUCTO"
        Me.btnEditarProducto.UseVisualStyleBackColor = True
        '
        'nudMaxSabores
        '
        Me.nudMaxSabores.Location = New System.Drawing.Point(8, 136)
        Me.nudMaxSabores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nudMaxSabores.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudMaxSabores.Name = "nudMaxSabores"
        Me.nudMaxSabores.Size = New System.Drawing.Size(100, 20)
        Me.nudMaxSabores.TabIndex = 18
        Me.nudMaxSabores.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'lblMaxSabores
        '
        Me.lblMaxSabores.AutoSize = True
        Me.lblMaxSabores.Location = New System.Drawing.Point(8, 118)
        Me.lblMaxSabores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaxSabores.Name = "lblMaxSabores"
        Me.lblMaxSabores.Size = New System.Drawing.Size(101, 13)
        Me.lblMaxSabores.TabIndex = 17
        Me.lblMaxSabores.Text = "Máximo de sabores:"
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(148, 197)
        Me.lblProductos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(58, 13)
        Me.lblProductos.TabIndex = 16
        Me.lblProductos.Text = "Productos:"
        '
        'lblSaboresDisponibles
        '
        Me.lblSaboresDisponibles.AutoSize = True
        Me.lblSaboresDisponibles.Location = New System.Drawing.Point(6, 197)
        Me.lblSaboresDisponibles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaboresDisponibles.Name = "lblSaboresDisponibles"
        Me.lblSaboresDisponibles.Size = New System.Drawing.Size(104, 13)
        Me.lblSaboresDisponibles.TabIndex = 15
        Me.lblSaboresDisponibles.Text = "Sabores disponibles:"
        '
        'clbSabores
        '
        Me.clbSabores.FormattingEnabled = True
        Me.clbSabores.Location = New System.Drawing.Point(4, 214)
        Me.clbSabores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clbSabores.Name = "clbSabores"
        Me.clbSabores.Size = New System.Drawing.Size(130, 94)
        Me.clbSabores.TabIndex = 14
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(2, 8)
        Me.lblNombreProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(109, 13)
        Me.lblNombreProducto.TabIndex = 7
        Me.lblNombreProducto.Text = "Nombre del producto:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(116, 8)
        Me.txtNombreProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(120, 20)
        Me.txtNombreProducto.TabIndex = 8
        '
        'lstProductos
        '
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.Location = New System.Drawing.Point(146, 219)
        Me.lstProductos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(198, 95)
        Me.lstProductos.TabIndex = 13
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(116, 116)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(105, 44)
        Me.btnAgregarProducto.TabIndex = 6
        Me.btnAgregarProducto.Text = "AGREGAR PRODUCTO"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(2, 38)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 9
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(114, 38)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(120, 20)
        Me.txtDescripcion.TabIndex = 10
        '
        'cmbCategorias
        '
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Location = New System.Drawing.Point(4, 89)
        Me.cmbCategorias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(92, 21)
        Me.cmbCategorias.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(116, 63)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(120, 20)
        Me.txtPrecio.TabIndex = 12
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(2, 63)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 11
        Me.lblPrecio.Text = "Precio:"
        '
        'pnlCategorias
        '
        Me.pnlCategorias.Controls.Add(Me.lblNombreCategoria)
        Me.pnlCategorias.Controls.Add(Me.txtNombreCategoria)
        Me.pnlCategorias.Controls.Add(Me.btnAgregarCategoria)
        Me.pnlCategorias.Controls.Add(Me.lstCategorias)
        Me.pnlCategorias.Location = New System.Drawing.Point(514, 50)
        Me.pnlCategorias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlCategorias.Name = "pnlCategorias"
        Me.pnlCategorias.Size = New System.Drawing.Size(255, 154)
        Me.pnlCategorias.TabIndex = 14
        '
        'lblNombreCategoria
        '
        Me.lblNombreCategoria.AutoSize = True
        Me.lblNombreCategoria.Location = New System.Drawing.Point(2, 8)
        Me.lblNombreCategoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreCategoria.Name = "lblNombreCategoria"
        Me.lblNombreCategoria.Size = New System.Drawing.Size(109, 13)
        Me.lblNombreCategoria.TabIndex = 2
        Me.lblNombreCategoria.Text = "Nombre de categoria:"
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Location = New System.Drawing.Point(116, 8)
        Me.txtNombreCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(125, 20)
        Me.txtNombreCategoria.TabIndex = 3
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(4, 25)
        Me.btnAgregarCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(75, 32)
        Me.btnAgregarCategoria.TabIndex = 4
        Me.btnAgregarCategoria.Text = "AGREGAR"
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'lstCategorias
        '
        Me.lstCategorias.FormattingEnabled = True
        Me.lstCategorias.Location = New System.Drawing.Point(4, 62)
        Me.lstCategorias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstCategorias.Name = "lstCategorias"
        Me.lstCategorias.Size = New System.Drawing.Size(113, 82)
        Me.lstCategorias.TabIndex = 5
        '
        'pnlOpcionales
        '
        Me.pnlOpcionales.Controls.Add(Me.btnAgregarOpcional)
        Me.pnlOpcionales.Controls.Add(Me.lstOpcionales)
        Me.pnlOpcionales.Controls.Add(Me.cmbGrupoOpcional)
        Me.pnlOpcionales.Controls.Add(Me.lblGrupoOpcional)
        Me.pnlOpcionales.Controls.Add(Me.txtPrecioOpcional)
        Me.pnlOpcionales.Controls.Add(Me.lblPrecioOpcional)
        Me.pnlOpcionales.Controls.Add(Me.txtNombreOpcional)
        Me.pnlOpcionales.Controls.Add(Me.lblNombreOpcional)
        Me.pnlOpcionales.Controls.Add(Me.lblTituloOpcionales)
        Me.pnlOpcionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOpcionales.Location = New System.Drawing.Point(132, 0)
        Me.pnlOpcionales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlOpcionales.Name = "pnlOpcionales"
        Me.pnlOpcionales.Size = New System.Drawing.Size(1220, 377)
        Me.pnlOpcionales.TabIndex = 19
        Me.pnlOpcionales.Visible = False
        '
        'btnAgregarOpcional
        '
        Me.btnAgregarOpcional.Location = New System.Drawing.Point(652, 58)
        Me.btnAgregarOpcional.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarOpcional.Name = "btnAgregarOpcional"
        Me.btnAgregarOpcional.Size = New System.Drawing.Size(111, 48)
        Me.btnAgregarOpcional.TabIndex = 8
        Me.btnAgregarOpcional.Text = "AGREGAR OPCIONAL"
        Me.btnAgregarOpcional.UseVisualStyleBackColor = True
        '
        'lstOpcionales
        '
        Me.lstOpcionales.FormattingEnabled = True
        Me.lstOpcionales.Location = New System.Drawing.Point(460, 172)
        Me.lstOpcionales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstOpcionales.Name = "lstOpcionales"
        Me.lstOpcionales.Size = New System.Drawing.Size(121, 69)
        Me.lstOpcionales.TabIndex = 7
        '
        'cmbGrupoOpcional
        '
        Me.cmbGrupoOpcional.FormattingEnabled = True
        Me.cmbGrupoOpcional.Location = New System.Drawing.Point(460, 142)
        Me.cmbGrupoOpcional.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbGrupoOpcional.Name = "cmbGrupoOpcional"
        Me.cmbGrupoOpcional.Size = New System.Drawing.Size(113, 21)
        Me.cmbGrupoOpcional.TabIndex = 6
        '
        'lblGrupoOpcional
        '
        Me.lblGrupoOpcional.AutoSize = True
        Me.lblGrupoOpcional.Location = New System.Drawing.Point(460, 111)
        Me.lblGrupoOpcional.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGrupoOpcional.Name = "lblGrupoOpcional"
        Me.lblGrupoOpcional.Size = New System.Drawing.Size(39, 13)
        Me.lblGrupoOpcional.TabIndex = 5
        Me.lblGrupoOpcional.Text = "Grupo:"
        '
        'txtPrecioOpcional
        '
        Me.txtPrecioOpcional.Location = New System.Drawing.Point(509, 75)
        Me.txtPrecioOpcional.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrecioOpcional.Name = "txtPrecioOpcional"
        Me.txtPrecioOpcional.Size = New System.Drawing.Size(114, 20)
        Me.txtPrecioOpcional.TabIndex = 4
        '
        'lblPrecioOpcional
        '
        Me.lblPrecioOpcional.AutoSize = True
        Me.lblPrecioOpcional.Location = New System.Drawing.Point(460, 75)
        Me.lblPrecioOpcional.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecioOpcional.Name = "lblPrecioOpcional"
        Me.lblPrecioOpcional.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecioOpcional.TabIndex = 3
        Me.lblPrecioOpcional.Text = "Precio:"
        '
        'txtNombreOpcional
        '
        Me.txtNombreOpcional.Location = New System.Drawing.Point(509, 43)
        Me.txtNombreOpcional.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreOpcional.Name = "txtNombreOpcional"
        Me.txtNombreOpcional.Size = New System.Drawing.Size(114, 20)
        Me.txtNombreOpcional.TabIndex = 2
        '
        'lblNombreOpcional
        '
        Me.lblNombreOpcional.AutoSize = True
        Me.lblNombreOpcional.Location = New System.Drawing.Point(458, 43)
        Me.lblNombreOpcional.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreOpcional.Name = "lblNombreOpcional"
        Me.lblNombreOpcional.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreOpcional.TabIndex = 1
        Me.lblNombreOpcional.Text = "Nombre:"
        '
        'lblTituloOpcionales
        '
        Me.lblTituloOpcionales.AutoSize = True
        Me.lblTituloOpcionales.Location = New System.Drawing.Point(458, 23)
        Me.lblTituloOpcionales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloOpcionales.Name = "lblTituloOpcionales"
        Me.lblTituloOpcionales.Size = New System.Drawing.Size(114, 13)
        Me.lblTituloOpcionales.TabIndex = 0
        Me.lblTituloOpcionales.Text = "Gestión de Opcionales"
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeccion.Location = New System.Drawing.Point(153, 13)
        Me.lblSeccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(370, 24)
        Me.lblSeccion.TabIndex = 1
        Me.lblSeccion.Text = "Bienvenido al Panel de Administración"
        '
        'btnPedidos
        '
        Me.btnPedidos.Location = New System.Drawing.Point(14, 281)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(112, 35)
        Me.btnPedidos.TabIndex = 8
        Me.btnPedidos.Text = "PEDIDOS"
        Me.btnPedidos.UseVisualStyleBackColor = True
        '
        'btnVerCliente
        '
        Me.btnVerCliente.Location = New System.Drawing.Point(17, 334)
        Me.btnVerCliente.Name = "btnVerCliente"
        Me.btnVerCliente.Size = New System.Drawing.Size(109, 34)
        Me.btnVerCliente.TabIndex = 9
        Me.btnVerCliente.Text = "Ver como Cliente"
        Me.btnVerCliente.UseVisualStyleBackColor = True
        '
        'PanelAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 410)
        Me.Controls.Add(Me.pnlContenido)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PanelAdm"
        Me.Text = "Panel Administración - Brooklyn Helados"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        Me.pnlConfiguracion.ResumeLayout(False)
        Me.pnlMetodosPago.ResumeLayout(False)
        Me.pnlMetodosPago.PerformLayout()
        Me.pnlMetodosEntrega.ResumeLayout(False)
        Me.pnlMetodosEntrega.PerformLayout()
        Me.pnlConfiguracionPedidos.ResumeLayout(False)
        Me.pnlConfiguracionPedidos.PerformLayout()
        CType(Me.nudRepeticionNotificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCierrePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreparacionEstimada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlClientes.ResumeLayout(False)
        Me.pnlClientes.PerformLayout()
        Me.pnlPromociones.ResumeLayout(False)
        Me.pnlPromociones.PerformLayout()
        Me.pnlSabores.ResumeLayout(False)
        Me.pnlSabores.PerformLayout()
        Me.pnlProductos.ResumeLayout(False)
        Me.pnlProductos.PerformLayout()
        CType(Me.nudMaxOpcionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxSabores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCategorias.ResumeLayout(False)
        Me.pnlCategorias.PerformLayout()
        Me.pnlOpcionales.ResumeLayout(False)
        Me.pnlOpcionales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnSabores As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnCategorias As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents lblSeccion As Label
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents lblNombreCategoria As Label
    Friend WithEvents lstCategorias As ListBox
    Friend WithEvents cmbCategorias As ComboBox
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lstProductos As ListBox
    Friend WithEvents pnlCategorias As Panel
    Friend WithEvents pnlProductos As Panel
    Friend WithEvents pnlSabores As Panel
    Friend WithEvents lstSabores As ListBox
    Friend WithEvents btnAgregarSabor As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblDescripcionSabor As Label
    Friend WithEvents txtNombreSabor As TextBox
    Friend WithEvents lblNombreSabor As Label
    Friend WithEvents lblSaboresDisponibles As Label
    Friend WithEvents clbSabores As CheckedListBox
    Friend WithEvents lblProductos As Label
    Friend WithEvents pnlPromociones As Panel
    Friend WithEvents lstPromociones As ListBox
    Friend WithEvents btnAgregarPromocion As Button
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents lblDescuento As Label
    Friend WithEvents txtDescripcionPromocion As TextBox
    Friend WithEvents lblDescripcionPromocion As Label
    Friend WithEvents txtNombrePromocion As TextBox
    Friend WithEvents lblNombrePromocion As Label
    Friend WithEvents lblTituloPromociones As Label
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents pnlConfiguracion As Panel
    Friend WithEvents pnlMetodosPago As Panel
    Friend WithEvents lstMetodosPago As ListBox
    Friend WithEvents btnAgregarMetodoPago As Button
    Friend WithEvents lblTituloMetodosPago As Label
    Friend WithEvents pnlMetodosEntrega As Panel
    Friend WithEvents lstMetodosEntrega As ListBox
    Friend WithEvents btnAgregarMetodoEntrega As Button
    Friend WithEvents lblTituloMetodosEntrega As Label
    Friend WithEvents btnCambiarEstadoPago As Button
    Friend WithEvents btnCambiarEstadoEntrega As Button
    Friend WithEvents btnEditarMetodoPago As Button
    Friend WithEvents btnEditarMetodoEntrega As Button
    Friend WithEvents btnEliminarMetodoPago As Button
    Friend WithEvents btnEliminarMetodoEntrega As Button
    Friend WithEvents pnlClientes As Panel
    Friend WithEvents lblTituloClientes As Label
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents lstClientes As ListBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents txtDniCliente As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtApellidoCliente As TextBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents nudMaxSabores As NumericUpDown
    Friend WithEvents lblMaxSabores As Label
    Friend WithEvents btnEditarProducto As Button
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents chkPermiteNotas As CheckBox
    Friend WithEvents pnlOpcionales As Panel
    Friend WithEvents cmbGrupoOpcional As ComboBox
    Friend WithEvents lblGrupoOpcional As Label
    Friend WithEvents txtPrecioOpcional As TextBox
    Friend WithEvents lblPrecioOpcional As Label
    Friend WithEvents txtNombreOpcional As TextBox
    Friend WithEvents lblNombreOpcional As Label
    Friend WithEvents lblTituloOpcionales As Label
    Friend WithEvents btnAgregarOpcional As Button
    Friend WithEvents lstOpcionales As ListBox
    Friend WithEvents btnOpcionales As Button
    Friend WithEvents nudMaxOpcionales As NumericUpDown
    Friend WithEvents lblMaxOpcionales As Label
    Friend WithEvents clbOpcionalesProducto As CheckedListBox
    Friend WithEvents lblOpcionalesProducto As Label
    Friend WithEvents btnGuardarOpcionales As Button
    Friend WithEvents txtPrecioOpcionalProducto As TextBox
    Friend WithEvents lblPrecioOpcionalProducto As Label
    Friend WithEvents btnGuardarPrecioOpcional As Button
    Friend WithEvents pnlConfiguracionPedidos As Panel
    Friend WithEvents btnGuardarConfiguracionPedidos As Button
    Friend WithEvents rdbPanelWhatsapp As RadioButton
    Friend WithEvents rdbSoloPanel As RadioButton
    Friend WithEvents rdbSoloWhatsapp As RadioButton
    Friend WithEvents lblTituloConfiguracionPedidos As Label
    Friend WithEvents lblMinutosPreparacion As Label
    Friend WithEvents nudPreparacionEstimada As NumericUpDown
    Friend WithEvents lblPreparacionEstimada As Label
    Friend WithEvents nudRepeticionNotificacion As NumericUpDown
    Friend WithEvents lblRepeticionNotificacion As Label
    Friend WithEvents cmbTonoNotificacion As ComboBox
    Friend WithEvents lblTonoNotificacion As Label
    Friend WithEvents lblMinutos As Label
    Friend WithEvents nudCierrePedidos As NumericUpDown
    Friend WithEvents lblCierrePedidos As Label
    Friend WithEvents chkNotificacionSonora As CheckBox
    Friend WithEvents chkImprimirPedidos As CheckBox
    Friend WithEvents btnPedidos As Button
    Friend WithEvents btnVerCliente As Button
End Class


