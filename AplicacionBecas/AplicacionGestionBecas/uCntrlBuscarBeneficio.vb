﻿Imports EntitiesLayer
Imports System.Windows.Forms
Imports System.Drawing

Public Class uCntrlBuscarBeneficio

    Private Sub PantallaConsultarBeneficio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarBeneficios()

    End Sub

    ''' <summary>
    ''' Este método llama a un método en el gestor y recibe una lista de beneficios.
    ''' Llena el data grid con la lista de beneficios.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    Public Sub listarBeneficios()

        Try

        
        Dim listaBeneficios As New List(Of Beneficio)
        listaBeneficios = objGestorBeneficio.buscarBeneficios()

        dtaBuscarBeneficio.Rows.Clear()
        For i As Integer = 0 To listaBeneficios.Count - 1

            dtaBuscarBeneficio.Rows.Add(1)
            dtaBuscarBeneficio.Rows(i).Cells(0).Value = listaBeneficios.Item(i).id
            dtaBuscarBeneficio.Rows(i).Cells(1).Value = listaBeneficios.Item(i).Nombre
            dtaBuscarBeneficio.Rows(i).Cells(2).Value = listaBeneficios.Item(i).Porcentaje
            dtaBuscarBeneficio.Rows(i).Cells(3).Value = listaBeneficios.Item(i).Aplicacion
            dtaBuscarBeneficio.Columns("dtaAplicabilidad").Visible = False
            dtaBuscarBeneficio.Columns("dtaId").Visible = False

            Next i

        Catch

            MsgBox("Debe crear un beneficio")

        End Try

    End Sub
    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click
        Dim uCtrlRegistrarBeneficio As New uCtrlRegistrarBeneficio

        frmPrincipal.Controls.Add(uCtrlRegistrarBeneficio)
        uCtrlRegistrarBeneficio.getFrmBuscar(Me)
        uCtrlRegistrarBeneficio.Location = New Point(290, 48)
        uCtrlRegistrarBeneficio.BringToFront()
        uCtrlRegistrarBeneficio.Show()


    End Sub
    ''' <summary>
    ''' Este método agarra el valor seleccionado del combobox y crea un evento
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtaBuscarBeneficio_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtaBuscarBeneficio.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dtaBuscarBeneficio.CurrentCell.ColumnIndex = 4 Then
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

    ''' <summary>
    ''' Dependiendo de la seleccion del usuario, el sistema realiza diferentes acciones.
    ''' -->La opcion ver: consulta un beneficio.
    ''' -->La opcion Editar: muestra un popup, que permite editar un beneficio.
    ''' -->La opcion Eliminar: muestra una alerta que permite eliminar un beneficio.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)

        If combo.SelectedItem = "Ver" Then

            verBeneficios()

        ElseIf combo.SelectedItem = "Editar" Then

            editarBeneficios()

        ElseIf combo.SelectedItem = "Eliminar" Then

            eliminarBeneficios()

        End If

    End Sub


    ''' <summary>
    ''' Busca un beneficio dependiendo del valor del parametro
    ''' Si el parametro es NULL, entonces la lista se referesca nada mas
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim parametro As String

        parametro = txtBuscar.Text

        Try
            If parametro = Nothing Then


                listarBeneficios()

            Else

                Dim beneficio As Beneficio

                dtaBuscarBeneficio.Rows.Clear()
                beneficio = objGestorBeneficio.buscarPorNombre(parametro)

                dtaBuscarBeneficio.Rows.Add(1)

                dtaBuscarBeneficio.Rows(0).Cells(0).Value = beneficio.Id
                dtaBuscarBeneficio.Rows(0).Cells(1).Value = beneficio.Nombre
                dtaBuscarBeneficio.Rows(0).Cells(2).Value = beneficio.Porcentaje
                dtaBuscarBeneficio.Rows(0).Cells(3).Value = beneficio.Aplicacion
                dtaBuscarBeneficio.Columns("dtaAplicabilidad").Visible = False
                dtaBuscarBeneficio.Columns("dtaId").Visible = False

            End If

        Catch

            MsgBox("El beneficio no existe")

        End Try
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////
    'El ASIGNAR AHORA LO HACE MARIA, NO VA AQUI EN BENEFICIOS!!!!

    'Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click

    '    Dim uCtrlAsignarBeneficios As New uCtrlAsignarBeneficios()

    '    frmPrincipal.Controls.Add(uCtrlAsignarBeneficios)
    '    uCtrlAsignarBeneficios.BringToFront()
    '    uCtrlAsignarBeneficios.Show()
    '    uCtrlAsignarBeneficios.Location = New Point(250, 50)

    'End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////

    ''' <summary>
    ''' consulta un beneficio
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <remarks></remarks>
    Private Sub verBeneficios()
        Dim nombre As String = dtaBuscarBeneficio.CurrentRow.Cells(1).Value

        Dim uCtrlConsultarBeneficio As New uCtrlConsultarBeneficio

        uCtrlConsultarBeneficio.recibirInfo(nombre)
        frmPrincipal.Controls.Add(uCtrlConsultarBeneficio)
        uCtrlConsultarBeneficio.BringToFront()
        uCtrlConsultarBeneficio.Show()
        uCtrlConsultarBeneficio.Location = New Point(200, 150)
        Me.Hide()


    End Sub

    ''' <summary>
    ''' Edita un beneficio
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <remarks></remarks>
    Private Sub editarBeneficios()


        Dim id As Integer = dtaBuscarBeneficio.CurrentRow.Cells(0).Value
        Dim nombre As String = dtaBuscarBeneficio.CurrentRow.Cells(1).Value
        Dim porcentaje As Double = dtaBuscarBeneficio.CurrentRow.Cells(2).Value
        Dim aplicacion As String = dtaBuscarBeneficio.CurrentRow.Cells(3).Value



        Dim uCtrlModificarBeneficio As New uCtrlModificarBeneficio


        frmPrincipal.Controls.Add(uCtrlModificarBeneficio)
        uCtrlModificarBeneficio.getFrmBuscar(Me)
        uCtrlModificarBeneficio.recieveData(id, nombre, porcentaje, aplicacion)
        uCtrlModificarBeneficio.BringToFront()
        uCtrlModificarBeneficio.Show()
        uCtrlModificarBeneficio.Location = New Point(290, 48)

    End Sub


    ''' <summary>
    ''' Elimina un beneficio
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <remarks></remarks>

    Private Sub eliminarBeneficios()


        Dim id As Integer = dtaBuscarBeneficio.CurrentRow.Cells(0).Value
        Dim nombre As String = dtaBuscarBeneficio.CurrentRow.Cells(1).Value
        Dim porcentaje As Double = dtaBuscarBeneficio.CurrentRow.Cells(2).Value
        Dim aplicacion As String = dtaBuscarBeneficio.CurrentRow.Cells(3).Value

        Dim uCtrlEliminarBeneficio As New uCtrlEliminarBeneficio

        frmPrincipal.Controls.Add(uCtrlEliminarBeneficio)
        uCtrlEliminarBeneficio.getUCtrlInstance(Me)
        uCtrlEliminarBeneficio.recibirInfo(id, nombre, porcentaje, aplicacion)
        uCtrlEliminarBeneficio.BringToFront()
        uCtrlEliminarBeneficio.Show()
        uCtrlEliminarBeneficio.Location = New Point(290, 48)

        dtaBuscarBeneficio.Rows.Clear()
        listarBeneficios()

    End Sub


End Class
