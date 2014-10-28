Public Class uCtrlEliminarBeneficio

    Dim id As Integer
    Dim nombre As String
    Dim porcentaje As Double
    Dim aplicabilidad As String

    Public Sub recibirInfo(ByVal pid As Integer, ByVal pnombre As String, ByVal pporcentaje As Double, ByVal paplicabilidad As String)

        id = pid
        nombre = pnombre
        porcentaje = pporcentaje
        aplicabilidad = paplicabilidad

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        objGestorBeneficio.eliminarBeneficio(id, nombre, porcentaje, aplicabilidad)
        MsgBox("beneficio eliminado")
        objGestorBeneficio.guardarCambios()

    End Sub
End Class
