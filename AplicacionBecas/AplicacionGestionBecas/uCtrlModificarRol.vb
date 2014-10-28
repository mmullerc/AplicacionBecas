
Imports EntitiesLayer

Public Class uCtrlModificarRol

    Dim nombre As String


    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name>  

    Public Sub recieveData(ByVal pnombre As String)
        txtNombre.Text = pnombre
    End Sub

    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name>  
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub


    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name>  

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        nombre = txtNombre.Text

        objGestorRol.modificarRol(nombre)
        objGestorRol.guardarCambios()
    End Sub

    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 

    Sub listarPermisos()

        Dim listaPermisos As New List(Of Permiso)
        listaPermisos = objGestorRol.consultarPermisos

        ' CLBPermisos.BeginUpdate()
        For i As Integer = 0 To listaPermisos.Count - 1
            CLBPermisos.Items.Add(listaPermisos.Item(i).Nombre)

        Next
        ' CLBPermisos.EndUpdate()
    End Sub

    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name> 
    Private Sub uCtrlModificarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPermisos()
    End Sub

End Class
