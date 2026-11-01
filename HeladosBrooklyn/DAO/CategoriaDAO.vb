Imports MySql.Data.MySqlClient

Public Class CategoriaDAO

    ' ==========================================
    ' AGREGAR CATEGORÍA
    ' ==========================================
    Public Shared Function Agregar(categoria As NombreCategoria) As Boolean

        Try
            Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()

                conexion.Open()

                Dim sql As String =
                    "INSERT INTO CATEGORIA " &
                    "(nombre_categoria, activo_categoria) " &
                    "VALUES (@nombre, @activo)"

                Using comando As New MySqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@nombre",
                                                   categoria.NombreCategoria)

                    comando.Parameters.AddWithValue("@activo",
                                                   categoria.Activo)

                    comando.ExecuteNonQuery()

                    'MySQL genera automáticamente el ID
                    categoria.IDCategoria = CInt(comando.LastInsertedId)

                End Using

            End Using

            Return True

        Catch ex As Exception

            MessageBox.Show("Error al agregar categoría: " & ex.Message)
            Return False

        End Try

    End Function


    ' ==========================================
    ' LISTAR CATEGORÍAS
    ' ==========================================
    Public Shared Function Listar() As List(Of NombreCategoria)

        Dim lista As New List(Of NombreCategoria)

        Try
            Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()

                conexion.Open()

                Dim sql As String =
                    "SELECT id_categoria, nombre_categoria, activo_categoria " &
                    "FROM CATEGORIA " &
                    "ORDER BY nombre_categoria"

                Using comando As New MySqlCommand(sql, conexion)

                    Using reader As MySqlDataReader = comando.ExecuteReader()

                        While reader.Read()

                            Dim categoria As New NombreCategoria()

                            categoria.IDCategoria =
                                CInt(reader("id_categoria"))

                            categoria.NombreCategoria =
                                reader("nombre_categoria").ToString()

                            categoria.Activo =
                                CBool(reader("activo_categoria"))

                            lista.Add(categoria)

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error al listar categorías: " & ex.Message)

        End Try

        Return lista

    End Function


    ' ==========================================
    ' MODIFICAR CATEGORÍA
    ' ==========================================
    Public Shared Function Modificar(categoria As NombreCategoria) As Boolean

        Try
            Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()

                conexion.Open()

                Dim sql As String =
                    "UPDATE CATEGORIA " &
                    "SET nombre_categoria = @nombre, " &
                    "activo_categoria = @activo " &
                    "WHERE id_categoria = @id"

                Using comando As New MySqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@nombre",
                                                   categoria.NombreCategoria)

                    comando.Parameters.AddWithValue("@activo",
                                                   categoria.Activo)

                    comando.Parameters.AddWithValue("@id",
                                                   categoria.IDCategoria)

                    Return comando.ExecuteNonQuery() > 0

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error al modificar categoría: " & ex.Message)
            Return False

        End Try

    End Function


    ' ==========================================
    ' ELIMINAR / DESACTIVAR CATEGORÍA
    ' ==========================================
    Public Shared Function Desactivar(idCategoria As Integer) As Boolean

        Try
            Using conexion As MySqlConnection = ConexionBD.ObtenerConexion()

                conexion.Open()

                Dim sql As String =
                    "UPDATE CATEGORIA " &
                    "SET activo_categoria = FALSE " &
                    "WHERE id_categoria = @id"

                Using comando As New MySqlCommand(sql, conexion)

                    comando.Parameters.AddWithValue("@id", idCategoria)

                    Return comando.ExecuteNonQuery() > 0

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error al desactivar categoría: " & ex.Message)
            Return False

        End Try

    End Function

End Class