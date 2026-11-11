
Imports System.Linq

Public Class FormSaboresCliente

    Private productoSeleccionado As Producto
    Private carritoActual As Carrito
    Private itemEditando As ItemCarrito = Nothing

    ' ==========================================
    ' CONSTRUCTOR - AGREGAR PRODUCTO
    ' ==========================================
    Public Sub New(producto As Producto, carrito As Carrito)

        InitializeComponent()

        productoSeleccionado = producto
        carritoActual = carrito

    End Sub

    ' ==========================================
    ' CONSTRUCTOR - EDITAR PRODUCTO
    ' ==========================================
    Public Sub New(item As ItemCarrito)

        InitializeComponent()

        itemEditando = item
        productoSeleccionado = item.producto

    End Sub

    ' ==========================================
    ' LOAD
    ' ==========================================
    Private Sub FormSaboresCliente_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' Mostrar datos del producto
        lblNombreProducto.Text = productoSeleccionado.NombreProducto

        lblPrecio.Text =
            "$ " & productoSeleccionado.Precio.ToString("N0")

        ' Limpiar lista
        clbSabores.Items.Clear()

        ' Cargar sabores asociados al producto
        For Each sabor As Sabor In productoSeleccionado.Sabores

            If sabor.Activo Then
                clbSabores.Items.Add(sabor)
            End If

        Next

        ' MODO EDICION
        If itemEditando IsNot Nothing Then

            txtNotasAdicionales.Text = itemEditando.NotaAdicional

            For i As Integer = 0 To clbSabores.Items.Count - 1

                Dim sabor As Sabor =
                    CType(clbSabores.Items(i), Sabor)

                If itemEditando.SaboresSeleccionados.Any(
                    Function(s) s.IDSabor = sabor.IDSabor) Then

                    clbSabores.SetItemChecked(i, True)

                End If

            Next

        End If

        ' Mostrar contador inicial
        ActualizarContadorSabores()

    End Sub

    ' ==========================================
    ' ACTUALIZAR CONTADOR
    ' ==========================================
    Private Sub ActualizarContadorSabores()

        lblLimiteSabores.Text =
            clbSabores.CheckedItems.Count.ToString() &
            " / " & productoSeleccionado.MaxSabores.ToString()

    End Sub

    ' ==========================================
    ' CONTROLAR SELECCION DE SABORES
    ' ==========================================
    Private Sub clbSabores_ItemCheck(
        sender As Object,
        e As ItemCheckEventArgs
    ) Handles clbSabores.ItemCheck

        Dim cantidad As Integer = clbSabores.CheckedItems.Count

        If e.NewValue = CheckState.Checked Then

            cantidad += 1

            If cantidad > productoSeleccionado.MaxSabores Then

                MessageBox.Show(
                    "Solo puede seleccionar un máximo de " &
                    productoSeleccionado.MaxSabores.ToString() &
                    " sabores.")

                e.NewValue = CheckState.Unchecked
                Return

            End If

        ElseIf e.NewValue = CheckState.Unchecked Then

            cantidad -= 1

        End If

        lblLimiteSabores.Text =
            cantidad.ToString() & " / " &
            productoSeleccionado.MaxSabores.ToString()

    End Sub

    ' ==========================================
    ' BOTON AGREGAR AL PEDIDO
    ' ==========================================
    Private Sub btnAgregarPedido_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAgregarPedido.Click

        ' Validar seleccion obligatoria
        If clbSabores.CheckedItems.Count = 0 Then

            MessageBox.Show(
                "Debe seleccionar al menos un sabor.")

            Exit Sub

        End If

        ' Validar máximo de sabores
        If clbSabores.CheckedItems.Count >
            productoSeleccionado.MaxSabores Then

            MessageBox.Show(
                "Superó el máximo de sabores permitidos.")

            Exit Sub

        End If

        ' =====================================
        ' MODO EDICION
        ' =====================================
        If itemEditando IsNot Nothing Then

            itemEditando.SaboresSeleccionados.Clear()

            For Each sabor As Sabor In clbSabores.CheckedItems

                itemEditando.SaboresSeleccionados.Add(sabor)

            Next

            itemEditando.NotaAdicional =
                txtNotasAdicionales.Text

            MessageBox.Show(
                "Producto actualizado correctamente.")

            Me.Close()
            Exit Sub

        End If

        ' =====================================
        ' MODO AGREGAR
        ' =====================================
        Dim nuevoItem As New ItemCarrito()

        nuevoItem.producto = productoSeleccionado
        nuevoItem.cantidad = 1

        nuevoItem.subtotal =
            CDbl(productoSeleccionado.Precio)

        nuevoItem.NotaAdicional =
            txtNotasAdicionales.Text

        ' Guardar sabores seleccionados
        For Each sabor As Sabor In clbSabores.CheckedItems

            nuevoItem.SaboresSeleccionados.Add(sabor)

        Next

        ' Agregar producto al carrito
        carritoActual.AgregarProducto(nuevoItem)

        MessageBox.Show(
            "Producto agregado al carrito correctamente.")

        Me.Close()

    End Sub

End Class
