
Imports EntitiesLayer
Public Class UctrlListarYBuscarUsuario
    Dim ucntrlUsuario As UctrlCrearUsuario = New UctrlCrearUsuario()
    Dim ctrlUsuario As UCtrlConsultarUsuario = New UCtrlConsultarUsuario()

    Private Sub UctrlListarYBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarUsuarios()
    End Sub

    '<summary> Método que se encarga de listar los usuarios que hay registrados en el sistema</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param> No recibe valor  </param>
    '<returns> No retorna valor.</returns> 
    Public Sub listarUsuarios()
        Dim listaUsuarios As List(Of Usuario)
        listaUsuarios = objGestorUsuario.buscarUsuarios()
        For i As Integer = 0 To listaUsuarios.Count - 1
            dgUsuarios.Rows.Add(1)
            dgUsuarios.Rows(i).Cells(0).Value = listaUsuarios.Item(i).identificacion
            dgUsuarios.Rows(i).Cells(1).Value = listaUsuarios.Item(i).primerNombre & " " & listaUsuarios.Item(i).primerApellido & " " & listaUsuarios.Item(i).segundoApellido
            'dgUsuarios.Rows(i).Cells(2).Value = listaUsuarios.Item(i).rol.Nombre
        Next

    End Sub

    Public Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        Me.Hide()
        frmPrincipal.Controls.Add(ucntrlUsuario)
        ucntrlUsuario.Location = New Point(210, 100)
        ucntrlUsuario.Show()
    End Sub

    Public Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim parametro As String = txtBuscar.Text
        Dim objUsuario As Usuario = objGestorUsuario.buscarUnUsuario(parametro)
        dgUsuarios.Rows.Clear()
        dgUsuarios.Rows.Add(1)
        dgUsuarios.Rows(0).Cells(0).Value = objUsuario.identificacion
        dgUsuarios.Rows(0).Cells(1).Value = objUsuario.primerNombre & " " & objUsuario.primerApellido & " " & objUsuario.segundoApellido
        dgUsuarios.Rows(0).Cells(2).Value = objUsuario.rol.Nombre
    End Sub

    Private Sub dgUsuarios_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgUsuarios.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dgUsuarios.CurrentCell.ColumnIndex = 3 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                ' Remove an existing event-handler, if present, to avoid 
                ' adding multiple handlers when the editing control is reused.
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                ' Add the event handler. 
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If
    End Sub

    Public Sub consultarUsuario(ByVal pparametro As String)
        Me.Hide()
        ctrlUsuario.setParametro(pparametro)
        frmPrincipal.Controls.Add(ctrlUsuario)
        ctrlUsuario.Location = New Point(120, 0)
        ctrlUsuario.Show()

    End Sub
    Public Sub eliminarUsuario(ByVal parametro As String)

        Dim ucntrl As UctrlEliminarUsuario = New UctrlEliminarUsuario()
        ucntrl.setParametro(parametro)
        'frmPrincipal.Controls.Add(ucntrl)
        Me.Controls.Add(ucntrl)
        Me.dgUsuarios.SendToBack()
        Me.PbUsuarios.SendToBack()
        ucntrl.Location = New Point(280, 250)
        ucntrl.Show()
        
    End Sub

    Public Sub modificarUsuario(ByVal pparametro As String)
        Dim ucntrl As UctrlModificarUsuario = New UctrlModificarUsuario()
        ucntrl.setParametro(pparametro)
        'frmPrincipal.Controls.Add(ucntrl)
        Me.Controls.Add(ucntrl)
        Me.dgUsuarios.SendToBack()
        Me.PbUsuarios.SendToBack()
        Me.btnCrearUsuario.SendToBack()
        Me.txtBuscar.SendToBack()
        Me.btnBuscar.SendToBack()
        ucntrl.Location = New Point(100, 50)
        ucntrl.Show()

    End Sub
 
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)

        If combo.SelectedItem = "Ver" Then
            Dim parametro = dgUsuarios.CurrentRow.Cells(0).Value
            consultarUsuario(parametro)
        ElseIf combo.SelectedItem = "Editar" Then
            Dim parametro = dgUsuarios.CurrentRow.Cells(0).Value
            modificarUsuario(parametro)
        ElseIf combo.SelectedItem = "Eliminar" Then
            Dim parametro = dgUsuarios.CurrentRow.Cells(0).Value
            eliminarUsuario(parametro)
        End If
    End Sub


    Private Sub dgUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuarios.CellContentClick

    End Sub
End Class




