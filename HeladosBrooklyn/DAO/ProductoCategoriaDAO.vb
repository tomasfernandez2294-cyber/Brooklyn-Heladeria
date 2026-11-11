
Imports MySql.Data.MySqlClient

Public Class ProductoCategoriaDAO

    ' ==========================================
    ' ASIGNAR CATEGORIA A PRODUCTO
    ' ==========================================
    Public Shared Function Agregar(relacion As ProductoCategoria) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO PRODUCTO_CATEGORIA " &
                "(id_producto, id_categoria) " &
                "VALUES (@producto, @categoria)"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", relacion.IDProducto)
                cmd.Parameters.AddWithValue("@categoria", relacion.IDCategoria)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' LISTAR TODAS LAS RELACIONES
    ' ==========================================
    Public Shared Function Listar() As List(Of ProductoCategoria)

        Dim relaciones As New List(Of ProductoCategoria)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, id_categoria " &
                "FROM PRODUCTO_CATEGORIA"

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
    ' LISTAR CATEGORIAS DE UN PRODUCTO
    ' ==========================================
    Public Shared Function ListarPorProducto(
        idProducto As Integer) As List(Of ProductoCategoria)

        Dim relaciones As New List(Of ProductoCategoria)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, id_categoria " &
                "FROM PRODUCTO_CATEGORIA " &
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
    ' LISTAR PRODUCTOS DE UNA CATEGORIA
    ' ==========================================
    Public Shared Function ListarPorCategoria(
        idCategoria As Integer) As List(Of ProductoCategoria)

        Dim relaciones As New List(Of ProductoCategoria)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, id_categoria " &
                "FROM PRODUCTO_CATEGORIA " &
                "WHERE id_categoria = @categoria"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@categoria", idCategoria)

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
        idCategoria As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT COUNT(*) FROM PRODUCTO_CATEGORIA " &
                "WHERE id_producto = @producto " &
                "AND id_categoria = @categoria"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)
                cmd.Parameters.AddWithValue("@categoria", idCategoria)

                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' QUITAR UNA CATEGORIA DE UN PRODUCTO
    ' ==========================================
    Public Shared Function Eliminar(
        idProducto As Integer,
        idCategoria As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM PRODUCTO_CATEGORIA " &
                "WHERE id_producto = @producto " &
                "AND id_categoria = @categoria"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)
                cmd.Parameters.AddWithValue("@categoria", idCategoria)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' QUITAR TODAS LAS CATEGORIAS DE UN PRODUCTO
    ' ==========================================
    Public Shared Function EliminarPorProducto(
        idProducto As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM PRODUCTO_CATEGORIA " &
                "WHERE id_producto = @producto"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)

                cmd.ExecuteNonQuery()
                Return True

            End Using
        End Using

    End Function


    ' ==========================================
    ' REEMPLAZAR CATEGORIAS DE UN PRODUCTO
    ' ==========================================
    Public Shared Function GuardarCategorias(
        idProducto As Integer,
        idsCategorias As List(Of Integer)) As Boolean

        If idsCategorias Is Nothing Then
            Throw New ArgumentNullException("idsCategorias")
        End If

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Using transaccion As MySqlTransaction =
                conexion.BeginTransaction()

                Try

                    Dim sqlEliminar As String =
                        "DELETE FROM PRODUCTO_CATEGORIA " &
                        "WHERE id_producto = @producto"

                    Using cmdEliminar As New MySqlCommand(
                        sqlEliminar, conexion, transaccion)

                        cmdEliminar.Parameters.AddWithValue(
                            "@producto", idProducto)

                        cmdEliminar.ExecuteNonQuery()

                    End Using

                    Dim sqlAgregar As String =
                        "INSERT INTO PRODUCTO_CATEGORIA " &
                        "(id_producto, id_categoria) " &
                        "VALUES (@producto, @categoria)"

                    For Each idCategoria As Integer In idsCategorias.Distinct()

                        Using cmdAgregar As New MySqlCommand(
                            sqlAgregar, conexion, transaccion)

                            cmdAgregar.Parameters.AddWithValue(
                                "@producto", idProducto)

                            cmdAgregar.Parameters.AddWithValue(
                                "@categoria", idCategoria)

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
    ' CONVERTIR REGISTRO MYSQL A OBJETO
    ' ==========================================
    Private Shared Function Mapear(
        reader As MySqlDataReader) As ProductoCategoria

        Dim relacion As New ProductoCategoria()

        relacion.IDProducto =
            Convert.ToInt32(reader("id_producto"))

        relacion.IDCategoria =
            Convert.ToInt32(reader("id_categoria"))

        Return relacion

    End Function

End Class
