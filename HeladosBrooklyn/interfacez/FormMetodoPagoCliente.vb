Public Class FormMetodoPagoCliente

    Private carritoActual As Carrito
    Private metodoEntregaSeleccionado As MetodoEntrega

    'constructor
    Public Sub New(carrito As Carrito, metodoEntrega As MetodoEntrega)

        InitializeComponent()

        carritoActual = carrito
        metodoEntregaSeleccionado = metodoEntrega

    End Sub


    Private Sub rbTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles rbTarjeta.CheckedChanged

    End Sub


    ' Botón Confirmar Pedido
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        ' Validar método de pago
        If Not rbEfectivo.Checked AndAlso
       Not rbMercadoPago.Checked AndAlso
       Not rbTarjeta.Checked Then

            MessageBox.Show("Seleccione un método de pago.")
            Exit Sub

        End If


        ' Crear método de pago seleccionado
        Dim metodoPagoSeleccionado As New MetodoPago()

        If rbEfectivo.Checked Then

            metodoPagoSeleccionado.IDMetodoPago = 1
            metodoPagoSeleccionado.Nombre = "Efectivo"
            metodoPagoSeleccionado.Tipo = "Efectivo"

        ElseIf rbMercadoPago.Checked Then

            metodoPagoSeleccionado.IDMetodoPago = 2
            metodoPagoSeleccionado.Nombre = "Mercado Pago"
            metodoPagoSeleccionado.Tipo = "Mercado Pago"

        ElseIf rbTarjeta.Checked Then

            metodoPagoSeleccionado.IDMetodoPago = 3
            metodoPagoSeleccionado.Nombre = "Tarjeta"
            metodoPagoSeleccionado.Tipo = "Tarjeta"

        End If

        metodoPagoSeleccionado.Habilitado = True


        ' Crear el pedido
        Dim nuevoPedido As New Pedido()

        nuevoPedido.id = GestorPedidos.Pedidos.Count + 1
        nuevoPedido.NumeroPedido = "PED-" & nuevoPedido.id.ToString("0000")

        nuevoPedido.Carrito = carritoActual
        nuevoPedido.MetodoEntrega = metodoEntregaSeleccionado
        nuevoPedido.MetodoPago = metodoPagoSeleccionado

        nuevoPedido.subTotal = carritoActual.CalcularTotal()
        nuevoPedido.total = carritoActual.CalcularTotal()

        nuevoPedido.fechaPedido = Date.Now


        ' Guardar pedido
        GestorPedidos.AgregarPedido(nuevoPedido)


        MessageBox.Show(
        "Pedido " & nuevoPedido.NumeroPedido &
        " confirmado correctamente."
    )

    End Sub


    ' Botón Volver
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        ' Volvemos a Entrega pasando el MISMO carrito
        Dim formularioEntrega As New FormMetodoEntregaCliente(carritoActual)

        formularioEntrega.Show()
        Me.Close()

    End Sub

    Private Sub btnIrPedido_Click(sender As Object, e As EventArgs) Handles btnIrPedido.Click

        Dim formularioPedidos As New FormPedidos()

        formularioPedidos.Show()
        Me.Hide()
    End Sub
End Class