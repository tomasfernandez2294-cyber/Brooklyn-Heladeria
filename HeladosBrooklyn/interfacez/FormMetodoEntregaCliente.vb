Public Class FormMetodoEntregaCliente

    ' Carrito actual del cliente
    Private carritoActual As Carrito

    ' Constructor: recibe el carrito desde FormCarrito
    Public Sub New(carrito As Carrito)

        InitializeComponent()

        carritoActual = carrito

    End Sub


    ' Botón Continuar
    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click

        If Not rbDelivery.Checked AndAlso Not rbRetiro.Checked Then
            MessageBox.Show("Seleccione un método de entrega.")
            Exit Sub
        End If

        ' Crear el método de entrega seleccionado
        Dim metodoEntregaSeleccionado As New MetodoEntrega()

        If rbDelivery.Checked Then
            metodoEntregaSeleccionado.IDMetodoEntrega = 1
            metodoEntregaSeleccionado.Nombre = "Delivery"
            metodoEntregaSeleccionado.Tipo = "Delivery"
        Else
            metodoEntregaSeleccionado.IDMetodoEntrega = 2
            metodoEntregaSeleccionado.Nombre = "Retiro en el local"
            metodoEntregaSeleccionado.Tipo = "Retiro"
        End If

        metodoEntregaSeleccionado.Habilitado = True

        ' Pasamos carrito + método de entrega
        Dim formularioPago As New FormMetodoPagoCliente(
        carritoActual,
        metodoEntregaSeleccionado
    )

        formularioPago.Show()
        Me.Hide()

    End Sub

End Class