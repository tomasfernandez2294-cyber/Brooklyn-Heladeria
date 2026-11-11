
Imports MySql.Data.MySqlClient
Imports System.Linq

Public Class ProductoSaborDAO

    ' ==========================================
    ' AGREGAR SABOR A PRODUCTO
    ' ==========================================
    Public Shared Function Agregar(relacion As ProductoSabor) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO PRODUCTO_SABOR " &
                "(id_producto, id_sabor) " &
                "VALUES (@producto, @sabor)"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", relacion.IDProducto)
                cmd.Parameters.AddWithValue("@sabor", relacion.IDSabor)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' LISTAR TODAS LAS RELACIONES
    ' ==========================================
    Public Shared Function Listar() As List(Of ProductoSabor)

        Dim lista As New List(Of ProductoSabor)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, id_sabor " &
                "FROM PRODUCTO_SABOR"

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


    ' ==========================================
    ' LISTAR SABORES DE UN PRODUCTO
    ' ==========================================
    Public Shared Function ListarPorProducto(
        idProducto As Integer) As List(Of ProductoSabor)

        Dim lista As New List(Of ProductoSabor)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, id_sabor " &
                "FROM PRODUCTO_SABOR " &
                "WHERE id_producto = @producto"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        lista.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return lista

    End Function


    ' ==========================================
    ' LISTAR PRODUCTOS DE UN SABOR
    ' ==========================================
    Public Shared Function ListarPorSabor(
        idSabor As Integer) As List(Of ProductoSabor)

        Dim lista As New List(Of ProductoSabor)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_producto, id_sabor " &
                "FROM PRODUCTO_SABOR " &
                "WHERE id_sabor = @sabor"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@sabor", idSabor)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        lista.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return lista

    End Function


    ' ==========================================
    ' VERIFICAR SI EXISTE RELACION
    ' ==========================================
    Public Shared Function Existe(
        idProducto As Integer,
        idSabor As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT COUNT(*) FROM PRODUCTO_SABOR " &
                "WHERE id_producto = @producto " &
                "AND id_sabor = @sabor"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)
                cmd.Parameters.AddWithValue("@sabor", idSabor)

                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' ELIMINAR RELACION ESPECIFICA
    ' ==========================================
    Public Shared Function Eliminar(
        idProducto As Integer,
        idSabor As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM PRODUCTO_SABOR " &
                "WHERE id_producto = @producto " &
                "AND id_sabor = @sabor"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)
                cmd.Parameters.AddWithValue("@sabor", idSabor)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' ELIMINAR SABORES DE UN PRODUCTO
    ' ==========================================
    Public Shared Function EliminarPorProducto(
        idProducto As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM PRODUCTO_SABOR " &
                "WHERE id_producto = @producto"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@producto", idProducto)

                cmd.ExecuteNonQuery()

                Return True

            End Using
        End Using

    End Function


    ' ==========================================
    ' GUARDAR TODOS LOS SABORES DE UN PRODUCTO
    ' ==========================================
    Public Shared Function GuardarSabores(
        idProducto As Integer,
        idsSabores As List(Of Integer)) As Boolean

        If idsSabores Is Nothing Then
            Throw New ArgumentNullException("idsSabores")
        End If

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Using transaccion As MySqlTransaction =
                conexion.BeginTransaction()

                Try

                    ' Eliminar asociaciones anteriores
                    Dim sqlEliminar As String =
                        "DELETE FROM PRODUCTO_SABOR " &
                        "WHERE id_producto = @producto"

                    Using cmdEliminar As New MySqlCommand(
                        sqlEliminar, conexion, transaccion)

                        cmdEliminar.Parameters.AddWithValue(
                            "@producto", idProducto)

                        cmdEliminar.ExecuteNonQuery()

                    End Using

                    ' Insertar asociaciones seleccionadas
                    Dim sqlAgregar As String =
                        "INSERT INTO PRODUCTO_SABOR " &
                        "(id_producto, id_sabor) " &
                        "VALUES (@producto, @sabor)"

                    For Each idSabor As Integer In idsSabores.Distinct()

                        Using cmdAgregar As New MySqlCommand(
                            sqlAgregar, conexion, transaccion)

                            cmdAgregar.Parameters.AddWithValue(
                                "@producto", idProducto)

                            cmdAgregar.Parameters.AddWithValue(
                                "@sabor", idSabor)

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
    ' MAPEAR REGISTRO MYSQL A OBJETO
    ' ==========================================
    Private Shared Function Mapear(
        reader As MySqlDataReader) As ProductoSabor

        Dim relacion As New ProductoSabor()

        relacion.IDProducto =
            Convert.ToInt32(reader("id_producto"))

        relacion.IDSabor =
            Convert.ToInt32(reader("id_sabor"))

        Return relacion

    End Function

End Class
