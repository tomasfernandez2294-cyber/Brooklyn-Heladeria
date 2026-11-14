Public Class FormMetodoPagoCliente

    Public Property PedidoGuardado As Pedido

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



    ' BOTÓN CONFIRMAR PEDIDO
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

        ' Crear cliente de prueba
        ' SOLO PARA LA DEMOSTRACIÓN LOCAL
        Dim clientePrueba As New Cliente()
        clientePrueba.IDCliente = 1

        ' Crear pedido
        Dim nuevoPedido As New Pedido()

        nuevoPedido.NumeroPedido =
        "PED-" & Guid.NewGuid().ToString("N").Substring(0, 12).ToUpper()

        nuevoPedido.Cliente = clientePrueba
        nuevoPedido.Carrito = carritoActual
        nuevoPedido.MetodoEntrega = metodoEntregaSeleccionado
        nuevoPedido.MetodoPago = metodoPagoSeleccionado

        nuevoPedido.subTotal = carritoActual.CalcularTotal()
        nuevoPedido.total = carritoActual.CalcularTotalFinal()

        nuevoPedido.fechaPedido = Date.Now

        nuevoPedido.estadoPedido = EstadoPedido.RECIBIDO
        nuevoPedido.estadoPago = EstadoPago.Pendiente

        ' Guardar en MySQL
        Try


            If PedidoDAO.Agregar(nuevoPedido) Then

                ' Asignar solamente si se guardó correctamente
                PedidoGuardado = nuevoPedido

                MessageBox.Show(
                "Pedido " & nuevoPedido.NumeroPedido &
                " guardado correctamente en MySQL.",
                "Pedido confirmado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

                Me.DialogResult = DialogResult.OK
                Me.Close()

            Else

                MessageBox.Show("No se pudo guardar el pedido.")

            End If

        Catch ex As Exception

            MessageBox.Show(
            "Error al guardar el pedido: " & ex.Message,
            "Error de MySQL",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

    End Sub



    ' BOTÓN VOLVER
    Private Sub Button1_Click(
    sender As Object,
    e As EventArgs
) Handles btnVolver.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnIrPedido_Click(sender As Object, e As EventArgs) Handles btnIrPedido.Click

        Dim formularioPedidos As New FormPedidos()

        formularioPedidos.Show()
        Me.Hide()
    End Sub

    REM load
    Private Sub FormMetodoPagoCliente(sender As Object, e As EventArgs) Handles MyBase.Load

        EstiloBrooklyn.Aplicar(Me)


    End Sub
End Class