
Imports MySql.Data.MySqlClient

Public Class PedidoDAO

    ' ==========================================
    ' AGREGAR PEDIDO
    ' ==========================================
    Public Shared Function Agregar(pedido As Pedido) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO PEDIDO " &
                "(numero_pedido, fecha_pedido, subtotal, total, " &
                "estado_pedido, estado_pago) " &
                "VALUES (@numero, @fecha, @subtotal, @total, " &
                "@estadoPedido, @estadoPago)"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, pedido)

                cmd.ExecuteNonQuery()

                pedido.id = Convert.ToInt32(cmd.LastInsertedId)

                Return True

            End Using
        End Using

    End Function


    ' ==========================================
    ' LISTAR PEDIDOS
    ' ==========================================
    Public Shared Function Listar() As List(Of Pedido)

        Dim pedidos As New List(Of Pedido)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_pedido, numero_pedido, fecha_pedido, " &
                "subtotal, total, estado_pedido, estado_pago " &
                "FROM PEDIDO ORDER BY fecha_pedido DESC"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        pedidos.Add(MapearPedido(reader))
                    End While

                End Using
            End Using
        End Using

        Return pedidos

    End Function


    ' ==========================================
    ' BUSCAR PEDIDO POR ID
    ' ==========================================
    Public Shared Function BuscarPorID(id As Integer) As Pedido

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_pedido, numero_pedido, fecha_pedido, " &
                "subtotal, total, estado_pedido, estado_pago " &
                "FROM PEDIDO WHERE id_pedido = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        Return MapearPedido(reader)
                    End If

                End Using
            End Using
        End Using

        Return Nothing

    End Function


    ' ==========================================
    ' BUSCAR PEDIDO POR NUMERO
    ' ==========================================
    Public Shared Function BuscarPorNumero(numero As String) As Pedido

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_pedido, numero_pedido, fecha_pedido, " &
                "subtotal, total, estado_pedido, estado_pago " &
                "FROM PEDIDO WHERE numero_pedido = @numero LIMIT 1"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@numero", numero)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        Return MapearPedido(reader)
                    End If

                End Using
            End Using
        End Using

        Return Nothing

    End Function


    ' ==========================================
    ' MODIFICAR PEDIDO
    ' ==========================================
    Public Shared Function Modificar(pedido As Pedido) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE PEDIDO SET " &
                "numero_pedido = @numero, " &
                "fecha_pedido = @fecha, " &
                "subtotal = @subtotal, " &
                "total = @total, " &
                "estado_pedido = @estadoPedido, " &
                "estado_pago = @estadoPago " &
                "WHERE id_pedido = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, pedido)
                cmd.Parameters.AddWithValue("@id", pedido.id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' CAMBIAR ESTADO DEL PEDIDO
    ' ==========================================
    Public Shared Function CambiarEstadoPedido(
        id As Integer,
        nuevoEstado As EstadoPedido) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE PEDIDO SET estado_pedido = @estado " &
                "WHERE id_pedido = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue(
                    "@estado", nuevoEstado.ToString())

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' CAMBIAR ESTADO DEL PAGO
    ' ==========================================
    Public Shared Function CambiarEstadoPago(
        id As Integer,
        nuevoEstado As EstadoPago) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE PEDIDO SET estado_pago = @estado " &
                "WHERE id_pedido = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue(
                    "@estado", nuevoEstado.ToString())

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' CANCELAR PEDIDO
    ' ==========================================
    Public Shared Function Cancelar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE PEDIDO SET estado_pedido = @estado " &
                "WHERE id_pedido = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue(
                    "@estado", EstadoPedido.Cancelado.ToString())

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' CARGAR PARAMETROS SQL
    ' ==========================================
    Private Shared Sub CargarParametros(
        cmd As MySqlCommand,
        pedido As Pedido)

        cmd.Parameters.AddWithValue(
            "@numero", pedido.NumeroPedido)

        cmd.Parameters.AddWithValue(
            "@fecha", pedido.fechaPedido)

        cmd.Parameters.AddWithValue(
            "@subtotal", Convert.ToDecimal(pedido.subTotal))

        cmd.Parameters.AddWithValue(
            "@total", Convert.ToDecimal(pedido.total))

        cmd.Parameters.AddWithValue(
            "@estadoPedido", pedido.estadoPedido.ToString())

        cmd.Parameters.AddWithValue(
            "@estadoPago", pedido.estadoPago.ToString())

    End Sub


    ' ==========================================
    ' CONVERTIR REGISTRO MYSQL A PEDIDO
    ' ==========================================
    Private Shared Function MapearPedido(
        reader As MySqlDataReader) As Pedido

        Dim pedido As New Pedido()

        pedido.id = Convert.ToInt32(reader("id_pedido"))

        pedido.NumeroPedido =
            Convert.ToString(reader("numero_pedido"))

        pedido.fechaPedido =
            Convert.ToDateTime(reader("fecha_pedido"))

        pedido.subTotal =
            Convert.ToDouble(reader("subtotal"))

        pedido.total =
            Convert.ToDouble(reader("total"))

        pedido.estadoPedido =
            CType([Enum].Parse(
                GetType(EstadoPedido),
                Convert.ToString(reader("estado_pedido")),
                True), EstadoPedido)

        pedido.estadoPago =
            CType([Enum].Parse(
                GetType(EstadoPago),
                Convert.ToString(reader("estado_pago")),
                True), EstadoPago)

        Return pedido

    End Function

End Class
