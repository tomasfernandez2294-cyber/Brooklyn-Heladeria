Imports MySql.Data.MySqlClient

Public Class ConexionBD

    Private Shared cadenaConexion As String =
        "Server=localhost;Port=3306;Database=heladeria_db;Uid=root;Pwd=RACing2294$$;"

    Public Shared Function ObtenerConexion() As MySqlConnection

        Dim conexion As New MySqlConnection(cadenaConexion)

        Return conexion

    End Function

    REM funcion para hacer pruebas
    Public Shared Function ProbarConexion() As Boolean
        Try
            Using conexion As MySqlConnection = ObtenerConexion()
                conexion.Open()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
            Return False
        End Try
    End Function
End Class
