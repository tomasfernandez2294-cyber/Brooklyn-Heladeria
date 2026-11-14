Public Class FormRegistroCliente
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Try
            Dim nombre As String = txtNombre.Text.Trim()
            Dim apellido As String = txtApellido.Text.Trim()

            Dim telefono As String =
            ClienteServicio.NormalizarTelefono(
                txtTelefono.Text)

            ' VALIDAR DATOS OBLIGATORIOS
            If Not ClienteServicio.ValidarDatos(
            nombre, apellido, telefono) Then

                MessageBox.Show(
                "Complete nombre, apellido y WhatsApp.")

                Exit Sub
            End If

            ' COMPROBAR SI EL CLIENTE EXISTE
            If Not ClienteServicio.ValidarCliente(telefono) Then

                MessageBox.Show(
                "Este WhatsApp ya está registrado.")

                Exit Sub
            End If

            ' CREAR OBJETO CLIENTE
            Dim cliente As New Cliente()

            cliente.Nombre = nombre
            cliente.Apellido = apellido
            cliente.Telefono = telefono
            cliente.Email = txtEmail.Text.Trim()

            If dtpFechaNacimiento.Checked Then
                cliente.FechaNacimiento =
                dtpFechaNacimiento.Value.Date
            Else
                cliente.FechaNacimiento = Nothing
            End If

            ' GUARDAR EN MYSQL
            If ClienteDAO.Agregar(cliente) Then

                MessageBox.Show(
                "Cliente registrado correctamente." &
                vbCrLf &
                "ID generado: " & cliente.IDCliente)
                Me.Close()

            End If

        Catch ex As Exception

            MessageBox.Show(
            "Error al registrar cliente: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnVolver_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnVolver.Click

        Me.Close()

    End Sub
    Private Sub btnProbarCupon_Click(
    sender As Object,
    e As EventArgs
)

        Try
            Dim cupon As New Cupon()

            cupon.codigo = CuponServicio.GenerarCodigo()
            cupon.tipoDescuento = "PORCENTAJE"
            cupon.valor = 10D
            cupon.activo = True

            If CuponDAO.Agregar(cupon) Then

                MessageBox.Show(
                    "Cupón registrado correctamente." &
                    vbCrLf &
                    "ID: " & cupon.idCupon &
                    vbCrLf &
                    "Código: " & cupon.codigo)

            Else

                MessageBox.Show("No se pudo guardar el cupón.")

            End If

        Catch ex As Exception

            MessageBox.Show(
                "Error al guardar cupón: " & ex.Message)

        End Try

    End Sub

    REM load
    Private Sub FormRegistroCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EstiloBrooklyn.Aplicar(Me)


    End Sub
End Class