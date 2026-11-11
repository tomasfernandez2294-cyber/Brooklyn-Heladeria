Public Class FormSaboresCliente

    Private productoSeleccionado As Producto
    Private carritoActual As Carrito
    Private itemEditando As ItemCarrito = Nothing

    REM constructor producto
    Public Sub New(producto As Producto, carrito As Carrito)

        InitializeComponent()

        productoSeleccionado = producto
        carritoActual = carrito

    End Sub

    Public Sub New(item As ItemCarrito)

        InitializeComponent()

        itemEditando = item
        productoSeleccionado = item.producto

    End Sub

    REM load
    Private Sub FormSaboresCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Mostrar datos del producto elegido
        lblNombreProducto.Text = productoSeleccionado.NombreProducto
        lblPrecio.Text = "$ " & productoSeleccionado.Precio.ToString("N0")

        ' Mostrar límite de sabores
        lblLimiteSabores.Text =
            "0 / " & productoSeleccionado.MaxSabores.ToString()

        ' Limpiar lista
        clbSabores.Items.Clear()

        If productoSeleccionado.Sabores.Count = 0 Then

            productoSeleccionado.Sabores.Add(
        New Sabor With {
            .IDSabor = 1,
            .NombreSabor = "Chocolate",
            .Activo = True
        })

            productoSeleccionado.Sabores.Add(
        New Sabor With {
            .IDSabor = 2,
            .NombreSabor = "Dulce de leche",
            .Activo = True
        })

            productoSeleccionado.Sabores.Add(
        New Sabor With {
            .IDSabor = 3,
            .NombreSabor = "Frutilla",
            .Activo = True
        })

            productoSeleccionado.Sabores.Add(
        New Sabor With {
            .IDSabor = 4,
            .NombreSabor = "Americana",
            .Activo = True
        })

        End If

        If itemEditando IsNot Nothing Then

            txtNotasAdicionales.Text = itemEditando.NotaAdicional

            For i As Integer = 0 To clbSabores.Items.Count - 1

                Dim sabor As Sabor = CType(clbSabores.Items(i), Sabor)

                If itemEditando.SaboresSeleccionados.Any(
            Function(s) s.IDSabor = sabor.IDSabor) Then

                    clbSabores.SetItemChecked(i, True)

                End If

            Next

        End If

        ' Cargar sabores disponibles del producto
        For Each sabor As Sabor In productoSeleccionado.Sabores

            If sabor.Activo Then
                clbSabores.Items.Add(sabor)
            End If

        Next

    End Sub

    REM boton agregar 
    Private Sub btnAgregarPedido_Click(sender As Object, e As EventArgs) Handles btnAgregarPedido.Click

        'Validar sabores
        If clbSabores.CheckedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar al menos un sabor.")
            Exit Sub
        End If

        ' MODO EDICIÓN
        If itemEditando IsNot Nothing Then

            itemEditando.SaboresSeleccionados.Clear()

            For Each sabor As Sabor In clbSabores.CheckedItems
                itemEditando.SaboresSeleccionados.Add(sabor)
            Next

            itemEditando.NotaAdicional = txtNotasAdicionales.Text

            MessageBox.Show("Producto actualizado correctamente.")

            Me.Close()
            Exit Sub

        End If


        '====================================
        ' MODO AGREGAR
        '====================================
        Dim nuevoItem As New ItemCarrito()

        nuevoItem.producto = productoSeleccionado
        nuevoItem.cantidad = 1
        nuevoItem.subtotal = CDbl(productoSeleccionado.Precio)


        nuevoItem.NotaAdicional = txtNotasAdicionales.Text

        'agrega lo items seleccionados
        For Each sabor As Sabor In clbSabores.CheckedItems
            nuevoItem.SaboresSeleccionados.Add(sabor)
        Next

        MessageBox.Show("Nota guardada: " & nuevoItem.NotaAdicional)

        carritoActual.AgregarProducto(nuevoItem)

        MessageBox.Show("Producto agregado al carrito.")

        Me.Close()

    End Sub
End Class