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

    ' CARGAR PRODUCTOS DESDE MYSQL
    Private Sub CargarProductosDesdeBD()

        Dim productosBD As List(Of Producto) =
        ProductoDAO.Listar()

        productos.Clear()
        lstProductos.Items.Clear()

        For Each producto As Producto In productosBD

            If producto.Activo Then

                productos.Add(producto)

                lstProductos.Items.Add(
                producto.NombreProducto)

            End If

        Next

    End Sub

    'metodo para las categorias de la DB
    Private Sub CargarCategoriasDesdeBD()

        Dim categoriasBD As List(Of NombreCategoria) =
        CategoriaDAO.Listar()

        categorias.Clear()
        lstCategorias.Items.Clear()
        clbCategorias.Items.Clear()

        For Each categoria As NombreCategoria In categoriasBD

            If categoria.Activo Then

                categorias.Add(categoria)

                lstCategorias.Items.Add(
                categoria.NombreCategoria)

                clbCategorias.Items.Add(
                categoria.NombreCategoria)

            End If

        Next

    End Sub


    'boton categoria
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


    ' BOTÓN AGREGAR CATEGORÍA
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click

        Dim nombre As String = txtNombreCategoria.Text.Trim()

        If String.IsNullOrWhiteSpace(nombre) Then
            MessageBox.Show("Ingrese un nombre de categoría")
            Exit Sub
        End If

        Dim categoria As New NombreCategoria()

        categoria.NombreCategoria = nombre
        categoria.Activo = True

        If CategoriaDAO.Agregar(categoria) Then

            categorias.Add(categoria)

            lstCategorias.Items.Add(categoria.NombreCategoria)
            clbCategorias.Items.Add(categoria.NombreCategoria)

            MessageBox.Show("Categoría agregada correctamente")

            txtNombreCategoria.Clear()

        End If

    End Sub


    'boton modificar categoria
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If lstCategorias.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una categoría")
            Exit Sub
        End If

        Dim nombreNuevo As String = txtNombreCategoria.Text.Trim()

        If String.IsNullOrWhiteSpace(nombreNuevo) Then
            MessageBox.Show("Ingrese el nombre de la categoría")
            Exit Sub
        End If

        Dim indice As Integer = lstCategorias.SelectedIndex
        Dim categoria As NombreCategoria = categorias(indice)

        Dim nombreAnterior As String = categoria.NombreCategoria

        Try
            categoria.NombreCategoria = nombreNuevo

            If CategoriaDAO.Modificar(categoria) Then

                lstCategorias.Items(indice) = categoria.NombreCategoria
                clbCategorias.Items(indice) = categoria.NombreCategoria

                MessageBox.Show("Categoría modificada correctamente en MySQL")

            Else

                categoria.NombreCategoria = nombreAnterior
                MessageBox.Show("No se pudo modificar la categoría")

            End If

        Catch ex As Exception

            categoria.NombreCategoria = nombreAnterior

            MessageBox.Show(
            "Error al modificar categoría: " & ex.Message)

        End Try

    End Sub


    ' BOTÓN ELIMINAR / DESACTIVAR CATEGORÍA
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If lstCategorias.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una categoría")
            Exit Sub
        End If

        Dim indice As Integer = lstCategorias.SelectedIndex
        Dim categoria As NombreCategoria = categorias(indice)

        ' VERIFICAR PRODUCTOS ASOCIADOS
        For Each producto As Producto In productos

            If producto.Categoria IsNot Nothing AndAlso
           producto.Categoria.IDCategoria = categoria.IDCategoria Then

                MessageBox.Show(
                "No se puede dar de baja esta categoría porque tiene productos asociados.")
                Exit Sub

            End If

        Next

        ' CONFIRMAR BAJA
        Dim respuesta As DialogResult =
        MessageBox.Show(
            "¿Está seguro de dar de baja la categoría '" &
            categoria.NombreCategoria & "'?",
            "Confirmar baja",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If respuesta <> DialogResult.Yes Then Exit Sub

        ' DESACTIVAR EN MYSQL
        If CategoriaDAO.Desactivar(categoria.IDCategoria) Then

            categoria.Activo = False

            categorias.RemoveAt(indice)
            lstCategorias.Items.RemoveAt(indice)
            clbCategorias.Items.RemoveAt(indice)

            txtNombreCategoria.Clear()

            MessageBox.Show(
            "Categoría desactivada correctamente en MySQL.")

        Else

            MessageBox.Show(
            "No se pudo desactivar la categoría.")

        End If

    End Sub


    Private Sub lstCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCategorias.SelectedIndexChanged
        If lstCategorias.SelectedIndex >= 0 Then

            Dim categoriaSeleccionada As NombreCategoria = categorias(lstCategorias.SelectedIndex)
            MessageBox.Show("Categoria seleccionada: " & categoriaSeleccionada.NombreCategoria)
        End If
    End Sub


    ' BOTÓN AGREGAR PRODUCTO
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click

        If String.IsNullOrWhiteSpace(txtNombreProducto.Text) Then
            MessageBox.Show("Ingrese el nombre del producto")
            Exit Sub
        End If

        Dim precio As Decimal

        If Not Decimal.TryParse(txtPrecio.Text, precio) OrElse precio < 0D Then
            MessageBox.Show("Ingrese un precio válido")
            Exit Sub
        End If

        If clbCategorias.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una categoría")
            Exit Sub
        End If

        Dim producto As New Producto()

        producto.NombreProducto = txtNombreProducto.Text.Trim()
        producto.Descripcion = txtDescripcion.Text.Trim()
        producto.Precio = precio
        producto.Categoria = categorias(clbCategorias.SelectedIndex)
        producto.MaxSabores = CInt(nudMaxSabores.Value)
        producto.Activo = True

        Try

            ' 1. GUARDAR PRODUCTO EN MYSQL
            If Not ProductoDAO.Agregar(producto) Then
                MessageBox.Show("No se pudo agregar el producto.")
                Exit Sub
            End If

            ' 2. GUARDAR CATEGORÍA EN MYSQL
            Dim idsCategorias As New List(Of Integer)

            idsCategorias.Add(producto.Categoria.IDCategoria)

            ProductoCategoriaDAO.GuardarCategorias(
            producto.IDProducto, idsCategorias)


            ' 3. PREPARAR SABORES SELECCIONADOS

            Dim idsSabores As New List(Of Integer)
            Dim nuevasRelaciones As New List(Of ProductoSabor)

            For Each indice As Integer In clbSabores.CheckedIndices

                Dim opcion As OpcionSabor =
        CType(clbSabores.Items(indice), OpcionSabor)

                Dim idSabor As Integer = opcion.Sabor.IDSabor

                idsSabores.Add(idSabor)

                Dim relacion As New ProductoSabor()

                relacion.IDProducto = producto.IDProducto
                relacion.IDSabor = idSabor

                nuevasRelaciones.Add(relacion)

            Next


            ' 4. GUARDAR SABORES EN MYSQ

            If Not ProductoSaborDAO.GuardarSabores(
                producto.IDProducto, idsSabores) Then

                MessageBox.Show("No se pudieron guardar los sabores.")
                Exit Sub

            End If

            ' 5. ACTUALIZAR LISTAS EN MEMORIA
            productos.Add(producto)
            productosSabores.AddRange(nuevasRelaciones)

            lstProductos.Items.Add(
            producto.IDProducto & " - " &
            producto.NombreProducto & " - $" &
            producto.Precio & " - Máx. " &
            producto.MaxSabores & " sabores")

            MessageBox.Show("Producto agregado correctamente")

            ' 6. LIMPIAR CAMPOS
            txtNombreProducto.Clear()
            txtDescripcion.Clear()
            txtPrecio.Clear()

            For i As Integer = 0 To clbSabores.Items.Count - 1
                clbSabores.SetItemChecked(i, False)
            Next

        Catch ex As Exception

            MessageBox.Show(
            "Error al guardar producto: " & ex.Message)

        End Try

    End Sub

    REM procedimiento para actualizar la lista productoSabors
    Private Sub lstProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductos.SelectedIndexChanged
        If lstProductos.SelectedIndex >= 0 Then

            Dim producto As Producto = productos(lstProductos.SelectedIndex)

            txtNombreProducto.Text = producto.NombreProducto
            txtDescripcion.Text = producto.Descripcion
            txtPrecio.Text = producto.Precio.ToString()
            nudMaxSabores.Value = producto.MaxSabores

            If producto.Categoria IsNot Nothing Then

                clbCategorias.SelectedItem =
        producto.Categoria.NombreCategoria

            Else

                clbCategorias.SelectedIndex = -1

            End If

            'Desmarcar todos los sabores
            For i As Integer = 0 To clbSabores.Items.Count - 1
                clbSabores.SetItemChecked(i, False)
            Next



            ' MARCAR SABORES ASOCIADOS AL PRODUCTO

            Try

                Dim relaciones As List(Of ProductoSabor) =
        ProductoSaborDAO.ListarPorProducto(producto.IDProducto)

                For Each relacion As ProductoSabor In relaciones

                    For i As Integer = 0 To clbSabores.Items.Count - 1

                        Dim opcion As OpcionSabor =
                CType(clbSabores.Items(i), OpcionSabor)

                        If opcion.Sabor.IDSabor = relacion.IDSabor Then
                            clbSabores.SetItemChecked(i, True)
                        End If

                    Next

                Next

            Catch ex As Exception

                MessageBox.Show(
        "Error al cargar los sabores del producto: " & ex.Message)

            End Try


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
    REM boton productos
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


    ' BOTÓN AGREGAR SABOR
    Private Sub btnAgregarSabor_Click(sender As Object, e As EventArgs) Handles btnAgregarSabor.Click

        ' VALIDAR NOMBRE
        If String.IsNullOrWhiteSpace(txtNombreSabor.Text) Then
            MessageBox.Show("Ingrese el nombre del sabor")
            Exit Sub
        End If

        ' CREAR OBJETO SABOR
        Dim sabor As New Sabor()

        sabor.NombreSabor = txtNombreSabor.Text.Trim()
        sabor.Descripcion = txtDescripcion.Text.Trim()
        sabor.Activo = True
        sabor.Stock = 0

        Try

            ' GUARDAR EN MYSQL
            If Not SaborDAO.Agregar(sabor) Then
                MessageBox.Show("No se pudo guardar el sabor.")
                Exit Sub
            End If

            ' ACTUALIZAR LISTAS EN MEMORIA
            sabores.Add(sabor)

            lstSabores.Items.Add(
            sabor.IDSabor & " - " & sabor.NombreSabor)

            clbSabores.Items.Add(
    New OpcionSabor With {.Sabor = sabor})

            MessageBox.Show("Sabor agregado correctamente en MySQL")

            ' LIMPIAR CAMPOS
            txtNombreSabor.Clear()
            txtDescripcion.Clear()

        Catch ex As Exception

            MessageBox.Show(
            "Error al agregar sabor: " & ex.Message)

        End Try

    End Sub

    REM boton editar sabor

    Private Sub btnEditarSabor_Click(sender As Object, e As EventArgs) Handles btnEditarSabor.Click

        If lstSabores.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un sabor")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtNombreSabor.Text) Then
            MessageBox.Show("Ingrese el nombre del sabor")
            Exit Sub
        End If

        Dim indice As Integer = lstSabores.SelectedIndex
        Dim sabor As Sabor = sabores(indice)

        Dim nombreAnterior As String = sabor.NombreSabor
        Dim descripcionAnterior As String = sabor.Descripcion

        sabor.NombreSabor = txtNombreSabor.Text.Trim()
        sabor.Descripcion = txtDescripcion.Text.Trim()

        Try

            If SaborDAO.Modificar(sabor) Then

                CargarSaboresDesdeBD()

                MessageBox.Show("Sabor modificado correctamente en MySQL")

                txtNombreSabor.Clear()
                txtDescripcion.Clear()

            Else

                sabor.NombreSabor = nombreAnterior
                sabor.Descripcion = descripcionAnterior

                MessageBox.Show("No se pudo modificar el sabor.")

            End If

        Catch ex As Exception

            sabor.NombreSabor = nombreAnterior
            sabor.Descripcion = descripcionAnterior

            MessageBox.Show("Error al modificar sabor: " & ex.Message)

        End Try

    End Sub


    REM boton eliminar sabor

    Private Sub btnEliminarSabor_Click(sender As Object, e As EventArgs) Handles btnEliminarSabor.Click

        If lstSabores.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un sabor")
            Exit Sub
        End If

        Dim indice As Integer = lstSabores.SelectedIndex
        Dim sabor As Sabor = sabores(indice)

        Dim respuesta As DialogResult =
        MessageBox.Show(
            "¿Está seguro de dar de baja el sabor '" &
            sabor.NombreSabor & "'?",
            "Confirmar baja",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If respuesta <> DialogResult.Yes Then Exit Sub

        Try

            If SaborDAO.Eliminar(sabor.IDSabor) Then

                CargarSaboresDesdeBD()

                MessageBox.Show("Sabor dado de baja correctamente en MySQL")

                txtNombreSabor.Clear()
                txtDescripcion.Clear()

            Else

                MessageBox.Show("No se pudo dar de baja el sabor.")

            End If

        Catch ex As Exception

            MessageBox.Show("Error al eliminar sabor: " & ex.Message)

        End Try

    End Sub


    REM boton sabores 
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

    REM boton configuracion
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

    REM boton clientes
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

    REM boton agregar cliente

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click

        If String.IsNullOrWhiteSpace(txtNombreCliente.Text) OrElse
       String.IsNullOrWhiteSpace(txtApellidoCliente.Text) OrElse
       String.IsNullOrWhiteSpace(txtTelefonoCliente.Text) Then

            MessageBox.Show("Complete nombre, apellido y teléfono.")
            Exit Sub

        End If

        Dim cliente As New Cliente()

        cliente.Nombre = txtNombreCliente.Text.Trim()
        cliente.Apellido = txtApellidoCliente.Text.Trim()
        cliente.Telefono = txtTelefonoCliente.Text.Trim()
        cliente.Email = txtEmailCliente.Text.Trim()

        ' FECHA DE NACIMIENTO

        If dtpFechaNacimientoCliente.Checked Then

            cliente.FechaNacimiento =
        dtpFechaNacimientoCliente.Value.Date

        Else

            cliente.FechaNacimiento = Nothing

        End If

        cliente.Habilitado = True

        Try

            If ClienteDAO.Agregar(cliente) Then

                CargarClientesDesdeBD()

                MessageBox.Show("Cliente agregado correctamente en MySQL.")

                txtNombreCliente.Clear()
                txtApellidoCliente.Clear()
                dtpFechaNacimientoCliente.Checked = False
                txtTelefonoCliente.Clear()
                txtEmailCliente.Clear()

            Else

                MessageBox.Show("No se pudo agregar el cliente.")

            End If

        Catch ex As Exception

            MessageBox.Show("Error al agregar cliente: " & ex.Message)

        End Try

    End Sub

    'procedimiento para cargar los clientes de la db 

    Private Sub CargarClientesDesdeBD()

        Try

            Dim clientesBD As List(Of Cliente) = ClienteDAO.Listar()

            clientes.Clear()
            clientes.AddRange(clientesBD)

            lstClientes.Items.Clear()

            For Each cliente As Cliente In clientes

                lstClientes.Items.Add(
                cliente.IDCliente & " - " &
                cliente.Nombre & " " &
                cliente.Apellido & " - Tel: " &
                cliente.Telefono)

            Next

        Catch ex As Exception

            MessageBox.Show(
            "Error al cargar clientes desde MySQL: " & ex.Message)

        End Try

    End Sub


    'boton listar clientes

    Private Sub lstClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClientes.SelectedIndexChanged

        If lstClientes.SelectedIndex = -1 Then Exit Sub

        Dim cliente As Cliente = clientes(lstClientes.SelectedIndex)

        txtNombreCliente.Text = cliente.Nombre
        txtApellidoCliente.Text = cliente.Apellido
        txtTelefonoCliente.Text = cliente.Telefono
        txtEmailCliente.Text = cliente.Email

        ' MOSTRAR FECHA DE NACIMIENTO

        If cliente.FechaNacimiento.HasValue Then

            dtpFechaNacimientoCliente.Value =
        cliente.FechaNacimiento.Value.Date

            dtpFechaNacimientoCliente.Checked = True

        Else

            dtpFechaNacimientoCliente.Checked = False

        End If


        dtpFechaNacimientoCliente.Checked = False

    End Sub


    ' BOTÓN EDITAR CLIENTE
    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click

        If lstClientes.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un cliente.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtNombreCliente.Text) OrElse
       String.IsNullOrWhiteSpace(txtApellidoCliente.Text) OrElse
       String.IsNullOrWhiteSpace(txtTelefonoCliente.Text) Then

            MessageBox.Show("Complete nombre, apellido y teléfono.")
            Exit Sub
        End If

        Dim indice As Integer = lstClientes.SelectedIndex
        Dim cliente As Cliente = clientes(indice)

        ' Actualizar datos del cliente
        cliente.Nombre = txtNombreCliente.Text.Trim()
        cliente.Apellido = txtApellidoCliente.Text.Trim()
        cliente.Telefono = txtTelefonoCliente.Text.Trim()
        cliente.Email = txtEmailCliente.Text.Trim()

        ' ACTUALIZAR FECHA DE NACIMIENTO

        If dtpFechaNacimientoCliente.Checked Then

            cliente.FechaNacimiento =
        dtpFechaNacimientoCliente.Value.Date

        Else

            cliente.FechaNacimiento = Nothing

        End If

        Try

            ' Guardar cambios en MySQL
            If ClienteDAO.Modificar(cliente) Then

                CargarClientesDesdeBD()

                MessageBox.Show(
                "Cliente actualizado correctamente en MySQL.")

                txtNombreCliente.Clear()
                txtApellidoCliente.Clear()
                dtpFechaNacimientoCliente.Checked = False
                txtTelefonoCliente.Clear()
                txtEmailCliente.Clear()

            Else

                MessageBox.Show(
                "No se pudo actualizar el cliente.")

            End If

        Catch ex As Exception

            MessageBox.Show(
            "Error al modificar cliente: " & ex.Message)

        End Try

    End Sub



    ' BOTÓN ELIMINAR CLIENTE
    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click

        If lstClientes.SelectedIndex = -1 Then

            MessageBox.Show("Seleccione un cliente.")
            Exit Sub

        End If

        Dim indice As Integer = lstClientes.SelectedIndex
        Dim cliente As Cliente = clientes(indice)

        Dim respuesta As DialogResult =
        MessageBox.Show(
            "¿Está seguro de eliminar al cliente '" &
            cliente.Nombre & " " & cliente.Apellido & "'?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If respuesta <> DialogResult.Yes Then
            Exit Sub
        End If

        Try

            If ClienteDAO.Eliminar(cliente.IDCliente) Then

                CargarClientesDesdeBD()

                MessageBox.Show(
                "Cliente eliminado correctamente de MySQL.")

                txtNombreCliente.Clear()
                txtApellidoCliente.Clear()
                dtpFechaNacimientoCliente.Checked = False
                txtTelefonoCliente.Clear()
                txtEmailCliente.Clear()

            Else

                MessageBox.Show(
                "No se pudo eliminar el cliente.")

            End If

        Catch ex As MySql.Data.MySqlClient.MySqlException When ex.Number = 1451

            MessageBox.Show(
            "No se puede eliminar este cliente porque tiene " &
            "pedidos u otros registros asociados.")

        Catch ex As Exception

            MessageBox.Show(
            "Error al eliminar cliente: " & ex.Message)

        End Try

    End Sub



    ' BOTÓN EDITAR PRODUCTO
    Private Sub btnEditarProducto_Click(sender As Object, e As EventArgs) Handles btnEditarProducto.Click

        If lstProductos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un producto")
            Exit Sub
        End If

        Dim nombre As String = txtNombreProducto.Text.Trim()
        Dim precio As Decimal

        If String.IsNullOrWhiteSpace(nombre) Then
            MessageBox.Show("Ingrese el nombre del producto")
            Exit Sub
        End If

        If Not Decimal.TryParse(txtPrecio.Text, precio) OrElse precio < 0D Then
            MessageBox.Show("Ingrese un precio válido")
            Exit Sub
        End If

        If clbCategorias.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una categoría")
            Exit Sub
        End If

        Dim indice As Integer = lstProductos.SelectedIndex
        Dim producto As Producto = productos(indice)

        ' GUARDAR VALORES ANTERIORES
        Dim nombreAnterior = producto.NombreProducto
        Dim descripcionAnterior = producto.Descripcion
        Dim precioAnterior = producto.Precio
        Dim categoriaAnterior = producto.Categoria
        Dim maxSaboresAnterior = producto.MaxSabores

        Try

            producto.NombreProducto = nombre
            producto.Descripcion = txtDescripcion.Text.Trim()
            producto.Precio = precio
            producto.Categoria = categorias(clbCategorias.SelectedIndex)
            producto.MaxSabores = CInt(nudMaxSabores.Value)

            ' GUARDAR PRODUCTO EN MYSQL
            If Not ProductoDAO.Modificar(producto) Then

                producto.NombreProducto = nombreAnterior
                producto.Descripcion = descripcionAnterior
                producto.Precio = precioAnterior
                producto.Categoria = categoriaAnterior
                producto.MaxSabores = maxSaboresAnterior

                MessageBox.Show("No se pudo modificar el producto")
                Exit Sub
            End If

            ' GUARDAR RELACIÓN PRODUCTO - CATEGORÍA

            Dim idsCategorias As New List(Of Integer)

            idsCategorias.Add(producto.Categoria.IDCategoria)

            If Not ProductoCategoriaDAO.GuardarCategorias(
    producto.IDProducto, idsCategorias) Then

                MessageBox.Show(
        "No se pudo guardar la categoría del producto.")

                Exit Sub


            End If


            ' GUARDAR RELACIÓN PRODUCTO - SABORES EN MYSQL

            Dim idsSabores As New List(Of Integer)

            For Each indiceSabor As Integer In clbSabores.CheckedIndices

                Dim opcion As OpcionSabor =
        CType(clbSabores.Items(indiceSabor), OpcionSabor)

                idsSabores.Add(opcion.Sabor.IDSabor)

            Next

            If Not ProductoSaborDAO.GuardarSabores(
    producto.IDProducto, idsSabores) Then

                MessageBox.Show(
        "No se pudieron guardar los sabores del producto.")

                Exit Sub

            End If


            ' ACTUALIZAR SABORES EN MEMORIA
            For i As Integer = productosSabores.Count - 1 To 0 Step -1

                If productosSabores(i).IDProducto = producto.IDProducto Then
                    productosSabores.RemoveAt(i)
                End If

            Next

            For Each indiceSabor As Integer In clbSabores.CheckedIndices

                Dim productoSabor As New ProductoSabor()



                Dim opcion As OpcionSabor = CType(clbSabores.Items(indiceSabor), OpcionSabor)

                productoSabor.IDProducto = producto.IDProducto
                productoSabor.IDSabor = opcion.Sabor.IDSabor

                productosSabores.Add(productoSabor)

            Next

            ' ACTUALIZAR LISTA VISUAL
            lstProductos.Items(indice) =
            producto.IDProducto & " - " &
            producto.NombreProducto & " - $" &
            producto.Precio & " - Máx. " &
            producto.MaxSabores & " sabores"

            MessageBox.Show("Datos principales del producto guardados en MySQL")

        Catch ex As Exception

            producto.NombreProducto = nombreAnterior
            producto.Descripcion = descripcionAnterior
            producto.Precio = precioAnterior
            producto.Categoria = categoriaAnterior
            producto.MaxSabores = maxSaboresAnterior

            MessageBox.Show(
            "Error al modificar producto: " & ex.Message)

        End Try

    End Sub

    REM boton eliminar producto
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

        If respuesta <> DialogResult.Yes Then Exit Sub

        Try
            If ProductoDAO.Eliminar(producto.IDProducto) Then

                For i As Integer = productosSabores.Count - 1 To 0 Step -1
                    If productosSabores(i).IDProducto = producto.IDProducto Then
                        productosSabores.RemoveAt(i)
                    End If
                Next

                productos.RemoveAt(indice)
                lstProductos.Items.RemoveAt(indice)

                txtNombreProducto.Clear()
                txtDescripcion.Clear()
                txtPrecio.Clear()

                For i As Integer = 0 To clbSabores.Items.Count - 1
                    clbSabores.SetItemChecked(i, False)
                Next

                MessageBox.Show("Producto dado de baja correctamente")

            Else
                MessageBox.Show("No se pudo dar de baja el producto.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al eliminar producto: " & ex.Message)
        End Try

    End Sub


    REM load
    Private Sub PanelAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbGrupoOpcional.Items.Add("Salsas adicionales")
        cmbGrupoOpcional.Items.Add("Baño de chocolate Águila")

        CargarSaboresDesdeBD()
        CargarCategoriasDesdeBD()
        CargarProductosDesdeBD()
        productosSabores.Clear()
        productosSabores.AddRange(ProductoSaborDAO.Listar())
        CargarClientesDesdeBD()
        dtpFechaNacimientoCliente.MaxDate = Date.Today
        dtpFechaNacimientoCliente.Checked = False

    End Sub

    ' ==========================================
    ' CARGAR SABORES DESDE MYSQL
    ' ==========================================

    Private Sub CargarSaboresDesdeBD()

        Try

            sabores.Clear()
            sabores.AddRange(SaborDAO.Listar())

            lstSabores.Items.Clear()
            clbSabores.Items.Clear()

            For Each sabor As Sabor In sabores

                Dim texto As String =
                sabor.IDSabor & " - " & sabor.NombreSabor

                If Not sabor.Activo Then
                    texto &= " (Inactivo)"
                End If

                lstSabores.Items.Add(texto)

                If sabor.Activo Then

                    clbSabores.Items.Add(
                    New OpcionSabor With {.Sabor = sabor})

                End If

            Next

        Catch ex As Exception

            MessageBox.Show(
            "Error al cargar sabores desde MySQL: " & ex.Message)

        End Try

    End Sub


    'boton opcional
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

    'boton agregar opcional
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

    '
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

    'boton guardar opcionales
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

    REM boton ver vista pedido
    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click

        Dim frm As New FormPedidos()
        frm.Show()

    End Sub

    REM vista como cliente
    Private Sub btnVerCliente_Click(sender As Object, e As EventArgs) Handles btnVerCliente.Click

        Dim frm As New FormCliente()
        frm.Show()

    End Sub

    REM metodo para auxiliar los check de sabores
    Private Class OpcionSabor

        Public Property Sabor As Sabor

        Public Overrides Function ToString() As String
            Return Sabor.NombreSabor
        End Function

    End Class

End Class