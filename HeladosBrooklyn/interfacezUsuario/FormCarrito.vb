Public Class FormCarrito

    Private carritoActual As Carrito
    Private descuentoActual As Decimal = 0D

    'Constructor para el diseñador
    Public Sub New()

        InitializeComponent()

    End Sub

    REM contructor de bpruba
    Public Sub New(carrito As Carrito)

        InitializeComponent()

        carritoActual = carrito

        CargarCarrito()

    End Sub

    'metodo para actualizar el total

    Private Sub ActualizarTotal()

        If carritoActual Is Nothing Then Exit Sub

        Dim subtotal As Decimal =
        Convert.ToDecimal(carritoActual.CalcularTotal())

        descuentoActual = carritoActual.CalcularDescuento()

        Dim totalFinal As Decimal =
        carritoActual.CalcularTotalFinal()

        lblSubtotal.Text =
        "$" & subtotal.ToString("N2")

        lblDescuento.Text =
        "-$" & descuentoActual.ToString("N2")

        lblTotal.Text =
        "$" & totalFinal.ToString("N2")

    End Sub


    REM procedimiento para cargar al carrito 
    Private Sub CargarCarrito()

        dgvCarrito.Rows.Clear()

        For Each item As ItemCarrito In carritoActual.Items

            Dim saboresTexto As String = ""

            For Each sabor As Sabor In item.SaboresSeleccionados

                If saboresTexto <> "" Then
                    saboresTexto &= ", "
                End If

                saboresTexto &= sabor.NombreSabor

            Next

            'Agregar la fila y guardar su índice
            Dim indiceFila As Integer = dgvCarrito.Rows.Add(
            item.producto.NombreProducto,
            saboresTexto,
            item.cantidad,
            item.subtotal,
            item.NotaAdicional
        )

            'Relacionar la fila con ESTE ItemCarrito
            dgvCarrito.Rows(indiceFila).Tag = item

        Next

        ActualizarTotal()

    End Sub

    'boton volver
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    'boton continuar pedido
    Private Sub btnContinuarPedido_Click(sender As Object, e As EventArgs) Handles btnContinuarPedido.Click

        Dim formularioEntrega As New FormMetodoEntregaCliente(carritoActual)

        formularioEntrega.Show()
        Me.Hide()

    End Sub

    REM boton eliminar 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If dgvCarrito.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un producto del carrito.")
            Exit Sub
        End If

        Dim itemSeleccionado As ItemCarrito =
            CType(dgvCarrito.CurrentRow.Tag, ItemCarrito)

        carritoActual.Items.Remove(itemSeleccionado)

        CargarCarrito()

    End Sub

    REM editar carrito
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If dgvCarrito.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un producto para editar.")
            Exit Sub
        End If

        Dim itemSeleccionado As ItemCarrito =
            CType(dgvCarrito.CurrentRow.Tag, ItemCarrito)

        Dim ventana As New FormSaboresCliente(itemSeleccionado)

        ventana.ShowDialog()

        CargarCarrito()

    End Sub

    'boton aplicar descuento
    Private Sub btnAplicarCupon_Click(
    sender As Object,
    e As EventArgs
) Handles btnAplicarCupon.Click

        Try
            carritoActual.CuponAplicado = Nothing
            descuentoActual = 0D
            ActualizarTotal()

            Dim codigo As String =
                txtCodigoCupon.Text.Trim()

            If String.IsNullOrWhiteSpace(codigo) Then
                MessageBox.Show("Ingrese un código de cupón.")
                Exit Sub
            End If

            Dim cupon As Cupon =
                CuponDAO.BuscarPorCodigo(codigo)

            If cupon Is Nothing Then
                MessageBox.Show("El cupón no existe.")
                Exit Sub
            End If

            If Not cupon.activo Then
                MessageBox.Show("El cupón está deshabilitado.")
                Exit Sub
            End If

            Dim subtotal As Decimal =
                Convert.ToDecimal(carritoActual.CalcularTotal())

            Dim descuento As Decimal =
                CuponServicio.CalcularDescuento(cupon, subtotal)

            If descuento <= 0D Then
                MessageBox.Show("El cupón no es válido para este pedido.")
                Exit Sub
            End If

            carritoActual.CuponAplicado = cupon

            ActualizarTotal()

            MessageBox.Show(
                "Cupón aplicado correctamente." &
                vbCrLf &
                "Descuento: $" & descuentoActual.ToString("N2"))

        Catch ex As Exception

            MessageBox.Show(
                "Error al aplicar el cupón: " & ex.Message)

        End Try

    End Sub
End Class