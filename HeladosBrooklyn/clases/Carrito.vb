Public Class Carrito
    Public IdCarrito As Integer
    Public total As Double

    ' Relación Carrito 1 ---- 0..* ItemCarrito
    Public Items As List(Of ItemCarrito)

    Public Sub New()
        Items = New List(Of ItemCarrito)
    End Sub

    Public Sub AgregarProducto(item As ItemCarrito)
        Items.Add(item)
    End Sub

    Public Sub QuitarProducto(item As ItemCarrito)
        Items.Remove(item)
    End Sub

    Public Sub Vaciar()
        Items.Clear()
    End Sub

    'funcion para calcular el total
    Public Function CalcularTotal() As Double
        Dim totalCalculado As Double = 0

        For Each item As ItemCarrito In Items
            totalCalculado += item.subtotal
        Next

        Return totalCalculado
    End Function
End Class
