Public Class Sabor
    Public Property IDSabor As Integer
    Public Property NombreSabor As String
    Public Property Stock As Integer
    Public Property Activo As Boolean
    Public Property Descripcion As String


    'funcion para mostrar nombre x sabores seleccionados 
    Public Overrides Function ToString() As String
        Return NombreSabor
    End Function

End Class
