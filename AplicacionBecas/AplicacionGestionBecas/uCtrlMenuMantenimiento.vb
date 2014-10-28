Public Class uCtrlMenuMantenimiento

    Public Property uCtrlMantCarreras As uCtrlMantenimientoCarreras = New uCtrlMantenimientoCarreras()
    Public Property uCtrlMantCursos As uCtrlMantenimientoCursos = New uCtrlMantenimientoCursos()
    Public Property uCtrlMantRequisitos As uCtrlMantenimientoRequisitos = New uCtrlMantenimientoRequisitos()
    Public Property uCntrlRol As UCntrlRegistrarRol = New UCntrlRegistrarRol()
    Public Property ucntrlUsuario As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
    Public Property uCntrlBuscarBeneficio As uCntrlBuscarBeneficio = New uCntrlBuscarBeneficio()

    Private Sub btnRequisitos_Click(sender As Object, e As EventArgs) Handles btnRequisitos.Click

        Me.Hide()
        uCtrlMantRequisitos = New uCtrlMantenimientoRequisitos()
        frmPrincipal.Controls.Add(uCtrlMantRequisitos)
        uCtrlMantRequisitos.Show()

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton cursos, muestra 
    ''' al usuario el menu de cursos</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click

        Me.Hide()
        uCtrlMantCursos = New uCtrlMantenimientoCursos()
        frmPrincipal.Controls.Add(uCtrlMantCursos)
        uCtrlMantCursos.Show()

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton carreras, muestra 
    ''' al usuario el menu de carreras</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCarreras_Click(sender As Object, e As EventArgs) Handles btnCarreras.Click

        Me.Hide()
        uCtrlMantCarreras = New uCtrlMantenimientoCarreras()
        frmPrincipal.Controls.Add(uCtrlMantCarreras)
        uCtrlMantCarreras.Show()

    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        Me.Hide()
        frmPrincipal.Controls.Add(uCntrlRol)
        uCntrlRol.Location = New Point(210, 100)
        uCntrlRol.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        Me.Hide()
        frmPrincipal.Controls.Add(ucntrlUsuario)
        ucntrlUsuario.Location = New Point(120, 0)
        ucntrlUsuario.Show()

    End Sub

    Private Sub btnBeneficios_Click(sender As Object, e As EventArgs) Handles btnBeneficios.Click
        Me.Hide()
        frmPrincipal.Controls.Add(uCntrlBuscarBeneficio)
        uCntrlBuscarBeneficio.Show()
    End Sub

    Private Sub btnBecas_Click(sender As Object, e As EventArgs) Handles btnBecas.Click

    End Sub
End Class
