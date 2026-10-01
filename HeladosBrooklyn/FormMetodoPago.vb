Public Class FormMetodoPago
    Public Property MetodoCreado As MetodoPago
    Public Property MetodoEditar As MetodoPago

    Private Sub FormMetodoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipo.Items.Add("Efectivo")
        cmbTipo.Items.Add("Transferencia")
        cmbTipo.Items.Add("Mercado Pago")
        cmbTipo.Items.Add("Tarjeta de débito")
        cmbTipo.Items.Add("Tarjeta de crédito")

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Ingrese el nombre del método de pago")
            Exit Sub
        End If

        If cmbTipo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de pago")
            Exit Sub
        End If

        Dim metodo As MetodoPago
        If MetodoEditar Is Nothing Then
            metodo = New MetodoPago()
        Else
            metodo = MetodoEditar
        End If

        metodo.Nombre = txtNombre.Text
        metodo.Tipo = cmbTipo.Text
        metodo.Habilitado = chkHabilitado.Checked

        Dim porcentaje As Integer

        If txtRecargoDescuento.Text = "" Then
            porcentaje = 0
        ElseIf Not Integer.TryParse(txtRecargoDescuento.Text, porcentaje) Then
            MessageBox.Show("Ingrese un porcentaje válido")
            Exit Sub
        End If

        If porcentaje < -50 Or porcentaje > 50 Then
            MessageBox.Show("El porcentaje debe estar entre -50 y 50")
            Exit Sub
        End If

        MetodoCreado = metodo
        MessageBox.Show("Método de pago guardado correctamente")
        DialogResult = DialogResult.OK
        Close()

    End Sub
End Class