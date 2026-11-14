Public Class FormPedidos

    Private Sub FormPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarPedidos()
        EstiloBrooklyn.Aplicar(Me)


    End Sub

    REM actualizar estados
    Private Sub ActualizarEstadoSeleccionado(
    nuevoEstado As EstadoPedido)

        If dgvPedidos.CurrentRow Is Nothing OrElse
       dgvPedidos.CurrentRow.Tag Is Nothing Then

            MessageBox.Show("Seleccione un pedido.")
            Exit Sub

        End If

        Dim pedido As Pedido =
        CType(dgvPedidos.CurrentRow.Tag, Pedido)

        Try

            If PedidoDAO.CambiarEstadoPedido(
            pedido.id, nuevoEstado) Then

                MessageBox.Show(
                "Pedido " & pedido.NumeroPedido &
                " actualizado a " &
                nuevoEstado.ToString())

                CargarPedidos()

            Else

                MessageBox.Show(
                "No se pudo actualizar el pedido.")

            End If

        Catch ex As Exception

            MessageBox.Show(
            "Error al actualizar el estado: " &
            ex.Message)

        End Try

    End Sub

    REM cargar los pedidos
    Private Sub CargarPedidos()

        Try

            dgvPedidos.Rows.Clear()

            ' Consultar pedidos de MySQL
            Dim pedidos As List(Of Pedido) =
            PedidoDAO.Listar()

            For Each pedido As Pedido In pedidos

                Dim indice As Integer =
                dgvPedidos.Rows.Add(
                    pedido.NumeroPedido,
                    pedido.fechaPedido.ToString("dd/MM/yyyy HH:mm"),
                    If(pedido.MetodoEntrega IsNot Nothing,
   pedido.MetodoEntrega.Nombre,
   "-"),
                    "-",
                    "$ " & pedido.total.ToString("N0"),
                    pedido.estadoPedido.ToString()
                )

                ' Asociar el pedido a la fila
                dgvPedidos.Rows(indice).Tag = pedido

            Next

        Catch ex As Exception

            MessageBox.Show(
            "Error al cargar los pedidos: " &
            ex.Message)

        End Try

    End Sub



    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        Dim formularioAdministrador As New PanelAdm()

        formularioAdministrador.show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ConexionBD.ProbarConexion() Then
            MessageBox.Show("¡Conexión con MySQL exitosa!")
        End If
    End Sub

    Private Sub btnPreparacion_Click(sender As Object, e As EventArgs) Handles btnPreparacion.Click
        ActualizarEstadoSeleccionado(
        EstadoPedido.EN_PREPARACION)
    End Sub

    Private Sub btnFinalizados_Click(sender As Object, e As EventArgs) Handles btnFinalizados.Click
        ActualizarEstadoSeleccionado(
        EstadoPedido.ENTREGADO
        )
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActualizarEstadoSeleccionado(
        EstadoPedido.RECIBIDO)
    End Sub
End Class