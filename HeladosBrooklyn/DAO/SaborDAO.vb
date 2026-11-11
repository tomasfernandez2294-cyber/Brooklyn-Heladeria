Imports MySql.Data.MySqlClient

Public Class SaborDAO

    ' ==========================================
    ' AGREGAR SABOR
    ' ==========================================
    Public Shared Function Agregar(sabor As Sabor) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO SABOR " &
                "(nombre_sabor, stock, activo_sabor, descripcion) " &
                "VALUES (@nombre, @stock, @activo, @descripcion)"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, sabor)

                cmd.ExecuteNonQuery()

                sabor.IDSabor =
                    Convert.ToInt32(cmd.LastInsertedId)

                Return True

            End Using
        End Using

    End Function


    ' ==========================================
    ' LISTAR TODOS LOS SABORES
    ' ==========================================
    Public Shared Function Listar() As List(Of Sabor)

        Dim sabores As New List(Of Sabor)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_sabor, nombre_sabor, stock, " &
                "activo_sabor, descripcion FROM SABOR " &
                "ORDER BY nombre_sabor"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        sabores.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return sabores

    End Function


    ' ==========================================
    ' LISTAR SABORES ACTIVOS
    ' ==========================================
    Public Shared Function ListarActivos() As List(Of Sabor)

        Dim sabores As New List(Of Sabor)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_sabor, nombre_sabor, stock, " &
                "activo_sabor, descripcion FROM SABOR " &
                "WHERE activo = 1 ORDER BY nombre_sabor"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        sabores.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return sabores

    End Function


    ' ==========================================
    ' BUSCAR SABOR POR ID
    ' ==========================================
    Public Shared Function BuscarPorID(id As Integer) As Sabor

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_sabor, nombre_sabor, stock, " &
                "activo_sabor, descripcion FROM SABOR " &
                "WHERE id_sabor = @id"

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
    ' BUSCAR SABOR POR NOMBRE
    ' ==========================================
    Public Shared Function BuscarPorNombre(
        nombre As String) As Sabor

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_sabor, nombre_sabor, stock, " &
                "activo_sabor, descripcion FROM SABOR " &
                "WHERE nombre_sabor = @nombre LIMIT 1"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@nombre", nombre)

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
    ' MODIFICAR SABOR
    ' ==========================================
    Public Shared Function Modificar(sabor As Sabor) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE SABOR SET " &
                "nombre_sabor = @nombre, " &
                "stock = @stock, " &
                "activo_sabor = @activo, " &
                "descripcion = @descripcion " &
                "WHERE id_sabor = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, sabor)

                cmd.Parameters.AddWithValue(
                    "@id", sabor.IDSabor)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' DESACTIVAR SABOR
    ' ==========================================
    Public Shared Function Eliminar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE SABOR SET activo_sabor = 0 " &
                "WHERE id_sabor = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' REACTIVAR SABOR
    ' ==========================================
    Public Shared Function Reactivar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE SABOR SET activo_sabor = 1 " &
                "WHERE id_sabor = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' ACTUALIZAR STOCK
    ' ==========================================
    Public Shared Function ActualizarStock(
        id As Integer,
        nuevoStock As Integer) As Boolean

        If nuevoStock < 0 Then
            Throw New ArgumentException(
                "El stock no puede ser negativo.")
        End If

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE SABOR SET stock = @stock " &
                "WHERE id_sabor = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@stock", nuevoStock)
                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' DESCONTAR STOCK
    ' ==========================================
    Public Shared Function DescontarStock(
        id As Integer,
        cantidad As Integer) As Boolean

        If cantidad <= 0 Then
            Throw New ArgumentException(
                "La cantidad debe ser mayor a cero.")
        End If

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE SABOR SET stock = stock - @cantidad " &
                "WHERE id_sabor = @id AND stock >= @cantidad"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@cantidad", cantidad)
                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' LISTAR SABORES DISPONIBLES DE UN PRODUCTO
    ' ==========================================
    Public Shared Function ListarPorProducto(
        idProducto As Integer) As List(Of Sabor)

        Dim sabores As New List(Of Sabor)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT s.id_sabor, s.nombre_sabor, s.stock, " &
                "s.activo_sabor, s.descripcion " &
                "FROM SABOR s " &
                "INNER JOIN PRODUCTO_SABOR ps " &
                "ON s.id_sabor = ps.id_sabor " &
                "WHERE ps.id_producto = @producto " &
                "AND s.activo_sabor = 1 " &
                "ORDER BY s.nombre_sabor"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue(
                    "@producto", idProducto)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        sabores.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return sabores

    End Function


    ' ==========================================
    ' CARGAR PARAMETROS SQL
    ' ==========================================
    Private Shared Sub CargarParametros(
        cmd As MySqlCommand,
        sabor As Sabor)

        cmd.Parameters.AddWithValue(
            "@nombre", sabor.NombreSabor)

        cmd.Parameters.AddWithValue(
            "@stock", sabor.Stock)

        cmd.Parameters.AddWithValue(
            "@activo_sabor", sabor.Activo)

        cmd.Parameters.AddWithValue(
            "@descripcion", sabor.Descripcion)

    End Sub


    ' ==========================================
    ' MAPEAR REGISTRO MYSQL A OBJETO SABOR
    ' ==========================================
    Private Shared Function Mapear(
        reader As MySqlDataReader) As Sabor

        Dim sabor As New Sabor()

        sabor.IDSabor =
            Convert.ToInt32(reader("id_sabor"))

        sabor.NombreSabor =
            Convert.ToString(reader("nombre_sabor"))

        sabor.Stock =
            If(IsDBNull(reader("stock")), 0,
               Convert.ToInt32(reader("stock")))

        sabor.Activo =
            Convert.ToBoolean(reader("activo_sabor"))

        sabor.Descripcion =
            If(IsDBNull(reader("descripcion")), "",
               Convert.ToString(reader("descripcion")))

        Return sabor

    End Function

End Class
