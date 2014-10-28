Public Class UCntrlRegistrarRol

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim nombre As String = txtNombre.Text

        objGestorRol.agregarRol(nombre)

        objGestorRol.guardarCambios()
    End Sub
End Class
