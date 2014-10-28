Imports EntitiesLayer

Public Class ListarRol

    Public Property uCtrlRol As UCntrlRegistrarRol = New UCntrlRegistrarRol()

    'Private Sub btnCrearRol_Click(sender As Object, e As EventArgs) Handles btnCrearRol.Click
    '    UCntrlRegistrarRol1.Location = New Point(0, 0
    '    UCntrlRegistrarRol1.BringToFront()
    '    UCntrlRegistrarRol1.Show()

    '    'dgvRoles.Dispose()
    '    'PbRoles.Dispose()
    'End Sub


    Sub ListarRoles()

        Dim listaRoles As New List(Of Rol)
        listaRoles = objGestorRol.consultarRoles()

        For i As Integer = 0 To listaRoles.Count - 1

            DGVRol.Rows.Add(1)
            DGVRol.Rows(i).Cells(0).Value = listaRoles.Item(i).Nombre()
        Next

        '' dgvRol.DataSource = gestorRol.consultarRoles
    End Sub

    Private Sub ListarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarRoles()
        ''gvRoles.DataSource = gestorRol.consultarRoles
    End Sub

    'Private Sub dgvRoles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoles.CellContentClick
    '    Dim nombre As String
    '    Dim uCtrlModificarRol As New uCtrlModificarRol

    '    If e.RowIndex > 0 Then
    '        Dim row As DataGridViewRow
    '        row = Me.dgvRoles.Rows(e.RowIndex)
    '        nombre = row.Cells("dtaNombre").Value.ToString
    '        frmPrincipal.Controls.Add(uCtrlModificarRol)
    '        uCtrlModificarRol.recieveData(nombre)
    '        Location = New Point(0, 0)
    '        uCtrlModificarRol.BringToFront()
    '    End If


    'End Sub

    Private Sub modificarRol(numfila As Integer)

        Dim value1 As Object = DGVRol.Rows(numfila).Cells(0).Value

        Dim uCtrlModRol As New uCtrlModificarRol()
        uCtrlModRol.recieveData(value1)
        uCtrlModRol.txtNombre.Text = CType(value1, String)
        frmPrincipal.Controls.Add(uCtrlModRol)
        uCtrlModRol.Show()
        uCtrlModRol.BringToFront()

    End Sub

    Private Sub eliminarRol(numfila As Integer)

        Dim value1 As Object = DGVRol.Rows(numfila).Cells(0).Value

        Dim uCtrlEliRol As New uCtrlEliminarRol()
        uCtrlEliRol.recieveData(value1)
        frmPrincipal.Controls.Add(uCtrlEliRol)
        uCtrlEliRol.Show()
        uCtrlEliRol.BringToFront()

    End Sub

    Private Sub consultarRol(numfila As Integer)

        Dim value1 As Object = DGVRol.Rows(numfila).Cells(0).Value

        Dim uCtrlConsulRol As New uCntrlConsultarRol()
        uCtrlConsulRol.enseñarDatos(value1)
        uCtrlConsulRol.txtNombre.Text = CType(value1, String)
        frmPrincipal.Controls.Add(uCtrlConsulRol)
        uCtrlConsulRol.Show()
        uCtrlConsulRol.BringToFront()

    End Sub


    Private Sub DGVRol_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGVRol.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If DGVRol.CurrentCell.ColumnIndex = 3 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                ' Remove an existing event-handler, if present, to avoid 
                ' adding multiple handlers when the editing control is reused.
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf Combo_SelectionChangeCommitted)

                ' Add the event handler. 
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf Combo_SelectionChangeCommitted)
            End If
        End If
    End Sub

    Private Sub Combo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combo.SelectionChangeCommitted
        Dim combo As ComboBox = CType(sender, ComboBox)

        If combo.SelectedItem = "Editar" Then

            Dim fila As Integer = DGVRol.CurrentCell.RowIndex
            MsgBox(fila)
            modificarRol(fila)

        ElseIf combo.SelectedItem = "Eliminar" Then
            Dim fila As Integer = DGVRol.CurrentCell.RowIndex
            MsgBox(fila)
            eliminarRol(fila)

        ElseIf combo.SelectedItem = "Ver" Then
            Dim fila As Integer = DGVRol.CurrentCell.RowIndex
            MsgBox(fila)
            consultarRol(fila)


        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Sub ListarRol()

        Dim Rol As New Rol
        Rol = objGestorRol.consultarRolPorNombre(txtBuscarRol.Text)
        DGVRol.Rows.Clear()
        DGVRol.Rows.Add(1)
        DGVRol.Rows(0).Cells(0).Value = Rol.Nombre()


            '' dgvRol.DataSource = gestorRol.consultarRoles
    End Sub


    Private Sub btnCrearRoles_Click(sender As Object, e As EventArgs) Handles btnCrearRoles.Click
        uCtrlRol = New UCntrlRegistrarRol()
        frmPrincipal.Controls.Add(uCtrlRol)
        uCtrlRol.BringToFront()
        uCtrlRol.Show()
        uCtrlRol.Location = New Point(0, 0)
    End Sub

    Private Sub btnBuscarRol_Click(sender As Object, e As EventArgs) Handles btnBuscarRol.Click
        If txtBuscarRol.Text = Nothing Then
            ListarRoles()
        Else
            ListarRol()
        End If

    End Sub

    Private Sub DGVRol_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRol.CellContentClick

    End Sub
End Class
