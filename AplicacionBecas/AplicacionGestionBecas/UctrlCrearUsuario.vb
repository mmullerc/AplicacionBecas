Imports EntitiesLayer

Public Class UctrlCrearUsuario

    '<summary> Método que se encarga mandar al gestor la información para crear un nuevo usuario</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param> No recibe valor  </param>
    '<returns> No retorna valor.</returns> 
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

        objGestorUsuario.crearUsuario(pNombre, sNombre, pApellido, sApellido, identificacion, telefono, fechaNacimiento, rol, genero, correoElectronico, contraseña, confirmacion)
        objGestorUsuario.guardarCambios()

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


    Private Sub UctrlCrearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboRoles()
    End Sub
End Class
