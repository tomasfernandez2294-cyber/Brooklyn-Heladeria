
Imports MySql.Data.MySqlClient

Public Class ProductoOpcionalDAO

    ' ==========================================
    ' AGREGAR OPCIONAL A UN PRODUCTO
    ' ==========================================
    Public Shared Function Agregar(relacion As ProductoOpcional) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO PRODUCTO_OPCIONAL " &
                "(id_producto, id_opcional, precio, max_seleccion, grupo) " &
                "VALUES (@producto, @opcional, @precio, @maximo, @grupo)"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, relacion)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' LISTAR TODAS LAS RELACIONES
    ' ==========================================
    Public Shared Function Listar() As List(Of ProductoOpcional)

        Dim relaciones As New List(Of ProductoOpcional)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, id_opcional, precio, " &
                "max_seleccion, grupo FROM PRODUCTO_OPCIONAL"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        relaciones.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return relaciones

    End Function


    ' ==========================================
    ' LISTAR OPCIONALES DE UN PRODUCTO
    ' ==========================================
    Public Shared Function ListarPorProducto(
        idProducto As Integer) As List(Of ProductoOpcional)

        Dim relaciones As New List(Of ProductoOpcional)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, id_opcional, precio, " &
                "max_seleccion, grupo " &
                "FROM PRODUCTO_OPCIONAL " &
                "WHERE id_producto = @producto"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        relaciones.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return relaciones

    End Function


    ' ==========================================
    ' LISTAR PRODUCTOS DE UN OPCIONAL
    ' ==========================================
    Public Shared Function ListarPorOpcional(
        idOpcional As Integer) As List(Of ProductoOpcional)

        Dim relaciones As New List(Of ProductoOpcional)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, id_opcional, precio, " &
                "max_seleccion, grupo " &
                "FROM PRODUCTO_OPCIONAL " &
                "WHERE id_opcional = @opcional"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@opcional", idOpcional)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        relaciones.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return relaciones

    End Function


    ' ==========================================
    ' COMPROBAR SI EXISTE LA RELACION
    ' ==========================================
    Public Shared Function Existe(
        idProducto As Integer,
        idOpcional As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT COUNT(*) FROM PRODUCTO_OPCIONAL " &
                "WHERE id_producto = @producto " &
                "AND id_opcional = @opcional"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)
                cmd.Parameters.AddWithValue("@opcional", idOpcional)

                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' MODIFICAR RELACION PRODUCTO-OPCIONAL
    ' ==========================================
    Public Shared Function Modificar(relacion As ProductoOpcional) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE PRODUCTO_OPCIONAL SET " &
                "precio = @precio, " &
                "max_seleccion = @maximo, " &
                "grupo = @grupo " &
                "WHERE id_producto = @producto " &
                "AND id_opcional = @opcional"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, relacion)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' ELIMINAR OPCIONAL DE UN PRODUCTO
    ' ==========================================
    Public Shared Function Eliminar(
        idProducto As Integer,
        idOpcional As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM PRODUCTO_OPCIONAL " &
                "WHERE id_producto = @producto " &
                "AND id_opcional = @opcional"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)
                cmd.Parameters.AddWithValue("@opcional", idOpcional)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' ELIMINAR TODOS LOS OPCIONALES DE UN PRODUCTO
    ' ==========================================
    Public Shared Function EliminarPorProducto(
        idProducto As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM PRODUCTO_OPCIONAL " &
                "WHERE id_producto = @producto"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)

                cmd.ExecuteNonQuery()
                Return True

            End Using
        End Using

    End Function


    ' ==========================================
    ' GUARDAR TODOS LOS OPCIONALES DE UN PRODUCTO
    ' ==========================================
    Public Shared Function GuardarOpcionales(
        idProducto As Integer,
        opcionales As List(Of ProductoOpcional)) As Boolean

        If opcionales Is Nothing Then
            Throw New ArgumentNullException("opcionales")
        End If

        If opcionales.Any(Function(x) x Is Nothing OrElse
                         x.IDProducto <> idProducto) Then
            Throw New ArgumentException(
                "Todos los opcionales deben pertenecer al producto indicado.")
        End If

        If opcionales.GroupBy(Function(x) x.IDOpcional).
            Any(Function(g) g.Count() > 1) Then

            Throw New ArgumentException(
                "No puede repetirse el mismo opcional para un producto.")
        End If

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Using transaccion As MySqlTransaction =
                conexion.BeginTransaction()

                Try

                    Dim sqlEliminar As String =
                        "DELETE FROM PRODUCTO_OPCIONAL " &
                        "WHERE id_producto = @producto"

                    Using cmdEliminar As New MySqlCommand(
                        sqlEliminar, conexion, transaccion)

                        cmdEliminar.Parameters.AddWithValue(
                            "@producto", idProducto)

                        cmdEliminar.ExecuteNonQuery()

                    End Using

                    Dim sqlAgregar As String =
                        "INSERT INTO PRODUCTO_OPCIONAL " &
                        "(id_producto, id_opcional, precio, " &
                        "max_seleccion, grupo) " &
                        "VALUES (@producto, @opcional, @precio, " &
                        "@maximo, @grupo)"

                    For Each relacion As ProductoOpcional In opcionales

                        Using cmdAgregar As New MySqlCommand(
                            sqlAgregar, conexion, transaccion)

                            CargarParametros(cmdAgregar, relacion)

                            cmdAgregar.ExecuteNonQuery()

                        End Using

                    Next

                    transaccion.Commit()
                    Return True

                Catch
                    transaccion.Rollback()
                    Throw
                End Try

            End Using
        End Using

    End Function


    ' ==========================================
    ' CARGAR PARAMETROS
    ' ==========================================
    Private Shared Sub CargarParametros(
        cmd As MySqlCommand,
        relacion As ProductoOpcional)

        cmd.Parameters.AddWithValue(
            "@producto", relacion.IDProducto)

        cmd.Parameters.AddWithValue(
            "@opcional", relacion.IDOpcional)

        cmd.Parameters.AddWithValue(
            "@precio", relacion.Precio)

        cmd.Parameters.AddWithValue(
            "@maximo", relacion.MaxSeleccion)

        cmd.Parameters.AddWithValue(
            "@grupo", relacion.Grupo)

    End Sub


    ' ==========================================
    ' MAPEAR REGISTRO MYSQL A OBJETO
    ' ==========================================
    Private Shared Function Mapear(
        reader As MySqlDataReader) As ProductoOpcional

        Dim relacion As New ProductoOpcional()

        relacion.IDProducto =
            Convert.ToInt32(reader("id_producto"))

        relacion.IDOpcional =
            Convert.ToInt32(reader("id_opcional"))

        relacion.Precio =
            Convert.ToInt32(reader("precio"))

        relacion.MaxSeleccion =
            Convert.ToInt32(reader("max_seleccion"))

        relacion.Grupo =
            If(IsDBNull(reader("grupo")), "",
               Convert.ToString(reader("grupo")))

        Return relacion

    End Function

End Class
