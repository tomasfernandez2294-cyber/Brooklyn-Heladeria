Public Class FormCarrito

    Private carritoActual As Carrito

    'Constructor para el diseñador
    Public Sub New()

        InitializeComponent()

    End Sub

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

            'Agregar la fila y guardar su índice
            Dim indiceFila As Integer = dgvCarrito.Rows.Add(
            item.producto.NombreProducto,
            saboresTexto,
            item.cantidad,
            item.subtotal,
            item.NotaAdicional
        )

            'Relacionar la fila con ESTE ItemCarrito
            dgvCarrito.Rows(indiceFila).Tag = item

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

    REM boton eliminar 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If dgvCarrito.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un producto del carrito.")
            Exit Sub
        End If

        Dim itemSeleccionado As ItemCarrito =
            CType(dgvCarrito.CurrentRow.Tag, ItemCarrito)

        carritoActual.Items.Remove(itemSeleccionado)

        CargarCarrito()

    End Sub

    REM editar carrito
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If dgvCarrito.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un producto para editar.")
            Exit Sub
        End If

        Dim itemSeleccionado As ItemCarrito =
            CType(dgvCarrito.CurrentRow.Tag, ItemCarrito)

        Dim ventana As New FormSaboresCliente(itemSeleccionado)

        ventana.ShowDialog()

        CargarCarrito()

    End Sub

End Class