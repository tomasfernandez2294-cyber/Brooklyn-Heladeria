
Imports MySql.Data.MySqlClient

Public Class PedidoDAO

    ' ==========================================
    ' AGREGAR PEDIDO
    ' ==========================================

    Public Shared Function Agregar(pedido As Pedido) As Boolean

        If pedido Is Nothing OrElse pedido.Carrito Is Nothing Then
            Throw New Exception("El pedido no tiene carrito.")
        End If

        If pedido.Cliente Is Nothing OrElse
       pedido.Cliente.IDCliente <= 0 Then
            Throw New Exception("Falta identificar al cliente.")
        End If

        If pedido.MetodoEntrega Is Nothing Then
            Throw New Exception("Falta el método de entrega.")
        End If

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()

            conexion.Open()

            Using transaccion As MySqlTransaction =
            conexion.BeginTransaction()

                Try
                    ' 1. GUARDAR PEDIDO
                    Dim sqlPedido As String =
                    "INSERT INTO pedido " &
                    "(id_cliente, id_metodo_entrega, numero_pedido, " &
                    "fecha_pedido, estado_pedido, estado_pago, " &
                    "monto_descuento_congelado, total) " &
                    "VALUES (@cliente, @entrega, @numero, " &
                    "@fecha, @estado, @pago, @descuento, @total)"

                    Dim idPedido As Long

                    Using cmd As New MySqlCommand(
                    sqlPedido, conexion, transaccion)

                        cmd.Parameters.AddWithValue(
                        "@cliente", pedido.Cliente.IDCliente)

                        cmd.Parameters.AddWithValue(
                        "@entrega",
                        pedido.MetodoEntrega.IDMetodoEntrega)

                        cmd.Parameters.AddWithValue(
                        "@numero", pedido.NumeroPedido)

                        cmd.Parameters.AddWithValue(
                        "@fecha", pedido.fechaPedido)

                        cmd.Parameters.AddWithValue(
    "@estado", pedido.estadoPedido.ToString())

                        cmd.Parameters.AddWithValue(
                        "@pago", pedido.estadoPago.ToString())

                        cmd.Parameters.AddWithValue(
                        "@descuento",
                        pedido.Carrito.CalcularDescuento())

                        cmd.Parameters.AddWithValue(
                        "@total", pedido.total)

                        cmd.ExecuteNonQuery()

                        idPedido = cmd.LastInsertedId

                    End Using

                    ' 2. GUARDAR PRODUCTOS
                    For Each item As ItemCarrito In pedido.Carrito.Items

                        Dim sqlDetalle As String =
                        "INSERT INTO detalle_pedido " &
                        "(id_pedido, id_producto, cantidad, " &
                        "precio_unitario, nota_adicional) " &
                        "VALUES (@pedido, @producto, @cantidad, " &
                        "@precio, @nota)"

                        Dim idDetalle As Long

                        Using cmd As New MySqlCommand(
                        sqlDetalle, conexion, transaccion)

                            cmd.Parameters.AddWithValue(
                            "@pedido", idPedido)

                            cmd.Parameters.AddWithValue(
                            "@producto", item.producto.IDProducto)

                            cmd.Parameters.AddWithValue(
                            "@cantidad", item.cantidad)

                            cmd.Parameters.AddWithValue(
                            "@precio",
                            Convert.ToDecimal(item.subtotal) /
                            item.cantidad)

                            cmd.Parameters.AddWithValue(
                            "@nota",
                            If(item.NotaAdicional, ""))

                            cmd.ExecuteNonQuery()

                            idDetalle = cmd.LastInsertedId

                        End Using

                        ' 3. GUARDAR SABORES
                        If item.SaboresSeleccionados IsNot Nothing Then

                            For Each sabor As Sabor In item.SaboresSeleccionados

                                Dim sqlSabor As String =
                                "INSERT INTO detalle_pedido_sabor " &
                                "(id_detalle_pedido, id_sabor) " &
                                "VALUES (@detalle, @sabor)"

                                Using cmd As New MySqlCommand(
                                sqlSabor, conexion, transaccion)

                                    cmd.Parameters.AddWithValue(
                                    "@detalle", idDetalle)

                                    cmd.Parameters.AddWithValue(
                                    "@sabor", sabor.IDSabor)

                                    cmd.ExecuteNonQuery()

                                End Using

                            Next

                        End If

                    Next

                    transaccion.Commit()

                    pedido.id = Convert.ToInt32(idPedido)

                    Return True

                Catch
                    transaccion.Rollback()
                    Throw
                End Try

            End Using

        End Using

    End Function


    ' ==========================================
    ' LISTAR PEDIDOS
    ' ==========================================
    Public Shared Function Listar() As List(Of Pedido)

        Dim pedidos As New List(Of Pedido)()

        Using conexion As MySqlConnection =
            ConexionBD.ObtenerConexion()

            conexion.Open()

            Dim sql As String =
    "SELECT id_pedido, " &
    "id_cliente, " &
    "id_metodo_entrega, " &
    "numero_pedido, " &
    "fecha_pedido, " &
    "total, " &
    "monto_descuento_congelado, " &
    "costo_envio_congelado, " &
    "estado_pedido, " &
    "estado_pago " &
    "FROM pedido " &
    "ORDER BY fecha_pedido DESC"

            Using cmd As New MySqlCommand(sql, conexion)

                Using reader As MySqlDataReader =
                    cmd.ExecuteReader()

                    While reader.Read()
                        pedidos.Add(MapearPedido(reader))
                    End While

                End Using

            End Using
        End Using


        Return pedidos

    End Function


    ' ==========================================
    ' BUSCAR POR ID
    ' ==========================================
    Public Shared Function BuscarPorID(
        id As Integer) As Pedido

        Using conexion As MySqlConnection =
            ConexionBD.ObtenerConexion()

            conexion.Open()

            Dim sql As String =
                "SELECT id_pedido, numero_pedido, " &
                "fecha_pedido, total, monto_descuento_congelado, " &
                "costo_envio_congelado, " &
                "estado_pedido, estado_pago " &
                "FROM pedido WHERE id_pedido = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Using reader As MySqlDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() Then
                        Return MapearPedido(reader)
                    End If

                End Using

            End Using
        End Using

        Return Nothing

    End Function


    ' ==========================================
    ' BUSCAR POR NUMERO
    ' ==========================================
    Public Shared Function BuscarPorNumero(
        numero As String) As Pedido

        Using conexion As MySqlConnection =
            ConexionBD.ObtenerConexion()

            conexion.Open()

            Dim sql As String =
                "SELECT id_pedido, numero_pedido, " &
                "fecha_pedido, total, monto_descuento_congelado, " &
                "costo_envio_congelado, " &
                "estado_pedido, estado_pago " &
                "FROM pedido " &
                "WHERE numero_pedido = @numero LIMIT 1"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue(
                    "@numero", numero)

                Using reader As MySqlDataReader =
                    cmd.ExecuteReader()

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
    Public Shared Function Modificar(
        pedido As Pedido) As Boolean

        Using conexion As MySqlConnection =
            ConexionBD.ObtenerConexion()

            conexion.Open()

            Dim sql As String =
                "UPDATE pedido SET " &
                "numero_pedido = @numero, " &
                "fecha_pedido = @fecha, " &
                "total = @total, " &
                "estado_pedido = @estadoPedido, " &
                "estado_pago = @estadoPago " &
                "WHERE id_pedido = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue(
                    "@numero", pedido.NumeroPedido)

                cmd.Parameters.AddWithValue(
                    "@fecha", pedido.fechaPedido)

                cmd.Parameters.AddWithValue(
                    "@total",
                    Convert.ToDecimal(pedido.total))

                cmd.Parameters.AddWithValue(
                    "@estadoPedido",
                    pedido.estadoPedido.ToString())

                cmd.Parameters.AddWithValue(
                    "@estadoPago",
                    pedido.estadoPago.ToString())

                cmd.Parameters.AddWithValue(
                    "@id", pedido.id)

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

        Using conexion As MySqlConnection =
            ConexionBD.ObtenerConexion()

            conexion.Open()

            Dim sql As String =
                "UPDATE pedido " &
                "SET estado_pedido = @estado " &
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

        Using conexion As MySqlConnection =
            ConexionBD.ObtenerConexion()

            conexion.Open()

            Dim sql As String =
                "UPDATE pedido " &
                "SET estado_pago = @estado " &
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

        Return CambiarEstadoPedido(
        id, EstadoPedido.CANCELADO)

    End Function


    ' ==========================================
    ' MAPEAR REGISTRO MYSQL A PEDIDO
    ' ==========================================
    Private Shared Function MapearPedido(
        reader As MySqlDataReader) As Pedido

        Dim pedido As New Pedido()

        pedido.id =
            Convert.ToInt32(reader("id_pedido"))

        pedido.NumeroPedido =
            Convert.ToString(reader("numero_pedido"))

        pedido.fechaPedido =
            Convert.ToDateTime(reader("fecha_pedido"))

        pedido.total =
            Convert.ToDouble(reader("total"))

        ' Calcular subtotal a partir de los
        ' campos existentes en MySQL
        Dim descuento As Decimal =
            Convert.ToDecimal(reader("monto_descuento_congelado"))

        Dim costoEnvio As Decimal =
            Convert.ToDecimal(reader("costo_envio_congelado"))

        pedido.subTotal =
            Convert.ToDouble(
                Convert.ToDecimal(pedido.total) +
                descuento - costoEnvio)

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

        ' RECUPERAR MÉTODO DE ENTREGA
        Dim idEntrega As Integer =
    Convert.ToInt32(reader("id_metodo_entrega"))

        pedido.MetodoEntrega = New MetodoEntrega()

        pedido.MetodoEntrega.IDMetodoEntrega = idEntrega

        Select Case idEntrega

            Case 1
                pedido.MetodoEntrega.Nombre = "Delivery"

            Case 2
                pedido.MetodoEntrega.Nombre = "Retiro en el local"

        End Select
        Return pedido

    End Function

End Class
