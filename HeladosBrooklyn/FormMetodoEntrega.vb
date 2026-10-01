Public Class FormMetodoEntrega
    Public Property MetodoCreado As MetodoEntrega
    Public Property metodoEditar As MetodoEntrega

    Private Sub FormMetodoEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipo.Items.Add("Retiro en local")
        cmbTipo.Items.Add("Delivery")

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Ingrese el nombre del método de entrega")
            Exit Sub
        End If

        If cmbTipo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de entrega")
            Exit Sub
        End If

        Dim metodo As MetodoEntrega
        If metodoEditar Is Nothing Then
            metodo = New MetodoEntrega()
        Else
            metodo = metodoEditar
        End If

        metodo.Nombre = txtNombre.Text
        metodo.Tipo = cmbTipo.Text
        metodo.Habilitado = chkHabilitado.Checked
        metodo.PermitirPedidos = chkPermitirPedidos.Checked.ToString()
        metodo.SolicitarEntreCalles = chkSolicitarEntreCalles.Checked

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

        metodo.RecargoDescuento = porcentaje

        MetodoCreado = metodo
        MessageBox.Show("Método de entrega guardado correctamente")
        DialogResult = DialogResult.OK
        Close()

    End Sub
End Class