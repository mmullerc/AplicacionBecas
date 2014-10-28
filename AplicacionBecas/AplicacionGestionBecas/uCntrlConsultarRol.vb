Imports EntitiesLayer

Class uCntrlConsultarRol

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Dispose()
    End Sub

    Public Sub enseñarDatos(ByVal pnombre As String)
        txtNombre.Text = pnombre
    End Sub

    Sub listarPermisos()

        Dim listaPermisos As New List(Of Permiso)
        'listaPermisos = objestorBe.consultarPermisos

        ' CLBPermisos.BeginUpdate()
        For i As Integer = 0 To listaPermisos.Count - 1
            CLBPermisos.Items.Add(listaPermisos.Item(i).Nombre)

        Next
        ' CLBPermisos.EndUpdate()
    End Sub

    Private Sub uCntrlConsultarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPermisos()
    End Sub
End Class
