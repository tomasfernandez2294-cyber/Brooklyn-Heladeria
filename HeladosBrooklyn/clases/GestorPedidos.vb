Public Class GestorPedidos

    Public Shared Pedidos As New List(Of Pedido)

    Public Shared Sub AgregarPedido(pedido As Pedido)
        Pedidos.Add(pedido)
    End Sub

End Class
