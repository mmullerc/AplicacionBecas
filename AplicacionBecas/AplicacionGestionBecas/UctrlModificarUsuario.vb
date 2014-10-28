Imports EntitiesLayer
Public Class UctrlModificarUsuario

    Dim parametro As String

    Public Sub setParametro(ByVal pparametro As String)
        parametro = pparametro
    End Sub
    Private Sub UctrlModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboRoles()
        llenarInfoEditar()
    End Sub

    '<summary> Método que se encarga de llenar un combo box de objetos Rol</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param> No recibe valor  </param>
    '<returns> No retorna valor.</returns> 
    Public Sub llenarComboRoles()


        Dim listaRoles As List(Of Rol) = New List(Of Rol)

        listaRoles = objGestorRol.consultarRoles()

        For i As Integer = 0 To listaRoles.Count - 1

            cmbRoles.Items.Add(listaRoles(i).Nombre)
        Next
    End Sub


    Public Sub llenarInfoEditar()
        Dim objetoUsuario As Usuario = objGestorUsuario.buscarUnUsuario(parametro)
        txtNombre.Text = objetoUsuario.primerNombre
        txtSegundoNombre.Text = objetoUsuario.segundoNombre
        txtPrimerApellido.Text = objetoUsuario.primerApellido
        txtSegundoApellido.Text = objetoUsuario.segundoApellido
        txtIdentificacion.Text = objetoUsuario.identificacion
        txtTelefono.Text = objetoUsuario.telefono
        'DtpFechaNacimiento = 
        If objetoUsuario.genero = 1 Then
            rbtMasculino.Select()
        ElseIf objetoUsuario.genero = 2 Then
            rbtFemenino.Select()
        Else
            rbtOtro.Select()
        End If
        cmbRoles.SelectedText = objetoUsuario.rol.Nombre
        txtCorreoElectronico.Text = objetoUsuario.correoElectronico
        txtContraseña.Text = objetoUsuario.contraseña


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ucntrl As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.Hide()
        frmPrincipal.Controls.Add(ucntrl)
        ucntrl.Location = New Point(120, 0)
        ucntrl.Show()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim pNombre As String = txtNombre.Text
        Dim sNombre As String = txtSegundoNombre.Text
        Dim pApellido As String = txtPrimerApellido.Text
        Dim sApellido As String = txtSegundoApellido.Text
        Dim identificacion As String = txtIdentificacion.Text
        Dim telefono As String = txtTelefono.Text
        Dim fechaNacimiento As Date = DtpFechaNacimiento.Value.Date
        Dim rol As String = cmbRoles.Text
        Dim genero As Integer
        Dim correoElectronico As String = txtCorreoElectronico.Text
        Dim contraseña As String = txtContraseña.Text
        Dim confirmacion As String = txtConfirmacionContraseña.Text

        If (rbtMasculino.Checked = True) Then
            genero = 1
        Else
            If (rbtFemenino.Checked = True) Then
                genero = 2

            Else
                genero = 3
            End If
        End If

        objGestorUsuario.modificarUsuario(pNombre, sNombre, pApellido, sApellido, identificacion, telefono, fechaNacimiento, rol, genero, correoElectronico, contraseña, confirmacion, Me.parametro)
        objGestorUsuario.guardarCambios()
    End Sub
End Class
