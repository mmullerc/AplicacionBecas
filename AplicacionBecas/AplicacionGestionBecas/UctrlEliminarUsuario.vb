Public Class UctrlEliminarUsuario

    Dim parametro As String

    Public Sub setParametro(ByVal pparametro As String)
        parametro = pparametro
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        objGestorUsuario.eliminarUsuario(Me.parametro)
        objGestorUsuario.guardarCambios()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ucntrl As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.Hide()
        frmPrincipal.Controls.Add(ucntrl)
        ucntrl.Location = New Point(120, 0)
        ucntrl.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub UctrlEliminarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
