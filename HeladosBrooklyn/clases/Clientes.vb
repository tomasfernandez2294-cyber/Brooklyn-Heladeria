Public Class Cliente

    Public Apellido As String
    Public Nombre As String
    Public Email As String
    Public FechaNacimiento As Date?
    Public IDCliente As Integer
    Public DNI As String
    Public Telefono As String
    Public Habilitado As Boolean

    Public Property Direcciones As List(Of Direccion)

    Public Sub New()
        Direcciones = New List(Of Direccion)()
    End Sub

End Class
