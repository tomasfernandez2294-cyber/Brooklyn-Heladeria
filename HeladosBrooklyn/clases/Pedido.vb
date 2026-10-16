Public Class Pedido

    Public estadoPago As EstadoPago
    Public estadoPedido As EstadoPedido
    Public fechaPedido As Date
    Public id As Integer
    Public NumeroPedido As String
    Public subTotal As Double
    Public total As Double

    'relaciones
    Public Property Carrito As Carrito
    Public Property Detalles As List(Of DetallePedido)
    Public Property MetodoEntrega As MetodoEntrega
    Public Property MetodoPago As MetodoPago
    Public Property Direccion As Direccion
    Public Property Cupon As Cupon
    Public Property Cliente As Cliente

    Public Sub New()
        Detalles = New List(Of DetallePedido)()
        estadoPedido = EstadoPedido.Nuevo
        estadoPago = EstadoPago.Pendiente
        fechaPedido = Date.Now
    End Sub

End Class
