Public Class Carrito
    Public IdCarrito As Integer
    Public total As Double
    Public CuponAplicado As Cupon = Nothing

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

    ' CALCULAR DESCUENTO DEL CARRITO
    Public Function CalcularDescuento() As Decimal

        If CuponAplicado Is Nothing Then Return 0D

        Dim subtotal As Decimal =
            Convert.ToDecimal(CalcularTotal())

        Return CuponServicio.CalcularDescuento(
            CuponAplicado, subtotal)

    End Function


    ' CALCULAR TOTAL CON DESCUENTO
    Public Function CalcularTotalFinal() As Decimal

        Dim subtotal As Decimal =
            Convert.ToDecimal(CalcularTotal())

        Return subtotal - CalcularDescuento()

    End Function

End Class
