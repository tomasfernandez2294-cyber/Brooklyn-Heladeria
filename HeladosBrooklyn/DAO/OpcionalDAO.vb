
Imports MySql.Data.MySqlClient

Public Class OpcionalDAO

    ' ==========================================
    ' AGREGAR OPCIONAL
    ' ==========================================
    Public Shared Function Agregar(opcional As Opcional) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO OPCIONAL " &
                "(nombre, precio, grupo, activo) " &
                "VALUES (@nombre, @precio, @grupo, @activo)"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, opcional)

                cmd.ExecuteNonQuery()

                opcional.IDOpcional =
                    Convert.ToInt32(cmd.LastInsertedId)

                Return True

            End Using
        End Using

    End Function


    ' ==========================================
    ' LISTAR TODOS LOS OPCIONALES
    ' ==========================================
    Public Shared Function Listar() As List(Of Opcional)

        Dim opcionales As New List(Of Opcional)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_opcional, nombre, precio, grupo, activo " &
                "FROM OPCIONAL ORDER BY nombre"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()

                        opcionales.Add(MapearOpcional(reader))

                    End While

                End Using
            End Using
        End Using

        Return opcionales

    End Function


    ' ==========================================
    ' LISTAR OPCIONALES ACTIVOS
    ' ==========================================
    Public Shared Function ListarActivos() As List(Of Opcional)

        Dim opcionales As New List(Of Opcional)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_opcional, nombre, precio, grupo, activo " &
                "FROM OPCIONAL WHERE activo = 1 " &
                "ORDER BY nombre"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()

                        opcionales.Add(MapearOpcional(reader))

                    End While

                End Using
            End Using
        End Using

        Return opcionales

    End Function


    ' ==========================================
    ' BUSCAR OPCIONAL POR ID
    ' ==========================================
    Public Shared Function BuscarPorID(id As Integer) As Opcional

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_opcional, nombre, precio, grupo, activo " &
                "FROM OPCIONAL WHERE id_opcional = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        Return MapearOpcional(reader)
                    End If

                End Using
            End Using
        End Using

        Return Nothing

    End Function


    ' ==========================================
    ' BUSCAR OPCIONALES POR GRUPO
    ' ==========================================
    Public Shared Function BuscarPorGrupo(
        grupo As String) As List(Of Opcional)

        Dim opcionales As New List(Of Opcional)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_opcional, nombre, precio, grupo, activo " &
                "FROM OPCIONAL " &
                "WHERE grupo = @grupo AND activo = 1 " &
                "ORDER BY nombre"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@grupo", grupo)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        opcionales.Add(MapearOpcional(reader))
                    End While

                End Using
            End Using
        End Using

        Return opcionales

    End Function


    ' ==========================================
    ' MODIFICAR OPCIONAL
    ' ==========================================
    Public Shared Function Modificar(opcional As Opcional) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE OPCIONAL SET " &
                "nombre = @nombre, " &
                "precio = @precio, " &
                "grupo = @grupo, " &
                "activo = @activo " &
                "WHERE id_opcional = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, opcional)

                cmd.Parameters.AddWithValue(
                    "@id", opcional.IDOpcional)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' DESACTIVAR OPCIONAL (BAJA LOGICA)
    ' ==========================================
    Public Shared Function Eliminar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE OPCIONAL SET activo = 0 " &
                "WHERE id_opcional = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' REACTIVAR OPCIONAL
    ' ==========================================
    Public Shared Function Reactivar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE OPCIONAL SET activo = 1 " &
                "WHERE id_opcional = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' CARGAR PARAMETROS
    ' ==========================================
    Private Shared Sub CargarParametros(
        cmd As MySqlCommand,
        opcional As Opcional)

        cmd.Parameters.AddWithValue(
            "@nombre", opcional.Nombre)

        cmd.Parameters.AddWithValue(
            "@precio", opcional.Precio)

        cmd.Parameters.AddWithValue(
            "@grupo", opcional.Grupo)

        cmd.Parameters.AddWithValue(
            "@activo", opcional.Activo)

    End Sub


    ' ==========================================
    ' CONVERTIR REGISTRO MYSQL A OBJETO
    ' ==========================================
    Private Shared Function MapearOpcional(
        reader As MySqlDataReader) As Opcional

        Dim opcional As New Opcional()

        opcional.IDOpcional =
            Convert.ToInt32(reader("id_opcional"))

        opcional.Nombre =
            Convert.ToString(reader("nombre"))

        opcional.Precio =
            Convert.ToInt32(reader("precio"))

        opcional.Grupo =
            If(IsDBNull(reader("grupo")), "",
               Convert.ToString(reader("grupo")))

        opcional.Activo =
            Convert.ToBoolean(reader("activo"))

        Return opcional

    End Function

End Class
