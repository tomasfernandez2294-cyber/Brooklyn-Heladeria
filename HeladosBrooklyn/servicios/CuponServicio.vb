Public Class CuponServicio

    ' Generar un código aleatorio de cupón
    Public Shared Function GenerarCodigo() As String

        Dim codigo As String =
            Guid.NewGuid().ToString("N").
            Substring(0, 10).ToUpper()

        Return "BROOKLYN-" & codigo

    End Function

    'funcion para calcular el descuento
    Public Shared Function CalcularDescuento(
    cupon As Cupon,
    subtotal As Decimal
) As Decimal

        If cupon Is Nothing Then Return 0D

        If Not cupon.activo Then Return 0D

        If subtotal <= 0D Then Return 0D

        Dim valor As Decimal = CDec(cupon.valor)

        If valor <= 0D Then Return 0D

        Select Case cupon.tipoDescuento.Trim().ToUpperInvariant()

            Case "PORCENTAJE"

                If valor > 100D Then Return 0D

                Return Math.Round(
                    subtotal * valor / 100D,
                    2)

            Case "FIJO"

                Return Math.Min(valor, subtotal)

            Case Else

                Return 0D

        End Select

    End Function
End Class
