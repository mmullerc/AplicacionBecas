Imports EntitiesLayer

Public Class uCtrlConsultarBeneficio

    Dim nombre As String


    Private Sub uCtrlConsultarBeneficio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim beneficio As Beneficio

        dtaConsultarBeneficio.Rows.Clear()
        beneficio = objGestorBeneficio.buscarPorNombre(nombre)

        dtaConsultarBeneficio.Rows.Add(1)

        dtaConsultarBeneficio.Rows(0).Cells(0).Value = beneficio.id
        dtaConsultarBeneficio.Rows(0).Cells(1).Value = beneficio.Nombre
        dtaConsultarBeneficio.Rows(0).Cells(2).Value = beneficio.Porcentaje
        dtaConsultarBeneficio.Rows(0).Cells(3).Value = beneficio.Aplicacion
        'dtaConsultarBeneficio.Columns("dtaAplicabilidad").Visible = False
        dtaConsultarBeneficio.Columns("dtaId").Visible = False

    End Sub

    Public Sub recibirInfo(ByVal pnombre As String)

        nombre = pnombre

    End Sub


    Private Sub pctbxBeneficios_Click(sender As Object, e As EventArgs) Handles pctbxBeneficios.Click

    End Sub
End Class
