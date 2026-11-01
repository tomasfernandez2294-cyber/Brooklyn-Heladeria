Public Class FormPedidos

    Private Sub FormPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarPedidos()

    End Sub


    Private Sub CargarPedidos()

        ' Limpiar la tabla antes de cargar
        dgvPedidos.Rows.Clear()

        ' Recorrer los pedidos guardados
        For Each pedido As Pedido In GestorPedidos.Pedidos

            dgvPedidos.Rows.Add(
                pedido.NumeroPedido,
                pedido.fechaPedido.ToString("dd/MM/yyyy HH:mm"),
                pedido.MetodoEntrega.Nombre,
                pedido.MetodoPago.Nombre,
                "$ " & pedido.total.ToString("N0")
            )

        Next

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
End Class