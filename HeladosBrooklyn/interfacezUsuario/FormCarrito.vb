
Imports System.Linq

Public Class FormCarrito

    Private carritoActual As Carrito
    Private descuentoActual As Decimal = 0D

    ' Control de confirmación del pedido
    Private pedidoConfirmado As Boolean = False
    Private pedidoActual As Pedido = Nothing

    ' Constructor para el diseñador
    Public Sub New()

        InitializeComponent()

    End Sub

    ' Constructor que recibe el carrito
    Public Sub New(carrito As Carrito)

        InitializeComponent()

        carritoActual = carrito

        CargarCarrito()

    End Sub

    ' BLOQUEAR CARRITO DESPUÉS DE CONFIRMAR
    Private Sub BloquearCarrito()

        pedidoConfirmado = True

        ' Deshabilitar botones
        btnContinuarPedido.Enabled = False
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        btnAplicarCupon.Enabled = False

        txtCodigoCupon.Enabled = False

        ' Bloquear DataGridView
        dgvCarrito.ReadOnly = True
        dgvCarrito.AllowUserToAddRows = False
        dgvCarrito.AllowUserToDeleteRows = False

        ' Cambiar título de la columna Nota
        dgvCarrito.Columns(4).HeaderText =
            "Estado del pedido"

    End Sub

    ' ACTUALIZAR TOTAL
    Private Sub ActualizarTotal()

        If carritoActual Is Nothing Then Exit Sub

        Dim subtotal As Decimal =
            Convert.ToDecimal(carritoActual.CalcularTotal())

        descuentoActual =
            carritoActual.CalcularDescuento()

        Dim totalFinal As Decimal =
            carritoActual.CalcularTotalFinal()

        lblSubtotal.Text =
            "$" & subtotal.ToString("N2")

        lblDescuento.Text =
            "-$" & descuentoActual.ToString("N2")

        lblTotal.Text =
            "$" & totalFinal.ToString("N2")

    End Sub

    ' CARGAR PRODUCTOS EN EL CARRITO
    Private Sub CargarCarrito()

        If carritoActual Is Nothing Then Exit Sub

        dgvCarrito.Rows.Clear()

        For Each item As ItemCarrito In carritoActual.Items

            Dim saboresTexto As String = ""

            If item.SaboresSeleccionados IsNot Nothing Then

                For Each sabor As Sabor In item.SaboresSeleccionados

                    If saboresTexto <> "" Then
                        saboresTexto &= ", "
                    End If

                    saboresTexto &= sabor.NombreSabor

                Next

            End If

            ' Nota antes de confirmar
            Dim textoUltimaColumna As String =
                item.NotaAdicional

            ' Estado después de confirmar
            If pedidoConfirmado AndAlso
               pedidoActual IsNot Nothing Then

                textoUltimaColumna = "Pendiente"

            End If

            ' Agregar fila
            Dim indiceFila As Integer =
                dgvCarrito.Rows.Add(
                    item.producto.NombreProducto,
                    saboresTexto,
                    item.cantidad,
                    item.subtotal,
                    textoUltimaColumna
                )

            ' Asociar fila con ItemCarrito
            dgvCarrito.Rows(indiceFila).Tag = item

        Next

        ActualizarTotal()

    End Sub

    ' BOTÓN VOLVER
    Private Sub btnVolver_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnVolver.Click

        Me.Close()

    End Sub

    ' BOTÓN CONTINUAR PEDIDO
    Private Sub btnContinuarPedido_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnContinuarPedido.Click

        If pedidoConfirmado Then
            MessageBox.Show(
                "Este pedido ya fue confirmado.")
            Exit Sub
        End If

        If carritoActual Is Nothing OrElse
           carritoActual.Items.Count = 0 Then

            MessageBox.Show(
                "El carrito está vacío.")
            Exit Sub

        End If

        Using formularioEntrega As New FormMetodoEntregaCliente(
            carritoActual)

            Me.Hide()

            Try

                Dim resultado As DialogResult =
                    formularioEntrega.ShowDialog(Me)

                ' El cliente confirmó el pedido
                If resultado = DialogResult.OK Then

                    ' Buscar pedido registrado
                    pedidoActual =
                        GestorPedidos.Pedidos.LastOrDefault(
                            Function(p) p.Carrito Is carritoActual)

                    If pedidoActual IsNot Nothing Then

                        BloquearCarrito()
                        CargarCarrito()

                        MessageBox.Show(
                            "Pedido " &
                            pedidoActual.NumeroPedido &
                            " registrado correctamente." &
                            vbCrLf &
                            "Estado: Pendiente")

                    Else

                        MessageBox.Show(
                            "No se encontró el pedido confirmado.")

                    End If

                End If

            Finally

                If Not Me.IsDisposed Then
                    Me.Show()
                End If

            End Try

        End Using

    End Sub

    ' BOTÓN ELIMINAR
    Private Sub Button2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEliminar.Click

        If pedidoConfirmado Then
            MessageBox.Show(
                "No se puede eliminar un producto " &
                "de un pedido confirmado.")
            Exit Sub
        End If

        If dgvCarrito.CurrentRow Is Nothing Then
            MessageBox.Show(
                "Seleccione un producto del carrito.")
            Exit Sub
        End If

        Dim itemSeleccionado As ItemCarrito =
            TryCast(dgvCarrito.CurrentRow.Tag, ItemCarrito)

        If itemSeleccionado Is Nothing Then Exit Sub

        carritoActual.Items.Remove(itemSeleccionado)

        CargarCarrito()

    End Sub

    ' BOTÓN EDITAR
    Private Sub btnEditar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEditar.Click

        If pedidoConfirmado Then
            MessageBox.Show(
                "No se puede editar un pedido confirmado.")
            Exit Sub
        End If

        If dgvCarrito.CurrentRow Is Nothing Then
            MessageBox.Show(
                "Seleccione un producto para editar.")
            Exit Sub
        End If

        Dim itemSeleccionado As ItemCarrito =
            TryCast(dgvCarrito.CurrentRow.Tag, ItemCarrito)

        If itemSeleccionado Is Nothing Then Exit Sub

        Using ventana As New FormSaboresCliente(
            itemSeleccionado)

            ventana.ShowDialog(Me)

        End Using

        CargarCarrito()

    End Sub

    ' BOTÓN APLICAR CUPÓN
    Private Sub btnAplicarCupon_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAplicarCupon.Click

        If pedidoConfirmado Then
            MessageBox.Show(
                "No se pueden aplicar cupones " &
                "a un pedido confirmado.")
            Exit Sub
        End If

        Try

            carritoActual.CuponAplicado = Nothing

            descuentoActual = 0D

            ActualizarTotal()

            Dim codigo As String =
                txtCodigoCupon.Text.Trim()

            If String.IsNullOrWhiteSpace(codigo) Then

                MessageBox.Show(
                    "Ingrese un código de cupón.")
                Exit Sub

            End If

            Dim cupon As Cupon =
                CuponDAO.BuscarPorCodigo(codigo)

            If cupon Is Nothing Then

                MessageBox.Show(
                    "El cupón no existe.")
                Exit Sub

            End If

            If Not cupon.activo Then

                MessageBox.Show(
                    "El cupón está deshabilitado.")
                Exit Sub

            End If

            Dim subtotal As Decimal =
                Convert.ToDecimal(
                    carritoActual.CalcularTotal())

            Dim descuento As Decimal =
                CuponServicio.CalcularDescuento(
                    cupon,
                    subtotal)

            If descuento <= 0D Then

                MessageBox.Show(
                    "El cupón no es válido para este pedido.")
                Exit Sub

            End If

            carritoActual.CuponAplicado = cupon

            ActualizarTotal()

            MessageBox.Show(
                "Cupón aplicado correctamente." &
                vbCrLf &
                "Descuento: $" &
                descuentoActual.ToString("N2"))

        Catch ex As Exception

            MessageBox.Show(
                "Error al aplicar el cupón: " &
                ex.Message)

        End Try

    End Sub

End Class
