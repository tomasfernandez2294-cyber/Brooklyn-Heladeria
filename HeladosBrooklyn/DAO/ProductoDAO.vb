
Imports MySql.Data.MySqlClient

Public Class ProductoDAO

    ' ==========================================
    ' AGREGAR PRODUCTO
    ' ==========================================
    Public Shared Function Agregar(producto As Producto) As Boolean

        Try
            Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()

                Dim sql As String =
                    "INSERT INTO PRODUCTO " &
                    "(nombre_producto, descripcion_producto, orden, " &
                    "precio, activo_producto, imagen, max_marcrote, " &
                    "max_sabores, max_salsas, permitir_notas) " &
                    "VALUES (@nombre, @descripcion, @orden, " &
                    "@precio, @activo, @imagen, @maxMarrocotes, " &
                    "@maxSabores, @maxSalsas, @permitirNotas)"

                Using cmd As New MySqlCommand(sql, conexion)

                    CargarParametros(cmd, producto)

                    cmd.ExecuteNonQuery()

                    producto.IDProducto =
                        Convert.ToInt32(cmd.LastInsertedId)

                    Return True

                End Using
            End Using

        Catch ex As Exception
            Throw New Exception(
                "Error al agregar producto: " & ex.Message, ex)
        End Try

    End Function


    ' ==========================================
    ' LISTAR PRODUCTOS
    ' ==========================================
    Public Shared Function Listar() As List(Of Producto)

        Dim productos As New List(Of Producto)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, nombre_producto, " &
                "descripcion_producto, orden, precio, " &
                "activo_producto, imagen, max_marcrote, " &
                "max_sabores, max_salsas, permitir_notas " &
                "FROM PRODUCTO ORDER BY orden, nombre_producto"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        productos.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return productos

    End Function


    ' ==========================================
    ' BUSCAR PRODUCTO POR ID
    ' ==========================================
    Public Shared Function BuscarPorID(id As Integer) As Producto

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, nombre_producto, " &
                "descripcion_producto, orden, precio, " &
                "activo_producto, imagen, max_marcrote, " &
                "max_sabores, max_salsas, permitir_notas " &
                "FROM PRODUCTO WHERE id_producto = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        Return Mapear(reader)
                    End If

                End Using
            End Using
        End Using

        Return Nothing

    End Function


    ' ==========================================
    ' MODIFICAR PRODUCTO
    ' ==========================================
    Public Shared Function Modificar(producto As Producto) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE PRODUCTO SET " &
                "nombre_producto = @nombre, " &
                "descripcion_producto = @descripcion, " &
                "orden = @orden, " &
                "precio = @precio, " &
                "activo_producto = @activo, " &
                "imagen = @imagen, " &
                "max_marcrote = @maxMarrocotes, " &
                "max_sabores = @maxSabores, " &
                "max_salsas = @maxSalsas, " &
                "permitir_notas = @permitirNotas " &
                "WHERE id_producto = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, producto)

                cmd.Parameters.AddWithValue(
                    "@id", producto.IDProducto)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' ELIMINAR PRODUCTO (BAJA LOGICA)
    ' ==========================================
    Public Shared Function Eliminar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE PRODUCTO SET activo_producto = 0 " &
                "WHERE id_producto = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' REACTIVAR PRODUCTO
    ' ==========================================
    Public Shared Function Reactivar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE PRODUCTO SET activo_producto = 1 " &
                "WHERE id_producto = @id"

            Using cmd As New MySqlCommand(sql, conexion)

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
        producto As Producto)

        cmd.Parameters.AddWithValue(
            "@nombre", producto.NombreProducto)

        cmd.Parameters.AddWithValue(
            "@descripcion",
            If(producto.Descripcion Is Nothing,
               CType(DBNull.Value, Object),
               producto.Descripcion))

        cmd.Parameters.AddWithValue(
            "@orden", producto.Orden)

        cmd.Parameters.AddWithValue(
            "@precio", producto.Precio)

        cmd.Parameters.AddWithValue(
            "@activo", producto.Activo)

        cmd.Parameters.AddWithValue(
            "@imagen",
            If(producto.Imagen Is Nothing,
               CType(DBNull.Value, Object),
               producto.Imagen))

        cmd.Parameters.AddWithValue(
            "@maxMarrocotes", producto.MaxMarrocotes)

        cmd.Parameters.AddWithValue(
            "@maxSabores", producto.MaxSabores)

        cmd.Parameters.AddWithValue(
            "@maxSalsas", producto.MaxSalsas)

        cmd.Parameters.AddWithValue(
            "@permitirNotas", producto.PermitirNotas)

    End Sub


    ' ==========================================
    ' MAPEAR REGISTRO MYSQL A OBJETO PRODUCTO
    ' ==========================================
    Private Shared Function Mapear(
        reader As MySqlDataReader) As Producto

        Dim producto As New Producto()

        producto.IDProducto =
            Convert.ToInt32(reader("id_producto"))

        producto.NombreProducto =
            Convert.ToString(reader("nombre_producto"))

        producto.Descripcion =
            If(IsDBNull(reader("descripcion_producto")), "",
               Convert.ToString(reader("descripcion_producto")))

        producto.Orden =
            Convert.ToInt32(reader("orden"))

        producto.Precio =
            Convert.ToDecimal(reader("precio"))

        producto.Activo =
            Convert.ToBoolean(reader("activo_producto"))

        producto.Imagen =
            If(IsDBNull(reader("imagen")), "",
               Convert.ToString(reader("imagen")))

        producto.MaxMarrocotes =
            Convert.ToInt32(reader("max_marcrote"))

        producto.MaxSabores =
            Convert.ToInt32(reader("max_sabores"))

        producto.MaxSalsas =
            Convert.ToInt32(reader("max_salsas"))

        producto.PermitirNotas =
            Convert.ToBoolean(reader("permitir_notas"))

        Return producto

    End Function

End Class
