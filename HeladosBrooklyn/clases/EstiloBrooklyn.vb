Imports System.Drawing
Imports System.Windows.Forms

Public Class EstiloBrooklyn

    Public Shared Sub Aplicar(formulario As Form)

        ' Evitar escalado
        formulario.AutoScaleMode = AutoScaleMode.None

        ' Fondo rosa Brooklyn
        formulario.BackColor = Color.FromArgb(237, 163, 202)

        ' Centrar formulario
        formulario.StartPosition = FormStartPosition.CenterScreen

        ' Aplicar estilo a los botones
        AplicarBotones(formulario)

    End Sub

    Private Shared Sub AplicarBotones(contenedor As Control)

        For Each control As Control In contenedor.Controls

            If TypeOf control Is Button Then

                Dim boton As Button = DirectCast(control, Button)

                ' Fondo azul
                boton.BackColor = Color.FromArgb(30, 100, 200)

                ' Letras blancas
                boton.ForeColor = Color.White

                ' Estilo plano
                boton.FlatStyle = FlatStyle.Flat

                ' Sin borde
                boton.FlatAppearance.BorderSize = 0

                ' Color al pasar el mouse
                boton.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(20, 75, 160)

            End If

            ' Buscar botones dentro de paneles y otros contenedores
            If control.HasChildren Then
                AplicarBotones(control)
            End If

        Next

    End Sub

End Class