
Public Class ClienteServicio

    ' ==========================================
    ' VALIDAR DATOS DEL CLIENTE
    ' ==========================================
    Public Shared Function ValidarDatos(
        nombre As String,
        apellido As String,
        telefono As String
    ) As Boolean

        If String.IsNullOrWhiteSpace(nombre) Then
            Return False
        End If

        If String.IsNullOrWhiteSpace(apellido) Then
            Return False
        End If

        If String.IsNullOrWhiteSpace(telefono) Then
            Return False
        End If

        Return True

    End Function


    ' ==========================================
    ' NORMALIZAR TELEFONO
    ' ==========================================
    Public Shared Function NormalizarTelefono(
        telefono As String
    ) As String

        If telefono Is Nothing Then Return ""

        ' Elimina espacios y separadores visuales.
        ' Todavía no convierte formatos nacionales
        ' e internacionales a un formato único.
        Return telefono.Trim().
            Replace(" ", "").
            Replace("-", "").
            Replace("(", "").
            Replace(")", "")

    End Function


    ' ==========================================
    ' VERIFICAR SI EL CLIENTE YA EXISTE
    ' ==========================================
    Public Shared Function ValidarCliente(
        telefono As String
    ) As Boolean

        Dim telefonoNormalizado As String =
            NormalizarTelefono(telefono)

        Dim clienteExistente As Cliente =
            ClienteDAO.BuscarPorTelefono(telefonoNormalizado)

        Return clienteExistente Is Nothing

    End Function

End Class
