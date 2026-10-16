Public Class FormCarrito

    Private carritoActual As Carrito


    REM contructor de bpruba
    Public Sub New(carrito As Carrito)

        InitializeComponent()

        carritoActual = carrito

        CargarCarrito()

    End Sub

    REM procedimiento para cargar al carrito 
    Private Sub CargarCarrito()

        dgvCarrito.Rows.Clear()

        For Each item As ItemCarrito In carritoActual.Items

            Dim saboresTexto As String = ""

            For Each sabor As Sabor In item.SaboresSeleccionados

                If saboresTexto <> "" Then
                    saboresTexto &= ", "
                End If

                saboresTexto &= sabor.NombreSabor

            Next

            dgvCarrito.Rows.Add(
            item.producto.NombreProducto,
            saboresTexto,
            item.cantidad,
            item.subtotal
        )

        Next

        lblTotal.Text = "$" & carritoActual.CalcularTotal().ToString()

    End Sub

    'boton volver
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    'boton continuar pedido
    Private Sub btnContinuarPedido_Click(sender As Object, e As EventArgs) Handles btnContinuarPedido.Click

        Dim formularioEntrega As New FormMetodoEntregaCliente(carritoActual)

        formularioEntrega.Show()
        Me.Hide()

    End Sub

End Class