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
        Me.chkNotificacionSonora = New System.Windows.Forms.CheckBox()
        Me.lblCierrePedidos = New System.Windows.Forms.Label()
        Me.nudCierrePedidos = New System.Windows.Forms.NumericUpDown()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.lblTonoNotificacion = New System.Windows.Forms.Label()
        Me.cmbTonoNotificacion = New System.Windows.Forms.ComboBox()
        Me.lblRepeticionNotificacion = New System.Windows.Forms.Label()
        Me.nudRepeticionNotificacion = New System.Windows.Forms.NumericUpDown()
        Me.chkImprimirPedidos = New System.Windows.Forms.CheckBox()
        Me.pnlMenu.SuspendLayout()
        Me.pnlContenido.SuspendLayout()
        Me.pnlConfiguracion.SuspendLayout()
        Me.pnlMetodosPago.SuspendLayout()
        Me.pnlMetodosEntrega.SuspendLayout()
        Me.pnlConfiguracionPedidos.SuspendLayout()
        CType(Me.nudPreparacionEstimada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlClientes.SuspendLayout()
        Me.pnlPromociones.SuspendLayout()
        Me.pnlSabores.SuspendLayout()
        Me.pnlProductos.SuspendLayout()
        CType(Me.nudMaxOpcionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxSabores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCategorias.SuspendLayout()
        Me.pnlOpcionales.SuspendLayout()
        CType(Me.nudCierrePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRepeticionNotificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnConfiguracion)
        Me.pnlMenu.Controls.Add(Me.btnClientes)
        Me.pnlMenu.Controls.Add(Me.btnSabores)
        Me.pnlMenu.Controls.Add(Me.btnProductos)
        Me.pnlMenu.Controls.Add(Me.btnCategorias)
        Me.pnlMenu.Controls.Add(Me.btnOpcionales)
        Me.pnlMenu.Controls.Add(Me.lblTitulo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(176, 464)
        Me.pnlMenu.TabIndex = 0
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Location = New System.Drawing.Point(18, 241)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(150, 32)
        Me.btnConfiguracion.TabIndex = 6
        Me.btnConfiguracion.Text = "CONFIGURACIÓN"
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(19, 187)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(140, 38)
        Me.btnClientes.TabIndex = 5
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnSabores
        '
        Me.btnSabores.Location = New System.Drawing.Point(18, 150)
        Me.btnSabores.Name = "btnSabores"
        Me.btnSabores.Size = New System.Drawing.Size(137, 23)
        Me.btnSabores.TabIndex = 3
        Me.btnSabores.Text = "SABORES"
        Me.btnSabores.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(18, 108)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(137, 23)
        Me.btnProductos.TabIndex = 2
        Me.btnProductos.Text = "PRODUCTOS"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnCategorias
        '
        Me.btnCategorias.Location = New System.Drawing.Point(19, 61)
        Me.btnCategorias.Name = "btnCategorias"
        Me.btnCategorias.Size = New System.Drawing.Size(136, 23)
        Me.btnCategorias.TabIndex = 1
        Me.btnCategorias.Text = "CATEGORIAS"
        Me.btnCategorias.UseVisualStyleBackColor = True
        '
        'btnOpcionales
        '
        Me.btnOpcionales.Location = New System.Drawing.Point(18, 289)
        Me.btnOpcionales.Name = "btnOpcionales"
        Me.btnOpcionales.Size = New System.Drawing.Size(150, 38)
        Me.btnOpcionales.TabIndex = 7
        Me.btnOpcionales.Text = "OPCIONALES"
        Me.btnOpcionales.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(34, 17)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(85, 17)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "BROOKLYN"
        '
        'pnlContenido
        '
        Me.pnlContenido.Controls.Add(Me.pnlConfiguracion)
        Me.pnlContenido.Controls.Add(Me.pnlClientes)
        Me.pnlContenido.Controls.Add(Me.pnlPromociones)
        Me.pnlContenido.Controls.Add(Me.pnlSabores)
        Me.pnlContenido.Controls.Add(Me.pnlProductos)
        Me.pnlContenido.Controls.Add(Me.pnlCategorias)
        Me.pnlContenido.Controls.Add(Me.pnlOpcionales)
        Me.pnlContenido.Controls.Add(Me.lblSeccion)
        Me.pnlContenido.Controls.Add(Me.pnlMenu)
        Me.pnlContenido.Location = New System.Drawing.Point(12, 12)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1802, 464)
        Me.pnlContenido.TabIndex = 0
        '
        'pnlConfiguracion
        '
        Me.pnlConfiguracion.Controls.Add(Me.pnlMetodosPago)
        Me.pnlConfiguracion.Controls.Add(Me.pnlMetodosEntrega)
        Me.pnlConfiguracion.Controls.Add(Me.pnlConfiguracionPedidos)
        Me.pnlConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConfiguracion.Location = New System.Drawing.Point(176, 0)
        Me.pnlConfiguracion.Name = "pnlConfiguracion"
        Me.pnlConfiguracion.Size = New System.Drawing.Size(1626, 464)
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
        Me.pnlMetodosPago.Location = New System.Drawing.Point(0, 273)
        Me.pnlMetodosPago.Name = "pnlMetodosPago"
        Me.pnlMetodosPago.Size = New System.Drawing.Size(1626, 200)
        Me.pnlMetodosPago.TabIndex = 0
        '
        'btnEliminarMetodoPago
        '
        Me.btnEliminarMetodoPago.Location = New System.Drawing.Point(149, 98)
        Me.btnEliminarMetodoPago.Name = "btnEliminarMetodoPago"
        Me.btnEliminarMetodoPago.Size = New System.Drawing.Size(112, 38)
        Me.btnEliminarMetodoPago.TabIndex = 5
        Me.btnEliminarMetodoPago.Text = "ELIMINAR"
        Me.btnEliminarMetodoPago.UseVisualStyleBackColor = True
        '
        'btnEditarMetodoPago
        '
        Me.btnEditarMetodoPago.Location = New System.Drawing.Point(12, 98)
        Me.btnEditarMetodoPago.Name = "btnEditarMetodoPago"
        Me.btnEditarMetodoPago.Size = New System.Drawing.Size(116, 39)
        Me.btnEditarMetodoPago.TabIndex = 4
        Me.btnEditarMetodoPago.Text = "EDITAR"
        Me.btnEditarMetodoPago.UseVisualStyleBackColor = True
        '
        'btnCambiarEstadoPago
        '
        Me.btnCambiarEstadoPago.Location = New System.Drawing.Point(283, 98)
        Me.btnCambiarEstadoPago.Name = "btnCambiarEstadoPago"
        Me.btnCambiarEstadoPago.Size = New System.Drawing.Size(230, 44)
        Me.btnCambiarEstadoPago.TabIndex = 3
        Me.btnCambiarEstadoPago.Text = "HABILITAR / DESHABILITAR"
        Me.btnCambiarEstadoPago.UseVisualStyleBackColor = True
        '
        'lstMetodosPago
        '
        Me.lstMetodosPago.FormattingEnabled = True
        Me.lstMetodosPago.ItemHeight = 16
        Me.lstMetodosPago.Location = New System.Drawing.Point(340, 18)
        Me.lstMetodosPago.Name = "lstMetodosPago"
        Me.lstMetodosPago.Size = New System.Drawing.Size(333, 68)
        Me.lstMetodosPago.TabIndex = 2
        '
        'btnAgregarMetodoPago
        '
        Me.btnAgregarMetodoPago.Location = New System.Drawing.Point(139, 7)
        Me.btnAgregarMetodoPago.Name = "btnAgregarMetodoPago"
        Me.btnAgregarMetodoPago.Size = New System.Drawing.Size(88, 32)
        Me.btnAgregarMetodoPago.TabIndex = 1
        Me.btnAgregarMetodoPago.Text = "+ AÑADIR"
        Me.btnAgregarMetodoPago.UseVisualStyleBackColor = True
        '
        'lblTituloMetodosPago
        '
        Me.lblTituloMetodosPago.AutoSize = True
        Me.lblTituloMetodosPago.Location = New System.Drawing.Point(14, 14)
        Me.lblTituloMetodosPago.Name = "lblTituloMetodosPago"
        Me.lblTituloMetodosPago.Size = New System.Drawing.Size(119, 17)
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
        Me.pnlMetodosEntrega.Location = New System.Drawing.Point(0, 130)
        Me.pnlMetodosEntrega.Name = "pnlMetodosEntrega"
        Me.pnlMetodosEntrega.Size = New System.Drawing.Size(1626, 143)
        Me.pnlMetodosEntrega.TabIndex = 1
        '
        'lblTituloMetodosEntrega
        '
        Me.lblTituloMetodosEntrega.AutoSize = True
        Me.lblTituloMetodosEntrega.Location = New System.Drawing.Point(9, 11)
        Me.lblTituloMetodosEntrega.Name = "lblTituloMetodosEntrega"
        Me.lblTituloMetodosEntrega.Size = New System.Drawing.Size(136, 17)
        Me.lblTituloMetodosEntrega.TabIndex = 0
        Me.lblTituloMetodosEntrega.Text = "Métodos de Entrega"
        '
        'btnEliminarMetodoEntrega
        '
        Me.btnEliminarMetodoEntrega.Location = New System.Drawing.Point(139, 85)
        Me.btnEliminarMetodoEntrega.Name = "btnEliminarMetodoEntrega"
        Me.btnEliminarMetodoEntrega.Size = New System.Drawing.Size(110, 47)
        Me.btnEliminarMetodoEntrega.TabIndex = 5
        Me.btnEliminarMetodoEntrega.Text = "ELIMINAR"
        Me.btnEliminarMetodoEntrega.UseVisualStyleBackColor = True
        '
        'btnEditarMetodoEntrega
        '
        Me.btnEditarMetodoEntrega.Location = New System.Drawing.Point(9, 88)
        Me.btnEditarMetodoEntrega.Name = "btnEditarMetodoEntrega"
        Me.btnEditarMetodoEntrega.Size = New System.Drawing.Size(112, 47)
        Me.btnEditarMetodoEntrega.TabIndex = 4
        Me.btnEditarMetodoEntrega.Text = "EDITAR"
        Me.btnEditarMetodoEntrega.UseVisualStyleBackColor = True
        '
        'btnCambiarEstadoEntrega
        '
        Me.btnCambiarEstadoEntrega.Location = New System.Drawing.Point(260, 87)
        Me.btnCambiarEstadoEntrega.Name = "btnCambiarEstadoEntrega"
        Me.btnCambiarEstadoEntrega.Size = New System.Drawing.Size(253, 42)
        Me.btnCambiarEstadoEntrega.TabIndex = 3
        Me.btnCambiarEstadoEntrega.Text = "HABILITAR / DESHABILITAR"
        Me.btnCambiarEstadoEntrega.UseVisualStyleBackColor = True
        '
        'lstMetodosEntrega
        '
        Me.lstMetodosEntrega.FormattingEnabled = True
        Me.lstMetodosEntrega.ItemHeight = 16
        Me.lstMetodosEntrega.Location = New System.Drawing.Point(340, 3)
        Me.lstMetodosEntrega.Name = "lstMetodosEntrega"
        Me.lstMetodosEntrega.Size = New System.Drawing.Size(333, 68)
        Me.lstMetodosEntrega.TabIndex = 2
        '
        'btnAgregarMetodoEntrega
        '
        Me.btnAgregarMetodoEntrega.Location = New System.Drawing.Point(149, 6)
        Me.btnAgregarMetodoEntrega.Name = "btnAgregarMetodoEntrega"
        Me.btnAgregarMetodoEntrega.Size = New System.Drawing.Size(161, 36)
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
        Me.pnlConfiguracionPedidos.Name = "pnlConfiguracionPedidos"
        Me.pnlConfiguracionPedidos.Size = New System.Drawing.Size(1626, 130)
        Me.pnlConfiguracionPedidos.TabIndex = 6
        '
        'lblMinutosPreparacion
        '
        Me.lblMinutosPreparacion.AutoSize = True
        Me.lblMinutosPreparacion.Location = New System.Drawing.Point(463, 33)
        Me.lblMinutosPreparacion.Name = "lblMinutosPreparacion"
        Me.lblMinutosPreparacion.Size = New System.Drawing.Size(57, 17)
        Me.lblMinutosPreparacion.TabIndex = 7
        Me.lblMinutosPreparacion.Text = "Minutos"
        '
        'nudPreparacionEstimada
        '
        Me.nudPreparacionEstimada.Location = New System.Drawing.Point(394, 31)
        Me.nudPreparacionEstimada.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.nudPreparacionEstimada.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPreparacionEstimada.Name = "nudPreparacionEstimada"
        Me.nudPreparacionEstimada.Size = New System.Drawing.Size(63, 22)
        Me.nudPreparacionEstimada.TabIndex = 6
        Me.nudPreparacionEstimada.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'lblPreparacionEstimada
        '
        Me.lblPreparacionEstimada.AutoSize = True
        Me.lblPreparacionEstimada.Location = New System.Drawing.Point(391, 11)
        Me.lblPreparacionEstimada.Name = "lblPreparacionEstimada"
        Me.lblPreparacionEstimada.Size = New System.Drawing.Size(150, 17)
        Me.lblPreparacionEstimada.TabIndex = 5
        Me.lblPreparacionEstimada.Text = "Preparación estimada:"
        '
        'btnGuardarConfiguracionPedidos
        '
        Me.btnGuardarConfiguracionPedidos.Location = New System.Drawing.Point(206, 50)
        Me.btnGuardarConfiguracionPedidos.Name = "btnGuardarConfiguracionPedidos"
        Me.btnGuardarConfiguracionPedidos.Size = New System.Drawing.Size(172, 44)
        Me.btnGuardarConfiguracionPedidos.TabIndex = 4
        Me.btnGuardarConfiguracionPedidos.Text = "GUARDAR CONFIGURACIÓN"
        Me.btnGuardarConfiguracionPedidos.UseVisualStyleBackColor = True
        '
        'rdbPanelWhatsapp
        '
        Me.rdbPanelWhatsapp.AutoSize = True
        Me.rdbPanelWhatsapp.Location = New System.Drawing.Point(24, 102)
        Me.rdbPanelWhatsapp.Name = "rdbPanelWhatsapp"
        Me.rdbPanelWhatsapp.Size = New System.Drawing.Size(144, 21)
        Me.rdbPanelWhatsapp.TabIndex = 3
        Me.rdbPanelWhatsapp.Text = "Panel y Whatsapp"
        Me.rdbPanelWhatsapp.UseVisualStyleBackColor = True
        '
        'rdbSoloPanel
        '
        Me.rdbSoloPanel.AutoSize = True
        Me.rdbSoloPanel.Checked = True
        Me.rdbSoloPanel.Location = New System.Drawing.Point(24, 71)
        Me.rdbSoloPanel.Name = "rdbSoloPanel"
        Me.rdbSoloPanel.Size = New System.Drawing.Size(116, 21)
        Me.rdbSoloPanel.TabIndex = 2
        Me.rdbSoloPanel.TabStop = True
        Me.rdbSoloPanel.Text = "Solo en panel"
        Me.rdbSoloPanel.UseVisualStyleBackColor = True
        '
        'rdbSoloWhatsapp
        '
        Me.rdbSoloWhatsapp.AutoSize = True
        Me.rdbSoloWhatsapp.Location = New System.Drawing.Point(24, 45)
        Me.rdbSoloWhatsapp.Name = "rdbSoloWhatsapp"
        Me.rdbSoloWhatsapp.Size = New System.Drawing.Size(145, 21)
        Me.rdbSoloWhatsapp.TabIndex = 1
        Me.rdbSoloWhatsapp.Text = "Solo en Whatsapp"
        Me.rdbSoloWhatsapp.UseVisualStyleBackColor = True
        '
        'lblTituloConfiguracionPedidos
        '
        Me.lblTituloConfiguracionPedidos.AutoSize = True
        Me.lblTituloConfiguracionPedidos.Location = New System.Drawing.Point(21, 12)
        Me.lblTituloConfiguracionPedidos.Name = "lblTituloConfiguracionPedidos"
        Me.lblTituloConfiguracionPedidos.Size = New System.Drawing.Size(185, 17)
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
        Me.pnlClientes.Location = New System.Drawing.Point(176, 0)
        Me.pnlClientes.Name = "pnlClientes"
        Me.pnlClientes.Size = New System.Drawing.Size(1626, 464)
        Me.pnlClientes.TabIndex = 6
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(316, 215)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(107, 53)
        Me.btnEliminarCliente.TabIndex = 18
        Me.btnEliminarCliente.Text = "ELIMINAR"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Location = New System.Drawing.Point(160, 212)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(119, 56)
        Me.btnEditarCliente.TabIndex = 17
        Me.btnEditarCliente.Text = "EDITAR"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        '
        'lblTituloClientes
        '
        Me.lblTituloClientes.AutoSize = True
        Me.lblTituloClientes.Location = New System.Drawing.Point(44, 14)
        Me.lblTituloClientes.Name = "lblTituloClientes"
        Me.lblTituloClientes.Size = New System.Drawing.Size(131, 17)
        Me.lblTituloClientes.TabIndex = 0
        Me.lblTituloClientes.Text = "Gestión de Clientes"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(21, 50)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre:"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(109, 178)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(170, 22)
        Me.txtEmailCliente.TabIndex = 15
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(106, 45)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(173, 22)
        Me.txtNombreCliente.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(32, 183)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 17)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(104, 147)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(175, 22)
        Me.txtTelefonoCliente.TabIndex = 14
        '
        'txtDniCliente
        '
        Me.txtDniCliente.Location = New System.Drawing.Point(106, 113)
        Me.txtDniCliente.Name = "txtDniCliente"
        Me.txtDniCliente.Size = New System.Drawing.Size(173, 22)
        Me.txtDniCliente.TabIndex = 13
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(21, 84)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(62, 17)
        Me.lblApellido.TabIndex = 7
        Me.lblApellido.Text = "Apellido:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(21, 150)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(68, 17)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Teléfono:"
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(24, 215)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(121, 53)
        Me.btnAgregarCliente.TabIndex = 16
        Me.btnAgregarCliente.Text = "AGREGAR CLIENTE"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'lstClientes
        '
        Me.lstClientes.FormattingEnabled = True
        Me.lstClientes.ItemHeight = 16
        Me.lstClientes.Location = New System.Drawing.Point(21, 278)
        Me.lstClientes.Name = "lstClientes"
        Me.lstClientes.Size = New System.Drawing.Size(258, 132)
        Me.lstClientes.TabIndex = 1
        '
        'txtApellidoCliente
        '
        Me.txtApellidoCliente.Location = New System.Drawing.Point(106, 79)
        Me.txtApellidoCliente.Name = "txtApellidoCliente"
        Me.txtApellidoCliente.Size = New System.Drawing.Size(170, 22)
        Me.txtApellidoCliente.TabIndex = 12
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(32, 113)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(35, 17)
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
        Me.pnlPromociones.Location = New System.Drawing.Point(1134, 73)
        Me.pnlPromociones.Name = "pnlPromociones"
        Me.pnlPromociones.Size = New System.Drawing.Size(321, 331)
        Me.pnlPromociones.TabIndex = 17
        '
        'lstPromociones
        '
        Me.lstPromociones.FormattingEnabled = True
        Me.lstPromociones.ItemHeight = 16
        Me.lstPromociones.Location = New System.Drawing.Point(17, 216)
        Me.lstPromociones.Name = "lstPromociones"
        Me.lstPromociones.Size = New System.Drawing.Size(288, 100)
        Me.lstPromociones.TabIndex = 8
        '
        'btnAgregarPromocion
        '
        Me.btnAgregarPromocion.Location = New System.Drawing.Point(95, 158)
        Me.btnAgregarPromocion.Name = "btnAgregarPromocion"
        Me.btnAgregarPromocion.Size = New System.Drawing.Size(123, 52)
        Me.btnAgregarPromocion.TabIndex = 7
        Me.btnAgregarPromocion.Text = "AGREGAR PROMOCIÓN"
        Me.btnAgregarPromocion.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(172, 114)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(133, 22)
        Me.txtDescuento.TabIndex = 6
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(14, 114)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(106, 17)
        Me.lblDescuento.TabIndex = 5
        Me.lblDescuento.Text = "Descuento (%):"
        '
        'txtDescripcionPromocion
        '
        Me.txtDescripcionPromocion.Location = New System.Drawing.Point(172, 78)
        Me.txtDescripcionPromocion.Name = "txtDescripcionPromocion"
        Me.txtDescripcionPromocion.Size = New System.Drawing.Size(133, 22)
        Me.txtDescripcionPromocion.TabIndex = 4
        '
        'lblDescripcionPromocion
        '
        Me.lblDescripcionPromocion.AutoSize = True
        Me.lblDescripcionPromocion.Location = New System.Drawing.Point(23, 76)
        Me.lblDescripcionPromocion.Name = "lblDescripcionPromocion"
        Me.lblDescripcionPromocion.Size = New System.Drawing.Size(86, 17)
        Me.lblDescripcionPromocion.TabIndex = 3
        Me.lblDescripcionPromocion.Text = "Descripción:"
        '
        'txtNombrePromocion
        '
        Me.txtNombrePromocion.Location = New System.Drawing.Point(172, 42)
        Me.txtNombrePromocion.Name = "txtNombrePromocion"
        Me.txtNombrePromocion.Size = New System.Drawing.Size(133, 22)
        Me.txtNombrePromocion.TabIndex = 2
        '
        'lblNombrePromocion
        '
        Me.lblNombrePromocion.AutoSize = True
        Me.lblNombrePromocion.Location = New System.Drawing.Point(14, 42)
        Me.lblNombrePromocion.Name = "lblNombrePromocion"
        Me.lblNombrePromocion.Size = New System.Drawing.Size(152, 17)
        Me.lblNombrePromocion.TabIndex = 1
        Me.lblNombrePromocion.Text = "Nombre de promoción:"
        '
        'lblTituloPromociones
        '
        Me.lblTituloPromociones.AutoSize = True
        Me.lblTituloPromociones.Location = New System.Drawing.Point(13, 14)
        Me.lblTituloPromociones.Name = "lblTituloPromociones"
        Me.lblTituloPromociones.Size = New System.Drawing.Size(162, 17)
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
        Me.pnlSabores.Location = New System.Drawing.Point(686, 257)
        Me.pnlSabores.Name = "pnlSabores"
        Me.pnlSabores.Size = New System.Drawing.Size(442, 142)
        Me.pnlSabores.TabIndex = 16
        '
        'lstSabores
        '
        Me.lstSabores.FormattingEnabled = True
        Me.lstSabores.ItemHeight = 16
        Me.lstSabores.Location = New System.Drawing.Point(281, 6)
        Me.lstSabores.Name = "lstSabores"
        Me.lstSabores.Size = New System.Drawing.Size(158, 132)
        Me.lstSabores.TabIndex = 5
        '
        'btnAgregarSabor
        '
        Me.btnAgregarSabor.Location = New System.Drawing.Point(9, 67)
        Me.btnAgregarSabor.Name = "btnAgregarSabor"
        Me.btnAgregarSabor.Size = New System.Drawing.Size(118, 57)
        Me.btnAgregarSabor.TabIndex = 4
        Me.btnAgregarSabor.Text = "AGREGAR SABOR"
        Me.btnAgregarSabor.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(134, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'lblDescripcionSabor
        '
        Me.lblDescripcionSabor.AutoSize = True
        Me.lblDescripcionSabor.Location = New System.Drawing.Point(6, 37)
        Me.lblDescripcionSabor.Name = "lblDescripcionSabor"
        Me.lblDescripcionSabor.Size = New System.Drawing.Size(86, 17)
        Me.lblDescripcionSabor.TabIndex = 2
        Me.lblDescripcionSabor.Text = "Descripción:"
        '
        'txtNombreSabor
        '
        Me.txtNombreSabor.Location = New System.Drawing.Point(134, 6)
        Me.txtNombreSabor.Name = "txtNombreSabor"
        Me.txtNombreSabor.Size = New System.Drawing.Size(100, 22)
        Me.txtNombreSabor.TabIndex = 1
        '
        'lblNombreSabor
        '
        Me.lblNombreSabor.AutoSize = True
        Me.lblNombreSabor.Location = New System.Drawing.Point(3, 6)
        Me.lblNombreSabor.Name = "lblNombreSabor"
        Me.lblNombreSabor.Size = New System.Drawing.Size(125, 17)
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
        Me.pnlProductos.Location = New System.Drawing.Point(182, 3)
        Me.pnlProductos.Name = "pnlProductos"
        Me.pnlProductos.Size = New System.Drawing.Size(917, 450)
        Me.pnlProductos.TabIndex = 15
        '
        'btnGuardarPrecioOpcional
        '
        Me.btnGuardarPrecioOpcional.Location = New System.Drawing.Point(724, 304)
        Me.btnGuardarPrecioOpcional.Name = "btnGuardarPrecioOpcional"
        Me.btnGuardarPrecioOpcional.Size = New System.Drawing.Size(154, 64)
        Me.btnGuardarPrecioOpcional.TabIndex = 32
        Me.btnGuardarPrecioOpcional.Text = "GUARDAR PRECIO OPCIONAL"
        Me.btnGuardarPrecioOpcional.UseVisualStyleBackColor = True
        '
        'txtPrecioOpcionalProducto
        '
        Me.txtPrecioOpcionalProducto.Location = New System.Drawing.Point(724, 275)
        Me.txtPrecioOpcionalProducto.Name = "txtPrecioOpcionalProducto"
        Me.txtPrecioOpcionalProducto.Size = New System.Drawing.Size(154, 22)
        Me.txtPrecioOpcionalProducto.TabIndex = 31
        '
        'lblPrecioOpcionalProducto
        '
        Me.lblPrecioOpcionalProducto.AutoSize = True
        Me.lblPrecioOpcionalProducto.Location = New System.Drawing.Point(658, 246)
        Me.lblPrecioOpcionalProducto.Name = "lblPrecioOpcionalProducto"
        Me.lblPrecioOpcionalProducto.Size = New System.Drawing.Size(256, 17)
        Me.lblPrecioOpcionalProducto.TabIndex = 30
        Me.lblPrecioOpcionalProducto.Text = "Precio del opcional para este producto:"
        '
        'btnGuardarOpcionales
        '
        Me.btnGuardarOpcionales.Location = New System.Drawing.Point(481, 387)
        Me.btnGuardarOpcionales.Name = "btnGuardarOpcionales"
        Me.btnGuardarOpcionales.Size = New System.Drawing.Size(132, 50)
        Me.btnGuardarOpcionales.TabIndex = 29
        Me.btnGuardarOpcionales.Text = "GUARDAR OPCIONALES"
        Me.btnGuardarOpcionales.UseVisualStyleBackColor = True
        '
        'nudMaxOpcionales
        '
        Me.nudMaxOpcionales.Location = New System.Drawing.Point(481, 205)
        Me.nudMaxOpcionales.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMaxOpcionales.Name = "nudMaxOpcionales"
        Me.nudMaxOpcionales.Size = New System.Drawing.Size(120, 22)
        Me.nudMaxOpcionales.TabIndex = 28
        Me.nudMaxOpcionales.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMaxOpcionales
        '
        Me.lblMaxOpcionales.AutoSize = True
        Me.lblMaxOpcionales.Location = New System.Drawing.Point(321, 206)
        Me.lblMaxOpcionales.Name = "lblMaxOpcionales"
        Me.lblMaxOpcionales.Size = New System.Drawing.Size(151, 17)
        Me.lblMaxOpcionales.TabIndex = 27
        Me.lblMaxOpcionales.Text = "Máximo de opcionales:"
        '
        'clbOpcionalesProducto
        '
        Me.clbOpcionalesProducto.FormattingEnabled = True
        Me.clbOpcionalesProducto.Location = New System.Drawing.Point(478, 275)
        Me.clbOpcionalesProducto.Name = "clbOpcionalesProducto"
        Me.clbOpcionalesProducto.Size = New System.Drawing.Size(237, 106)
        Me.clbOpcionalesProducto.TabIndex = 26
        '
        'lblOpcionalesProducto
        '
        Me.lblOpcionalesProducto.AutoSize = True
        Me.lblOpcionalesProducto.Location = New System.Drawing.Point(475, 249)
        Me.lblOpcionalesProducto.Name = "lblOpcionalesProducto"
        Me.lblOpcionalesProducto.Size = New System.Drawing.Size(166, 17)
        Me.lblOpcionalesProducto.TabIndex = 25
        Me.lblOpcionalesProducto.Text = "Opcionales del producto:"
        '
        'chkPermiteNotas
        '
        Me.chkPermiteNotas.AutoSize = True
        Me.chkPermiteNotas.Checked = True
        Me.chkPermiteNotas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPermiteNotas.Location = New System.Drawing.Point(6, 206)
        Me.chkPermiteNotas.Name = "chkPermiteNotas"
        Me.chkPermiteNotas.Size = New System.Drawing.Size(195, 21)
        Me.chkPermiteNotas.TabIndex = 24
        Me.chkPermiteNotas.Text = "Permitir Notas Adicionales"
        Me.chkPermiteNotas.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(459, 139)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(125, 51)
        Me.btnEliminarProducto.TabIndex = 23
        Me.btnEliminarProducto.Text = "ELIMINAR PRODUCTO"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnEditarProducto
        '
        Me.btnEditarProducto.Location = New System.Drawing.Point(310, 139)
        Me.btnEditarProducto.Name = "btnEditarProducto"
        Me.btnEditarProducto.Size = New System.Drawing.Size(125, 56)
        Me.btnEditarProducto.TabIndex = 22
        Me.btnEditarProducto.Text = "EDITAR PRODUCTO"
        Me.btnEditarProducto.UseVisualStyleBackColor = True
        '
        'nudMaxSabores
        '
        Me.nudMaxSabores.Location = New System.Drawing.Point(11, 167)
        Me.nudMaxSabores.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudMaxSabores.Name = "nudMaxSabores"
        Me.nudMaxSabores.Size = New System.Drawing.Size(134, 22)
        Me.nudMaxSabores.TabIndex = 18
        Me.nudMaxSabores.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'lblMaxSabores
        '
        Me.lblMaxSabores.AutoSize = True
        Me.lblMaxSabores.Location = New System.Drawing.Point(11, 145)
        Me.lblMaxSabores.Name = "lblMaxSabores"
        Me.lblMaxSabores.Size = New System.Drawing.Size(134, 17)
        Me.lblMaxSabores.TabIndex = 17
        Me.lblMaxSabores.Text = "Máximo de sabores:"
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(197, 243)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(76, 17)
        Me.lblProductos.TabIndex = 16
        Me.lblProductos.Text = "Productos:"
        '
        'lblSaboresDisponibles
        '
        Me.lblSaboresDisponibles.AutoSize = True
        Me.lblSaboresDisponibles.Location = New System.Drawing.Point(8, 243)
        Me.lblSaboresDisponibles.Name = "lblSaboresDisponibles"
        Me.lblSaboresDisponibles.Size = New System.Drawing.Size(140, 17)
        Me.lblSaboresDisponibles.TabIndex = 15
        Me.lblSaboresDisponibles.Text = "Sabores disponibles:"
        '
        'clbSabores
        '
        Me.clbSabores.FormattingEnabled = True
        Me.clbSabores.Location = New System.Drawing.Point(6, 263)
        Me.clbSabores.Name = "clbSabores"
        Me.clbSabores.Size = New System.Drawing.Size(172, 123)
        Me.clbSabores.TabIndex = 14
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(3, 10)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(145, 17)
        Me.lblNombreProducto.TabIndex = 7
        Me.lblNombreProducto.Text = "Nombre del producto:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(154, 10)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(158, 22)
        Me.txtNombreProducto.TabIndex = 8
        '
        'lstProductos
        '
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.ItemHeight = 16
        Me.lstProductos.Location = New System.Drawing.Point(194, 270)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(263, 116)
        Me.lstProductos.TabIndex = 13
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(154, 143)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(140, 54)
        Me.btnAgregarProducto.TabIndex = 6
        Me.btnAgregarProducto.Text = "AGREGAR PRODUCTO"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 47)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(86, 17)
        Me.lblDescripcion.TabIndex = 9
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(152, 47)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(158, 22)
        Me.txtDescripcion.TabIndex = 10
        '
        'cmbCategorias
        '
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Location = New System.Drawing.Point(6, 110)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(121, 24)
        Me.cmbCategorias.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(154, 78)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(158, 22)
        Me.txtPrecio.TabIndex = 12
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(3, 78)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(52, 17)
        Me.lblPrecio.TabIndex = 11
        Me.lblPrecio.Text = "Precio:"
        '
        'pnlCategorias
        '
        Me.pnlCategorias.Controls.Add(Me.lblNombreCategoria)
        Me.pnlCategorias.Controls.Add(Me.txtNombreCategoria)
        Me.pnlCategorias.Controls.Add(Me.btnAgregarCategoria)
        Me.pnlCategorias.Controls.Add(Me.lstCategorias)
        Me.pnlCategorias.Location = New System.Drawing.Point(686, 61)
        Me.pnlCategorias.Name = "pnlCategorias"
        Me.pnlCategorias.Size = New System.Drawing.Size(340, 190)
        Me.pnlCategorias.TabIndex = 14
        '
        'lblNombreCategoria
        '
        Me.lblNombreCategoria.AutoSize = True
        Me.lblNombreCategoria.Location = New System.Drawing.Point(3, 10)
        Me.lblNombreCategoria.Name = "lblNombreCategoria"
        Me.lblNombreCategoria.Size = New System.Drawing.Size(145, 17)
        Me.lblNombreCategoria.TabIndex = 2
        Me.lblNombreCategoria.Text = "Nombre de categoria:"
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Location = New System.Drawing.Point(154, 10)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(165, 22)
        Me.txtNombreCategoria.TabIndex = 3
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(6, 31)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(100, 39)
        Me.btnAgregarCategoria.TabIndex = 4
        Me.btnAgregarCategoria.Text = "AGREGAR"
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'lstCategorias
        '
        Me.lstCategorias.FormattingEnabled = True
        Me.lstCategorias.ItemHeight = 16
        Me.lstCategorias.Location = New System.Drawing.Point(6, 76)
        Me.lstCategorias.Name = "lstCategorias"
        Me.lstCategorias.Size = New System.Drawing.Size(149, 100)
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
        Me.pnlOpcionales.Location = New System.Drawing.Point(176, 0)
        Me.pnlOpcionales.Name = "pnlOpcionales"
        Me.pnlOpcionales.Size = New System.Drawing.Size(1626, 464)
        Me.pnlOpcionales.TabIndex = 19
        Me.pnlOpcionales.Visible = False
        '
        'btnAgregarOpcional
        '
        Me.btnAgregarOpcional.Location = New System.Drawing.Point(870, 71)
        Me.btnAgregarOpcional.Name = "btnAgregarOpcional"
        Me.btnAgregarOpcional.Size = New System.Drawing.Size(148, 59)
        Me.btnAgregarOpcional.TabIndex = 8
        Me.btnAgregarOpcional.Text = "AGREGAR OPCIONAL"
        Me.btnAgregarOpcional.UseVisualStyleBackColor = True
        '
        'lstOpcionales
        '
        Me.lstOpcionales.FormattingEnabled = True
        Me.lstOpcionales.ItemHeight = 16
        Me.lstOpcionales.Location = New System.Drawing.Point(613, 212)
        Me.lstOpcionales.Name = "lstOpcionales"
        Me.lstOpcionales.Size = New System.Drawing.Size(160, 84)
        Me.lstOpcionales.TabIndex = 7
        '
        'cmbGrupoOpcional
        '
        Me.cmbGrupoOpcional.FormattingEnabled = True
        Me.cmbGrupoOpcional.Location = New System.Drawing.Point(613, 175)
        Me.cmbGrupoOpcional.Name = "cmbGrupoOpcional"
        Me.cmbGrupoOpcional.Size = New System.Drawing.Size(149, 24)
        Me.cmbGrupoOpcional.TabIndex = 6
        '
        'lblGrupoOpcional
        '
        Me.lblGrupoOpcional.AutoSize = True
        Me.lblGrupoOpcional.Location = New System.Drawing.Point(614, 137)
        Me.lblGrupoOpcional.Name = "lblGrupoOpcional"
        Me.lblGrupoOpcional.Size = New System.Drawing.Size(52, 17)
        Me.lblGrupoOpcional.TabIndex = 5
        Me.lblGrupoOpcional.Text = "Grupo:"
        '
        'txtPrecioOpcional
        '
        Me.txtPrecioOpcional.Location = New System.Drawing.Point(679, 92)
        Me.txtPrecioOpcional.Name = "txtPrecioOpcional"
        Me.txtPrecioOpcional.Size = New System.Drawing.Size(151, 22)
        Me.txtPrecioOpcional.TabIndex = 4
        '
        'lblPrecioOpcional
        '
        Me.lblPrecioOpcional.AutoSize = True
        Me.lblPrecioOpcional.Location = New System.Drawing.Point(613, 92)
        Me.lblPrecioOpcional.Name = "lblPrecioOpcional"
        Me.lblPrecioOpcional.Size = New System.Drawing.Size(52, 17)
        Me.lblPrecioOpcional.TabIndex = 3
        Me.lblPrecioOpcional.Text = "Precio:"
        '
        'txtNombreOpcional
        '
        Me.txtNombreOpcional.Location = New System.Drawing.Point(679, 53)
        Me.txtNombreOpcional.Name = "txtNombreOpcional"
        Me.txtNombreOpcional.Size = New System.Drawing.Size(151, 22)
        Me.txtNombreOpcional.TabIndex = 2
        '
        'lblNombreOpcional
        '
        Me.lblNombreOpcional.AutoSize = True
        Me.lblNombreOpcional.Location = New System.Drawing.Point(611, 53)
        Me.lblNombreOpcional.Name = "lblNombreOpcional"
        Me.lblNombreOpcional.Size = New System.Drawing.Size(62, 17)
        Me.lblNombreOpcional.TabIndex = 1
        Me.lblNombreOpcional.Text = "Nombre:"
        '
        'lblTituloOpcionales
        '
        Me.lblTituloOpcionales.AutoSize = True
        Me.lblTituloOpcionales.Location = New System.Drawing.Point(610, 28)
        Me.lblTituloOpcionales.Name = "lblTituloOpcionales"
        Me.lblTituloOpcionales.Size = New System.Drawing.Size(152, 17)
        Me.lblTituloOpcionales.TabIndex = 0
        Me.lblTituloOpcionales.Text = "Gestión de Opcionales"
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeccion.Location = New System.Drawing.Point(204, 16)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(462, 29)
        Me.lblSeccion.TabIndex = 1
        Me.lblSeccion.Text = "Bienvenido al Panel de Administración"
        '
        'chkNotificacionSonora
        '
        Me.chkNotificacionSonora.AutoSize = True
        Me.chkNotificacionSonora.Checked = True
        Me.chkNotificacionSonora.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNotificacionSonora.Location = New System.Drawing.Point(394, 63)
        Me.chkNotificacionSonora.Name = "chkNotificacionSonora"
        Me.chkNotificacionSonora.Size = New System.Drawing.Size(205, 21)
        Me.chkNotificacionSonora.TabIndex = 8
        Me.chkNotificacionSonora.Text = "Habilitar notificación sonora"
        Me.chkNotificacionSonora.UseVisualStyleBackColor = True
        '
        'lblCierrePedidos
        '
        Me.lblCierrePedidos.AutoSize = True
        Me.lblCierrePedidos.Location = New System.Drawing.Point(389, 97)
        Me.lblCierrePedidos.Name = "lblCierrePedidos"
        Me.lblCierrePedidos.Size = New System.Drawing.Size(124, 17)
        Me.lblCierrePedidos.TabIndex = 9
        Me.lblCierrePedidos.Text = "Cierre de pedidos:"
        '
        'nudCierrePedidos
        '
        Me.nudCierrePedidos.Location = New System.Drawing.Point(516, 97)
        Me.nudCierrePedidos.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.nudCierrePedidos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCierrePedidos.Name = "nudCierrePedidos"
        Me.nudCierrePedidos.Size = New System.Drawing.Size(77, 22)
        Me.nudCierrePedidos.TabIndex = 10
        Me.nudCierrePedidos.Value = New Decimal(New Integer() {240, 0, 0, 0})
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Location = New System.Drawing.Point(599, 97)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(57, 17)
        Me.lblMinutos.TabIndex = 11
        Me.lblMinutos.Text = "minutos"
        '
        'lblTonoNotificacion
        '
        Me.lblTonoNotificacion.AutoSize = True
        Me.lblTonoNotificacion.Location = New System.Drawing.Point(602, 13)
        Me.lblTonoNotificacion.Name = "lblTonoNotificacion"
        Me.lblTonoNotificacion.Size = New System.Drawing.Size(142, 17)
        Me.lblTonoNotificacion.TabIndex = 12
        Me.lblTonoNotificacion.Text = "Tono de Notificación:"
        '
        'cmbTonoNotificacion
        '
        Me.cmbTonoNotificacion.FormattingEnabled = True
        Me.cmbTonoNotificacion.Items.AddRange(New Object() {"Ding"})
        Me.cmbTonoNotificacion.Location = New System.Drawing.Point(614, 33)
        Me.cmbTonoNotificacion.Name = "cmbTonoNotificacion"
        Me.cmbTonoNotificacion.Size = New System.Drawing.Size(117, 24)
        Me.cmbTonoNotificacion.TabIndex = 13
        '
        'lblRepeticionNotificacion
        '
        Me.lblRepeticionNotificacion.AutoSize = True
        Me.lblRepeticionNotificacion.Location = New System.Drawing.Point(610, 67)
        Me.lblRepeticionNotificacion.Name = "lblRepeticionNotificacion"
        Me.lblRepeticionNotificacion.Size = New System.Drawing.Size(79, 17)
        Me.lblRepeticionNotificacion.TabIndex = 14
        Me.lblRepeticionNotificacion.Text = "Repetición:"
        '
        'nudRepeticionNotificacion
        '
        Me.nudRepeticionNotificacion.Location = New System.Drawing.Point(695, 67)
        Me.nudRepeticionNotificacion.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudRepeticionNotificacion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRepeticionNotificacion.Name = "nudRepeticionNotificacion"
        Me.nudRepeticionNotificacion.Size = New System.Drawing.Size(78, 22)
        Me.nudRepeticionNotificacion.TabIndex = 15
        Me.nudRepeticionNotificacion.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'chkImprimirPedidos
        '
        Me.chkImprimirPedidos.AutoSize = True
        Me.chkImprimirPedidos.Location = New System.Drawing.Point(667, 97)
        Me.chkImprimirPedidos.Name = "chkImprimirPedidos"
        Me.chkImprimirPedidos.Size = New System.Drawing.Size(209, 21)
        Me.chkImprimirPedidos.TabIndex = 16
        Me.chkImprimirPedidos.Text = "Imprimir pedidos al recibirlos"
        Me.chkImprimirPedidos.UseVisualStyleBackColor = True
        '
        'PanelAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1826, 505)
        Me.Controls.Add(Me.pnlContenido)
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
        CType(Me.nudCierrePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRepeticionNotificacion, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class


