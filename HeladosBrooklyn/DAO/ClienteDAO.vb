
Imports MySql.Data.MySqlClient

Public Class ClienteDAO

    ' ==========================================
    ' AGREGAR CLIENTE
    ' ==========================================
    Public Shared Function Agregar(cliente As Cliente) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO CLIENTE " &
                "(nombre, apellido, telefono, email, fecha_nacimiento) " &
                "VALUES (@nombre, @apellido, @telefono, @email, @fecha)"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, cliente)

                cmd.ExecuteNonQuery()

                cliente.IDCliente =
                    Convert.ToInt32(cmd.LastInsertedId)

                Return True

            End Using
        End Using

    End Function


    ' ==========================================
    ' LISTAR CLIENTES
    ' ==========================================
    Public Shared Function Listar() As List(Of Cliente)

        Dim clientes As New List(Of Cliente)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_cliente, nombre, apellido, telefono, " &
                "email, fecha_nacimiento FROM CLIENTE " &
                "ORDER BY apellido, nombre"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        clientes.Add(Mapear(reader))
                    End While

                End Using
            End Using
        End Using

        Return clientes

    End Function


    ' ==========================================
    ' BUSCAR CLIENTE POR ID
    ' ==========================================
    Public Shared Function BuscarPorID(id As Integer) As Cliente

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_cliente, nombre, apellido, telefono, " &
                "email, fecha_nacimiento FROM CLIENTE " &
                "WHERE id_cliente = @id"

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
    ' BUSCAR CLIENTE POR TELEFONO
    ' ==========================================
    Public Shared Function BuscarPorTelefono(
        telefono As String) As Cliente

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT id_cliente, nombre, apellido, telefono, " &
                "email, fecha_nacimiento FROM CLIENTE " &
                "WHERE telefono = @telefono LIMIT 1"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@telefono", telefono)

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
    ' MODIFICAR CLIENTE
    ' ==========================================
    Public Shared Function Modificar(cliente As Cliente) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE CLIENTE SET " &
                "nombre = @nombre, " &
                "apellido = @apellido, " &
                "telefono = @telefono, " &
                "email = @email, " &
                "fecha_nacimiento = @fecha " &
                "WHERE id_cliente = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, cliente)

                cmd.Parameters.AddWithValue(
                    "@id", cliente.IDCliente)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' ELIMINAR CLIENTE (BAJA FISICA)
    ' ==========================================
    Public Shared Function Eliminar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM CLIENTE WHERE id_cliente = @id"

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
        cliente As Cliente)

        cmd.Parameters.AddWithValue(
            "@nombre", cliente.Nombre)

        cmd.Parameters.AddWithValue(
            "@apellido", cliente.Apellido)

        cmd.Parameters.AddWithValue(
            "@telefono", cliente.Telefono)

        cmd.Parameters.AddWithValue(
            "@email",
            If(String.IsNullOrWhiteSpace(cliente.Email),
               CType(DBNull.Value, Object),
               cliente.Email.Trim()))

        Dim fecha As Object = DBNull.Value

        If cliente.FechaNacimiento.HasValue Then
            fecha = cliente.FechaNacimiento.Value.Date
        End If

        cmd.Parameters.AddWithValue("@fecha", fecha)

    End Sub


    ' ==========================================
    ' MAPEAR REGISTRO MYSQL A CLIENTE
    ' ==========================================
    Private Shared Function Mapear(
        reader As MySqlDataReader) As Cliente

        Dim cliente As New Cliente()

        cliente.IDCliente =
            Convert.ToInt32(reader("id_cliente"))

        cliente.Nombre =
            Convert.ToString(reader("nombre"))

        cliente.Apellido =
            Convert.ToString(reader("apellido"))

        cliente.Telefono =
            Convert.ToString(reader("telefono"))

        cliente.Email =
            If(IsDBNull(reader("email")), "",
               Convert.ToString(reader("email")))

        If Not IsDBNull(reader("fecha_nacimiento")) Then
            cliente.FechaNacimiento =
                Convert.ToDateTime(reader("fecha_nacimiento"))
        Else
            cliente.FechaNacimiento = Nothing
        End If

        Return cliente

    End Function

End Class
