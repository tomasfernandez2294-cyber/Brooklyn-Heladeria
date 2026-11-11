
Imports MySql.Data.MySqlClient

Public Class CarritoDAO

    ' ==========================================
    ' CREAR CARRITO
    ' ==========================================
    Public Shared Function Crear(idCliente As Integer) As Integer

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO CARRITO " &
                "(id_cliente, estado_carrito, fecha_creacion) " &
                "VALUES (@cliente, 'ACTIVO', NOW())"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@cliente", idCliente)
                cmd.ExecuteNonQuery()

                Return Convert.ToInt32(cmd.LastInsertedId)

            End Using
        End Using

    End Function


    ' ==========================================
    ' AGREGAR PRODUCTO AL CARRITO
    ' ==========================================
    Public Shared Function AgregarProducto(
        idCarrito As Integer,
        idProducto As Integer,
        cantidad As Integer,
        precioUnitario As Decimal) As Boolean

        If cantidad <= 0 Then
            Throw New ArgumentException("La cantidad debe ser mayor a cero.")
        End If

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO ITEM_CARRITO " &
                "(id_carrito, id_producto, cantidad, precio_unitario) " &
                "VALUES (@carrito, @producto, @cantidad, @precio)"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@carrito", idCarrito)
                cmd.Parameters.AddWithValue("@producto", idProducto)
                cmd.Parameters.AddWithValue("@cantidad", cantidad)
                cmd.Parameters.AddWithValue("@precio", precioUnitario)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' LISTAR PRODUCTOS DEL CARRITO
    ' ==========================================
    Public Shared Function ListarProductos(
        idCarrito As Integer) As DataTable

        Dim tabla As New DataTable()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT ic.id_item_carrito, " &
                "ic.id_producto, p.nombre_producto, " &
                "ic.cantidad, ic.precio_unitario, " &
                "(ic.cantidad * ic.precio_unitario) AS subtotal " &
                "FROM ITEM_CARRITO ic " &
                "INNER JOIN PRODUCTO p " &
                "ON ic.id_producto = p.id_producto " &
                "WHERE ic.id_carrito = @carrito"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@carrito", idCarrito)

                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using

            End Using
        End Using

        Return tabla

    End Function


    ' ==========================================
    ' MODIFICAR CANTIDAD
    ' ==========================================
    Public Shared Function ModificarCantidad(
        idItemCarrito As Integer,
        cantidad As Integer) As Boolean

        If cantidad <= 0 Then
            Throw New ArgumentException("La cantidad debe ser mayor a cero.")
        End If

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE ITEM_CARRITO " &
                "SET cantidad = @cantidad " &
                "WHERE id_item_carrito = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@cantidad", cantidad)
                cmd.Parameters.AddWithValue("@id", idItemCarrito)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' QUITAR PRODUCTO
    ' ==========================================
    Public Shared Function QuitarProducto(
        idItemCarrito As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM ITEM_CARRITO " &
                "WHERE id_item_carrito = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", idItemCarrito)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' CALCULAR TOTAL
    ' ==========================================
    Public Shared Function CalcularTotal(
        idCarrito As Integer) As Decimal

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT COALESCE(SUM(cantidad * precio_unitario), 0) " &
                "FROM ITEM_CARRITO " &
                "WHERE id_carrito = @carrito"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@carrito", idCarrito)

                Return Convert.ToDecimal(cmd.ExecuteScalar())

            End Using
        End Using

    End Function


    ' ==========================================
    ' VACIAR CARRITO
    ' ==========================================
    Public Shared Function Vaciar(
        idCarrito As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM ITEM_CARRITO " &
                "WHERE id_carrito = @carrito"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@carrito", idCarrito)

                cmd.ExecuteNonQuery()
                Return True

            End Using
        End Using

    End Function


    ' ==========================================
    ' CERRAR CARRITO
    ' ==========================================
    Public Shared Function Cerrar(
        idCarrito As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE CARRITO " &
                "SET estado_carrito = 'CERRADO' " &
                "WHERE id_carrito = @carrito"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@carrito", idCarrito)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function

End Class
