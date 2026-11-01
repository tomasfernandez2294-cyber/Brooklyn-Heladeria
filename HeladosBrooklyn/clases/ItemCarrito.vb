Public Class ItemCarrito
    Public producto As Producto
    Public cantidad As Integer
    Public subtotal As Double
    Public NotaAdicional As String

    ' Sabores que eligio el cliente para este producto
    Public SaboresSeleccionados As List(Of Sabor)

    Public Sub New()
        SaboresSeleccionados = New List(Of Sabor)()
        NotaAdicional = ""
    End Sub

End Class
