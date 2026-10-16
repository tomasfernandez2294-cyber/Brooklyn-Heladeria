Public Class Producto

    ' DATOS PRINCIPALES
    Public Property IDProducto As Integer
    Public Property NombreProducto As String
    Public Property Descripcion As String
    Public Property Precio As Decimal
    Public Property Imagen As String
    Public Property Activo As Boolean
    Public Property Orden As Integer
    Public Property Cantidad As Integer

    ' CONFIGURACIÓN DEL PRODUCTO
    Public Property MaxSabores As Integer
    Public Property MaxSalsas As Integer
    Public Property MaxMarrocotes As Integer

    ' Propiedades utilizadas por el administrador
    Public Property BotonADDCarrito As Boolean
    Public Property PermitirNotas As Boolean

    ' CATEGORÍA
    ' Esta propiedad mantiene compatibilidad con PanelAdm
    Public Property Categoria As NombreCategoria

    ' SABORES
    Public Property Sabores As List(Of Sabor)

    Public Sub New()

        Sabores = New List(Of Sabor)()

        Activo = True

    End Sub

End Class