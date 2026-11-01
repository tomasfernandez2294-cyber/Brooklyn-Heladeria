Imports MySql.Data.MySqlClient
Public Class PanelAdm

    Private categorias As New List(Of NombreCategoria)
    Private productos As New List(Of Producto)
    Private sabores As New List(Of Sabor)
    Private productosSabores As New List(Of ProductoSabor)
    Private metodosPago As New List(Of MetodoPago)
    Private metodosEntrega As New List(Of MetodoEntrega)
    Private clientes As New List(Of Cliente)
    Private opcionales As New List(Of Opcional)
    Private productosOpcionales As New List(Of ProductoOpcional)
    Private notificacionSonora As Boolean = True
    Private imprimirPedidos As Boolean = False
    Private cierrePedidos As Integer = 240
    Private tonoNotificacion As String = "Ding"
    Private dondeRecibirPedidos As String = "Solo en panel"
    Private preparacionEstimada As Integer = 30
    Private proximoIdProducto As Integer = 1
    Private proximoIdSabor As Integer = 1
    Private proximoIdMetodoPago As Integer = 1
    Private proximoIdMetodoEntrega As Integer = 1
    Private proximoIdCliente As Integer = 1
    Private proximoIdOpcional As Integer = 1
    Private repeticionNotificacion As Integer = 2

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click

        pnlCategorias.Visible = True
        pnlProductos.Visible = False
        pnlSabores.Visible = False
        pnlConfiguracion.Visible = False
        pnlClientes.Visible = False
        pnlOpcionales.Visible = False

        pnlCategorias.BringToFront()
        lblSeccion.Text = "Gestión de Categorías"
    End Sub

    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click

        If txtNombreCategoria.Text = "" Then
            MessageBox.Show("Ingrese un nombre de categoría")
            Exit Sub
        End If

        Dim categoria As New NombreCategoria()
        categoria.NombreCategoria = txtNombreCategoria.Text
        categoria.Activo = True

        If CategoriaDAO.Agregar(categoria) Then

            categorias.Add(categoria)

            lstCategorias.Items.Add(categoria.NombreCategoria)
            cmbCategorias.Items.Add(categoria.NombreCategoria)

            MessageBox.Show("Categoría agregada correctamente")

        End If

        txtNombreCategoria.Clear()

    End Sub

    Private Sub lstCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCategorias.SelectedIndexChanged
        If lstCategorias.SelectedIndex >= 0 Then

            Dim categoriaSeleccionada As NombreCategoria = categorias(lstCategorias.SelectedIndex)
            MessageBox.Show("Categoria seleccionada: " & categoriaSeleccionada.NombreCategoria)
        End If
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click

        If txtNombreProducto.Text = "" Then
            MessageBox.Show("Ingrese el nombre del producto")
            Exit Sub
        End If

        If txtPrecio.Text = "" Then
            MessageBox.Show("Ingrese el precio")
            Exit Sub
        End If

        If cmbCategorias.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una categoría")
            Exit Sub
        End If

        Dim producto As New Producto()

        'producto.IDProducto = proximoIdProducto
        producto.NombreProducto = txtNombreProducto.Text
        producto.Descripcion = txtDescripcion.Text
        producto.Precio = CInt(txtPrecio.Text)
        producto.Categoria = categorias(cmbCategorias.SelectedIndex)
        producto.MaxSabores = CInt(nudMaxSabores.Value)

        'linea de mysql probamos
        Try
            Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()

                conexion.Open()

                Dim sql As String =
            "INSERT INTO PRODUCTO " &
            "(nombre_producto, descripcion_producto, precio, max_sabores) " &
            "VALUES (@nombre, @descripcion, @precio, @maxSabores);"

                Using comando As New MySqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@nombre", producto.NombreProducto)
                    comando.Parameters.AddWithValue("@descripcion", producto.Descripcion)
                    comando.Parameters.AddWithValue("@precio", producto.Precio)
                    comando.Parameters.AddWithValue("@maxSabores", producto.MaxSabores)

                    comando.ExecuteNonQuery()

                    'Tomamos el ID que generó MySQL
                    producto.IDProducto = CInt(comando.LastInsertedId)

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar producto en la base de datos: " &
                    ex.Message)
            Exit Sub
        End Try

        productos.Add(producto)

        For Each indice As Integer In clbSabores.CheckedIndices
            Dim productoSabor As New ProductoSabor()

            productoSabor.IDProducto = producto.IDProducto
            productoSabor.IDSabor = sabores(indice).IDSabor

            productosSabores.Add(productoSabor)
        Next

        lstProductos.Items.Add(producto.IDProducto & " - " &
        producto.NombreProducto & " - $" &
        producto.Precio & " - Máx. " &
        producto.MaxSabores & " sabores")
        'proximoIdProducto += 1
        MessageBox.Show("Producto agregado correctamente")

        txtNombreProducto.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()

        For i As Integer = 0 To clbSabores.Items.Count - 1
            clbSabores.SetItemChecked(i, False)
        Next

    End Sub

    Private Sub lstProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductos.SelectedIndexChanged
        If lstProductos.SelectedIndex >= 0 Then

            Dim producto As Producto = productos(lstProductos.SelectedIndex)

            txtNombreProducto.Text = producto.NombreProducto
            txtDescripcion.Text = producto.Descripcion
            txtPrecio.Text = producto.Precio.ToString()
            nudMaxSabores.Value = producto.MaxSabores

            cmbCategorias.SelectedItem = producto.Categoria.NombreCategoria

            'Desmarcar todos los sabores
            For i As Integer = 0 To clbSabores.Items.Count - 1
                clbSabores.SetItemChecked(i, False)
            Next

            'Marcar los sabores asociados al producto
            For Each productoSabor As ProductoSabor In productosSabores

                If productoSabor.IDProducto = producto.IDProducto Then

                    For i As Integer = 0 To sabores.Count - 1

                        If sabores(i).IDSabor = productoSabor.IDSabor Then
                            clbSabores.SetItemChecked(i, True)
                        End If

                    Next

                End If

            Next


            'Cargar opcionales con el precio correspondiente al producto
            clbOpcionalesProducto.Items.Clear()

            For Each itemOpcional As Opcional In opcionales

                Dim precioMostrar As Integer = itemOpcional.Precio

                'Buscar si este producto tiene un precio específico
                For Each productoOpcional As ProductoOpcional In productosOpcionales

                    If productoOpcional.IDProducto = producto.IDProducto AndAlso
                   productoOpcional.IDOpcional = itemOpcional.IDOpcional Then

                        precioMostrar = productoOpcional.Precio
                        Exit For

                    End If

                Next

                clbOpcionalesProducto.Items.Add(
                itemOpcional.Nombre & " - $" & precioMostrar
            )

            Next


            'Marcar los opcionales asociados al producto
            For Each productoOpcional As ProductoOpcional In productosOpcionales

                If productoOpcional.IDProducto = producto.IDProducto Then

                    For i As Integer = 0 To opcionales.Count - 1

                        If opcionales(i).IDOpcional = productoOpcional.IDOpcional Then
                            clbOpcionalesProducto.SetItemChecked(i, True)
                        End If

                    Next

                End If

            Next

        End If

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click

        pnlCategorias.Visible = False
        pnlProductos.Visible = True
        pnlSabores.Visible = False
        pnlConfiguracion.Visible = False
        pnlClientes.Visible = False
        pnlOpcionales.Visible = False

        pnlProductos.BringToFront()
        lblSeccion.Text = "Gestión de Productos"
    End Sub

    Private Sub btnAgregarSabor_Click(sender As Object, e As EventArgs) Handles btnAgregarSabor.Click
        If txtNombreSabor.Text = " " Then
            MessageBox.Show("Ingrese el nombre del sabor")
            Exit Sub
        End If
        ' posible correccion 
        ' If String.IsNullOrWhiteSpace(txtNombreSabor.Text) Then
        ' MessageBox.Show("Ingrese el nombre del sabor")
        ' Exit Sub
        ' End If
        Dim sabor As New Sabor()

        sabor.IDSabor = proximoIdSabor
        sabor.NombreSabor = txtNombreSabor.Text
        sabor.Descripcion = txtDescripcion.Text
        sabor.Activo = True

        sabores.Add(sabor)

        lstSabores.Items.Add(sabor.IDSabor & " - " & sabor.NombreSabor)
        clbSabores.Items.Add(sabor.NombreSabor)

        proximoIdSabor += 1

        MessageBox.Show("Sabor agregado correctamente")

        txtNombreSabor.Clear()
        txtDescripcion.Clear()

    End Sub

    Private Sub btnSabores_Click(sender As Object, e As EventArgs) Handles btnSabores.Click

        pnlCategorias.Visible = False
        pnlProductos.Visible = False
        pnlSabores.Visible = True
        pnlConfiguracion.Visible = False
        pnlClientes.Visible = False
        pnlOpcionales.Visible = False

        pnlSabores.BringToFront()
        lblSeccion.Text = "Gestión de Sabores"

    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click

        pnlCategorias.Visible = False
        pnlProductos.Visible = False
        pnlSabores.Visible = False
        pnlConfiguracion.Visible = True
        pnlClientes.Visible = False
        pnlOpcionales.Visible = False

        pnlConfiguracion.BringToFront()
        lblSeccion.Text = "Gestión de Configuración"

    End Sub

    Private Sub btnAgregarMetodoPago_Click(sender As Object, e As EventArgs) Handles btnAgregarMetodoPago.Click
        Dim formulario As New FormMetodoPago()
        If formulario.ShowDialog() = DialogResult.OK Then

            Dim metodo As MetodoPago = formulario.MetodoCreado
            metodo.IDMetodoPago = proximoIdMetodoPago
            metodosPago.Add(metodo)

            Dim estado As String
            If metodo.Habilitado Then
                estado = "Habilitado"
            Else
                estado = "Deshabilitado"
            End If

            lstMetodosPago.Items.Add(metodo.Nombre & " - " & metodo.Tipo & " - " & estado)

        End If
    End Sub

    Private Sub btnAgregarMetodoEntrega_Click(sender As Object, e As EventArgs) Handles btnAgregarMetodoEntrega.Click

        Dim formulario As New FormMetodoEntrega()
        If formulario.ShowDialog() = DialogResult.OK Then
            Dim metodo As MetodoEntrega = formulario.MetodoCreado
            metodo.IDMetodoEntrega = proximoIdMetodoEntrega
            metodosEntrega.Add(metodo)

            Dim estado As String
            If metodo.Habilitado Then
                estado = "Habilitado"
            Else
                estado = "Deshabilitado"
            End If

            lstMetodosEntrega.Items.Add(metodo.Nombre & " - " & metodo.Tipo & " - " & estado)

        End If

    End Sub

    Private Sub btnCambiarEstadoPago_Click(sender As Object, e As EventArgs) Handles btnCambiarEstadoPago.Click

        If lstMetodosPago.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un método de pago")
            Exit Sub
        End If

        Dim metodo As MetodoPago = metodosPago(lstMetodosPago.SelectedIndex)
        metodo.Habilitado = Not metodo.Habilitado
        Dim estado As String

        If metodo.Habilitado Then
            estado = "Habilitado"
        Else
            estado = "Deshabilitado"
        End If

        lstMetodosPago.Items(lstMetodosPago.SelectedIndex) =
        metodo.Nombre & " - " & metodo.Tipo & " - " & estado

    End Sub

    Private Sub btnCambiarEstadoEntrega_Click(sender As Object, e As EventArgs) Handles btnCambiarEstadoEntrega.Click

        If lstMetodosEntrega.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un método de entrega")
            Exit Sub
        End If

        Dim metodo As MetodoEntrega = metodosEntrega(lstMetodosEntrega.SelectedIndex)
        metodo.Habilitado = Not metodo.Habilitado
        Dim estado As String

        If metodo.Habilitado Then
            estado = "Habilitado"
        Else
            estado = "Deshabilitado"
        End If

        lstMetodosEntrega.Items(lstMetodosEntrega.SelectedIndex) =
            metodo.Nombre & " - " & metodo.Tipo & " - " & estado

    End Sub

    Private Sub btnEditarMetodoPago_Click(sender As Object, e As EventArgs) Handles btnEditarMetodoPago.Click

        If lstMetodosPago.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un método de pago")
            Exit Sub
        End If

        Dim metodo As MetodoPago = metodosPago(lstMetodosPago.SelectedIndex)
        Dim formulario As New FormMetodoPago()

        formulario.MetodoEditar = metodo

        formulario.txtNombre.Text = metodo.Nombre
        formulario.cmbTipo.Text = metodo.Tipo
        formulario.chkHabilitado.Checked = metodo.Habilitado
        formulario.txtRecargoDescuento.Text = metodo.RecargoDescuento.ToString()

        If formulario.ShowDialog() = DialogResult.OK Then
            Dim estado As String

            If metodo.Habilitado Then
                estado = "Habilitado"
            Else
                estado = "Deshabilitado"
            End If

            lstMetodosPago.Items(lstMetodosPago.SelectedIndex) =
                    metodo.Nombre & " - " & metodo.Tipo & " - " & estado
        End If

    End Sub

    Private Sub btnEditarMetodoEntrega_Click(sender As Object, e As EventArgs) Handles btnEditarMetodoEntrega.Click

        If lstMetodosEntrega.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un método de entrega")
            Exit Sub
        End If

        Dim metodo As MetodoEntrega = metodosEntrega(lstMetodosEntrega.SelectedIndex)
        Dim formulario As New FormMetodoEntrega()

        formulario.metodoEditar = metodo

        formulario.txtNombre.Text = metodo.Nombre
        formulario.cmbTipo.Text = metodo.Tipo
        formulario.chkHabilitado.Checked = metodo.Habilitado
        formulario.chkPermitirPedidos.Checked = CBool(metodo.PermitirPedidos)
        formulario.chkSolicitarEntreCalles.Checked = metodo.SolicitarEntreCalles
        formulario.txtRecargoDescuento.Text = metodo.RecargoDescuento.ToString()

        If formulario.ShowDialog() = DialogResult.OK Then
            Dim estado As String

            If metodo.Habilitado Then
                estado = "Habilitado"
            Else
                estado = "Deshabilitado"
            End If

            lstMetodosEntrega.Items(lstMetodosEntrega.SelectedIndex) =
                metodo.Nombre & " - " & metodo.Tipo & " - " & estado
        End If

    End Sub

    Private Sub btnEliminarMetodoPago_Click(sender As Object, e As EventArgs) Handles btnEliminarMetodoPago.Click

        If lstMetodosPago.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un método de pago")
            Exit Sub
        End If

        Dim indice As Integer = lstMetodosPago.SelectedIndex
        Dim metodo As MetodoPago = metodosPago(indice)

        Dim respuesta As DialogResult =
            MessageBox.Show("¿Está seguro de eliminar el método de pago '" &
            metodo.Nombre & "'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            metodosPago.RemoveAt(indice)
            lstMetodosPago.Items.RemoveAt(indice)

            MessageBox.Show("Método de pago eliminado correctamente")
        End If
    End Sub

    Private Sub btnEliminarMetodoEntrega_Click(sender As Object, e As EventArgs) Handles btnEliminarMetodoEntrega.Click

        If lstMetodosEntrega.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un método de entrega")
            Exit Sub
        End If

        Dim indice As Integer = lstMetodosEntrega.SelectedIndex
        Dim metodo As MetodoEntrega = metodosEntrega(indice)

        Dim respuesta As DialogResult =
            MessageBox.Show("¿Está seguro de eliminar el método de entrega '" &
            metodo.Nombre & "'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            metodosEntrega.RemoveAt(indice)
            lstMetodosEntrega.Items.RemoveAt(indice)

            MessageBox.Show("Método de entrega eliminado correctamente")
        End If
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click

        pnlCategorias.Visible = False
        pnlProductos.Visible = False
        pnlSabores.Visible = False
        pnlOpcionales.Visible = False
        pnlConfiguracion.Visible = False
        pnlClientes.Visible = True
        pnlClientes.BringToFront()

        lblSeccion.Text = "Gestión de Clientes"
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        If txtNombreCliente.Text = "" Then
            MessageBox.Show("Ingrese el nombre del cliente")
            Exit Sub
        End If

        If txtApellidoCliente.Text = "" Then
            MessageBox.Show("Ingrese el apellido del cliente")
            Exit Sub
        End If

        If txtDniCliente.Text = "" Then
            MessageBox.Show("Ingrese el DNI del cliente")
            Exit Sub
        End If

        If txtTelefonoCliente.Text = "" Then
            MessageBox.Show("Ingrese el teléfono del cliente")
            Exit Sub
        End If

        If txtEmailCliente.Text = "" Then
            MessageBox.Show("Ingrese el email del cliente")
            Exit Sub
        End If

        Dim cliente As New Cliente()

        cliente.IDCliente = proximoIdCliente
        cliente.Nombre = txtNombreCliente.Text
        cliente.Apellido = txtApellidoCliente.Text
        cliente.DNI = txtDniCliente.Text
        cliente.Telefono = txtTelefonoCliente.Text
        cliente.Email = txtEmailCliente.Text
        cliente.Habilitado = True

        clientes.Add(cliente)

        lstClientes.Items.Add(cliente.IDCliente & " - " & cliente.Nombre & " " & cliente.Apellido & " - DNI: " & cliente.DNI)

        proximoIdCliente += 1
        MessageBox.Show("Cliente agregado correctamente")

        txtNombreCliente.Clear()
        txtApellidoCliente.Clear()
        txtDniCliente.Clear()
        txtTelefonoCliente.Clear()
        txtEmailCliente.Clear()
    End Sub

    Private Sub lstClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClientes.SelectedIndexChanged
        If lstClientes.SelectedIndex >= 0 Then

            Dim cliente As Cliente = clientes(lstClientes.SelectedIndex)

            txtNombreCliente.Text = cliente.Nombre
            txtApellidoCliente.Text = cliente.Apellido
            txtDniCliente.Text = cliente.DNI
            txtTelefonoCliente.Text = cliente.Telefono
            txtEmailCliente.Text = cliente.Email

        End If
    End Sub

    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click

        If lstClientes.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un cliente")
            Exit Sub
        End If

        If txtNombreCliente.Text = "" Then
            MessageBox.Show("Ingrese el nombre del cliente")
            Exit Sub
        End If

        If txtApellidoCliente.Text = "" Then
            MessageBox.Show("Ingrese el apellido del cliente")
            Exit Sub
        End If

        If txtDniCliente.Text = "" Then
            MessageBox.Show("Ingrese el DNI del cliente")
            Exit Sub
        End If

        If txtTelefonoCliente.Text = "" Then
            MessageBox.Show("Ingrese el teléfono del cliente")
            Exit Sub
        End If

        If txtEmailCliente.Text = "" Then
            MessageBox.Show("Ingrese el email del cliente")
            Exit Sub
        End If

        Dim indice As Integer = lstClientes.SelectedIndex
        Dim cliente As Cliente = clientes(indice)

        cliente.Nombre = txtNombreCliente.Text
        cliente.Apellido = txtApellidoCliente.Text
        cliente.DNI = txtDniCliente.Text
        cliente.Telefono = txtTelefonoCliente.Text
        cliente.Email = txtEmailCliente.Text

        lstClientes.Items(indice) =
            cliente.IDCliente & " - " &
            cliente.Nombre & " " &
            cliente.Apellido & " - DNI: " &
            cliente.DNI

        MessageBox.Show("Cliente actualizado correctamente")
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click

        If lstClientes.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un cliente")
            Exit Sub
        End If

        Dim indice As Integer = lstClientes.SelectedIndex
        Dim cliente As Cliente = clientes(indice)

        Dim respuesta As DialogResult =
            MessageBox.Show("¿Está seguro de eliminar al cliente '" &
                            cliente.Nombre & " " & cliente.Apellido & "'?",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then

            clientes.RemoveAt(indice)
            lstClientes.Items.RemoveAt(indice)

            MessageBox.Show("Cliente eliminado correctamente")

            txtNombreCliente.Clear()
            txtApellidoCliente.Clear()
            txtDniCliente.Clear()
            txtTelefonoCliente.Clear()
            txtEmailCliente.Clear()

        End If
    End Sub

    Private Sub btnEditarProducto_Click(sender As Object, e As EventArgs) Handles btnEditarProducto.Click
        If lstProductos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un producto")
            Exit Sub
        End If

        If txtNombreProducto.Text = "" Then
            MessageBox.Show("Ingrese el nombre del producto")
            Exit Sub
        End If

        If txtPrecio.Text = "" Then
            MessageBox.Show("Ingrese el precio")
            Exit Sub
        End If

        If cmbCategorias.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una categoría")
            Exit Sub
        End If

        Dim indice As Integer = lstProductos.SelectedIndex
        Dim producto As Producto = productos(indice)

        producto.NombreProducto = txtNombreProducto.Text
        producto.Descripcion = txtDescripcion.Text
        producto.Precio = CInt(txtPrecio.Text)
        producto.Categoria = categorias(cmbCategorias.SelectedIndex)
        producto.MaxSabores = CInt(nudMaxSabores.Value)

        'Actualizar sabores del producto
        For i As Integer = productosSabores.Count - 1 To 0 Step -1

            If productosSabores(i).IDProducto = producto.IDProducto Then
                productosSabores.RemoveAt(i)
            End If

        Next

        For Each indiceSabor As Integer In clbSabores.CheckedIndices

            Dim productoSabor As New ProductoSabor()

            productoSabor.IDProducto = producto.IDProducto
            productoSabor.IDSabor = sabores(indiceSabor).IDSabor

            productosSabores.Add(productoSabor)

        Next

        lstProductos.Items(indice) =
            producto.IDProducto & " - " &
            producto.NombreProducto & " - $" &
            producto.Precio & " - Máx. " &
            producto.MaxSabores & " sabores"

        MessageBox.Show("Producto actualizado correctamente")
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If lstProductos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un producto")
            Exit Sub
        End If

        Dim indice As Integer = lstProductos.SelectedIndex
        Dim producto As Producto = productos(indice)

        Dim respuesta As DialogResult =
        MessageBox.Show(
            "¿Está seguro de eliminar el producto '" &
            producto.NombreProducto & "'?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then

            'Eliminar relaciones con sabores
            For i As Integer = productosSabores.Count - 1 To 0 Step -1

                If productosSabores(i).IDProducto = producto.IDProducto Then
                    productosSabores.RemoveAt(i)
                End If

            Next

            'Eliminar producto
            productos.RemoveAt(indice)

            'Eliminarlo de la lista visual
            lstProductos.Items.RemoveAt(indice)

            MessageBox.Show("Producto eliminado correctamente")

            'Limpiar campos
            txtNombreProducto.Clear()
            txtDescripcion.Clear()
            txtPrecio.Clear()

            For i As Integer = 0 To clbSabores.Items.Count - 1
                clbSabores.SetItemChecked(i, False)
            Next

        End If

    End Sub

    Private Sub PanelAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbGrupoOpcional.Items.Add("Salsas adicionales")
        cmbGrupoOpcional.Items.Add("Baño de chocolate Águila")

    End Sub

    Private Sub btnOpcionales_Click(sender As Object, e As EventArgs) Handles btnOpcionales.Click

        pnlCategorias.Visible = False
        pnlProductos.Visible = False
        pnlSabores.Visible = False
        pnlConfiguracion.Visible = False
        pnlClientes.Visible = False
        pnlOpcionales.Visible = True

        pnlOpcionales.BringToFront()

        lblSeccion.Text = "Gestión de Opcionales"

    End Sub

    Private Sub btnAgregarOpcional_Click(sender As Object, e As EventArgs) Handles btnAgregarOpcional.Click

        If txtNombreOpcional.Text = "" Then
            MessageBox.Show("Ingrese el nombre del opcional")
            Exit Sub
        End If

        If txtPrecioOpcional.Text = "" Then
            MessageBox.Show("Ingrese el precio")
            Exit Sub
        End If

        If cmbGrupoOpcional.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un grupo")
            Exit Sub
        End If

        Dim precio As Integer

        If Not Integer.TryParse(txtPrecioOpcional.Text, precio) OrElse precio < 0 Then
            MessageBox.Show("Ingrese un precio válido")
            Exit Sub
        End If

        Dim opcional As New Opcional()

        opcional.IDOpcional = proximoIdOpcional
        opcional.Nombre = txtNombreOpcional.Text
        opcional.Precio = precio
        opcional.Grupo = cmbGrupoOpcional.Text
        opcional.Activo = True

        opcionales.Add(opcional)

        lstOpcionales.Items.Add(
            opcional.IDOpcional & " - " &
            opcional.Nombre & " - " &
            opcional.Grupo & " - $" &
            opcional.Precio
        )

        proximoIdOpcional += 1

        MessageBox.Show("Opcional agregado correctamente")

        txtNombreOpcional.Clear()
        txtPrecioOpcional.Clear()
        cmbGrupoOpcional.SelectedIndex = -1
        CargarOpcionalesEnProductos()
    End Sub

    Private Sub CargarOpcionalesEnProductos()

        clbOpcionalesProducto.Items.Clear()

        For Each itemOpcional As Opcional In opcionales
            Dim precioMostrar As Integer = itemOpcional.Precio

            'Si hay un producto seleccionado,
            'buscar si tiene un precio específico para este opcional
            If lstProductos.SelectedIndex >= 0 Then

                Dim productoSeleccionado As Producto =
                productos(lstProductos.SelectedIndex)

                For Each productoOpcional As ProductoOpcional In productosOpcionales
                    If productoOpcional.IDProducto = productoSeleccionado.IDProducto AndAlso
                   productoOpcional.IDOpcional = itemOpcional.IDOpcional Then

                        precioMostrar = productoOpcional.Precio
                        Exit For

                    End If

                Next

            End If
            clbOpcionalesProducto.Items.Add(itemOpcional.Nombre & " - $" & precioMostrar)

        Next
    End Sub

    Private Sub btnGuardarOpcionales_Click(sender As Object, e As EventArgs) Handles btnGuardarOpcionales.Click
        If lstProductos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un producto")
            Exit Sub
        End If

        Dim producto As Producto = productos(lstProductos.SelectedIndex)
        'Validar maximo de opcionales por grupo
        Dim cantidadesPorGrupo As New Dictionary(Of String, Integer)
        For Each indice As Integer In clbOpcionalesProducto.CheckedIndices
            Dim opcional As Opcional = opcionales(indice)

            If Not cantidadesPorGrupo.ContainsKey(opcional.Grupo) Then
                cantidadesPorGrupo.Add(opcional.Grupo, 0)
            End If
            cantidadesPorGrupo(opcional.Grupo) += 1
        Next

        For Each grupo As String In cantidadesPorGrupo.Keys
            If cantidadesPorGrupo(grupo) > nudMaxOpcionales.Value Then
                MessageBox.Show("No puede seleccionar más de " & nudMaxOpcionales.Value & " opcional(es) del grupo '" & grupo & "'.")
                Exit Sub
            End If
        Next
        'Eliminar asociaciones anteriores de este producto
        For i As Integer = productosOpcionales.Count - 1 To 0 Step -1
            If productosOpcionales(i).IDProducto = producto.IDProducto Then
                productosOpcionales.RemoveAt(i)
            End If
        Next

        'Guardar los opcionales seleccionados
        For Each indice As Integer In clbOpcionalesProducto.CheckedIndices

            Dim opcional As Opcional = opcionales(indice)

            Dim productoOpcional As New ProductoOpcional()

            productoOpcional.IDProducto = producto.IDProducto
            productoOpcional.IDOpcional = opcional.IDOpcional
            productoOpcional.Precio = opcional.Precio
            productoOpcional.MaxSeleccion = CInt(nudMaxOpcionales.Value)
            productoOpcional.Grupo = opcional.Grupo

            productosOpcionales.Add(productoOpcional)

        Next

        MessageBox.Show("Opcionales guardados correctamente")
    End Sub

    Private Sub clbOpcionalesProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbOpcionalesProducto.SelectedIndexChanged
        If clbOpcionalesProducto.SelectedIndex >= 0 Then
            Dim opcional As Opcional = opcionales(clbOpcionalesProducto.SelectedIndex)

            txtPrecioOpcionalProducto.Text = opcional.Precio.ToString()
        End If

    End Sub

    Private Sub btnGuardarPrecioOpcional_Click(sender As Object, e As EventArgs) Handles btnGuardarPrecioOpcional.Click
        If lstProductos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un producto")
            Exit Sub
        End If

        If clbOpcionalesProducto.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un opcional")
            Exit Sub
        End If

        Dim precio As Integer

        If Not Integer.TryParse(txtPrecioOpcionalProducto.Text, precio) OrElse precio < 0 Then
            MessageBox.Show("Ingrese un precio válido")
            Exit Sub
        End If

        Dim producto As Producto = productos(lstProductos.SelectedIndex)
        Dim opcional As Opcional =
            opcionales(clbOpcionalesProducto.SelectedIndex)

        Dim encontrado As Boolean = False

        For Each productoOpcional As ProductoOpcional In productosOpcionales

            If productoOpcional.IDProducto = producto.IDProducto AndAlso
               productoOpcional.IDOpcional = opcional.IDOpcional Then

                productoOpcional.Precio = precio
                encontrado = True
                Exit For

            End If

        Next

        If Not encontrado Then
            MessageBox.Show("Primero debe asignar el opcional al producto")
            Exit Sub
        End If

        MessageBox.Show("Precio del opcional actualizado correctamente")
    End Sub

    Private Sub btnGuardarConfiguracionPedidos_Click(sender As Object, e As EventArgs) Handles btnGuardarConfiguracionPedidos.Click
        If rdbSoloWhatsapp.Checked Then
            dondeRecibirPedidos = "Solo en Whatsapp"
        ElseIf rdbSoloPanel.Checked Then
            dondeRecibirPedidos = "Solo en panel"
        ElseIf rdbPanelWhatsapp.Checked Then
            dondeRecibirPedidos = "Panel y Whatsapp"
        End If
        preparacionEstimada = CInt(nudPreparacionEstimada.Value)

        notificacionSonora = chkNotificacionSonora.Checked
        imprimirPedidos = chkImprimirPedidos.Checked
        cierrePedidos = CInt(nudCierrePedidos.Value)
        tonoNotificacion = cmbTonoNotificacion.Text
        repeticionNotificacion = CInt(nudRepeticionNotificacion.Value)

        MessageBox.Show(
    "Configuración guardada correctamente." & vbCrLf &
    "Pedidos: " & dondeRecibirPedidos & vbCrLf &
    "Preparación: " & preparacionEstimada & " minutos" & vbCrLf &
    "Notificación sonora: " & If(notificacionSonora, "Sí", "No") & vbCrLf &
    "Imprimir pedidos: " & If(imprimirPedidos, "Sí", "No") & vbCrLf &
    "Cierre de pedidos: " & cierrePedidos & " minutos" & vbCrLf &
    "Tono: " & tonoNotificacion & vbCrLf &
    "Repetición: " & repeticionNotificacion)

    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click

        Dim frm As New FormPedidos()
        frm.Show()

    End Sub

    Private Sub btnVerCliente_Click(sender As Object, e As EventArgs) Handles btnVerCliente.Click

        Dim frm As New FormCliente()
        frm.Show()

    End Sub
End Class