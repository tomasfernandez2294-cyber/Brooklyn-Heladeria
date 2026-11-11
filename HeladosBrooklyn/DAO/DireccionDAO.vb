
Imports MySql.Data.MySqlClient

Public Class DireccionDAO

    ' ==========================================
    ' AGREGAR DIRECCION
    ' ==========================================
    Public Shared Function Agregar(direccion As Direccion) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "INSERT INTO DIRECCION " &
                "(barrio, calle, ciudad, cod_postal, entre_calles, " &
                "latitud, localidad, longitud, mas_informacion, " &
                "pais, piso_depto, provincia) " &
                "VALUES (@barrio, @calle, @ciudad, @codPostal, " &
                "@entreCalles, @latitud, @localidad, @longitud, " &
                "@masInformacion, @pais, @pisoDepto, @provincia)"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, direccion)

                cmd.ExecuteNonQuery()

                direccion.idDireccion =
                    Convert.ToInt32(cmd.LastInsertedId)

            End Using
        End Using

        Return True

    End Function


    ' ==========================================
    ' LISTAR DIRECCIONES
    ' ==========================================
    Public Shared Function Listar() As List(Of Direccion)

        Dim direcciones As New List(Of Direccion)()

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT * FROM DIRECCION ORDER BY id_direccion"

            Using cmd As New MySqlCommand(sql, conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        direcciones.Add(MapearDireccion(reader))
                    End While

                End Using
            End Using
        End Using

        Return direcciones

    End Function


    ' ==========================================
    ' BUSCAR DIRECCION POR ID
    ' ==========================================
    Public Shared Function BuscarPorID(id As Integer) As Direccion

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "SELECT * FROM DIRECCION " &
                "WHERE id_direccion = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                cmd.Parameters.AddWithValue("@id", id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        Return MapearDireccion(reader)
                    End If

                End Using
            End Using
        End Using

        Return Nothing

    End Function


    ' ==========================================
    ' MODIFICAR DIRECCION
    ' ==========================================
    Public Shared Function Modificar(direccion As Direccion) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "UPDATE DIRECCION SET " &
                "barrio = @barrio, " &
                "calle = @calle, " &
                "ciudad = @ciudad, " &
                "cod_postal = @codPostal, " &
                "entre_calles = @entreCalles, " &
                "latitud = @latitud, " &
                "localidad = @localidad, " &
                "longitud = @longitud, " &
                "mas_informacion = @masInformacion, " &
                "pais = @pais, " &
                "piso_depto = @pisoDepto, " &
                "provincia = @provincia " &
                "WHERE id_direccion = @id"

            Using cmd As New MySqlCommand(sql, conexion)

                CargarParametros(cmd, direccion)
                cmd.Parameters.AddWithValue("@id", direccion.idDireccion)

                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function


    ' ==========================================
    ' ELIMINAR DIRECCION
    ' ==========================================
    Public Shared Function Eliminar(id As Integer) As Boolean

        Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim sql As String =
                "DELETE FROM DIRECCION WHERE id_direccion = @id"

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
        direccion As Direccion)

        cmd.Parameters.AddWithValue("@barrio", direccion.barrio)
        cmd.Parameters.AddWithValue("@calle", direccion.calle)
        cmd.Parameters.AddWithValue("@ciudad", direccion.ciudad)
        cmd.Parameters.AddWithValue("@codPostal", direccion.codPostal)
        cmd.Parameters.AddWithValue("@entreCalles", direccion.entreCalles)
        cmd.Parameters.AddWithValue("@latitud", direccion.latitud)
        cmd.Parameters.AddWithValue("@localidad", direccion.localidad)
        cmd.Parameters.AddWithValue("@longitud", direccion.longitud)
        cmd.Parameters.AddWithValue("@masInformacion", direccion.masInformacion)
        cmd.Parameters.AddWithValue("@pais", direccion.pais)
        cmd.Parameters.AddWithValue("@pisoDepto", direccion.pisoDepto)
        cmd.Parameters.AddWithValue("@provincia", direccion.provincia)

    End Sub


    ' ==========================================
    ' CONVERTIR REGISTRO MYSQL A DIRECCION
    ' ==========================================
    Private Shared Function MapearDireccion(
        reader As MySqlDataReader) As Direccion

        Dim direccion As New Direccion()

        direccion.idDireccion =
            Convert.ToInt32(reader("id_direccion"))

        direccion.barrio = LeerTexto(reader, "barrio")
        direccion.calle = LeerTexto(reader, "calle")
        direccion.ciudad = LeerTexto(reader, "ciudad")

        direccion.codPostal =
            If(IsDBNull(reader("cod_postal")), 0,
               Convert.ToInt32(reader("cod_postal")))

        direccion.entreCalles =
            LeerTexto(reader, "entre_calles")

        direccion.latitud =
            If(IsDBNull(reader("latitud")), 0,
               Convert.ToInt32(reader("latitud")))

        direccion.localidad =
            LeerTexto(reader, "localidad")

        direccion.longitud =
            If(IsDBNull(reader("longitud")), 0,
               Convert.ToInt32(reader("longitud")))

        direccion.masInformacion =
            LeerTexto(reader, "mas_informacion")

        direccion.pais = LeerTexto(reader, "pais")
        direccion.pisoDepto = LeerTexto(reader, "piso_depto")
        direccion.provincia = LeerTexto(reader, "provincia")

        Return direccion

    End Function


    ' ==========================================
    ' LEER TEXTO QUE PUEDE SER NULL
    ' ==========================================
    Private Shared Function LeerTexto(
        reader As MySqlDataReader,
        columna As String) As String

        If IsDBNull(reader(columna)) Then
            Return ""
        End If

        Return Convert.ToString(reader(columna))

    End Function

End Class
