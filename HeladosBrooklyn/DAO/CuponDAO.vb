
Imports MySql.Data.MySqlClient

Public Class CuponDAO

    ' AGREGAR CUPON
    Public Shared Function Agregar(cupon As Cupon) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO CUPON " &
                "(codigo, tipo_descuento, valor, activo) " &
                "VALUES (@codigo, @tipo, @valor, @activo)"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@codigo", cupon.codigo)
                cmd.Parameters.AddWithValue("@tipo", cupon.tipoDescuento)
                cmd.Parameters.AddWithValue("@valor", cupon.valor)
                cmd.Parameters.AddWithValue("@activo", cupon.activo)

                cmd.ExecuteNonQuery()
                cupon.idCupon = Convert.ToInt32(cmd.LastInsertedId)

                Return True
            End Using
        End Using

    End Function


    ' LISTAR CUPONES
    Public Shared Function Listar() As List(Of Cupon)

        Dim lista As New List(Of Cupon)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_cupon, codigo, tipo_descuento, " &
                "valor, activo FROM CUPON"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        lista.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return lista

    End Function


    ' BUSCAR POR CODIGO
    Public Shared Function BuscarPorCodigo(codigo As String) As Cupon

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_cupon, codigo, tipo_descuento, " &
                "valor, activo FROM CUPON " &
                "WHERE codigo = @codigo LIMIT 1"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@codigo", codigo.Trim())

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return Mapear(reader)
                    End If
                End Using

            End Using
        End Using

        Return Nothing

    End Function


    ' MODIFICAR CUPON
    Public Shared Function Modificar(cupon As Cupon) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE CUPON SET " &
                "codigo = @codigo, " &
                "tipo_descuento = @tipo, " &
                "valor = @valor, " &
                "activo = @activo " &
                "WHERE id_cupon = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", cupon.idCupon)
                cmd.Parameters.AddWithValue("@codigo", cupon.codigo)
                cmd.Parameters.AddWithValue("@tipo", cupon.tipoDescuento)
                cmd.Parameters.AddWithValue("@valor", cupon.valor)
                cmd.Parameters.AddWithValue("@activo", cupon.activo)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' DESHABILITAR CUPON
    Public Shared Function Eliminar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE CUPON SET activo = 0 " &
                "WHERE id_cupon = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' CALCULAR DESCUENTO
    Public Shared Function CalcularDescuento(
        codigo As String,
        total As Decimal) As Decimal

        If total < 0D Then
            Throw New ArgumentException("El total no puede ser negativo.")
        End If

        Dim cupon As Cupon = BuscarPorCodigo(codigo)

        If cupon Is Nothing OrElse Not cupon.activo Then
            Return 0D
        End If

        Dim valor As Decimal = cupon.valor
        Dim descuento As Decimal

        Select Case cupon.tipoDescuento.Trim().ToUpperInvariant()

            Case "PORCENTAJE"
                If valor <= 0D OrElse valor > 100D Then
                    Return 0D
                End If
                descuento = total * valor / 100D

            Case "FIJO"
                If valor <= 0D Then
                    Return 0D
                End If
                descuento = valor

            Case Else
                Return 0D

        End Select

        Return Math.Min(total,
            Math.Round(descuento, 2,
                       MidpointRounding.AwayFromZero))

    End Function


    ' CONVERTIR REGISTRO A OBJETO
    Private Shared Function Mapear(
        reader As MySqlDataReader) As Cupon

        Dim cupon As New Cupon()

        cupon.idCupon = Convert.ToInt32(reader("id_cupon"))
        cupon.codigo = Convert.ToString(reader("codigo"))
        cupon.tipoDescuento =
            Convert.ToString(reader("tipo_descuento"))
        cupon.valor = Convert.ToDecimal(reader("valor"))
        cupon.activo =
            Convert.ToBoolean(reader("activo"))

        Return cupon

    End Function

End Class
