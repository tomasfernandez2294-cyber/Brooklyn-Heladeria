
Public Class FormMetodoEntregaCliente
    Public Property PedidoGuardado As Pedido

    Private carritoActual As Carrito

    ' Constructor
    Public Sub New(carrito As Carrito)

        InitializeComponent()
        carritoActual = carrito

    End Sub

    ' BOTÓN CONTINUAR
    Private Sub btnContinuar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnContinuar.Click

        ' Validar método de entrega
        If Not rbDelivery.Checked AndAlso
           Not rbRetiro.Checked Then

            MessageBox.Show(
                "Seleccione un método de entrega.")
            Exit Sub

        End If

        ' Crear método de entrega
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

        ' Abrir formulario de pago
        Using formularioPago As New FormMetodoPagoCliente(
            carritoActual,
            metodoEntregaSeleccionado)

            Me.Hide()

            Try
                Dim resultado As DialogResult =
                    formularioPago.ShowDialog(Me)


                If resultado = DialogResult.OK Then

                    ' Recuperar el pedido confirmado
                    PedidoGuardado = formularioPago.PedidoGuardado

                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                    Return

                End If


            Finally
                If Not Me.IsDisposed Then
                    Me.Show()
                End If
            End Try

        End Using

    End Sub

    REM load
    Private Sub FormMetodoEntregaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EstiloBrooklyn.Aplicar(Me)


    End Sub
End Class
