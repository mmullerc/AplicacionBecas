
Imports EntitiesLayer

Public Class uCtrlEliminarRol

    Dim nombre As String
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
    Public Sub recieveData(ByVal pnombre As String)
        nombre = pnombre
    End Sub
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        objGestorRol.eliminarRol(nombre)
        objGestorRol.guardarCambios()
    End Sub

    Private Sub uCtrlEliminarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
