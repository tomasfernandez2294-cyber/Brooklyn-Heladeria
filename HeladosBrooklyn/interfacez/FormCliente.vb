Public Class FormCliente

    Private productos As New List(Of Producto)
    Private carritoActual As New Carrito()

    REM load
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim producto1 As New Producto()

        producto1.IDProducto = 1
        producto1.NombreProducto = "1 Kilo de Helado"
        producto1.Descripcion = "Hasta 2 sabores"
        producto1.Precio = 18000D
        producto1.Activo = True
        producto1.Orden = 1
        producto1.MaxSabores = 2


        Dim producto2 As New Producto()

        producto2.IDProducto = 2
        producto2.NombreProducto = "1/2 Kilo de Helado"
        producto2.Descripcion = "Hasta 2 sabores"
        producto2.Precio = 11000D
        producto2.Activo = True
        producto2.Orden = 2
        producto2.MaxSabores = 2


        Dim producto3 As New Producto()

        producto3.IDProducto = 3
        producto3.NombreProducto = "1/4 Kilo de Helado"
        producto3.Descripcion = "Hasta 2 sabores"
        producto3.Precio = 7000D
        producto3.Activo = True
        producto3.Orden = 3
        producto3.MaxSabores = 2

        productos.Add(producto1)
        productos.Add(producto2)
        productos.Add(producto3)

        MostrarProductos()

    End Sub

    REM procedimiento para mostrar objetos OJO
    Private Sub MostrarProductos()

        flpProductos.Controls.Clear()

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
    Private Sub btnVerCarrito_Click(sender As Object, e As EventArgs) Handles btnVerCarrito.Click

        Dim formularioCarrito As New FormCarrito(carritoActual)

        Me.Hide()
        formularioCarrito.ShowDialog()
        Me.Show()

    End Sub

End Class