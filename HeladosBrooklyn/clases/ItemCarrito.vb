Public Class ItemCarrito
    Public producto As Producto
    Public cantidad As Integer
    Public subtotal As Double


    ' Sabores que eligió el cliente para este producto
    Public SaboresSeleccionados As List(Of Sabor)

    Public Sub New()
        SaboresSeleccionados = New List(Of Sabor)
    End Sub

End Class
