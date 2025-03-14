Imports Entidades.Commons

Public Class FrmCompany
    Private _emisor As Company

    Sub New(emisor As Company)
        _emisor = emisor
        InitializeComponent()
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTipo.Text = _emisor.TipDocIdentidad & " - " & _emisor.NomDocIdentidad
        TxtNumero.Text = _emisor.NumDocIdentidad
        TxtRazonSocial.Text = _emisor.RazonSocial
        TxtNombreComercial.Text = _emisor.NombreComercial

        TxtDireccion.Text = _emisor.Direccion.Direccion
        TxtUbigeo.Text = _emisor.Direccion.Ubigeo
        Txtdistrito.Text = _emisor.Direccion.Distrito & " - " & _emisor.Direccion.Provincia & " - " & _emisor.Direccion.Departamento
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
End Class