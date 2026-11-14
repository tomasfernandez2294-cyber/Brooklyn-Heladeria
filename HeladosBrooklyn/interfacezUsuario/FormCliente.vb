Public Class FormCliente

    Private productos As New List(Of Producto)
    Private carritoActual As New Carrito()

    REM load
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarProductosDesdeBD()
        MostrarProductos()
        EstiloBrooklyn.Aplicar(Me)

    End Sub

    ' CARGAR PRODUCTOS Y SABORES DESDE MYSQL
    Private Sub CargarProductosDesdeBD()

        Try
            productos.Clear()

            Dim productosBD As List(Of Producto) =
            ProductoDAO.Listar()

            For Each producto As Producto In productosBD

                If producto.Activo Then

                    ' Obtener sabores asociados al producto
                    producto.Sabores =
                    SaborDAO.ListarPorProducto(producto.IDProducto)

                    productos.Add(producto)

                End If

            Next

        Catch ex As Exception

            MessageBox.Show(
            "Error al cargar productos y sabores: " &
            ex.Message)

        End Try

    End Sub


    REM procedimiento para mostrar objetos OJO
    Private Sub MostrarProductos()

        flpProductos.Controls.Clear()

        ' Configuración del contenedor
        flpProductos.FlowDirection = FlowDirection.TopDown
        flpProductos.WrapContents = False
        flpProductos.AutoScroll = True

        For Each producto As Producto In productos

            Dim pnlProducto As New Panel()
            pnlProducto.Width = flpProductos.ClientSize.Width - 25
            pnlProducto.Height = 120
            pnlProducto.BorderStyle = BorderStyle.FixedSingle

            Dim lblNombre As New Label()
            lblNombre.Text = producto.NombreProducto
            lblNombre.AutoSize = True
            lblNombre.Location = New Point(15, 15)

            Dim lblPrecio As New Label()
            lblPrecio.Text = "$ " & producto.Precio.ToString("N0")
            lblPrecio.AutoSize = True
            lblPrecio.Location = New Point(15, 45)

            Dim btnElegir As New Button()
            btnElegir.Text = "Elegir"
            btnElegir.Width = 80
            btnElegir.Location = New Point(pnlProducto.Width - btnElegir.Width - 15, 75)
            btnElegir.Tag = producto
            AddHandler btnElegir.Click, AddressOf ElegirProducto

            pnlProducto.Controls.Add(lblNombre)
            pnlProducto.Controls.Add(lblPrecio)
            pnlProducto.Controls.Add(btnElegir)

            flpProductos.Controls.Add(pnlProducto)

        Next

    End Sub

    REM procedimiento para elegir producto
    Private Sub ElegirProducto(sender As Object, e As EventArgs)

        Dim boton As Button = CType(sender, Button)

        Dim productoSeleccionado As Producto =
        CType(boton.Tag, Producto)

        'Abrir ventana para configurar el producto
        Dim ventanaSabores As New FormSaboresCliente(productoSeleccionado, carritoActual)

        ventanaSabores.ShowDialog()

    End Sub

    'boton ver carrito
    Private Sub btnVerCarrito_Click(sender As Object, e As EventArgs) Handles btnVerCarrito.Click

        Dim formularioCarrito As New FormCarrito(carritoActual)

        Me.Hide()
        formularioCarrito.ShowDialog()
        Me.Show()

    End Sub

    'boton registrarse
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click

        Using formulario As New FormRegistroCliente()
            formulario.ShowDialog(Me)
        End Using

    End Sub
End Class