Public Class Categoria

    Public IdCategoria As Integer
    Public NombreCategoria As String
    Public Descripcion As String
    Public Activo As Boolean
    Public Orden As Integer

    Public Property Productos As List(Of Producto)

    Public Sub New()
        Productos = New List(Of Producto)()
    End Sub
End Class
