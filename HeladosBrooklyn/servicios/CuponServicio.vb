Public Class CuponServicio

    ' Generar un código aleatorio de cupón
    Public Shared Function GenerarCodigo() As String

        Dim codigo As String =
            Guid.NewGuid().ToString("N").
            Substring(0, 10).ToUpper()

        Return "BROOKLYN-" & codigo

    End Function

End Class
